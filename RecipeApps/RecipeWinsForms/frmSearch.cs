﻿
namespace RecipeWinsForms
{
    public partial class frmSearch : Form
    {
        DataTable recipetable;
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
            int recipeid = RecipeSystem.SelectRecipe(recipetable, rowindex);
            frmSingleRecipe frm = new();
            frm.ShowForm(recipeid);
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
            ShowRecipeForm(-1);
        }
    }
}
