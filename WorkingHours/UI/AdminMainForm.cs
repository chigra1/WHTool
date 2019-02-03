using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using WorkingHours.Common;
using WorkingHours.Database;

namespace WorkingHours.UI
{
    public partial class AdminMainForm : Form
    {
        UserData user = null;

        public AdminMainForm()
        {
            InitializeComponent();
        }

        public AdminMainForm(UserData user)
        {
            InitializeComponent();
            this.user = user;

            DisplayAllProjects();
        }

        private void DisplayAllProjects()
        {
            this.dataGridViewProjects.DataSource = null;
            this.dataGridViewProjects.Rows.Clear();
            this.dataGridViewProjects.Columns.Clear();

            DataSet ds = new DataSet();

            try
            {
                DBRetrieve retrieve = new DBRetrieve();
                ds = retrieve.GetAllProjects();

                dataGridViewProjects.ReadOnly = true;
                dataGridViewProjects.DataSource = ds.Tables[0];
                dataGridViewProjects.Columns[0].HeaderText = "Id";
                dataGridViewProjects.AutoResizeColumn(0);
                dataGridViewProjects.Columns[1].HeaderText = "Project Code";
                dataGridViewProjects.AutoResizeColumn(1);
                dataGridViewProjects.Columns[2].HeaderText = "Project Name";
                dataGridViewProjects.AutoResizeColumn(2);
                dataGridViewProjects.Columns[3].HeaderText = "Project Description";
                dataGridViewProjects.AutoResizeColumn(3);
                dataGridViewProjects.Columns[4].HeaderText = "Project Status";
                dataGridViewProjects.AutoResizeColumn(4);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            foreach (DataGridViewColumn column in dataGridViewProjects.Columns)
            {
                if (column.HeaderText == "Id")
                {
                    column.Visible = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridViewEmployees.DataSource = null;
            this.dataGridViewEmployees.Rows.Clear();
            this.dataGridViewEmployees.Columns.Clear();

            try
            {
                var select = "SELECT employee.name, employee.surname FROM employee;";
                var c = new MySqlConnection(Common.CommonSettings.connectionString);
                var dataAdapter = new MySqlDataAdapter(select, c);
                var commandBuilder = new MySqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridViewEmployees.ReadOnly = true;
                dataGridViewEmployees.DataSource = ds.Tables[0];
                dataGridViewEmployees.Columns[0].HeaderText = "Name";
                dataGridViewEmployees.AutoResizeColumn(0);
                dataGridViewEmployees.Columns[1].HeaderText = "Surname";
                dataGridViewEmployees.AutoResizeColumn(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            AddProject ap = new AddProject(this);
            ap.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.dataGridViewEmployees.DataSource = null;
            this.dataGridViewEmployees.Rows.Clear();
            this.dataGridViewEmployees.Columns.Clear();

            try
            {
                var select = "SELECT employee.name, employee.surname FROM work_hours.employee LEFT JOIN work_hours.employee_status ON employee_status.id=employee.employee_status_id where employee_status.status='EXTERNAL';";
                var c = new MySqlConnection(Common.CommonSettings.connectionString);
                var dataAdapter = new MySqlDataAdapter(select, c);
                var commandBuilder = new MySqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridViewEmployees.ReadOnly = true;
                dataGridViewEmployees.DataSource = ds.Tables[0];
                dataGridViewEmployees.Columns[0].HeaderText = "Name";
                dataGridViewEmployees.AutoResizeColumn(0);
                dataGridViewEmployees.Columns[1].HeaderText = "Surname";
                dataGridViewEmployees.AutoResizeColumn(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.dataGridViewEmployees.DataSource = null;
            this.dataGridViewEmployees.Rows.Clear();
            this.dataGridViewEmployees.Columns.Clear();

            try
            {
                var select = "SELECT employee.name, employee.surname FROM work_hours.employee LEFT JOIN work_hours.employee_status ON employee_status.id=employee.employee_status_id where employee_status.status='INTERNAL';";
                var c = new MySqlConnection(Common.CommonSettings.connectionString);
                var dataAdapter = new MySqlDataAdapter(select, c);
                var commandBuilder = new MySqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridViewEmployees.ReadOnly = true;
                dataGridViewEmployees.DataSource = ds.Tables[0];
                dataGridViewEmployees.Columns[0].HeaderText = "Name";
                dataGridViewEmployees.AutoResizeColumn(0);
                dataGridViewEmployees.Columns[1].HeaderText = "Surname";
                dataGridViewEmployees.AutoResizeColumn(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Button to exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Fill ComboBox with names of all ACTIVE projects from database
        /// </summary>
        private void comboBoxBind()
        {
            var select = "SELECT project_name FROM work_hours.project JOIN work_hours.project_status ON project.status_project_id=project_status.id WHERE project_status.status='ACTIVE';";
            MySqlConnection c = new MySqlConnection(Common.CommonSettings.connectionString);
            MySqlCommand cmdDatabase = new MySqlCommand(select, c);
            MySqlDataReader myReader;
            try
            {
                c.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    string combo = myReader.GetString("project_name");
                    cmbProjects.Items.Add(combo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            c.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxBind();
            int monthIndex = getCurrentMonth() - 1;
            cmbMonth.SelectedIndex = monthIndex;
        }

        /// <summary>
        /// Add working hours to database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddHours_Click(object sender, EventArgs e)
        {
            if (cmbProjects.SelectedIndex == -1 || String.IsNullOrEmpty(tbNumberOFHours.Text))
            {
                MessageBox.Show("Project name, number of hours and date must be selected", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                int employeeID = getEmployeeID();
                int projectID = getProjectID();

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

        /// <summary>
        /// Gets ID of employee that is adding its working hours (in case of error return -1)
        /// </summary>
        /// <returns></returns>
        public int getEmployeeID()
        {
            /* User not found if id is -1 */
            int getEmployeeId = -1;

            try
            {
                var select = "SELECT employee.id FROM work_hours.employee WHERE employee.username='" + Common.SessionSettings.user.ToString() + "';";
                var c = new MySqlConnection(Common.CommonSettings.connectionString);
                var dataAdapter = new MySqlDataAdapter(select, c);
                var commandBuilder = new MySqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    getEmployeeId = (int)ds.Tables[0].Rows[0]["id"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);              
            }
            return getEmployeeId;
        }

        /// <summary>
        /// Gets ID of project for which working hours is added (in case of error return 0)
        /// </summary>
        /// <returns></returns>
        public int getProjectID()
        {
            try
            {
                var select = "SELECT project.id FROM work_hours.project WHERE project.project_name='" + cmbProjects.SelectedItem.ToString() + "';";
                var c = new MySqlConnection(Common.CommonSettings.connectionString);
                var dataAdapter = new MySqlDataAdapter(select, c);
                var commandBuilder = new MySqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                int getProjectId = (int)ds.Tables[0].Rows[0]["id"];
                return getProjectId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int getCurrentMonth()
        {
            int month = DateTime.Now.Month;
            return month;
        }

        public void AddWorkingHours(int employeeID, int projectID)
        {
            try
            {
                var insert = "INSERT INTO work_hours.working_hours (employee_id, project_id, date, number_of_hours) VALUES ('" + employeeID + "', '" + projectID + "', '" + Calendar.SelectionRange.Start.ToString("yyyy-MM-dd") + "', '" + tbNumberOFHours.Text + "');";
                var c = new MySqlConnection(Common.CommonSettings.connectionString);
                var dataAdapter = new MySqlDataAdapter(insert, c);
                var commandBuilder = new MySqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridViewHours.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dataGridViewHours.DataSource = null;
            this.dataGridViewHours.Rows.Clear();
            this.dataGridViewHours.Columns.Clear();

            int month = cmbMonth.SelectedIndex + 1;

            try
            {
                var select = "SELECT working_hours.date, project.project_name, working_hours.number_of_hours FROM work_hours.working_hours JOIN work_hours.project ON working_hours.project_id=project.id JOIN work_hours.employee ON working_hours.employee_id=employee.id WHERE employee.username='" + user + "' AND MONTH(working_hours.date) = " + month.ToString() + " ORDER BY working_hours.date;";
                var c = new MySqlConnection(Common.CommonSettings.connectionString);
                var dataAdapter = new MySqlDataAdapter(select, c);
                var commandBuilder = new MySqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridViewHours.ReadOnly = true;
                dataGridViewHours.DataSource = ds.Tables[0];
                dataGridViewHours.Columns[0].HeaderText = "Date";
                dataGridViewHours.AutoResizeColumn(0);
                dataGridViewHours.Columns[1].HeaderText = "Project";
                dataGridViewHours.AutoResizeColumn(1);
                dataGridViewHours.Columns[2].HeaderText = "Hours";
                dataGridViewHours.AutoResizeColumn(1);
                paintHoursDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void paintHoursDataGridView()
        {
            foreach (DataGridViewRow row in dataGridViewHours.Rows)
                if (row.Index % 2 != 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Azure;
                }
        }
    }
}
