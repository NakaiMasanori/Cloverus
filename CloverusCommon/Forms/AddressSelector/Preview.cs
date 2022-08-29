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
#endregion

namespace CloverusCommon.Forms.AddressSelector
{
    public partial class Preview : BaseForm
    {
        #region メンバ変数
        private string _postCode;
        private DataTable _db;
        #endregion

        #region プロパティ
        /// <summary>
        /// データ数
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return _db == null ? 0 : _db.Rows.Count;
        }
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Preview(string postCode)
        {
            InitializeComponent();
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
            this.DgvAddress.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(this.DgvCustomer_DataBindingComplete);
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
            using (var db = new SqlBase(SqlBase.TransactionUse.No, CloverusCommon.Log.ApplicationType.CloverusSys))
            {
                _db = db.Select(Sql.M_ADDRESS.GetPreview(_postCode));
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
        private void DgvCustomer_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gv = (DataGridView)sender;
            gv.Columns[0].Width = 120;
            gv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gv.Columns[1].Width = 240;
            gv.Columns[2].Width = 420;
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
            this.Close();
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
            this.Close();
        }
        #endregion

        #endregion
    }
}
