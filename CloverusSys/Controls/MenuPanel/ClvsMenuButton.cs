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
using System.ComponentModel.DataAnnotations;
using CloverusCommon;
using SprCommon;
#endregion

namespace CloverusSys.Controls.MenuPanel
{
    public partial class ClvsMenuButton : UserControl
    {
        #region 定数

        #region メニュー定義
        /// <summary>
        /// メニュー定義
        /// </summary>
        public enum MenuItems
        {
            /// <summary>
            /// 予定登録
            /// </summary>
            [Display(Description = "予定登録")]
            EntrySchedule,

            /// <summary>
            /// 予定作成（全件）
            /// </summary>
            [Display(Description = "予定作成（全件）")]
            SchedulingAll,

            /// <summary>
            /// 予定生成（個別）
            /// </summary>
            [Display(Description = "予定生成（個別）")]
            SchedulingIndividual,

            /// <summary>
            /// 予定修正・確認
            /// </summary>
            [Display(Description = "予定修正・確認")]
            ScheduleChange,

            /// <summary>
            /// 請求先設定
            /// </summary>
            [Display(Description = "請求先設定")]
            BillingSetting,

            /// <summary>
            /// 請求先設定キャンセル
            /// </summary>
            [Display(Description = "請求先設定キャンセル")]
            CancelBilling,

            /// <summary>
            /// 請求締日更新
            /// </summary>
            [Display(Description = "請求締日更新")]
            UpdateClosingDate,

            /// <summary>
            /// 請求締日更新取消（一括）
            /// </summary>
            [Display(Description = "請求締日更新取消（一括）")]
            CancelClosingDateAll,

            /// <summary>
            /// 請求締日更新取消（個別）
            /// </summary>
            [Display(Description = "請求締日更新取消（個別）")]
            CancelClosingDateIndividual,

            /// <summary>
            /// 入金処理（締請求）
            /// </summary>
            [Display(Description = "入金処理（締請求）")]
            PaymentByClosing,

            /// <summary>
            /// 入金処理（都度回収）
            /// </summary>
            [Display(Description = "入金処理（都度回収）")]
            PaymentByEachTime,

            /// <summary>
            /// 売上生成（全件）
            /// </summary>
            [Display(Description = "売上生成（全件）")]
            SalesGenerationAll,

            /// <summary>
            /// 売上生成処理（個別）
            /// </summary>
            [Display(Description = "売上生成処理（個別）")]
            SalesGenerationIndividual,

            /// <summary>
            /// 未請求チェック
            /// </summary>
            [Display(Description = "未請求チェック")]
            UnbilledCheck,

            /// <summary>
            /// サブルートマスター
            /// </summary>
            [Display(Description = "サブルートマスター")]
            SubRootMaster,

            /// <summary>
            /// ルートマスター
            /// </summary>
            [Display(Description = "ルートマスター")]
            RootMaster,

            /// <summary>
            /// ルート変更
            /// </summary>
            [Display(Description = "ルート変更")]
            ChangeRoot,

            /// <summary>
            /// 金融機関マスター
            /// </summary>
            [Display(Description = "金融機関マスター")]
            FinancialInstitutionMaster,

            /// <summary>
            /// 金融機関支店マスター
            /// </summary>
            [Display(Description = "金融機関支店マスター")]
            FinancialInstitutionBranchMaster,

            /// <summary>
            /// 顧客マスター
            /// </summary>
            [Display(Description = "顧客マスター")]
            CustomerMaster,

            /// <summary>
            /// 顧客分類マスター
            /// </summary>
            [Display(Description = "顧客分類マスター")]
            CustomerClassMaster,

            /// <summary>
            /// 種類マスター
            /// </summary>
            [Display(Description = "種類マスター")]
            KindMaster,

            /// <summary>
            /// 定期パターンマスター
            /// </summary>
            [Display(Description = "定期パターンマスター")]
            RegularPatternMaster,

            /// <summary>
            /// 配送先マスター
            /// </summary>
            [Display(Description = "配送先マスター")]
            ShippingMaster,

            /// <summary>
            /// 郵送記号マスター
            /// </summary>
            [Display(Description = "郵送記号マスター")]
            MailingCodeMaster,

            /// <summary>
            /// 休日設定管理
            /// </summary>
            [Display(Description = "休日設定管理")]
            HolidaySetting,

            /// <summary>
            /// 月別支援型数量
            /// </summary>
            [Display(Description = "月別支援型数量")]
            MontlySupportQuantity,

            /// <summary>
            /// 顧客別請求一覧表
            /// </summary>
            [Display(Description = "顧客別請求一覧表")]
            ClaimList,

            /// <summary>
            /// 顧客別入金一覧表（締請求）
            /// </summary>
            [Display(Description = "顧客別入金一覧表（締請求）")]
            PaymentListByClosing,

            /// <summary>
            /// 顧客別入金一覧表（都度回収）
            /// </summary>
            [Display(Description = "顧客別入金一覧表（都度回収）")]
            PaymentListByEachTime,

            /// <summary>
            /// 請求書発行（口振用）
            /// </summary>
            [Display(Description = "請求書発行（口振用）")]
            Invoice,

            /// <summary>
            /// 請求明細書（都度回収）
            /// </summary>
            [Display(Description = "請求明細書（都度回収）")]
            InvoiceDetailList,

            /// <summary>
            /// 繰越明細書
            /// </summary>
            [Display(Description = "繰越明細書")]
            PrintCarryDetail,

            /// <summary>
            /// 領収書
            /// </summary>
            [Display(Description = "領収書")]
            Receipt,

            /// <summary>
            /// 領収書（都度回収）
            /// </summary>
            [Display(Description = "領収書（都度回収）")]
            ReceiptIndividual,

            /// <summary>
            /// 配送表
            /// </summary>
            [Display(Description = "配送表")]
            ShippingTable,

            /// <summary>
            /// 売上金額確認表
            /// </summary>
            [Display(Description = "売上金額確認表")]
            SalesConfirmation,

            /// <summary>
            /// 定期パターンリスト
            /// </summary>
            [Display(Description = "定期パターンリスト")]
            RegularPatternList,

            /// <summary>
            /// 予定・売上差額チェックリスト
            /// </summary>
            [Display(Description = "予定・売上差額チェックリスト")]
            DifferenceCheckList,

            /// <summary>
            /// 予定金額集計表
            /// </summary>
            [Display(Description = "予定金額集計表")]
            ScheduledAggregationMoneyList,

            /// <summary>
            /// 予定数量集計表
            /// </summary>
            [Display(Description = "予定数量集計表")]
            ScheduledAggregationQuantityList,

            /// <summary>
            /// 予定明細確認リスト
            /// </summary>
            [Display(Description = "予定明細確認リスト")]
            ScheduledItemList,

            /// <summary>
            /// カード
            /// </summary>
            [Display(Description = "カード")]
            Card,

            /// <summary>
            /// 種類別ルート別集計表
            /// </summary>
            [Display(Description = "種類別ルート別集計表")]
            KindRootList,

            /// <summary>
            /// ごはん量集計表（ルート別、集計表）
            /// </summary>
            [Display(Description = "ごはん量集計表（ルート別、集計表）")]
            RiceQuantityRootList,

            /// <summary>
            /// おかず量集計表
            /// </summary>
            [Display(Description = "おかず量集計表")]
            DishQuantityList,

            /// <summary>
            /// 種類別集計表（容器数）
            /// </summary>
            [Display(Description = "種類別集計表（容器数）")]
            KindList,

            /// <summary>
            /// カロリー調整表
            /// </summary>
            [Display(Description = "カロリー調整表")]
            CalorieList,

            /// <summary>
            /// たんぱく食一覧
            /// </summary>
            [Display(Description = "たんぱく食一覧")]
            Protein,

            /// <summary>
            /// ムース食一覧
            /// </summary>
            [Display(Description = "ムース食一覧")]
            Mousse,

            /// <summary>
            /// ごはん量集計表（釜数シミュレーション）
            /// </summary>
            [Display(Description = "ごはん量集計表（釜数シミュレーション）")]
            RiceQuantityCauldronList,
        }
        #endregion

        #endregion

        #region プロパティ
        public MenuItems MenuItem { get; set; }
        /// <summary>
        /// ボタン文字
        /// </summary>
        public string Caption
        {
            get { return BtnItem.Text; }
            set { BtnItem.Text = value; }
        }
        /// <summary>
        /// 背景色
        /// </summary>
        public Color ButtonBackColor
        {
            get { return BtnItem.BackColor; }
            set { BtnItem.BackColor = value; }
        }
        #endregion

        public ClvsMenuButton()
        {
            InitializeComponent();
        }

        /// <summary>
        /// アプリケーション種別文言の取得
        /// </summary>
        /// <param name="applicationType"></param>
        /// <returns></returns>
        public static string MenuText(MenuItems menuItemType)
        {
            return menuItemType.GetApplied<DisplayAttribute>().First().Description;
        }

        private void BtnItem_Click(object sender, EventArgs e)
        {
            OpenForm(this.MenuItem);
        }

        private static void OpenForm(MenuItems menuItem)
        {
            switch (menuItem)
            {
                case MenuItems.CustomerMaster:
                    var frm = new MasterMaintenance.Customers.Edit(0);
                    frm.Show();
                    break;
            }
        }
    }
}
