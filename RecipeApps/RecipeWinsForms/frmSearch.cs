using CPUFramework;
using CPUWindowsFormsFramework;
using System.Data;

namespace RecipeWinsForms
{
    public partial class frmSearch : Form
    {
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
            if (rowindex > -1)
            {
                recipeid = (int)gRecipes.Rows[rowindex].Cells["RecipeID"].Value;
            }
            frmSingleRecipe frm = new();
            frm.ShowForm(recipeid);
        }

        private void GRecipes_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }

        private void SearchForRecipe(string recipename)
        {
            string sql = "select RecipeID, RecipeName, Calories, DateDrafted, DatePublished, DateArchived, RecipeStatus, RecipePic from Recipe where RecipeName like '%" + recipename + "%'";
            DataTable dt = SQLUtility.GetDataTable(sql);
            gRecipes.DataSource = dt;
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
