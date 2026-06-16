using Hotel_management_system.Models;

namespace Hotel_management_system.Helpers
{
    public static class SessionManager
    {
        public static Staff CurrentUser { get; private set; }

        public static void Login(Staff staff)
        {
            CurrentUser = staff;
        }

        public static void Logout()
        {
            CurrentUser = null;
        }

        public static bool IsLoggedIn => CurrentUser != null;

        public static int CurrentUserId => CurrentUser?.StaffID ?? 0;

        public static string CurrentUserName => CurrentUser?.FullName ?? "";

        public static string CurrentUserRole => CurrentUser?.Role ?? "";
    }
}