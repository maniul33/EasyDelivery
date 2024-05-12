using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyDelivery
{
    public partial class LoginCustomer : Form
    {
        public LoginCustomer()
        {
            InitializeComponent();
            userCredentialTextBox.SelectionStart = 0;
            userCredentialTextBox.SelectionLength = 0;
            userCredentialTextBox.Text = "Phone number";
            userCredentialTextBox.ForeColor = Color.Silver;
        }

        private void SignupLabel_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void userCredentialTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void userCredentialTextBox_Click(object sender, EventArgs e)
        {

        }

        private void trackButton_Click(object sender, EventArgs e)
        {
            string phoneNumber = userCredentialTextBox.Text;
            try
            {
                // Connection string
                string connectionString = DatabaseSettings.ConnectionString;

                // SQL query to check if phoneNumber exists in the collect table
                string query = "SELECT COUNT(*) FROM collect WHERE cusPhone = @PhoneNumber";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open connection
                    connection.Open();

                    // Create command with parameters
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameter for phoneNumber
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                        // Execute scalar query to get count of records with the specified phoneNumber
                        int count = (int)command.ExecuteScalar();

                        // Check if any record with the specified phoneNumber exists
                        if (count > 0)
                        {
                            new customerTracking(phoneNumber).Show();
                            this.Hide();
                            // Proceed with your logic here
                        }
                        else
                        {
                            MessageBox.Show("Phone number does not exist in the collect table.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void SignInLabel_Click(object sender, EventArgs e)
        {

        }

        private void userCredentialTextBox_Enter(object sender, EventArgs e)
        {
            if (userCredentialTextBox.Text == "Phone number")
            {
                userCredentialTextBox.Text = "";
                userCredentialTextBox.ForeColor = Color.Black;
            }
        }

        private void userCredentialTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userCredentialTextBox.Text))
            {
                userCredentialTextBox.Text = "Phone number";
                userCredentialTextBox.ForeColor = Color.Silver;
            }
        }
    }
}
