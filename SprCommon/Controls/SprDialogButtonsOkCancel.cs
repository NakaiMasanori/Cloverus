//*****************************************************************************
//
//  システム名：汎用ライブラリ SprCommon
//
//  Copyright 株式会社スプレッド 2022 All rights reserved.
//
//-----------------------------------------------------------------------------
//  変更履歴:
//  Ver      日付        担当       コメント
//  0.0      2022/12/31  A.Satou    新規作成
#region 更新履歴
#endregion
//*****************************************************************************

#region using defines
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace SprCommon.Controls
{
    public partial class SprDialogButtonsOkCancel : UserControl
    {
        public event EventHandler AcceptClick;
        public event EventHandler CancelClick;

        #region プロパティ
        /// <summary>
        /// OKボタン
        /// </summary>
        public Button AcceptButton
        {
            get { return BtnOk; }
        }
        /// <summary>
        /// キャンセルボタン
        /// </summary>
        public Button CancelButton
        {
            get { return BtnCancel; }
        }
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public SprDialogButtonsOkCancel()
        {
            InitializeComponent();
        }
        #endregion

        #region イベント
        /// <summary>
        /// OKクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (AcceptClick == null)
            {
                return;
            }
            AcceptClick(this, e);
        }
        /// <summary>
        /// キャンセルクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (CancelClick == null)
            {
                return;
            }
            CancelClick(this, e);
        }
        #endregion
    }
}
