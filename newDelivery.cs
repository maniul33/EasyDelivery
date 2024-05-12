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
    public partial class newDelivery : Form
    {
        private string store_id;
        public newDelivery(string store_id)
        {
            InitializeComponent();
            this.store_id = store_id;
        }

        private void RefreshForm()
        {
            CustomerNameTxtBox.Text = "Customer Name";
            CustomerNameTxtBox.ForeColor = Color.Silver;
            cusPhoneTextBox.Text = "Customer Phone No.";
            cusPhoneTextBox.ForeColor = Color.Silver;
            districtTextBox.Text = "District";
            districtTextBox.ForeColor = Color.Silver;
            areaTextBox.Text = "Area";
            areaTextBox.ForeColor = Color.Silver;
            zipTextBox.Text = "Zip";
            zipTextBox.ForeColor = Color.Silver;
            streetTextBox.Text = "Street";
            streetTextBox.ForeColor = Color.Silver;
            weightTextBox.Text = "Weight of Parcel (in kg)";
            weightTextBox.ForeColor = Color.Silver;
            productTypeTextBox.Text = "Product Type";
            productTypeTextBox.ForeColor = Color.Silver;
            codTextBox.Text = "Amount to collect";
            codTextBox.ForeColor = Color.Silver;
        }

        private void CustomerNameTextBox_Enter(object sender, EventArgs e)
        {
            if (CustomerNameTxtBox.Text == "Customer Name")
            {
                CustomerNameTxtBox.Text = "";
                CustomerNameTxtBox.ForeColor = Color.Black;
            }
        }

        private void CustomerNameTextBox_Leave(object sender, EventArgs e)
        {
            if (CustomerNameTxtBox.Text == "")
            {
                CustomerNameTxtBox.Text = "Customer Name";
                CustomerNameTxtBox.ForeColor = Color.Silver;
            }
        }

        private void cusPhoneTextBox_Enter(object sender, EventArgs e)
        {
            if (cusPhoneTextBox.Text == "Customer Phone No.")
            {
                cusPhoneTextBox.Text = "";
                cusPhoneTextBox.ForeColor = Color.Black;
            }
        }

        private void cusPhoneTextBox_Leave(object sender, EventArgs e)
        {
            if (cusPhoneTextBox.Text == "")
            {
                cusPhoneTextBox.Text = "Customer Phone No.";
                cusPhoneTextBox.ForeColor = Color.Silver;
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

        private void productTypeTextBox_Enter(object sender, EventArgs e)
        {
            if (productTypeTextBox.Text == "Product Type")
            {
                productTypeTextBox.Text = "";
                productTypeTextBox.ForeColor = Color.Black;
            }
        }

        private void productTypeTextBox_Leave(object sender, EventArgs e)
        {
            if (productTypeTextBox.Text == "")
            {
                productTypeTextBox.Text = "Product Type";
                productTypeTextBox.ForeColor = Color.Silver;
            }
        }

        private void codTextBox_Enter(object sender, EventArgs e)
        {
            if (codTextBox.Text == "Amount to collect")
            {
                codTextBox.Text = "";
                codTextBox.ForeColor = Color.Black;
            }
        }

        private void codTextBox_Leave(object sender, EventArgs e)
        {
            if (codTextBox.Text == "")
            {
                codTextBox.Text = "Amount to collect";
                codTextBox.ForeColor = Color.Silver;
            }
        }

        private void weightTextBox_Enter(object sender, EventArgs e)
        {
            if (weightTextBox.Text == "Weight of Parcel (in kg)")
            {
                weightTextBox.Text = "";
                weightTextBox.ForeColor = Color.Black;
            }
        }

        private void weightTextBox_Leave(object sender, EventArgs e)
        {
            if (weightTextBox.Text == "")
            {
                weightTextBox.Text = "Weight of Parcel (in kg)";
                weightTextBox.ForeColor = Color.Silver;
            }
        }

        private void createDeliveryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(CustomerNameTxtBox.Text) ||
                    string.IsNullOrWhiteSpace(cusPhoneTextBox.Text) ||
                    string.IsNullOrWhiteSpace(districtTextBox.Text) ||
                    string.IsNullOrWhiteSpace(areaTextBox.Text) ||
                    string.IsNullOrWhiteSpace(zipTextBox.Text) ||
                    string.IsNullOrWhiteSpace(streetTextBox.Text) ||
                    string.IsNullOrWhiteSpace(weightTextBox.Text) ||
                    string.IsNullOrWhiteSpace(productTypeTextBox.Text) ||
                    string.IsNullOrWhiteSpace(codTextBox.Text))
                {
                    MessageBox.Show("Please provide all the informations!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string name = CustomerNameTxtBox.Text;
                string phone = cusPhoneTextBox.Text;
                string district = districtTextBox.Text;
                string area = areaTextBox.Text;
                string zip = zipTextBox.Text;
                string street = streetTextBox.Text;
                string weight = weightTextBox.Text;
                string productType = productTypeTextBox.Text;
                string amountToCollect = codTextBox.Text;
                string orderdate = DateTime.Now.ToShortDateString();

                idGenerator idGen = new idGenerator();
                string dlvId = idGen.createNewID("DLV");

                string connectionString = DatabaseSettings.ConnectionString;

                bool customerExists = false;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string checkCustomerQuery = "SELECT COUNT(*) FROM customer WHERE cusPhone = @cusPhone";
                    using (SqlCommand command = new SqlCommand(checkCustomerQuery, connection))
                    {
                        command.Parameters.AddWithValue("@cusPhone", phone);
                        int count = (int)command.ExecuteScalar();
                        if (count > 0)
                        {
                            customerExists = true;
                        }
                    }

                    if (!customerExists)
                    {
                        string insertCustomerQuery = "INSERT INTO customer (cusName, cusPhone, cusDistrict, cusArea, cusStreet, cusZip) VALUES (@cusName, @cusPhone, @cusDistrict, @cusArea, @cusStreet, @cusZip)";
                        using (SqlCommand command = new SqlCommand(insertCustomerQuery, connection))
                        {
                            command.Parameters.AddWithValue("@cusName", name);
                            command.Parameters.AddWithValue("@cusPhone", phone);
                            command.Parameters.AddWithValue("@cusDistrict", district);
                            command.Parameters.AddWithValue("@cusArea", area);
                            command.Parameters.AddWithValue("@cusStreet", street);
                            command.Parameters.AddWithValue("@cusZip", zip);

                            command.ExecuteNonQuery();
                        }
                    }

                    string createQuery = "INSERT INTO [create] (d_id, status, weight, productType, collectAmount, store_id, orderDate) VALUES (@d_id, @status, @weight, @productType, @collectAmount, @store_id, @orderDate)";
                    using (SqlCommand command = new SqlCommand(createQuery, connection))
                    {
                        command.Parameters.AddWithValue("@d_id", dlvId);
                        command.Parameters.AddWithValue("@status", "Pending");
                        command.Parameters.AddWithValue("@weight", weight);
                        command.Parameters.AddWithValue("@productType", productType);
                        command.Parameters.AddWithValue("@collectAmount", amountToCollect);
                        command.Parameters.AddWithValue("@store_id", store_id);
                        command.Parameters.AddWithValue("@orderDate", orderdate);

                        command.ExecuteNonQuery();
                    }

                    string collectQuery = "INSERT INTO collect (d_id, status, weight, productType, collectAmount, cusPhone) VALUES (@d_id, @status, @weight, @productType, @collectAmount, @cusPhone)";
                    using (SqlCommand command = new SqlCommand(collectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@d_id", dlvId);
                        command.Parameters.AddWithValue("@status", "Pending");
                        command.Parameters.AddWithValue("@weight", weight);
                        command.Parameters.AddWithValue("@productType", productType);
                        command.Parameters.AddWithValue("@collectAmount", amountToCollect);
                        command.Parameters.AddWithValue("@cusPhone", phone);

                        command.ExecuteNonQuery();
                    }

                    string deliveryQuery = "INSERT INTO delivery (d_id, status, weight, productType, collectAmount) VALUES (@d_id, @status, @weight, @productType, @collectAmount)";
                    using (SqlCommand command = new SqlCommand(deliveryQuery, connection))
                    {
                        command.Parameters.AddWithValue("@d_id", dlvId);
                        command.Parameters.AddWithValue("@status", "Pending");
                        command.Parameters.AddWithValue("@weight", weight);
                        command.Parameters.AddWithValue("@productType", productType);
                        command.Parameters.AddWithValue("@collectAmount", amountToCollect);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Delivery created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                newDelivery form = new newDelivery(store_id);
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please provide all the valid informations!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                newDelivery form = new newDelivery(store_id);
                form.Show();
            }
        }

        private void backtoDashboardButton_Click(object sender, EventArgs e)
        {
            this.Close();
            merchantDashboard form = new merchantDashboard(store_id);
            form.Show();
        }
    }
}
