namespace RecipeWinsForms
{
    public partial class frmDataMaintenance : Form
    {
        private enum TableNameEnum { Users, Cuisine, Ingredient, MeasuringUnit, Course }
        TableNameEnum currenttableenum = TableNameEnum.Users;
        DataTable dt = new();
        string delcolname = "Delete";
        public frmDataMaintenance()
        {
            InitializeComponent();
            SetUpRadioButtons();
            BindData();
        }

        private void BindData()
        {
            gData.Columns.Clear();
            dt = DataMaintenance.GetDataList(currenttableenum.ToString());
            gData.DataSource = dt;
            WindowsFormsUtility.FormatGridForEdit(gData);
            WindowsFormsUtility.AddDeleteButtonToGrid(gData, delcolname);
        }

        private void SetUpRadioButtons()
        {
            TableNameEnum setradioenum;

            foreach (RadioButton c in flpOptions.Controls)
            {
                c.Click += C_Click;
                if (Enum.TryParse(c.Name.Substring(3), false, out setradioenum))
                {
                    c.Tag = setradioenum;
                }
            }
        }

        private void C_Click(object? sender, EventArgs e)
        {
            if (sender is RadioButton rb && rb.Tag is TableNameEnum table)
            {
                currenttableenum = table;
                BindData();
            }

        }
    }
}
