namespace RecipeWinsForms
{
    public partial class frmRecipeList : Form
    {
        public frmRecipeList()
        {
            InitializeComponent();
            BindData();
        }

        private void BindData()
        {
            gData.DataSource = RecipeList.GetRecipeSummary();
            WindowsFormsUtility.FormatGridForSearchResults(gData);
        }
    }
}
