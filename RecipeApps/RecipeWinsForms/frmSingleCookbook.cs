namespace RecipeWinsForms
{

    public partial class frmSingleCookbook : Form
    {
        DataTable dtcookbook = new();
        DataTable dtrecipe = new();
        BindingSource bindsource = new();
        DataRow row;
        string deletecolname = "Delete";
        string orgfrmtext = "Cookbook - ";
        string cookbookname = string.Empty;
        int cookbookid = 0;
        public frmSingleCookbook()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
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
            dtrecipe = RecipeChildrenRecords.LoadChildById(cookbookid, "CookbookRecipeGet", "CookbookID");
            gDataRecipe.Columns.Clear();
            gDataRecipe.DataSource = dtrecipe;
            WindowsFormsUtility.AddComboBoxToGrid(gDataRecipe, DataMaintenance.GetDataList("Recipe", true), "Recipe", "RecipeName");
            WindowsFormsUtility.AddDeleteButtonToGrid(gDataRecipe, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gDataRecipe);
        }


        private void Save()
        {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally { Cursor = Cursors.Default; }
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

        private void SetEnabledButtons()
        {
            btnDelete.Enabled = cookbookid == 0 ? false : true;
            btnSaveRecipe.Enabled = cookbookid == 0 ? false : true;
        }
        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }
    }
}
