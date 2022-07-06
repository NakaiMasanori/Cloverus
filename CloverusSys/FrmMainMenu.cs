//*****************************************************************************
//
//  システム名：宅食業販売管理システム
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
using System.Windows.Forms;
#endregion

namespace CloverusSys
{
    /// <summary>
    /// メインメニュー
    /// </summary>
    public partial class FrmMainMenu : Form
    {
        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FrmMainMenu()
        {
            InitializeComponent();
            InitializeForm();
        }
        #endregion

        #region イベント
        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            var frm = new MasterMaintenance.Customers.Preview();
            frm.ShowDialog();
        }
        private void BtnSalesCreation_Click(object sender, EventArgs e)
        {

            var frm = new DailyWorks.FrmClosing();
            frm.ShowDialog();
        }
        #endregion

        #region private functions
        /// <summary>
        /// ダイアログ初期化
        /// </summary>
        private void InitializeForm()
        {
            // イベント登録
            this.BtnCustomers.Click += new EventHandler(this.BtnCustomers_Click);
            this.BtnSalesCreation.Click += new EventHandler(this.BtnSalesCreation_Click);
        }
        #endregion
    }
}
