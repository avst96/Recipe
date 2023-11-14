namespace RecipeWinsForms
{
    public partial class frmAutoCreateCookbook : Form
    {
        public frmAutoCreateCookbook()
        {
            InitializeComponent();
            BindData();
            btnCreate.Click += BtnCreate_Click;
        }


        private void BindData()
        {
            DataTable dtusers = DataMaintenance.GetDataList("Users", true);
            WindowsFormsUtility.SetListBinding(lstUserName, dtusers, null, "Users");

        }

        private void CreateCookbook(int userid)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                int cookbookid = Cookbooks.AutoCreateCookbook(userid);
                ((frmMain)Owner).OpenForm(typeof(frmSingleCookbook), cookbookid);
                Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, Application.ProductName); }
            finally { Cursor = Cursors.Default; }
        }

        private void BtnCreate_Click(object? sender, EventArgs e)
        {
            int selecteduser = WindowsFormsUtility.GetIdFromComboBox(lstUserName);

            if (selecteduser == 0)
            {
                MessageBox.Show("Please select a user to create a cookbook.", Application.ProductName);
            }
            else
            {
                CreateCookbook(selecteduser);
            }
        }
    }
}
