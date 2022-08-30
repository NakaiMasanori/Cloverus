//*****************************************************************************
//
//  システム名：宅食業販売管理システム CloverusCommon
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
using System.Data.Common;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using SprCommon.Func;
#endregion

namespace CloverusCommon.Database.SqlServer.Sql
{
    public class M_OTHER
    {
        #region 定数
        private const string TABLE_NAME = nameof(M_OTHER);

        public const string ITEM_CODE = "ITEM_CODE";
        public const string ITEM_NAME = "ITEM_NAME";
        #endregion

        #region public static functions
        /// <summary>
        /// ドロップダウン要素の取得
        /// </summary>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public static string GetDropDownItems(string columnName)
        {
            var sql = new StringBuilder();
            sql.Append($"SELECT ");
            sql.Append($"  {ITEM_CODE} ");
            sql.Append($" ,{ITEM_NAME} ");
            sql.Append($"FROM {TABLE_NAME} ");
            sql.Append($"WHERE COLUMN_NAME = '{columnName}' ");
            return sql.ToString();
        }
        #endregion

    }
}
