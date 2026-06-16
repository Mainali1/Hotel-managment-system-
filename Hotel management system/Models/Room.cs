namespace Hotel_management_system.Models
{
    public class Room
    {
        public int RoomID { get; set; }
        public string RoomNumber { get; set; }
        public string RoomType { get; set; }
        public decimal RatePerNight { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public System.DateTime CreatedAt { get; set; }
    }
}