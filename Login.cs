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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SignInLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void userCredential_Enter(object sender, EventArgs e)
        {
            if (userCredentialTextBox.Text == "Email address or phone number")
            {
                userCredentialTextBox.Text = "";
                userCredentialTextBox.ForeColor = Color.Black;
            }
        }

        private void userCredential_Leave(object sender, EventArgs e)
        {
            if (userCredentialTextBox.Text == "")
            {
                userCredentialTextBox.Text = "Email address or phone number";
                userCredentialTextBox.ForeColor = Color.Silver;
            }
        }

        private void userPassword_Enter(object sender, EventArgs e)
        {
            if (userPasswordTextBox.Text == "Password")
            {
                userPasswordTextBox.Text = "";
                userPasswordTextBox.ForeColor = Color.Black;
            }
        }

        private void userPassword_Leave(object sender, EventArgs e)
        {
            if (userPasswordTextBox.Text == "")
            {
                userPasswordTextBox.Text = "Password";
                userPasswordTextBox.ForeColor = Color.Silver;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void userCredentialTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string matchedId = null; // Variable to store matched ID

                if (userCredentialTextBox.Text == "admin" && userPasswordTextBox.Text == "admin")
                {
                    // Handle admin login here
                }
                else
                {
                    //1. Address of SQL Server and Database.
                    string connection = "Data Source=LAPTOP-0F2M46LC\\SQLEXPRESS;Initial Catalog=EasyDelivery;Integrated Security=True;";

                    //2. Establish Connection.
                    using (SqlConnection conn = new SqlConnection(connection))
                    {
                        //3. Open Connection.
                        conn.Open();

                        //4. Prepare Query.
                        string cred = userCredentialTextBox.Text;
                        string password = userPasswordTextBox.Text;

                        // Check if the credentials match any record in the merchant table
                        string merchantQuery = "SELECT store_id FROM merchant WHERE (email = @Email OR number = @Number) AND password = @Password;";
                        using (SqlCommand cmd = new SqlCommand(merchantQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@Email", cred);
                            cmd.Parameters.AddWithValue("@Number", cred);
                            cmd.Parameters.AddWithValue("@Password", password);

                            object merchantId = cmd.ExecuteScalar();
                            if (merchantId != null)
                            {
                                matchedId = merchantId.ToString(); // Store matched ID
                            }
                        }

                        // Check if the credentials match any record in the rider table
                        string riderQuery = "SELECT rider_id FROM rider WHERE (email = @Email OR number = @Number) AND rider_password = @Password;";
                        using (SqlCommand cmd = new SqlCommand(riderQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@Email", cred);
                            cmd.Parameters.AddWithValue("@Number", cred);
                            cmd.Parameters.AddWithValue("@Password", password);

                            object riderId = cmd.ExecuteScalar();
                            if (riderId != null)
                            {
                                matchedId = riderId.ToString(); // Store matched ID
                            }
                        }

                        if (!string.IsNullOrEmpty(matchedId))
                        {
                            // If matched ID starts with STR, redirect to Merchant Dashboard
                            if (matchedId.StartsWith("STR"))
                            {
                                //new merchantDashboard(matchedId).Show();
                                this.Hide();
                                return;
                            }
                            // If matched ID starts with RDR, redirect to Rider Dashboard
                            else if (matchedId.StartsWith("RDR"))
                            {
                                //new RiderDashboard().Show();
                                //this.Hide();
                                //return;
                            }
                        }

                        // If credentials do not match any record in either table
                        MessageBox.Show("Incorrect email or password. Please try again.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
