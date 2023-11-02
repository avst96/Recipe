namespace RecipeAppSystem
{
    public class RecipeSystem

    {
        public enum StatusEnum { Drafted, Published, Archived }
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
        public static void SetAndSaveRecipeStatus(DataTable table, StatusEnum status)
        {
            if (table.Rows.Count == 1)
            {
                switch (status)
                {
                    case StatusEnum.Drafted:
                        table.Rows[0]["DateDrafted"] = DateTime.Now;
                        table.Rows[0]["DatePublished"] = DBNull.Value;
                        table.Rows[0]["DateArchived"] = DBNull.Value;
                        break;
                    case StatusEnum.Published:
                        table.Rows[0]["DateArchived"] = DBNull.Value;
                        table.Rows[0]["DatePublished"] = DateTime.Now;
                        break;
                    case StatusEnum.Archived:
                        table.Rows[0]["DateArchived"] = DateTime.Now;
                        break;
                }
                SaveRecipe(table, table.Rows[0]);
            }
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