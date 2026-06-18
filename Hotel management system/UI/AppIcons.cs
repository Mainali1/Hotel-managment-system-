namespace Hotel_management_system.UI
{
    /// <summary>
    /// Glyph codepoints from the Segoe Fluent Icons / Segoe MDL2 Assets font.
    /// Both fonts use the same Unicode Private-Use-Area codepoints, so the same
    /// glyph string renders correctly whichever one is installed (Theme.IconFontFamily
    /// picks the right font automatically).
    ///
    /// If any icon shows up as an empty box on your machine, open Character Map
    /// (charmap.exe), select "Segoe Fluent Icons" or "Segoe MDL2 Assets", and swap
    /// in a different codepoint from that chart — it's just this one constant to change.
    /// </summary>
    public static class AppIcons
    {
        public const string Dashboard = "\uE71D"; // grid / overview
        public const string Guests = "\uE77B";    // person / contact
        public const string Rooms = "\uE80F";     // building / home
        public const string Bookings = "\uE787";  // calendar
        public const string Billing = "\uE7C3";   // document / invoice
        public const string Logout = "\uE7E8";    // sign out

        public const string Add = "\uE710";
        public const string Save = "\uE74E";
        public const string Edit = "\uE70F";
        public const string Delete = "\uE74D";
        public const string Refresh = "\uE72C";
        public const string Search = "\uE721";
        public const string Print = "\uE749";
        public const string Clear = "\uE894";
        public const string CheckIn = "\uE73E";   // checkmark
        public const string CheckOut = "\uE7E7";  // arrow leaving
        public const string Cancel = "\uE711";
        public const string Invoice = "\uE7C3";
        public const string Paid = "\uE73E";
        public const string User = "\uE77B";
        public const string Lock = "\uE72E";
    }
}