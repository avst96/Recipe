using CPUFramework;
using CPUWindowsFormsFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //lstCuisineName.DataBindings.Add("Text", dt, "CuisineName");

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

