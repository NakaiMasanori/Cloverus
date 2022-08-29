using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloverusCommon.Database.SqlServer.Sql
{
    public class M_ADDRESS
    {
        #region 定数
        private const string TABLE_NAME = nameof(M_ADDRESS);

        private const string CHIHO_DANTAI_CODE = "CHIHO_DANTAI_CODE";
        private const string POST_CODE_OLD = "POST_CODE_OLD";
        private const string POST_CODE = "POST_CODE";
        public const string PREFECTURES_KANA = "PREFECTURES_KANA";
        public const string MUNICIPALITIES_KANA = "MUNICIPALITIES_KANA";
        public const string TOWN_AREA_KANA = "TOWN_AREA_KANA";
        public const string PREFECTURES_NAME = "PREFECTURES_NAME";
        public const string MUNICIPALITIES_NAME = "MUNICIPALITIES_NAME";
        public const string TOWN_AREA_NAME = "TOWN_AREA_NAME";
        private const string AREA_MULTI = "AREA_MULTI";
        private const string AREA_KOAZA = "AREA_KOAZA";
        private const string AREA_BANCHI_BY_CHOUME = "AREA_BANCHI_BY_CHOUME";
        private const string AREA_POST_MULTI = "AREA_POST_MULTI";
        private const string UPDATE_MODE = "UPDATE_MODE";
        private const string CHANGE_REASON = "CHANGE_REASON";
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
            sql.Append($"  {POST_CODE} AS 郵便番号");
            sql.Append($" ,{PREFECTURES_NAME} AS 都道府県 ");
            sql.Append($" ,{PREFECTURES_NAME} AS 市区町村 ");
            sql.Append($" ,{MUNICIPALITIES_NAME} AS 町域 ");
            sql.Append($"FROM {TABLE_NAME} ");
            sql.Append($"WHERE {POST_CODE} = '{postCode}' ");
            return sql.ToString();
        }
        #endregion

        #endregion
    }
}
