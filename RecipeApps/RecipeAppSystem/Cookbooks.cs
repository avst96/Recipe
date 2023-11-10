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
        public static void DeleteCookbook(DataRow row)
        {
            int cookbookid = (int)row["CookbookId"];
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookDelete");
            SQLUtility.SetParamValue(cmd, "@CookbookId", cookbookid);
            SQLUtility.ExecuteSQL(cmd);
        }
        public static DataTable LoadRecipeByCookbookId(int cookbookid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookRecipeGet");
            SQLUtility.SetParamValue(cmd, "@CookbookID", cookbookid);
            return SQLUtility.GetDataTable(cmd);
        }
        public static void SaveCookbookRecipe(DataTable dt, int primarykey)
        {
            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added))
            {
                r["CookbookID"] = primarykey;
            }
            SQLUtility.SaveDataTable(dt, "CookbookRecipeUpdate");
        }

        public static void DeleteCookbookRecipe(int recordid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookRecipeDelete");
            cmd.Parameters["@CookbookRecipeId"].Value = recordid;
            SQLUtility.ExecuteSQL(cmd);
        }

        public static int AutoCreateCookbook(int userid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookAutoCreate");
            SQLUtility.SetParamValue(cmd, "@UsersId", userid);
            SQLUtility.ExecuteSQL(cmd);
            return SQLUtility.GetNewPrimaryKey(cmd, "CookbookID");
        }
    }
}
