using CloverusCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CloverusSys.Controls.MenuPanel
{
    public class MenuControl
    {
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
        }
    }
}
