namespace RecipeWinsForms
{
    public partial class frmChangeStatus : Form
    {
        BindingSource bindsource = new();
        DataTable dt = new();
        RecipeSystem.StatusEnum newstatusenum = new();
        int recipeid = 0;
        string msg = "Are you sure you want to change to status of this recipe to ";

        public frmChangeStatus()
        {
            InitializeComponent();
            btnDraft.Click += BtnDraft_Click;
            btnPublish.Click += BtnPublish_Click;
            btnArchive.Click += BtnArchive_Click;
            Activated += FrmChangeStatus_Activated;
        }

        private void FrmChangeStatus_Activated(object? sender, EventArgs e)
        {
            LoadForm(recipeid, false);
        }

        public void LoadForm(int pkvalue, bool binddata = true)
        {
            recipeid = pkvalue;
            string recipename = "";
            this.Tag = pkvalue;
            Cursor = Cursors.WaitCursor;
            try
            {
                dt = RecipeSystem.LoadRecipe(pkvalue);
                if (dt.Rows.Count > 0)
                {
                    bindsource.DataSource = dt;
                    if (binddata)
                    {
                        WindowsFormsUtility.SetControlBinding(lblRecipeName, bindsource);
                        WindowsFormsUtility.SetControlBinding(lblRecipeStatus, bindsource);
                        WindowsFormsUtility.SetControlBinding(txtDateDrafted, bindsource);
                        WindowsFormsUtility.SetControlBinding(txtDatePublished, bindsource);
                        WindowsFormsUtility.SetControlBinding(txtDateArchived, bindsource);
                    }

                    recipename = RecipeSystem.GetMainColumnNameValue(dt.Rows[0], "Recipe");
                    Text = recipename + Text;
                    SetEnabledButtons(dt.Rows[0]);
                }
                else if(dt.Rows.Count == 0) //Recipe was deleted
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally { Cursor = Cursors.Default; }
        }

        private void ChangeRecipeStatus(RecipeSystem.StatusEnum newstatusenum)
        {
            var ans = MessageBox.Show(msg + newstatusenum + "?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes)
            {
                Cursor = Cursors.WaitCursor;
                try
                {
                    RecipeSystem.SetAndSaveRecipeStatus(dt, newstatusenum);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
                finally
                {
                    Cursor = Cursors.Default;
                    SetEnabledButtons(dt.Rows[0]);
                }
            }
        }

        private void SetEnabledButtons(DataRow row)
        {
            string status = "";
            if (row != null && row.Table.Columns.Contains("RecipeStatus"))
            {
                status = row["RecipeStatus"].ToString();
            }
            btnDraft.Enabled = status == "Draft" ? false : true;
            btnPublish.Enabled = status == "Published" ? false : true;
            btnArchive.Enabled = status == "Archived" ? false : true;
        }
        private void BtnArchive_Click(object? sender, EventArgs e)
        {
            newstatusenum = RecipeSystem.StatusEnum.Archived;
            ChangeRecipeStatus(newstatusenum);
        }

        private void BtnPublish_Click(object? sender, EventArgs e)
        {
            newstatusenum = RecipeSystem.StatusEnum.Published;
            ChangeRecipeStatus(newstatusenum);
        }

        private void BtnDraft_Click(object? sender, EventArgs e)
        {
            newstatusenum = RecipeSystem.StatusEnum.Drafted;
            ChangeRecipeStatus(newstatusenum);
        }
    }
}
