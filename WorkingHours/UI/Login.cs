using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WorkingHours.Common;
using WorkingHours.Database;
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
            tbUsername.Text = "biljana.milojevic";
            tbPassword.Text = "Bilja71";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.AcceptButton = this.btnLogin;
            MySqlConnection connection;
            Common.CommonSettings.connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

            using (connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    DBRetrieve retrieve = new DBRetrieve();

                    bool UserExist = retrieve.DoesUserExist(tbUsername.Text, tbPassword.Text);

                    if (UserExist)
                    {
                        userType = checkUserType(tbUsername.Text);
                        user = new UserData(tbUsername.Text, userType);

                        switch (userType)
                        {
                            case UserType.UNKNOWN:
                                MessageBox.Show("User unknown!", "Connection unsuccesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    else
                    {
                        MessageBox.Show("Invalid username/password. Please try again.", "Connection unsuccesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Show();
                        return;
                    }
                }
                catch (MySqlException ex)
                {
                    string a = ex.Message;
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

        private UserType checkUserType(string username)
        {
            UserType type = UserType.UNKNOWN;

            DBRetrieve retrieve = new DBRetrieve();
            type = retrieve.GetUserType(username);

            return type;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
