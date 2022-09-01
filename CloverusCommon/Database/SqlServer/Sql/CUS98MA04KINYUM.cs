//*****************************************************************************
//
//  システム名：宅食業販売管理システム CloverusCommon
//
//  Copyright 株式会社スプレッド 2022 All rights reserved.
//
//-----------------------------------------------------------------------------
//  変更履歴:
//  Ver      日付        担当       コメント
//  0.0      2022/12/31  M.Nakai    新規作成
#region 更新履歴
#endregion
//*****************************************************************************

#region using defines
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace CloverusCommon.Database.SqlServer.Sql
{
    public class CUS98MA04KINYUM
    {
        #region 定数
        private static readonly List<string> Columns = new List<string>()
        {
             "CUSMA04001"
            ,"CUSMA04002"
            ,"CUSMA04003"
            ,"CUSMA04004"
            ,"CUSMA04005"
            ,"CUSMA04006"
            ,"CUSMA04007"
            ,"CUSMA04008"
            ,"CUSMA04999"
        };

        private const string TABLE_NAME = nameof(CUS98MA04KINYUM);
        #endregion

        #region public static function

        #region 編集画面表示
        public static string GetForEditor(int code)
        {
            var sql = new StringBuilder();
            sql.Append($"SELECT {string.Join(" ,", Columns)} ");
            sql.Append($"FROM {TABLE_NAME} ");
            sql.Append($"WHERE CUSMA04001 = {code} ");
            return sql.ToString();
        }
        #endregion

        #endregion
    }
}
