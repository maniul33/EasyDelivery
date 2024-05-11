using java.sql;
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
    public partial class adminDashboardBriefStats : Form
    {
        string deliveryId = "";
        public adminDashboardBriefStats()
        {
            InitializeComponent();
            briefStats();
        }

        private void briefStats()
        {
            string totalMerchant = "0";
            string totalRider = "0";
            string totalDelivery = "0";
            string connection = "Data Source=LAPTOP-0F2M46LC\\SQLEXPRESS;Initial Catalog=EasyDelivery;Integrated Security=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    // Query for total number of merchants
                    string merchantQuery = "SELECT COUNT(*) FROM merchant;";
                    SqlCommand merchantCmd = new SqlCommand(merchantQuery, conn);
                    totalMerchant = merchantCmd.ExecuteScalar().ToString(); // Convert int to string

                    // Query for total number of riders
                    string riderQuery = "SELECT COUNT(*) FROM rider;";
                    SqlCommand riderCmd = new SqlCommand(riderQuery, conn);
                    totalRider = riderCmd.ExecuteScalar().ToString(); // Convert int to string

                    // Query for total number of deliveries
                    string deliveryQuery = "SELECT COUNT(*) FROM [create];";
                    SqlCommand deliveryCmd = new SqlCommand(deliveryQuery, conn);
                    totalDelivery = deliveryCmd.ExecuteScalar().ToString(); // Convert int to string

                    totalMerchantLabel.Text = totalMerchant;
                    totalDeliveryLabel.Text = totalDelivery;
                    totalRiderLabel.Text = totalRider;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void searchButton_Click(object sender, EventArgs e)
        {
            deliveryId = searchTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(deliveryId))
            {
                MessageBox.Show("Please enter a valid delivery id.");
                return;
            }
            string connection = "Data Source=LAPTOP-0F2M46LC\\SQLEXPRESS;Initial Catalog=EasyDelivery;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    conn.Open();

                    string query = @"
                       SELECT m.store_id, m.store_name, m.email AS store_email, m.number AS store_phone, m.district AS store_district, 
                       m.area AS store_area, c.weight, c.productType, c.collectAmount, c.status, 
                       r.rider_name, r.rider_id, r.email AS rider_email, r.number AS rider_phone, 
                       cust.cusName, cust.cusPhone, cust.cusDistrict, cust.cusArea
                FROM [create] c
                INNER JOIN merchant m ON c.store_id = m.store_id
                INNER JOIN delivery d ON c.d_id = d.d_id
                INNER JOIN rider r ON d.rider_id = r.rider_id
                INNER JOIN collect col ON c.d_id = col.d_id
                INNER JOIN customer cust ON col.cusPhone = cust.cusPhone
                WHERE c.d_id = @DeliveryId";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@DeliveryId", deliveryId);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Populate textboxes with retrieved data
                        storeIdTextBox.Text = reader["store_id"].ToString();
                        storeNameTextBox.Text = reader["store_name"].ToString();
                        storeEmailTextBox.Text = reader["store_email"].ToString();
                        storePhoneTextBox.Text = reader["store_phone"].ToString();
                        StoreDistrictTextBox.Text = reader["store_district"].ToString();
                        storeAreaTextBox.Text = reader["store_area"].ToString();

                        weightTextBox.Text = reader["weight"].ToString();
                        productTypeTextBox.Text = reader["productType"].ToString();
                        collectTextBox.Text = reader["collectAmount"].ToString();
                        statusTextBox.Text = reader["status"].ToString();

                        riderNameTextBox.Text = reader["rider_name"].ToString();
                        riderIdTextBox.Text = reader["rider_id"].ToString();
                        riderEmailTextBox.Text = reader["rider_email"].ToString();
                        riderPhoneTextBox.Text = reader["rider_phone"].ToString();

                        cusNameTextBox.Text = reader["cusName"].ToString();
                        cusPhoneTextBox.Text = reader["cusPhone"].ToString();
                        cusDistrictTextBox.Text = reader["cusDistrict"].ToString();
                        cusAreaTextBox.Text = reader["cusArea"].ToString();

                        storeIdTextBox.ForeColor = Color.Black;
                        storeIdTextBox.ReadOnly = true;

                        storeNameTextBox.ForeColor = Color.Black;
                        storeNameTextBox.ReadOnly = true;

                        storeEmailTextBox.ForeColor = Color.Black;
                        storeEmailTextBox.ReadOnly = true;

                        storePhoneTextBox.ForeColor = Color.Black;
                        storePhoneTextBox.ReadOnly = true;

                        StoreDistrictTextBox.ForeColor = Color.Black;
                        StoreDistrictTextBox.ReadOnly = true;

                        storeAreaTextBox.ForeColor = Color.Black;
                        storeAreaTextBox.ReadOnly = true;

                        weightTextBox.ForeColor = Color.Black;
                        weightTextBox.ReadOnly = true;

                        productTypeTextBox.ForeColor = Color.Black;
                        productTypeTextBox.ReadOnly = true;

                        collectTextBox.ForeColor = Color.Black;
                        collectTextBox.ReadOnly = true;

                        statusTextBox.ForeColor = Color.Black;
                        statusTextBox.ReadOnly = true;

                        riderNameTextBox.ForeColor = Color.Black;
                        riderNameTextBox.ReadOnly = true;

                        riderIdTextBox.ForeColor = Color.Black;
                        riderIdTextBox.ReadOnly = true;

                        riderEmailTextBox.ForeColor = Color.Black;
                        riderEmailTextBox.ReadOnly = true;

                        riderPhoneTextBox.ForeColor = Color.Black;
                        riderPhoneTextBox.ReadOnly = true;

                        cusNameTextBox.ForeColor = Color.Black;
                        cusNameTextBox.ReadOnly = true;

                        cusPhoneTextBox.ForeColor = Color.Black;
                        cusPhoneTextBox.ReadOnly = true;

                        cusDistrictTextBox.ForeColor = Color.Black;
                        cusDistrictTextBox.ReadOnly = true;

                        cusAreaTextBox.ForeColor = Color.Black;
                        cusAreaTextBox.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("No data found for the provided delivery id.");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
       

        private void adminDashboardBriefStats_Load(object sender, EventArgs e)
        {

        }

        private void statusTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void weightTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void productTypeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void collectTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cusNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cusPhoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cusDistrictTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cusAreaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void riderIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void riderNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void riderPhoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void riderEmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void storeIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void storeNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void storeEmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void storePhoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StoreDistrictTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void storeAreaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalMerchantLabel_Click(object sender, EventArgs e)
        {

        }

        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "Delivery id")
            {
                searchTextBox.Text = "";
                searchTextBox.ForeColor = Color.Black;
            }
        }

        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                searchTextBox.Text = "Delivery";
                searchTextBox.ForeColor = Color.Silver;
            }
        }
    }
}
