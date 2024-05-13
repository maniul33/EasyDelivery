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
    public partial class adminDashboard : Form
    {
        public adminDashboard()
        {
            InitializeComponent();
            loadForm(new adminDashboardBriefStats());
        }
        public void loadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            loadForm(new adminDashboardBriefStats());
        }

        private void merchantButton_Click(object sender, EventArgs e)
        {
            loadForm(new merchantDashboardPanel());
        }

        private void riderButton_Click(object sender, EventArgs e)
        {
            loadForm(new riderDashboardPanel(mainPanel));
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void deliveryButton_Click(object sender, EventArgs e)
        {
            loadForm(new adminDeliveriesPanel());
        }
    }
}
