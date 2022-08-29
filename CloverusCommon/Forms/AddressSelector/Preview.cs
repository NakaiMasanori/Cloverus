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
using CloverusCommon.Forms.Base;
using SprCommon.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CloverusCommon.Forms.Base.BaseForm;
using Sql = CloverusCommon.Database.SqlServer.Sql;
using SqlBase = CloverusCommon.Database.SqlServer.SqlBase;
using SprCommon;
#endregion

namespace CloverusCommon.Forms.AddressSelector
{
    public partial class Preview : BaseForm
    {
        #region メンバ変数
        private string _postCode;
        private DataTable _db;
        private string _prefectures;
        private string _municipalities;
        private string _townArea;
        #endregion

        #region 定数
        private const int COLUMN_POST_CODE = 0;
        private const int COLUMN_PREFECTURES = 1;
        private const int COLUMN_MUNICIPALITIES = 2;
        private const int TOWN_AREA_CODE = 3;
        #endregion

        #region プロパティ
        /// <summary>
        /// データ数
        /// </summary>
        /// <returns></returns>
        public int Count { get { return _db == null ? 0 : _db.Rows.Count; } }
        public string Prefectures { get { return _prefectures; } }
        public string Municipalities { get { return _municipalities; } }
        public string TownArea { get { return _townArea; } }
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Preview(string postCode)
        {
            InitializeComponent();
            InitializeForm();
            _postCode = postCode;
            GetAddress();
        }
        #endregion

        #region private functions

        #region 画面初期設定
        private void InitializeForm()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            this.KeyPreview = true;
            this.CancelButton = DialogButtons.CancelButton;
            this.AcceptButton = DialogButtons.AcceptButton;
            InitializeGridView(DgvAddress, FontSize.Middle);
            this.DgvAddress.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(this.DgvAddress_DataBindingComplete);
            this.DialogButtons.AcceptClick += new EventHandler(this.DialogButtons_AcceptClick);
            this.DialogButtons.CancelClick += new EventHandler(this.DialogButtons_CancelClick);
            this.Shown += new EventHandler(this.Preview_Shown);
        }
        #endregion

        #region 顧客一覧取得
        /// <summary>
        /// 顧客一覧取得
        /// </summary>
        private void GetAddress()
        {
            using (var db = new SqlBase(SqlBase.TransactionUse.No, Log.ApplicationType.CloverusSys))
            {
                _db = db.Select(Sql.M_ADDRESS.GetPreview(_postCode));
                if (_db.Rows.Count == 1)
                {
                    _prefectures = _db.Rows[0][Sql.M_ADDRESS.TITLE_PREFECTURES].ToString();
                    _municipalities = _db.Rows[0][Sql.M_ADDRESS.TITLE_MUNICIPALITIES].ToString();
                    _townArea = _db.Rows[0][Sql.M_ADDRESS.TITLE_TOWN_AREA].ToString();
                }
            }
        }
        #endregion

        #region 顧客一覧表示
        /// <summary>
        /// 顧客一覧表示
        /// </summary>
        private void PreviewAddress()
        {
            DgvAddress.DataSource = _db;
        }
        #endregion

        #region 住所確定
        /// <summary>
        /// 住所確定
        /// </summary>
        /// <param name="index"></param>
        private void AcceptAddress(int index)
        {
            _prefectures = DgvAddress.Rows[index].Cells[COLUMN_PREFECTURES].Value.ToString();
            _municipalities = DgvAddress.Rows[index].Cells[COLUMN_MUNICIPALITIES].Value.ToString();
            _townArea = DgvAddress.Rows[index].Cells[TOWN_AREA_CODE].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        #endregion

        #endregion

        #region イベント

        #region フォーム表示完了
        /// <summary>
        /// フォーム表示完了
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Preview_Shown(object sender, EventArgs e)
        {
            PreviewAddress();
        }
        #endregion

        #region DataGridView描画完了
        /// <summary>
        /// DataGridView描画完了
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvAddress_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gv = (DataGridView)sender;
            gv.Columns[COLUMN_POST_CODE].Width = 120;
            gv.Columns[COLUMN_POST_CODE].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gv.Columns[COLUMN_PREFECTURES].Width = 240;
            gv.Columns[COLUMN_MUNICIPALITIES].Width = 240;
            gv.Columns[TOWN_AREA_CODE].Width = 240;
        }
        #endregion

        #region OKクリック
        /// <summary>
        /// OKクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DialogButtons_AcceptClick(object sender, EventArgs e)
        {
            AcceptAddress(DgvAddress.SelectedRows[0].Index);
        }
        #endregion

        #region キャンセルクリック
        /// <summary>
        /// キャンセルクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DialogButtons_CancelClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #endregion

        #region 一覧でダブルクリック
        /// <summary>
        /// 一覧でダブルクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvAddress_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AcceptAddress(e.RowIndex);
        }
        #endregion

        #endregion

    }
}
