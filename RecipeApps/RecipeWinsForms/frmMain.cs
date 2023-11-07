namespace RecipeWinsForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.Shown += FrmMain_Shown;
            MnuDashboard.Click += MnuDashboard_Click;
            mnuListRecipe.Click += MnuListRecipe_Click;
            mnuNewRecipe.Click += MnuNewRecipe_Click;
            mnuListCookbooks.Click += MnuListCookbooks_Click;
            mnuListMeals.Click += MnuListMeals_Click;
        }



        public void OpenForm(Type frmtype, int pkvalue = 0)
        {
            bool isopen = WindowsFormsUtility.IsFormOpen(frmtype, pkvalue);
            if (isopen == false)
            {
                Form? newfrm = new();

                if (frmtype == typeof(frmDashboard)) { newfrm = new frmDashboard(); }
                else if (frmtype == typeof(frmSingleRecipe))
                {
                    frmSingleRecipe f = new frmSingleRecipe();
                    f.MdiParent = this;
                    f.LoadForm(pkvalue); //LoadForm must be after MidParent setting to avoid issues with column ordering in DataGrid
                    newfrm = f;
                }
                else if (frmtype == typeof(frmRecipeList)) { newfrm = new frmRecipeList(); }
                else if (frmtype == typeof(frmChangeStatus))
                {
                    frmChangeStatus f = new frmChangeStatus();
                    f.LoadForm(pkvalue);
                    newfrm = f;
                }
                else if (frmtype == typeof(frmCookbookList)) { newfrm = new frmCookbookList(); }
                else if (frmtype == typeof(frmSingleCookbook))
                {
                    frmSingleCookbook f = new frmSingleCookbook();
                    f.MdiParent = this;
                    f.LoadCookbook(pkvalue);
                    newfrm = f;
                }
                else if (frmtype == typeof(frmMealList)) { newfrm = new frmMealList(); }
                if (newfrm != null)
                {
                    newfrm.MdiParent = this;
                    newfrm.WindowState = FormWindowState.Maximized;
                    newfrm.FormClosed += Newfrm_FormClosed;
                    newfrm.TextChanged += Newfrm_TextChanged;

                    if (newfrm.GetType() != typeof(frmSingleRecipe)) //frmSingleRecipe already has a Show() in the LoadForm() method
                    {
                        newfrm.Show();
                    }
                }

                WindowsFormsUtility.SetUpNav(tsMain);
            }
        }

        private void Newfrm_TextChanged(object? sender, EventArgs e)
        {
            WindowsFormsUtility.SetUpNav(tsMain);
        }

        private void Newfrm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            WindowsFormsUtility.SetUpNav(tsMain);
        }

        private void FrmMain_Shown(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDashboard));

        }

        private void MnuDashboard_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDashboard));
        }
        private void MnuListRecipe_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipeList));
        }
        private void MnuNewRecipe_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmSingleRecipe));
        }
        private void MnuListCookbooks_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbookList));
        }
        private void MnuListMeals_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmMealList));
        }
    }
}
