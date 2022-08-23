//*****************************************************************************
//
//  システム名：宅食業販売管理システム
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
using CloverusSys.Base;
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
#endregion

namespace CloverusSys.MasterMaintenance.Customers
{
    /// <summary>
    /// 顧客マスター
    /// </summary>
    public partial class FrmEdit : BaseForm
    {
        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FrmEdit(int customerCode)
        {
            InitializeComponent();
            using (var db = new SqlBase(SqlBase.TransactionUse.No, CloverusCommon.Log.ApplicationType.OrderManager))
            {
                var data = db.Select(Sql.CUS98MA01KOKYAKUM.GetForEditor(customerCode));
                if (data.Rows.Count > 0)
                {
                    //label2.Text = data.Rows[0][0].ToString();
                    //label3.Text = data.Rows[0][1].ToString();
                }
            }
        }
        #endregion

        #region イベント
        #endregion

        #region private function
        #endregion

    }
}
