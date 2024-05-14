using Bunifu.Licensing.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EasyDelivery
{
    public partial class acceptDelivery : Form
    {
        private string deliveryId;
        private string rider_id;
        private string collectedAmount;
        public acceptDelivery(string deliveryId, string rider_id)
        {
            InitializeComponent();
            this.deliveryId = deliveryId;
            populateInformation();
            this.rider_id = rider_id;
        }
        private void bottomLeftPanel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                int padding = 130;
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
                        topStatusLabel.Text = reader["status"].ToString();
                        string status = reader["status"].ToString();
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
                        string collectAmount = reader["collectAmount"].ToString();
                        collectAmountLabel.Text = collectAmount;
                        this.collectedAmount = collectAmount;
                        statusLabel.Text = reader["status"].ToString();
                        deliveryIdLabel.Text = reader["d_id"].ToString();

                        Font boldFont = new Font(this.Font, FontStyle.Bold);

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

                        if (status == "OutForDelivery")
                        {
                            doneButton.Visible = true;
                            acceptButton.Visible = false;
                            cancelButton.Visible = true;
                        }
                        else if (status == "Pending")
                        {
                            doneButton.Visible = false;
                            acceptButton.Visible = true;
                            cancelButton.Visible = false;
                        }
                        else if (status == "Delivered")
                        {
                            acceptButton.Visible = false;
                            cancelButton.Visible = false;
                            doneButton.Visible = false;
                        }

                        if (status == "Pending")
                        {
                            outForDeliveryDoneIconLabel.Visible = false;
                            outForDeliveryIconLabel.Visible = true;
                            deliveredIconLabel.Visible = false;
                            cancelledIconLabel.Visible = false;
                            NotDeliveredCancelledIconLabel.Visible = true;
                            outForDeliveryGreenTickLabel.Visible = false;
                            cancelledLabel.Visible = false;
                            deliveredLabel.Visible = true;
                        }
                        else if (status == "OutForDelivery")
                        {
                            outForDeliveryDoneIconLabel.Visible = true;
                            outForDeliveryIconLabel.Visible = false;
                            deliveredIconLabel.Visible = false;
                            cancelledIconLabel.Visible = false;
                            NotDeliveredCancelledIconLabel.Visible = true;
                            outForDeliveryGreenTickLabel.Visible = false;
                            cancelledLabel.Visible = false;
                            deliveredLabel.Visible = true;
                        }
                        else if (status == "Delivered")
                        {
                            deliveredIconLabel.Visible = true;
                            outForDeliveryDoneIconLabel.Visible = false;
                            outForDeliveryIconLabel.Visible = false;
                            cancelledIconLabel.Visible = false;
                            NotDeliveredCancelledIconLabel.Visible = false;
                            outForDeliveryGreenTickLabel.Visible = true;
                            cancelledLabel.Visible = false;
                            deliveredLabel.Visible = true;

                        }
                        else if (status == "Cancelled")
                        {
                            deliveredIconLabel.Visible = false;
                            outForDeliveryDoneIconLabel.Visible = true;
                            outForDeliveryIconLabel.Visible = false;
                            cancelledIconLabel.Visible = true;
                            NotDeliveredCancelledIconLabel.Visible = false;
                            outForDeliveryGreenTickLabel.Visible = false;
                            cancelledLabel.Visible = true;
                            deliveredLabel.Visible = false;

                        }
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
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(DatabaseSettings.ConnectionString))
            {
                connection.Open();

                string createQuery = "UPDATE [create] set status = 'Cancelled' where d_id = @d_id";
                using (SqlCommand command = new SqlCommand(createQuery, connection))
                {
                    command.Parameters.AddWithValue("@d_id", deliveryId);
                    command.ExecuteNonQuery();
                }

                string collectQuery = "UPDATE collect set status = 'Cancelled' where d_id = @d_id";
                using (SqlCommand command = new SqlCommand(collectQuery, connection))
                {
                    command.Parameters.AddWithValue("@d_id", deliveryId);
                    command.ExecuteNonQuery();
                }

                string deliveryQuery = "UPDATE delivery set status = 'Cancelled' where d_id = @d_id";
                using (SqlCommand command = new SqlCommand(deliveryQuery, connection))
                {
                    command.Parameters.AddWithValue("@d_id", deliveryId);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Delivery cancelled!", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(DatabaseSettings.ConnectionString))
            {
                connection.Open();

                string createQuery = "UPDATE [create] set status = 'OutForDelivery' where d_id = @d_id";
                using (SqlCommand command = new SqlCommand(createQuery, connection))
                {
                    command.Parameters.AddWithValue("@d_id", deliveryId);
                    command.ExecuteNonQuery();
                }

                string collectQuery = "UPDATE collect set status = 'OutForDelivery' where d_id = @d_id";
                using (SqlCommand command = new SqlCommand(collectQuery, connection))
                {
                    command.Parameters.AddWithValue("@d_id", deliveryId);
                    command.ExecuteNonQuery();
                }

                string deliveryQuery = "UPDATE delivery set status = 'OutForDelivery' where d_id = @d_id";
                using (SqlCommand command = new SqlCommand(deliveryQuery, connection))
                {
                    command.Parameters.AddWithValue("@d_id", deliveryId);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Delivery Accepted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(DatabaseSettings.ConnectionString))
            {
                connection.Open();

                string createQuery = "UPDATE [create] set status = 'Delivered' where d_id = @d_id";
                using (SqlCommand command = new SqlCommand(createQuery, connection))
                {
                    command.Parameters.AddWithValue("@d_id", deliveryId);
                    command.ExecuteNonQuery();
                }

                string collectQuery = "UPDATE collect set status = 'Delivered' where d_id = @d_id";
                using (SqlCommand command = new SqlCommand(collectQuery, connection))
                {
                    command.Parameters.AddWithValue("@d_id", deliveryId);
                    command.ExecuteNonQuery();
                }

                string deliveryQuery = "UPDATE delivery set status = 'Delivered' where d_id = @d_id";
                using (SqlCommand command = new SqlCommand(deliveryQuery, connection))
                {
                    command.Parameters.AddWithValue("@d_id", deliveryId);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Delivered Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
