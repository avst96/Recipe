using CPUFramework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeAppSystem
{
    public class RecipeChildrenRecords
    {
        public static DataTable LoadChildById(int primarykey, string sprocname, string idcolumnname)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(sprocname);
            SQLUtility.SetParamValue(cmd, $"@{idcolumnname}", primarykey);
            return SQLUtility.GetDataTable(cmd);
        }


    }
}
