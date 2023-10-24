namespace RecipeWinsForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.Shown += FrmMain_Shown;
            MnuDashboard.Click += MnuDashboard_Click;
        }

        public void OpenForm(Type frmtype)
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
                    newfrm = new frmSingleRecipe();
                }
                if (newfrm != null)
                {
                    newfrm.MdiParent = this;
                    newfrm.WindowState = FormWindowState.Maximized;
                    newfrm.FormClosed += Newfrm_FormClosed;
                    newfrm.Show();
                }
            }
        }

        private void Newfrm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            WindowsFormsUtility.SetUpNav(tsMain);
        }

        private void FrmMain_Shown(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDashboard));
            WindowsFormsUtility.SetUpNav(tsMain);
        }

        private void MnuDashboard_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDashboard));
        }
    }
}
