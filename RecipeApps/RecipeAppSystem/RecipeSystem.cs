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

            //string sql;

            //if (id > 0)
            //{
            //    sql = "update Recipe " +
            //        $"set UsersID = {row["UsersID"]}, CuisineID = {row["CuisineID"]}," +
            //        $"RecipeName = '{row["RecipeName"]}', Calories = {row["Calories"]}," +
            //        $"DateDrafted = '{row["DateDrafted"]}' " +

            //        $"where RecipeID = {row["RecipeID"]}";
            //}
            //else
            //{
            //    sql = "insert Recipe (UsersID, CuisineID, RecipeName, Calories, DateDrafted)" +
            //        Environment.NewLine +
            //        $"select {row["UsersID"]}, {row["CuisineID"]}, '{row["RecipeName"]}', {row["Calories"]}, '{row["DateDrafted"]}'";
            //}
            //SQLUtility.ExecuteSQL(sql);
            SQLUtility.SaveDataRow(row, "RecipeUpdate");
        }
    }
}