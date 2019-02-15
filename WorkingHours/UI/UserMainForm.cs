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
        DateTime selectedDate;

        public UserMainForm()
        {
            InitializeComponent();
        }

        public UserMainForm(Employee user)
        {
            InitializeComponent();
            this.user = user;

            calendar.SomethingHappened += HandleSomethingHappening;
            calendar.RectangleClick += HandleRectangleClick;
        }

        public void HandleSomethingHappening(object sender, EventArgs e)
        {
            CalendarEvent cevent = (CalendarEvent)sender;

            DBStore store = new DBStore();
            store.DeleteWorkingHours(cevent.Event.InsertId);
        }

        public void HandleRectangleClick(object sender, EventArgs e)
        {
            DateTime date = (DateTime)sender;
            selectedDate = date;
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
                if (selectedDate != null)
                {
                    DBStore store = new DBStore();
                    store.AddWorkingHours(projectID, selectedDate.ToString("yyyy-MM-dd"), tbNumberOFHours.Text);

                    calendar.RemoveAllEvents();
                    LoadHoursForCurrentUser();
                }
                else
                {
                    MessageBox.Show("Please select date");
                }             
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

            calendar.CalendarView = CalendarViews.Month;
            calendar.AllowEditingEvents = true;

            calendar.IsAccessible = true;
            calendar.Enabled = true;
        }
    }
}
