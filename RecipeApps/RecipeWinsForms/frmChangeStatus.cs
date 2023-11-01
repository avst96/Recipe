namespace RecipeWinsForms
{
    public partial class frmChangeStatus : Form
    {
        BindingSource bindsource = new();
        DataTable dt = new();
        public frmChangeStatus()
        {
            InitializeComponent();
            btnDraft.Click += BtnDraft_Click;
            btnPublish.Click += BtnPublish_Click;
            btnArchive.Click += BtnArchive_Click;
        }
        //! Add try catch, move out of btn click and make reusable
        //! Prompt before changing

        private void BtnArchive_Click(object? sender, EventArgs e)
        {
            dt.Rows[0]["DateArchived"] = DateTime.Now;
            RecipeSystem.SaveRecipe(dt, dt.Rows[0]);
        }

            private void BtnPublish_Click(object? sender, EventArgs e)
        {
            dt.Rows[0]["DateArchived"] = DBNull.Value;
            dt.Rows[0]["DatePublished"] = DateTime.Now;
            RecipeSystem.SaveRecipe(dt, dt.Rows[0]);
        }

        private void BtnDraft_Click(object? sender, EventArgs e)
        {
            dt.Rows[0]["DatePublished"] = DBNull.Value;
            dt.Rows[0]["DateArchived"] = DBNull.Value;
            dt.Rows[0]["DateDrafted"] = DateTime.Now;

            RecipeSystem.SaveRecipe(dt, dt.Rows[0]);
        }

        public void LoadForm(int pkvalue)
        {
            string recipename = "";
            this.Tag = pkvalue;
            dt = RecipeSystem.LoadRecipe(pkvalue);
            if (dt.Rows.Count > 0)
            {
                bindsource.DataSource = dt;

                WindowsFormsUtility.SetControlBinding(lblRecipeName, bindsource);
                WindowsFormsUtility.SetControlBinding(lblRecipeStatus, bindsource);
                WindowsFormsUtility.SetControlBinding(txtDateDrafted, bindsource);
                WindowsFormsUtility.SetControlBinding(txtDatePublished, bindsource);
                WindowsFormsUtility.SetControlBinding(txtDateArchived, bindsource);

                recipename = RecipeSystem.GetRecipeName(dt.Rows[0]);
                Text = recipename + Text;
            }
        }

    }
}
