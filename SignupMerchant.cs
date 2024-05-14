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
    public partial class SignupMerchant : Form
    {
        public SignupMerchant()
        {
            InitializeComponent();
            passwordTextBox.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool EmailExists(SqlConnection conn, string email)
        {
            string query = "SELECT COUNT(*) FROM merchant WHERE email = @Email;";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Email", email);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private bool PhoneNumberExists(SqlConnection conn, string phoneNumber)
        {
            string query = "SELECT COUNT(*) FROM merchant WHERE number = @PhoneNumber;";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
        private void FrontRightPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DontHaveAccountLabel_Click(object sender, EventArgs e)
        {

        }

        private void storeNameTextBox_Enter(object sender, EventArgs e)
        {
            if (storeNameTextBox.Text == "Store name")
            {
                storeNameTextBox.Text = "";
                storeNameTextBox.ForeColor = Color.Black;
            }
        }

        private void storeNameTextBox_Leave(object sender, EventArgs e)
        {
            if (storeNameTextBox.Text == "")
            {
                storeNameTextBox.Text = "Store name";
                storeNameTextBox.ForeColor = Color.Silver;
            }
        }

        private void emailTextBox_Enter(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "Email address")
            {
                emailTextBox.Text = "";
                emailTextBox.ForeColor = Color.Black;
            }
        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "")
            {
                emailTextBox.Text = "Email address";
                emailTextBox.ForeColor = Color.Silver;
            }
        }

        private void numberTextBox_Enter(object sender, EventArgs e)
        {
            if (numberTextBox.Text == "Phone number")
            {
                numberTextBox.Text = "";
                numberTextBox.ForeColor = Color.Black;
            }
        }

        private void numberTextBox_Leave(object sender, EventArgs e)
        {
            if (numberTextBox.Text == "")
            {
                numberTextBox.Text = "Phone number";
                numberTextBox.ForeColor = Color.Silver;
            }
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Password")
            {
                passwordTextBox.Text = "";
                passwordTextBox.ForeColor = Color.Black;
            }
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
            {
                passwordTextBox.Text = "Password";
                passwordTextBox.ForeColor = Color.Silver;
            }
        }

        private void bankNameTextBox_Enter(object sender, EventArgs e)
        {
            if (bankNameTextBox.Text == "Bank name")
            {
                bankNameTextBox.Text = "";
                bankNameTextBox.ForeColor = Color.Black;
            }
        }

        private void bankNameTextBox_Leave(object sender, EventArgs e)
        {
            if (bankNameTextBox.Text == "")
            {
                bankNameTextBox.Text = "Bank name";
                bankNameTextBox.ForeColor = Color.Silver;
            }
        }

        private void branchNameTextBox_Enter(object sender, EventArgs e)
        {
            if (branchNameTextBox.Text == "Branch name")
            {
                branchNameTextBox.Text = "";
                branchNameTextBox.ForeColor = Color.Black;
            }
        }

        private void branchNameTextBox_Leave(object sender, EventArgs e)
        {
            if (branchNameTextBox.Text == "")
            {
                branchNameTextBox.Text = "Branch name";
                branchNameTextBox.ForeColor = Color.Silver;
            }
        }

        private void accountNoTextBox_Enter(object sender, EventArgs e)
        {
            if (accountNoTextBox.Text == "Account number")
            {
                accountNoTextBox.Text = "";
                accountNoTextBox.ForeColor = Color.Black;
            }
        }

        private void accountNoTextBox_Leave(object sender, EventArgs e)
        {
            if (accountNoTextBox.Text == "")
            {
                accountNoTextBox.Text = "Account number";
                accountNoTextBox.ForeColor = Color.Silver;
            }
        }

        private void districtTextBox_Enter(object sender, EventArgs e)
        {
            if (districtTextBox.Text == "District")
            {
                districtTextBox.Text = "";
                districtTextBox.ForeColor = Color.Black;
            }
        }

        private void districtTextBox_Leave(object sender, EventArgs e)
        {
            if (districtTextBox.Text == "")
            {
                districtTextBox.Text = "District";
                districtTextBox.ForeColor = Color.Silver;
            }
        }

        private void areaTextBox_Enter(object sender, EventArgs e)
        {
            if (areaTextBox.Text == "Area")
            {
                areaTextBox.Text = "";
                areaTextBox.ForeColor = Color.Black;
            }
        }

        private void areaTextBox_Leave(object sender, EventArgs e)
        {
            if (areaTextBox.Text == "")
            {
                areaTextBox.Text = "Area";
                areaTextBox.ForeColor = Color.Silver;
            }
        }

        private void streetTextBox_Enter(object sender, EventArgs e)
        {
            if (streetTextBox.Text == "Street")
            {
                streetTextBox.Text = "";
                streetTextBox.ForeColor = Color.Black;
            }
        }

        private void streetTextBox_Leave(object sender, EventArgs e)
        {
            if (streetTextBox.Text == "")
            {
                streetTextBox.Text = "Street";
                streetTextBox.ForeColor = Color.Silver;
            }
        }

        private void zipTextBox_Enter(object sender, EventArgs e)
        {
            if (zipTextBox.Text == "Zip")
            {
                zipTextBox.Text = "";
                zipTextBox.ForeColor = Color.Black;
            }
        }

        private void zipTextBox_Leave(object sender, EventArgs e)
        {
            if (zipTextBox.Text == "")
            {
                zipTextBox.Text = "Zip";
                zipTextBox.ForeColor = Color.Silver;
            }
        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        //private void storeNameTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    if (storeNameTextBox.Text == "Store name")
        //    {
        //        storeNameTextBox.Text = ""; 
        //        storeNameTextBox.ForeColor = Color.Black;
        //    }
        //}

        //private void emailTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    if (emailTextBox.Text == "Email address")
        //    {
        //        emailTextBox.Text = "";
        //        emailTextBox.ForeColor = Color.Black;
        //    }
        //}

        private void numberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (numberTextBox.Text == "Phone number")
            {
                numberTextBox.Text = "";
                numberTextBox.ForeColor = Color.Black;
            }
        }

        //private void passwordTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    if (passwordTextBox.Text == "Password")
        //    {
        //        passwordTextBox.Text = "";
        //        passwordTextBox.ForeColor = Color.Black;
        //    }
        //}

        private void bankNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (bankNameTextBox.Text == "Bank name")
            {
                bankNameTextBox.Text = "";
                bankNameTextBox.ForeColor = Color.Black;
            }
        }

        private void branchNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (branchNameTextBox.Text == "Branch name")
            {
                branchNameTextBox.Text = "";
                branchNameTextBox.ForeColor = Color.Black;
            }
        }

        private void accountNoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (accountNoTextBox.Text == "Account number")
            {
                accountNoTextBox.Text = "";
                accountNoTextBox.ForeColor = Color.Black;
            }
        }

        private void districtTextBox_TextChanged(object sender, EventArgs e)
        {
            if (districtTextBox.Text == "District")
            {
                districtTextBox.Text = "";
                districtTextBox.ForeColor = Color.Black;
            }
        }

        private void areaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (areaTextBox.Text == "Area")
            {
                areaTextBox.Text = "";
                areaTextBox.ForeColor = Color.Black;
            }
        }

        private void streetTextBox_TextChanged(object sender, EventArgs e)
        {
            if (streetTextBox.Text == "Street")
            {
                streetTextBox.Text = "";
                streetTextBox.ForeColor = Color.Black;
            }
        }

        private void zipTextBox_TextChanged(object sender, EventArgs e)
        {
            if (zipTextBox.Text == "Zip")
            {
                zipTextBox.Text = "";
                zipTextBox.ForeColor = Color.Black;
            }
        }


        private void signUpButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(storeNameTextBox.Text) || string.IsNullOrWhiteSpace(emailTextBox.Text) || string.IsNullOrWhiteSpace(numberTextBox.Text) || string.IsNullOrWhiteSpace(passwordTextBox.Text) || string.IsNullOrWhiteSpace(districtTextBox.Text) || string.IsNullOrWhiteSpace(areaTextBox.Text) || string.IsNullOrWhiteSpace(zipTextBox.Text) || string.IsNullOrWhiteSpace(streetTextBox.Text) || string.IsNullOrWhiteSpace(bankNameTextBox.Text) || string.IsNullOrWhiteSpace(branchNameTextBox.Text) || string.IsNullOrWhiteSpace(accountNoTextBox.Text))
                {
                    MessageBox.Show("Please fill in all the required fields.");
                    return;
                }

                //1. Address of SQL Server and Database.
                string connection = DatabaseSettings.ConnectionString;

                //2. Establish Connection.
                SqlConnection conn = new SqlConnection(connection);

                //3. Open Connection.
                conn.Open();

                //4. Duplicate Email/Number checking.
                string email = emailTextBox.Text;
                string number = numberTextBox.Text;
                if (EmailExists(conn, email))
                {
                    MessageBox.Show("Email already exists.");
                    return;
                }

                if (PhoneNumberExists(conn, number))
                {
                    MessageBox.Show("Phone number already exists.");
                    return;
                }

                //5. Prepare Query.
                string storeName = storeNameTextBox.Text;
                string password = passwordTextBox.Text;
                string bankName = bankNameTextBox.Text;
                string branchName = branchNameTextBox.Text;
                int accountNo;
                if (!int.TryParse(accountNoTextBox.Text, out accountNo))
                {
                    MessageBox.Show("Please enter a valid account number.");
                    return;
                }
                string district = districtTextBox.Text;
                string area = areaTextBox.Text;
                string street = streetTextBox.Text;
                int zip;
                if (!int.TryParse(zipTextBox.Text, out zip))
                {
                    MessageBox.Show("Please enter a valid ZIP code.");
                    return;
                }

                idGenerator i = new idGenerator();
                string id = i.createNewID("STR");

                string query = "INSERT INTO merchant (store_id, store_name, password, bankName, branch_name, accNo, district, area, street, zip, email, number) VALUES (@StoreId, @StoreName, @Password, @BankName, @BranchName, @AccountNo, @District, @Area, @Street, @Zip, @Email, @Number);";
                // 6. Execute Query with parameters
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StoreId", id);
                cmd.Parameters.AddWithValue("@StoreName", storeName);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@BankName", bankName);
                cmd.Parameters.AddWithValue("@BranchName", branchName);
                cmd.Parameters.AddWithValue("@AccountNo", accountNo);
                cmd.Parameters.AddWithValue("@District", district);
                cmd.Parameters.AddWithValue("@Area", area);
                cmd.Parameters.AddWithValue("@Street", street);
                cmd.Parameters.AddWithValue("@Zip", zip);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Number", number);


                cmd.ExecuteNonQuery();

                //7. Close Connection.
                conn.Close();

                MessageBox.Show("Congratulations, your account has been successfully created.");

                ResetTextBox(storeNameTextBox, "Store name", Color.Silver);
                ResetTextBox(passwordTextBox, "Password", Color.Silver);
                ResetTextBox(bankNameTextBox, "Bank name", Color.Silver);
                ResetTextBox(branchNameTextBox, "Branch name", Color.Silver);
                ResetTextBox(accountNoTextBox, "Account number", Color.Silver);
                ResetTextBox(districtTextBox, "District", Color.Silver);
                ResetTextBox(areaTextBox, "Area", Color.Silver);
                ResetTextBox(streetTextBox, "Street", Color.Silver);
                ResetTextBox(emailTextBox, "Email address", Color.Silver);
                ResetTextBox(numberTextBox, "Phone number", Color.Silver);
                ResetTextBox(zipTextBox, "Zip", Color.Silver);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ResetTextBox(TextBox textBox, string placeholder, Color color)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = color;
        }

        private void storeNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
