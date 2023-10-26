using CPUFramework;
using System.Data;
using System.Data.SqlClient;

namespace RecipeAppSystem
{
    public class RecipeList
    {
        public static DataTable GetRecipeSummary()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeSummaryGet");
            return SQLUtility.GetDataTable(cmd);
        }

        public static int GetPrimaryKeyValueFromGridIndex(DataRow row, string columnname)
        {
            int recipeid = (int)row[columnname];
            
            return recipeid;
        }

    }
}
