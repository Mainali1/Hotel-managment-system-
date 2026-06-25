using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Hotel_management_system.Models;

namespace Hotel_management_system.DAL
{
    public class RoomDAL
    {
        public List<Room> GetAllRooms()
        {
            List<Room> rooms = new List<Room>();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM tbl_Rooms ORDER BY RoomNumber";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rooms.Add(MapRoom(reader));
                    }
                }
            }
            return rooms;
        }

        public Room GetRoomById(int roomId)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM tbl_Rooms WHERE RoomID = @RoomID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RoomID", roomId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return MapRoom(reader);
                        }
                    }
                }
            }
            return null;
        }

        public List<Room> GetRoomsByStatus(string status)
        {
            List<Room> rooms = new List<Room>();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM tbl_Rooms WHERE Status = @Status ORDER BY RoomNumber";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Status", status);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rooms.Add(MapRoom(reader));
                        }
                    }
                }
            }
            return rooms;
        }

        public List<Room> GetAvailableRooms()
        {
            return GetRoomsByStatus("Available");
        }

        public int GetTotalRooms()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM tbl_Rooms";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        public bool HasActiveBookings(int roomId)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"SELECT COUNT(*) FROM tbl_Bookings 
                                 WHERE RoomID = @RoomID AND Status IN ('Confirmed', 'CheckedIn')";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RoomID", roomId);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public bool AddRoom(Room room)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO tbl_Rooms 
                                (RoomNumber, RoomType, RatePerNight, Status, Description)
                                VALUES (@RoomNumber, @RoomType, @RatePerNight, @Status, @Description)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RoomNumber", room.RoomNumber);
                    cmd.Parameters.AddWithValue("@RoomType", room.RoomType);
                    cmd.Parameters.AddWithValue("@RatePerNight", room.RatePerNight);
                    cmd.Parameters.AddWithValue("@Status", room.Status);
                    cmd.Parameters.AddWithValue("@Description", (object)room.Description ?? DBNull.Value);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateRoom(Room room)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE tbl_Rooms 
                                SET RoomNumber = @RoomNumber, RoomType = @RoomType, 
                                    RatePerNight = @RatePerNight, Status = @Status, Description = @Description
                                WHERE RoomID = @RoomID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RoomNumber", room.RoomNumber);
                    cmd.Parameters.AddWithValue("@RoomType", room.RoomType);
                    cmd.Parameters.AddWithValue("@RatePerNight", room.RatePerNight);
                    cmd.Parameters.AddWithValue("@Status", room.Status);
                    cmd.Parameters.AddWithValue("@Description", (object)room.Description ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@RoomID", room.RoomID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateRoomStatus(int roomId, string status)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "UPDATE tbl_Rooms SET Status = @Status WHERE RoomID = @RoomID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@RoomID", roomId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteRoom(int roomId)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM tbl_Rooms WHERE RoomID = @RoomID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RoomID", roomId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        private Room MapRoom(SqlDataReader reader)
        {
            return new Room
            {
                RoomID = (int)reader["RoomID"],
                RoomNumber = reader["RoomNumber"].ToString(),
                RoomType = reader["RoomType"].ToString(),
                RatePerNight = (decimal)reader["RatePerNight"],
                Status = reader["Status"].ToString(),
                Description = reader["Description"].ToString(),
                CreatedAt = (DateTime)reader["CreatedAt"]
            };
        }
    }
}