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

        public List<Delivery> deliveries;


        private string connectionString = "Data Source=MANIUL\\SQLEXPRESS;Initial Catalog=EasyDelivery;Integrated Security=True";

        // Define a method to fetch deliveries with status "OutForDelivery"
        public List<Delivery> getOutForDeliveryList(string store_id)
        {
            List<Delivery> outForDeliveryList = new List<Delivery>();

            // SQL query to fetch deliveries with status "OutForDelivery" for the specified store
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
                        // Create a Delivery object from the retrieved data
                        Delivery delivery = new Delivery(
                            reader["DeliveryID"].ToString(),
                            reader["CustomerName"].ToString(),
                            Convert.ToInt64(reader["CustomerPhone"]),
                            Convert.ToSingle(reader["AmountToCollect"]),
                            reader["DeliveryStatus"].ToString(),
                            reader["RiderID"].ToString(),
                            reader["RiderName"].ToString()
                        );

                        // Add the Delivery object to the list
                        outForDeliveryList.Add(delivery);
                    }

                    reader.Close();
                }
            }

            return outForDeliveryList;
        }

        public void setOfts(List<Delivery> deliveries)
        {
            Delivery d1 = deliveries[0];
            name1Label.Text = d1.cus_name;
            phone1label.Text = d1.cus_phone.ToString();
            deliveryid1Label.Text = d1.d_id;
            price1Label.Text = d1.AmountToCollect.ToString();

            Delivery d2 = deliveries[1];
            name2Label.Text = d2.cus_name;
            phone2Label.Text = d2.cus_phone.ToString();
            deliveryid2Label.Text = d2.d_id;
            price2Label.Text = d2.AmountToCollect.ToString();

            Delivery d3 = deliveries[2];
            name3Label.Text = d3.cus_name;
            phone3Label.Text = d3.cus_phone.ToString();
            deliveryid3Label.Text = d3.d_id;
            price3Label.Text = d3.AmountToCollect.ToString();

            Delivery d4 = deliveries[3];
            name4Label.Text = d4.cus_name;
            phone4Label.Text = d4.cus_phone.ToString();
            deliveryid4Label.Text = d4.d_id;
            price4Label.Text = d4.AmountToCollect.ToString();
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

            deliveries = getOutForDeliveryList(store_id);

            setOfts(deliveries);
        }
    }
}
