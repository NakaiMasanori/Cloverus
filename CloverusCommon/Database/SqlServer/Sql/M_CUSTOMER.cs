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
    public class M_CUSTOMER
    {
        #region 定数
        private static readonly List<string> Columns = new List<string>()
        {
             "CUSMA01001"
            ,"CUSMA01002"
            ,"CUSMA01003"
            ,"CUSMA01004"
            ,"CUSMA01005"
            ,"CUSMA01006"
            ,"CUSMA01007"
            ,"CUSMA01008"
            ,"CUSMA01009"
            ,"CUSMA01010"
            ,"CUSMA01011"
            ,"CUSMA01012"
            ,"CUSMA01013"
            ,"CUSMA01014"
            ,"CUSMA01015"
            ,"CUSMA01016"
            ,"CUSMA01017"
            ,"CUSMA01018"
            ,"CUSMA01019"
            ,"CUSMA01020"
            ,"CUSMA01021"
            ,"CUSMA01022"
            ,"CUSMA01023"
            ,"CUSMA01024"
            ,"CUSMA01025"
            ,"CUSMA01026"
            ,"CUSMA01027"
            ,"CUSMA01028"
            ,"CUSMA01029"
            ,"CUSMA01030"
            ,"CUSMA01031"
            ,"CUSMA01032"
            ,"CUSMA01033"
            ,"CUSMA01034"
            ,"CUSMA01035"
            ,"CUSMA01036"
            ,"CUSMA01037"
            ,"CUSMA01038"
            ,"CUSMA01039"
            ,"CUSMA01040"
            ,"CUSMA01041"
            ,"CUSMA01042"
            ,"CUSMA01043"
            ,"CUSMA01044"
            ,"CUSMA01045"
            ,"CUSMA01046"
            ,"CUSMA01047"
            ,"CUSMA01048"
            ,"CUSMA01049"
            ,"CUSMA01050"
            ,"CUSMA01051"
            ,"CUSMA01052"
            ,"CUSMA01053"
            ,"CUSMA01054"
            ,"CUSMA01055"
            ,"CUSMA01056"
            ,"CUSMA01057"
            ,"CUSMA01999"
            ,"CUSMA01058"
            ,"CUSMA01059"
            ,"CUSMA01060"
            ,"CUSMA01061"
            ,"CUSMA01062"
            ,"CUSMA01063"
            ,"CUSMA01064"
            ,"CUSMA01065"
            ,"CUSMA01066"
            ,"CUSMA01067"
            ,"CUSMA01068"
            ,"CUSMA01069"
            ,"CUSMA01070"
            ,"CUSMA01071"
            ,"CUSMA01072"
            ,"CUSMA01076"
            ,"CUSMA01073"
            ,"CUSMA01074"
            ,"CUSMA01075"
            ,"CUSMA01077"
            ,"CUSMA01078"
            ,"CUSMA01079"
            ,"CUSMA01080"
            ,"CUSMA01081"
            ,"CUSMA01082"
            ,"CUSMA01083"
            ,"CUSMA01084"
            ,"CUSMA01085"
            ,"CUSMA01086"
            ,"CUSMA01087"
            ,"CUSMA01088"
            ,"CUSMA01089"
            ,"CUSMA01090"
            ,"CUSMA01091"
            ,"CUSMA01092"
            ,"CUSMA01093"
            ,"CUSMA01094"
            ,"CUSMA01095"
            ,"CUSMA01096"
            ,"CUSMA01097"
        };

        private const string TABLE_NAME = nameof(M_CUSTOMER);

        #endregion

        public static string GetPreviewForMenu(string keyWords)
        {
            var conditions = new List<string>();
            if (keyWords != "")
            {
                var values = new List<string>();
                foreach (var keyWord in keyWords.Replace("　", " ").Split(' '))
                {
                    var columnCondition = new List<string>();
                    foreach (var column in Columns)
                    {
                        foreach (var value in ToValues(keyWord))
                        {
                            columnCondition.Add($"{column} LIKE '%{value}%' ");
                        }
                    }
                    conditions.Add($"({string.Join("OR ", columnCondition)})");
                }
            }
            var sql = new StringBuilder();
            sql.Append($"SELECT ");
            sql.Append($"  CUSMA01001 AS 顧客コード ");
            sql.Append($" ,CUSMA01002 AS 顧客名 ");
            sql.Append($" ,CUSMA01007 AS 住所 ");
            sql.Append($"FROM {TABLE_NAME} ");
            if (conditions.Any())
            {
                sql.Append($"WHERE ");
                sql.Append(String.Join("AND ", conditions));
            }
            return sql.ToString();
        }

        public static string GetForEditor(int code)
        {
            var sql = new StringBuilder();
            sql.Append($"SELECT ");
            sql.Append($"  CUSMA01001 AS 顧客コード ");
            sql.Append($" ,CUSMA01002 AS 顧客名 ");
            sql.Append($" ,CUSMA01007 AS 住所 ");
            sql.Append($"FROM {TABLE_NAME} ");
            sql.Append($"WHERE CUSMA01001 = {code} ");
            return sql.ToString();
        }

        private static List<string> ToValues(string keyWord)
        {
            var values = new List<string>();
            values.Add(keyWord);
            var value = Com.HiraganaToKatakana(keyWord);
            if (!values.Contains(value))
            {
                values.Add(value);
            }
            value = Com.ZenkakuToHankaku(value);
            if (!values.Contains(value))
            {
                values.Add(value);
            }
            return values;
        }
    }
}
