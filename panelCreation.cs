// panelCreation.cs
using com.sun.tools.javac.util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace EasyDelivery
{
    //
    internal class panelCreation
    {
        private string connectionString = "Data Source=MANIUL\\SQLEXPRESS;Initial Catalog=EasyDelivery;Integrated Security=True";
        private string query = "";

        
        public List<Panel> LoadDeliveryDetails(string id)
        {
            List<Delivery> deliveryDetails = new List<Delivery>();
            List<Panel> panels = new List<Panel>();

            string idType = "";
            if (id.Substring(0, 3) == "STR")
            {
                idType = "@StoreId";
                query = "SELECT * FROM CustomerDeliveryView WHERE store_id = @StoreId"; // Modified query to use the view and filter by store_id
            }
            else if(id.Substring(0,3) == "DLV")
            {
                idType = "@d_id";
                query = "SELECT * FROM CustomerDeliveryView WHERE d_id = @d_id"; // Modified query to use the view and filter by store_i
            }
            else if(id.Substring(0,3) == "RDR")
            {
                query = "SELECT * FROM CustomerDeliveryView WHERE DeliveryStatus = 'Pending'"; // Modified query to use the view and filter by store_i
            }
            else
            {
                idType = "@customerPhone";
                query = "SELECT * FROM CustomerDeliveryView WHERE CustomerPhone = @customerPhone";
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(idType, id);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Delivery detail = new Delivery(
                                reader.GetString(0), // d_id
                                reader.GetString(1), // cus_name
                                reader.GetString(2), // cus_phone
                                reader.GetString(3), // cus_district
                                reader.GetString(4), // cus_area
                                reader.GetString(5), // cus_street
                                reader.GetString(6), // cus_zip
                                reader.GetString(7), // AmountToCollect
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

            int initialX = 31;
            int initialY = 10;
            int panelWidth = 1050;
            int panelHeight = 150;

            foreach (Delivery dlv in deliveryDetails)
            {
                Panel panel = new Panel();
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Size = new System.Drawing.Size(panelWidth, panelHeight);
                panel.Location = new System.Drawing.Point(initialX, initialY);
                panel.Margin = new Padding(0, 0, 15, 0);
                panel.Click += (sender, e) =>
                {
                    showDeliveryDetails destinationForm = new showDeliveryDetails(dlv.d_id);
                    destinationForm.Show();
                };
                panel.Cursor = Cursors.Hand;

                PictureBox phoneIcon = new PictureBox();
                phoneIcon.Image = Image.FromFile("C:\\Users\\user\\source\\repos\\EasyDelivery\\Resources\\phone.png");
                phoneIcon.Size = new Size(20, 20);
                phoneIcon.Location = new System.Drawing.Point(425, 111);
                panel.Controls.Add(phoneIcon);

                PictureBox profileIcon = new PictureBox();
                profileIcon.Image = Image.FromFile("C:\\Users\\user\\source\\repos\\EasyDelivery\\Resources\\profile.png");
                profileIcon.Size = new Size(20, 20);
                profileIcon.Location = new System.Drawing.Point(425, 23);
                panel.Controls.Add(profileIcon);


                PictureBox locationIcon = new PictureBox();
                locationIcon.Image = Image.FromFile("C:\\Users\\user\\source\\repos\\EasyDelivery\\Resources\\location.png");
                locationIcon.Size = new Size(20, 20);
                locationIcon.Location = new System.Drawing.Point(425, 69);
                panel.Controls.Add(locationIcon);


                PictureBox takaIcon = new PictureBox();
                takaIcon.Image = Image.FromFile("C:\\Users\\user\\source\\repos\\EasyDelivery\\Resources\\taka.png");
                takaIcon.Size = new Size(20, 20);
                takaIcon.Location = new System.Drawing.Point(927, 71);
                panel.Controls.Add(takaIcon);


                Font font = new Font("Arial Rounded MT", 12, FontStyle.Bold);

                Label lblDeliveryId = new Label();
                lblDeliveryId.Text = dlv.d_id;
                lblDeliveryId.Location = new System.Drawing.Point(45, 65);
                lblDeliveryId.Size = new System.Drawing.Size(130, 23);
                lblDeliveryId.Font = font;
                panel.Controls.Add(lblDeliveryId);

                Label lblStoreName = new Label();
                lblStoreName.Text = dlv.store_name;
                lblStoreName.Location = new System.Drawing.Point(229, 65);
                lblStoreName.Size = new System.Drawing.Size(124, 23);
                lblStoreName.Font = font;
                panel.Controls.Add(lblStoreName);

                Label lblCusName = new Label();
                lblCusName.Text = dlv.cus_name;
                lblCusName.Location = new System.Drawing.Point(451, 21);
                lblCusName.Size = new System.Drawing.Size(213, 23);
                lblCusName.Font = font;
                panel.Controls.Add(lblCusName);

                Label lblCusLocation = new Label();
                lblCusLocation.Text = dlv.cus_area + ", " + dlv.cus_district;
                lblCusLocation.Location = new System.Drawing.Point(451, 67);
                lblCusLocation.Size = new System.Drawing.Size(189, 23);
                lblCusLocation.Font = font;
                panel.Controls.Add(lblCusLocation);

                Label lblCusPhone = new Label();
                lblCusPhone.Text = dlv.cus_phone;
                lblCusPhone.Location = new System.Drawing.Point(451, 110);
                lblCusPhone.Size = new System.Drawing.Size(142, 23);
                lblCusPhone.Font = font;
                panel.Controls.Add(lblCusPhone);

                Label lblStatus = new Label();
                lblStatus.Text = dlv.DeliveryStatus;
                lblStatus.Location = new System.Drawing.Point(716, 69);
                lblStatus.Size = new System.Drawing.Size(165, 24);
                lblStatus.Font = font;
                panel.Controls.Add(lblStatus);

                Label lblAmount = new Label();
                lblAmount.Text = dlv.AmountToCollect;
                lblAmount.Location = new System.Drawing.Point(947, 70);
                lblAmount.Size = new System.Drawing.Size(58, 23);
                lblAmount.Font = font;
                panel.Controls.Add(lblAmount);

                initialY += panelHeight + 15;

                // Add the panel to the list of panels
                panels.Add(panel);
            }
            return panels;
        }
    }
}
