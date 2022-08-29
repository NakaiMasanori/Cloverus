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
    public class M_ADDRESS
    {
        #region 定数
        private const string TABLE_NAME = nameof(M_ADDRESS);

        private const string CHIHO_DANTAI_CODE = "CHIHO_DANTAI_CODE";
        private const string POST_CODE_OLD = "POST_CODE_OLD";
        private const string POST_CODE = "POST_CODE";
        private const string PREFECTURES_KANA = "PREFECTURES_KANA";
        private const string MUNICIPALITIES_KANA = "MUNICIPALITIES_KANA";
        private const string TOWN_AREA_KANA = "TOWN_AREA_KANA";
        private const string PREFECTURES_NAME = "PREFECTURES_NAME";
        private const string MUNICIPALITIES_NAME = "MUNICIPALITIES_NAME";
        private const string TOWN_AREA_NAME = "TOWN_AREA_NAME";
        private const string AREA_MULTI = "AREA_MULTI";
        private const string AREA_KOAZA = "AREA_KOAZA";
        private const string AREA_BANCHI_BY_CHOUME = "AREA_BANCHI_BY_CHOUME";
        private const string AREA_POST_MULTI = "AREA_POST_MULTI";
        private const string UPDATE_MODE = "UPDATE_MODE";
        private const string CHANGE_REASON = "CHANGE_REASON";

        public const string TITLE_POST_CODE = "郵便番号";
        public const string TITLE_PREFECTURES = "都道府県";
        public const string TITLE_MUNICIPALITIES = "市区町村";
        public const string TITLE_TOWN_AREA = "町域";
        #endregion

        #region public static function

        #region 一覧表示
        /// <summary>
        /// 一覧表示
        /// </summary>
        /// <param name="postCode"></param>
        /// <returns></returns>
        public static string GetPreview(string postCode)
        {
            var sql = new StringBuilder();
            sql.Append($"SELECT ");
            sql.Append($"  {POST_CODE} AS {TITLE_POST_CODE}");
            sql.Append($" ,{PREFECTURES_NAME} AS {TITLE_PREFECTURES} ");
            sql.Append($" ,{MUNICIPALITIES_NAME} AS {TITLE_MUNICIPALITIES} ");
            sql.Append($" ,{TOWN_AREA_NAME} AS {TITLE_TOWN_AREA} ");
            sql.Append($"FROM {TABLE_NAME} ");
            sql.Append($"WHERE {POST_CODE} = '{postCode}' ");
            return sql.ToString();
        }
        #endregion

        #endregion
    }
}
