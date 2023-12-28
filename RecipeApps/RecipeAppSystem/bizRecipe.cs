namespace RecipeAppSystem
{
    public class bizRecipe : bizObject
    {
        private int _recipeid, _usersid, _cuisineid, _calories;
        private string _recipename = "", _recipestatus = "", _recipepic = "";
        private DateTime _datedrafted;
        private DateOnly? _datepublished, _datearchived;

        public int RecipeId
        {
            get => _recipeid;
            set { if (_recipeid != value) { _recipeid = value; InvokePropertyChanged(); } }
        }
        public int UsersId
        {
            get => _usersid;
            set { if (_usersid != value) { _usersid = value; InvokePropertyChanged(); } }
        }
        public int CuisineId
        {
            get => _cuisineid;
            set { if (_cuisineid != value) { _cuisineid = value; InvokePropertyChanged(); } }
        }
        public int Calories
        {
            get => _calories;
            set { if (_calories != value) { _calories = value; InvokePropertyChanged(); } }
        }
        public string RecipeName
        {
            get => _recipename;
            set { if (_recipename != value) { _recipename = value; InvokePropertyChanged(); } }
        }
        public string RecipeStatus
        {
            get => _recipestatus;
            set { if (_recipestatus != value) { _recipestatus = value; InvokePropertyChanged(); } }
        }
        public string RecipePic
        {
            get => _recipepic;
            set { if (_recipepic != value) { _recipepic = value; InvokePropertyChanged(); } }
        }
        public DateTime DateDrafted
        {
            get => _datedrafted;
            set { if (_datedrafted != value) { _datedrafted = value; InvokePropertyChanged(); } }
        }
        public DateOnly? DatePublished
        {
            get => _datepublished;
            set { if (_datepublished != value) { _datepublished = value; InvokePropertyChanged(); } }
        }
        public DateOnly? DateArchived
        {
            get => _datearchived;
            set { if (_datearchived != value) { _datearchived = value; InvokePropertyChanged(); } }
        }
    }
}