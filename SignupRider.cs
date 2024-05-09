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
    public partial class SignupRider : Form
    {
        public SignupRider()
        {
            InitializeComponent();
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

        private void riderNameTextBox_Enter(object sender, EventArgs e)
        {
            if (riderNameTextBox.Text == "Rider name")
            {
                riderNameTextBox.Text = "";
                riderNameTextBox.ForeColor = Color.Black;
            }
        }

        private void riderNameTextBox_Leave(object sender, EventArgs e)
        {
            if (riderNameTextBox.Text == "")
            {
                riderNameTextBox.Text = "Rider name";
                riderNameTextBox.ForeColor = Color.Silver;
            }
        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
        private bool EmailExists(SqlConnection conn, string email)
        {
            string query = "SELECT COUNT(*) FROM rider WHERE email = @Email;";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Email", email);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private bool PhoneNumberExists(SqlConnection conn, string phoneNumber)
        {
            string query = "SELECT COUNT(*) FROM rider WHERE number = @PhoneNumber;";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(riderNameTextBox.Text) || string.IsNullOrWhiteSpace(emailTextBox.Text) || string.IsNullOrWhiteSpace(numberTextBox.Text) || string.IsNullOrWhiteSpace(passwordTextBox.Text) || string.IsNullOrWhiteSpace(bankNameTextBox.Text) || string.IsNullOrWhiteSpace(branchNameTextBox.Text) || string.IsNullOrWhiteSpace(accountNoTextBox.Text))
                {
                    MessageBox.Show("Please fill in all the required fields.");
                    return;
                }

                //1. Address of SQL Server and Database.
                string connection = "Data Source=LAPTOP-0F2M46LC\\SQLEXPRESS;Initial Catalog=EasyDelivery;Integrated Security=True;";

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
                string riderName = riderNameTextBox.Text;
                string password = passwordTextBox.Text;
                string bankName = bankNameTextBox.Text;
                string branchName = branchNameTextBox.Text;
                long accountNo;
                if (!long.TryParse(accountNoTextBox.Text, out accountNo))
                {
                    MessageBox.Show("Please enter a valid account number.");
                    return;
                }

                idGenerator i = new idGenerator();
                string id = i.createNewID("RDR");

                string query = "INSERT INTO rider (rider_id, rider_name, rider_password, r_bankName, r_branchName, r_accNo, email, number) VALUES (@RiderId, @RiderName, @Password, @BankName, @BranchName, @AccountNo, @Email, @Number);";
                // 6. Execute Query with parameters
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RiderId", id);
                cmd.Parameters.AddWithValue("@RiderName", riderName);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@BankName", bankName);
                cmd.Parameters.AddWithValue("@BranchName", branchName);
                cmd.Parameters.AddWithValue("@AccountNo", accountNo);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Number", number);

                cmd.ExecuteNonQuery();

                //7. Close Connection.
                conn.Close();

                MessageBox.Show("Congratulations, your account has been successfully created.");

                // Reset placeholders and colors
                ResetTextBox(riderNameTextBox, "Rider name", Color.Silver);
                ResetTextBox(passwordTextBox, "Password", Color.Silver);
                ResetTextBox(bankNameTextBox, "Bank name", Color.Silver);
                ResetTextBox(branchNameTextBox, "Branch name", Color.Silver);
                ResetTextBox(accountNoTextBox, "Account number", Color.Silver);
                ResetTextBox(emailTextBox, "Email address", Color.Silver);
                ResetTextBox(numberTextBox, "Phone number", Color.Silver);
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
    }
}
