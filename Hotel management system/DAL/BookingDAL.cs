using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Hotel_management_system.Models;

namespace Hotel_management_system.DAL
{
    public class BookingDAL
    {
        public List<Booking> GetAllBookings()
        {
            List<Booking> bookings = new List<Booking>();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"SELECT b.*, g.FullName AS GuestName, r.RoomNumber 
                                FROM tbl_Bookings b
                                INNER JOIN tbl_Guests g ON b.GuestID = g.GuestID
                                INNER JOIN tbl_Rooms r ON b.RoomID = r.RoomID
                                ORDER BY b.CheckInDate DESC";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bookings.Add(MapBooking(reader));
                    }
                }
            }
            return bookings;
        }

        public Booking GetBookingById(int bookingId)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"SELECT b.*, g.FullName AS GuestName, r.RoomNumber 
                                FROM tbl_Bookings b
                                INNER JOIN tbl_Guests g ON b.GuestID = g.GuestID
                                INNER JOIN tbl_Rooms r ON b.RoomID = r.RoomID
                                WHERE b.BookingID = @BookingID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BookingID", bookingId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return MapBooking(reader);
                        }
                    }
                }
            }
            return null;
        }

        public List<Booking> GetActiveBookings()
        {
            List<Booking> bookings = new List<Booking>();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"SELECT b.*, g.FullName AS GuestName, r.RoomNumber 
                                FROM tbl_Bookings b
                                INNER JOIN tbl_Guests g ON b.GuestID = g.GuestID
                                INNER JOIN tbl_Rooms r ON b.RoomID = r.RoomID
                                WHERE b.Status IN ('Confirmed', 'CheckedIn')
                                ORDER BY b.CheckInDate DESC";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bookings.Add(MapBooking(reader));
                    }
                }
            }
            return bookings;
        }

        public List<Booking> SearchBookings(string searchTerm)
        {
            List<Booking> bookings = new List<Booking>();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"SELECT b.*, g.FullName AS GuestName, r.RoomNumber 
                                FROM tbl_Bookings b
                                INNER JOIN tbl_Guests g ON b.GuestID = g.GuestID
                                INNER JOIN tbl_Rooms r ON b.RoomID = r.RoomID
                                WHERE g.FullName LIKE @Search 
                                   OR r.RoomNumber LIKE @Search
                                   OR CAST(b.BookingID AS NVARCHAR) LIKE @Search
                                ORDER BY b.CheckInDate DESC";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Search", "%" + searchTerm + "%");
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            bookings.Add(MapBooking(reader));
                        }
                    }
                }
            }
            return bookings;
        }

        public bool IsRoomAvailable(int roomId, DateTime checkIn, DateTime checkOut, int? excludeBookingId = null)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"SELECT COUNT(*) FROM tbl_Bookings 
                                WHERE RoomID = @RoomID 
                                AND Status NOT IN ('Cancelled', 'CheckedOut')
                                AND (
                                    (CheckInDate <= @CheckIn AND CheckOutDate > @CheckIn)
                                    OR (CheckInDate < @CheckOut AND CheckOutDate >= @CheckOut)
                                    OR (CheckInDate >= @CheckIn AND CheckOutDate <= @CheckOut)
                                )";
                if (excludeBookingId.HasValue)
                {
                    query += " AND BookingID != @ExcludeBookingID";
                }
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RoomID", roomId);
                    cmd.Parameters.AddWithValue("@CheckIn", checkIn);
                    cmd.Parameters.AddWithValue("@CheckOut", checkOut);
                    if (excludeBookingId.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@ExcludeBookingID", excludeBookingId.Value);
                    }
                    int count = (int)cmd.ExecuteScalar();
                    return count == 0;
                }
            }
        }

        public int AddBooking(Booking booking)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO tbl_Bookings 
                                (GuestID, RoomID, CheckInDate, CheckOutDate, Status, CreatedBy, Notes)
                                VALUES (@GuestID, @RoomID, @CheckInDate, @CheckOutDate, @Status, @CreatedBy, @Notes);
                                SELECT SCOPE_IDENTITY();";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@GuestID", booking.GuestID);
                    cmd.Parameters.AddWithValue("@RoomID", booking.RoomID);
                    cmd.Parameters.AddWithValue("@CheckInDate", booking.CheckInDate);
                    cmd.Parameters.AddWithValue("@CheckOutDate", booking.CheckOutDate);
                    cmd.Parameters.AddWithValue("@Status", booking.Status);
                    cmd.Parameters.AddWithValue("@CreatedBy", (object)booking.CreatedAt ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Notes", (object)booking.Notes ?? DBNull.Value);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public bool UpdateBooking(Booking booking)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE tbl_Bookings 
                                SET GuestID = @GuestID, RoomID = @RoomID, CheckInDate = @CheckInDate,
                                    CheckOutDate = @CheckOutDate, Status = @Status, Notes = @Notes
                                WHERE BookingID = @BookingID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@GuestID", booking.GuestID);
                    cmd.Parameters.AddWithValue("@RoomID", booking.RoomID);
                    cmd.Parameters.AddWithValue("@CheckInDate", booking.CheckInDate);
                    cmd.Parameters.AddWithValue("@CheckOutDate", booking.CheckOutDate);
                    cmd.Parameters.AddWithValue("@Status", booking.Status);
                    cmd.Parameters.AddWithValue("@Notes", (object)booking.Notes ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@BookingID", booking.BookingID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateBookingStatus(int bookingId, string status)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "UPDATE tbl_Bookings SET Status = @Status WHERE BookingID = @BookingID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@BookingID", bookingId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteBooking(int bookingId)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM tbl_Bookings WHERE BookingID = @BookingID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BookingID", bookingId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        private Booking MapBooking(SqlDataReader reader)
        {
            return new Booking
            {
                BookingID = (int)reader["BookingID"],
                GuestID = (int)reader["GuestID"],
                GuestName = reader["GuestName"].ToString(),
                RoomID = (int)reader["RoomID"],
                RoomNumber = reader["RoomNumber"].ToString(),
                CheckInDate = (DateTime)reader["CheckInDate"],
                CheckOutDate = (DateTime)reader["CheckOutDate"],
                Status = reader["Status"].ToString(),
                Notes = reader["Notes"].ToString(),
                CreatedAt = (DateTime)reader["CreatedAt"]
            };
        }
    }
}