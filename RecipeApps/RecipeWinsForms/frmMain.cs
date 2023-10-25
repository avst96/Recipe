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
        
        }

      

        public void OpenForm(Type frmtype, int pkvalue = 0)
        {
            bool isopen = WindowsFormsUtility.IsFormOpen(frmtype);
            if (isopen == false)
            {
                Form? newfrm = new();

                if (frmtype == typeof(frmDashboard))
                {
                    newfrm = new frmDashboard();
                }
                else if (frmtype == typeof(frmSingleRecipe))
                {
                    frmSingleRecipe f = new();
                    f.LoadForm(pkvalue); 
                    newfrm = f;
                }
                else if (frmtype == typeof(frmRecipeList))
                {
                    newfrm = new frmRecipeList();
                }
                if (newfrm != null)
                {
                    newfrm.MdiParent = this;
                    newfrm.WindowState = FormWindowState.Maximized;
                    newfrm.FormClosed += Newfrm_FormClosed;
                    newfrm.Show();
                }
                WindowsFormsUtility.SetUpNav(tsMain);
            }
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
    }
}
