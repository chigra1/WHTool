using Calendar.NET;
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

            LoadHoursForCurrentUser();

            cmbProjects.DataSource = list;
            cmbProjects.DisplayMember = "name";

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
            if (cmbProjects.SelectedIndex == -1 || String.IsNullOrEmpty(tbNumberOFHours.Text))
            {
                MessageBox.Show("Project name, number of hours and date must be selected", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Project project = (Project)cmbProjects.SelectedItem;

                int employeeID = user.id;
                int projectID = project.id;

                if (employeeID < 1)
                {
                    MessageBox.Show("User must be added in databse", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    AddWorkingHours(employeeID, projectID);
                }
            }
        }

        public void AddWorkingHours(int employeeID, int projectID)
        {
            try
            {
                DBStore store = new DBStore();
                store.AddWorkingHours(projectID, monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"), tbNumberOFHours.Text);

                calendar.RemoveAllEvents();
                
                //calendar.Dispose();
                //calendar.Show();
                //calendar.Load();
                LoadHoursForCurrentUser();
                //calendar.Refresh();
                /*dgvWorkingHours.AutoGenerateColumns = false;
                dgvWorkingHours.AutoSize = true;

                dgvWorkingHours.ReadOnly = true;
                dgvWorkingHours.DataSource = ds.Tables[0];

                dgvWorkingHours.Refresh();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadHoursForCurrentUser()
        {
            DBRetrieve retreive = new DBRetrieve();
            List<CustomEvent> events = retreive.GetWorkingHoursForLoggedUser(user, Convert.ToInt32(DateTime.Now.Month));

            foreach (CustomEvent custom in events)
            {
                calendar.AddEvent(custom);
            }

            //calendar.HighlightCurrentDay

            calendar.CalendarView = CalendarViews.Month;
            calendar.AllowEditingEvents = true;

            calendar.IsAccessible = true;
            calendar.Enabled = true;
        }

        private void calendar_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
