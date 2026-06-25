using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Hotel_management_system.Models;
using Hotel_management_system.Helpers;

namespace Hotel_management_system.DAL
{
    public class StaffDAL
    {
        public Staff GetByUsernameAndPassword(string username, string password)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM tbl_Staff WHERE Username = @Username AND IsActive = 1";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedHash = reader["Password"].ToString();
                            if (PasswordHelper.VerifyPassword(password, storedHash))
                            {
                                return new Staff
                                {
                                    StaffID = (int)reader["StaffID"],
                                    Username = reader["Username"].ToString(),
                                    Password = storedHash,
                                    FullName = reader["FullName"].ToString(),
                                    Role = reader["Role"].ToString(),
                                    IsActive = (bool)reader["IsActive"]
                                };
                            }
                        }
                    }
                }
            }
            return null;
        }

        public Staff GetById(int staffId)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM tbl_Staff WHERE StaffID = @StaffID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StaffID", staffId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Staff
                            {
                                StaffID = (int)reader["StaffID"],
                                Username = reader["Username"].ToString(),
                                Password = reader["Password"].ToString(),
                                FullName = reader["FullName"].ToString(),
                                Role = reader["Role"].ToString(),
                                IsActive = (bool)reader["IsActive"]
                            };
                        }
                    }
                }
            }
            return null;
        }

        public bool UpdatePassword(int staffId, string newPassword)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string hashedPassword = PasswordHelper.HashPassword(newPassword);
                string query = "UPDATE tbl_Staff SET Password = @Password WHERE StaffID = @StaffID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Password", hashedPassword);
                    cmd.Parameters.AddWithValue("@StaffID", staffId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}