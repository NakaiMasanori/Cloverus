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
    /// <summary>
    /// 項目名つきテキストボックス
    /// </summary>
    public partial class SprTextBox : UserControl
    {
        #region イベント定義
        public event EventHandler DblClickValueText;
        public event EventHandler ValueChanged;
        public event EventHandler EnterValueText;
        public event KeyEventHandler ValueKeyDown;
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public SprTextBox()
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
        public string Value
        {
            get { return TxtData.Text; }
            set { TxtData.Text = value; }
        }
        /// <summary>
        /// テキストボックス部の幅
        /// </summary>
        public int TextBoxWidth
        {
            get { return TxtData.Width; }
            set { TxtData.Width = value; }
        }
        /// <summary>
        /// IMEモード
        /// </summary>
        public ImeMode TextImeMode
        {
            get { return TxtData.ImeMode; }
            set { TxtData.ImeMode = value; }
        }
        #endregion

        #region イベント発生処理
        /// <summary>
        /// Enterキーを押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtData_Enter(object sender, EventArgs e)
        {
            if (EnterValueText == null)
            {
                return;
            }
            EnterValueText(this, e);
        }
        /// <summary>
        /// テキストボックスの値を変更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtData_TextChanged(object sender, EventArgs e)
        {
            if (ValueChanged == null)
            {
                return;
            }
            ValueChanged(this, e);
        }
        /// <summary>
        /// テキストボックスでダブルクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtData_DoubleClick(object sender, EventArgs e)
        {
            if (DblClickValueText == null)
            {
                return;
            }
            DblClickValueText(this, e);
        }
        /// <summary>
        /// キー押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtData_KeyDown(object sender, KeyEventArgs e)
        {
            if (ValueKeyDown == null)
            {
                return;
            }
            ValueKeyDown(this, e);
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
                Value = row[TableColumn].ToString();
            }
        }
        #endregion
        #endregion

    }
}
