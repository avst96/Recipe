namespace RecipeWinsForms
{
    public partial class frmDataMaintenance : Form
    {
        private enum TableNameEnum { Users, Cuisines, Ingredients, Measurements, Courses }
        TableNameEnum currenttableenum;
        public frmDataMaintenance()
        {
            InitializeComponent();
            SetUpRadioButtons();
        }

        private void SetUpRadioButtons()
        {
            TableNameEnum setradioenum;

            foreach (RadioButton c in flpOptions.Controls)
            {
                c.Click += C_Click;
                if (Enum.TryParse(c.Text, false, out setradioenum))
                {
                    c.Tag = setradioenum;
                }
            }
        }

        private void C_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
