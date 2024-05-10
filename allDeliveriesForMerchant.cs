using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyDelivery
{
    public partial class allDeliveriesForMerchant : Form
    {
        public allDeliveriesForMerchant(string store_id)
        {
            InitializeComponent();

            // Create an instance of the panelCreation class
            panelCreation p = new panelCreation();

            // Load delivery details into panels
            List<Panel> panels = p.LoadDeliveryDetails(store_id);

            // Add each panel created by panelCreation to the form's Controls collection
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
    }
}
