using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Hotel_management_system.Models;

namespace Hotel_management_system.DAL
{
    public class GuestDAL
    {
        public List<Guest> GetAllGuests()
        {
            List<Guest> guests = new List<Guest>();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM tbl_Guests ORDER BY FullName";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        guests.Add(MapGuest(reader));
                    }
                }
            }
            return guests;
        }

        public Guest GetGuestById(int guestId)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM tbl_Guests WHERE GuestID = @GuestID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@GuestID", guestId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return MapGuest(reader);
                        }
                    }
                }
            }
            return null;
        }

        public List<Guest> SearchGuests(string searchTerm)
        {
            List<Guest> guests = new List<Guest>();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"SELECT * FROM tbl_Guests 
                                 WHERE FullName LIKE @Search 
                                    OR Phone LIKE @Search 
                                    OR CAST(GuestID AS NVARCHAR) LIKE @Search
                                 ORDER BY FullName";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Search", "%" + searchTerm + "%");
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            guests.Add(MapGuest(reader));
                        }
                    }
                }
            }
            return guests;
        }

        public bool AddGuest(Guest guest)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO tbl_Guests 
                                (FullName, Phone, Email, Address, NationalID)
                                VALUES (@FullName, @Phone, @Email, @Address, @NationalID)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FullName", guest.FullName);
                    cmd.Parameters.AddWithValue("@Phone", guest.Phone);
                    cmd.Parameters.AddWithValue("@Email", (object)guest.Email ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Address", (object)guest.Address ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@NationalID", (object)guest.NationalID ?? DBNull.Value);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateGuest(Guest guest)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE tbl_Guests 
                                SET FullName = @FullName, Phone = @Phone, Email = @Email,
                                    Address = @Address, NationalID = @NationalID
                                WHERE GuestID = @GuestID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FullName", guest.FullName);
                    cmd.Parameters.AddWithValue("@Phone", guest.Phone);
                    cmd.Parameters.AddWithValue("@Email", (object)guest.Email ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Address", (object)guest.Address ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@NationalID", (object)guest.NationalID ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@GuestID", guest.GuestID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteGuest(int guestId)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM tbl_Guests WHERE GuestID = @GuestID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@GuestID", guestId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        private Guest MapGuest(SqlDataReader reader)
        {
            return new Guest
            {
                GuestID = (int)reader["GuestID"],
                FullName = reader["FullName"].ToString(),
                Phone = reader["Phone"].ToString(),
                Email = reader["Email"].ToString(),
                Address = reader["Address"].ToString(),
                NationalID = reader["NationalID"].ToString(),
                CreatedAt = (DateTime)reader["CreatedAt"]
            };
        }
    }
}