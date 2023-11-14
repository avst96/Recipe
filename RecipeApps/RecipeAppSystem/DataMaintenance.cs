namespace RecipeAppSystem
{
    public class DataMaintenance
    {

        public static void SaveDataTable(DataTable dt, string tabletosaveto)
        {
            SQLUtility.SaveDataTable(dt, tabletosaveto + "Update");
        }
        public static void DeleteRow(DataRow row, string tablename)
        {
            int primarykey;
            try
            {
                primarykey = (int)row[tablename + "Id"];
            }
            catch
            {
                throw;
            }
            SqlCommand cmd = SQLUtility.GetSqlCommand(tablename + "Delete");
            SQLUtility.SetParamValue(cmd, $"@{tablename}Id", primarykey);
            SQLUtility.ExecuteSQL(cmd);
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
