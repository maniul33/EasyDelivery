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
    public partial class adminRiderUpdatePanel : Form
    {
        private string riderId;
        string connection = "Data Source=LAPTOP-0F2M46LC\\SQLEXPRESS;Initial Catalog=EasyDelivery;Integrated Security=True;";

        public adminRiderUpdatePanel(string riderId)
        {
            InitializeComponent();
            this.riderId = riderId;
            searchTextBox.Text = riderId;
            // Populate textboxes
            searchButton_Click(this, EventArgs.Empty);
        }

        private void backLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrontRightPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            riderId = searchTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(riderId))
            {
                MessageBox.Show("Please enter a valid rider id.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM rider WHERE rider_id = @RiderId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@RiderId", riderId);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Populate textboxes with retrieved data
                        riderNameTextBox.Text = reader["rider_name"].ToString();
                        emailTextBox.Text = reader["email"].ToString();
                        numberTextBox.Text = reader["number"].ToString();
                        passwordTextBox.Text = reader["rider_password"].ToString();
                        bankNameTextBox.Text = reader["r_bankName"].ToString();
                        branchNameTextBox.Text = reader["r_branchName"].ToString();
                        accountNoTextBox.Text = reader["r_accNo"].ToString();

                        riderNameTextBox.ForeColor = Color.Black;
                        emailTextBox.ForeColor = Color.Black;
                        numberTextBox.ForeColor = Color.Black;
                        passwordTextBox.ForeColor = Color.Black;
                        bankNameTextBox.ForeColor = Color.Black;
                        branchNameTextBox.ForeColor = Color.Black;
                        accountNoTextBox.ForeColor = Color.Black;
                    }
                    else
                    {
                        MessageBox.Show("Rider with the provided rider id does not exist.");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string updatedRiderName = riderNameTextBox.Text.Trim();
            string updatedEmail = emailTextBox.Text.Trim();
            string updatedNumber = numberTextBox.Text.Trim();
            string updatedPassword = passwordTextBox.Text.Trim();
            string updatedBankName = bankNameTextBox.Text.Trim();
            string updatedBranchName = branchNameTextBox.Text.Trim();
            string updatedAccountNo = accountNoTextBox.Text.Trim();

            // Update the record in the database
            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    conn.Open();

                    string query = @"
                    UPDATE rider 
                    SET 
                        rider_name = @RiderName,
                        email = @Email,
                        number = @Number,
                        rider_password = @Password,
                        r_bankName = @BankName,
                        r_branchName = @BranchName,
                        r_accNo = @AccountNo
                    WHERE rider_id = @RiderId";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@RiderName", updatedRiderName);
                    cmd.Parameters.AddWithValue("@Email", updatedEmail);
                    cmd.Parameters.AddWithValue("@Number", updatedNumber);
                    cmd.Parameters.AddWithValue("@Password", updatedPassword);
                    cmd.Parameters.AddWithValue("@BankName", updatedBankName);
                    cmd.Parameters.AddWithValue("@BranchName", updatedBranchName);
                    cmd.Parameters.AddWithValue("@AccountNo", updatedAccountNo);
                    cmd.Parameters.AddWithValue("@RiderId", riderId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Rider information updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update rider information.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
