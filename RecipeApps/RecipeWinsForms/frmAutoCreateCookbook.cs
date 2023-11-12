namespace RecipeWinsForms
{
    public partial class frmAutoCreateCookbook : Form
    {
        BindingSource bindsource;
        bool firstactivation = true;
        public frmAutoCreateCookbook()
        {
            InitializeComponent();
            Activated += FrmAutoCreateCookbook_Activated;
            btnCreate.Click += BtnCreate_Click;
        }



        private void FrmAutoCreateCookbook_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            BindingSource bind = new();
            DataTable dtusers = DataMaintenance.GetDataList("Users", true);
            if (firstactivation)
            {
                WindowsFormsUtility.SetListBinding(lstUserName, dtusers, null, "Users");
            }
        }

        private void CreateCookbook()
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                int cookbookid = Cookbooks.AutoCreateCookbook((int)lstUserName.SelectedValue);
                ((frmMain)Owner).OpenForm(typeof(frmSingleCookbook), cookbookid);
                Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, Application.ProductName); }
            finally { Cursor = Cursors.Default; }
        }

        private void BtnCreate_Click(object? sender, EventArgs e)
        {
            CreateCookbook();
        }

    }
}
