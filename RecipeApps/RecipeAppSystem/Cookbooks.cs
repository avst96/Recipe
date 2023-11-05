namespace RecipeAppSystem
{
    public class Cookbooks
    {
        public static DataTable CookbookSummaryGet()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookSummaryGet");
            return SQLUtility.GetDataTable(cmd);
            }

        public static DataTable SingleCookbookGet(int primarykey) {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookGet");
            SQLUtility.SetParamValue(cmd, "@CookbookID", primarykey);
            return SQLUtility.GetDataTable(cmd);
        }
    }
}
