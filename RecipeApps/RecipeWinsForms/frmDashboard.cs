using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;

namespace RecipeWinsForms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            BindData();
            btnRecipeList.Click += BtnRecipeList_Click;
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
    }
}
