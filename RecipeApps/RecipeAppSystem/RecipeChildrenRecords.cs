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
            //Need to make sure that the params and sproc are like in sproc
            string sprocname = recordtodelete == ChildRecordEnum.Ingredient ? "RecipeIngredientDelete" : "DirectionsDelete";
            string param = recordtodelete == ChildRecordEnum.Ingredient ? "@RecipeIngredientId" : "@DirectionsId";

            SqlCommand cmd = SQLUtility.GetSqlCommand(sprocname);
            cmd.Parameters[param].Value = recordid;
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
