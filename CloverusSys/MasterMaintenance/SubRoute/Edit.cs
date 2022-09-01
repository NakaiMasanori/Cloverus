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
using SprCommon;
#endregion

namespace CloverusSys.MasterMaintenance.SubRoute
{
    /// <summary>
    /// サブルートマスター
    /// </summary>
    public partial class Edit : Base.BaseForm
    {
        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="subNo"></param>
        public Edit(int subNo)
        {
            InitializeComponent();
            using (var db = new SqlBase(SqlBase.TransactionUse.No, Log.ApplicationType.CloverusSys))
            {
                CloverusCommon.Func.Com.InitializeControls(this.Controls);
            }
            subNo = 4;
            ViewData(subNo);
        }
        #endregion

        #region 画面表示
        /// <summary>
        /// 画面表示
        /// </summary>
        /// <param name="subNo"></param>
        private void ViewData(int subNo)
        {
            using (var db = new SqlBase(SqlBase.TransactionUse.No, Log.ApplicationType.CloverusSys))
            {
                var data = db.Select(Sql.CUS98MA06SUBROUTEM.GetForEditor(subNo));
                if (data.Rows.Count > 0)
                {
                    CloverusCommon.Func.Com.DataRowToControl(data.Rows[0], this.Controls, db);
                }
            }
        }
        #endregion
    }
}
