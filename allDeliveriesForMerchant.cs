using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public allDeliveriesForMerchant(string store_id, string id)
        {
            InitializeComponent();
            PictureBox logo = new PictureBox();
            logoBox.Image = Image.FromFile("C:\\Users\\user\\source\\repos\\EasyDelivery\\Resources\\435178119_795721862618047_8546822541438855553_n.png");
            logoBox.Controls.Add(logo);

            panelCreation p = new panelCreation();

            List<Panel> panels = p.LoadDeliveryDetails(id);

            foreach (Panel panel in panels)
            {
                rightPanel.Controls.Add(panel);
            }
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
                string info = "";
                
                if (string.IsNullOrEmpty(searchByCustomerPhoneBox.Text))
                {
                    info = searchbyIDBox.Text;                   
                }
                else
                {
                    info = searchByCustomerPhoneBox.Text;
                }
                this.Close();

                allDeliveriesForMerchant form = new allDeliveriesForMerchant(store_id,info);

                form.Show();
            }
        }
    }
}
