using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkingHours.Common;
using WorkingHours.Projects;
using static WorkingHours.Common.UserData;

namespace WorkingHours.Database
{
    public class DBRetrieve
    {
        public DataSet GetWorkingHoursForCurrentMonth(UserData user)
        {
            DataSet res = new DataSet();

            using (MySqlConnection connection = new MySqlConnection(CommonSettings.connectionString))
            {
                try
                {
                    string query = "SELECT working_hours.date, project.project_name, working_hours.number_of_hours " +
                        "FROM work_hours.working_hours " +
                        "JOIN work_hours.project ON working_hours.project_id=project.id " +
                        "JOIN work_hours.employee ON working_hours.employee_id=employee.id " +
                        "WHERE employee.username='" + user.username + "' " +
                        "AND MONTH(working_hours.date) = '" + DateTime.Now.ToString("MMMM") + "' " +
                        "ORDER BY working_hours.date;";

                    var dataAdapter = new MySqlDataAdapter(query, connection);
                    var commandBuilder = new MySqlCommandBuilder(dataAdapter);
                    dataAdapter.Fill(res);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return res;
        }

        public List<Project> GetAllProjects()
        {
            List<Project> res = new List<Project>();

            using (MySqlConnection connection = new MySqlConnection(CommonSettings.connectionString))
            {
                string query = "SELECT * FROM project";

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader;

                try
                {
                    connection.Open();

                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Project project = new Project(reader["project_name"].ToString(), reader["project_code"].ToString(), reader["description"].ToString(), (Project.Active)reader["status_project_id"]);
                        res.Add(project);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return res;
        }

        public DataSet GetWorkingHoursForLoggedUser(UserData user, int month)
        {
            DataSet res = new DataSet();

            using (MySqlConnection connection = new MySqlConnection(CommonSettings.connectionString))
            {
                try
                {
                    string query = "SELECT working_hours.date, project.project_name, working_hours.number_of_hours " +
                        "FROM work_hours.working_hours " +
                        "JOIN work_hours.project " +
                        "ON working_hours.project_id=project.id " +
                        "JOIN work_hours.employee " +
                        "ON working_hours.employee_id=employee.id " +
                        "WHERE employee.username='" + user.username + "' " +
                        "AND MONTH(working_hours.date) = " + month.ToString() + " " +
                        "ORDER BY working_hours.date;";

                    var dataAdapter = new MySqlDataAdapter(query, connection);
                    var commandBuilder = new MySqlCommandBuilder(dataAdapter);
                    dataAdapter.Fill(res);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return res;
        }

        public UserType GetUserType(string username)
        {
            UserType res = UserType.UNKNOWN;

            using (MySqlConnection connection = new MySqlConnection(CommonSettings.connectionString))
            {
                string query = "SELECT user_status " +
                    "FROM user where username='" + username + "';";

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader;

                try
                {
                    connection.Open();

                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        res = (UserType)reader.GetInt32("user_status");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return res;
        }

        /// <summary>
        /// Check password for user
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool DoesUserExist(string username, string password)
        {
            bool res = false;

            using (MySqlConnection connection = new MySqlConnection(CommonSettings.connectionString))
            {
                string query = "SELECT * " +
                    "FROM user where username='" + username + "' AND password='" + password + "';";

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader;

                try
                {
                    connection.Open();

                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            res = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return res;
        }
        
    }
}
