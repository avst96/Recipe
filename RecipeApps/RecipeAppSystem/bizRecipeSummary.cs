namespace RecipeAppSystem
{
    public class bizRecipeSummary : bizObject<bizRecipeSummary>
    {
        private string _recipename = "", _status = "", _users = "";
        private int _recipeid, _calories, _numingredients;
        private bool _isvegan;


        public int RecipeId
        {
            get => _recipeid;
            set
            {
                if (_recipeid != value)
                {
                    _recipeid = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string RecipeName
        {
            get => _recipename;
            set { if (_recipename != value) { _recipename = value; InvokePropertyChanged(); } }
        }
        public string RecipeStatus
        {
            get => _status;
            set { if (_status != value) { _status = value; InvokePropertyChanged(); } }
        }

        public int Calories
        {
            get => _calories;
            set { if (_calories != value) { _calories = value; InvokePropertyChanged(); } }
        }
        public string Users
        {
            get => _users;
            set { if (_users != value) { _users = value; InvokePropertyChanged(); } }
        }
        public int Num_Ingredients
        {
            get => _numingredients;
            set { if (_numingredients != value) { _numingredients = value; InvokePropertyChanged(); } }
        }
        public bool isVegan
        {
            get => _isvegan;
            set { if (_isvegan != value) { _isvegan = value; InvokePropertyChanged(); } }
        }


        public List<bizRecipeSummary> SearchRecipeByCookbook(string cookbook)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(GetSprocName);
            SQLUtility.SetParamValue(cmd, "CookbookName", cookbook);
            return GetListFromDataTable(SQLUtility.GetDataTable(cmd));
        }

        public List<bizRecipeSummary> GetRecipebyCuisineId(int cuisineid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(GetSprocName);
            SQLUtility.SetParamValue(cmd, "CuisineId", cuisineid);
            return GetListFromDataTable(SQLUtility.GetDataTable(cmd));
        }
    }
}
