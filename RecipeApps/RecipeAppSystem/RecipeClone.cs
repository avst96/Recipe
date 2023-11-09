namespace RecipeAppSystem
{
    public static class RecipeClone
    {
        public static int CloneRecipe(int recipeid)
        {
            int pk = 0;

            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeClone");
            SQLUtility.SetParamValue(cmd, "@RecipeId", recipeid);
            SQLUtility.ExecuteSQL(cmd);
            pk = SQLUtility.GetNewPrimaryKey(cmd, "RecipeId");
            if (pk == 0)
            {
                Exception pkerror = new Exception("New recipe ID received was 0. An error occured in the program");
                throw pkerror;
            }

            return pk;
        }
    }
}
