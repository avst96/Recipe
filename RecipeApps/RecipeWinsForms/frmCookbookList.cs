namespace RecipeWinsForms
{
    public partial class frmCookbookList : Form
    {
        public frmCookbookList()
        {
            InitializeComponent();
            BindData();
            btnNewCookbook.Click += BtnNewCookbook_Click;
            gData.CellContentClick += GData_CellContentClick;
            gData.KeyDown += GData_KeyDown;
        }

       

        private void BindData()
        {
            gData.DataSource = Cookbooks.CookbookSummaryGet();
            WindowsFormsUtility.FormatGridForSearchResults(gData);
        }

        private void BtnNewCookbook_Click(object? sender, EventArgs e)
        {
            ((frmMain)MdiParent).OpenForm(typeof(frmSingleCookbook));
        }
        private void GData_KeyDown(object? sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void GData_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
