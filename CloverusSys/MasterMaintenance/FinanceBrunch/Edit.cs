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

namespace CloverusSys.MasterMaintenance.FinanceBrunch
{
    public partial class Edit : Base.BaseForm
    {
        /// <summary>
        /// 金融機関支店マスター
        /// </summary>
        public Edit()
        {
            InitializeComponent();
        }
    }
}
