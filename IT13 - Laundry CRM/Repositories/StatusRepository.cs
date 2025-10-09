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
            "Data Source=GILGWE\\SQLEXPRESS;Initial Catalog=LaundryDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

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

        public List<Status> GetStatusesByUserId(int userId)
        {
            var statuses = new List<Status>();

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT s.status_id, s.user_id, s.status, s.created_at,
                                        u.user_id, u.first_name, u.middle_name, u.last_name
                                 FROM Status s
                                 INNER JOIN Users u ON s.user_id = u.user_id
                                 WHERE s.user_id = @UserId
                                 ORDER BY s.created_at DESC";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var status = new Status
                            {
                                status_id = (int)reader["status_id"],
                                user_id = (int)reader["user_id"],
                                status = reader["status"].ToString(),
                                created_at = (DateTime)reader["created_at"],
                                User = new User
                                {
                                    user_id = (int)reader["user_id"],
                                    first_name = reader["first_name"].ToString(),
                                    middle_name = reader["middle_name"].ToString(),
                                    last_name = reader["last_name"].ToString()
                                }
                            };

                            statuses.Add(status);
                        }
                    }
                }
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

        public List<Status> GetArchivedStatuses()
        {
            var statuses = new List<Status>();

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            SELECT s.status_id, s.user_id, s.status, s.is_archived, s.created_at,
                   u.user_id, u.first_name, u.middle_name, u.last_name
            FROM Status s
            INNER JOIN Users u ON s.user_id = u.user_id
            WHERE s.is_archived = 1
            ORDER BY s.created_at DESC";

                using (var cmd = new SqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        statuses.Add(new Status
                        {
                            status_id = (int)reader["status_id"],
                            user_id = (int)reader["user_id"],
                            status = reader["status"].ToString(),
                            created_at = (DateTime)reader["created_at"],
                            User = new User
                            {
                                user_id = (int)reader["user_id"],
                                first_name = reader["first_name"].ToString(),
                                middle_name = reader["middle_name"].ToString(),
                                last_name = reader["last_name"].ToString()
                            }
                        });
                    }
                }
            }

            return statuses;
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

        public void UnarchiveStatus(int statusId)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"UPDATE Status 
                         SET is_archived = 0 
                         WHERE status_id = @StatusId";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StatusId", statusId);
                    cmd.ExecuteNonQuery();
                }
            }
        }




        public void AddStatusHistory(StatusHistory history)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = @"INSERT INTO StatusHistory (status_id, user_id, status, created_at)
                           VALUES (@status_id, @user_id, @status, @created_at)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@status_id", (object)history.status_id ?? DBNull.Value);
                        command.Parameters.AddWithValue("@user_id", history.user_id);
                        command.Parameters.AddWithValue("@status", history.status);
                        command.Parameters.AddWithValue("@created_at", history.created_at);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding status history: " + ex.Message);
            }
        }

        public void UpdateStatusWithHistory(Status status)
        {
            // Step 1: Get current status from DB
            Status currentStatus = GetStatusesByUserId(status.user_id).FirstOrDefault();

            if (currentStatus != null)
            {
                // Step 2: Save old status to history
                var history = new StatusHistory
                {
                    status_id = currentStatus.status_id,
                    user_id = currentStatus.user_id,
                    status = currentStatus.status,
                    created_at = currentStatus.created_at
                };

                AddStatusHistory(history);

                // Step 3: Update current status
                UpdateStatus(status);
            }
            else
            {
                // If no current status exists, just add it
                AddStatus(status);
            }
        }

        public List<StatusHistory> GetStatusHistoryByUserId(int userId)
        {
            var historyList = new List<StatusHistory>();

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT h.history_id, h.status_id, h.user_id, h.status, h.created_at
            FROM StatusHistory h
            WHERE h.user_id = @UserId
            ORDER BY h.created_at ASC"; // oldest first

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            historyList.Add(new StatusHistory
                            {
                                history_id = (int)reader["history_id"],
                                status_id = reader["status_id"] != DBNull.Value ? (int?)reader["status_id"] : null,
                                user_id = (int)reader["user_id"],
                                status = reader["status"].ToString(),
                                created_at = (DateTime)reader["created_at"]
                            });
                        }
                    }
                }
            }

            return historyList;
        }

        public Dictionary<string, int> GetStatusCounts()
        {
            var counts = new Dictionary<string, int>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            SELECT status, COUNT(*) as total
            FROM Status
            GROUP BY status";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string status = reader["status"].ToString();
                            int total = (int)reader["total"];
                            counts[status] = total;
                        }
                    }
                }
            }

            return counts;
        }



    }
}
