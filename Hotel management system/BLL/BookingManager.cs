using System;
using System.Collections.Generic;
using Hotel_management_system.DAL;
using Hotel_management_system.Models;
using Hotel_management_system.Helpers;

namespace Hotel_management_system.BLL
{
    public class BookingManager
    {
        private BookingDAL bookingDAL = new BookingDAL();
        private RoomDAL roomDAL = new RoomDAL();
        private BillingDAL billingDAL = new BillingDAL();

        public List<Booking> GetAllBookings()
        {
            return bookingDAL.GetAllBookings();
        }

        public Booking GetBookingById(int bookingId)
        {
            return bookingDAL.GetBookingById(bookingId);
        }

        public List<Booking> GetActiveBookings()
        {
            return bookingDAL.GetActiveBookings();
        }

        public List<Booking> SearchBookings(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return GetAllBookings();
            }
            return bookingDAL.SearchBookings(searchTerm);
        }

        public (bool success, string message, int bookingId) CreateBooking(Booking booking)
        {
            if (booking.GuestID <= 0)
            {
                return (false, "Please select a guest.", 0);
            }
            if (booking.RoomID <= 0)
            {
                return (false, "Please select a room.", 0);
            }
            if (!ValidationHelper.IsValidDateRange(booking.CheckInDate, booking.CheckOutDate))
            {
                return (false, "Check-out date must be after check-in date.", 0);
            }
            if (booking.CheckInDate.Date < DateTime.Now.Date)
            {
                return (false, "Check-in date cannot be in the past.", 0);
            }
            if (!bookingDAL.IsRoomAvailable(booking.RoomID, booking.CheckInDate.Date, booking.CheckOutDate.Date))
            {
                return (false, "Room is not available for the selected dates.", 0);
            }

            booking.Status = "Confirmed";
            int bookingId = bookingDAL.AddBooking(booking);
            if (bookingId > 0)
            {
                return (true, "Booking created successfully.", bookingId);
            }
            return (false, "Failed to create booking.", 0);
        }

        public (bool success, string message) CheckIn(int bookingId)
        {
            var booking = bookingDAL.GetBookingById(bookingId);
            if (booking == null)
            {
                return (false, "Booking not found.");
            }
            if (booking.Status != "Confirmed")
            {
                return (false, "Only confirmed bookings can be checked in.");
            }

            if (bookingDAL.UpdateBookingStatus(bookingId, "CheckedIn"))
            {
                roomDAL.UpdateRoomStatus(booking.RoomID, "Occupied");
                return (true, "Check-in successful.");
            }
            return (false, "Failed to check in.");
        }

        public (bool success, string message, Bill bill) CheckOut(int bookingId)
        {
            var booking = bookingDAL.GetBookingById(bookingId);
            if (booking == null)
            {
                return (false, "Booking not found.", null);
            }
            if (booking.Status != "CheckedIn")
            {
                return (false, "Only checked-in bookings can be checked out.", null);
            }

            if (bookingDAL.UpdateBookingStatus(bookingId, "CheckedOut"))
            {
                roomDAL.UpdateRoomStatus(booking.RoomID, "Available");
                var room = roomDAL.GetRoomById(booking.RoomID);
                var billingManager = new BillingManager();
                var bill = billingManager.GenerateBill(booking, room.RatePerNight);
                billingDAL.AddBill(bill);
                return (true, "Check-out successful. Bill generated.", bill);
            }
            return (false, "Failed to check out.", null);
        }

        public (bool success, string message) CancelBooking(int bookingId)
        {
            var booking = bookingDAL.GetBookingById(bookingId);
            if (booking == null)
            {
                return (false, "Booking not found.");
            }
            if (booking.Status == "CheckedIn" || booking.Status == "CheckedOut")
            {
                return (false, "Cannot cancel a booking that is already checked in or checked out.");
            }

            if (bookingDAL.UpdateBookingStatus(bookingId, "Cancelled"))
            {
                return (true, "Booking cancelled successfully.");
            }
            return (false, "Failed to cancel booking.");
        }

        public bool UpdateBooking(Booking booking)
        {
            if (!ValidationHelper.IsValidDateRange(booking.CheckInDate, booking.CheckOutDate))
            {
                return false;
            }
            if (!bookingDAL.IsRoomAvailable(booking.RoomID, booking.CheckInDate.Date, booking.CheckOutDate.Date, booking.BookingID))
            {
                return false;
            }
            return bookingDAL.UpdateBooking(booking);
        }
    }
}