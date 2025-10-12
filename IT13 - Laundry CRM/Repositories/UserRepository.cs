using IT13___Laundry_CRM.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace IT13___Laundry_CRM.Repositories
{
    internal class UserRepository
    {
        private readonly string connectionString =
           "Data Source=RAVEN-13\\SQLEXPRESS01;Initial Catalog=LaundryDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        // Get all users
        public List<User> GetUsers()
        {
            var users = new List<User>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = @"SELECT user_id, username, password, role, 
                                  first_name, middle_name, last_name, 
                                  address, contact, created_at 
                           FROM users 
                           ORDER BY user_id DESC";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                User user = new User
                                {
                                    user_id = reader.GetInt32(0),
                                    username = reader.GetString(1),
                                    password = reader.GetString(2),
                                    role = reader.GetString(3),
                                    first_name = reader.IsDBNull(4) ? null : reader.GetString(4),
                                    middle_name = reader.IsDBNull(5) ? null : reader.GetString(5),
                                    last_name = reader.IsDBNull(6) ? null : reader.GetString(6),
                                    address = reader.IsDBNull(7) ? null : reader.GetString(7),
                                    contact = reader.IsDBNull(8) ? null : reader.GetString(8),
                                    created_at = reader.GetDateTime(9)
                                };
                                users.Add(user);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            return users;
        }


        public User? GetUser(int id)
        {
            User? user = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = @"SELECT user_id, username, password, role, 
                                  first_name, middle_name, last_name, 
                                  address, contact, created_at
                           FROM users
                           WHERE user_id = @id";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                user = new User
                                {
                                    user_id = reader.GetInt32(0),
                                    username = reader.GetString(1),
                                    password = reader.GetString(2),
                                    role = reader.GetString(3),
                                    first_name = reader.IsDBNull(4) ? null : reader.GetString(4),
                                    middle_name = reader.IsDBNull(5) ? null : reader.GetString(5),
                                    last_name = reader.IsDBNull(6) ? null : reader.GetString(6),
                                    address = reader.IsDBNull(7) ? null : reader.GetString(7),
                                    contact = reader.IsDBNull(8) ? null : reader.GetString(8),
                                    created_at = reader.GetDateTime(9)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            return user;
        }



        // Get user by username (used in login)
        public User? GetUserByUsername(string username)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = @"SELECT user_id, username, password, role, first_name, middle_name, last_name, address, contact, created_at
                           FROM users 
                           WHERE username = @username";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new User
                                {
                                    user_id = reader.GetInt32(reader.GetOrdinal("user_id")),
                                    username = reader.GetString(reader.GetOrdinal("username")),
                                    password = reader.GetString(reader.GetOrdinal("password")),
                                    role = reader.GetString(reader.GetOrdinal("role")),
                                    first_name = reader.GetString(reader.GetOrdinal("first_name")),
                                    middle_name = reader.GetString(reader.GetOrdinal("middle_name")),
                                    last_name = reader.GetString(reader.GetOrdinal("last_name")),
                                    address = reader.GetString(reader.GetOrdinal("address")),
                                    contact = reader.GetString(reader.GetOrdinal("contact")),
                                    created_at = reader.GetDateTime(reader.GetOrdinal("created_at"))
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
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
                                    user_id = reader.GetInt32(0),
                                    username = reader.GetString(1),
                                    password = reader.GetString(2),
                                    role = reader.GetString(3),
                                    created_at= reader.GetDateTime(4)
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

                    string sql = @"INSERT INTO users 
                (username, password, role, first_name, middle_name, last_name, address, contact, created_at) 
                VALUES 
                (@username, @password, @role, @first_name, @middle_name, @last_name, @address, @contact, @created_at)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Hash the password before saving
                        string hashedPassword = HashPassword(user.password);

                        command.Parameters.AddWithValue("@username", user.username);
                        command.Parameters.AddWithValue("@password", hashedPassword);
                        command.Parameters.AddWithValue("@role", user.role);
                        command.Parameters.AddWithValue("@first_name", (object?)user.first_name ?? DBNull.Value);
                        command.Parameters.AddWithValue("@middle_name", (object?)user.middle_name ?? DBNull.Value);
                        command.Parameters.AddWithValue("@last_name", (object?)user.last_name ?? DBNull.Value);
                        command.Parameters.AddWithValue("@address", (object?)user.address ?? DBNull.Value);
                        command.Parameters.AddWithValue("@contact", (object?)user.contact ?? DBNull.Value);
                        command.Parameters.AddWithValue("@created_at", user.created_at);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

        }


        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
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

                    // If password is provided → include in update
                    string sql;
                    if (!string.IsNullOrEmpty(user.password))
                    {
                        sql = @"UPDATE users 
                        SET username = @username, 
                            password = @password, 
                            role = @role, 
                            first_name = @first_name, 
                            middle_name = @middle_name, 
                            last_name = @last_name, 
                            address = @address, 
                            contact = @contact
                        WHERE user_id = @user_id";
                    }
                    else
                    {
                        // No password change → exclude password column
                        sql = @"UPDATE users 
                        SET username = @username, 
                            role = @role, 
                            first_name = @first_name, 
                            middle_name = @middle_name, 
                            last_name = @last_name, 
                            address = @address, 
                            contact = @contact
                        WHERE user_id = @user_id";
                    }

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@username", user.username);
                        command.Parameters.AddWithValue("@role", user.role);
                        command.Parameters.AddWithValue("@first_name", (object?)user.first_name ?? DBNull.Value);
                        command.Parameters.AddWithValue("@middle_name", (object?)user.middle_name ?? DBNull.Value);
                        command.Parameters.AddWithValue("@last_name", (object?)user.last_name ?? DBNull.Value);
                        command.Parameters.AddWithValue("@address", (object?)user.address ?? DBNull.Value);
                        command.Parameters.AddWithValue("@contact", (object?)user.contact ?? DBNull.Value);
                        command.Parameters.AddWithValue("@user_id", user.user_id);

                        if (!string.IsNullOrEmpty(user.password))
                        {
                            string hashedPassword = HashPassword(user.password);
                            command.Parameters.AddWithValue("@password", hashedPassword);
                        }

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        public bool UpdateUserProfile(User user)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"UPDATE users
                         SET first_name=@FirstName,
                             middle_name=@MiddleName,
                             last_name=@LastName,
                             address=@Address,
                             contact=@Contact,
                             username=@Username,
                             password=@Password
                         WHERE user_id=@UserId";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FirstName", user.first_name);
                    cmd.Parameters.AddWithValue("@MiddleName", user.middle_name);
                    cmd.Parameters.AddWithValue("@LastName", user.last_name);
                    cmd.Parameters.AddWithValue("@Address", user.address);
                    cmd.Parameters.AddWithValue("@Contact", user.contact);
                    cmd.Parameters.AddWithValue("@Username", user.username);
                    cmd.Parameters.AddWithValue("@Password", user.password);
                    cmd.Parameters.AddWithValue("@UserId", user.user_id);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }



        // Delete user
        public void DeleteUser(int userId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.Transaction = transaction;

                            cmd.CommandText = @"
                        DELETE FROM Messages WHERE sender_id = @user_id OR receiver_id = @user_id;
                        DELETE FROM Feedback WHERE user_id = @user_id;
                        DELETE FROM StatusHistory WHERE user_id = @user_id;
                        DELETE FROM Status WHERE user_id = @user_id;
                        DELETE FROM Users WHERE user_id = @user_id;
                    ";

                            cmd.Parameters.AddWithValue("@user_id", userId);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }


    }
}
