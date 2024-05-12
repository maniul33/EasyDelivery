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
    public partial class acceptDelivery : Form
    {
        string deliveryId;
        public acceptDelivery(string deliveryId)
        {
            InitializeComponent();
            this.deliveryId = deliveryId;
            populateInformation();
        }
        private void bottomLeftPanel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                int padding = 130; // Adjust the padding as needed
                int y = panel.Height / 2;
                int startX = padding;
                int endX = panel.Width - padding;

                using (Pen pen = new Pen(Color.Black))
                {
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                    pen.Width = 1;
                    pen.DashPattern = new float[] { 3, 3 };
                    e.Graphics.DrawLine(pen, startX, y, endX, y);
                }
            }
        }

        private void populateInformation()
        {
            string connection = DatabaseSettings.ConnectionString;

            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    conn.Open();

                    string query = @"
               SELECT m.store_name, 
               m.number, 
               col.weight, 
               col.productType, 
               col.collectAmount, 
               col.status, 
               cust.cusName, 
               col.d_id, 
               cust.cusPhone, 
               cust.cusDistrict, 
               cust.cusArea, 
               cust.cusStreet, 
               cust.cusZip
               FROM collect col
               INNER JOIN merchant m ON m.store_id = (SELECT store_id FROM [create] WHERE d_id = col.d_id)
               INNER JOIN customer cust ON col.cusPhone = cust.cusPhone
               WHERE col.d_id = @DeliveryId";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@DeliveryId", deliveryId);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Populate textboxes with retrieved data
                        topStatusLabel.Text = reader["status"].ToString();
                        topDeliveryLabel.Text = reader["d_id"].ToString();
                        topStoreNameLabel.Text = reader["store_name"].ToString();
                        cusNameLabel.Text = reader["cusName"].ToString();
                        cusPhoneLabel.Text = reader["cusPhone"].ToString();
                        cusDistrictLabel.Text = reader["cusDistrict"].ToString();
                        topStorePhoneLabel.Text = reader["number"].ToString();


                        cusAreaLabel.Text = reader["cusArea"].ToString();
                        cusStreetLabel.Text = reader["cusStreet"].ToString();
                        cusZipLabel.Text = reader["cusZip"].ToString();
                        productTypeLabel.Text = reader["productType"].ToString();

                        weightLabel.Text = reader["weight"].ToString();
                        collectAmountLabel.Text = reader["collectAmount"].ToString();
                        statusLabel.Text = reader["status"].ToString();
                        deliveryIdLabel.Text = reader["d_id"].ToString();

                        Font boldFont = new Font(this.Font, FontStyle.Bold);

                        // Set font to bold for specific labels
                        topStatusLabel.Font = boldFont;
                        topDeliveryLabel.Font = boldFont;
                        topStoreNameLabel.Font = boldFont;
                        cusNameLabel.Font = boldFont;
                        cusPhoneLabel.Font = boldFont;
                        cusDistrictLabel.Font = boldFont;
                        cusAreaLabel.Font = boldFont;
                        cusStreetLabel.Font = boldFont;
                        cusZipLabel.Font = boldFont;
                        productTypeLabel.Font = boldFont;
                        weightLabel.Font = boldFont;
                        collectAmountLabel.Font = boldFont;
                        statusLabel.Font = boldFont;
                        deliveryIdLabel.Font = boldFont;
                        topStorePhoneLabel.Font = boldFont;

                        //The below code is for the timeline panel(bottomLeftPanel).

                        //string deliveryStatus = reader["status"].ToString();
                        //if (deliveryStatus == "Pending")
                        //{
                        //    outForDeliveryDoneIconLabel.Visible = false;
                        //    outForDeliveryIconLabel.Visible = true;
                        //    deliveredIconLabel.Visible = false;
                        //    cancelledIconLabel.Visible = false;
                        //    NotDeliveredCancelledIconLabel.Visible = true;
                        //    outForDeliveryGreenTickLabel.Visible = false;
                        //    cancelledLabel.Visible = false;
                        //    deliveredLabel.Visible = true;
                        //}
                        //else if (deliveryStatus == "OutForDelivery")
                        //{
                        //    outForDeliveryDoneIconLabel.Visible = true;
                        //    outForDeliveryIconLabel.Visible = false;
                        //    deliveredIconLabel.Visible = false;
                        //    cancelledIconLabel.Visible = false;
                        //    NotDeliveredCancelledIconLabel.Visible = true;
                        //    outForDeliveryGreenTickLabel.Visible = false;
                        //    cancelledLabel.Visible = false;
                        //    deliveredLabel.Visible = true;

                        //}
                        //else if (deliveryStatus == "Delivered")
                        //{
                        //    deliveredIconLabel.Visible = true;
                        //    outForDeliveryDoneIconLabel.Visible = true;
                        //    outForDeliveryIconLabel.Visible = false;
                        //    cancelledIconLabel.Visible = false;
                        //    NotDeliveredCancelledIconLabel.Visible = false;
                        //    outForDeliveryGreenTickLabel.Visible = true;
                        //    cancelledLabel.Visible = false;
                        //    deliveredLabel.Visible = true;

                        //}
                        //else if (deliveryStatus == "Cancelled")
                        //{
                        //    deliveredIconLabel.Visible = false;
                        //    outForDeliveryDoneIconLabel.Visible = true;
                        //    outForDeliveryIconLabel.Visible = false;
                        //    cancelledIconLabel.Visible = true;
                        //    NotDeliveredCancelledIconLabel.Visible = false;
                        //    outForDeliveryGreenTickLabel.Visible = false;
                        //    cancelledLabel.Visible = true;
                        //    deliveredLabel.Visible = false;

                        //}
                    }
                    else
                    {
                        MessageBox.Show("No data found for the provided phone number.");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void backLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
