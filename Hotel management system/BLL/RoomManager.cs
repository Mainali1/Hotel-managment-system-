using System.Collections.Generic;
using Hotel_management_system.DAL;
using Hotel_management_system.Models;
using Hotel_management_system.Helpers;

namespace Hotel_management_system.BLL
{
    public class RoomManager
    {
        private RoomDAL roomDAL = new RoomDAL();
        private BookingDAL bookingDAL = new BookingDAL();

        public List<Room> GetAllRooms()
        {
            return roomDAL.GetAllRooms();
        }

        public Room GetRoomById(int roomId)
        {
            return roomDAL.GetRoomById(roomId);
        }

        public List<Room> GetAvailableRooms()
        {
            return roomDAL.GetAvailableRooms();
        }

        public List<Room> GetRoomsByStatus(string status)
        {
            return roomDAL.GetRoomsByStatus(status);
        }

        public (bool success, string message) AddRoom(Room room)
        {
            if (string.IsNullOrWhiteSpace(room.RoomNumber))
            {
                return (false, "Room number is required.");
            }
            if (!ValidationHelper.IsPositiveDecimal(room.RatePerNight))
            {
                return (false, "Rate per night must be a positive number.");
            }
            if (roomDAL.AddRoom(room))
            {
                return (true, "Room added successfully.");
            }
            return (false, "Failed to add room.");
        }

        public (bool success, string message) UpdateRoom(Room room)
        {
            if (string.IsNullOrWhiteSpace(room.RoomNumber))
            {
                return (false, "Room number is required.");
            }
            if (!ValidationHelper.IsPositiveDecimal(room.RatePerNight))
            {
                return (false, "Rate per night must be a positive number.");
            }
            if (roomDAL.UpdateRoom(room))
            {
                return (true, "Room updated successfully.");
            }
            return (false, "Failed to update room.");
        }

        public (bool success, string message) DeleteRoom(int roomId)
        {
            var room = roomDAL.GetRoomById(roomId);
            if (room == null)
            {
                return (false, "Room not found.");
            }
            if (room.Status == "Occupied")
            {
                return (false, "Cannot delete a room that is currently occupied.");
            }
            if (roomDAL.DeleteRoom(roomId))
            {
                return (true, "Room deleted successfully.");
            }
            return (false, "Failed to delete room.");
        }

        public bool UpdateRoomStatus(int roomId, string status)
        {
            return roomDAL.UpdateRoomStatus(roomId, status);
        }
    }
}