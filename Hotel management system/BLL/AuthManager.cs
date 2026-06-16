using Hotel_management_system.DAL;
using Hotel_management_system.Models;

namespace Hotel_management_system.BLL
{
    public class AuthManager
    {
        private StaffDAL staffDAL = new StaffDAL();

        public Staff Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return null;
            }
            return staffDAL.GetByUsernameAndPassword(username, password);
        }

        public bool ChangePassword(int staffId, string currentPassword, string newPassword)
        {
            var staff = staffDAL.GetById(staffId);
            if (staff == null || staff.Password != currentPassword)
            {
                return false;
            }
            return staffDAL.UpdatePassword(staffId, newPassword);
        }

        public Staff GetStaffById(int staffId)
        {
            return staffDAL.GetById(staffId);
        }
    }
}