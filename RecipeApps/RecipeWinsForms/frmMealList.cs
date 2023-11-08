using System.Data.SqlClient;

namespace RecipeWinsForms
{
    public partial class frmMealList : Form
    {
        public frmMealList()
        {
            InitializeComponent();
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
            BindData();
        }
    }
}
