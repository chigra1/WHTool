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
    }
}
