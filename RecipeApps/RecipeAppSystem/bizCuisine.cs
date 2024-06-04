

namespace RecipeAppSystem
{
    public class bizCuisine : bizObject<bizCuisine>
    {
        int _cuisineid;
        string _name = "";


        public int CuisineId
        {
            get => _cuisineid;
            set { if (value != _cuisineid) { _cuisineid = value; InvokePropertyChanged(); } }
        }

        public string CuisineName
        {
            get => _name;
            set { if (value != _name) { _name = value; InvokePropertyChanged(); } }
        }
             
    }
}


