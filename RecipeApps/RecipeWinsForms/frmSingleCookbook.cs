﻿namespace RecipeWinsForms
{

    public partial class frmSingleCookbook : Form
    {
        DataTable dtcookbook = new();
        DataTable dtcookbookrecipe = new();
        BindingSource bindsource = new();
        DataRow row;
        bool firstactivation = true;
        string deletecolname = "Delete";
        string orgfrmtext = "Cookbook - ";
        string cookbookname = string.Empty;
        int cookbookid = 0;
        public frmSingleCookbook()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnSaveRecipe.Click += BtnSaveRecipe_Click;
            gDataRecipe.CellContentClick += GDataRecipe_CellContentClick;
            FormClosing += FrmSingleCookbook_FormClosing;
            Activated += FrmSingleCookbook_Activated;
        }


        public void LoadCookbook(int bookid = 0)
        {
            DataTable dtusers = new();
            cookbookid = bookid;
            Cursor = Cursors.WaitCursor;
            try
            {
                dtcookbook = Cookbooks.SingleCookbookGet(cookbookid);
                bindsource.DataSource = dtcookbook;

                if (bookid == 0)
                {
                    dtcookbook.Rows.Add();
                    dtcookbook.AcceptChanges();
                }
                row = dtcookbook.Rows[0];

                WindowsFormsUtility.SetControlBinding(txtBookName, bindsource);
                WindowsFormsUtility.SetControlBinding(txtPrice, bindsource);
                WindowsFormsUtility.SetControlBinding(txtDateCreated, bindsource);
                WindowsFormsUtility.SetControlBinding(chkIsActive, bindsource);
                WindowsFormsUtility.SetListBinding(lstUserName, DataMaintenance.GetDataList("Users", true), dtcookbook, "Users");
                SetEnabledButtons();

                Show(); //Show should be before LoadCookbookRecipes() to avoid mix up in columns in grid
                LoadCookbookRecipes();
                cookbookname = RecipeSystem.GetMainColumnNameValue(row, "Book");
                this.Tag = cookbookid;
                this.Text = orgfrmtext + cookbookname;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally { Cursor = Cursors.Default; }
        }


        private void LoadCookbookRecipes()
        {
            dtcookbookrecipe = Cookbooks.LoadRecipeByCookbookId(cookbookid);
            gDataRecipe.Columns.Clear();
            gDataRecipe.DataSource = dtcookbookrecipe;
            WindowsFormsUtility.AddComboBoxToGrid(gDataRecipe, DataMaintenance.GetDataList("Recipe", true), "Recipe", "RecipeName");
            WindowsFormsUtility.AddDeleteButtonToGrid(gDataRecipe, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gDataRecipe);

        }


        private bool Save()
        {
            bool saved = false;

            Cursor = Cursors.WaitCursor;
            try
            {
                Cookbooks.SaveCookbook(dtcookbook);
                cookbookid = SQLUtility.GetValueFromFirstRowAsInt(dtcookbook, "CookbookID");
                this.Tag = cookbookid;
                cookbookname = RecipeSystem.GetMainColumnNameValue(row, "Book");
                this.Text = orgfrmtext + cookbookname;
                bindsource.ResetBindings(false);
                SetEnabledButtons();
                GlobalVariables.reloadcookbooklist = true;
                GlobalVariables.reloaddashboard = true;
                saved = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally { Cursor = Cursors.Default; }
            return saved;
        }
        private void Delete()
        {
            DialogResult answer = MessageBox.Show($"Are you sure you want to delete this cookbook '{cookbookname}'?", "Recipe App", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {

                Application.UseWaitCursor = true;
                try
                {
                    Cookbooks.DeleteCookbook(row);
                    GlobalVariables.reloadcookbooklist = true;
                    GlobalVariables.reloaddashboard = true;
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
        private bool SaveCookbookRecipe()
        {
            bool saved = false;
            Cursor = Cursors.WaitCursor;
            try
            {
                Cookbooks.SaveCookbookRecipe(dtcookbookrecipe, cookbookid);
                saved = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
                LoadCookbookRecipes();
            }
            finally { Cursor = Cursors.Default; }
            return saved;
        }
        private void DeleteRecipeFromCookbook(int rowindex)
        {
            var ans = MessageBox.Show("Are you sure you want to delete this recipe from the cookbook?", Application.ProductName, MessageBoxButtons.YesNo);
            if (ans == DialogResult.Yes)
            {
                int recordid = WindowsFormsUtility.GetIdFromGrid(gDataRecipe, rowindex, "CookbookRecipeID");

                if (recordid > 0)
                {
                    try
                    {
                        Cookbooks.DeleteCookbookRecipe(recordid);
                        LoadCookbookRecipes();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName);
                    }
                }
                else if (recordid == 0 && rowindex < gDataRecipe.Rows.Count)
                {
                    gDataRecipe.Rows.RemoveAt(rowindex);
                }
            }
        }
        private void SetEnabledButtons()
        {
            btnDelete.Enabled = cookbookid == 0 ? false : true;
            btnSaveRecipe.Enabled = cookbookid == 0 ? false : true;
        }
        private void FrmSingleCookbook_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bool cookbooksaved = true;
            bool recipesaved = true;
            bindsource.EndEdit();

            bool change = CheckSaveForAllTables(out string changedtables, out bool recipechange, out bool cookbookchange);

            string msg = $"You have unsaved changes in the following table(s) - {changedtables}. Do you want to save changes before closing?";

            if (change)
            {
                DialogResult ans = MessageBox.Show(msg, Application.ProductName, MessageBoxButtons.YesNoCancel);
                if (ans == DialogResult.Yes)
                {
                    if (cookbookchange)
                    {
                        cookbooksaved = Save();
                    }
                    if (recipechange)
                    {
                        recipesaved = SaveCookbookRecipe();
                    }

                    if (recipesaved == false || cookbooksaved == false)
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
        private bool CheckSaveForAllTables(out string changedtables, out bool recipechange, out bool cookbookchange)
        {
            recipechange = SQLUtility.TableHasChanges(dtcookbookrecipe);
            cookbookchange = SQLUtility.TableHasChanges(dtcookbook);

            changedtables = cookbookchange ? "Cookbook, " : "";
            changedtables += recipechange ? "Recipes" : "";

            changedtables = changedtables.TrimEnd().TrimEnd(',');

            return recipechange || cookbookchange;
        }
        private void FrmSingleCookbook_Activated(object? sender, EventArgs e)
        {
            if (firstactivation == false && GlobalVariables.reloadcookbookrecipe)
            {
                LoadCookbookRecipes();
                GlobalVariables.reloadcookbookrecipe = false;
            }
            firstactivation = false;
        }
        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }
        private void BtnSaveRecipe_Click(object? sender, EventArgs e)
        {
            SaveCookbookRecipe();
        }
        private void GDataRecipe_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {

            if (gDataRecipe.Columns[e.ColumnIndex].Name == deletecolname)
            {
                DeleteRecipeFromCookbook(e.RowIndex);
            }
        }
    }
}