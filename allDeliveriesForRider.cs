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
    public partial class allDeliveriesForRider : Form
    {
        private string riderID;
        public allDeliveriesForRider(string riderID)
        {
            InitializeComponent();
            this.riderID = riderID;
            PictureBox logo = new PictureBox();
            logoBox.Image = Image.FromFile("C:\\Users\\user\\source\\repos\\EasyDelivery\\Resources\\435178119_795721862618047_8546822541438855553_n.png");
            logoBox.Controls.Add(logo);

            panelCreation p = new panelCreation();

            List<Panel> panels = p.LoadDeliveryDetails(riderID, true);

            foreach (Panel panel in panels)
            {
                rightPanel.Controls.Add(panel);
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new riderDashboard(riderID).Show();
        }
    }
}
