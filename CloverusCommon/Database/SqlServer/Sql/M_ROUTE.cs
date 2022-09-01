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
    public class M_ROUTE
    {
        #region 定数
        public enum RouteType
        {
            // 昼
            DayTime = 1,
            // 夜
            NightTime = 2,
        }

        private const string TABLE_NAME = nameof(M_ROUTE);

        private const string ROUTE_TYPE = "CUSMA03004";
        private const string ROUTE_CODE = "CUSMA03001";
        public const string ROUTE_NAME = "CUSMA03002";
        #endregion

        #region public static function


        #region 名称取得
        /// <summary>
        /// 名称取得
        /// </summary>
        /// <param name="routeType"></param>
        /// <param name="routeCode"></param>
        /// <returns></returns>
        public static string GetName(RouteType routeType, string routeCode)
        {
            var sql = new StringBuilder();
            sql.Append($"SELECT ");
            sql.Append($"  {ROUTE_NAME} AS {ROUTE_NAME} ");
            sql.Append($"FROM {TABLE_NAME} ");
            sql.Append($"WHERE {ROUTE_TYPE} = {(int)routeType} ");
            sql.Append($"  AND {ROUTE_CODE} = '{routeCode}' ");
            return sql.ToString();
        }
        #endregion

        #endregion
    }
}
