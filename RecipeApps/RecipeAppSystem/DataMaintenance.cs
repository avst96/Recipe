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
    }
}
