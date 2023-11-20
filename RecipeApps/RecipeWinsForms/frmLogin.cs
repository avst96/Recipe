namespace RecipeWinsForms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            btnCancel.Click += BtnCancel_Click;
            btnLogin.Click += BtnLogin_Click;
        }

        private void BtnLogin_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
