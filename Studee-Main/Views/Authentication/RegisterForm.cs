using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Studee_Main.Views.Authentication
{
    public partial class RegisterForm : Form
    {
        private MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void LoginText_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm logg = new LoginForm();
            logg.ShowDialog();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textboxFullname.Text) || string.IsNullOrEmpty(textboxEmail.Text) || string.IsNullOrEmpty(textboxPassword.Text))
            {
                MessageBox.Show("Please fill out all information!", "Error");
                return;
            }

            try
            {
                connection.Open();

                MySqlCommand checkUsernameCmd = new MySqlCommand("SELECT * FROM studeeDB.userinfo WHERE Username = @UserName", connection);
                checkUsernameCmd.Parameters.AddWithValue("@UserName", textboxEmail.Text);

                bool userExists = false;

                using (MySqlDataReader reader = checkUsernameCmd.ExecuteReader())
                {
                    userExists = reader.HasRows;
                }

                if (userExists)
                {
                    MessageBox.Show("Username not available!");
                }
                else
                {
                    string insertQuery = "INSERT INTO studeeDB.userinfo(`ID`, `FirstName`, `Username`, `Password`) VALUES (NULL, @FullName, @UserName, @Password)";
                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@FullName", textboxFullname.Text);
                    insertCommand.Parameters.AddWithValue("@UserName", textboxEmail.Text);
                    insertCommand.Parameters.AddWithValue("@Password", textboxPassword.Text); // Note: Secure password handling is beyond the scope of this example
                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show("Account Successfully Created!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
