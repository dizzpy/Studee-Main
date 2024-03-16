using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using Studee_Main.Views;
using System.Data; // Assuming Dashboard form namespace

namespace Studee_Main.Views.Authentication
{
    public partial class LoginForm : Form
    {
        private MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");

        public LoginForm()
        {
            InitializeComponent();
        }

        private void SignUpText_Click(object sender, EventArgs e)
        {
            Hide();
            RegisterForm reg = new RegisterForm();
            reg.ShowDialog();
        }

        private void LoginButtom_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textboxEmail.Text) || string.IsNullOrEmpty(textboxPassword.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
                return;
            }

            try
            {
                connection.Open();
                string selectQuery = "SELECT * FROM studeeDB.userinfo WHERE Username = @Username AND Password = @Password;";
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                command.Parameters.AddWithValue("@Username", textboxEmail.Text);
                command.Parameters.AddWithValue("@Password", textboxPassword.Text); // Note: Secure password handling is beyond the scope of this example
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Login Successful!");
                    Hide();
                    Dashboard frm2 = new Dashboard();
                    frm2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Incorrect Login Information! Try again.");
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
