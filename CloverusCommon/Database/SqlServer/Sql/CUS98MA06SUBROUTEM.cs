//*****************************************************************************
//
//  システム名：宅食業販売管理システム CloverusCommon
//
//  Copyright 株式会社スプレッド 2022 All rights reserved.
//
//-----------------------------------------------------------------------------
//  変更履歴:
//  Ver      日付        担当       コメント
//  0.0      2022/12/31  Y.Ito    新規作成
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
    public class CUS98MA06SUBROUTEM
    {
        #region 定数
        private const string TABLE_NAME = nameof(CUS98MA06SUBROUTEM);
        private const string ROUTE_CODE = "CUSMA06001";
        private const string SUB_NO = "CUSMA06002";
        private const string SUB_NAME = "CUSMA06003";
        private const string TYPE = "CUSMA06004";
        private const string POST = "CUSMA06005";
        private const string BIKO = "CUSMA06006";
        private const string UPDATE_NO = "CUSMA06006";
        #endregion

        #region public static function

        #region 編集画面表示
        /// <summary>
        /// 編集画面表示
        /// </summary>
        /// <param name="subNo"></param>
        /// <returns></returns>
        public static string GetForEditor(int subNo)
        {
            var sql = new StringBuilder();
            sql.Append($"SELECT {ROUTE_CODE} ");
            sql.Append($"       , {SUB_NO} ");
            sql.Append($"       , {SUB_NAME} ");
            sql.Append($"       , {TYPE} ");
            sql.Append($"       , {POST} ");
            sql.Append($"       , {BIKO} ");
            sql.Append($"       , {UPDATE_NO} ");
            sql.Append($"FROM {TABLE_NAME} ");
            sql.Append($"WHERE {SUB_NO} = {subNo} ");
            return sql.ToString();
        }
        #endregion

        #endregion
    }
}
