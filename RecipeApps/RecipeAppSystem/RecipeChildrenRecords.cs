using CPUFramework;
using System.Data;
using System.Data.SqlClient;

namespace RecipeAppSystem
{
    public class RecipeChildrenRecords
    {
        public enum ChildRecordEnum { Ingredient, Steps }
        public static DataTable LoadChildById(int primarykey, string sprocname, string idcolumnname)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(sprocname);
            SQLUtility.SetParamValue(cmd, $"@{idcolumnname}", primarykey);
            return SQLUtility.GetDataTable(cmd);
        }

        public static void DeleteChildRecord(ChildRecordEnum recordtodelete, int recordid)
        {
            string sprocname = recordtodelete == ChildRecordEnum.Ingredient ? "RecipeIngredientDelete" : "DirectionsDelete";
            string param = recordtodelete == ChildRecordEnum.Ingredient ? "@RecipeIngredientId" : "@DirectionsId";

            SqlCommand cmd = SQLUtility.GetSqlCommand(sprocname);
            cmd.Parameters[param].Value = recordid;
            SQLUtility.ExecuteSQL(cmd);
        }

        public static void SaveChildTable(DataTable dt, int primarykey, ChildRecordEnum recordenum)
        {
            string sproc = recordenum == ChildRecordEnum.Ingredient ? "RecipeIngredientUpdate" : "";

            foreach (DataRow dr in dt.Select("","",DataViewRowState.Added))
            {
                dr["RecipeId"] = primarykey;
            }

            SQLUtility.SaveDataTable(dt, sproc);
        }
    }
}
