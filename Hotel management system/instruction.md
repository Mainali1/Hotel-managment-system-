# Hotel Management System — AI Onboarding & Implementation Guide

> **Project by:** Rijan Mainali, Bidhya Malla, Roshna Shrestha  
> **Institution:** Gomendra Multiple College, Birtamode  
> **Program:** Bachelor in Computer Application (BCA), 3rd Semester  
> **Supervisor:** Mr. Jhalnath Chapagain  
> **Affiliation:** Purbanchal University  

---

## ⚠️ CRITICAL NOTES FOR AI — READ FIRST

The submitted PDF proposal has **two naming inconsistencies** that must be understood:

1. The **cover page** says "Student Record Management System" — this is **outdated/wrong**.
2. Every other section of the document consistently describes a **Hotel Management System**.
3. The **Objectives section** mentions "student records" in one bullet — this is a **copy-paste error** from a template. Ignore it. The actual system is a **Hotel Management System**.
4. The **References section** cites C programming books — the actual implementation uses **C# and SQL Server**, not C. This is another template artifact.

**The correct project title is: Hotel Management System**  
**The correct language is: C# (.NET WinForms)**  
**The correct database is: Microsoft SQL Server**

Build everything based on the Hotel Management System specifications described throughout the body of the proposal.

---

## 1. Project Overview

### What This Is
A **Windows desktop application** (WinForms) built with **C# and Microsoft SQL Server** that digitizes and automates hotel administrative operations. The system replaces paper-based manual processes — such as register books and spreadsheets — with a structured, secure, and efficient digital environment.

### Who Uses It
Hotel administrative staff and managers. Users are assumed to have minimal technical expertise. The UI must be intuitive, clean, and accessible without requiring training.

### What Problem It Solves
- Manual paper registers lead to double bookings, data loss, and errors
- Spreadsheets are hard to query and don't enforce data integrity
- Billing is done manually, causing financial discrepancies
- No centralized access control — anyone can modify records

### Academic Context
This is a **BCA 3rd Semester academic project**. The purpose is to demonstrate understanding of:
- Object-Oriented Programming (OOP) in C#
- Database Management with SQL Server
- GUI development with Windows Forms
- Modular software architecture (SDLC-based approach)

Keep code clean, well-commented, and educational. Avoid over-engineering. Prefer clarity over cleverness.

---

## 2. Technology Stack

| Layer | Technology | Notes |
|---|---|---|
| Language | C# | Primary language, OOP-based |
| UI Framework | Windows Forms (WinForms) | .NET desktop GUI |
| Database | Microsoft SQL Server (Express or higher) | Backend RDBMS |
| IDE | Visual Studio 2022 (Community Edition or higher) | Development environment |
| DB Tool | SQL Server Management Studio (SSMS) | DB design and admin |
| Runtime | .NET Desktop Runtime (latest stable) | Required to run the app |
| Architecture Pattern | 3-Layer (Presentation / Business Logic / Data Access) | See Section 5 |

---

## 3. System Requirements

### Hardware (Minimum)
- **Processor:** Intel Core i3 or AMD equivalent, 1.6 GHz or higher
- **RAM:** 4 GB minimum (to support .NET, Visual Studio, and SQL Server services simultaneously)
- **Storage:** 500 MB free disk space minimum (app + SQL Server instance + database files)
- **Display:** 1280x720 resolution minimum (WinForms panels must display correctly at this resolution)
- **Input:** Standard keyboard and mouse

### Software
- **OS:** Windows 10 or Windows 11 (64-bit) — required for .NET compatibility
- **IDE:** Visual Studio 2022 Community Edition or higher
- **Database:** Microsoft SQL Server Express Edition or higher
- **DB Admin:** SQL Server Management Studio (SSMS)
- **Runtime:** .NET Desktop Runtime (latest version at time of development)

### Permissions
- Administrator privileges required during installation (SQL Server setup, connection string configuration)
- Normal user privileges sufficient for day-to-day runtime

### Network
- Designed as a **single-user, offline, local application**
- No internet connectivity required
- Multi-terminal LAN access is explicitly **out of scope** for this version (noted as future enhancement)
- No cloud integration in this version

---

## 4. System Modules — Complete Feature Breakdown

The system is divided into **6 core modules**. Each module must be implemented as a separate, logically independent component.

---

### 4.1 User Authentication Module

**Purpose:** Restrict system access to authorized hotel staff only.

**Features:**
- Login form as the application entry point (first form that loads on startup)
- Username and password fields
- Validate credentials against a `Staff` or `Users` table in SQL Server
- On successful login → redirect to main dashboard
- On failed login → show error message, do NOT close the app
- Optionally: lock account after N failed attempts (bonus feature)
- Session tracking: store logged-in user info in a static class or application-level variable for audit purposes

**UI Elements:**
- `TextBox` for username
- `TextBox` for password (set `PasswordChar = '*'`)
- `Button` for login
- `Label` for error messages
- Logo/branding area (optional)

**Database Table Required:** `tbl_Staff` or `tbl_Users`

**Security Note:** For academic purposes, MD5 or SHA256 hashing of passwords is acceptable. Plain text is not recommended but acceptable if the supervisor permits.

---

### 4.2 Guest Management Module

**Purpose:** Maintain comprehensive profiles of all hotel guests.

**Features:**
- **Add Guest:** Form to input and save new guest details
- **View Guests:** DataGridView showing all registered guests with search/filter
- **Update Guest:** Edit existing guest information
- **Delete Guest:** Remove guest record (with confirmation dialog)
- **Search:** Filter by name, phone number, or guest ID
- Guest profile includes: Guest ID (auto-generated), Full Name, Phone Number, Email, Address, National ID / Passport Number, Check-in Date, Check-out Date, Assigned Room Number, Notes

**UI Elements:**
- `DataGridView` for listing guests
- Input `TextBox` controls for each field
- `DateTimePicker` for check-in and check-out dates
- `Button` controls: Add, Update, Delete, Clear, Search
- `ComboBox` or `TextBox` for room assignment

**Database Table Required:** `tbl_Guests`

**Business Rules:**
- Guest ID must be unique and auto-incremented
- Phone number should have basic format validation
- Check-out date cannot be before check-in date (validate in Business Logic Layer)
- Cannot delete a guest who has an active unpaid booking

---

### 4.3 Room Management Module

**Purpose:** Track all rooms in the hotel, their types, rates, and real-time availability status.

**Features:**
- **Add Room:** Register new room with number, type, rate, and status
- **View Rooms:** DataGridView with all rooms and their current status
- **Update Room:** Change room details, rate, or status
- **Delete Room:** Remove a room (only if not currently occupied or booked)
- **Status Tracking:** Each room has one of three statuses:
  - `Available` — ready for booking
  - `Occupied` — currently has a guest
  - `Under Maintenance` — not available, being serviced
- **Filter:** Filter rooms by type or availability status

**Room Categories:**
- Single
- Double
- Deluxe
- Suite
- (Extensible — add more as needed)

**UI Elements:**
- `DataGridView` for room list with color coding by status (green = available, red = occupied, yellow = maintenance)
- `ComboBox` for room type and status selection
- `NumericUpDown` or `TextBox` for room number and rate
- `Button` controls: Add, Update, Delete, Filter, Refresh

**Database Table Required:** `tbl_Rooms`

**Business Rules:**
- Room numbers must be unique
- Room rate must be a positive number
- A room set to `Occupied` must have an associated guest booking
- Status must update automatically when a guest checks in or out

---

### 4.4 Reservation / Booking Module

**Purpose:** Manage the complete lifecycle of a guest's stay — from booking to check-out.

**Features:**
- **Create Booking:** Link a guest to a room for a defined date range
- **View Bookings:** List of all active and historical bookings
- **Check-in:** Mark guest as arrived, update room status to `Occupied`
- **Check-out:** Mark guest as departed, update room status to `Available`
- **Cancel Booking:** Cancel a reservation before check-in
- **Prevent Double Booking:** System must check room availability for the requested dates before confirming
- **Search:** Find bookings by guest name, room number, or date range

**Booking Lifecycle:**
```
[Created] → [Confirmed] → [Checked In] → [Checked Out]
                       ↘ [Cancelled]
```

**UI Elements:**
- `DateTimePicker` for booking start and end dates
- `ComboBox` to select guest (populated from tbl_Guests)
- `ComboBox` to select room (shows only available rooms)
- `DataGridView` for booking list
- `Button` controls: Book, Check-In, Check-Out, Cancel, View Details

**Database Table Required:** `tbl_Bookings`

**Business Rules:**
- A room cannot be booked if it is already occupied or under maintenance during the requested period
- Check-in date cannot be in the past (for new bookings)
- Check-out date must be after check-in date
- When check-out is processed, trigger billing calculation automatically

---

### 4.5 Billing & Invoicing Module

**Purpose:** Automatically calculate stay costs and generate printable invoices for guests.

**Features:**
- **Auto-calculate Bill:** Total = Room Rate per night × Number of nights stayed
- **Additional Charges:** Support for extra charges (room service, damages, etc.) — optional fields
- **Generate Invoice:** Display formatted invoice with all details
- **Print Invoice:** Allow printing directly from the application
- **Payment Status:** Mark bills as Paid or Unpaid
- **View Billing History:** DataGridView with all past invoices

**Invoice Must Include:**
- Hotel name / header
- Invoice number (auto-generated)
- Guest name and ID
- Room number and type
- Check-in and check-out dates
- Number of nights
- Rate per night
- Subtotal, any additional charges, and total amount
- Payment status
- Date generated

**UI Elements:**
- Read-only `TextBox` or `Label` controls showing calculated values
- `DataGridView` for billing history
- `Button` controls: Generate Bill, Print, Mark as Paid
- `PrintDocument` component for print functionality

**Database Table Required:** `tbl_Billing`

**Business Rules:**
- Bill is generated automatically when a guest checks out
- Number of nights = (Check-out Date − Check-in Date).TotalDays
- Minimum 1 night even if same-day check-in/check-out
- Invoice number must be unique and sequential
- Cannot mark a bill as paid twice

---

### 4.6 Search & Filter Module (Cross-Cutting Feature)

**Purpose:** Allow staff to quickly find specific records across the system.

**Features:**
- Search guests by name, phone, or ID
- Search rooms by number, type, or status
- Search bookings by date range, guest name, or room number
- Filter available rooms for a specific date range (for new bookings)
- Results displayed instantly in DataGridView as the user types (optional: use TextChanged event)

This is not a standalone screen — it is integrated into each module's respective form.

---

## 5. Architecture — 3-Layer Design

The application follows a strict 3-layer architecture. Do NOT mix database code directly in the form (Presentation Layer). Always route through the Business Logic Layer and Data Access Layer.

```
┌─────────────────────────────────────────┐
│          PRESENTATION LAYER             │
│  WinForms Forms (.cs + .Designer.cs)   │
│  - LoginForm                            │
│  - DashboardForm                        │
│  - GuestForm                            │
│  - RoomForm                             │
│  - BookingForm                          │
│  - BillingForm                          │
└────────────────┬────────────────────────┘
                 │ Calls
┌────────────────▼────────────────────────┐
│         BUSINESS LOGIC LAYER            │
│  C# Classes in /BLL/ folder             │
│  - GuestManager.cs                      │
│  - RoomManager.cs                       │
│  - BookingManager.cs                    │
│  - BillingManager.cs                    │
│  - AuthManager.cs                       │
│  - ValidationHelper.cs                  │
└────────────────┬────────────────────────┘
                 │ Calls
┌────────────────▼────────────────────────┐
│          DATA ACCESS LAYER              │
│  C# Classes in /DAL/ folder             │
│  - DatabaseHelper.cs (connection mgmt)  │
│  - GuestDAL.cs                          │
│  - RoomDAL.cs                           │
│  - BookingDAL.cs                        │
│  - BillingDAL.cs                        │
│  - StaffDAL.cs                          │
└────────────────┬────────────────────────┘
                 │ SQL Queries
┌────────────────▼────────────────────────┐
│           DATABASE LAYER                │
│  Microsoft SQL Server                   │
│  - tbl_Staff                            │
│  - tbl_Guests                           │
│  - tbl_Rooms                            │
│  - tbl_Bookings                         │
│  - tbl_Billing                          │
└─────────────────────────────────────────┘
```

### Key Architectural Rules
- Forms only handle UI events and display logic
- All business rules (validation, calculations) live in the BLL
- All SQL queries live in the DAL — no raw SQL strings in forms or BLL
- Use parameterized queries in ALL DAL methods (prevents SQL injection)
- Database connection string stored in `App.config` or a static `DatabaseHelper` class, not hardcoded in each class

---

## 6. Database Schema

### Connection Setup
Use SQL Server Express with Windows Authentication or SQL Server Authentication. Store the connection string in `App.config`:

```xml
<connectionStrings>
  <add name="HotelDB"
       connectionString="Server=.\SQLEXPRESS;Database=HotelManagementDB;Integrated Security=True;"
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

---

### Table: tbl_Staff

```sql
CREATE TABLE tbl_Staff (
    StaffID     INT IDENTITY(1,1) PRIMARY KEY,
    Username    NVARCHAR(50)  NOT NULL UNIQUE,
    Password    NVARCHAR(255) NOT NULL,  -- Store hashed value
    FullName    NVARCHAR(100) NOT NULL,
    Role        NVARCHAR(50)  NOT NULL DEFAULT 'Staff',  -- 'Admin', 'Staff'
    IsActive    BIT           NOT NULL DEFAULT 1,
    CreatedAt   DATETIME      NOT NULL DEFAULT GETDATE()
);
```

---

### Table: tbl_Rooms

```sql
CREATE TABLE tbl_Rooms (
    RoomID      INT IDENTITY(1,1) PRIMARY KEY,
    RoomNumber  NVARCHAR(10)   NOT NULL UNIQUE,
    RoomType    NVARCHAR(50)   NOT NULL,   -- 'Single', 'Double', 'Deluxe', 'Suite'
    RatePerNight DECIMAL(10,2) NOT NULL,
    Status      NVARCHAR(30)   NOT NULL DEFAULT 'Available',  -- 'Available', 'Occupied', 'Under Maintenance'
    Description NVARCHAR(255)  NULL,
    CreatedAt   DATETIME       NOT NULL DEFAULT GETDATE()
);
```

---

### Table: tbl_Guests

```sql
CREATE TABLE tbl_Guests (
    GuestID     INT IDENTITY(1,1) PRIMARY KEY,
    FullName    NVARCHAR(100)  NOT NULL,
    Phone       NVARCHAR(20)   NOT NULL,
    Email       NVARCHAR(100)  NULL,
    Address     NVARCHAR(255)  NULL,
    NationalID  NVARCHAR(50)   NULL,   -- Passport or Citizenship Number
    CreatedAt   DATETIME       NOT NULL DEFAULT GETDATE()
);
```

---

### Table: tbl_Bookings

```sql
CREATE TABLE tbl_Bookings (
    BookingID   INT IDENTITY(1,1) PRIMARY KEY,
    GuestID     INT            NOT NULL REFERENCES tbl_Guests(GuestID),
    RoomID      INT            NOT NULL REFERENCES tbl_Rooms(RoomID),
    CheckInDate  DATE          NOT NULL,
    CheckOutDate DATE          NOT NULL,
    Status      NVARCHAR(30)   NOT NULL DEFAULT 'Confirmed',  -- 'Confirmed', 'CheckedIn', 'CheckedOut', 'Cancelled'
    CreatedBy   INT            NULL REFERENCES tbl_Staff(StaffID),
    CreatedAt   DATETIME       NOT NULL DEFAULT GETDATE(),
    Notes       NVARCHAR(500)  NULL,
    CONSTRAINT chk_dates CHECK (CheckOutDate > CheckInDate)
);
```

---

### Table: tbl_Billing

```sql
CREATE TABLE tbl_Billing (
    BillID          INT IDENTITY(1,1) PRIMARY KEY,
    BookingID       INT             NOT NULL REFERENCES tbl_Bookings(BookingID),
    InvoiceNumber   NVARCHAR(20)    NOT NULL UNIQUE,  -- e.g., 'INV-0001'
    RatePerNight    DECIMAL(10,2)   NOT NULL,
    NumberOfNights  INT             NOT NULL,
    SubTotal        DECIMAL(10,2)   NOT NULL,
    AdditionalCharges DECIMAL(10,2) NOT NULL DEFAULT 0,
    TotalAmount     DECIMAL(10,2)   NOT NULL,
    PaymentStatus   NVARCHAR(20)    NOT NULL DEFAULT 'Unpaid',  -- 'Unpaid', 'Paid'
    GeneratedAt     DATETIME        NOT NULL DEFAULT GETDATE(),
    PaidAt          DATETIME        NULL
);
```

---

### Seed Data (Insert on first run)

```sql
-- Default admin account (password: admin123 — hash in production)
INSERT INTO tbl_Staff (Username, Password, FullName, Role)
VALUES ('admin', 'admin123', 'Administrator', 'Admin');

-- Sample rooms
INSERT INTO tbl_Rooms (RoomNumber, RoomType, RatePerNight, Status)
VALUES 
  ('101', 'Single', 800.00, 'Available'),
  ('102', 'Single', 800.00, 'Available'),
  ('201', 'Double', 1400.00, 'Available'),
  ('202', 'Deluxe', 2200.00, 'Available'),
  ('301', 'Suite',  4000.00, 'Available');
```

---

## 7. Project Folder Structure

```
HotelManagementSystem/
│
├── HotelManagementSystem.sln          ← Solution file
│
└── HotelManagementSystem/             ← Main project folder
    │
    ├── App.config                     ← Connection strings, app settings
    ├── Program.cs                     ← Entry point — loads LoginForm
    │
    ├── Forms/                         ← All WinForms (.cs + .Designer.cs)
    │   ├── LoginForm.cs
    │   ├── DashboardForm.cs
    │   ├── GuestForm.cs
    │   ├── RoomForm.cs
    │   ├── BookingForm.cs
    │   └── BillingForm.cs
    │
    ├── BLL/                           ← Business Logic Layer
    │   ├── AuthManager.cs
    │   ├── GuestManager.cs
    │   ├── RoomManager.cs
    │   ├── BookingManager.cs
    │   ├── BillingManager.cs
    │   └── ValidationHelper.cs
    │
    ├── DAL/                           ← Data Access Layer
    │   ├── DatabaseHelper.cs          ← Connection + shared SQL utilities
    │   ├── StaffDAL.cs
    │   ├── GuestDAL.cs
    │   ├── RoomDAL.cs
    │   ├── BookingDAL.cs
    │   └── BillingDAL.cs
    │
    ├── Models/                        ← Plain C# model classes (POCOs)
    │   ├── Staff.cs
    │   ├── Guest.cs
    │   ├── Room.cs
    │   ├── Booking.cs
    │   └── Bill.cs
    │
    └── Helpers/                       ← Utility classes
        ├── SessionManager.cs          ← Stores current logged-in user
        └── InvoiceHelper.cs           ← Invoice number generation, print logic
```

---

## 8. Model Classes (POCOs)

Define one model class per entity. These are simple data containers with no logic.

### Guest.cs
```csharp
public class Guest
{
    public int GuestID { get; set; }
    public string FullName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string NationalID { get; set; }
    public DateTime CreatedAt { get; set; }
}
```

### Room.cs
```csharp
public class Room
{
    public int RoomID { get; set; }
    public string RoomNumber { get; set; }
    public string RoomType { get; set; }
    public decimal RatePerNight { get; set; }
    public string Status { get; set; }   // "Available", "Occupied", "Under Maintenance"
    public string Description { get; set; }
}
```

### Booking.cs
```csharp
public class Booking
{
    public int BookingID { get; set; }
    public int GuestID { get; set; }
    public string GuestName { get; set; }   // For display purposes (joined)
    public int RoomID { get; set; }
    public string RoomNumber { get; set; }  // For display purposes (joined)
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }
    public string Status { get; set; }
    public string Notes { get; set; }
    public DateTime CreatedAt { get; set; }
}
```

### Bill.cs
```csharp
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
    public DateTime GeneratedAt { get; set; }
}
```

### Staff.cs
```csharp
public class Staff
{
    public int StaffID { get; set; }
    public string Username { get; set; }
    public string FullName { get; set; }
    public string Role { get; set; }
    public bool IsActive { get; set; }
}
```

---

## 9. Data Access Layer — Key Patterns

### DatabaseHelper.cs

```csharp
using System.Configuration;
using System.Data.SqlClient;

public static class DatabaseHelper
{
    private static string connectionString =
        ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;

    public static SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}
```

### Example: GuestDAL.cs Pattern

```csharp
public class GuestDAL
{
    // Get all guests
    public List<Guest> GetAllGuests()
    {
        List<Guest> guests = new List<Guest>();
        using (SqlConnection conn = DatabaseHelper.GetConnection())
        {
            conn.Open();
            string query = "SELECT * FROM tbl_Guests ORDER BY FullName";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    guests.Add(new Guest
                    {
                        GuestID  = (int)reader["GuestID"],
                        FullName = reader["FullName"].ToString(),
                        Phone    = reader["Phone"].ToString(),
                        Email    = reader["Email"].ToString(),
                        Address  = reader["Address"].ToString(),
                        NationalID = reader["NationalID"].ToString()
                    });
                }
            }
        }
        return guests;
    }

    // Add guest — ALWAYS use parameterized queries
    public bool AddGuest(Guest guest)
    {
        using (SqlConnection conn = DatabaseHelper.GetConnection())
        {
            conn.Open();
            string query = @"INSERT INTO tbl_Guests 
                            (FullName, Phone, Email, Address, NationalID)
                            VALUES (@FullName, @Phone, @Email, @Address, @NationalID)";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@FullName",   guest.FullName);
                cmd.Parameters.AddWithValue("@Phone",      guest.Phone);
                cmd.Parameters.AddWithValue("@Email",      guest.Email ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Address",    guest.Address ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@NationalID", guest.NationalID ?? (object)DBNull.Value);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }

    // Update, Delete — follow same pattern with parameterized queries
}
```

**CRITICAL RULE:** Every single SQL query must use `@parameter` placeholders. Never concatenate user input into SQL strings. This is both a security requirement and good academic practice.

---

## 10. Business Logic Layer — Key Rules

### ValidationHelper.cs

```csharp
public static class ValidationHelper
{
    public static bool IsValidPhone(string phone)
    {
        return !string.IsNullOrWhiteSpace(phone) && phone.Length >= 7;
    }

    public static bool IsValidDateRange(DateTime checkIn, DateTime checkOut)
    {
        return checkOut > checkIn;
    }

    public static bool IsValidEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email)) return true; // Email is optional
        return email.Contains("@") && email.Contains(".");
    }

    public static bool IsPositiveDecimal(decimal value)
    {
        return value > 0;
    }
}
```

### BillingManager.cs — Core Calculation

```csharp
public class BillingManager
{
    public Bill GenerateBill(Booking booking, decimal ratePerNight, decimal additionalCharges = 0)
    {
        int nights = (booking.CheckOutDate - booking.CheckInDate).Days;
        if (nights < 1) nights = 1; // Minimum 1 night

        decimal subtotal = ratePerNight * nights;
        decimal total    = subtotal + additionalCharges;

        return new Bill
        {
            BookingID         = booking.BookingID,
            InvoiceNumber     = InvoiceHelper.GenerateInvoiceNumber(),
            RatePerNight      = ratePerNight,
            NumberOfNights    = nights,
            SubTotal          = subtotal,
            AdditionalCharges = additionalCharges,
            TotalAmount       = total,
            PaymentStatus     = "Unpaid",
            GeneratedAt       = DateTime.Now
        };
    }
}
```

### SessionManager.cs

```csharp
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
}
```

---

## 11. UI/UX Guidelines

### Dashboard Layout
- Upon successful login, open `DashboardForm` as the main MDI container or use a navigation panel
- Left sidebar or top menu with clearly labeled navigation buttons:
  - 🏠 Dashboard (home/summary)
  - 👤 Guest Management
  - 🛏️ Room Management
  - 📋 Bookings
  - 💰 Billing
  - 🚪 Logout
- Central content area changes based on selected module
- Status bar at the bottom showing logged-in user's name

### General UI Rules
- Font: Use `Segoe UI`, size 9–11pt for forms; 12–14pt for headings
- Color scheme: Professional — white/light gray backgrounds, dark navy/blue accents
- All `DataGridView` controls: `ReadOnly = true`, `SelectionMode = FullRowSelect`, `AllowUserToAddRows = false`
- All data-entry forms: validate before saving, show error messages via `MessageBox` or `ErrorProvider`
- All destructive actions (Delete, Cancel Booking, Check-out) must show a confirmation `MessageBox` first
- `ComboBox` dropdowns must be pre-populated from the database on form load
- `DateTimePicker` for all date fields — never use plain TextBox for dates

### Form Design Patterns
- Use `GroupBox` to visually organize related fields
- Place Save/Add/Update buttons bottom-right
- Place Cancel/Clear buttons next to primary action button
- Use `Panel` separators between the input section and the data grid section
- Refresh DataGridView after every add/update/delete operation

### Error Handling
- Wrap all database calls in `try-catch (Exception ex)` blocks
- Show user-friendly error messages (not raw exception messages)
- Log errors to console or a simple text log file for debugging
- Example pattern:
  ```csharp
  try
  {
      // DB operation
  }
  catch (SqlException ex)
  {
      MessageBox.Show("Database error: " + ex.Message, "Error",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
  }
  catch (Exception ex)
  {
      MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
  }
  ```

---

## 12. Navigation & Application Flow

```
Application Start
      │
      ▼
  LoginForm
      │
  [Valid Login?]
      │ Yes
      ▼
DashboardForm (Main Window)
      │
  ┌───┼───────────────────────────────────────┐
  │   │                                       │
  ▼   ▼                                       ▼
GuestForm  RoomForm  BookingForm  BillingForm  Logout
```

### Check-out Flow (Critical Path)
```
BookingForm
  → User selects active booking
  → Clicks "Check-out"
  → Confirmation dialog
  → BookingManager.CheckOut(bookingId) called
  → BillingManager.GenerateBill() called
  → Bill saved to tbl_Billing
  → Room status updated to 'Available' in tbl_Rooms
  → Booking status updated to 'CheckedOut' in tbl_Bookings
  → BillingForm opens automatically showing the generated invoice
```

---

## 13. Project Timeline (From the Proposal)

The Gantt chart in the proposal shows the following phases from approximately June 21 to July 26, 2026:

| Phase | Description | Timing |
|---|---|---|
| Requirement Analysis | Finalize scope, modules, and DB schema | Week 1 (June 21–27) |
| System Design | Architecture, form wireframes, DB design | Week 2 (June 28 – July 4) |
| Database Development | Create all SQL Server tables, seed data | Week 2–3 (July 1–11) |
| Documentation | Write report, diagrams, and comments in code | Continuous (July 4–19) |
| Coding (WinForms + Logic) | Implement all modules | Week 3–5 (July 5–19) |
| Testing & Debugging | Functional testing, bug fixes | Week 5–6 (July 19–26) |

---

## 14. Expected Outcomes (Checklist for Completion)

The project is considered complete when all of the following are achieved:

- [ ] Login system works — unauthorized users are blocked
- [ ] Guests can be added, viewed, edited, and deleted
- [ ] Rooms can be managed with real-time status updates
- [ ] Bookings can be created without double-booking conflicts
- [ ] Check-in updates room status to `Occupied`
- [ ] Check-out updates room status to `Available` and triggers billing
- [ ] Bills are auto-calculated based on stay duration and room rate
- [ ] Invoices can be viewed and printed
- [ ] Search and filter works in all relevant modules
- [ ] All forms validate user input before saving
- [ ] Error messages are shown for invalid input or DB failures
- [ ] Code is organized into Presentation / BLL / DAL / Models layers
- [ ] All SQL queries use parameterized inputs (no SQL injection risk)
- [ ] Code is commented — especially complex logic sections

---

## 15. Out of Scope (Do NOT Implement)

The following features are explicitly excluded from this version. Do not add them unless the supervisor specifically requests:

- Cloud integration or remote database access
- Multi-terminal or networked access (LAN)
- Online booking portal or web interface
- Mobile application
- Housekeeping management
- Restaurant/food billing
- Payroll or staff management beyond login
- Advanced analytics or reporting dashboards
- Email or SMS notifications
- External payment gateway integration

These are marked in the proposal as potential **future enhancements**.

---

## 16. Code Quality Standards

Since this is an academic project, code quality will be evaluated. Follow these standards:

1. **Naming Conventions:**
   - Classes: `PascalCase` → `GuestManager`, `BookingDAL`
   - Methods: `PascalCase` → `GetAllGuests()`, `GenerateBill()`
   - Variables: `camelCase` → `guestList`, `totalAmount`
   - Constants: `ALL_CAPS` → `MAX_LOGIN_ATTEMPTS`
   - Controls: prefix with type → `txtGuestName`, `btnSave`, `dgvGuests`, `cmbRoomType`

2. **Comments:**
   - Each class should have a header comment explaining its purpose
   - Each method should have a brief comment if non-obvious
   - Complex logic (billing calculation, availability check) must be commented

3. **No Magic Numbers:**
   - Use named constants or config values instead of hardcoded numbers
   - Example: `const int MIN_NIGHTS = 1;` instead of `if (nights < 1)`

4. **Separation of Concerns:**
   - Zero SQL in forms
   - Zero UI code in DAL or BLL
   - Models contain only data, no logic

5. **Dispose Properly:**
   - Always use `using` blocks for `SqlConnection`, `SqlCommand`, `SqlDataReader`
   - This ensures connections are closed even if an exception occurs

---

## 17. Key Corrections Made to the Original Proposal

For transparency, the following inconsistencies were found in the submitted PDF and corrected in this implementation guide:

| Issue | Found in PDF | Correct Version |
|---|---|---|
| Project Title on Cover Page | "Student Record Management System" | "Hotel Management System" |
| Objective #1 | "store and manage student records" | "store and manage guest and room records" |
| References | C programming books cited | Actual project uses C#, not C |
| References | C programming documentation cited | Not applicable — project is C# + SQL Server |

All corrections above are implementation-level adjustments. The actual content of the proposal (scope, features, architecture, methodology) is consistent and correctly describes a Hotel Management System in C# with WinForms and SQL Server.

---

*End of Onboarding Document — v1.0*  
*Generated for: Hotel Management System, BCA 3rd Semester, Gomendra Multiple College*