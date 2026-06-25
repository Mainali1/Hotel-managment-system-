using System;
using System.Collections.Generic;
using Hotel_management_system.Models;

namespace Hotel_management_system.BLL
{
    public class DashboardManager
    {
        private DAL.RoomDAL roomDAL = new DAL.RoomDAL();
        private DAL.GuestDAL guestDAL = new DAL.GuestDAL();
        private DAL.BookingDAL bookingDAL = new DAL.BookingDAL();
        private DAL.BillingDAL billingDAL = new DAL.BillingDAL();

        public int GetTotalRooms()
        {
            return roomDAL.GetTotalRooms();
        }

        public int GetAvailableRooms()
        {
            var rooms = roomDAL.GetAvailableRooms();
            return rooms.Count;
        }

        public int GetOccupiedRooms()
        {
            var rooms = roomDAL.GetAllRooms();
            int count = 0;
            foreach (var room in rooms)
            {
                if (room.Status == "Occupied")
                    count++;
            }
            return count;
        }

        public int GetTotalGuests()
        {
            return guestDAL.GetTotalGuests();
        }

        public int GetActiveBookings()
        {
            var bookings = bookingDAL.GetActiveBookings();
            return bookings.Count;
        }

        public List<Booking> GetTodayCheckIns()
        {
            return bookingDAL.GetTodayCheckIns();
        }

        public List<Booking> GetTodayCheckOuts()
        {
            return bookingDAL.GetTodayCheckOuts();
        }

        public decimal GetTodayRevenue()
        {
            return billingDAL.GetTodayRevenue();
        }

        public decimal GetMonthlyRevenue()
        {
            return billingDAL.GetMonthlyRevenue();
        }

        public List<Booking> GetRecentBookings(int limit = 5)
        {
            return bookingDAL.GetRecentBookings(limit);
        }
    }
}