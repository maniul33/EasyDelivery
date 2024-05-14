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
    public partial class adminMerchantUpdatePanel : Form
    {
        private string storeId;
        string connection = DatabaseSettings.ConnectionString;
        private bool showSearch = true;

        public adminMerchantUpdatePanel(string storeId)
        {
            InitializeComponent();
            this.storeId = storeId;
            searchTextBox.Text = storeId;

            searchButton_Click(this, EventArgs.Empty);
        }
        public adminMerchantUpdatePanel(string storeId, bool showSearch) : this(storeId)
        {
            this.showSearch = showSearch;
            searchTextBox.Visible = showSearch;
            searchButton.Visible = showSearch;
            UpdateLabel.Location = new Point(UpdateLabel.Location.X, 105);
        }

        private void storeNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "Store id")
            {
                searchTextBox.Text = "";
                searchTextBox.ForeColor = Color.Black;
            }
        }

        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "")
            {
                searchTextBox.Text = "Store id";
                searchTextBox.ForeColor = Color.Silver;
            }
        }

        private void storeNameTextBox_Enter_1(object sender, EventArgs e)
        {
            if (storeNameTextBox.Text == "Store name")
            {
                storeNameTextBox.Text = "";
                storeNameTextBox.ForeColor = Color.Black;
            }
        }

        private void storeNameTextBox_Leave_1(object sender, EventArgs e)
        {
            if (storeNameTextBox.Text == "")
            {
                storeNameTextBox.Text = "Store name";
                storeNameTextBox.ForeColor = Color.Silver;
            }
        }

        private void emailTextBox_Enter_1(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "Email address")
            {
                emailTextBox.Text = "";
                emailTextBox.ForeColor = Color.Black;
            }
        }

        private void emailTextBox_Leave_1(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "")
            {
                emailTextBox.Text = "Email address";
                emailTextBox.ForeColor = Color.Silver;
            }
        }

        private void numberTextBox_Enter_1(object sender, EventArgs e)
        {
            if (numberTextBox.Text == "Phone number")
            {
                numberTextBox.Text = "";
                numberTextBox.ForeColor = Color.Black;
            }
        }

        private void numberTextBox_Leave_1(object sender, EventArgs e)
        {
            if (numberTextBox.Text == "")
            {
                numberTextBox.Text = "Phone number";
                numberTextBox.ForeColor = Color.Silver;
            }
        }

        private void passwordTextBox_Enter_1(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Password")
            {
                passwordTextBox.Text = "";
                passwordTextBox.ForeColor = Color.Black;
            }
        }

        private void passwordTextBox_Leave_1(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
            {
                passwordTextBox.Text = "Password";
                passwordTextBox.ForeColor = Color.Silver;
            }
        }

        private void districtTextBox_Enter_1(object sender, EventArgs e)
        {
            if (districtTextBox.Text == "District")
            {
                districtTextBox.Text = "";
                districtTextBox.ForeColor = Color.Black;
            }
        }

        private void districtTextBox_Leave_1(object sender, EventArgs e)
        {
            if (districtTextBox.Text == "")
            {
                districtTextBox.Text = "District";
                districtTextBox.ForeColor = Color.Silver;
            }
        }

        private void areaTextBox_Enter_1(object sender, EventArgs e)
        {
            if (areaTextBox.Text == "Area")
            {
                areaTextBox.Text = "";
                areaTextBox.ForeColor = Color.Black;
            }
        }

        private void areaTextBox_Leave_1(object sender, EventArgs e)
        {
            if (areaTextBox.Text == "")
            {
                areaTextBox.Text = "Area";
                areaTextBox.ForeColor = Color.Silver;
            }
        }

        private void streetTextBox_Enter_1(object sender, EventArgs e)
        {
            if (streetTextBox.Text == "Street")
            {
                streetTextBox.Text = "";
                streetTextBox.ForeColor = Color.Black;
            }
        }

        private void streetTextBox_Leave_1(object sender, EventArgs e)
        {
            if (streetTextBox.Text == "")
            {
                streetTextBox.Text = "Street";
                streetTextBox.ForeColor = Color.Silver;
            }
        }

        private void zipTextBox_Enter_1(object sender, EventArgs e)
        {
            if (zipTextBox.Text == "Zip")
            {
                zipTextBox.Text = "";
                zipTextBox.ForeColor = Color.Black;
            }
        }

        private void zipTextBox_Leave_1(object sender, EventArgs e)
        {
            if (zipTextBox.Text == "")
            {
                zipTextBox.Text = "Zip";
                zipTextBox.ForeColor = Color.Silver;
            }
        }

        private void bankNameTextBox_Enter_1(object sender, EventArgs e)
        {
            if (bankNameTextBox.Text == "Bank name")
            {
                bankNameTextBox.Text = "";
                bankNameTextBox.ForeColor = Color.Black;
            }
        }

        private void bankNameTextBox_Leave_1(object sender, EventArgs e)
        {
            if (bankNameTextBox.Text == "")
            {
                bankNameTextBox.Text = "Bank name";
                bankNameTextBox.ForeColor = Color.Silver;
            }
        }

        private void branchNameTextBox_Enter_1(object sender, EventArgs e)
        {
            if (branchNameTextBox.Text == "Branch name")
            {
                branchNameTextBox.Text = "";
                branchNameTextBox.ForeColor = Color.Black;
            }
        }

        private void branchNameTextBox_Leave_1(object sender, EventArgs e)
        {
            if (branchNameTextBox.Text == "")
            {
                branchNameTextBox.Text = "Branch name";
                branchNameTextBox.ForeColor = Color.Silver;
            }
        }

        private void accountNoTextBox_Enter_1(object sender, EventArgs e)
        {
            if (accountNoTextBox.Text == "Account number")
            {
                accountNoTextBox.Text = "";
                accountNoTextBox.ForeColor = Color.Black;
            }
        }

        private void accountNoTextBox_Leave_1(object sender, EventArgs e)
        {
            if (accountNoTextBox.Text == "")
            {
                accountNoTextBox.Text = "Account number";
                accountNoTextBox.ForeColor = Color.Silver;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string updatedStoreName = storeNameTextBox.Text.Trim();
            string updatedEmail = emailTextBox.Text.Trim();
            string updatedNumber = numberTextBox.Text.Trim();
            string updatedPassword = passwordTextBox.Text.Trim();
            string updatedDistrict = districtTextBox.Text.Trim();
            string updatedArea = areaTextBox.Text.Trim();
            string updatedStreet = streetTextBox.Text.Trim();
            string updatedZip = zipTextBox.Text.Trim();
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
                UPDATE merchant 
                SET 
                    store_name = @StoreName,
                    email = @Email,
                    number = @Number,
                    password = @Password,
                    district = @District,
                    area = @Area,
                    street = @Street,
                    zip = @Zip,
                    bankName = @BankName,
                    branch_name = @BranchName,
                    accNo = @AccountNo
                WHERE store_id = @StoreId";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StoreName", updatedStoreName);
                    cmd.Parameters.AddWithValue("@Email", updatedEmail);
                    cmd.Parameters.AddWithValue("@Number", updatedNumber);
                    cmd.Parameters.AddWithValue("@Password", updatedPassword);
                    cmd.Parameters.AddWithValue("@District", updatedDistrict);
                    cmd.Parameters.AddWithValue("@Area", updatedArea);
                    cmd.Parameters.AddWithValue("@Street", updatedStreet);
                    cmd.Parameters.AddWithValue("@Zip", updatedZip);
                    cmd.Parameters.AddWithValue("@BankName", updatedBankName);
                    cmd.Parameters.AddWithValue("@BranchName", updatedBranchName);
                    cmd.Parameters.AddWithValue("@AccountNo", updatedAccountNo);
                    cmd.Parameters.AddWithValue("@StoreId", storeId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Merchant information updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update merchant information.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            storeId = searchTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(storeId) || storeId == "Store id")
            {
                MessageBox.Show("Please enter a valid store id.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM merchant WHERE store_id = @StoreId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StoreId", storeId);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Populate textboxes with retrieved data
                        storeNameTextBox.Text = reader["store_name"].ToString();
                        emailTextBox.Text = reader["email"].ToString();
                        numberTextBox.Text = reader["number"].ToString();
                        passwordTextBox.Text = reader["password"].ToString();
                        districtTextBox.Text = reader["district"].ToString();
                        areaTextBox.Text = reader["area"].ToString();
                        streetTextBox.Text = reader["street"].ToString();
                        zipTextBox.Text = reader["zip"].ToString();
                        bankNameTextBox.Text = reader["bankName"].ToString();
                        branchNameTextBox.Text = reader["branch_name"].ToString();
                        accountNoTextBox.Text = reader["accNo"].ToString();

                        storeNameTextBox.ForeColor = Color.Black;
                        emailTextBox.ForeColor = Color.Black;
                        numberTextBox.ForeColor = Color.Black;
                        passwordTextBox.ForeColor = Color.Black;
                        districtTextBox.ForeColor = Color.Black;
                        areaTextBox.ForeColor = Color.Black;
                        streetTextBox.ForeColor = Color.Black;
                        zipTextBox.ForeColor = Color.Black;
                        bankNameTextBox.ForeColor = Color.Black;
                        branchNameTextBox.ForeColor = Color.Black;
                        accountNoTextBox.ForeColor = Color.Black;
                    }
                    else
                    {
                        MessageBox.Show("Merchant with the provided store id does not exist.");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrontLeftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backLabel_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void passwordTextBox_MouseHover(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_MouseLeave(object sender, EventArgs e)
        {

        }

        private void FrontRightPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdateLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
