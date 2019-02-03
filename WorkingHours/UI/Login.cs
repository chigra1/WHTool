using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WorkingHours.Common;
using static WorkingHours.Common.CommonSettings;
using static WorkingHours.Common.UserData;

namespace WorkingHours.UI
{
    public partial class Login : Form
    {
        UserData user = null;
        UserType userType;

        public Login()
        {
            InitializeComponent();
            tbUsername.Text = "marko.novkovic";
            tbPassword.Text = "Marko88";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.AcceptButton = this.btnLogin;
            MySqlConnection connection;
            Common.CommonSettings.connectionString = "user id = " + tbUsername.Text + "; password = " + tbPassword.Text + "; server = 127.0.0.1; Database = work_hours; AllowPublicKeyRetrieval = true; SslMode = none";

            using (connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    userType = checkUserType();
                    user = new UserData(tbUsername.Text, userType);

                    switch (userType)
                    {
                        case UserType.UNKNOWN:
                            MessageBox.Show("User unknown!", "Connection succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Show();
                            return;
                        case UserType.Administrator:
                            MessageBox.Show("Succesfully connected to database!", "Connection succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AdminMainForm a = new AdminMainForm(user);
                            a.Show();
                            this.Hide();
                            break;
                        case UserType.RegularUser:
                            MessageBox.Show("Succesfully connected to database!", "Connection succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UserMainForm u = new UserMainForm(user);
                            u.ShowDialog();
                            this.Hide();
                            break;
                    }    
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Invalid username/password, please try again", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private UserType checkUserType()
        {
            UserType type = UserType.UNKNOWN;

            try
            {
                var select = "SELECT * FROM mysql.user where User='" + tbUsername.Text + "';";
                var c = new MySqlConnection(connectionString);
                var dataAdapter = new MySqlDataAdapter(select, c);
                var commandBuilder = new MySqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    if (ds.Tables[0].Rows[i]["Create_priv"].ToString() == "Y")
                    {
                        type = UserType.Administrator;
                    }
                    else
                    {
                        type = UserType.RegularUser;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return type;
        }
    }
}
