namespace EasyDelivery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            idGenerator i = new idGenerator();
            string id = i.createNewID("PYS");
            textBox1.Text = id;
        }
    }
}
