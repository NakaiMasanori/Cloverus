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
    public class CUS98MA05KINYUSHITENM
    {
        #region 定数
        private static readonly List<string> Columns = new List<string>()
        {
             "CUSMA05001"
            ,"CUSMA05002"
            ,"CUSMA05003"
            ,"CUSMA05004"
            ,"CUSMA05005"
            ,"CUSMA05006"
            ,"CUSMA05007"
            ,"CUSMA05008"
            ,"CUSMA05009"
            ,"CUSMA05999"
        };

        private static string TABLE_NAME = nameof(CUS98MA05KINYUSHITENM);
        #endregion

        #region 編集画面表示
        /// <summary>
        /// 編集画面表示
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static string GetForEditor(string code)
        {
            var sql = new StringBuilder();
            sql.Append($"SELECT {string.Join(" ,", Columns)} ");
            sql.Append($"FROM {TABLE_NAME} ");
            sql.Append($"WHERE CUSMA05002 = {code} ");
            return sql.ToString();
        }
        #endregion
    }
}
