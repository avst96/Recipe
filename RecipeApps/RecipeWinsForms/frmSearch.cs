namespace RecipeWinsForms
{
    public partial class frmSearch : Form
    {
        DataTable recipetable = new();
        public frmSearch()
        {
            InitializeComponent();
            WindowsFormsUtiity.FormatGridForSearchResults(gRecipes);
            btnSearch.Click += BtnSearch_Click;
            btnNew.Click += BtnNew_Click;
            gRecipes.CellDoubleClick += GRecipes_CellDoubleClick;
        }



        private void ShowRecipeForm(int rowindex)
        {
            int recipeid = 0;
            if (rowindex != -1) //Clicking on the header returns a -1, in which case I don't wan't to do anything
            {
                if (rowindex >= 0)
                {
                    recipeid = (int)gRecipes.Rows[rowindex].Cells["RecipeID"].Value;
                }
                frmSingleRecipe frm = new();
                frm.ShowForm(recipeid);

            }
        }

        private void GRecipes_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }

        private void SearchForRecipe(string recipename)
        {
            recipetable = RecipeSystem.SearchRecipe(recipename);
            gRecipes.DataSource = recipetable;
            gRecipes.Columns["RecipeID"].Visible = false;
        }

        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            SearchForRecipe(txtRecipeName.Text);
        }

        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm(-2);
        }
    }
}
