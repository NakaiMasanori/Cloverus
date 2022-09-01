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
    public partial class SprDateTimePicker : UserControl
    {
        #region 定数
        /// <summary>
        /// 過去日付の入力を認めるか否か
        /// </summary>
        public enum PastDateType
        {
            /// <summary>
            /// 過去日付の入力を認める
            /// </summary>
            Enabled,
            /// <summary>
            /// 過去日付の入力を認めない
            /// </summary>
            Disabled,
            /// <summary>
            /// 10日前まで認める
            /// </summary>
            EnabledOverTenDays,
        }
        #endregion

        #region プロパティ
        /// <summary>
        /// フォント
        /// </summary>
        public override Font Font
        {
            get { return DatePicker.Font; }
            set { DatePicker.Font = value; }
        }
        /// <summary>
        /// 設定値
        /// </summary>
        public DateTime Value
        {
            get { return DatePicker.Value; }
            set { DatePicker.Value = value; }
        }
        /// <summary>
        /// 最大日付
        /// </summary>
        public DateTime MaxDate
        {
            get { return DatePicker.MaxDate; }
            set { DatePicker.MaxDate = value; }
        }
        /// <summary>
        /// 最小日付
        /// </summary>
        public DateTime MinDate
        {
            get { return DatePicker.MinDate; }
            set { DatePicker.MinDate = value; }
        }
        /// <summary>
        /// 過去日付を認めるか否か
        /// </summary>
        public PastDateType PastDate
        {
            set
            {
                switch (value)
                {
                    case PastDateType.Enabled:
                        DatePicker.MinDate = DateTime.Now;
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        #region イベント定義
        public event EventHandler ValueChanged;
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public SprDateTimePicker()
        {
            InitializeComponent();
        }
        #endregion

        #region イベント
        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (this.ValueChanged != null)
            {
                ValueChanged(this, e);
            }
        }
        #endregion
    }
}
