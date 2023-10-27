
namespace RecipeWinsForms
{
    public partial class frmSingleRecipe : Form
    {
        int recipeid = 0;
        DataTable dtrecipe = new();
        DataTable dtrecipeingredients = new();
        DataTable dtdirections = new();
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
            WindowsFormsUtility.SetListBinding(lstUserName, dtusers, dtrecipe, "Users");
            WindowsFormsUtility.SetControlBinding(txtRecipeName, bindsource);
            WindowsFormsUtility.SetControlBinding(txtCalories, bindsource);
            WindowsFormsUtility.SetControlBinding(lblRecipeStatus, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateDrafted, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDatePublished, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateArchived, bindsource);
            row = dtrecipe.Rows[0];
            this.recipeid = recipeid;

            LoadRecipeIngredients();
            LoadDirections();

            SetEnabledButtons();
            this.Tag = recipeid;
            this.Text = GetRecipeName(row);
        }

        private void LoadDirections()
        {
            dtdirections = RecipeChildrenRecords.LoadChildById(recipeid, "DirectionsGet", "RecipeID");
            gSteps.Columns.Clear();
            gSteps.DataSource = dtdirections;
            WindowsFormsUtility.AddDeleteButtonToGrid(gSteps, "Delete");
            WindowsFormsUtility.FormatGridForEdit(gSteps);
        }

        private void LoadRecipeIngredients()
        {
            dtrecipeingredients = RecipeChildrenRecords.LoadChildById(recipeid, "RecipeIngredientGet", "RecipeId");
            gIngredients.Columns.Clear();
            WindowsFormsUtility.AddComboBoxToGrid(gIngredients, DataMaintenance.GetDataList("MeasuringUnit", true, false), "MeasuringUnit", "Unit");
            WindowsFormsUtility.AddComboBoxToGrid(gIngredients, DataMaintenance.GetDataList("Ingredient", true, false), "Ingredient", "IngredientName");
            gIngredients.DataSource = dtrecipeingredients;
            WindowsFormsUtility.AddDeleteButtonToGrid(gIngredients, "Delete");
            WindowsFormsUtility.FormatGridForEdit(gIngredients);
        }

        private void Save()
        {
            Application.UseWaitCursor = true;
            try
            {
                RecipeSystem.SaveRecipe(dtrecipe, row);
                recipeid = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeID");
                this.Tag = recipeid;
                this.Text = GetRecipeName(row);
                bindsource.ResetBindings(false);
                SetEnabledButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }
        private string GetRecipeName(DataRow row)
        {
            string recipename = "New Recipe";
            if (row["RecipeName"] != DBNull.Value)
            {
                recipename = row["RecipeName"].ToString();
                if (recipename.Length > 18)
                {
                    recipename = recipename.Substring(18);
                }
            }
            return recipename;
        }
        private void Delete()
        {
            DialogResult answer = MessageBox.Show("Are you sure you want to delete this recipe and all related records?", "Recipe App", MessageBoxButtons.YesNo);
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

        private void SetEnabledButtons()
        {
            bool b = recipeid == 0 ? false : true;
            btnDelete.Enabled = b;
            btnChangeStatus.Enabled = b;
            btnSaveSteps.Enabled = b;
            btnSaveIngredients.Enabled = b;
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


