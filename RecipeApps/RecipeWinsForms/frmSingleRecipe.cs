
namespace RecipeWinsForms
{
    public partial class frmSingleRecipe : Form
    {
        int recipeid = 0;
        DataTable dtrecipe = new();
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
            dtrecipe = RecipeSystem.LoadRecipe(recipeid);

            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
                dtpDateDrafted.Format = DateTimePickerFormat.Custom;
            }
            SQLUtility.DebugPrintDataTable(dtrecipe);

            DataTable dtusers = RecipeSystem.GetUserList();
            DataTable dtcuisine = RecipeSystem.GetCuisineList();

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
            this.recipeid = recipeid;

            Show();
        }
        private void Save()
        {
            Application.UseWaitCursor = true;
            try
            {
                RecipeSystem.SaveRecipe(dtrecipe, row, recipeid);
                Close();
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


