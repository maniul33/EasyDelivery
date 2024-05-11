using com.sun.org.apache.bcel.@internal.generic;
using javax.xml.crypto;
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
        public string retrievedID;
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
            new LoginCustomer().Show();
            this.Hide();
        }

        private void userCredentialTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (userCredentialTextBox.Text == "admin" && userPasswordTextBox.Text == "admin")
                {
                    new adminDashboard().Show();
                    this.Hide();
                }
                else
                {
                    string connection = "Data Source=LAPTOP-0F2M46LC\\SQLEXPRESS;Initial Catalog=EasyDelivery;Integrated Security=True;";
                    using (SqlConnection conn = new SqlConnection(connection))
                    {
                        conn.Open();
                        string credential = userCredentialTextBox.Text;
                        string password = userPasswordTextBox.Text;


                        string queryMerchant = "SELECT TOP 1 store_id FROM merchant WHERE (email = @Email OR number = @Number) AND password = @Password;";
                        string queryRider = "SELECT TOP 1 rider_id FROM rider WHERE (email = @Email OR number = @Number) AND rider_password = @Password;";

                        using (SqlCommand cmdMerchant = new SqlCommand(queryMerchant, conn))
                        using (SqlCommand cmdRider = new SqlCommand(queryRider, conn))
                        {
                            cmdMerchant.Parameters.AddWithValue("@Email", credential);
                            cmdMerchant.Parameters.AddWithValue("@Number", credential);
                            cmdMerchant.Parameters.AddWithValue("@Password", password);

                            using (SqlDataReader readerMerchant = cmdMerchant.ExecuteReader())
                            {
                                if (readerMerchant.Read())
                                {
                                    retrievedID = readerMerchant["store_id"].ToString();
                                    MessageBox.Show(retrievedID);
                                    // Redirect to Merchant Dashboard
                                    //new merchantDashboard(retrievedID).Show();
                                    // this.Hide();
                                }
                                else // If no record found in merchant table, check rider table
                                {
                                    readerMerchant.Close(); // Close the reader for merchant table

                                    // Clear parameters from cmdMerchant and reuse them for cmdRider
                                    cmdMerchant.Parameters.Clear();

                                    cmdRider.Parameters.AddWithValue("@Email", credential);
                                    cmdRider.Parameters.AddWithValue("@Number", credential);
                                    cmdRider.Parameters.AddWithValue("@Password", password);

                                    using (SqlDataReader readerRider = cmdRider.ExecuteReader())
                                    {
                                        if (readerRider.Read())
                                        {
                                            string retrievedID = readerRider["rider_id"].ToString();
                                            MessageBox.Show(retrievedID);
                                            // Redirect to Rider Dashboard
                                            // new RiderDashboard().Show();
                                            // this.Hide();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Incorrect email or password. Please try again.");
                                        }
                                    }
                                }
                            }
                        }



                        conn.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void FrontRightPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
