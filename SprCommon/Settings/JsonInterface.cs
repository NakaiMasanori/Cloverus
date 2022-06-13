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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprCommon.Settings
{
    public class JsonInterface : IDisposable
    {
        #region 定数
        #endregion

        #region メンバ変数
        private bool _disposed { get; set; } = false;
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="databaseKind"></param>
        /// <param name="transatctionUse"></param>
        public JsonInterface()
        {
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
        ~JsonInterface()
        {
            Dispose(false);
        }
        #endregion

        #region public functions

        #endregion
    }
}
