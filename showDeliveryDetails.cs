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
    public partial class showDeliveryDetails : Form
    {
        string deliveryId { get; }
        string store_id { get; }
        public showDeliveryDetails(string deliveryId, string store_id)
        {
            InitializeComponent();
            this.deliveryId = deliveryId;
            this.store_id = store_id;
            populateInformation();
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
                                    cust.cusZip,
                                    r.rider_name,
                                    r.number
                                    FROM collect col
                                    INNER JOIN merchant m ON m.store_id = (SELECT store_id FROM [create] WHERE d_id = col.d_id)
                                    INNER JOIN customer cust ON col.cusPhone = cust.cusPhone
                                    INNER JOIN delivery d ON col.d_id = d.d_id
                                    INNER JOIN rider r ON d.rider_id = r.rider_id
                                    WHERE col.d_id = @DeliveryId";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@DeliveryId", deliveryId);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        cusNameLabel.Text = reader["cusName"].ToString();
                        cusPhoneLabel.Text = reader["cusPhone"].ToString();
                        cusDistrictLabel.Text = reader["cusDistrict"].ToString();

                        string rdrName = reader["rider_name"].ToString();
                        string rdrPhone = reader["number"].ToString();

                        if (string.IsNullOrEmpty(rdrName))
                        {
                            riderNameLabel.Text = "Unassigned";
                            riderNameLabel.ForeColor = System.Drawing.Color.Red;
                            riderPhoneLabel.Text = "Unassigned";
                            riderPhoneLabel.ForeColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            riderNameLabel.Text = rdrName;
                            riderPhoneLabel.Text = rdrPhone;
                        }

                        cusAreaLabel.Text = reader["cusArea"].ToString();
                        cusStreetLabel.Text = reader["cusStreet"].ToString();
                        cusZipLabel.Text = reader["cusZip"].ToString();
                        productTypeLabel.Text = reader["productType"].ToString();

                        weightLabel.Text = reader["weight"].ToString();
                        collectAmountLabel.Text = reader["collectAmount"].ToString();
                        statusLabel.Text = reader["status"].ToString();
                        deliveryIdLabel.Text = reader["d_id"].ToString();

                        Font boldFont = new Font(this.Font, FontStyle.Bold);


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

                        string deliveryStatus = reader["status"].ToString();
                        if (deliveryStatus == "Pending")
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
                        else if (deliveryStatus == "OutForDelivery")
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
                        else if (deliveryStatus == "Delivered")
                        {
                            deliveredIconLabel.Visible = true;
                            outForDeliveryDoneIconLabel.Visible = true;
                            outForDeliveryIconLabel.Visible = false;
                            cancelledIconLabel.Visible = false;
                            NotDeliveredCancelledIconLabel.Visible = false;
                            outForDeliveryGreenTickLabel.Visible = true;
                            cancelledLabel.Visible = false;
                            deliveredLabel.Visible = true;

                        }
                        else if (deliveryStatus == "Cancelled")
                        {
                            deliveredIconLabel.Visible = false;
                            outForDeliveryDoneIconLabel.Visible = true;
                            outForDeliveryIconLabel.Visible = false;
                            cancelledIconLabel.Visible = true;
                            NotDeliveredCancelledIconLabel.Visible = false;
                            outForDeliveryGreenTickLabel.Visible = true;
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

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            string connectionString = DatabaseSettings.ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                string deliveryID = this.deliveryId;

                string updateCreateTableQuery = "UPDATE [create] SET status = 'Cancelled' WHERE d_id = @deliveryID";
                SqlCommand updateCreateTableCmd = new SqlCommand(updateCreateTableQuery, connection);
                updateCreateTableCmd.Parameters.AddWithValue("@deliveryID", deliveryID);
                updateCreateTableCmd.ExecuteNonQuery();

                string updateCollectTableQuery = "UPDATE collect SET status = 'Cancelled' WHERE d_id = @deliveryID";
                SqlCommand updateCollectTableCmd = new SqlCommand(updateCollectTableQuery, connection);
                updateCollectTableCmd.Parameters.AddWithValue("@deliveryID", deliveryID);
                updateCollectTableCmd.ExecuteNonQuery();

                string updateDeliveryTableQuery = "UPDATE delivery SET status = 'Cancelled' WHERE d_id = @deliveryID";
                SqlCommand updateDeliveryTableCmd = new SqlCommand(updateDeliveryTableQuery, connection);
                updateDeliveryTableCmd.Parameters.AddWithValue("@deliveryID", deliveryID);
                updateDeliveryTableCmd.ExecuteNonQuery();

                MessageBox.Show("Delivery with ID " + deliveryID + " has been successfully cancelled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
                showDeliveryDetails form = new showDeliveryDetails(deliveryID, store_id);
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while cancelling the delivery: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void backtoDashboardButton_Click(object sender, EventArgs e)
        {
            this.Close();
            allDeliveriesForMerchant form = new allDeliveriesForMerchant(store_id, store_id);
            form.Show();
        }
    }
}
