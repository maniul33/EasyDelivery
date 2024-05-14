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

            panelCreation p = new panelCreation();

            List<Panel> panels = p.LoadDeliveryDetails(riderID, true);

            foreach (Panel panel in panels)
            {
                rightPanel.Controls.Add(panel);
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            new riderDashboard(riderID).Show();
            this.Hide();
        }
    }
}
