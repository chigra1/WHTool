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
    }
}
