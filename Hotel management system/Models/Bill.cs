namespace Hotel_management_system.Models
{
    public class Bill
    {
        public int BillID { get; set; }
        public int BookingID { get; set; }
        public string InvoiceNumber { get; set; }
        public decimal RatePerNight { get; set; }
        public int NumberOfNights { get; set; }
        public decimal SubTotal { get; set; }
        public decimal AdditionalCharges { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentStatus { get; set; }
        public System.DateTime GeneratedAt { get; set; }
        public System.DateTime? PaidAt { get; set; }
    }
}