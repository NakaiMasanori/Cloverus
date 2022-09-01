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
using System.Xml.Linq;
#endregion

namespace SprCommon.Controls
{
    public partial class SprCodeName : UserControl
    {

        #region プロパティ
        /// <summary>
        /// コントロールと紐づくデータベースのカラム
        /// </summary>
        public string TableColumnCode
        {
            get;
            set;
        }
        public string TableColumnName
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
        public string CodeValue
        {
            get { return TxtCode.Text; }
            set { TxtCode.Text = value; }
        }
        public string NameValue
        {
            get { return LblName.Text; }
            set { LblName.Text = value; }
        }
        /// <summary>
        /// IMEモード
        /// </summary>
        public ImeMode TextImeMode
        {
            get { return TxtCode.ImeMode; }
            set { TxtCode.ImeMode = value; }
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
        /// <summary>
        /// テキストボックスの背景色
        /// </summary>
        public Color TextBackColor
        {
            get { return TxtCode.BackColor; }
            set { TxtCode.BackColor = value; }
        }
        /// <summary>
        /// テキストボックスの文字色
        /// </summary>
        public Color TextForeColor
        {
            get { return TxtCode.ForeColor; }
            set { TxtCode.ForeColor = value; }
        }
        #endregion

        #region コンストラクタ
        public SprCodeName()
        {
            InitializeComponent();
        }
        #endregion

        #region public fuctions
        #region データベースの値をコントロールにセット
        /// <summary>
        /// データベースの値をコントロールにセット
        /// </summary>
        /// <param name="row"></param>
        public void SetFromDb(DataRow row)
        {
            if (!string.IsNullOrEmpty(TableColumnCode) && row.Table.Columns.Contains(TableColumnCode))
            {
                CodeValue = row[TableColumnCode] != null ? row[TableColumnCode].ToString() : "";
            }
            if (!string.IsNullOrEmpty(TableColumnName) && row.Table.Columns.Contains(TableColumnName))
            {
                NameValue = row[TableColumnName] != null ? row[TableColumnName].ToString() : "";
            }
            //NameValue
        }
        #endregion
        #endregion

    }
}
