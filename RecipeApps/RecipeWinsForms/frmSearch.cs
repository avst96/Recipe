using CPUFramework;
using System.Data;

namespace RecipeWinsForms
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
            FormatGrid();
            btnSearch.Click += BtnSearch_Click;
            gRecipes.CellDoubleClick += GRecipes_CellDoubleClick;
        }

        private void GRecipes_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchForRecipe(string recipename)
        {
            string sql = "select RecipeID, RecipeName from Recipe where RecipeName like '%" + recipename + "%'";
            DataTable dt = SQLUtility.GetDataTable(sql);
            gRecipes.DataSource = dt;
            gRecipes.Columns["RecipeID"].Visible = false;
        }
        private void FormatGrid()
        {
            gRecipes.AllowUserToAddRows = false;
            gRecipes.ReadOnly = true;
            gRecipes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gRecipes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            SearchForRecipe(txtRecipeName.Text);
        }
    }
}
