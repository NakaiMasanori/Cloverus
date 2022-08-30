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
using SprCommon;
#endregion

namespace CloverusCommon.Controls
{
    public partial class ClvsSendNameBox : UserControl
    {
        #region プロパティ
        /// <summary>
        /// 郵便番号のタイトル
        /// </summary>
        public string TitleText
        {
            get { return LblTitle.Text; }
            set { LblTitle.Text = value; }
        }
        /// <summary>
        /// 宛名(1)
        /// </summary>
        public string TextValueUpper
        {
            get { return TxtUpper.Text; }
            set { TxtUpper.Text = value; }
        }
        /// <summary>
        /// 宛名(2)
        /// </summary>
        public string TextValueLower
        {
            get { return TxtLower.Text; }
            set { TxtLower.Text = value; }
        }
        /// <summary>
        /// 宛名(1)のデータベースカラム
        /// </summary>
        public string TableColumnUpper { get; set; }
        /// <summary>
        /// 宛名(2)のデータベースカラム
        /// </summary>
        public string TableColumnLower { get; set; }
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ClvsSendNameBox()
        {
            InitializeComponent();
        }
        #endregion
    }
}
