using IT13___Laundry_CRM.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT13___Laundry_CRM.Repositories
{
    internal class FeedbackRepository
    {
        private readonly string connectionString =
<<<<<<< HEAD
<<<<<<< HEAD
            "Data Source=LAPTOP-NGRORR8P\\SQLEXPRESS;Initial Catalog=LaundryDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
=======
            "Data Source=LAPTOP-NGRORR8P\\SQLEXPRESS; Initial Catalog=LaundryDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
>>>>>>> e30cbf9 (ui gadugi)
=======
            "Data Source=GILGWE\\SQLEXPRESS;Initial Catalog=LaundryDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
>>>>>>> 01d16142ab20084db456627e578487a282f25ac9


        // CREATE: Add feedback
        public bool AddFeedback(Feedback feedback)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = @"
                        INSERT INTO Feedback (user_id, subject, feedback, created_at, updated_at)
                        VALUES (@user_id, @subject, @feedback, @created_at, @updated_at)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@user_id", feedback.user_id);
                        cmd.Parameters.AddWithValue("@subject", feedback.subject ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@feedback", feedback.feedback ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@created_at", feedback.created_at);
                        cmd.Parameters.AddWithValue("@updated_at", feedback.updated_at);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("AddFeedback Exception: " + ex.Message);
                return false;
            }
        }


        // READ: Get all feedbacks
        public List<Feedback> GetAllFeedback()
        {
            var feedbacks = new List<Feedback>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = @"
                        SELECT f.feedback_id, f.user_id, f.subject, f.feedback, f.created_at, f.updated_at,
                               u.username, u.first_name, u.middle_name, u.last_name, u.role
                        FROM Feedback f
                        INNER JOIN Users u ON f.user_id = u.user_id
                        ORDER BY f.created_at DESC";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var fb = new Feedback
                            {
                                feedback_id = (int)reader["feedback_id"],
                                user_id = (int)reader["user_id"],
                                subject = reader["subject"].ToString(),
                                feedback = reader["feedback"].ToString(),
                                created_at = (DateTime)reader["created_at"],
                                updated_at = (DateTime)reader["updated_at"],

                                User = new User
                                {
                                    user_id = (int)reader["user_id"],
                                    username = reader["username"].ToString(),
                                    first_name = reader["first_name"].ToString(),
                                    middle_name = reader["middle_name"].ToString(),
                                    last_name = reader["last_name"].ToString(),
                                    role = reader["role"].ToString()
                                }
                            };

                            feedbacks.Add(fb);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetAllFeedback Exception: " + ex.Message);
            }

            return feedbacks;
        }

        // READ: Get feedback by user
        public List<Feedback> GetFeedbacksByUser(int userId)
        {
            var feedbacks = new List<Feedback>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = @"
                        SELECT f.feedback_id, f.user_id, f.subject, f.feedback, f.created_at, f.updated_at,
                               u.username, u.first_name, u.middle_name, u.last_name, u.role
                        FROM Feedback f
                        INNER JOIN Users u ON f.user_id = u.user_id
                        WHERE f.user_id = @userId
                        ORDER BY f.created_at DESC";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var fb = new Feedback
                                {
                                    feedback_id = (int)reader["feedback_id"],
                                    user_id = (int)reader["user_id"],
                                    subject = reader["subject"].ToString(),
                                    feedback = reader["feedback"].ToString(),
                                    created_at = (DateTime)reader["created_at"],
                                    updated_at = (DateTime)reader["updated_at"],

                                    User = new User
                                    {
                                        user_id = (int)reader["user_id"],
                                        username = reader["username"].ToString(),
                                        first_name = reader["first_name"].ToString(),
                                        middle_name = reader["middle_name"].ToString(),
                                        last_name = reader["last_name"].ToString(),
                                        role = reader["role"].ToString()
                                    }
                                };

                                feedbacks.Add(fb);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetFeedbackByUserId Exception: " + ex.Message);
            }

            return feedbacks;
        }

        // DELETE: Remove feedback
        public bool DeleteFeedback(int feedbackId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "DELETE FROM Feedback WHERE feedback_id = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", feedbackId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("DeleteFeedback Exception: " + ex.Message);
                return false;
            }
        }

        public Feedback? GetLatestFeedback()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            SELECT TOP 1 f.feedback_id, f.user_id, f.subject, f.feedback, f.created_at, f.updated_at,
                   u.user_id, u.first_name, u.middle_name, u.last_name
            FROM Feedback f
            INNER JOIN Users u ON f.user_id = u.user_id
            ORDER BY f.created_at DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Feedback
                            {
                                feedback_id = (int)reader["feedback_id"],
                                user_id = (int)reader["user_id"],
                                subject = reader["subject"].ToString(),
                                feedback = reader["feedback"].ToString(),
                                created_at = (DateTime)reader["created_at"],
                                updated_at = (DateTime)reader["updated_at"],
                                User = new User
                                {
                                    user_id = (int)reader["user_id"],
                                    first_name = reader["first_name"].ToString(),
                                    middle_name = reader["middle_name"].ToString(),
                                    last_name = reader["last_name"].ToString()
                                }
                            };
                        }
                    }
                }
            }
            return null;
        }

    }
}
