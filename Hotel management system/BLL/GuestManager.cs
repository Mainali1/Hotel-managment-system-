using System.Collections.Generic;
using Hotel_management_system.DAL;
using Hotel_management_system.Models;
using Hotel_management_system.Helpers;

namespace Hotel_management_system.BLL
{
    public class GuestManager
    {
        private GuestDAL guestDAL = new GuestDAL();

        public List<Guest> GetAllGuests()
        {
            return guestDAL.GetAllGuests();
        }

        public Guest GetGuestById(int guestId)
        {
            return guestDAL.GetGuestById(guestId);
        }

        public List<Guest> SearchGuests(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return GetAllGuests();
            }
            return guestDAL.SearchGuests(searchTerm);
        }

        public (bool success, string message) AddGuest(Guest guest)
        {
            if (string.IsNullOrWhiteSpace(guest.FullName))
            {
                return (false, "Guest name is required.");
            }
            if (!ValidationHelper.IsValidPhone(guest.Phone))
            {
                return (false, "Invalid phone number. Phone must be at least 7 digits.");
            }
            if (!ValidationHelper.IsValidEmail(guest.Email))
            {
                return (false, "Invalid email format.");
            }
            if (guestDAL.AddGuest(guest))
            {
                return (true, "Guest added successfully.");
            }
            return (false, "Failed to add guest.");
        }

        public (bool success, string message) UpdateGuest(Guest guest)
        {
            if (string.IsNullOrWhiteSpace(guest.FullName))
            {
                return (false, "Guest name is required.");
            }
            if (!ValidationHelper.IsValidPhone(guest.Phone))
            {
                return (false, "Invalid phone number. Phone must be at least 7 digits.");
            }
            if (!ValidationHelper.IsValidEmail(guest.Email))
            {
                return (false, "Invalid email format.");
            }
            if (guestDAL.UpdateGuest(guest))
            {
                return (true, "Guest updated successfully.");
            }
            return (false, "Failed to update guest.");
        }

        public (bool success, string message) DeleteGuest(int guestId)
        {
            if (guestDAL.DeleteGuest(guestId))
            {
                return (true, "Guest deleted successfully.");
            }
            return (false, "Failed to delete guest.");
        }
    }
}