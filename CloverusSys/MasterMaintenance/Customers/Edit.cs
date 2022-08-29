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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sql = CloverusCommon.Database.SqlServer.Sql;
using SqlBase = CloverusCommon.Database.SqlServer.SqlBase;
using SprCommon.Func;
#endregion

namespace CloverusSys.MasterMaintenance.Customers
{
    /// <summary>
    /// 顧客マスター
    /// </summary>
    public partial class Edit : Base.BaseForm
    {
        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Edit(int customerCode)
        {
            InitializeComponent();
            customerCode = 8;
            ViewData(customerCode);
        }
        #endregion

        #region イベント
        /// <summary>
        /// キー押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmEdit_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.F3:
                        var frmSearch = new Preview();
                        frmSearch.ShowDialog();
                        break;
                }
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }
        #endregion

        #region private function

        #region 画面表示
        /// <summary>
        /// 画面表示
        /// </summary>
        /// <param name="customerCode"></param>
        private void ViewData(int customerCode)
        {
            using (var db = new SqlBase(SqlBase.TransactionUse.No, CloverusCommon.Log.ApplicationType.CloverusSys))
            {
                var data = db.Select(Sql.M_CUSTOMER.GetForEditor(customerCode));
                if (data.Rows.Count > 0)
                {
                    Com.DataRowToControl(data.Rows[0], this.Controls);
                }
            }
        }
        #endregion

        #endregion
    }
}
