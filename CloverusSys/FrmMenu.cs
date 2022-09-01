//*****************************************************************************
//
//  システム名：宅食業販売管理システム CloverusSys
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

namespace CloverusSys
{
    public partial class FrmMenu : Base.BaseForm
    {
        #region 定数
        /// <summary>
        /// メニュータイプ
        /// </summary>
        private enum MainMenuType
        {
            /// <summary>
            /// 基本業務
            /// </summary>
            BasicBusiness,
            /// <summary>
            /// 請求業務
            /// </summary>
            BillingBusiness,
            /// <summary>
            /// 管理業務
            /// </summary>
            AdministrativeTask,
            /// <summary>
            /// 閉店業務
            /// </summary>
            CloseBusiness,
        }
        #endregion

        #region メンバ変数
        /// <summary>
        /// 選択中のメニュー
        /// </summary>
        private MainMenuType selectedMenuType;
        #endregion

        public FrmMenu()
        {
            InitializeComponent();
            InitializeForm();
        }

        #region イベント
        /// <summary>
        /// キー押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMenu_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.F1:
                        // 基本業務
                        BtnBasicBusiness.Focus();
                        BtnBasicBusiness.PerformClick();
                        break;
                    case Keys.F2:
                        // 請求業務
                        BtnBillingBusiness.Focus();
                        BtnBillingBusiness.PerformClick();
                        break;
                    case Keys.F3:
                        // 管理業務
                        BtnAdministrativeTask.Focus();
                        BtnAdministrativeTask.PerformClick();
                        break;
                    case Keys.F4:
                        // 帳票出力
                        BtnClosing.Focus();
                        BtnClosing.PerformClick();
                        break;
                }
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }
        /// <summary>
        /// 基本業務
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBasicBusiness_Click(object sender, EventArgs e)
        {
            MainMenuChanged(MainMenuType.BasicBusiness);
        }
        /// <summary>
        /// 請求業務
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBillingBusiness_Click(object sender, EventArgs e)
        {
            MainMenuChanged(MainMenuType.BillingBusiness);
        }
        /// <summary>
        /// 管理業務
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdministrativeTask_Click(object sender, EventArgs e)
        {
            MainMenuChanged(MainMenuType.AdministrativeTask);
        }
        /// <summary>
        /// 帳票出力
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClosing_Click(object sender, EventArgs e)
        {
            MainMenuChanged(MainMenuType.CloseBusiness);
        }
        #endregion

        #region private function
        /// <summary>
        /// 画面初期化
        /// </summary>
        private void InitializeForm()
        {
            CloverusSys.Controls.Func.InitControls(this.Controls);
            // サブメニューをパネルいっぱいに表示
            PnlBasicBusiness.Dock = DockStyle.Fill;
            PnlBillingBusiness.Dock = DockStyle.Fill;
            PnlAdministrativeTask.Dock = DockStyle.Fill;
            PnlCloseBusiness.Dock = DockStyle.Fill;
            // 基本業務を選んだ状態で開く
            MainMenuChanged(MainMenuType.BasicBusiness);
            // イベント登録
            this.BtnBasicBusiness.Click += new EventHandler(this.BtnBasicBusiness_Click);
            this.BtnBillingBusiness.Click += new EventHandler(this.BtnBillingBusiness_Click);
            this.BtnAdministrativeTask.Click += new EventHandler(this.BtnAdministrativeTask_Click);
            this.BtnClosing.Click += new EventHandler(this.BtnClosing_Click);
        }
        /// <summary>
        /// メインメニュー選択処理
        /// </summary>
        /// <param name="selectedMenu"></param>
        private void MainMenuChanged(MainMenuType selectedMenu)
        {
            PnlBasicBusiness.Visible = false;
            PnlBillingBusiness.Visible = false;
            PnlAdministrativeTask.Visible = false;
            PnlCloseBusiness.Visible = false;
            switch (selectedMenu)
            {
                case MainMenuType.BasicBusiness:
                    PnlBasicBusiness.Visible = true;
                    break;
                case MainMenuType.BillingBusiness:
                    PnlBillingBusiness.Visible = true;
                    break;
                case MainMenuType.AdministrativeTask:
                    PnlAdministrativeTask.Visible = true;
                    break;
                case MainMenuType.CloseBusiness:
                    PnlCloseBusiness.Visible = true;
                    break;
            }
            selectedMenuType = selectedMenu;
        }
        #endregion

    }
}
