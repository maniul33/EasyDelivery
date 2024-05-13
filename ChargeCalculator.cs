using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EasyDelivery
{
    public static class ChargeCalculator
    {
        public static void CalculateCharges()
        {
            string connection = DatabaseSettings.ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    string query = @"
                        SELECT d.d_id, d.collectAmount, d.rider_id, c.store_id
                        FROM delivery d
                        INNER JOIN [create] c ON d.d_id = c.d_id
                        WHERE d.status = 'Delivered'";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    List<(string, double, string, string)> deliveryDataList = new List<(string, double, string, string)>();

                    while (reader.Read())
                    {
                        string d_id = reader["d_id"].ToString();
                        double collectAmount = Convert.ToDouble(reader["collectAmount"]);
                        string rider_id = reader["rider_id"].ToString();
                        string store_id = reader["store_id"].ToString();

                        deliveryDataList.Add((d_id, collectAmount, rider_id, store_id));
                    }

                    reader.Close();

                    foreach (var deliveryData in deliveryDataList)
                    {
                        double deliveryCharge = deliveryData.Item2 * 0.1; 
                        double riderCharge = deliveryCharge * 0.7;
                        InsertCharge(conn, deliveryData.Item1, deliveryCharge, riderCharge, deliveryData.Item3, deliveryData.Item4);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        private static void InsertCharge(SqlConnection conn, string d_id, double deliveryCharge, double riderCharge, string rider_id, string store_id)
        {
            string query = @"
                INSERT INTO Charge (d_id, store_id, rider_id, deliveryCharge, riderCharge)
                VALUES (@d_id, @store_id, @rider_id, @deliveryCharge, @riderCharge)";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@d_id", d_id);
            cmd.Parameters.AddWithValue("@store_id", store_id);
            cmd.Parameters.AddWithValue("@rider_id", rider_id);
            cmd.Parameters.AddWithValue("@deliveryCharge", deliveryCharge);
            cmd.Parameters.AddWithValue("@riderCharge", riderCharge);

            cmd.ExecuteNonQuery();
        }
    }
}
