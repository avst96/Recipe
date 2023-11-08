namespace RecipeWinsForms
{
    public partial class frmCookbookList : Form
    {
        public frmCookbookList()
        {
            InitializeComponent();
            BindData();
            btnNewCookbook.Click += BtnNewCookbook_Click;
            gData.CellDoubleClick += GData_CellDoubleClick;
            gData.KeyDown += GData_KeyDown;
            Activated += FrmCookbookList_Activated;
        }



        private void BindData()
        {
            gData.DataSource = Cookbooks.CookbookSummaryGet();
            WindowsFormsUtility.FormatGridForSearchResults(gData);
        }
        private void ShowCookbookForm(int rowIndex)
        {
            int id = 0;

            if (rowIndex >= 0)
            {
                id = (int)gData.Rows[rowIndex].Cells["CookbookID"].Value;
                ((frmMain)MdiParent).OpenForm(typeof(frmSingleCookbook), id);
            }
        }

        private void BtnNewCookbook_Click(object? sender, EventArgs e)
        {
            ((frmMain)MdiParent).OpenForm(typeof(frmSingleCookbook));
        }
        private void GData_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ShowCookbookForm(gData.SelectedRows[0].Index);
            }
        }


        private void GData_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowCookbookForm(e.RowIndex);
        }
        private void FrmCookbookList_Activated(object? sender, EventArgs e)
        {
            if (GlobalVariables.reloadcookbooklist)
            {
                BindData();
                GlobalVariables.reloadcookbooklist = false;
            }
        }
    }
}
