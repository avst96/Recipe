namespace RecipeWinsForms
{
    public partial class frmDashboard : Form
    {

        public frmDashboard()
        {
            InitializeComponent();
            Activated += FrmDashboard_Activated;
            btnRecipeList.Click += BtnRecipeList_Click;
            btnCookbookList.Click += BtnCookbookList_Click;
            btnMealList.Click += BtnMealList_Click;
        }


        private void FrmDashboard_Activated(object? sender, EventArgs e)
        {
            BindData();
        }


        private void BindData()
        {
            DataTable dt = DataMaintenance.GetDashboard();
            SetButtonText(dt, "Recipes", btnRecipesCount);
            SetButtonText(dt, "Meals", btnMealsCount);
            SetButtonText(dt, "Cookbooks", btnCookbooksCount);
        }
        private void SetButtonText(DataTable dt, string recordtype, Button btn)
        {
            DataRow[] rows = dt.Select($"DashboardType = '{recordtype}'");
            if (rows.Length == 1)
            {
                btn.Text = rows[0]["DashboardText"].ToString();
            }
        }

        private void BtnRecipeList_Click(object? sender, EventArgs e)
        {
            ((frmMain)MdiParent).OpenForm(typeof(frmRecipeList));
        }
        private void BtnCookbookList_Click(object? sender, EventArgs e)
        {
            ((frmMain)MdiParent).OpenForm(typeof(frmCookbookList));
        }
        private void BtnMealList_Click(object? sender, EventArgs e)
        {
            ((frmMain)MdiParent).OpenForm(typeof(frmMealList));
        }

    }
}
