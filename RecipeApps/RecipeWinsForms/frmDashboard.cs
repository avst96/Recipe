using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinsForms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            BindData();
        }

        private void BindData()
        {
            //Move out some to other method class
            SqlCommand cmd = SQLUtility.GetSqlCommand("DashboardGet");
            DataTable dt = SQLUtility.GetDataTable(cmd);
            gData.DataSource = dt;
            
            WindowsFormsUtility.FormatGridForSearchResults(gData);
        }
    }
}
