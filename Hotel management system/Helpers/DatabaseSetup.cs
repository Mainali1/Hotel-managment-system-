using System;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace Hotel_management_system.Helpers
{
    public static class DatabaseSetup
    {
        private static string GetMasterConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["MasterDB"]?.ConnectionString
                ?? "Server=localhost;Database=master;User Id=sa;Password=root123;";
        }

        private static string GetHotelConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["HotelDB"]?.ConnectionString
                ?? "Server=localhost;Database=HotelManagementDB;User Id=sa;Password=root123;";
        }

        public static void InitializeDatabase()
        {
            using (SqlConnection conn = new SqlConnection(GetMasterConnectionString()))
            {
                conn.Open();

                string checkDbQuery = "SELECT COUNT(*) FROM sys.databases WHERE name = 'HotelManagementDB'";
                using (SqlCommand checkCmd = new SqlCommand(checkDbQuery, conn))
                {
                    int exists = (int)checkCmd.ExecuteScalar();
                    if (exists > 0)
                    {
                        return;
                    }
                }

                string createDbQuery = "CREATE DATABASE HotelManagementDB";
                using (SqlCommand createDbCmd = new SqlCommand(createDbQuery, conn))
                {
                    createDbCmd.ExecuteNonQuery();
                }
            }

            CreateTables();
            SeedData();
        }

        private static void CreateTables()
        {
            using (SqlConnection conn = new SqlConnection(GetHotelConnectionString()))
            {
                conn.Open();

                string[] createTableQueries = new string[]
                {
                    @"CREATE TABLE tbl_Staff (
                        StaffID INT IDENTITY(1,1) PRIMARY KEY,
                        Username NVARCHAR(50) NOT NULL UNIQUE,
                        Password NVARCHAR(255) NOT NULL,
                        FullName NVARCHAR(100) NOT NULL,
                        Role NVARCHAR(50) NOT NULL DEFAULT 'Staff',
                        IsActive BIT NOT NULL DEFAULT 1,
                        CreatedAt DATETIME NOT NULL DEFAULT GETDATE()
                    )",
                    @"CREATE TABLE tbl_Rooms (
                        RoomID INT IDENTITY(1,1) PRIMARY KEY,
                        RoomNumber NVARCHAR(10) NOT NULL UNIQUE,
                        RoomType NVARCHAR(50) NOT NULL,
                        RatePerNight DECIMAL(10,2) NOT NULL,
                        Status NVARCHAR(30) NOT NULL DEFAULT 'Available',
                        Description NVARCHAR(255) NULL,
                        CreatedAt DATETIME NOT NULL DEFAULT GETDATE()
                    )",
                    @"CREATE TABLE tbl_Guests (
                        GuestID INT IDENTITY(1,1) PRIMARY KEY,
                        FullName NVARCHAR(100) NOT NULL,
                        Phone NVARCHAR(20) NOT NULL,
                        Email NVARCHAR(100) NULL,
                        Address NVARCHAR(255) NULL,
                        NationalID NVARCHAR(50) NULL,
                        CreatedAt DATETIME NOT NULL DEFAULT GETDATE()
                    )",
                    @"CREATE TABLE tbl_Bookings (
                        BookingID INT IDENTITY(1,1) PRIMARY KEY,
                        GuestID INT NOT NULL REFERENCES tbl_Guests(GuestID),
                        RoomID INT NOT NULL REFERENCES tbl_Rooms(RoomID),
                        CheckInDate DATE NOT NULL,
                        CheckOutDate DATE NOT NULL,
                        Status NVARCHAR(30) NOT NULL DEFAULT 'Confirmed',
                        CreatedBy INT NULL REFERENCES tbl_Staff(StaffID),
                        CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),
                        Notes NVARCHAR(500) NULL
                    )",
                    @"CREATE TABLE tbl_Billing (
                        BillID INT IDENTITY(1,1) PRIMARY KEY,
                        BookingID INT NOT NULL REFERENCES tbl_Bookings(BookingID),
                        InvoiceNumber NVARCHAR(20) NOT NULL UNIQUE,
                        RatePerNight DECIMAL(10,2) NOT NULL,
                        NumberOfNights INT NOT NULL,
                        SubTotal DECIMAL(10,2) NOT NULL,
                        AdditionalCharges DECIMAL(10,2) NOT NULL DEFAULT 0,
                        TotalAmount DECIMAL(10,2) NOT NULL,
                        PaymentStatus NVARCHAR(20) NOT NULL DEFAULT 'Unpaid',
                        GeneratedAt DATETIME NOT NULL DEFAULT GETDATE(),
                        PaidAt DATETIME NULL
                    )"
                };

                foreach (string query in createTableQueries)
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private static void SeedData()
        {
            string hashedPassword = PasswordHelper.HashPassword("admin123");

            using (SqlConnection conn = new SqlConnection(GetHotelConnectionString()))
            {
                conn.Open();

                string seedQuery = $@"
                    INSERT INTO tbl_Staff (Username, Password, FullName, Role)
                    VALUES ('admin', '{hashedPassword}', 'Administrator', 'Admin');

                    INSERT INTO tbl_Rooms (RoomNumber, RoomType, RatePerNight, Status)
                    VALUES 
                        ('101', 'Single', 800.00, 'Available'),
                        ('102', 'Single', 800.00, 'Available'),
                        ('201', 'Double', 1400.00, 'Available'),
                        ('202', 'Deluxe', 2200.00, 'Available'),
                        ('301', 'Suite', 4000.00, 'Available');
                ";

                using (SqlCommand cmd = new SqlCommand(seedQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}