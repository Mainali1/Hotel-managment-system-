namespace Hotel_management_system.Models
{
    public class Booking
    {
        public int BookingID { get; set; }
        public int GuestID { get; set; }
        public string GuestName { get; set; }
        public int RoomID { get; set; }
        public string RoomNumber { get; set; }
        public System.DateTime CheckInDate { get; set; }
        public System.DateTime CheckOutDate { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public System.DateTime CreatedAt { get; set; }
    }
}