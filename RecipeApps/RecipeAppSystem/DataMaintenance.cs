using CPUFramework;
using System.Data;
using System.Data.SqlClient;

namespace RecipeAppSystem
{
    public class DataMaintenance
    {
        public static DataTable GetDashboard()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("DashboardGet");
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable GetDataList(string tablename, bool includeblank = false, bool usesallparam = true)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(tablename + "Get");
            if (usesallparam)
            {
            SQLUtility.SetParamValue(cmd, "@All", 1);
            }
            if (includeblank)
            {
                SQLUtility.SetParamValue(cmd, "@IncludeBlank", 1);
            }
            return SQLUtility.GetDataTable(cmd);
        }
    }
}
