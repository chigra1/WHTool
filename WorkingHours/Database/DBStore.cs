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

namespace WorkingHours.Database
{
    public class DBStore
    {
        public DataSet AddNewProject(Project project)
        {
            DataSet res = new DataSet();

            using (MySqlConnection connection = new MySqlConnection(CommonSettings.connectionString))
            {
                try
                {
                    string query = "INSERT INTO project(project_code, project_name, description, status_project_id) " +
                        "VALUES('" + project.code + "','" + project.name + "', '" + project.description + "','" + Convert.ToUInt32(project.active) + "')";

                    var dataAdapter = new MySqlDataAdapter(query, connection);
                    var commandBuilder = new MySqlCommandBuilder(dataAdapter);
                    dataAdapter.Fill(res);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    MessageBox.Show("Project added");
                }
            }
            return res;
        }

        public void AddWorkingHours(int projectID, string date, string numberOfHours)
        {
            using (MySqlConnection connection = new MySqlConnection(CommonSettings.connectionString))
            {
                string query = "INSERT INTO working_hours (employee_id, project_id, date, number_of_hours) " +
                    "VALUES ('" + SessionSettings.user.id + "', '" + projectID + "', '" + date + "', '" + numberOfHours + "');";

                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                    MessageBox.Show("Project added");
                }
            }
        }

        public void DeleteWorkingHours(int insertID)
        {
            using (MySqlConnection connection = new MySqlConnection(CommonSettings.connectionString))
            {
                string query = "DELETE FROM working_hours " +
                    "WHERE employee_id = " + SessionSettings.user.id + " AND id = " + insertID + ";";

                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

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
        }
    }
}
