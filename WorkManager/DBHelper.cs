using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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

        public static int InsertProduct(string name, string spec, int price, int timePerUnit)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "INSERT INTO Product (ProductName, Specification, UnitPrice, TimePerUnit) VALUES (@name, @spec, @price,@timePerUnit)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@spec", spec);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@timePerUnit", timePerUnit);

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

        public static DataTable LoadWorkhistory()
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "SELECT WorkerID, Status, TimeStamp FROM WorkHistory";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;

            }
        }

        public static int InsertOrder(int workerID, int productID, int quantity, DateTime startTime, DateTime expectedEndtime)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "INSERT INTO WorkOrder (WorkerID,ProductID,Quantity,StartTime,ExpectedEndtime) VALUES (@worker,@productID, @quantity,@startTime,@expectedEndtime)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@worker", workerID);
                cmd.Parameters.AddWithValue("@productID", productID);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@startTime", startTime);
                cmd.Parameters.AddWithValue("@expectedEndtime", expectedEndtime);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public List<string> GetWorkerNames()
        {
            List<string> names = new List<string>();

            using (SqlConnection conn = GetConnection())
            {
                string query = "SELECT WorkerID, Name FROM Worker";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int workerID = reader.GetInt32(0);
                    string workName = reader.GetString(1);
                    names.Add($"{workerID}. {workName}");
                }
            }
            return names;
        }

        public List<string> GetProductNames()
        {
            List<string> names = new List<string>();

            using (SqlConnection conn = GetConnection())
            {
                string query = "SELECT ProductName FROM Product";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    names.Add(reader.GetString(0));
                }
            }
            return names;
        }

        public string GetProductSpecification(string productName)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "SELECT Specification FROM Product WHERE ProductName = @name";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", productName);

                conn.Open();
                object result = cmd.ExecuteScalar();  // 첫 번째 행 첫 번째 열 값 반환
                return result != null ? result.ToString() : string.Empty;
            }
        }

        public List<string> GetProductNamesWithSpecification()
        {
            List<string> productList = new List<string>();

            using (SqlConnection conn = GetConnection())
            {
                string query = "SELECT ProductID, ProductName, Specification FROM Product";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int productID = reader.GetInt32(0);
                    string productName = reader.GetString(1);
                    string specification = reader.GetString(2);
                    // 상품명과 규격을 결합하여 하나의 문자열로 만듭니다.
                    productList.Add($"{productID}. {productName} ({specification})");
                }
            }
            return productList;
        }

        // DBHelper.cs
        // ...
        public int GetProductTime(int productID, int quantity)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "SELECT TimeUnit, TimePerUnit FROM Product WHERE ProductId = @productID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("productID", productID);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                int timePerUnit = 0;
                int shiftedTime = 0;
                string timeUnit = ""; // 변수 초기화

                if (reader.Read())
                {
                    timeUnit = reader.GetString(0);
                    timePerUnit = reader.GetInt32(1);

                    if (timeUnit == "minute")
                    {
                        shiftedTime = timePerUnit * 60;
                    }
                    else if (timeUnit == "hour")
                    {
                        shiftedTime = timePerUnit * 3600;
                    }
                }

                return shiftedTime * quantity;
            }
        }

        // ...

        public string GetUserRoleFromDataBase(string userName, string password)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "SELECT Role FROM Users WHERE UserName = @userName AND Password = @password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userName", userName);
                cmd.Parameters.AddWithValue("@password", password);
                conn.Open();
                object result = cmd.ExecuteScalar();
                return result != null ? result.ToString() : null;
            }
        }
    

    public User getUser(string username, string pssword)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "SELECT UserID, UserName, Password, Role FROM Users WHERE UserName = @username AND Password = @pssword";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@pssword", pssword);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int userID = reader.GetInt32(0);
                    string userName = reader.GetString(1);
                    string password = reader.GetString(2);
                    string role = reader.GetString(3);
                    return new User(userID, userName, password, role);
                }
                else
                {
                    return null; // 사용자 정보가 없을 경우 null 반환
                }
            }

        }
    }
}