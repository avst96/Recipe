using CPUFramework;
using System.Data;

namespace RecipeAppSystem
{
    public class RecipeSystem

    {
        public static DataTable SearchRecipe(string recipename)
        {
            string sql = "select RecipeID, RecipeName, Calories, DateDrafted, DatePublished, DateArchived, RecipeStatus, RecipePic from Recipe where RecipeName like '%" + recipename + "%'";
            return SQLUtility.GetDataTable(sql);
        }

        public static void DeleteRecipe(DataRow row)
        {
            string sql = $"delete r from Recipe r where r.RecipeID = {row["RecipeID"]}";
            SQLUtility.ExecuteSQL(sql);
        }

        public static void SaveRecipe(DataTable dt, DataRow row, int id)
        {
            SQLUtility.DebugPrintDataTable(dt);
            string sql;

            if (id > 0)
            {
                sql = "update Recipe " +
                    $"set UsersID = {row["UsersID"]}, CuisineID = {row["CuisineID"]}," +
                    $"RecipeName = '{row["RecipeName"]}', Calories = {row["Calories"]}," +
                    $"DateDrafted = '{row["DateDrafted"]}' " +

                    $"where RecipeID = {row["RecipeID"]}";
            }
            else
            {
                sql = "insert Recipe (UsersID, CuisineID, RecipeName, Calories, DateDrafted)" +
                    Environment.NewLine +
                    $"select {row["UsersID"]}, {row["CuisineID"]}, '{row["RecipeName"]}', {row["Calories"]}, '{row["DateDrafted"]}'";
            }
            SQLUtility.ExecuteSQL(sql);

        }

        public static DataTable LoadRecipe(int id)
        {
            string sql = "select r.RecipeID, r.RecipeName, r.UsersID, r.CuisineID, r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.RecipePic from Recipe r where RecipeID = " + id;
            return SQLUtility.GetDataTable(sql);
        }

        public static DataTable GetUserList()
        {
            return SQLUtility.GetDataTable("select UsersID, UserName from Users");
        }

        public static DataTable GetCuisineList()
        {
            return SQLUtility.GetDataTable("select CuisineID, CuisineName from Cuisine");
        }
        //TODO Continue to add middle tier code here

    }
}