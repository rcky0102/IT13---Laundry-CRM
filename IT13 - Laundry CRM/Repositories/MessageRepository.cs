using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT13___Laundry_CRM.Models;
using Message = IT13___Laundry_CRM.Models.Message;

namespace IT13___Laundry_CRM.Repositories
{
    internal class MessageRepository
    {
        private readonly string connectionString =
             "Data Source=LAPTOP-NGRORR8P\\SQLEXPRESS;Initial Catalog=LaundryDb;" +
             "Integrated Security=True;Connect " +
             "Timeout=30;Encrypt=True;Trust Server Certificate=True;" +
             "Application Intent=ReadWrite;" +
             "Multi Subnet Failover=False";

        public List<Message> GetConversation(int userId1, int userId2)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT * FROM Messages
            WHERE (sender_id = @user1 AND receiver_id = @user2)
               OR (sender_id = @user2 AND receiver_id = @user1)
            ORDER BY created_at ASC";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user1", userId1);
                    cmd.Parameters.AddWithValue("@user2", userId2);

                    using (var reader = cmd.ExecuteReader())
                    {
                        var messages = new List<Message>();
                        while (reader.Read())
                        {
                            messages.Add(new Message
                            {
                                message_id = (int)reader["message_id"],
                                sender_id = (int)reader["sender_id"],
                                receiver_id = (int)reader["receiver_id"],
                                message = reader["message"].ToString(),
                                created_at = (DateTime)reader["created_at"]
                            });
                        }
                        return messages;
                    }
                }
            }
        }


        public List<Message> GetMessagesByUserId(int userId)
        {
            var messages = new List<Message>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = @"
                        SELECT m.message_id, m.sender_id, m.receiver_id, m.message, m.created_at,
                               u.user_id, u.username, u.first_name, u.middle_name, u.last_name, u.role
                        FROM Messages m
                        INNER JOIN Users u ON m.sender_id = u.user_id
                        WHERE m.sender_id = @userId OR m.receiver_id = @userId
                        ORDER BY m.created_at DESC";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@userId", userId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var msg = new Message
                                {
                                    message_id = (int)reader["message_id"],
                                    sender_id = (int)reader["sender_id"],
                                    receiver_id = (int)reader["receiver_id"],
                                    message = reader["message"].ToString(),
                                    created_at = (DateTime)reader["created_at"],

                                    // Populate User object (sender details)
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

                                messages.Add(msg);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetMessagesByUserId Exception: " + ex.Message);
            }

            return messages;
        }

        public List<Message> GetMessagesWithSenderNames()
        {
            var messages = new List<Message>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = @"
                SELECT m.message_id, m.sender_id, m.receiver_id, m.message, m.created_at,
                       u.first_name, u.middle_name, u.last_name, u.username
                FROM Messages m
                INNER JOIN Users u ON m.sender_id = u.user_id
                ORDER BY m.created_at ASC"; // or DESC for newest first

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // build sender user
                                var sender = new User
                                {
                                    user_id = reader.GetInt32(1),
                                    first_name = reader.IsDBNull(5) ? "" : reader.GetString(5),
                                    middle_name = reader.IsDBNull(6) ? "" : reader.GetString(6),
                                    last_name = reader.IsDBNull(7) ? "" : reader.GetString(7),
                                    username = reader.IsDBNull(8) ? "" : reader.GetString(8)
                                };

                                // build message
                                var message = new Message
                                {
                                    message_id = reader.GetInt32(0),
                                    sender_id = reader.GetInt32(1),
                                    receiver_id = reader.GetInt32(2),
                                    message = reader.GetString(3),
                                    created_at = reader.GetDateTime(4),
                                    User = sender
                                };

                                messages.Add(message);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            return messages;
        }

        public bool AddMessage(Message message)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = @"
                        INSERT INTO Messages (sender_id, receiver_id, message, created_at)
                        VALUES (@sender_id, @receiver_id, @message, @created_at)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@sender_id", message.sender_id);
                        command.Parameters.AddWithValue("@receiver_id", message.receiver_id);
                        command.Parameters.AddWithValue("@message", message.message);
                        command.Parameters.AddWithValue("@created_at", message.created_at);

                        return command.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("AddMessage Exception: " + ex.Message);
                return false;
            }
        }

        // READ: Get all messages
        public List<Message> GetAllMessages()
        {
            var messages = new List<Message>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = @"
                        SELECT m.message_id, m.sender_id, m.receiver_id, m.message, m.created_at,
                               u.first_name, u.middle_name, u.last_name, u.username
                        FROM Messages m
                        INNER JOIN Users u ON m.sender_id = u.user_id
                        ORDER BY m.created_at ASC";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var sender = new User
                            {
                                user_id = reader.GetInt32(1),
                                first_name = reader.IsDBNull(5) ? "" : reader.GetString(5),
                                middle_name = reader.IsDBNull(6) ? "" : reader.GetString(6),
                                last_name = reader.IsDBNull(7) ? "" : reader.GetString(7),
                                username = reader.IsDBNull(8) ? "" : reader.GetString(8)
                            };

                            var message = new Message
                            {
                                message_id = reader.GetInt32(0),
                                sender_id = reader.GetInt32(1),
                                receiver_id = reader.GetInt32(2),
                                message = reader.GetString(3),
                                created_at = reader.GetDateTime(4),
                                User = sender
                            };

                            messages.Add(message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetAllMessages Exception: " + ex.Message);
            }

            return messages;
        }

        // UPDATE: Edit a message (by message_id)
        public bool UpdateMessage(int messageId, string newText)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Messages SET message = @message WHERE message_id = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@message", newText);
                    cmd.Parameters.AddWithValue("@id", messageId);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating message: " + ex.Message);
                return false;
            }
        }


        public bool DeleteMessage(int messageId)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var query = "DELETE FROM Messages WHERE message_id = @messageId";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@messageId", messageId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }


        public Message? GetLatestMessageForUser(int currentUserId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = @"
            SELECT TOP 1 
                m.message_id, m.sender_id, m.receiver_id, m.message, m.created_at,
                u.user_id, u.first_name, u.middle_name, u.last_name, u.username, u.role
            FROM messages m
            INNER JOIN users u ON m.sender_id = u.user_id
            WHERE m.receiver_id = @currentUserId
            ORDER BY m.created_at DESC";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@currentUserId", currentUserId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var message = new Message
                            {
                                message_id = (int)reader["message_id"],
                                sender_id = (int)reader["sender_id"],
                                receiver_id = (int)reader["receiver_id"],
                                message = reader["message"].ToString(),
                                created_at = (DateTime)reader["created_at"],
                                User = new User
                                {
                                    user_id = (int)reader["user_id"],
                                    first_name = reader["first_name"].ToString(),
                                    middle_name = reader["middle_name"].ToString(),
                                    last_name = reader["last_name"].ToString(),
                                    username = reader["username"].ToString(),
                                    role = reader["role"].ToString()
                                }
                            };

                            return message;
                        }
                    }
                }
            }

            return null;
        }


    }
}
