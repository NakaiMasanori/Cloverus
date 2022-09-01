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
using static CloverusSys.Base.BaseForm;
using Sql = CloverusCommon.Database.SqlServer.Sql;
using SqlBase = CloverusCommon.Database.SqlServer.SqlBase;
using SprCommon;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
#endregion

namespace CloverusSys.MasterMaintenance.Customers
{
    public partial class Preview : Base.BaseForm
    {
        #region メンバ変数
        private int _customerCode;
        #endregion

        #region 定数
        private const int COLUMN_CUSTOMER_CODE = 0;
        #endregion

        #region プロパティ
        /// <summary>
        /// 検索キーワード
        /// </summary>
        public string Keyword
        {
            get { return this.TxtKeyword.Text; }
        }
        /// <summary>
        /// 顧客番号
        /// </summary>
        public int CustomerCode
        {
            get { return _customerCode; }
        }
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Preview()
        {
            InitializeComponent();
            InitializeForm();
        }
        #endregion

        #region private functions

        #region 画面初期設定
        private void InitializeForm()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            this.KeyPreview = true;
            this.CancelButton = BtnCancel;
            //this.AcceptButton = BtnAccept;
            InitializeGridView(DgvCustomer, FontSize.Middle);
            this.TxtKeyword.KeyDown += new KeyEventHandler(this.TxtKeyword_KeyDown);
            this.DgvCustomer.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(this.DgvCustomer_DataBindingComplete);
            this.BtnAccept.Click += new EventHandler(this.DialogButtons_AcceptClick);
            this.BtnCancel.Click += new EventHandler(this.DialogButtons_CancelClick);
            this.TxtCustomerCode.GotFocus += TxtCustomerCode_GotFocus;
            this.Shown += new EventHandler(this.Preview_Shown);
        }
        #endregion

        #region 顧客一覧表示
        /// <summary>
        /// 顧客一覧表示
        /// </summary>
        private void PreviewKokyaku()
        {
            using (var db = new SqlBase(SqlBase.TransactionUse.No, Log.ApplicationType.CloverusSys))
            {
                DgvCustomer.DataSource = db.Select(Sql.M_CUSTOMER.GetPreviewForMenu(Keyword));
            }
            DgvCustomer.Focus();
        }
        #endregion

        #region 選択している顧客番号を取得する
        /// <summary>
        /// 選択している顧客番号を取得する
        /// </summary>
        /// <param name="dgv"></param>
        /// <returns></returns>
        private string GetSelectedCode(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                return dgv.SelectedRows[0].Cells[COLUMN_CUSTOMER_CODE].Value.ToString();
            }
            else
            {
                return "0";
            }
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
            PreviewKokyaku();
        }
        #endregion

        #region 検索キーワードでキー押下
        /// <summary>
        /// 検索キーワードでキー押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtKeyword_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        PreviewKokyaku();
                        break;
                }
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
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
            TxtKeyword.Focus();
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
            _customerCode = int.Parse(GetSelectedCode(DgvCustomer));
            this.DialogResult = DialogResult.OK;
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
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion

        #region 一覧の行選択
        /// <summary>
        /// 一覧の行選択
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvCustomer_SelectionChanged(object sender, EventArgs e)
        {
            TxtCustomerCode.Text = GetSelectedCode(DgvCustomer);
        }
        #endregion

        #region 顧客番号テキストボックス
        /// <summary>
        /// 顧客番号テキストボックス
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void TxtCustomerCode_GotFocus(object sender, EventArgs e)
        {
            ((System.Windows.Forms.TextBox)sender).SelectAll();
        }
        #endregion

        #endregion

    }
}
