//*****************************************************************************
//
//  システム名：宅食業 販売管理システム
//
//  Copyright 株式会社スプレッド 2022 All rights reserved.
//
//-----------------------------------------------------------------------------
//  変更履歴:
//  Ver      日付        担当       コメント
//  0.0      2022/06/08  A.Satou    新規作成
#region 更新履歴
#endregion
//*****************************************************************************

using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

namespace CloverusCommon.Database
{
    /// <summary>
    /// データベース処理クラス
    /// </summary>
    public class SqlBase : IDisposable
    {
        #region 定数
        /// <summary>
        /// トランザクション使用有無
        /// </summary>
        public enum TransactionUse
        {
            /// <summary>
            /// トランザクションを使用する
            /// </summary>
            Yes,
            /// <summary>
            /// トランザクションを使用しない
            /// </summary>
            No
        }

        /// <summary>
        /// データベース種別
        /// </summary>
        public enum DatabaseKind
        {
            /// <summary>
            /// SYSTEM
            /// </summary>
            SYSTEM,
            /// <summary>
            /// USER
            /// </summary>
            USER,
        }

        private const int TIMEOUT_VALUE = 120;
        #endregion

        #region メンバ変数
        private bool _disposed { get; set; } = false;
        private SqlConnection _connection { get; set; } = null;
        private SqlTransaction _transaction { get; set; } = null;
        private int _registCount { get; set; } = 0;
        //private Log.ApplicationType _applicationType { get; set; }
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="databaseKind"></param>
        /// <param name="transatctionUse"></param>
        public SqlBase(DatabaseKind databaseKind, TransactionUse transatctionUse)
        {
            //// iniファイルからデータベース接続文字列を取得する
            //var settings = new IniFile.Settings();
            //// データベースを切り替える
            //var catalog = string.Empty;
            //switch (databaseKind)
            //{
            //    case DatabaseKind.NPMAIN:
            //        catalog = settings.Database.NpMain;
            //        break;
            //    case DatabaseKind.IOSSUP:
            //        catalog = settings.Database.IosSup;
            //        break;
            //    case DatabaseKind.ORDER:
            //        catalog = settings.Database.NpOrder;
            //        break;
            //    case DatabaseKind.SUPERVISOR:
            //        catalog = settings.Database.SuperVisor;
            //        break;
            //}
            var catalog = "Password=cps_pwd2000;Persist Security Info=True;User ID=sa;Initial Catalog=SMILEX1001;Data Source=PC-ASAHINA,1432";
            // コネクションを開く
            _connection = new SqlConnection(catalog);
            _connection.Open();
            if (transatctionUse == TransactionUse.Yes)
            {
                _transaction = _connection.BeginTransaction();
            }
            _registCount = 0;
            //_applicationType = applicationType;
        }
        #endregion

        #region ディスポーザ
        /// <summary>
        /// ディスポーザ
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        /// <summary>
        /// ディスポーザ
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (_transaction != null)
                {
                    // 更新処理を行った後、commitもrollbackもされていない時はrollbackする
                    if (_registCount > 0)
                    {
                        _transaction.Rollback();
                    }
                    _transaction.Dispose();
                    _transaction = null;
                }
                if (disposing)
                {
                    _connection.Close();
                }
                _disposed = true;
            }
        }
        #endregion

        #region デストラクタ
        /// <summary>
        /// デストラクタ
        /// </summary>
        ~SqlBase()
        {
            Dispose(false);
        }
        #endregion

        #region public functions

        #region トランザクション処理
        /// <summary>
        /// トランザクションのコミット
        /// </summary>
        public void Commit()
        {
            if (_transaction != null)
            {
                _transaction.Commit();
                _registCount = 0;
            }
        }

        /// <summary>
        /// トランザクションのロールバック
        /// </summary>
        public void Rollback()
        {
            if (_transaction != null)
            {
                _transaction.Rollback();
                _registCount = 0;
            }
        }
        #endregion

        #region Sqlパラメータ作成
        /// <summary>
        /// Sqlパラメータを作成する
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static SqlParameter ToSqlParam(ParameterItem item)
        {
            return new SqlParameter(item.Key, item.Value);
        }
        #endregion

        public static List<SqlParameter> ToSqlParams(List<ParameterItem> SqlParameters)
        {
            var result = new List<SqlParameter>();
            foreach (var item in SqlParameters)
            {
                result.Add(ToSqlParam(item));
            }
            return result;
        }

        #region 更新系クエリ実行
        /// <summary>
        /// クエリ実行
        /// （更新系）
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public int Execute(string sql, List<ParameterItem> parameters = null)
        {
            return Execute(sql, ToSqlParams(parameters));
        }
        #endregion

        #region 更新系クエリ実行
        /// <summary>
        /// クエリ実行
        /// （更新系）
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public int Execute(string sql, List<SqlParameter> parameters = null)
        {

            var result = -1;
            using (SqlCommand cmd = new SqlCommand(sql, _connection))
            {
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.Add(param);
                    }
                }
                cmd.Transaction = _transaction;
                result = cmd.ExecuteNonQuery();
            }
            _registCount += result;
            return result;
        }
        #endregion

        #region 参照クエリ実行
        /// <summary>
        /// Select SQL 実行
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable Select(string sql, List<ParameterItem> parameters = null)
        {
            var dt = new DataTable();
            //using (var command = _connection.CreateCommand())
            //{
            //    command.CommandText = sqlString;
            //    var adapter = new SqlDataAdapter(command);
            //    adapter.Fill(dt);
            //}
            using (var cmd = new SqlCommand(sql, _connection))
            {
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }
                cmd.Transaction = _transaction;
                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
            //Log.Write(Sentence.Messages.SelectedDatabase, _applicationType, sql);
            return dt;
        }

        /// <summary>
        /// Select SQL 実行
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable Select(StringBuilder sql, List<ParameterItem> parameters = null)
        {
            return Select(sql.ToString(), parameters);
        }
        #endregion

        #endregion
    }
}
