namespace RecipeAppSystem
{
    public class Cookbooks
    {
        public static DataTable CookbookSummaryGet()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookSummaryGet");
            return SQLUtility.GetDataTable(cmd);
            }
    }
}
