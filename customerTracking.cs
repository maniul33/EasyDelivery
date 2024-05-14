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
    public partial class customerTracking : Form
    {
        string phoneNumber;
        public customerTracking(string phoneNumber)
        {
            InitializeComponent();
            this.phoneNumber = phoneNumber;
            populateInformation();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void middlePanel_Paint(object sender, PaintEventArgs e)
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

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void populateInformation()
        {
            string connection = DatabaseSettings.ConnectionString;

            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    conn.Open();

                    string query = "select * from CustomerDeliveryView WHERE CustomerPhone = @PhoneNumber";


                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        cusNameLabel.Text = reader[1].ToString();
                        cusPhoneLabel.Text = reader[2].ToString();
                        cusDistrictLabel.Text = reader[3].ToString();

                        string rdrName = reader[12].ToString();
                        string rdrPhone = reader[13].ToString();
                        riderNameLabel.Text = rdrName;
                        riderPhoneLabel.Text = rdrPhone;
                        
                        cusAreaLabel.Text = reader[4].ToString();
                        cusStreetLabel.Text = reader[5].ToString();
                        cusZipLabel.Text = reader[6].ToString();
                        productTypeLabel.Text = reader[15].ToString();

                        weightLabel.Text = reader[14].ToString();
                        collectAmountLabel.Text = reader[7].ToString();
                        statusLabel.Text = reader[8].ToString();
                        deliveryIdLabel.Text = reader[0].ToString();
                        topStatusLabel.Text = reader[8].ToString();
                        topDeliveryLabel.Text = reader[0].ToString();
                        topStoreNameLabel.Text = reader[10].ToString();


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
                        riderNameLabel.Font = boldFont;
                        riderPhoneLabel.Font = boldFont;

                        string deliveryStatus = reader[8].ToString();
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
                            riderNameLabel.ForeColor = System.Drawing.Color.Red;
                            riderPhoneLabel.ForeColor = System.Drawing.Color.Red;
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
                            riderNameLabel.Text = rdrName;
                            riderPhoneLabel.Text = rdrPhone;
                        }
                        else if (deliveryStatus == "Delivered")
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
                        else if (deliveryStatus == "Cancelled")
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
            new Login().Show();
            this.Hide();
        }
    }
}
