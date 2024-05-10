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
    public partial class merchantDashboard : Form
    {
        private string toDate;
        private string fromDate;

        public merchantDashboard()
        {
            InitializeComponent();

            DateTime today = DateTime.Today;

            toDate = today.ToString("MMM dd, yyyy");

            DateTime firstDayOfMonth = new DateTime(today.Year, today.Month, 01);
            fromDate = firstDayOfMonth.ToString("MMM dd, yyyy");

            dateBox.Text = fromDate + " - " + toDate;

            name1Label.Text = "ahajajkskkasjajakaka";
            phone1label.Text = "01889655894";
            deliveryid1Label.Text = "DT260424GS35M3";
            price1Label.Text = "265";

        }

        private void merchantDashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void newDeliveryButton_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void name1Label_Click(object sender, EventArgs e)
        {

        }
    }
}
