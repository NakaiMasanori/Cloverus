//*****************************************************************************
//
//  システム名：共通クラス
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
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.IO;
using System.Windows.Forms;

namespace SprSettings
{
    public class Interface : IDisposable
    {
        #region 定数
        #endregion

        #region 値格納クラス
        public class Settings
        {
            #region プロパティ
            /// <summary>
            /// データベース定義
            /// </summary>
            public Sections.Database Database { get; set; }
            #endregion

            #region コンストラクタ
            /// <summary>
            /// コンストラクタ
            /// </summary>
            public Settings()
            {
                Database = new Sections.Database();
            }
            #endregion

        }
        #endregion

        #region プロパティ
        private bool _disposed { get; set; } = false;
        public Settings Setting { get; set; }
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="databaseKind"></param>
        /// <param name="transatctionUse"></param>
        public Interface()
        {
            Setting = new Settings();
            var appPath = Path.GetDirectoryName(Application.ExecutablePath);
            using (var sr = new StreamReader(Path.Combine(appPath, "SprSettings.json"), Encoding.GetEncoding("utf-8")))
            {
                var data = sr.ReadToEnd();
                Setting = JsonSerializer.Deserialize<Settings>(data);
            }
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
                if (disposing)
                {
                }
                _disposed = true;
            }
        }
        #endregion

        #region デストラクタ
        /// <summary>
        /// デストラクタ
        /// </summary>
        ~Interface()
        {
            Dispose(false);
        }
        #endregion

        #region public functions

        /// <summary>
        /// 書き込み
        /// （初期データ作成用）
        /// </summary>
        public static void Write()
        {
            var setting = new Settings();
            setting.Database.ConnectionString = "Password=cps_pwd2000;Persist Security Info=True;User ID=sa;Initial Catalog=SMILEX1001;Data Source=PC-ASAHINA,1432";
            var jsonStr = JsonSerializer.Serialize(setting);
            var appPath = Path.GetDirectoryName(Application.ExecutablePath);
            using (var sw = new StreamWriter(Path.Combine(appPath, "SprSettings.json")))
            {
                sw.WriteLine(jsonStr);
            }
        }
        #endregion
    }
}
