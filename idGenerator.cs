using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EasyDelivery
{
    public class idGenerator
    {
        public string createNewID(string role)
        {
            List<string> ids = new List<string>();

            string connectionString = DatabaseSettings.ConnectionString;

            string query = "";
            string clm = "";

            switch (role)
            {
                case "STR":
                    query = "SELECT store_id FROM merchant";
                    clm = "store_id";
                    break;
                case "DLV":
                    query = "SELECT d_id FROM delivery";
                    clm = "d_id";
                    break;
                case "RDR":
                    query = "SELECT rider_id FROM rider";
                    clm = "rider_id";
                    break;
                case "PYR":
                    query = "SELECT p_id FROM obtain";
                    clm = "p_id";
                    break;
                case "NTE":
                    query = "SELECT note_id FROM receive_note";
                    clm = "note_id";
                    break;
                case "PYS":
                    query = "SELECT p_id FROM receive_payment";
                    clm = "p_id";
                    break;
                case "REV":
                    query = "SELECT rev_id FROM give";
                    clm = "rev_id";
                    break;
                default:
                    Console.WriteLine("Unknown role.");
                    return null; // Handle unknown role
            }

            // Create a new SqlConnection instance
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                // Open the connection
                connection.Open();

                // Create a SqlCommand object with the SQL query and connection
                SqlCommand command = new SqlCommand(query, connection);

                // Execute the command and get a SqlDataReader
                SqlDataReader reader = command.ExecuteReader();

                // Read each row from the result set
                while (reader.Read())
                {
                    // Get the value of the column based on the role
                    string Id = reader[clm].ToString();
                    // Add the ID to the list
                    ids.Add(Id);
                }

                // Close the SqlDataReader
                reader.Close();
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                // Close the connection (whether an exception occurred or not)
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }


            // Generate a unique ID
            Random r = new Random();
            List<int> idsInt = ids.ConvertAll(s => int.TryParse(s.Substring(3), out int result) ? result : -1);

            int id;
            do
            {
                id = r.Next(100000, 1000000);
            }
            while (idsInt.Contains(id));

            // Return the generated ID
            return role + id;
        }
    }
}