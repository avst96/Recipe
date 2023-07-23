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
        
        public static int SelectRecipe(DataTable dt, int rowindex)
        {
            int recipeid = 0;
            if (rowindex >= 0)
            {
                recipeid = (int)dt.Rows[rowindex]["RecipeID"];
            }
            return recipeid;
        }

    }
}