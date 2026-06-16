namespace Hotel_management_system.Models
{
    public class Guest
    {
        public int GuestID { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string NationalID { get; set; }
        public System.DateTime CreatedAt { get; set; }
    }
}