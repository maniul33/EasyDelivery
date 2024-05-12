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
        private string selectedStoreId = "";
        public merchantDashboardPanel()
        {
            InitializeComponent();
            loadAllMerchantAvailable();
        }
        public void loadAllMerchantAvailable()
        {
            try
            {
                //1. Address of SQL Server and Database.
                string connection = DatabaseSettings.ConnectionString;

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

        private void allMerchantDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (allMerchantDataGridView.SelectedRows.Count > 0) // Check if any row is selected
            {
                // Retrieve the store_id of the selected row
                selectedStoreId = allMerchantDataGridView.SelectedRows[0].Cells["StoreID"].Value.ToString();
            }
            else
            {
                selectedStoreId = ""; // Reset the variable if no row is selected
            }
        }
        public string GetSelectedStoreId()
        {
            return selectedStoreId;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string strID = GetSelectedStoreId();
            new adminMerchantUpdatePanel(strID).Show();
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Address of SQL Server and Database.
                string connection = DatabaseSettings.ConnectionString;

                // Establish Connection.
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    // Open Connection.
                    conn.Open();
                    string storeIdToDelete = GetSelectedStoreId();

                    // Prepare Query.
                    string deleteQuery = "DELETE FROM merchant WHERE store_id = @StoreID;";

                    // Create SqlCommand
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@StoreID", storeIdToDelete);

                        // Execute the DELETE query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully.");
                            loadAllMerchantAvailable(); // Reload data after deletion
                        }
                        else
                        {
                            MessageBox.Show("No record deleted. Please verify the store ID.");
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
