using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EasyDelivery
{

    public partial class merchantDashboard : Form
    {
        private string toDate;
        private string fromDate;
        private string store_id;


        private string connectionString = DatabaseSettings.ConnectionString;

        private void noOFDelivery()
        {
            oftPanel1.Visible = false;
            oftPanel2.Visible = false;
            oftPanel3.Visible = false;
            oftPanel4.Visible = false;

            Label l = new Label();
            oftPanel.Controls.Add(l);
            l.Text = "No deliveries to show!";
            l.TextAlign = ContentAlignment.MiddleCenter;
            l.AutoSize = false;
            l.Dock = DockStyle.Fill;

            l.Font = new Font("Bahnschrift", 18, FontStyle.Bold);
            l.ForeColor = Color.FromArgb(19, 40, 71);
        }

        private int[] getBriefStatsNumbers(DateTime fromDate, DateTime toDate, string store_id)
        {
            int[] statsNumbers = new int[3];

            string deliveredQuery = $"SELECT COUNT(*) FROM [create] WHERE store_id = @store_id AND status = 'Delivered' AND orderDate BETWEEN @fromDate AND @toDate";
            string pendingQuery = $"SELECT COUNT(*) FROM [create] WHERE store_id = @store_id AND status = 'Pending' AND orderDate BETWEEN @fromDate AND @toDate";
            string cancelledQuery = $"SELECT COUNT(*) FROM [create] WHERE store_id = @store_id AND status = 'Cancelled' AND orderDate BETWEEN @fromDate AND @toDate";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(deliveredQuery, connection))
                {
                    command.Parameters.AddWithValue("@fromDate", fromDate);
                    command.Parameters.AddWithValue("@toDate", toDate);
                    command.Parameters.AddWithValue("@store_id", store_id);

                    statsNumbers[0] = (int)command.ExecuteScalar();
                }

                using (SqlCommand command = new SqlCommand(pendingQuery, connection))
                {
                    command.Parameters.AddWithValue("@fromDate", fromDate);
                    command.Parameters.AddWithValue("@toDate", toDate);
                    command.Parameters.AddWithValue("@store_id", store_id);
                    statsNumbers[1] = (int)command.ExecuteScalar();
                }

                using (SqlCommand command = new SqlCommand(cancelledQuery, connection))
                {
                    command.Parameters.AddWithValue("@fromDate", fromDate);
                    command.Parameters.AddWithValue("@toDate", toDate);
                    command.Parameters.AddWithValue("@store_id", store_id);
                    statsNumbers[2] = (int)command.ExecuteScalar();
                }
            }

            return statsNumbers;
        }



        internal List<Delivery> getOutForDeliveryList(string store_id)
        {
            List<Delivery> outForDeliveryList = new List<Delivery>();

            string query = @"SELECT CustomerName, CustomerPhone, DeliveryID, AmountToCollect, DeliveryStatus, RiderID, RiderName
                             FROM CustomerDeliveryView
                             WHERE DeliveryStatus = 'OutForDelivery' AND store_id = @store_id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@store_id", store_id);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Delivery delivery = new Delivery(
                            reader["DeliveryID"].ToString(),
                            reader["CustomerName"].ToString(),
                            reader["CustomerPhone"].ToString(),
                            reader["AmountToCollect"].ToString(),
                            reader["DeliveryStatus"].ToString(),
                            reader["RiderID"].ToString(),
                            reader["RiderName"].ToString()
                        );

                        outForDeliveryList.Add(delivery);
                    }

                    reader.Close();
                }
            }

            return outForDeliveryList;
        }

        internal void setOfts(List<Delivery> deliveries)
        {
            if (deliveries.Count >= 1)
            {
                Delivery d1 = deliveries[0];
                name1Label.Text = d1.cus_name;
                phone1label.Text = d1.cus_phone;
                deliveryid1Label.Text = d1.d_id;
                price1Label.Text = d1.AmountToCollect;

                Delivery d2 = deliveries[1];
                name2Label.Text = d2.cus_name;
                phone2Label.Text = d2.cus_phone;
                deliveryid2Label.Text = d2.d_id;
                price2Label.Text = d2.AmountToCollect;

                Delivery d3 = deliveries[2];
                name3Label.Text = d3.cus_name;
                phone3Label.Text = d3.cus_phone;
                deliveryid3Label.Text = d3.d_id;
                price3Label.Text = d3.AmountToCollect;

                Delivery d4 = deliveries[3];
                name4Label.Text = d4.cus_name;
                phone4Label.Text = d4.cus_phone;
                deliveryid4Label.Text = d4.d_id;
                price4Label.Text = d4.AmountToCollect;
            }
            else
            {
                noOFDelivery();
            }
        }

        public merchantDashboard(string store_id)
        {
            InitializeComponent();

            this.store_id = store_id;

            DateTime today = DateTime.Today;

            toDate = today.ToString("MMM dd, yyyy");

            DateTime firstDayOfMonth = new DateTime(today.Year, today.Month, 01);
            fromDate = firstDayOfMonth.ToString("MMM dd, yyyy");

            dateBox.Text = fromDate + " - " + toDate;

            List<Delivery> oftdeliveries = getOutForDeliveryList(store_id);

            int[] briefStatsValues = getBriefStatsNumbers(firstDayOfMonth, today, store_id);
            deliveredCount.Text = briefStatsValues[0].ToString();
            pendingCount.Text = briefStatsValues[1].ToString();
            cancelledCount.Text = briefStatsValues[2].ToString();

            setOfts(oftdeliveries);
        }

        private void deliveriesButton_Click(object sender, EventArgs e)
        {
            new allDeliveriesForMerchant(store_id, store_id).Show();
            this.Hide();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void merchantDashboard_Load(object sender, EventArgs e)
        {

        }

        private void newDeliveryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            newDelivery form = new newDelivery(store_id);
            form.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login form = new Login();

            form.Show();
        }

        private void seeallButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            allDeliveriesForMerchant form = new allDeliveriesForMerchant(store_id, store_id);
            form.Show();
        }


        private void profileButton_Click(object sender, EventArgs e)
        {
            new adminMerchantUpdatePanel(store_id, false).Show();
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {

        }
    }
}
