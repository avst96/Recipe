using System.Data.SqlClient;

namespace RecipeWinsForms
{
    public partial class frmMealList : Form
    {
        bool notfirstactivation = false;
        public frmMealList()
        {
            InitializeComponent();
            BindData();
            Activated += FrmMealList_Activated;
        }

        private void BindData()
        {
            gData.Columns.Clear();
            SqlCommand cmd = SQLUtility.GetSqlCommand("MealSummaryGet");
            gData.DataSource = SQLUtility.GetDataTable(cmd);
            WindowsFormsUtility.FormatGridForSearchResults(gData);
        }
        private void FrmMealList_Activated(object? sender, EventArgs e)
        {
            if (notfirstactivation && GlobalVariables.reloadmeallist)
            {
                BindData();
            }
            notfirstactivation = true;
        }
    }
}
