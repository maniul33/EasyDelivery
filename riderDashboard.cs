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
    public partial class riderDashboard : Form
    {
        public string rider_id;
        public riderDashboard(string rider_id)
        {
            InitializeComponent();
            this.rider_id = rider_id;

            panelCreation p = new panelCreation();

            List<Panel> panels = p.LoadDeliveryDetails(rider_id, false);

            foreach (Panel panel in panels)
            {
                rightPanel.Controls.Add(panel);
            }
        }

        private void deliveriesButton_Click(object sender, EventArgs e)
        {

        }
    }
}
