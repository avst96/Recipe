namespace RecipeAppSystem
{
    public class bizMealSummary : bizObject<bizMealSummary>
    {


        private string _mealname = "", _username = "", _mealdesc = "";
        private int _numcalories, _numcourses, _numrecipes;
        public string MealName
        {
            get => _mealname;
            set { if (_mealname != value) { _mealname = value; InvokePropertyChanged(); } }
        }

        public string UserName
        {
            get => _username;
            set { if (_username != value) { _username = value; InvokePropertyChanged(); } }
        }
        public int Num_Calories
        {
            get => _numcalories;
            set { if (_numcalories != value) { _numcalories = value; InvokePropertyChanged(); } }
        }
        public int Num_Courses
        {
            get => _numcourses;
            set { if (_numcourses != value) { _numcourses = value; InvokePropertyChanged(); } }
        }
        public int Num_Recipes
        {
            get => _numrecipes;
            set { if (_numrecipes != value) { _numrecipes = value; InvokePropertyChanged(); } }
        }
        public string MealDesc
        {
            get => _mealdesc;
            set { if (_mealdesc != value) { _mealdesc = value; InvokePropertyChanged(); } }
        }
    }
}
