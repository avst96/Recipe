using System.Configuration;
using System.Data.SqlClient;

namespace RecipeWinsForms
{
    public partial class frmLogin : Form
    {
        bool loginsuccess = false;
        public frmLogin()
        {
            InitializeComponent();
            btnCancel.Click += BtnCancel_Click;
            btnLogin.Click += BtnLogin_Click;
            txtPassword.KeyDown += TxtPassword_KeyDown;
        }

        public bool LoginForm()
        {
#if DEBUG
            Text += " - Dev mode";
#endif
            txtUserId.Text = Settings.Default.Userid;
            ShowDialog();
            return loginsuccess;
        }

        private void Login()
        {
            try
            {
                string connkey = "liveconn";
#if DEBUG 
                connkey = "devconn";
#endif
                string connstring = ConfigurationManager.ConnectionStrings[connkey].ConnectionString;
                DBManager.SetConnectionString(connstring, true, txtUserId.Text, txtPassword.Text);
                loginsuccess = true;
                Settings.Default.Userid = txtUserId.Text;
                Settings.Default.Save();
                Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("UserId or password is invalid.", Application.ProductName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }
        private void BtnLogin_Click(object? sender, EventArgs e)
        {
            Login();
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void TxtPassword_KeyDown(object? sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
    }
}
