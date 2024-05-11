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
    public partial class showDeliveryDetails : Form
    {
        public showDeliveryDetails(string delivery_id)
        {
            InitializeComponent();
            label1.Text = delivery_id;
        }

        private void showDeliveryDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
