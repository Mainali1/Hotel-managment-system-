using System;
using System.Linq;
using System.Text.RegularExpressions;

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
            return digitsOnly.Length >= 7 && digitsOnly.Length <= 15;
        }

        public static bool IsValidDateRange(DateTime checkIn, DateTime checkOut)
        {
            return checkOut.Date > checkIn.Date;
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }
            try
            {
                var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                return regex.IsMatch(email);
            }
            catch
            {
                return false;
            }
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