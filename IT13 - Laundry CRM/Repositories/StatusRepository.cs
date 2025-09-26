using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT13___Laundry_CRM.Models;

namespace IT13___Laundry_CRM.Repositories
{
    internal class StatusRepository
    {
        private readonly string connectionString =
    "Data Source=LAPTOP-NGRORR8P\\SQLEXPRESS;Initial Catalog=LaundryDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public List<Status> GetStatusesWithCustomerNames()
        {
            var statuses = new List<Status>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = @"
                        SELECT s.status_id, s.user_id, s.status, s.created_at,
                               u.first_name, u.middle_name, u.last_name
                        FROM Status s
                        INNER JOIN Users u ON s.user_id = u.user_id
                        WHERE u.role = 'customer' AND s.is_archived = 0
                        ORDER BY s.status_id DESC";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // build user (only names)
                                var user = new User
                                {
                                    user_id = reader.GetInt32(1),
                                    first_name = reader.IsDBNull(4) ? null : reader.GetString(4),
                                    middle_name = reader.IsDBNull(5) ? null : reader.GetString(5),
                                    last_name = reader.IsDBNull(6) ? null : reader.GetString(6),
                                    role = "customer" // since we filtered by role already
                                };

                                // build status
                                var status = new Status
                                {
                                    status_id = reader.GetInt32(0),
                                    user_id = reader.GetInt32(1),
                                    status = reader.GetString(2),
                                    created_at = reader.GetDateTime(3),
                                    User = user
                                };

                                statuses.Add(status);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            return statuses;
        }

        public void AddStatus(Status status)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = @"INSERT INTO Status (user_id, status, created_at) 
                                   VALUES (@user_id, @status, @created_at)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@user_id", status.user_id);
                        command.Parameters.AddWithValue("@status", status.status);
                        command.Parameters.AddWithValue("@created_at", status.created_at);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding status: " + ex.Message);
            }
        }

        public void UpdateStatus(Status status)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = @"UPDATE Status
                           SET status = @status,
                               created_at = @created_at
                           WHERE status_id = @status_id";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@status_id", status.status_id);
                        command.Parameters.AddWithValue("@status", status.status);
                        command.Parameters.AddWithValue("@created_at", DateTime.Now); // refresh timestamp

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating status: " + ex.Message);
            }
        }

        // ✅ New: Get customer ID by status_id
        public int GetUserIdByStatusId(int statusId)
        {
            int userId = -1;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT user_id FROM Status WHERE status_id = @status_id";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@status_id", statusId);

                    object result = command.ExecuteScalar();
                    if (result != null)
                        userId = Convert.ToInt32(result);
                }
            }

            return userId;
        }

        // ✅ New: Get status text by status_id
        public string GetStatusTextById(int statusId)
        {
            string statusText = "";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT status FROM Status WHERE status_id = @status_id";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@status_id", statusId);

                    object result = command.ExecuteScalar();
                    if (result != null)
                        statusText = result.ToString();
                }
            }

            return statusText;
        }

        public void ArchiveStatus(int statusId)
        {   
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = @"UPDATE Status
                           SET is_archived = 1
                           WHERE status_id = @status_id";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@status_id", statusId);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error archiving status: " + ex.Message);
            }
        }


    }
}
