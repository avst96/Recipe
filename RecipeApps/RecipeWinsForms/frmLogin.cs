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
            txtPassword.KeyDown += Txt_KeyDown;
            txtUserId.KeyDown += Txt_KeyDown;
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
            string pass = txtPassword.Text.Trim();
            string user = txtUserId.Text.Trim();
            if (pass == "" || user == "")
            {
                string msg = user == "" ? "UserID" : "Password";
                MessageBox.Show(msg + " cannot be blank", Application.ProductName);
                txtUserId.Text = user;
                txtPassword.Text = pass;
                if (user == "")
                {

                    txtUserId.Focus();
                }
                else
                {
                    txtPassword.Focus();
                }
            }
            else
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
        }
        private void BtnLogin_Click(object? sender, EventArgs e)
        {
            Login();
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void Txt_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
    }
}
