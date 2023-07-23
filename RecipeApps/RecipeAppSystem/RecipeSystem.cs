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
        //TODO Continue to add middle tier code here
       
    }
}