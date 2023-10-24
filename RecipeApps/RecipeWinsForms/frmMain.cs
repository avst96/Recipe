namespace RecipeWinsForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public void OpenForm(Type frmtype)
        {
            bool isopen = WindowsFormsUtility.IsFormOpen(frmtype);
            if (isopen == false)
            {
                Form? newfrm = new();

                if(frmtype == typeof(frmSearch))
                {
                    newfrm = new frmSearch();
                }
                else if (frmtype == typeof(frmSingleRecipe))
                {
                    newfrm = new frmSingleRecipe();
                }   
                if(newfrm != null)
                {
                    newfrm.MdiParent = this;
                }
            }
        }
    }
}
