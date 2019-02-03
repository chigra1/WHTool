using System;
using System.Data;
using System.Windows.Forms;
using WorkingHours.Common;
using WorkingHours.Database;

namespace WorkingHours.UI
{
    public partial class UserMainForm : Form
    {
        UserData user = null;

        public UserMainForm()
        {
            InitializeComponent();
        }

        public UserMainForm(UserData user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void UserMainForm_Load(object sender, EventArgs e)
        {
            DataSet ds;
            DBRetrieve retrieve = new DBRetrieve();
            ds = retrieve.GetWorkingHoursForCurrentMonth(user);

            this.dgvWorkingHours.DataSource = null;
            this.dgvWorkingHours.Rows.Clear();
            this.dgvWorkingHours.Columns.Clear();

            dgvWorkingHours.ReadOnly = true;
            dgvWorkingHours.DataSource = ds.Tables[0];
            dgvWorkingHours.Columns[0].HeaderText = "Date";
            dgvWorkingHours.AutoResizeColumn(0);
            dgvWorkingHours.Columns[1].HeaderText = "Project";
            dgvWorkingHours.AutoResizeColumn(1);
            dgvWorkingHours.Columns[2].HeaderText = "Hours";
        }
    }
}
