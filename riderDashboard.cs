using Microsoft.VisualBasic.Logging;
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
    public partial class riderDashboard : Form
    {
        public riderDashboard()
        {
            InitializeComponent();
        }

       
        

        private void riderDelivery_button_Click(object sender, EventArgs e)
        {
            new riderDeliveries().Show();
            this.Hide();
        }
    }
}
