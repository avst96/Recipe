namespace RecipeAppSystem
{
    public class RecipeSystem

    {
        public static DataTable SearchRecipe(string recipename)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            cmd.Parameters["@RecipeName"].Value = recipename;
            if (recipename == "")
            {
                cmd.Parameters["@All"].Value = 1;
            }
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable LoadRecipe(int id)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            cmd.Parameters["@RecipeId"].Value = id;
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable GetUserList()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("UsersGet");
            cmd.Parameters["@All"].Value = 1;
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable GetCuisineList()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CuisineGet");
            cmd.Parameters["@All"].Value = 1;
            return SQLUtility.GetDataTable(cmd);
        }


        public static void DeleteRecipe(DataRow row)
        {
            int recipeid = (int)row["RecipeId"];
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeDelete");
            SQLUtility.SetParamValue(cmd, "@RecipeId", recipeid);
            SQLUtility.ExecuteSQL(cmd);
        }

        public static void SaveRecipe(DataTable dt, DataRow row)
        {
#if DEBUG
            SQLUtility.DebugPrintDataTable(dt);
#endif

            SQLUtility.SaveDataRow(row, "RecipeUpdate");
        }

        public static string GetRecipeName(DataRow row)
        {
            string recipename = "New Recipe";
            if (row["RecipeName"] != DBNull.Value)
            {
                recipename = row["RecipeName"].ToString();
                if (recipename.Length > 16)
                {
                    recipename = recipename.Substring(0, 13) + "...";
                }
            }
            return recipename;
        }
    }
}