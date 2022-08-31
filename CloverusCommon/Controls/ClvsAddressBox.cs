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
    public partial class ClvsAddressBox : UserControl
    {
        #region プロパティ
        /// <summary>
        /// 郵便番号のタイトル
        /// </summary>
        public string TitleTextPost
        {
            get { return LblTitlePost.Text; }
            set { LblTitlePost.Text = value; }
        }
        /// <summary>
        /// 住所のタイトル
        /// </summary>
        public string TitleTextAddress
        {
            get { return LblTitleAddress.Text; }
            set { LblTitleAddress.Text = value; }
        }
        /// <summary>
        /// 郵便番号
        /// </summary>
        public string ValuePost
        {
            get { return TxtPostCode.Text; }
            set { TxtPostCode.Text = value; }
        }
        /// <summary>
        /// 都道府県
        /// </summary>
        public string ValuePrefectures
        {
            get { return TxtPrefectures.Text; }
            set { TxtPrefectures.Text = value; }
        }
        /// <summary>
        /// 市区町村
        /// </summary>
        public string ValueMunicipalities
        {
            get { return TxtMunicipalities.Text; }
            set { TxtMunicipalities.Text = value; }
        }
        /// <summary>
        /// 町域
        /// </summary>
        public string ValueTownArea
        {
            get { return TxtTownArea.Text; }
            set { TxtTownArea.Text = value; }
        }
        /// <summary>
        /// 郵便番号のデータベースカラム
        /// </summary>
        public string TableColumnPost { get; set; }
        /// <summary>
        /// 都道府県のデータベースカラム
        /// </summary>
        public string TableColumnPrefectures { get; set; }
        /// <summary>
        /// 市区町村のデータベースカラム
        /// </summary>
        public string TableColumnMunicipalities { get; set; }
        /// <summary>
        /// 町域のデータベースカラム
        /// </summary>
        public string TableColumnTownArea { get; set; }
        /// <summary>
        /// タイトルの背景色
        /// </summary>
        public Color TitlePostBackColor
        {
            get { return LblTitlePost.BackColor; }
            set { LblTitlePost.BackColor = value; }
        }
        /// <summary>
        /// タイトルの文字色
        /// </summary>
        public Color TitlePostForeColor
        {
            get { return LblTitlePost.ForeColor; }
            set { LblTitlePost.ForeColor = value; }
        }
        /// <summary>
        /// タイトルの背景色
        /// </summary>
        public Color TitleAddressBackColor
        {
            get { return LblTitleAddress.BackColor; }
            set { LblTitleAddress.BackColor = value; }
        }
        /// <summary>
        /// タイトルの文字色
        /// </summary>
        public Color TitleAddressForeColor
        {
            get { return LblTitleAddress.ForeColor; }
            set { LblTitleAddress.ForeColor = value; }
        }
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ClvsAddressBox()
        {
            InitializeComponent();
        }
        #endregion

        #region イベント処理
        private void BtnPreviewAddress_Click(object sender, EventArgs e)
        {
            var postCode = TxtPostCode.Text.Replace("-", "");
            if (!CheckPostCode(postCode))
            {
                Messages.ShowDialog(Sentence.Messages.InvalidPostalCode);
                TxtPostCode.Focus();
                return;
            }
            var prefectures = string.Empty;
            var municipalities = string.Empty;
            var townArea = string.Empty;
            var frm = new Forms.AddressSelector.Preview(postCode);
            switch (frm.Count)
            {
                case 0:
                    Messages.ShowDialog(Sentence.Messages.InvalidPostalCode);
                    return;
                case 1:
                    prefectures = frm.Prefectures;
                    municipalities = frm.Municipalities;
                    townArea = frm.TownArea;
                    break;
                default:
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        prefectures = frm.Prefectures;
                        municipalities = frm.Municipalities;
                        townArea = frm.TownArea;
                    }
                    break;
            }
            if (!string.IsNullOrEmpty(prefectures))
            {
                SetAdressData(prefectures, municipalities, townArea);
            }
        }
        #endregion

        #region private functions

        #region 住所テーブルの住所データをコントロールに格納
        /// <summary>
        /// 住所テーブルの住所データをコントロールに格納
        /// </summary>
        /// <param name="prefectures"></param>
        /// <param name="municipalities"></param>
        /// <param name="townArea"></param>
        private void SetAdressData(string prefectures, string municipalities, string townArea)
        {
            if (!string.IsNullOrEmpty(TxtPrefectures.Text.Trim()))
            {
                // 確認でNoを選択したらなにもしない
                if (Messages.ShowDialog(Sentence.Messages.ChangeAddress) == DialogResult.No)
                {
                    return;
                }
            }
            TxtPrefectures.Text = $"{municipalities}{townArea}";
            //TxtMunicipalities.Text = municipalities;
            //TxtTownArea.Text = townArea;
        }

        #region データベースの値をコントロールにセット
        /// <summary>
        /// データベースの値をコントロールにセット
        /// </summary>
        /// <param name="row"></param>
        public void SetFromDb(DataRow row)
        {
            if (!string.IsNullOrEmpty(TableColumnPost) && row.Table.Columns.Contains(TableColumnPost))
            {
                ValuePost = row[TableColumnPost].ToString();
            }
            if (!string.IsNullOrEmpty(TableColumnPrefectures) && row.Table.Columns.Contains(TableColumnPrefectures))
            {
                ValuePrefectures = row[TableColumnPrefectures].ToString();
            }
            if (!string.IsNullOrEmpty(TableColumnMunicipalities) && row.Table.Columns.Contains(TableColumnMunicipalities))
            {
                ValueMunicipalities = row[TableColumnMunicipalities].ToString();
            }
            if (!string.IsNullOrEmpty(TableColumnTownArea) && row.Table.Columns.Contains(TableColumnTownArea))
            {
                ValueTownArea = row[TableColumnTownArea].ToString();
            }
        }
        #endregion

        #region 郵便番号の入力値チェック
        /// <summary>
        /// 郵便番号の入力値チェック
        /// </summary>
        /// <param name="postCode"></param>
        /// <returns></returns>
        private bool CheckPostCode(string postCode)
        {
            if (string.IsNullOrEmpty(postCode))
            {
                return false;
            }
            if (postCode.Length != 7)
            {
                return false;
            }
            if (!int.TryParse(postCode, out int val))
            {
                return false;
            }
            return true;
        }
        #endregion

        #endregion

        #endregion

    }
}
