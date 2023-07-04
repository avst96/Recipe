using CPUFramework;
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
            string sql = "select r.RecipeName, u.UserName, c.CuisineName, r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.RecipePic from Recipe r join Users u on r.UsersID = u.UsersID join Cuisine c on r.CuisineID = c.CuisineID where RecipeID = " + recipeid;
            DataTable dt = SQLUtility.GetDataTable(sql);
            txtRecipe.DataBindings.Add("Text", dt, "RecipeName");
            txtUserName.DataBindings.Add("Text", dt, "UserName");
            txtCuisine.DataBindings.Add("Text", dt, "CuisineName");
            txtCalories.DataBindings.Add("Text", dt, "Calories");
            txtDateDrafted.DataBindings.Add("Text", dt, "DateDrafted");
            txtDatePublished.DataBindings.Add("Text", dt, "DatePublished");
            txtDateArchived.DataBindings.Add("Text", dt, "DateArchived");
            txtCurrentStatus.DataBindings.Add("Text", dt, "RecipeStatus");
            txtPictureFile.DataBindings.Add("Text", dt, "RecipePic");
            this.Show();
        }
    }
}

