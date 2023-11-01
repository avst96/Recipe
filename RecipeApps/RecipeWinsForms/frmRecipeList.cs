namespace RecipeWinsForms
{
    public partial class frmRecipeList : Form
    {
        public frmRecipeList()
        {
            InitializeComponent();
            BindData();
            Activated += FrmRecipeList_Activated;
            btnNewRecipe.Click += BtnNewRecipe_Click;
            gData.CellDoubleClick += GData_CellDoubleClick;
            gData.KeyDown += GData_KeyDown;
        }

        private void BindData(bool formatgrid = true)
        {
            gData.DataSource = RecipeList.GetRecipeSummary();
            if (formatgrid)
            {
                WindowsFormsUtility.FormatGridForSearchResults(gData);
            }
        }
        private void FrmRecipeList_Activated(object? sender, EventArgs e)
        {
            if (GlobalVariables.reloadrecipelist)
            {
                BindData(false);
                GlobalVariables.reloadrecipelist = false;
            }
        }

        private void ShowRecipeForm(int rowindex)
        {
            int recipeid = 0;

            if (rowindex != -1) //Clicking on the header returns a -1, in which case I don't wan't to do anything
            {
                if (rowindex >= 0)
                {
                    recipeid = (int)gData.Rows[rowindex].Cells["RecipeID"].Value;
                }
            }
            ((frmMain)MdiParent).OpenForm(typeof(frmSingleRecipe), recipeid);
        }

        private void GData_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gData.Rows.Count > 0)
            {
                ShowRecipeForm(gData.SelectedRows[0].Index);
            }
        }

        private void GData_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                ShowRecipeForm(e.RowIndex);
            }

        }

        private void BtnNewRecipe_Click(object? sender, EventArgs e)
        {
            ((frmMain)MdiParent).OpenForm(typeof(frmSingleRecipe));
        }


    }
}
