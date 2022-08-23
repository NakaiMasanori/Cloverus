//*****************************************************************************
//
//  システム名：共通コントロール
//
//  Copyright 株式会社スプレッド 2022 All rights reserved.
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
        /// タイトル
        /// </summary>
        public string Title
        {
            get
            {
                return LblTitle.Text;
            }
            set
            {
                LblTitle.Text = value;
            }
        }
        /// <summary>
        /// 値
        /// </summary>
        public string Value
        {
            get
            {
                return TxtData.Text;
            }
            set
            {
                TxtData.Text = value;
            }
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
        #endregion
    }
}
