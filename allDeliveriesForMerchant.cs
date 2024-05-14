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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EasyDelivery
{
    public partial class allDeliveriesForMerchant : Form
    {
        private string store_id;
        public allDeliveriesForMerchant(string store_id, string searchingInfo)
        {
            InitializeComponent();
            PictureBox logo = new PictureBox();
            logoBox.Image = Image.FromFile("C:\\Users\\user\\source\\repos\\EasyDelivery\\Resources\\435178119_795721862618047_8546822541438855553_n.png");
            logoBox.Controls.Add(logo);

            panelCreation p = new panelCreation();

            List<Panel> panels = p.LoadDeliveryDetails(searchingInfo, false);

            foreach (Panel panel in panels)
            {
                rightPanel.Controls.Add(panel);
            }

            LoadStoreImage(store_id);
        }


        private void allDeliveriesForMerchant_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rightPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadStoreImage(string store_id)
        {
            string connection = DatabaseSettings.ConnectionString;
            string query = "SELECT store_image FROM merchant WHERE store_id = @StoreId";

            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StoreId", store_id);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        byte[] imageBytes = (byte[])result;
                        Image image;
                        using (System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBytes))
                        {
                            image = Image.FromStream(ms);
                        }
                        profilePicture.Image = image;
                    }
                    else
                    {
                        MessageBox.Show("Store image not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the store image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchByCustomerPhoneBox.Text) && string.IsNullOrWhiteSpace(searchbyIDBox.Text))
            {
                MessageBox.Show("Please provide customer contact number or delivery id to search!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!string.IsNullOrWhiteSpace(searchByCustomerPhoneBox.Text) && !string.IsNullOrWhiteSpace(searchbyIDBox.Text))
            {
                MessageBox.Show("Please provide only one information!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string searchingInfo = "";

                if (!string.IsNullOrEmpty(searchByCustomerPhoneBox.Text))
                {
                    searchingInfo = searchByCustomerPhoneBox.Text;
                }
                else
                {
                    searchingInfo = searchbyIDBox.Text;
                }

                this.Hide();

                string connectionString = DatabaseSettings.ConnectionString;
                string query = "SELECT * FROM CustomerDeliveryView WHERE CustomerPhone = @searchingInfo OR DeliveryID = @searchingInfo";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@searchingInfo", searchingInfo);

                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();

                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string deliveryId = reader.GetString(0);
                                    showDeliveryDetails form = new showDeliveryDetails(deliveryId, store_id);
                                    form.Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show("No matching data found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }


        private void profilePicture_Click(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
