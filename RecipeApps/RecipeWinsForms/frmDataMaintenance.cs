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
            btnSave.Click += BtnSave_Click;
        }

        private void BindData()
        {
            dt = DataMaintenance.GetDataList(currenttableenum.ToString());
            gData.Columns.Clear();
            gData.DataSource = dt;
            WindowsFormsUtility.FormatGridForEdit(gData);
            WindowsFormsUtility.AddDeleteButtonToGrid(gData, delcolname);
        }
        private void Save()
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                DataMaintenance.SaveDataTable(dt, currenttableenum.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        private void SetUpRadioButtons()
        {
            TableNameEnum setradioenum;

            foreach (RadioButton c in flpOptions.Controls)
            {
                c.Click += C_Click;
                if (Enum.TryParse(c.Name[3..], false, out setradioenum))
                {
                    c.Tag = setradioenum;
                }
                else
                {
                    MessageBox.Show($"This form has a bug and it will not open. Please contact your developer with the following info: " +
                        $"The name property of the following radio button '{c.Text} did not match any enum in {this.Name} ", Application.ProductName);
                    this.Tag = "dont show form";
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
        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
    }
}
