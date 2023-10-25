
namespace RecipeWinsForms
{
    public partial class frmSingleRecipe : Form
    {
        int recipeid = 0;
        DataTable dtrecipe = new();
        DataRow? row;
        BindingSource bindsource = new();
        public frmSingleRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;

        }


        public void LoadForm(int recipeid)
        {
            dtrecipe = RecipeSystem.LoadRecipe(recipeid);
            bindsource.DataSource = dtrecipe;

            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();

            }
#if DEBUG
            SQLUtility.DebugPrintDataTable(dtrecipe);
#endif 
            DataTable dtusers = RecipeSystem.GetUserList();
            DataTable dtcuisine = RecipeSystem.GetCuisineList();

            WindowsFormsUtility.SetListBinding(lstCuisineName, dtcuisine, dtrecipe, "Cuisine");

            WindowsFormsUtility.SetControlBinding(txtRecipeName, bindsource);
            WindowsFormsUtility.SetControlBinding(txtCalories, bindsource);
            WindowsFormsUtility.SetControlBinding(lblRecipeStatus, bindsource);

            //Setting the row here so I shouldn't have to do it in 2 other places, so I am doing it here where it will run upon start and storing it in a variable for the entire form
            row = dtrecipe.Rows[0];
            this.recipeid = recipeid;
        }
        private void Save()
        {
            Application.UseWaitCursor = true;
            try
            {
                RecipeSystem.SaveRecipe(dtrecipe, row);
                //Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe App");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        private void Delete()
        {
            DialogResult answer = MessageBox.Show("Are you sure you want to delete this recipe?", "Recipe App", MessageBoxButtons.YesNo);
            if (answer == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                RecipeSystem.DeleteRecipe(row);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
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


