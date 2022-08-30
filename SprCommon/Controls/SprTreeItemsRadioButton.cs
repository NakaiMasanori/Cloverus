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
    public partial class SprTreeItemsRadioButton : UserControl
    {
        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public SprTreeItemsRadioButton()
        {
            InitializeComponent();
            //foreach (var item in _valueItems)
            //{

            //}
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
        /// ラジオボタン（左）の値
        /// </summary>
        public int RadioLeftValue
        {
            get;
            set;
        }
        /// <summary>
        /// ラジオボタン（左）のテキスト
        /// </summary>
        public string RadioLeftText
        {
            get { return RdoLeft.Text; }
            set { RdoLeft.Text = value; }
        }
        /// <summary>
        /// ラジオボタン（中央）の値
        /// </summary>
        public int RadioCenterValue
        {
            get;
            set;
        }
        /// <summary>
        /// ラジオボタン（中央）のテキスト
        /// </summary>
        public string RadioCenterText
        {
            get { return RdoCenter.Text; }
            set { RdoCenter.Text = value; }
        }
        /// <summary>
        /// ラジオボタン（右）の値
        /// </summary>
        public int RadioRightValue
        {
            get;
            set;
        }
        /// <summary>
        /// ラジオボタン（右）のテキスト
        /// </summary>
        public string RadioRightText
        {
            get { return RdoRight.Text; }
            set { RdoRight.Text = value; }
        }
        /// <summary>
        /// 使用する要素の数
        /// </summary>
        private int _itemsCount = 3;
        public int ItemsCount
        {
            get { return _itemsCount; }
            set
            {
                _itemsCount = value;
                switch (value)
                {
                    case 1:
                        RdoCenter.Visible = false;
                        RdoRight.Visible = false;
                        break;
                    case 2:
                        RdoRight.Visible = false;
                        break;
                }
            }
        }
        /// <summary>
        /// 選択値
        /// </summary>
        public int Value
        {
            get
            {
                if (RdoRight.Visible && RdoRight.Checked)
                {
                    return RadioRightValue;
                }
                if (RdoCenter.Visible && RdoCenter.Checked)
                {
                    return RadioCenterValue;
                }
                return RadioLeftValue;
            }
            set
            {
                if (value == RadioLeftValue)
                {
                    RdoLeft.Checked = true;
                    return;
                }
                if (value == RadioCenterValue)
                {
                    RdoCenter.Checked = true;
                    return;
                }
                if (value == RadioRightValue)
                {
                    RdoRight.Checked = true;
                    return;
                }
            }
        }
        #endregion
    }
}
