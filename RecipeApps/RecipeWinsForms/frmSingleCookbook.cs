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
        int cookbookid = 0;
        public frmSingleCookbook()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
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
                this.Tag = cookbookid;
                this.Text = orgfrmtext + RecipeSystem.GetMainColumnNameValue(dtcookbook.Rows[0], "Book");
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
                this.Text = orgfrmtext + RecipeSystem.GetMainColumnNameValue(row, "Book");
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

        private void SetEnabledButtons()
        {
            btnDelete.Enabled = cookbookid == 0 ? false : true;
            btnSaveRecipe.Enabled = cookbookid == 0 ? false : true;
        }
        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
    }
}
