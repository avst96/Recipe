using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeAppSystem
{
    public class bizIngredient : bizObject<bizIngredient>
    {
        int _ingredientid;
        string _name = "", _picture = "";


        public int IngredientId
        {
            get => _ingredientid;
            set { if (value != _ingredientid) { _ingredientid = value; InvokePropertyChanged(); } }
        }

        public string IngredientName
        {
            get => _name;
            set { if (value != _name) { _name = value; InvokePropertyChanged(); } }
        }

        public string IngredientPicture
        {
            get => _picture;
            set { if (value != _picture) { _picture = value; InvokePropertyChanged(); } }
        }
        public List<bizIngredient> SearchIngredient(string search)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(GetSprocName);
            if (search == "") { SQLUtility.SetParamValue(cmd, "All", 1); }
            else { SQLUtility.SetParamValue(cmd, "IngredientName", search); }
            return GetListFromDataTable(SQLUtility.GetDataTable(cmd));
        }
    }
}
