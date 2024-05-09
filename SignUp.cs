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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void merchantButton_Click(object sender, EventArgs e)
        {
            new SignupMerchant().Show();
            this.Hide();
        }

        private void riderButton_Click(object sender, EventArgs e)
        {
            new SignupRider().Show();
            this.Hide();
        }
    }
}
