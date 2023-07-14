using CPUFramework;
using CPUWindowsFormsFramework;
using System.Data;
using System.Diagnostics;

namespace RecipeWinsForms
{
    public partial class frmSingleRecipe : Form
    {
        int recipeid;
        DataTable dtrecipe;
        DataRow row;
        public frmSingleRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            dtpDateDrafted.Enter += DtpDateDrafted_Enter;
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

            //Setting the row here so I shouldn't have to do it in 2 other places, so I am doing it here where it will run upon start and storing it in a variable for the entire form
            row = dtrecipe.Rows[0];
            this.Show();
        }
        private void Save()
        {
            SQLUtility.DebugPrintDataTable(dtrecipe);
            string sql;

            if (recipeid > 0)
            {
                sql = "update Recipe " +
                    $"set UsersID = {row["UsersID"]}, CuisineID = {row["CuisineID"]}," +
                    $"RecipeName = '{row["RecipeName"]}', Calories = {row["Calories"]}," +
                    $"DateDrafted = '{row["DateDrafted"]}' " +

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

        private void Delete()
        {
            string sql = $"delete r from Recipe r where r.RecipeID = {row["RecipeID"]}";
            SQLUtility.ExecuteSQL(sql);

            Close();
        }

        private void DtpDateDrafted_Enter(object? sender, EventArgs e)
        {
            //Since its 2 line code thats control specific, I left it in the event handler. The first line ensures that the date is changed in order it should be recorded in the DataTable
            dtpDateDrafted.Value = DateTime.Now;
            dtpDateDrafted.Format = DateTimePickerFormat.Short;
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
    }
}


