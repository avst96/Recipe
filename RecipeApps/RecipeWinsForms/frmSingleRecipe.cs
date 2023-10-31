
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
        string deletecolumnname = "Delete";
        public frmSingleRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            gIngredients.CellContentClick += GIngredients_CellContentClick;
            gSteps.CellContentClick += GSteps_CellContentClick;
            btnSaveIngredients.Click += BtnSaveIngredients_Click;
            btnSaveSteps.Click += BtnSaveSteps_Click;
            FormClosing += FrmSingleRecipe_FormClosing;
        }

        private void FrmSingleRecipe_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            bool change = CheckSaveForAllRecipeTables(out string changedtables);

            string msg = $"You have unsaved changes in the following table(s) - {changedtables}. Do you want to save changes before closing?";
            //! ToDo , set up changedtables, set up save events to unsaved tables

            if (change)
            {
                DialogResult ans = MessageBox.Show(msg, Application.ProductName, MessageBoxButtons.YesNoCancel);
                if (ans == DialogResult.Yes)
                {
                    bool recipesave = Save();
                    bool ingredientsave = IngredientsSave();
                    bool stepssave = StepsSave();

                    if (recipesave == false || ingredientsave == false || stepssave == false)
                    {
                        e.Cancel = true;
                        Activate();
                    }
                }
                else if (ans == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    Activate();
                }
            }
        }


        public void LoadForm(int recipeid)
        {
            Cursor = Cursors.WaitCursor;

            try
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
                Show(); //Show must be before the next to Load() to avoid a mix up in DataGrid Columns


                LoadRecipeIngredients();
                LoadDirections();

                SetEnabledButtons();
                this.Tag = recipeid;
                this.Text = GetRecipeName(row);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void LoadDirections()
        {
            dtdirections = RecipeChildrenRecords.LoadChildById(recipeid, "DirectionsGet", "RecipeID");
            gSteps.Columns.Clear();
            gSteps.DataSource = dtdirections;
            WindowsFormsUtility.FormatGridForEdit(gSteps);
            WindowsFormsUtility.AddDeleteButtonToGrid(gSteps, deletecolumnname);
        }

        private void LoadRecipeIngredients()
        {
            dtrecipeingredients = RecipeChildrenRecords.LoadChildById(recipeid, "RecipeIngredientGet", "RecipeId");
            gIngredients.Columns.Clear();
            gIngredients.DataSource = dtrecipeingredients;
            WindowsFormsUtility.AddComboBoxToGrid(gIngredients, DataMaintenance.GetDataList("MeasuringUnit", true, false), "MeasuringUnit", "Unit");
            WindowsFormsUtility.AddComboBoxToGrid(gIngredients, DataMaintenance.GetDataList("Ingredient", true, false), "Ingredient", "IngredientName");
            WindowsFormsUtility.FormatGridForEdit(gIngredients);
            WindowsFormsUtility.AddDeleteButtonToGrid(gIngredients, deletecolumnname);
        }

        private bool Save()
        {
            Application.UseWaitCursor = true;
            bool savedrecipe = false;
            try
            {
                RecipeSystem.SaveRecipe(dtrecipe, row);
                recipeid = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeID");
                this.Tag = recipeid;
                this.Text = GetRecipeName(row);
                bindsource.ResetBindings(false);
                SetEnabledButtons();
                savedrecipe = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return savedrecipe;
        }
        private string GetRecipeName(DataRow row)
        {
            string recipename = "New Recipe";
            if (row["RecipeName"].ToString() != null)
            {
                recipename = row["RecipeName"].ToString();
                if (recipename.Length > 16)
                {
                    recipename = recipename.Substring(0, 16);
                }
            }
            return recipename;
        }
        private void RecipeDelete()
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
        private void DeleteChildRecord(RecipeChildrenRecords.ChildRecordEnum recordenum, int rowindex)
        {
            int recordid;
            DataGridView currentgrid = recordenum == RecipeChildrenRecords.ChildRecordEnum.Ingredient ? gIngredients : gSteps;
            string currentcolumn = recordenum == RecipeChildrenRecords.ChildRecordEnum.Ingredient ? "RecipeIngredientID" : "DirectionsID";
            string table = recordenum == RecipeChildrenRecords.ChildRecordEnum.Ingredient ? "Ingredients" : "Steps";

            var ans = MessageBox.Show($"Are you sure you want to delete this record from {table} table?", Application.ProductName, MessageBoxButtons.YesNo);

            if (ans == DialogResult.Yes)
            {
                recordid = WindowsFormsUtility.GetIdFromGrid(currentgrid, rowindex, currentcolumn);


                Cursor = Cursors.WaitCursor;
                try
                {
                    if (recordid > 0)
                    {
                        RecipeChildrenRecords.DeleteChildRecord(recordenum, recordid);

                        if (recordenum == RecipeChildrenRecords.ChildRecordEnum.Ingredient)
                        {
                            LoadRecipeIngredients();
                        }
                        else
                        {
                            LoadDirections();
                        }
                    }
                    else if (recordid == 0 && rowindex < currentgrid.Rows.Count)
                    {
                        currentgrid.Rows.Remove(currentgrid.Rows[rowindex]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
                finally { Cursor = Cursors.Default; }

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
        private bool IngredientsSave()
        {
            bool b = false;
            try
            {
                RecipeChildrenRecords.SaveChildTable(dtrecipeingredients, recipeid, RecipeChildrenRecords.ChildRecordEnum.Ingredient);
                b = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            return b;
        }
        private bool StepsSave()
        {
            bool b = false;
            try
            {
                RecipeChildrenRecords.SaveChildTable(dtdirections, recipeid, RecipeChildrenRecords.ChildRecordEnum.Steps);
                b = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            return b;
        }
        private bool CheckSaveForAllRecipeTables(out string changedtables)
        {
            bool recipechange = SQLUtility.TableHasChanges(dtrecipe);
            bool ingredientchange = SQLUtility.TableHasChanges(dtrecipeingredients);
            bool stepschange = SQLUtility.TableHasChanges(dtdirections);
            changedtables = recipechange ? "Recipe, " : "";
            changedtables += ingredientchange ? "Ingredients, " : "";
            changedtables += stepschange ? "Steps" : "";
            changedtables = changedtables.TrimEnd().TrimEnd(',');

            return recipechange || ingredientchange || stepschange;
        }
        private void GIngredients_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (gIngredients.Columns[e.ColumnIndex].Name == deletecolumnname)
            {
                DeleteChildRecord(RecipeChildrenRecords.ChildRecordEnum.Ingredient, e.RowIndex);

            }
        }

        private void GSteps_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (gSteps.Columns[e.ColumnIndex].Name == deletecolumnname)
            {
                DeleteChildRecord(RecipeChildrenRecords.ChildRecordEnum.Steps, e.RowIndex);
            }
        }
        private void BtnDelete_Click(object? sender, EventArgs e)
        {

            RecipeDelete();
        }

        private void BtnSaveIngredients_Click(object? sender, EventArgs e)
        {
            IngredientsSave();
        }

        private void BtnSaveSteps_Click(object? sender, EventArgs e)
        {
            StepsSave();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
    }
}


