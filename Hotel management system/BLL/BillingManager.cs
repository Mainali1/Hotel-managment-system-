using System;
using System.Collections.Generic;
using Hotel_management_system.DAL;
using Hotel_management_system.Models;
using Hotel_management_system.Helpers;

namespace Hotel_management_system.BLL
{
    public class BillingManager
    {
        private BillingDAL billingDAL = new BillingDAL();

        private const int MIN_NIGHTS = 1;

        public List<Bill> GetAllBills()
        {
            return billingDAL.GetAllBills();
        }

        public Bill GetBillById(int billId)
        {
            return billingDAL.GetBillById(billId);
        }

        public Bill GetBillByBookingId(int bookingId)
        {
            return billingDAL.GetBillByBookingId(bookingId);
        }

        public Bill GenerateBill(Booking booking, decimal ratePerNight, decimal additionalCharges = 0)
        {
            int nights = (booking.CheckOutDate - booking.CheckInDate).Days;
            if (nights < MIN_NIGHTS)
            {
                nights = MIN_NIGHTS;
            }

            decimal subtotal = ratePerNight * nights;
            decimal total = subtotal + additionalCharges;

            return new Bill
            {
                BookingID = booking.BookingID,
                InvoiceNumber = InvoiceHelper.GenerateInvoiceNumber(),
                RatePerNight = ratePerNight,
                NumberOfNights = nights,
                SubTotal = subtotal,
                AdditionalCharges = additionalCharges,
                TotalAmount = total,
                PaymentStatus = "Unpaid",
                GeneratedAt = DateTime.Now
            };
        }

        public (bool success, string message) MarkAsPaid(int billId)
        {
            var bill = billingDAL.GetBillById(billId);
            if (bill == null)
            {
                return (false, "Bill not found.");
            }
            if (bill.PaymentStatus == "Paid")
            {
                return (false, "Bill is already paid.");
            }
            if (billingDAL.UpdatePaymentStatus(billId, "Paid"))
            {
                return (true, "Bill marked as paid.");
            }
            return (false, "Failed to update payment status.");
        }
    }
}