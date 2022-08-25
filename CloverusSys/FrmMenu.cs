//*****************************************************************************
//
//  システム名：オリジナル販売管理システム
//
//  Copyright 株式会社クローバス 2022 All rights reserved.
//
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
            /// 帳票出力
            /// </summary>
            Report,
        }

        public FrmMenu()
        {
            InitializeComponent();
            InitializeForm();
        }

        #region イベント
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
        private void BtnReport_Click(object sender, EventArgs e)
        {
            MainMenuChanged(MainMenuType.Report);
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
            PnlReport.Dock = DockStyle.Fill;
            // 基本業務を選んだ状態で開く
            MainMenuChanged(MainMenuType.BasicBusiness);
            // イベント登録
            this.BtnBasicBusiness.Click += new EventHandler(this.BtnBasicBusiness_Click);
            this.BtnBillingBusiness.Click += new EventHandler(this.BtnBillingBusiness_Click);
            this.BtnAdministrativeTask.Click += new EventHandler(this.BtnAdministrativeTask_Click);
            this.BtnReport.Click += new EventHandler(this.BtnReport_Click);
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
            PnlReport.Visible = false;
            switch (selectedMenu)
            {
                case MainMenuType.BasicBusiness:
                    PnlBasicBusiness.Visible = true;
                    PnlBasicBusiness.Preview();
                    break;
                case MainMenuType.BillingBusiness:
                    PnlBillingBusiness.Visible = true;
                    break;
                case MainMenuType.AdministrativeTask:
                    PnlAdministrativeTask.Visible = true;
                    break;
                case MainMenuType.Report:
                    PnlReport.Visible = true;
                    break;
            }
        }
        #endregion

    }
}
