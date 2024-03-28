namespace RecipeAppSystem
{
    public class bizCookbook : bizObject<bizCookbook>
    {
        public bizCookbook() : base("CookbookSummary") { }

        private int _cookbookid, _num_recipes;
        private string _cookbookname = "", _author = "", _skilllevel = "";
        private decimal _price;

        public int CookbookId
        {
            get => _cookbookid;
            set { if (_cookbookid != value) _cookbookid = value; InvokePropertyChanged(); }
        }

        public string CookbookName
        {
            get => _cookbookname;
            set { if (_cookbookname != value) _cookbookname = value; InvokePropertyChanged(); }
        }

        public string Author
        {
            get => _author;
            set { if (_author != value) _author = value; InvokePropertyChanged(); }
        }

        public int Num_Recipes
        {
            get => _num_recipes;
            set { if (_num_recipes != value) _num_recipes = value; InvokePropertyChanged(); }
        }

        public decimal Price
        {
            get => _price;
            set { if (_price != value) _price = value; InvokePropertyChanged(); }
        }

        public string SkillLevel
        {
            get => _skilllevel;
            set { if (_skilllevel != value) _skilllevel = value; InvokePropertyChanged(); }
        }
    }
}
