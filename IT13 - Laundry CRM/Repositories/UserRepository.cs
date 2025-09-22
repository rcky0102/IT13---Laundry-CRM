using IT13___Laundry_CRM.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace IT13___Laundry_CRM.Repositories
{
    internal class UserRepository
    {
        private readonly string connectionString =
            "Data Source=LAPTOP-NGRORR8P\\SQLEXPRESS;Initial Catalog=LaundryDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        // Get all users
        public List<User> GetUsers()
        {
            var users = new List<User>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT UserId, Username, PasswordHash, Role, first_name, middle_name, last_name, address, contact, CreatedAt FROM users ORDER BY UserId DESC";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                User user = new User
                                {
                                    UserId = reader.GetInt32(0),
                                    Username = reader.GetString(1),
                                    PasswordHash = reader.GetString(2),
                                    Role = reader.GetString(3),
                                    CreatedAt = reader.GetDateTime(4)
                                };
                                users.Add(user);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex);
            }

            return users;
        }

        // Get user by username (used in login)
        public User? GetUserByUsername(string username)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT UserId, Username, PasswordHash, Role, CreatedAt FROM users WHERE Username=@username";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new User
                                {
                                    UserId = reader.GetInt32(0),
                                    Username = reader.GetString(1),
                                    PasswordHash = reader.GetString(2),
                                    Role = reader.GetString(3),
                                    CreatedAt = reader.GetDateTime(4)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex);
            }

            return null;
        }

        // Get user by ID
        public User? GetUserById(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT UserId, Username, PasswordHash, Role, CreatedAt FROM users WHERE UserId=@id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new User
                                {
                                    UserId = reader.GetInt32(0),
                                    Username = reader.GetString(1),
                                    PasswordHash = reader.GetString(2),
                                    Role = reader.GetString(3),
                                    CreatedAt = reader.GetDateTime(4)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex);
            }

            return null;
        }

        // Insert new user
        public void CreateUser(User user)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO users (Username, PasswordHash, Role, CreatedAt) " +
                                 "VALUES (@Username, @PasswordHash, @Role, @CreatedAt)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Username", user.Username);
                        command.Parameters.AddWithValue("@PasswordHash", user.PasswordHash); // ⚠️ Should be hashed before saving
                        command.Parameters.AddWithValue("@Role", user.Role);
                        command.Parameters.AddWithValue("@CreatedAt", user.CreatedAt);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex);
            }
        }

        // Update existing user
        public void UpdateUser(User user)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE users " +
                                 "SET Username=@Username, PasswordHash=@PasswordHash, Role=@Role " +
                                 "WHERE UserId=@UserId";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Username", user.Username);
                        command.Parameters.AddWithValue("@PasswordHash", user.PasswordHash); // ⚠️ Should be hashed before saving
                        command.Parameters.AddWithValue("@Role", user.Role);
                        command.Parameters.AddWithValue("@UserId", user.UserId);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex);
            }
        }

        // Delete user
        public void DeleteUser(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM users WHERE UserId=@id";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex);
            }
        }
    }
}
