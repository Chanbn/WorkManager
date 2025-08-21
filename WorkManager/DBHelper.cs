using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WorkManager
{
    internal class DBHelper
    {
        private static string connStr = @"Server=localhost\SQLEXPRESS01;Database=Mes_Project;Trusted_Connection=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connStr);
        }

        public static int ExecuteScalar(string query)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                return (int)cmd.ExecuteScalar();
            }
        }

        public static int InsertProduct(string name, string spec, int price)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "INSERT INTO Product (ProductName, Specification, UnitPrice) VALUES (@name, @spec, @price)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@spec", spec);
                cmd.Parameters.AddWithValue("@price", price);

                conn.Open();
                return cmd.ExecuteNonQuery();
            }

        }

        public static int InsertWorker(string name, string jobTitle)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "INSERT INTO Worker (Name,JobTitle) VALUES (@name, @jobTitle)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@jobTitle", jobTitle);

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
