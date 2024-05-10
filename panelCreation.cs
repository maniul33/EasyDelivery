using System;
using System.Drawing;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EasyDelivery
{
    internal class panelCreation
    {
        private string connectionString = "Data Source=MANIUL\\SQLEXPRESS;Initial Catalog=EasyDelivery;Integrated Security=True";
        private void LoadDeliveryDetails()
        {
            List<Delivery> deliveryDetails = new List<Delivery>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM CustomerDeliveryView"; // Modified query to use the view
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Delivery detail = new Delivery(

                                reader.GetString(0), // d_id
                                reader.GetString(1), // cus_name
                                reader.GetInt64(2), // cus_phone
                                reader.GetString(3), // cus_district
                                reader.GetString(4), // cus_area
                                reader.GetString(5), // cus_street
                                reader.GetString(6), // cus_zip
                                reader.GetFloat(7), // AmountToCollect
                                reader.GetString(8), // DeliveryStatus
                                reader.GetString(11), // rider_id
                                reader.GetString(12), // rider_name
                                reader.GetString(10), // store_name
                                reader.GetString(9) // store_id
                                );

                            deliveryDetails.Add(detail);
                        }
                    }
                }
            }

            DisplayDeliveryDetails(deliveryDetails);
        }



        private void DisplayDeliveryDetails(List<Delivery> deliveryDetails)
        {
            int initialX = 31;
            int initialY = 130;
            int panelWidth = 1050;
            int panelHeight = 100;
            int gap = 15;

            foreach (Delivery dlv in deliveryDetails)
            {
                PictureBox phoneIcon = new PictureBox();
                phoneIcon.Image = Image.FromFile("C:\\Users\\user\\source\\repos\\EasyDelivery\\Resources\\phone.png");
                phoneIcon.Size = new Size(20, 20);
                phoneIcon.Location = new System.Drawing.Point(425,111);
                PictureBox profileIcon = new PictureBox();
                phoneIcon.Image = Image.FromFile("C:\\Users\\user\\source\\repos\\EasyDelivery\\Resources\\profile.png");
                PictureBox takaIcon = new PictureBox();
                takaIcon.Image = Image.FromFile("C:\\Users\\user\\source\\repos\\EasyDelivery\\Resources\\taka.png");
                PictureBox locationIcon = new PictureBox();
                locationIcon.Image = Image.FromFile("C:\\Users\\user\\source\\repos\\EasyDelivery\\Resources\\location.png");
                Font font = new Font("Arial Rounded MT", 12, FontStyle.Bold);

                Panel panel = new Panel();
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Size = new System.Drawing.Size(panelWidth, panelHeight);

                Label lblDeliveryId = new Label();
                lblDeliveryId.Text = dlv.d_id;
                lblDeliveryId.Location = new System.Drawing.Point(45, 65);
                lblDeliveryId.Size = new System.Drawing.Size(123, 23);
                lblDeliveryId.Font = font;
                panel.Controls.Add(lblDeliveryId);

                Label lblStoreName = new Label();
                lblStoreName.Text = dlv.store_name;
                lblStoreName.Location = new System.Drawing.Point(229, 65);
                lblStoreName.Size = new System.Drawing.Size(124, 23);
                lblStoreName.Font = font;
                panel.Controls.Add(lblStoreName);

                Label lblCusDetails = new Label();
                lblCusDetails.Text = dlv.d_id;
                lblCusDetails.Location = new System.Drawing.Point(45, 65);
                lblCusDetails.Size = new System.Drawing.Size(1114, 803);
                lblCusDetails.Font = font;
                panel.Controls.Add(lblCusDetails);


                // Add more labels for other details if needed

                panel.Location = new System.Drawing.Point(initialX, initialY);
                initialY += panelHeight + gap; // Update Y position for the next panel
            }
        }


    }
}
