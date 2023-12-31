﻿namespace RecipeWinsForms
{
    public partial class frmCloneRecipe : Form
    {
        public frmCloneRecipe()
        {
            InitializeComponent();
            Activated += FrmCloneRecipe_Activated;
            btnClone.Click += BtnClone_Click;
        }
        private void FrmCloneRecipe_Activated(object? sender, EventArgs e)
        {
            BindList();
        }

        private void BindList()
        {
            WindowsFormsUtility.SetListBinding(lstRecipeName, DataMaintenance.GetDataList("Recipe", true), null, "Recipe");
        }

        private void BtnClone_Click(object? sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int selectedrecipe = WindowsFormsUtility.GetIdFromComboBox(lstRecipeName);

            if (selectedrecipe == 0)
            {
                MessageBox.Show("Please select a recipe to clone", Application.ProductName);
            }
            else
            {
                try
                {
                    int primarykey = RecipeSystem.CloneRecipe(selectedrecipe);
                    ((frmMain)Owner).OpenForm(typeof(frmSingleRecipe), primarykey);
                    this.Close();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, Application.ProductName); }
                finally { Cursor = Cursors.Default; }
            }
        }
    }
}
