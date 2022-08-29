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
    public partial class SprDateText : UserControl
    {
        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public SprDateText()
        {
            InitializeComponent();
        }
        #endregion

        #region プロパティ     
        /// <summary>
        /// コントロールと紐づくデータベースのカラム
        /// </summary>
        public string TableColumn
        {
            get;
            set;
        }
        /// <summary>
        /// タイトル
        /// </summary>
        public string TitleText
        {
            get { return LblTitle.Text; }
            set { LblTitle.Text = value; }
        }
        /// <summary>
        /// タイトル部の幅
        /// </summary>
        public int TitleWidth
        {
            get { return LblTitle.Width; }
            set { LblTitle.Width = value; }
        }
        /// <summary>
        /// 値
        /// </summary>
        public int TextValue
        {
            get
            {
                var val = DatePicker.Value;
                return val.Year * 10000 + val.Month * 100 + val.Day;
            }
            set
            {
                var val = value.ToString();
                if (!string.IsNullOrEmpty(val) && value > 0)
                {
                    DatePicker.Value = new DateTime(int.Parse(val.Substring(0, 4)), int.Parse(val.Substring(4, 2)), int.Parse(val.Substring(6, 2)));
                }
            }
        }
        /// <summary>
        /// テキストボックス部の幅
        /// </summary>
        public int TextBoxWidth
        {
            get { return DatePicker.Width; }
            set { DatePicker.Width = value; }
        }
        #endregion

        #region public functions
        #region データベースの値をコントロールにセット
        /// <summary>
        /// データベースの値をコントロールにセット
        /// </summary>
        /// <param name="row"></param>
        public void SetFromDb(DataRow row)
        {
            if (!string.IsNullOrEmpty(TableColumn) && row.Table.Columns.Contains(TableColumn))
            {
                TextValue = row[TableColumn] != null ? int.Parse(row[TableColumn].ToString()) : 0;
            }
        }
        #endregion
        #endregion

    }
}
