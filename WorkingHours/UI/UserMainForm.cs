using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using WorkingHours.Common;
using WorkingHours.Database;
using WorkingHours.Employees;
using WorkingHours.Projects;

namespace WorkingHours.UI
{
    public partial class UserMainForm : Form
    {
        Employee user = null;

        public UserMainForm()
        {
            InitializeComponent();
        }

        public UserMainForm(Employee user)
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

        private void btnAddWorkingHours_Click(object sender, EventArgs e)
        {
            //if (cmbProjects.SelectedIndex == -1 || String.IsNullOrEmpty(tbNumberOFHours.Text))
            //{
            //    MessageBox.Show("Project name, number of hours and date must be selected", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            //else
            //{
            //    int employeeID = user.;
            //    int projectID = getProjectID();

            //    if (employeeID < 1)
            //    {
            //        MessageBox.Show("User must be added in databse", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        return;
            //    }
            //    else
            //    {
            //        AddWorkingHours(employeeID, projectID);
            //    }
            //}
        }
    }
}
