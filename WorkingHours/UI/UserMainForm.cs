using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using WorkingHours.Common;
using WorkingHours.Database;
using WorkingHours.Projects;

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
            DataSet ds = new DataSet();
            DBRetrieve retrieve = new DBRetrieve();
            ds = retrieve.GetWorkingHoursForCurrentMonth(user);
            List<Project> list = retrieve.GetAllProjects();

            foreach (Project project in list)
            {
                cmbProjects.Items.Add(project.name);
            }

            this.dgvWorkingHours.DataSource = null;
            this.dgvWorkingHours.Rows.Clear();
            this.dgvWorkingHours.Columns.Clear();

            if (ds.Tables.Count != 0)
            {
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
}
