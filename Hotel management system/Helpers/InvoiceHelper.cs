using System;
using System.IO;
using System.Text;
using Hotel_management_system.Models;

namespace Hotel_management_system.Helpers
{
    public static class InvoiceHelper
    {
        private static readonly string counterFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "invoice_counter.txt");

        public static string GenerateInvoiceNumber()
        {
            int counter = GetNextCounter();
            return "INV-" + DateTime.Now.ToString("yyyyMMdd") + "-" + counter.ToString("D4");
        }

        private static int GetNextCounter()
        {
            int counter = 1;
            try
            {
                if (File.Exists(counterFilePath))
                {
                    string content = File.ReadAllText(counterFilePath).Trim();
                    string[] parts = content.Split(',');
                    if (parts.Length >= 2)
                    {
                        string dateStr = parts[0];
                        if (dateStr == DateTime.Now.ToString("yyyyMMdd"))
                        {
                            counter = int.Parse(parts[1]) + 1;
                        }
                    }
                }
            }
            catch
            {
                counter = 1;
            }

            try
            {
                File.WriteAllText(counterFilePath, DateTime.Now.ToString("yyyyMMdd") + "," + counter);
            }
            catch
            {
            }

            return counter;
        }

        public static string GenerateInvoiceText(Bill bill, Booking booking, Guest guest, Room room)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("========================================");
            sb.AppendLine("         HOTEL MANAGEMENT SYSTEM        ");
            sb.AppendLine("========================================");
            sb.AppendLine();
            sb.AppendLine($"Invoice Number : {bill.InvoiceNumber}");
            sb.AppendLine($"Date           : {bill.GeneratedAt:yyyy-MM-dd HH:mm}");
            sb.AppendLine();
            sb.AppendLine("----------------------------------------");
            sb.AppendLine("GUEST DETAILS");
            sb.AppendLine("----------------------------------------");
            sb.AppendLine($"Guest Name     : {guest.FullName}");
            sb.AppendLine($"Phone          : {guest.Phone}");
            sb.AppendLine($"Email          : {(string.IsNullOrEmpty(guest.Email) ? "N/A" : guest.Email)}");
            sb.AppendLine();
            sb.AppendLine("----------------------------------------");
            sb.AppendLine("BOOKING DETAILS");
            sb.AppendLine("----------------------------------------");
            sb.AppendLine($"Room Number    : {room.RoomNumber}");
            sb.AppendLine($"Room Type      : {room.RoomType}");
            sb.AppendLine($"Check-in Date  : {booking.CheckInDate:yyyy-MM-dd}");
            sb.AppendLine($"Check-out Date : {booking.CheckOutDate:yyyy-MM-dd}");
            sb.AppendLine($"Number of Nights: {bill.NumberOfNights}");
            sb.AppendLine();
            sb.AppendLine("----------------------------------------");
            sb.AppendLine("BILLING DETAILS");
            sb.AppendLine("----------------------------------------");
            sb.AppendLine($"Rate per Night : Rs. {bill.RatePerNight:N2}");
            sb.AppendLine($"Sub Total      : Rs. {bill.SubTotal:N2}");
            sb.AppendLine($"Additional     : Rs. {bill.AdditionalCharges:N2}");
            sb.AppendLine($"Total Amount   : Rs. {bill.TotalAmount:N2}");
            sb.AppendLine();
            sb.AppendLine($"Payment Status : {bill.PaymentStatus}");
            sb.AppendLine();
            sb.AppendLine("========================================");
            sb.AppendLine("       THANK YOU FOR YOUR STAY!         ");
            sb.AppendLine("========================================");
            return sb.ToString();
        }
    }
}