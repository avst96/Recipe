﻿namespace RecipeWinsForms
{
    public partial class frmRecipeList : Form
    {
        public frmRecipeList()
        {
            InitializeComponent();
            BindData();
            btnNewRecipe.Click += BtnNewRecipe_Click;
            gData.CellDoubleClick += GData_CellDoubleClick;
            gData.KeyDown += GData_KeyDown;
        }


        private void BindData()
        {
            gData.DataSource = RecipeList.GetRecipeSummary();
            WindowsFormsUtility.FormatGridForSearchResults(gData);
        }

        private void ShowRecipeForm(int rowindex)
        {
            int recipeid = 0;

            if (rowindex != -1) //Clicking on the header returns a -1, in which case I don't wan't to do anything
            {
                if (rowindex >= 0)
                {
                    recipeid = (int)gData.Rows[rowindex].Cells["RecipeID"].Value;
                }
            }
            ((frmMain)MdiParent).OpenForm(typeof(frmSingleRecipe), recipeid);
        }

        private void GData_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gData.Rows.Count > 0)
            {
                ShowRecipeForm(gData.SelectedRows[0].Index);
            }
        }

        private void GData_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);

        }

        private void BtnNewRecipe_Click(object? sender, EventArgs e)
        {
            ((frmMain)MdiParent).OpenForm(typeof(frmSingleRecipe));
        }

       
    }
}
