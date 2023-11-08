namespace RecipeAppSystem
{
    public class DataMaintenance
    {

        public static void SaveDataTable(DataTable dt, string tabletosaveto)
        {
            SQLUtility.SaveDataTable(dt, tabletosaveto + "Update");
        }


        public static DataTable GetDataList(string tablename, bool includeblank = false)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(tablename + "Get");
            if (cmd.Parameters.Contains("@All"))
            {
                SQLUtility.SetParamValue(cmd, "@All", 1);
            }
            if (includeblank)
            {
                SQLUtility.SetParamValue(cmd, "@IncludeBlank", 1);
            }
            return SQLUtility.GetDataTable(cmd);
        }
        public static DataTable GetDashboard()
        {
            return SQLUtility.GetDataTable(SQLUtility.GetSqlCommand("DashboardGet"));
        }
    }
}
