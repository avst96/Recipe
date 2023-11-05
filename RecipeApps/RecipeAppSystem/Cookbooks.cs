namespace RecipeAppSystem
{
    public class Cookbooks
    {
        public static DataTable CookbookSummaryGet()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookSummaryGet");
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable SingleCookbookGet(int primarykey)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookGet");
            SQLUtility.SetParamValue(cmd, "@CookbookID", primarykey);
            return SQLUtility.GetDataTable(cmd);
        }

        public static void SaveCookbook(DataTable dt, int rowindex = 0)
        {
            SQLUtility.GetSqlCommand("CookbookUpdate");
#if DEBUG
            SQLUtility.DebugPrintDataTable(dt);
#endif
            SQLUtility.SaveDataRow(dt.Rows[rowindex], "CookbookUpdate");
        }
    }
}
