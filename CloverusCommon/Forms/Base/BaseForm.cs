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
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using SprCommon;
#endregion

namespace CloverusCommon.Forms.Base
{
    public partial class BaseForm : Form
    {
        #region 定数

        public enum FontSize
        {
            /// <summary>
            /// 大
            /// </summary>
            [Display(Description = "大")]
            Large,
            /// <summary>
            /// 中
            /// </summary>
            [Display(Description = "中")]
            Middle,
            /// <summary>
            /// 小
            /// </summary>
            [Display(Description = "小")]
            Small,
        }
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public BaseForm()
        {
            InitializeComponent();
        }
        #endregion

        #region public functions

        public void InitializeGridView(DataGridView dgv, FontSize fontSize)
        {
            // 隔行着色
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            // フォントサイズ
            var currentSize = (float)10.0;
            switch (fontSize)
            {
                case FontSize.Large:
                    currentSize = (float)12.0;
                    break;
                case FontSize.Middle:
                    // 初期値のまま
                    break;
                case FontSize.Small:
                    currentSize = (float)8.0;
                    break;
            }
            dgv.Font = new Font(dgv.Font.Name, currentSize);
        }

        #region 閉店処理の時の終了日を算出する
        /// <summary>
        /// 閉店処理の時の終了日を算出する
        /// </summary>
        /// <param name="today"></param>
        /// <returns></returns>
        public DateTime NextBusinessDay(DateTime today)
        {
            var nextday = today.AddDays(2);
            switch (nextday.DayOfWeek)
            {
                case DayOfWeek.Saturday:
                    nextday = nextday.AddDays(2);
                    break;
                case DayOfWeek.Sunday:
                    nextday = nextday.AddDays(1);
                    break;
            }
            return nextday;
        }
        #endregion

        #region ログ出力

        /// <summary>
        /// ログ出力
        /// </summary>
        /// <param name="MessageId"></param>
        public void PutLog(Sentence.Messages MessageId, object[] addtionalInfo = null, bool displayDialog = false)
        {
            Log.Write(MessageId, Log.ApplicationType.CloverusSys, addtionalInfo);
            if (displayDialog)
            {
                Messages.ShowDialog(MessageId, addtionalInfo);
            }
        }

        /// <summary>
        /// ログ出力
        /// </summary>
        /// <param name="MessageId"></param>
        public void PutLog(Sentence.Messages MessageId, string addtionalInfo, bool displayDialog = false)
        {
            Log.Write(MessageId, Log.ApplicationType.CloverusSys, addtionalInfo);
            if (displayDialog)
            {
                Messages.ShowDialog(MessageId, addtionalInfo);
            }
        }

        /// <summary>
        /// 例外エラー時のログ出力
        /// </summary>
        /// <param name="MessageId"></param>
        public void PutLog(Exception ex, bool displayDialog = true)
        {
            Log.Write(Sentence.Messages.Exception, Log.ApplicationType.CloverusSys, ex.Message);
            if (displayDialog)
            {
                Messages.ShowDialog(Sentence.Messages.Exception, ex.Message);
            }
        }
        #endregion

        #endregion

    }
}
