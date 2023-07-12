using CPUFramework;
using CPUWindowsFormsFramework;
using System.Data;

namespace RecipeWinsForms
{
    public partial class frmSingleRecipe : Form
    {
        public frmSingleRecipe()
        {
            InitializeComponent();
        }

        public void ShowForm(int recipeid)
        {
            string sql = "select r.RecipeName, r.UsersID, r.CuisineID, r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.RecipePic from Recipe r where RecipeID = " + recipeid;
            DataTable dtrecipe = SQLUtility.GetDataTable(sql);
            DataTable dtusers = SQLUtility.GetDataTable("select UsersID, UserName from Users");
            DataTable dtcuisine = SQLUtility.GetDataTable("select CuisineID, CuisineName from Cuisine");

            WindowsFormsUtiity.SetListBinding(lstUserName, dtusers, dtrecipe, "Users");
            WindowsFormsUtiity.SetListBinding(lstCuisineName, dtcuisine, dtrecipe, "Cuisine");

            WindowsFormsUtiity.SetControlBinding(txtRecipeName, dtrecipe);
            WindowsFormsUtiity.SetControlBinding(txtCalories, dtrecipe);
            WindowsFormsUtiity.SetControlBinding(dtpDateDrafted, dtrecipe);
            WindowsFormsUtiity.SetControlBinding(txtDatePublished, dtrecipe);
            WindowsFormsUtiity.SetControlBinding(txtDateArchived, dtrecipe);
            WindowsFormsUtiity.SetControlBinding(lblRecipeStatus, dtrecipe);
            WindowsFormsUtiity.SetControlBinding(lblRecipePic, dtrecipe);

            this.Show();
        }
    }
}

//Make save and delete buttons work