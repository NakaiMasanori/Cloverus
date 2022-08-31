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
    public partial class SprCheckBox : UserControl
    {
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
        /// チェックボックスのテキスト
        /// </summary>
        public string CheckBoxText
        {
            get { return ChkBox.Text; }
            set { ChkBox.Text = value; }
        }
        /// <summary>
        /// チェックボックスのチェック
        /// </summary>
        public bool Value
        {
            get { return ChkBox.Checked; }
            set { ChkBox.Checked = value; }
        }
        /// <summary>
        /// タイトルの背景色
        /// </summary>
        public Color TitleBackColor
        {
            get { return LblTitle.BackColor; }
            set { LblTitle.BackColor = value; }
        }
        /// <summary>
        /// タイトルの文字色
        /// </summary>
        public Color TitleForeColor
        {
            get { return LblTitle.ForeColor; }
            set { LblTitle.ForeColor = value; }
        }
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public SprCheckBox()
        {
            InitializeComponent();
        }
        #endregion
    }
}
