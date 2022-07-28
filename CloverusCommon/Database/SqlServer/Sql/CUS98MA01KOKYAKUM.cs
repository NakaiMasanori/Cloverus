using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloverusCommon.Database.SqlServer.Sql
{
    public class CUS98MA01KOKYAKUM
    {

        public static string GetPreviewForMenu()
        {
            var sql = new StringBuilder();
            sql.Append($"SELECT ");
            sql.Append($"  CUSMA01001 AS 顧客コード ");
            sql.Append($" ,CUSMA01002 AS 顧客名 ");
            sql.Append($" ,CUSMA01007 AS 住所 ");
            sql.Append($"FROM CUS98MA01KOKYAKUM ");
            return sql.ToString();
        }

    }
}
