using CPUFramework;
using CPUWindowsFormsFramework;
using System.Data;

namespace RecipeWinsForms
{
    public partial class frmSingleRecipe : Form
    {
        int recipeid;
        DataTable dtrecipe;
        public frmSingleRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
        }


        public void ShowForm(int recipeid)
        {


            string sql = "select r.RecipeID, r.RecipeName, r.UsersID, r.CuisineID, r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.RecipePic from Recipe r where RecipeID = " + recipeid;
            dtrecipe = SQLUtility.GetDataTable(sql);
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            SQLUtility.DebugPrintDataTable(dtrecipe);

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
        private void Save()
        {
            SQLUtility.DebugPrintDataTable(dtrecipe);
            DataRow row = dtrecipe.Rows[0];
            string sql;

            if (recipeid > 0)
            {
                sql = "update Recipe " +
                    $"set UsersID = {row["UsersID"]}, CuisineID = {row["CuisineID"]}," +
                    $"RecipeName = '{row["RecipeName"]}', Calories = {row["Calories"]}," +
                    $"DateDrafted = '{row["DateDrafted"]}' " +
                    //$"DatePublished = null, DateArchived = null ",

                    $"where RecipeID = {row["RecipeID"]}";
            }
            else
            {
                sql = "insert Recipe (UsersID, CuisineID, RecipeName, Calories, DateDrafted)" +
                    Environment.NewLine +
                    $"select {row["UsersID"]}, {row["CuisineID"]}, '{row["RecipeName"]}', {row["Calories"]}, '{row["DateDrafted"]}'";
            }
            SQLUtility.ExecuteSQL(sql);

            Close();
        }
      

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
    }
}

//Make Delete buttons work
