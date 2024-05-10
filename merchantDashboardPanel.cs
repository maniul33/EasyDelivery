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
    public partial class merchantDashboardPanel : Form
    {
        public merchantDashboardPanel()
        {
            InitializeComponent();
            loadAllMerchantAvailable();
        }
        private void loadAllMerchantAvailable()
        {
            try
            {
                //1. Address of SQL Server and Database.
                string connection = "Data Source=LAPTOP-0F2M46LC\\SQLEXPRESS;Initial Catalog=EasyDelivery;Integrated Security=True;";

                //2. Establish Connection.
                SqlConnection conn = new SqlConnection(connection);

                //3. Open Connection.
                conn.Open();

                //4. Prepare Query.
                string query = "SELECT store_id AS StoreID, store_name AS StoreName, email AS Email, number as Number , district AS District, area as Area, street As Street, zip AS Zip, bankName AS BankName, branch_name AS BranchName, accNo as AccountNumber from merchant;\r\n";

                //5. Execute Query.
                SqlCommand cmd = new SqlCommand(query, conn);
                var reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                allMerchantDataGridView.DataSource = dt;


                //6. Close Connection.
                conn.Close();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void merchantDashboardPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
