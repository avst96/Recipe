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
    }
}
