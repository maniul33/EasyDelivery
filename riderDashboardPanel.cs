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
    public partial class riderDashboardPanel : Form
    {
        private string selectedRiderId = "";
        public riderDashboardPanel()
        {
            InitializeComponent();
            loadAllRiderAvailable();
        }
        public void loadAllRiderAvailable()
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
                string query = "select rider_id AS RiderID, rider_name AS RiderName, email AS RiderEmail, number AS RiderNumber, rider_password AS RiderPassword, r_bankName AS RiderBankName, r_branchName as RiderBranchName, r_accNo AS RiderAccountNumber from rider;";

                //5. Execute Query.
                SqlCommand cmd = new SqlCommand(query, conn);
                var reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                riderDataGridView.DataSource = dt;


                //6. Close Connection.
                conn.Close();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public string GetSelectedRiderId()
        {
            return selectedRiderId;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Address of SQL Server and Database.
                string connection = "Data Source=LAPTOP-0F2M46LC\\SQLEXPRESS;Initial Catalog=EasyDelivery;Integrated Security=True;";

                // Establish Connection.
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    // Open Connection.
                    conn.Open();
                    string riderIdToDelete = GetSelectedRiderId();

                    // Prepare Query.
                    string deleteQuery = "DELETE FROM rider WHERE rider_id = @RiderID;";

                    // Create SqlCommand
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@RiderID", riderIdToDelete);

                        // Execute the DELETE query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully.");
                            loadAllRiderAvailable(); // Reload data after deletion
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

        private void riderDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (riderDataGridView.SelectedRows.Count > 0) // Check if any row is selected
            {
                // Retrieve the rider_id of the selected row
                selectedRiderId = riderDataGridView.SelectedRows[0].Cells["RiderID"].Value.ToString();
            }
            else
            {
                selectedRiderId = ""; // Reset the variable if no row is selected
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string rdrID = GetSelectedRiderId();
            new adminRiderUpdatePanel(rdrID).Show();
        }
    }
}
