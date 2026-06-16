using System;

namespace Hotel_management_system.Helpers
{
    public static class ValidationHelper
    {
        public static bool IsValidPhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
            {
                return false;
            }
            string digitsOnly = new string(phone.Where(char.IsDigit).ToArray());
            return digitsOnly.Length >= 7;
        }

        public static bool IsValidDateRange(DateTime checkIn, DateTime checkOut)
        {
            return checkOut.Date > checkIn.Date;
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return true;
            }
            return email.Contains("@") && email.Contains(".");
        }

        public static bool IsPositiveDecimal(decimal value)
        {
            return value > 0;
        }

        public static bool IsValidRoomNumber(string roomNumber)
        {
            return !string.IsNullOrWhiteSpace(roomNumber) && roomNumber.Length <= 10;
        }
    }
}