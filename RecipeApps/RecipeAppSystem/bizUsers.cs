namespace RecipeAppSystem
{
    public class bizUsers: bizObject<bizUsers>
    {
        private int _usersid;
        private string _username = "";

        public int UsersId
        {
            get => _usersid;
            set
            {
                if (_usersid != value)
                {
                    _usersid = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string UserName
        {
            get => _username;
            set
            {
                if (_username != value)
                {
                    _username = value;
                    InvokePropertyChanged();
                }
            }
        }
    }
}
