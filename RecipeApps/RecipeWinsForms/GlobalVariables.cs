namespace RecipeWinsForms
{
    public static class GlobalVariables
    {
        public static bool reloadrecipelist = false;
        public static bool reloaddashboard = false;
        public static bool reloadcookbooklist = false;
        public static bool reloadcookbookrecipe = false;
        public static bool reloadmeallist = false;


        public static void SetSpecificReloads(string tablechanged)
        {
            if (tablechanged == "Users")
            {
                reloadrecipelist = true;
                reloaddashboard = true;
                reloadcookbooklist = true;
                reloadcookbookrecipe = true;
                reloadmeallist = true;
            }
        }
    }

}
