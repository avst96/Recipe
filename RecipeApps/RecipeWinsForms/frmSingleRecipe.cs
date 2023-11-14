namespace RecipeWinsForms
{
    public partial class frmSingleRecipe : Form
    {
        int recipepk = 0;
        DataTable dtrecipe = new();
        DataTable dtrecipeingredients = new();
        DataTable dtdirections = new();
        DataRow row;
        BindingSource bindsource = new();
        string deletecolumnname = "Delete";
        bool notfirstactivation = false;
        string orgfrmtext = "Recipe - ";
        string recipename = string.Empty;
        public frmSingleRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            gIngredients.CellContentClick += GIngredients_CellContentClick;
            gSteps.CellContentClick += GSteps_CellContentClick;
            btnSaveIngredients.Click += BtnSaveIngredients_Click;
            btnSaveSteps.Click += BtnSaveSteps_Click;
            btnChangeStatus.Click += BtnChangeStatus_Click;
            FormClosing += FrmSingleRecipe_FormClosing;
            Activated += FrmSingleRecipe_Activated;
            txtCalories.KeyPress += TxtCalories_KeyPress;
            gIngredients.DataError += Grid_DataError;
            gSteps.DataError += Grid_DataError;
        }


        public void LoadForm(int recipeid, bool binddata = true)
        {

            recipepk = recipeid;
            Cursor = Cursors.WaitCursor;

            try
            {

                dtrecipe = RecipeSystem.LoadRecipe(recipepk);
                bindsource.DataSource = dtrecipe;
                if (recipeid == 0)
                {
                    dtrecipe.Rows.Add();
                    dtrecipe.AcceptChanges();
                }
                if (dtrecipe.Rows.Count == 0)
                {
                    throw new Exception("This record has been deleted, this form will close.");
                }
                row = dtrecipe.Rows[0];

#if DEBUG
                SQLUtility.DebugPrintDataTable(dtrecipe);
#endif
                DataTable dtusers = RecipeSystem.GetUserList();
                DataTable dtcuisine = RecipeSystem.GetCuisineList();
                if (binddata)
                {
                    WindowsFormsUtility.SetListBinding(lstCuisineName, dtcuisine, bindsource, "Cuisine");
                    WindowsFormsUtility.SetListBinding(lstUserName, dtusers, bindsource, "Users");
                    WindowsFormsUtility.SetControlBinding(txtRecipeName, bindsource);
                    WindowsFormsUtility.SetControlBinding(txtCalories, bindsource);
                    WindowsFormsUtility.SetControlBinding(lblRecipeStatus, bindsource);
                    WindowsFormsUtility.SetControlBinding(txtDateDrafted, bindsource);
                    WindowsFormsUtility.SetControlBinding(txtDatePublished, bindsource);
                    WindowsFormsUtility.SetControlBinding(txtDateArchived, bindsource);
                }
                Show(); //Show must be before the next 2 Load() to avoid a mix up in DataGrid Columns
                LoadRecipeIngredients();
                LoadDirections();
                this.Tag = recipeid;
                recipename = RecipeSystem.GetMainColumnNameValue(row, "Recipe");
                this.Text = orgfrmtext + recipename;

                SetEnabledButtons();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, Application.ProductName);
                if (dtrecipe.Rows.Count == 0)
                {
                    Close();
                }
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }


        private void LoadDirections()
        {
            dtdirections = RecipeChildrenRecords.LoadChildById(recipepk, "DirectionsGet", "RecipeID");
            gSteps.Columns.Clear();
            gSteps.DataSource = dtdirections;
            WindowsFormsUtility.FormatGridForEdit(gSteps);
            WindowsFormsUtility.AddDeleteButtonToGrid(gSteps, deletecolumnname);
        }

        private void LoadRecipeIngredients()
        {
            dtrecipeingredients = RecipeChildrenRecords.LoadChildById(recipepk, "RecipeIngredientGet", "RecipeId");
            gIngredients.Columns.Clear();
            gIngredients.DataSource = dtrecipeingredients;
            WindowsFormsUtility.AddComboBoxToGrid(gIngredients, DataMaintenance.GetDataList("MeasuringUnit", true), "MeasuringUnit", "Unit");
            WindowsFormsUtility.AddComboBoxToGrid(gIngredients, DataMaintenance.GetDataList("Ingredient", true), "Ingredient", "IngredientName");
            WindowsFormsUtility.FormatGridForEdit(gIngredients);
            WindowsFormsUtility.AddDeleteButtonToGrid(gIngredients, deletecolumnname);
        }

        private bool Save()
        {
            Application.UseWaitCursor = true;
            bool recipesaved = false;
            try
            {
                RecipeSystem.SaveRecipe(dtrecipe, dtrecipe.Rows[0]);
                LoadForm(SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeID"), false);
                recipesaved = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return recipesaved;
        }

        private void RecipeDelete()
        {
            DialogResult answer = MessageBox.Show($"Are you sure you want to delete this recipe '{recipename}' and all related records?", "Recipe App", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
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
                        currentgrid.Rows.RemoveAt(rowindex);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
                finally { Cursor = Cursors.Default; }
            }
        }


        private bool IngredientsSave()
        {
            bool b = false;
            try
            {
                RecipeChildrenRecords.SaveChildTable(dtrecipeingredients, recipepk, RecipeChildrenRecords.ChildRecordEnum.Ingredient);
                b = true;
            }
            catch (Exception ex)
            {
                var ans = WindowsFormsUtility.MessageBoxWithReset(ex.Message);
                if (ans == DialogResult.Yes)
                {
                    LoadRecipeIngredients();
                }
            }
            return b;
        }
        private bool StepsSave()
        {
            bool b = false;
            try
            {
                RecipeChildrenRecords.SaveChildTable(dtdirections, recipepk, RecipeChildrenRecords.ChildRecordEnum.Steps);
                b = true;
            }
            catch (Exception ex)
            {
                var ans = WindowsFormsUtility.MessageBoxWithReset(ex.Message);
                if (ans == DialogResult.Yes)
                {
                    LoadDirections();
                }
            }
            return b;
        }
        private void FrmSingleRecipe_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bool recipesave = true;
            bool ingredientsave = true;
            bool stepssave = true;
            bindsource.EndEdit();
            bool change = CheckSaveForAllRecipeTables(out string changedtables, out bool recipechange, out bool ingredientchange, out bool stepschange);

            string msg = $"You have unsaved changes in the following table(s) - {changedtables}. Do you want to save changes before closing?";

            if (change)
            {
                DialogResult ans = MessageBox.Show(msg, Application.ProductName, MessageBoxButtons.YesNoCancel);
                if (ans == DialogResult.Yes)
                {
                    if (recipechange)
                    {
                        recipesave = Save();
                    }
                    if (ingredientchange)
                    {
                        ingredientsave = IngredientsSave();
                    }
                    if (stepschange)
                    {
                        stepssave = StepsSave();
                    }

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
        private bool CheckSaveForAllRecipeTables(out string changedtables, out bool recipechange, out bool ingredientchange, out bool stepschange)
        {
            recipechange = SQLUtility.TableHasChanges(dtrecipe);
            ingredientchange = SQLUtility.TableHasChanges(dtrecipeingredients);
            stepschange = SQLUtility.TableHasChanges(dtdirections);
            changedtables = recipechange ? "Recipe, " : "";
            changedtables += ingredientchange ? "Ingredients, " : "";
            changedtables += stepschange ? "Steps" : "";
            changedtables = changedtables.TrimEnd().TrimEnd(',');

            return recipechange || ingredientchange || stepschange;
        }
        private void SetEnabledButtons()
        {
            bool b = recipepk == 0 ? false : true;
            btnChangeStatus.Enabled = b;
            btnDelete.Enabled = b;
            btnSaveSteps.Enabled = b;
            btnSaveIngredients.Enabled = b;
        }

        private void FrmSingleRecipe_Activated(object? sender, EventArgs e)
        {
            if (notfirstactivation)
            {
                LoadForm(recipepk, false);
            }
            notfirstactivation = true;
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
        private void TxtCalories_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!WindowsFormsUtility.IsKeyIntOrControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void OpenChangeStatus()
        {
            frmChangeStatus frm = new frmChangeStatus(recipepk);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.FormClosing += Frm_FormClosing; ;
            frm.ShowDialog(this);
        }

        private void Frm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            LoadForm(recipepk, false);
        }
        private void BtnChangeStatus_Click(object? sender, EventArgs e)
        {
            OpenChangeStatus();
        }
        private void Grid_DataError(object? sender, DataGridViewDataErrorEventArgs e)
        {
            WindowsFormsUtility.GridErrorMsg(e);
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


