namespace RecipeWinsForms
{

    public partial class frmSingleCookbook : Form
    {
        DataTable dtcookbook = new();
        DataTable dtingredient = new();
        BindingSource bindsource = new();
        int cookbookid = 0;
        public frmSingleCookbook()
        {
            InitializeComponent();
        }

        public void LoadCookbook(int bookid = 0)
        {
            DataTable dtusers = new();
            cookbookid = bookid;

            dtcookbook = Cookbooks.SingleCookbookGet(cookbookid);
            bindsource.DataSource = dtcookbook;

            if (bookid == 0)
            {
                dtcookbook.Rows.Add();
            }

            WindowsFormsUtility.SetControlBinding(txtBookName, bindsource);
            WindowsFormsUtility.SetControlBinding(txtPrice, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateCreated, bindsource);
            WindowsFormsUtility.SetControlBinding(chkIsActive, bindsource);
            WindowsFormsUtility.SetListBinding(lstUserName, DataMaintenance.GetDataList("Users", true), dtcookbook, "Users");
        }
    }
}
