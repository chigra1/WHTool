using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkingHours.Database;
using WorkingHours.Projects;

namespace WorkingHours.UI
{
    public partial class AddProject : Form
    {
        AdminMainForm main;

        public AddProject(AdminMainForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            Project.Active active;

            if (chkActive.Checked)
            {
                active = Project.Active.ACTIVE;
            }
            else
            {
                active = Project.Active.INACTIVE;
            }

            Project project = new Project(txtProjectName.Text, txtProjectCode.Text, txtProjectDescription.Text, active);

            DBStore store = new DBStore();
            DataSet ds = store.AddNewProject(project);

            main.dataGridViewProjects.DataSource = null;
            main.dataGridViewProjects.Rows.Clear();
            main.dataGridViewProjects.Columns.Clear();

            main.dataGridViewProjects.ReadOnly = true;
            main.dataGridViewProjects.DataSource = ds.Tables[0];
            main.dataGridViewProjects.Columns[0].HeaderText = "Project Name";
            main.dataGridViewProjects.AutoResizeColumn(0);
            main.dataGridViewProjects.Columns[1].HeaderText = "Project Code";
            main.dataGridViewProjects.AutoResizeColumn(1);
            main.dataGridViewProjects.Columns[2].HeaderText = "Project Description";
            main.dataGridViewProjects.AutoResizeColumn(2);
            main.dataGridViewProjects.Columns[3].HeaderText = "Active";
            main.dataGridViewProjects.AutoResizeColumn(3);
        }
    }
}
