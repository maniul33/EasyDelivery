using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EasyDelivery
{
    public partial class riderVeiwDetails : Form
    {
        public riderVeiwDetails()
        {
            InitializeComponent();
        }


        
        private void noteSave_button_Click(object sender, EventArgs e)
        {
            try
            {
                string connection = "Data Source=DESKTOP-N9N0BK6\\SQLEXPRESS01;Integrated Security=True;";

                //Establish Connection.
                SqlConnection conn = new SqlConnection(connection);

                // Open Connection.
                conn.Open();

                // Prepare Query.
                idGenerator i = new idGenerator();
                string noteID = i.createNewID("NTE");
                string note = note_txtbox.Text;
                string storeId = "STR001";


                string query = " INSERT INTO receive_note(note_id, note_text, store_id) VALUES ('" + noteID + "', '" + note + "', '" + storeId + "');";

                // Create a SqlCommand object with the query and connection.
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters.
                    cmd.Parameters.AddWithValue("@NoteID", noteID);
                    cmd.Parameters.AddWithValue("@NoteText", note);
                    cmd.Parameters.AddWithValue("@StoreID", storeId);

                    // Execute the query.
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Check if the query was successful.
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Insert successful.");
                    }
                    else
                    {
                        Console.WriteLine("Insert failed.");
                    }
                    //Close Connection.
                    conn.Close();


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void riderDelivery_button_Click(object sender, EventArgs e)
        {
            new riderDeliveries().Show();
            this.Hide();
        }

        private void label_ID_Click(object sender, EventArgs e)
        {
            try
            {
                string connection = "Data Source=DESKTOP-N9N0BK6\\SQLEXPRESS01;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connection))
                {
                    // Open Connection.
                    conn.Open();

                    // Prepare Query to select d_id and cusPhone from collect table.
                    string query = "SELECT d_id, cusPhone FROM collect";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Execute the query.
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Check if there are rows returned.
                            if (reader.Read())
                            {

                                string d_id = reader["d_id"].ToString();
                                string cusPhone = reader["cusPhone"].ToString();

                              
                                label_ID.Text = d_id;

                                
                               // Console.WriteLine("Customer Phone: " + cusPhone);
                            }
                            else
                            {
                                // Handle case where no rows are returned.
                                label_ID.Text = "No data found.";
                            }
                        }
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
