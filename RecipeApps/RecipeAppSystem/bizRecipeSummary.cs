using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeAppSystem
{
    public class bizRecipeSummary : bizObject<bizRecipeSummary>
    {
        private string _recipename = "", _status = "", _users = "";
        private int _calories, _numingredients;
        private bool _isvegan;

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

    }
}
