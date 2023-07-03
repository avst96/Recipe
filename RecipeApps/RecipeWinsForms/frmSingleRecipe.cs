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
            string sql = "select RecipeName, Calories, DateDrafted, DatePublished, DateArchived, RecipeStatus, RecipePic from Recipe where RecipeID =" + recipeid;
            DataTable dt = SQLUtility.GetDataTable(sql);
            lblRecipe.DataBindings.Add("Text", dt, "RecipeName");
            lblCalories.DataBindings.Add("Text", dt, "Calories");
            lblDateDrafted.DataBindings.Add("Text", dt, "DateDrafted");
            lblDatePublished.DataBindings.Add("Text", dt, "DatePublished");
            lblDateArchived.DataBindings.Add("Text", dt, "DateArchived");
            lblCurrentStatus.DataBindings.Add("Text", dt, "RecipeStatus");
            lblPictureFile.DataBindings.Add("Text", dt, "RecipePic");
            this.Show();
        }
    }
}

