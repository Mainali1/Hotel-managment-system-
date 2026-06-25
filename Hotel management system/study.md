# Hotel Management System — Project Study Document

> **Project Title:** Hotel Management System  
> **Project Type:** Windows Desktop Application (WinForms)  
> **Primary Language:** C# (.NET Framework 4.7.2)  
> **Database:** Microsoft SQL Server  
> **Architecture Pattern:** 3-Layer Architecture  
> **Academic Level:** Bachelor in Computer Application (BCA), 3rd Semester  
> **Institution:** Gomendra Multiple College, Birtamode  
> **Affiliation:** Purbanchal University  
> **Project Team:** Rijan Mainali, Bidhya Malla, Roshna Shrestha  
> **Supervisor:** Mr. Jhalnath Chapagain  
> **Development Timeline:** June 21 – July 26, 2026  

---

## Table of Contents

1. [Project Overview](#1-project-overview)
2. [Problem Statement](#2-problem-statement)
3. [Objectives](#3-objectives)
4. [Target Users](#4-target-users)
5. [Technology Stack](#5-technology-stack)
6. [System Requirements](#6-system-requirements)
7. [Project Folder Structure](#7-project-folder-structure)
8. [Architecture Design](#8-architecture-design)
9. [Database Design](#9-database-design)
10. [Module Descriptions](#10-module-descriptions)
11. [Application Flow & Navigation](#11-application-flow--navigation)
12. [UI/UX Design Details](#12-uiux-design-details)
13. [Key Algorithms & Business Logic](#13-key-algorithms--business-logic)
14. [Code Quality Standards](#14-code-quality-standards)
15. [Security Considerations](#15-security-considerations)
16. [Project Timeline & Milestones](#16-project-timeline--milestones)
17. [Expected Outcomes & Deliverables](#17-expected-outcomes--deliverables)
18. [Limitations & Out-of-Scope Features](#18-limitations--out-of-scope-features)
19. [Future Enhancement Suggestions](#19-future-enhancement-suggestions)
20. [Code Walkthrough by Layer](#20-code-walkthrough-by-layer)

---

## 1. Project Overview

The Hotel Management System is a Windows desktop application developed in C# using the Windows Forms (WinForms) framework and Microsoft SQL Server as the backend database. The system is designed to digitize and automate the core administrative operations of a hotel, replacing manual paper-based processes such as register books, spreadsheets, and hand-written billing.

The application covers the entire guest lifecycle: from guest registration and room booking, through check-in and check-out, to billing and invoice generation. It provides hotel staff with an intuitive graphical interface to manage rooms, track bookings, and generate financial records without requiring specialized technical training.

This project was developed as part of the BCA (Bachelor in Computer Application) 3rd Semester curriculum at Gomendra Multiple College under Purbanchal University. It demonstrates the practical application of Object-Oriented Programming (OOP) concepts, database management, GUI development, and modular software architecture principles.

---

## 2. Problem Statement

Hotels that rely on manual paper-based systems face several critical operational challenges:

- **Double Bookings:** Without a centralized system, it is easy to accidentally assign the same room to multiple guests, leading to conflicts and customer dissatisfaction.
- **Data Loss and Errors:** Paper registers can be lost, damaged, or contain illegible handwriting. Manual data entry into spreadsheets is error-prone.
- **Billing Discrepancies:** Calculating bills manually — multiplying room rates by number of nights, adding extra charges — is susceptible to arithmetic errors and financial discrepancies.
- **Lack of Access Control:** In a paper-based system, anyone can access and modify records. There is no concept of user authentication or role-based permissions.
- **Inefficient Record Keeping:** Finding a specific guest's history or a past booking requires manually flipping through pages or searching spreadsheets, which is time-consuming and impractical as the guest database grows.
- **No Real-Time Availability Tracking:** Staff cannot instantly see which rooms are available, occupied, or under maintenance without physically checking each room or consulting multiple registers.

---

## 3. Objectives

The primary objectives of this project are:

1. **Digitize hotel guest and room records** — Replace paper-based registers with a structured, searchable digital database.
2. **Automate room availability tracking** — Provide real-time status updates for all rooms (Available, Occupied, Under Maintenance).
3. **Prevent double bookings** — Implement conflict-checking logic in the booking module to ensure no room is double-booked.
4. **Streamline the check-in/check-out process** — Allow staff to transition booking statuses and room statuses with a single click.
5. **Automate billing calculations** — Calculate total charges automatically based on room rate and duration of stay.
6. **Generate printable invoices** — Produce formatted bills that include all necessary details for guest records and financial accounting.
7. **Implement user authentication** — Restrict system access to authorized staff members only.
8. **Demonstrate 3-layer architecture** — Showcase clean separation between Presentation (UI), Business Logic, and Data Access layers.
9. **Provide search and filter capabilities** — Enable staff to quickly find guests, rooms, bookings, and bills.
10. **Deliver a user-friendly interface** — Ensure the application can be used by staff with minimal technical expertise.

---

## 4. Target Users

The application is designed for:

- **Hotel Receptionists / Front Desk Staff:** The primary users who handle guest check-ins, check-outs, and day-to-day bookings.
- **Hotel Managers / Proprietors:** Users who oversee operations, view billing records, and manage rooms and guest information.
- **System Administrator (implied):** The admin staff account (`admin`) is used for initial setup and ongoing system administration.

All users are assumed to have basic computer literacy (ability to use mouse, keyboard, and read standard Windows interfaces). No programming or database expertise is assumed.

---

## 5. Technology Stack

The technology stack used in this project is carefully chosen to meet academic requirements while ensuring practical real-world applicability:

| Layer | Technology | Version | Purpose |
|---|---|---|---|
| **Language** | C# | .NET Framework 4.7.2 | Primary object-oriented programming language |
| **UI Framework** | Windows Forms (WinForms) | Built into .NET | Desktop GUI development |
| **Database** | Microsoft SQL Server | Express Edition or higher | Relational database management system |
| **IDE** | Visual Studio | 2022 Community Edition+ | Development environment |
| **DB Administration** | SQL Server Management Studio (SSMS) | SSMS 18+ | Database design and administration |
| **Runtime** | .NET Desktop Runtime | 4.7.2+ | Required to run the compiled application |
| **Architecture** | 3-Layer (Presentation / BLL / DAL) | N/A | Modular software design pattern |
| **UI Enhancement** | Windows DWM API (dwmapi.dll) | Windows 10/11 | Mica/Acrylic backdrop effects |
| **Printing** | System.Drawing.Printing | Built-in .NET | Invoice print functionality |

### Key NuGet/Framework Dependencies

The project uses only built-in .NET Framework assemblies — no third-party NuGet packages are required. All dependencies are part of the standard .NET Framework 4.7.2 installation:

- `System.Data.SqlClient` — For SQL Server database connectivity
- `System.Configuration` — For reading connection strings from App.config
- `System.Drawing` — For custom UI rendering and printing
- `System.Windows.Forms` — For the WinForms UI framework

---

## 6. System Requirements

### Hardware (Minimum)

| Component | Requirement |
|---|---|
| Processor | Intel Core i3 / AMD equivalent, 1.6 GHz or higher |
| RAM | 4 GB minimum (to support .NET, Visual Studio, and SQL Server simultaneously) |
| Storage | 500 MB free disk space minimum |
| Display | 1280×720 resolution minimum |
| Input | Standard keyboard and mouse |

### Software

| Component | Requirement |
|---|---|
| Operating System | Windows 10 or Windows 11 (64-bit) |
| .NET Framework | .NET Desktop Runtime 4.7.2 or higher |
| Database | Microsoft SQL Server Express Edition or higher |
| SQL Authentication | SQL Server Authentication mode enabled (User: `sa`, Password: `root123`) |
| IDE | Visual Studio 2022 Community Edition or higher (for development) |
| Database Admin Tool | SQL Server Management Studio (SSMS) |

### Permissions

- **Installation:** Administrator privileges required for SQL Server setup and connection string configuration.
- **Runtime:** Normal user privileges are sufficient for day-to-day operation.
- **Network:** The application is a single-user, offline, local application. No internet connectivity or network access is required.

---

## 7. Project Folder Structure

The project follows a strict folder organization that mirrors the 3-layer architecture:

```
HotelManagementSystem/
│
├── HotelManagementSystem.slnx          ← Visual Studio Solution file
│
└── HotelManagementSystem/              ← Main Project folder
    │
    ├── App.config                      ← Connection strings and app settings
    ├── Program.cs                      ← Application entry point (Main method)
    │
    ├── Forms/                          ← Presentation Layer — All WinForms
    │   ├── LoginForm.cs
    │   ├── LoginForm.Designer.cs
    │   ├── DashboardForm.cs
    │   ├── DashboardForm.Designer.cs
    │   ├── GuestForm.cs
    │   ├── GuestForm.Designer.cs
    │   ├── RoomForm.cs
    │   ├── RoomForm.Designer.cs
    │   ├── BookingForm.cs
    │   ├── BookingForm.Designer.cs
    │   ├── BillingForm.cs
    │   └── BillingForm.Designer.cs
    │
    ├── BLL/                            ← Business Logic Layer
    │   ├── AuthManager.cs              ← Authentication and password management
    │   ├── GuestManager.cs             ← Guest business rules and validation
    │   ├── RoomManager.cs             ← Room business rules and validation
    │   ├── BookingManager.cs           ← Booking lifecycle logic
    │   └── BillingManager.cs           ← Billing and invoice logic
    │
    ├── DAL/                            ← Data Access Layer
    │   ├── DatabaseHelper.cs           ← Centralized connection management
    │   ├── StaffDAL.cs                 ← Staff/Authentication data access
    │   ├── GuestDAL.cs                 ← Guest CRUD operations
    │   ├── RoomDAL.cs                  ← Room CRUD operations
    │   ├── BookingDAL.cs               ← Booking CRUD and availability checks
    │   └── BillingDAL.cs               ← Billing CRUD operations
    │
    ├── Models/                        ← Plain Old C# Objects (POCOs)
    │   ├── Staff.cs                   ← Staff entity
    │   ├── Guest.cs                   ← Guest entity
    │   ├── Room.cs                    ← Room entity
    │   ├── Booking.cs                 ← Booking entity
    │   └── Bill.cs                    ← Billing/Invoice entity
    │
    ├── Helpers/                       ← Utility and infrastructure classes
    │   ├── DatabaseSetup.cs            ← Auto-creates DB and tables on first run
    │   ├── DwmApi.cs                   ← Windows DWM API interop (Mica effects)
    │   ├── ValidationHelper.cs         ← Reusable validation methods
    │   ├── SessionManager.cs          ← Session state (logged-in user)
    │   └── InvoiceHelper.cs            ← Invoice number generation and text formatting
    │
    ├── UI/                            ← Custom WinForms UI Components
    │   ├── Theme.cs                    ← Centralized color, font, and sizing constants
    │   ├── UIHelpers.cs                ← Rounded rectangle graphics helper
    │   ├── GlassFormBase.cs           ← Base form with Mica/Dark mode effects
    │   ├── GlassCard.cs               ← Rounded panel container
    │   ├── GlassButton.cs             ← Custom styled button
    │   ├── GlassNavButton.cs          ← Navigation sidebar button
    │   ├── GlassInput.cs              ← Styled text input container
    │   └── AppIcons.cs                ← Icon glyph constants (Segoe Fluent Icons)
    │
    └── Properties/                    ← Visual Studio-generated metadata
        ├── AssemblyInfo.cs
        ├── Resources.resx
        ├── Resources.Designer.cs
        ├── Settings.settings
        └── Settings.Designer.cs
```

### Key Architectural Principle

The folder structure is not just a matter of organization — it enforces the 3-layer architecture by design:

- **Forms/ only talks to BLL** — Forms contain zero SQL code and zero business logic.
- **BLL only talks to DAL** — Business rules and validation live here, never in Forms.
- **DAL only talks to the Database** — All SQL queries live exclusively in DAL classes.
- **Models/ are pure data containers** — They contain no logic whatsoever.
- **Helpers/ are infrastructure** — They provide shared utilities available to any layer.

---

## 8. Architecture Design

### 8.1 The 3-Layer Architecture

The application follows the **3-Layer Architecture** (also called Multitier Architecture), which separates the application into three distinct logical layers:

```
┌─────────────────────────────────────────────────────┐
│              PRESENTATION LAYER                     │
│  (WinForms Forms — UI rendering, user events)        │
│                                                     │
│  LoginForm, DashboardForm, GuestForm, RoomForm,     │
│  BookingForm, BillingForm                            │
│         │                           ▲                │
│         │ Calls                     │ Returns data  │
│         ▼                           │                │
│  ┌─────────────────────────────────────────────────┐│
│  │             BUSINESS LOGIC LAYER                 ││
│  │  (C# classes — validation, calculations, rules) ││
│  │                                                  ││
│  │  AuthManager, GuestManager, RoomManager,         ││
│  │  BookingManager, BillingManager                  ││
│  │         │                           ▲             ││
│  │         │ Calls                     │ Returns     ││
│  │         ▼                           │             ││
│  │  ┌─────────────────────────────────────────────┐  ││
│  │  │              DATA ACCESS LAYER               │  ││
│  │  │  (SQL queries — CRUD operations)           │  ││
│  │  │                                             │  ││
│  │  │  DatabaseHelper, StaffDAL, GuestDAL,        │  ││
│  │  │  RoomDAL, BookingDAL, BillingDAL            │  ││
│  │  │         │                         ▲          │  ││
│  │  │         │ Calls                   │          │  ││
│  │         ▼                         │             │  ││
│  └─────────────────────────────────────────────────────┘│
│                       │                              │
│                       ▼                              │
│  ┌─────────────────────────────────────────────────┐│
│  │              DATABASE LAYER                      ││
│  │         Microsoft SQL Server                      ││
│  │                                                  ││
│  │  tbl_Staff, tbl_Guests, tbl_Rooms,                ││
│  │  tbl_Bookings, tbl_Billing                       ││
│  └─────────────────────────────────────────────────┘│
```

### 8.2 Data Flow Between Layers

A typical data operation (e.g., adding a new guest) follows this path:

1. **User Action:** User fills in the GuestForm and clicks "Save"
2. **Presentation Layer (GuestForm.cs):** Receives the click event, gathers data from input controls, creates a `Guest` model object, and calls `GuestManager.AddGuest(guest)`
3. **Business Logic Layer (GuestManager.cs):** Receives the `Guest` object, performs validation (name required, phone format, email format), and calls `GuestDAL.AddGuest(guest)`
4. **Data Access Layer (GuestDAL.cs):** Opens a SQL connection, constructs a parameterized INSERT query, executes it against the database, returns `true`/`false`
5. **Database:** The `INSERT` statement executes against SQL Server
6. **Result:** Flows back up through each layer to the Form, which shows a `MessageBox` to the user

### 8.3 Why 3-Layer Architecture?

- **Separation of Concerns:** Each layer has a single, well-defined responsibility.
- **Maintainability:** Changes in one layer (e.g., swapping the database) do not ripple into other layers.
- **Testability:** Business logic can be unit tested without needing a live database or UI.
- **Academic Relevance:** Demonstrates understanding of OOP principles and software engineering best practices.

---

## 9. Database Design

### 9.1 Database Name

`HotelManagementDB` — Created automatically on first run by `DatabaseSetup.cs` if it does not already exist.

### 9.2 Database Schema Diagram

```
┌─────────────────┐       ┌─────────────────┐       ┌─────────────────┐
│   tbl_Staff     │       │   tbl_Guests    │       │   tbl_Rooms     │
├─────────────────┤       ├─────────────────┤       ├─────────────────┤
│ PK StaffID (INT)│       │ PK GuestID (INT)│       │ PK RoomID (INT) │
│ Username        │       │ FullName        │       │ RoomNumber      │
│ Password        │       │ Phone           │       │ RoomType        │
│ FullName        │       │ Email           │       │ RatePerNight    │
│ Role            │       │ Address         │       │ Status          │
│ IsActive        │       │ NationalID      │       │ Description     │
│ CreatedAt       │       │ CreatedAt       │       │ CreatedAt       │
└─────────────────┘       └────────┬────────┘       └────────┬────────┘
                                  │                         │
                                  │ 1:N                    │ 1:N
                                  ▼                         ▼
                          ┌─────────────────────────────────────────┐
                          │            tbl_Bookings                 │
                          ├─────────────────────────────────────────┤
                          │ PK BookingID (INT)                      │
                          │ FK GuestID (INT) ────────► tbl_Guests  │
                          │ FK RoomID (INT)  ────────► tbl_Rooms  │
                          │ CheckInDate (DATE)                     │
                          │ CheckOutDate (DATE)                   │
                          │ Status (NVARCHAR)                      │
                          │ CreatedBy (FK → tbl_Staff)            │
                          │ Notes (NVARCHAR)                       │
                          │ CreatedAt (DATETIME)                   │
                          └────────────────────┬──────────────────┘
                                               │ 1:1
                                               ▼
                          ┌─────────────────────────────────────────┐
                          │            tbl_Billing                  │
                          ├─────────────────────────────────────────┤
                          │ PK BillID (INT)                        │
                          │ FK BookingID (INT) ───────► tbl_Bookings│
                          │ InvoiceNumber (NVARCHAR, UNIQUE)       │
                          │ RatePerNight (DECIMAL)                 │
                          │ NumberOfNights (INT)                  │
                          │ SubTotal (DECIMAL)                    │
                          │ AdditionalCharges (DECIMAL)           │
                          │ TotalAmount (DECIMAL)                 │
                          │ PaymentStatus (NVARCHAR)              │
                          │ GeneratedAt (DATETIME)                │
                          │ PaidAt (DATETIME, NULLABLE)           │
                          └─────────────────────────────────────────┘
```

### 9.3 Table Definitions

#### tbl_Staff
Stores authentication credentials and profile information for hotel staff.

| Column | Data Type | Constraints | Description |
|---|---|---|---|
| StaffID | INT | PK, IDENTITY(1,1) | Auto-increment primary key |
| Username | NVARCHAR(50) | NOT NULL, UNIQUE | Login username |
| Password | NVARCHAR(255) | NOT NULL | Login password (stored as plain text in this version) |
| FullName | NVARCHAR(100) | NOT NULL | Staff member's full name |
| Role | NVARCHAR(50) | NOT NULL, DEFAULT 'Staff' | Role designation ('Admin' or 'Staff') |
| IsActive | BIT | NOT NULL, DEFAULT 1 | Account active status |
| CreatedAt | DATETIME | NOT NULL, DEFAULT GETDATE() | Account creation timestamp |

**Default Seed Data:** `admin` / `admin123` (Role: Admin)

#### tbl_Rooms
Tracks all hotel rooms with their types, rates, and availability status.

| Column | Data Type | Constraints | Description |
|---|---|---|---|
| RoomID | INT | PK, IDENTITY(1,1) | Auto-increment primary key |
| RoomNumber | NVARCHAR(10) | NOT NULL, UNIQUE | Human-readable room number (e.g., "101") |
| RoomType | NVARCHAR(50) | NOT NULL | Room category: Single, Double, Deluxe, Suite |
| RatePerNight | DECIMAL(10,2) | NOT NULL | Nightly rate in local currency |
| Status | NVARCHAR(30) | NOT NULL, DEFAULT 'Available' | Current status: Available, Occupied, Under Maintenance |
| Description | NVARCHAR(255) | NULL | Optional room description |
| CreatedAt | DATETIME | NOT NULL, DEFAULT GETDATE() | Record creation timestamp |

**Seed Data:** 5 sample rooms across all room types (101, 102, 201, 202, 301)

#### tbl_Guests
Stores comprehensive guest profile information.

| Column | Data Type | Constraints | Description |
|---|---|---|---|
| GuestID | INT | PK, IDENTITY(1,1) | Auto-increment primary key |
| FullName | NVARCHAR(100) | NOT NULL | Guest's full legal name |
| Phone | NVARCHAR(20) | NOT NULL | Primary contact phone number |
| Email | NVARCHAR(100) | NULL | Email address (optional) |
| Address | NVARCHAR(255) | NULL | Physical address |
| NationalID | NVARCHAR(50) | NULL | Passport or Citizenship Number |
| CreatedAt | DATETIME | NOT NULL, DEFAULT GETDATE() | Registration timestamp |

#### tbl_Bookings
Manages the complete lifecycle of a guest's hotel stay.

| Column | Data Type | Constraints | Description |
|---|---|---|---|
| BookingID | INT | PK, IDENTITY(1,1) | Auto-increment primary key |
| GuestID | INT | NOT NULL, FK → tbl_Guests | Reference to the guest |
| RoomID | INT | NOT NULL, FK → tbl_Rooms | Reference to the booked room |
| CheckInDate | DATE | NOT NULL | Arrival date |
| CheckOutDate | DATE | NOT NULL | Departure date |
| Status | NVARCHAR(30) | NOT NULL, DEFAULT 'Confirmed' | Booking state |
| CreatedBy | INT | NULL, FK → tbl_Staff | Staff member who created the booking |
| Notes | NVARCHAR(500) | NULL | Optional notes |
| CreatedAt | DATETIME | NOT NULL, DEFAULT GETDATE() | Booking creation timestamp |

**Booking Status Values:**
- `Confirmed` — Booking created, guest not yet arrived
- `CheckedIn` — Guest has arrived, room is occupied
- `CheckedOut` — Guest has departed
- `Cancelled` — Booking was cancelled

**Business Rule:** `CONSTRAINT chk_dates CHECK (CheckOutDate > CheckInDate)`

#### tbl_Billing
Stores all generated invoices/bills for completed stays.

| Column | Data Type | Constraints | Description |
|---|---|---|---|
| BillID | INT | PK, IDENTITY(1,1) | Auto-increment primary key |
| BookingID | INT | NOT NULL, FK → tbl_Bookings | Associated booking |
| InvoiceNumber | NVARCHAR(20) | NOT NULL, UNIQUE | Human-readable invoice ID (e.g., INV-20260701-0001) |
| RatePerNight | DECIMAL(10,2) | NOT NULL | Rate that was charged per night |
| NumberOfNights | INT | NOT NULL | Total nights stayed |
| SubTotal | DECIMAL(10,2) | NOT NULL | Rate × Nights |
| AdditionalCharges | DECIMAL(10,2) | NOT NULL, DEFAULT 0 | Extra charges (room service, damages, etc.) |
| TotalAmount | DECIMAL(10,2) | NOT NULL | SubTotal + AdditionalCharges |
| PaymentStatus | NVARCHAR(20) | NOT NULL, DEFAULT 'Unpaid' | Payment state: Unpaid, Paid |
| GeneratedAt | DATETIME | NOT NULL, DEFAULT GETDATE() | Invoice generation timestamp |
| PaidAt | DATETIME | NULL | Timestamp when payment was received |

---

## 10. Module Descriptions

### 10.1 User Authentication Module

**File:** `Forms/LoginForm.cs`, `BLL/AuthManager.cs`, `DAL/StaffDAL.cs`, `Helpers/SessionManager.cs`

**Purpose:** Restrict access to the system to authorized hotel staff only.

**Features:**
- Login form as the application entry point (first form displayed on startup)
- Username and password text fields
- Credentials validated against `tbl_Staff` table
- On success: loads `DashboardForm`, stores session in `SessionManager`
- On failure: displays error message, keeps form open, clears password field
- Pressing Enter in the password field triggers login
- Session tracking stores logged-in user globally in `SessionManager.CurrentUser`

**User Interface Elements:**
- `GlassInput` for username
- `GlassInput` with password character masking for password
- `GlassButton` for Login
- `Label` for error messages

**Data Flow:**
```
User enters credentials
       ↓
LoginForm.btnLogin_Click()
       ↓
AuthManager.Login(username, password)
       ↓
StaffDAL.GetByUsernameAndPassword(username, password)
       ↓
SELECT * FROM tbl_Staff WHERE Username=@U AND Password=@P AND IsActive=1
       ↓
If found → SessionManager.Login(staff) → DashboardForm
If not found → Show error message
```

**Security Note:** Passwords are stored as plain text in this version (acceptable for academic purposes). A production system would use SHA256 or bcrypt hashing.

---

### 10.2 Guest Management Module

**File:** `Forms/GuestForm.cs`, `BLL/GuestManager.cs`, `DAL/GuestDAL.cs`

**Purpose:** Maintain comprehensive profiles of all hotel guests.

**Features:**
- **Add Guest:** Creates a new guest record with validation
- **View Guests:** `DataGridView` listing all guests with formatted columns
- **Update Guest:** Edit existing guest information
- **Delete Guest:** Remove a guest record (with confirmation dialog)
- **Search:** Real-time filtering by name, phone number, or guest ID as user types
- **Auto-populate form:** Clicking a row in the DataGridView fills all input fields

**Guest Data Fields:**
- GuestID (auto-generated, read-only)
- Full Name (required)
- Phone Number (required, minimum 7 digits validated)
- Email (optional, format validated)
- Address (optional)
- National ID / Passport Number (optional)
- Created At (auto-generated, read-only)

**Business Rules Enforced by GuestManager:**
- Guest name cannot be empty
- Phone number must be at least 7 digits (letters stripped before validation)
- Email must contain '@' and '.' (only checked if non-empty)
- Delete operation has no restrictions in the current implementation (can delete guests with bookings in this version)

**UI Styling:**
- DataGridView with alternating row colors (white and light gray)
- Black header row with white text (Courier New font, 9pt, bold)
- Row height: 30px, Column header height: 35px
- Column headers styled for visual consistency

---

### 10.3 Room Management Module

**File:** `Forms/RoomForm.cs`, `BLL/RoomManager.cs`, `DAL/RoomDAL.cs`

**Purpose:** Track all rooms, their types, rates, and real-time availability status.

**Features:**
- **Add Room:** Register new room with number, type, rate, and initial status
- **View Rooms:** `DataGridView` listing all rooms
- **Update Room:** Modify room details, rate, or status
- **Delete Room:** Remove a room (blocked if room is currently occupied)
- **Filter by Status:** Filter the grid by Available, Occupied, Under Maintenance, or All
- **Color-coded rows:** Green = Available, Red = Occupied, Yellow = Under Maintenance

**Room Data Fields:**
- RoomID (auto-generated, read-only)
- Room Number (required, unique)
- Room Type: Single, Double, Deluxe, Suite (ComboBox selection)
- Rate Per Night (required, must be positive decimal)
- Status: Available, Occupied, Under Maintenance (ComboBox selection)
- Description (optional)

**Business Rules:**
- Room numbers must be unique (database-level UNIQUE constraint)
- Room rate must be a positive number
- A room set to `Occupied` is not automatically updated by this module — the Booking module handles that
- Cannot delete a room that is currently `Occupied`

**Room Rate Reference:**
| Room Type | Rate Per Night |
|---|---|
| Single | Rs. 800 |
| Double | Rs. 1,400 |
| Deluxe | Rs. 2,200 |
| Suite | Rs. 4,000 |

---

### 10.4 Reservation / Booking Module

**File:** `Forms/BookingForm.cs`, `BLL/BookingManager.cs`, `DAL/BookingDAL.cs`

**Purpose:** Manage the complete lifecycle of a guest's stay from booking to check-out.

**Features:**
- **Create Booking:** Link a guest to a room for a defined date range
- **View Bookings:** `DataGridView` with all active and historical bookings
- **Check-In:** Mark guest as arrived, update room status to `Occupied`, booking status to `CheckedIn`
- **Check-Out:** Mark guest as departed, update room status to `Available`, booking status to `CheckedOut`, automatically generate bill
- **Cancel Booking:** Cancel a reservation (only if not already checked in or checked out)
- **Search:** Find bookings by guest name, room number, or booking ID
- **Double-Booking Prevention:** System checks room availability before confirming any booking

**Booking Data Fields:**
- BookingID (auto-generated)
- Guest (ComboBox populated from tbl_Guests)
- Room (ComboBox showing only Available rooms)
- Check-in Date (DateTimePicker)
- Check-out Date (DateTimePicker, must be after check-in)
- Notes (optional text)

**Booking Lifecycle State Machine:**
```
  [Created/Confirmed]
        │
        ├─── Check-In ────────────────────► [CheckedIn] ──── Check-Out ────► [CheckedOut]
        │                                       │
        └─── Cancel ──────────────────────────► [Cancelled]
```

**Double-Booking Prevention Logic** (`BookingDAL.IsRoomAvailable`):
```sql
SELECT COUNT(*) FROM tbl_Bookings 
WHERE RoomID = @RoomID 
AND Status NOT IN ('Cancelled', 'CheckedOut')
AND (
    (CheckInDate <= @CheckIn AND CheckOutDate > @CheckIn)
    OR (CheckInDate < @CheckOut AND CheckOutDate >= @CheckOut)
    OR (CheckInDate >= @CheckIn AND CheckOutDate <= @CheckOut)
)
```
This checks for any overlap between the requested date range and existing active bookings for the same room.

**Business Rules Enforced:**
- Check-in date cannot be in the past (for new bookings)
- Check-out date must be after check-in date
- Room must be available for the requested dates
- Only `Confirmed` bookings can be checked in
- Only `CheckedIn` bookings can be checked out
- Only `Confirmed` bookings can be cancelled

**Color Coding in DataGridView:**
- Green rows: `Confirmed` status
- Blue rows: `CheckedIn` status
- Gray rows: `CheckedOut` status
- Red rows: `Cancelled` status

---

### 10.5 Billing & Invoicing Module

**File:** `Forms/BillingForm.cs`, `BLL/BillingManager.cs`, `DAL/BillingDAL.cs`, `Helpers/InvoiceHelper.cs`

**Purpose:** Automatically calculate stay costs and generate printable invoices.

**Features:**
- **Auto-calculate Bill:** Total = Rate Per Night × Number of Nights + Additional Charges
- **View Billing History:** DataGridView listing all generated bills
- **View Invoice Details:** Display full bill breakdown (rate, nights, subtotal, charges, total)
- **Generate Invoice Text:** Produce a formatted text invoice
- **Print Invoice:** Print the invoice via `PrintPreviewDialog` and `PrintDocument`
- **Mark as Paid:** Update payment status with timestamp

**Invoice Generation Trigger:**
Bills are generated automatically during the check-out process in `BookingManager.CheckOut()`:
```
1. User clicks "Check-out" on a booking
2. BookingManager.CheckOut(bookingId) is called
3. Booking status updated to 'CheckedOut'
4. Room status updated to 'Available'
5. Room rate fetched from database
6. BillingManager.GenerateBill() calculates charges
7. Bill saved to tbl_Billing
8. Bill object returned to the form for display
```

**Bill Calculation Formula:**
```
NumberOfNights = CheckOutDate - CheckInDate (minimum 1)
SubTotal = RatePerNight × NumberOfNights
TotalAmount = SubTotal + AdditionalCharges
```

**Invoice Number Format:** `INV-YYYYMMDD-NNNN`
- Example: `INV-20260701-0001`, `INV-20260701-0002`
- Format: `INV-` + YearMonthDay + `-` + 4-digit sequential counter (from `InvoiceHelper`)
- Note: Counter resets on application restart (in-memory only, not persisted)

**Invoice Must Include:**
- Hotel name header ("HOTEL MANAGEMENT SYSTEM")
- Invoice number (unique)
- Generation date and time
- Guest details (name, phone, email)
- Room number and type
- Check-in and check-out dates
- Number of nights
- Rate per night
- Subtotal, additional charges, total amount
- Payment status
- Thank-you message

---

## 11. Application Flow & Navigation

### 11.1 Application Startup Flow

```
Program.Main()
       │
       ▼
DatabaseSetup.InitializeDatabase()  ← Creates DB and tables if they don't exist
       │
       ▼
LoginForm.Show()  ← First window displayed
```

**Database Setup Logic (`DatabaseSetup.cs`):**
```
1. Connect to SQL Server (master database)
2. Check if HotelManagementDB exists
3. If NOT exists:
   a. CREATE DATABASE HotelManagementDB
   b. Create all 5 tables (tbl_Staff, tbl_Rooms, tbl_Guests, tbl_Bookings, tbl_Billing)
   c. Seed default admin account (admin/admin123)
   d. Seed 5 sample rooms
4. If exists: silently skip (assumes already set up)
```

### 11.2 Navigation Flow (Post-Login)

```
LoginForm (Username + Password)
       │
       │ Success
       ▼
DashboardForm (Main Container with Sidebar Navigation)
       │
       ├──┬──────────────────────────────────────────┐
       │  │                                          │
       ▼  ▼                                          │
  GuestForm  RoomForm  BookingForm  BillingForm      │
                                              Logout
```

**Dashboard Architecture:**
- `DashboardForm` acts as an **MDI-like container** using a `Panel` for content
- `OpenChildForm()` method replaces the content panel with the selected form
- Navigation sidebar (left side) with `GlassNavButton` controls for each module
- Top section shows: Welcome message (current user name), Role label, Current page title
- Bottom status bar showing logged-in user name
- Active navigation button highlighted with accent color

### 11.3 Check-Out Complete Flow (Critical Path)

```
BookingForm: User selects a "CheckedIn" booking, clicks "Check-Out"
       │
       ▼
Confirmation Dialog (Yes/No)
       │
       │ Yes
       ▼
BookingManager.CheckOut(bookingId)
       │
       ├── Fetch booking from DB
       ├── Validate: Status must be "CheckedIn"
       ├── Update booking status to "CheckedOut"
       ├── Update room status to "Available"
       ├── Get room rate from database
       ├── BillingManager.GenerateBill()
       │     └── Calculate nights, subtotal, total
       ├── Save bill to tbl_Billing
       └── Return Bill object
       │
       ▼
BookingForm receives Bill
       │
       ├── Refresh bookings grid
       ├── Refresh rooms grid (room now available)
       ├── Clear input fields
       └── Show success message
```

---

## 12. UI/UX Design Details

### 12.1 Design Philosophy

The application uses a **modern flat design** inspired by Windows 11's Fluent Design System. Despite being built on WinForms (a legacy framework), the UI uses custom-painted components to achieve a contemporary look:

- **Rounded corners** on all cards, buttons, and input fields (using GDI+ path clipping)
- **Mica/Acrylic backdrop effects** on the window (via Windows DWM API)
- **Dark mode title bar** (immersive dark mode attribute)
- **Color-coded status indicators** in all data grids
- **Segoe Fluent Icons** for navigation and action buttons
- **Segoe UI** font family throughout

### 12.2 Theme Color Palette (`Theme.cs`)

| Color Role | Hex Code | Usage |
|---|---|---|
| AppBackground | #F4F6FA | Main form background |
| SidebarBackground | #181A22 | Left navigation sidebar |
| SidebarHighlight | #262935 | Nav button hover |
| CardBackground | #FFFFFF | Content cards and panels |
| CardBorder | #E8EAF0 | Card outline |
| InputBackground | #F7F8FB | Text input fields |
| InputBorder | #E1E3EA | Input field border |
| Accent | #4D7CFE | Primary action buttons, highlights |
| AccentHover | #3A68EB | Button hover state |
| Success | #2EB87A | Success states, available status |
| Danger | #EB575C | Delete actions, cancelled status |
| Warning | #F5A623 | Warning states, maintenance status |
| TextPrimary | #1A1C24 | Main text color |
| TextOnDark | #FFFFFF | Text on dark backgrounds |
| TextOnDarkMuted | #A2A6B4 | Secondary text on dark backgrounds |

### 12.3 Custom UI Components

The application defines several custom UI components to achieve its visual style:

**GlassFormBase** — Base form class for all windows:
- Applies Windows 11 Mica backdrop via `DwmSetWindowAttribute`
- Enables immersive dark mode for title bar
- Applies rounded window corners
- Fails silently on Windows 10 (no crash, normal window)

**GlassCard** — Rounded rectangle panel:
- Paints itself as a rounded rectangle with configurable corner radius
- Optional border (1px, card border color)
- Used as container for form sections and data grids

**GlassButton** — Flat rounded button:
- Pill-shaped (rounded corners)
- Customizable base color, hover color, and icon glyph
- Icon rendered on the left using Segoe Fluent Icons font

**GlassNavButton** — Sidebar navigation button:
- Left-aligned icon + label layout
- Shows active state (accent color fill) and hover state (highlight color)
- Used exclusively in the DashboardForm sidebar

**GlassInput** — Styled text input:
- A `GlassCard` container holding a borderless `TextBox`
- Focus state changes border color to accent
- Used for username and password fields on LoginForm

### 12.4 DataGridView Styling

All DataGridView controls follow the same styling convention:
- **Row Selection Mode:** Full row select (clicking any cell selects the whole row)
- **Read-only:** No user additions or deletions directly in the grid
- **Alternating rows:** White and light gray alternating backgrounds
- **Header row:** Black background, white text, Courier New 9pt bold
- **Row height:** 30px
- **Header height:** 35px
- **Font:** Courier New 9pt for cell content

---

## 13. Key Algorithms & Business Logic

### 13.1 Room Availability Check (Double-Booking Prevention)

The `BookingDAL.IsRoomAvailable()` method uses date overlap detection:

```csharp
public bool IsRoomAvailable(int roomId, DateTime checkIn, DateTime checkOut, int? excludeBookingId = null)
{
    // Counts overlapping bookings for the same room
    // Three overlap scenarios checked:
    // 1. Existing booking starts before new check-in and ends after check-in
    // 2. Existing booking starts before new check-out and ends after check-out
    // 3. Existing booking starts after new check-in and ends before new check-out
    //
    // Excluded statuses: 'Cancelled' and 'CheckedOut' (these don't block the room)
    //
    // If excludeBookingId is provided (for editing), that booking is ignored in the check
}
```

### 13.2 Bill Generation Algorithm

```csharp
public Bill GenerateBill(Booking booking, decimal ratePerNight, decimal additionalCharges = 0)
{
    // Step 1: Calculate number of nights
    int nights = (booking.CheckOutDate - booking.CheckInDate).Days;

    // Step 2: Enforce minimum of 1 night (same-day checkout still charges 1 night)
    if (nights < MIN_NIGHTS)  // MIN_NIGHTS = 1
        nights = MIN_NIGHTS;

    // Step 3: Calculate subtotal
    decimal subtotal = ratePerNight * nights;

    // Step 4: Calculate grand total
    decimal total = subtotal + additionalCharges;

    // Step 5: Generate invoice number
    string invoiceNumber = InvoiceHelper.GenerateInvoiceNumber();
    // Format: "INV-YYYYMMDD-NNNN"
}
```

### 13.3 Validation Rules (`ValidationHelper.cs`)

| Method | Rule | Description |
|---|---|---|
| `IsValidPhone(phone)` | Digit count ≥ 7 | Strips non-digits, counts remaining |
| `IsValidEmail(email)` | Contains '@' and '.' | Only checked if email is non-empty |
| `IsValidDateRange(checkIn, checkOut)` | `checkOut > checkIn` | Dates must span at least 1 day |
| `IsPositiveDecimal(value)` | `value > 0` | Rate and charge amounts |
| `IsValidRoomNumber(roomNumber)` | Non-empty, ≤ 10 chars | Prevents oversized room numbers |

---

## 14. Code Quality Standards

### 14.1 Naming Conventions

| Element | Convention | Example |
|---|---|---|
| Class names | PascalCase | `GuestManager`, `BookingDAL` |
| Method names | PascalCase | `GetAllGuests()`, `GenerateBill()` |
| Variable names | camelCase | `guestList`, `totalAmount` |
| Constants | ALL_CAPS | `MIN_NIGHTS = 1` |
| WinForms Controls | Hungarian-style prefix | `txtGuestName`, `btnSave`, `dgvGuests`, `cmbRoomType` |
| Private fields | camelCase (no prefix) | `guestDAL`, `bookingList` |

### 14.2 SQL Injection Prevention

All database queries use **parameterized queries** exclusively. No string concatenation or string interpolation is used in SQL query construction.

**Correct (parameterized):**
```csharp
string query = "SELECT * FROM tbl_Guests WHERE FullName LIKE @Search";
cmd.Parameters.AddWithValue("@Search", "%" + searchTerm + "%");
```

**Incorrect (vulnerable):**
```csharp
string query = "SELECT * FROM tbl_Guests WHERE FullName LIKE '%" + searchTerm + "%'";
// NEVER do this — SQL injection risk!
```

### 14.3 Resource Management

All `SqlConnection`, `SqlCommand`, and `SqlDataReader` objects are wrapped in `using` blocks to ensure proper disposal even if an exception occurs:

```csharp
using (SqlConnection conn = DatabaseHelper.GetConnection())
{
    conn.Open();
    using (SqlCommand cmd = new SqlCommand(query, conn))
    using (SqlDataReader reader = cmd.ExecuteReader())
    {
        // work with reader
    } // reader disposed here, even if exception
} // connection closed here, even if exception
```

### 14.4 Error Handling Pattern

All database operations are wrapped in try-catch blocks:

```csharp
try
{
    // Database operation
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

### 14.5 Comments and Documentation

- Each class has a header comment explaining its purpose
- Each method has a brief comment if the logic is non-obvious
- Complex logic (like the billing calculation, availability overlap check) is commented inline
- Magic numbers are avoided in favor of named constants

---

## 15. Security Considerations

### 15.1 Current Security State

The application implements basic security measures:
- **User Authentication:** Login required to access the system
- **Parameterized SQL Queries:** All queries prevent SQL injection
- **Session Management:** Logged-in user tracked via `SessionManager`, accessible globally

### 15.2 Known Security Limitations (Academic Project Scope)

- **Plain-text passwords:** Passwords are stored in `tbl_Staff` as plain text (no hashing). A production system would use SHA256 or bcrypt.
- **No role-based access control:** All logged-in users can access all modules equally. A real system would restrict certain actions (e.g., delete room) to admin users.
- **No audit logging:** Actions are not logged to an audit table.
- **Connection string in App.config:** The SQL Server password is stored in plain text in `App.config`. In production, this should be encrypted or stored securely.
- **No data encryption:** Data is not encrypted at rest in the database.

---

## 16. Project Timeline & Milestones

The project was developed over approximately 5 weeks (June 21 – July 26, 2026) following this planned schedule:

| Phase | Timing | Description |
|---|---|---|
| Requirement Analysis | Week 1 (June 21–27) | Finalize scope, modules, and database schema |
| System Design | Week 2 (June 28 – July 4) | Architecture, form wireframes, database design |
| Database Development | Week 2–3 (July 1–11) | Create all SQL Server tables, seed data |
| Documentation | Continuous (July 4–19) | Write report, diagrams, and comments in code |
| Coding (WinForms + Logic) | Week 3–5 (July 5–19) | Implement all modules (Forms, BLL, DAL) |
| Testing & Debugging | Week 5–6 (July 19–26) | Functional testing, bug fixes |

---

## 17. Expected Outcomes & Deliverables

The project is considered complete when all of the following are verified:

### Functional Checklist
- [ ] Login system works — unauthorized users are blocked
- [ ] Guests can be added, viewed, edited, and deleted
- [ ] Rooms can be managed with real-time status updates
- [ ] Bookings can be created without double-booking conflicts
- [ ] Check-in updates booking status to `CheckedIn` and room to `Occupied`
- [ ] Check-out updates booking status to `CheckedOut`, room to `Available`, and generates a bill
- [ ] Bills are auto-calculated based on stay duration and room rate
- [ ] Invoices can be viewed and printed
- [ ] Search and filter works in all relevant modules
- [ ] All forms validate user input before saving
- [ ] Error messages are shown for invalid input or database failures

### Technical Checklist
- [ ] Code is organized into Presentation / BLL / DAL / Models layers
- [ ] All SQL queries use parameterized inputs (no SQL injection risk)
- [ ] Code is commented — especially complex logic sections
- [ ] Custom UI components are implemented and consistently used
- [ ] Database is created automatically on first run
- [ ] Seed data populates initial admin account and sample rooms

---

## 18. Limitations & Out-of-Scope Features

The following features are explicitly **NOT** implemented in this version:

| Feature | Reason for Exclusion |
|---|---|
| Cloud integration / Remote database | Academic scope — single-user offline app |
| Multi-terminal / LAN access | Academic scope — single machine deployment |
| Online booking portal / Web interface | Out of scope |
| Mobile application | Out of scope |
| Housekeeping management | Not in requirements |
| Restaurant / Food billing | Not in requirements |
| Payroll / HR management | Not in requirements |
| Advanced analytics / Reporting dashboards | Not in requirements |
| Email / SMS notifications | Not in requirements |
| External payment gateway | Out of scope |
| Password hashing | Acceptable for academic level |
| Role-based permissions beyond login | Not in requirements |

---

## 19. Future Enhancement Suggestions

Based on the current implementation, the following enhancements could be added in future versions:

1. **Password hashing** — Store passwords as SHA256 or bcrypt hashes instead of plain text
2. **Role-based access control** — Restrict certain operations (e.g., delete room) to Admin role only
3. **Audit logging** — Track all create/update/delete operations with user and timestamp
4. **Multi-terminal deployment** — Convert to a client-server architecture with a central SQL Server accessible over LAN
5. **Web portal** — Add an online booking portal for guests to make reservations via browser
6. **Housekeeping module** — Track room cleaning schedules and maintenance
7. **Restaurant integration** — Link food orders to guest bills
8. **Reporting dashboard** — Charts and graphs showing occupancy rates, revenue, etc.
9. **Email/SMS notifications** — Send booking confirmations and reminders
10. **Data export** — Export guest data, billing history to Excel/PDF

---

## 20. Code Walkthrough by Layer

### 20.1 Presentation Layer (Forms)

The Presentation Layer consists of 6 Form classes. Every form inherits from either `System.Windows.Forms.Form` (for child forms like GuestForm, RoomForm, etc.) or `GlassFormBase` (for window chrome forms like LoginForm and DashboardForm).

**LoginForm.cs — Entry Point**
```
Constructor:
  - InitializeComponent() loads the designer layout

btnLogin_Click():
  1. Trim and capture username + password
  2. Validate neither field is empty
  3. Create AuthManager and call Login(username, password)
  4. On success: SessionManager.Login(staff) → Hide() → Show DashboardForm
  5. On failure: Show error message, clear password field

txtPassword_KeyDown():
  - If Enter key pressed → trigger btnLogin_Click
```

**DashboardForm.cs — Navigation Container**
```
Constructor:
  - InitializeComponent()
  - Load event → set welcome label, open GuestForm by default

OpenChildForm(childForm, pageTitle):
  1. Close previously active form (if any)
  2. Set TopLevel = false, FormBorderStyle = None
  3. Add to panelContent, Dock = Fill, BringToFront, Show()
  4. Update lblPageTitle

Navigation button clicks:
  - btnDashboard_Click → clear content panel
  - btnGuests_Click → OpenChildForm(new GuestForm())
  - btnRooms_Click → OpenChildForm(new RoomForm())
  - btnBookings_Click → OpenChildForm(new BookingForm())
  - btnBilling_Click → OpenChildForm(new BillingForm())
  - btnLogout_Click → Confirm → SessionManager.Logout() → Show LoginForm
```

**GuestForm.cs — CRUD for Hotel Guests**
```
Data flow:
  - LoadGuests() → calls GuestManager.GetAllGuests() → binds to dgvGuests
  - btnSave_Click → creates Guest object → GuestManager.AddGuest() → refresh
  - btnUpdate_Click → creates Guest object → GuestManager.UpdateGuest() → refresh
  - btnDelete_Click → Confirmation → GuestManager.DeleteGuest() → refresh
  - txtSearch_TextChanged → GuestManager.SearchGuests() → live filter as user types
  - DgvGuests_SelectionChanged → populates input fields from selected row
```

**RoomForm.cs — CRUD for Hotel Rooms**
```
Data flow:
  - PopulateComboBoxes() → sets up room type and status ComboBox items
  - LoadRooms() → RoomManager.GetAllRooms() or GetRoomsByStatus() based on filter
  - FormatDataGridView() → applies color coding by room status
    - Green (#C8FFC8): Available
    - Red (#FFC8C8): Occupied
    - Yellow (#FFFFF8): Under Maintenance
  - btnSave_Click → RoomManager.AddRoom()
  - btnDelete_Click → blocked if room Status == "Occupied"
  - cmbFilterStatus_SelectedIndexChanged → reloads with filter applied
```

**BookingForm.cs — Full Booking Lifecycle**
```
Data flow:
  - LoadGuests() → populates guest ComboBox
  - LoadRooms() → populates room ComboBox (only Available rooms)
  - LoadBookings() → BookingManager.GetAllBookings()
  - btnBook_Click → BookingManager.CreateBooking() → auto-sets status to "Confirmed"
  - btnCheckIn_Click → BookingManager.CheckIn() → status: Confirmed→CheckedIn, room: Occupied
  - btnCheckOut_Click → BookingManager.CheckOut() → generates bill, status: CheckedIn→CheckedOut, room: Available
  - btnCancel_Click → BookingManager.CancelBooking() → status: Confirmed→Cancelled (blocked if CheckedIn/Out)
```

**BillingForm.cs — Invoice Management**
```
Data flow:
  - LoadBills() → BillingManager.GetAllBills() → binds to dgvBills
  - DgvBills_SelectionChanged → DisplayBillDetails()
  - btnMarkPaid_Click → BillingManager.MarkAsPaid() → updates PaidAt timestamp
  - btnViewInvoice_Click → fetches Bill + Booking + Guest + Room → InvoiceHelper.GenerateInvoiceText()
  - btnPrint_Click → PrintPreviewDialog using PrintDocument
  - Color coding: Green rows = Paid, Yellow rows = Unpaid
```

### 20.2 Business Logic Layer (BLL)

The BLL classes act as intermediaries between the Forms and DAL. They enforce business rules and validation but contain no SQL code.

**GuestManager.cs**
- `GetAllGuests()` — passthrough to DAL
- `SearchGuests(searchTerm)` — if empty, returns all guests; otherwise searches
- `AddGuest(guest)` — validates name, phone, email → calls DAL → returns `(success, message)`
- `UpdateGuest(guest)` — same validations as Add → calls DAL
- `DeleteGuest(guestId)` — calls DAL directly (no special rules in current version)

**RoomManager.cs**
- `GetAllRooms()`, `GetAvailableRooms()`, `GetRoomsByStatus()` — various filters
- `AddRoom(room)` — validates room number non-empty and rate > 0
- `UpdateRoom(room)` — same validations
- `DeleteRoom(roomId)` — checks if room is `Occupied` before deleting (cannot delete occupied room)
- `UpdateRoomStatus(roomId, status)` — utility method used by BookingManager

**BookingManager.cs**
- `GetAllBookings()`, `GetActiveBookings()`, `SearchBookings()` — various listing modes
- `CreateBooking(booking)` — comprehensive validation chain:
  1. GuestID must be > 0
  2. RoomID must be > 0
  3. Check-out must be after check-in
  4. Check-in cannot be in the past
  5. Room must be available for dates
  6. Sets status to "Confirmed", saves, returns new BookingID
- `CheckIn(bookingId)` — only Confirmed bookings can check in; updates booking status + room status
- `CheckOut(bookingId)` — only CheckedIn bookings can check out; updates booking, room, generates bill
- `CancelBooking(bookingId)` — only Confirmed bookings can be cancelled
- `UpdateBooking(booking)` — validates dates and availability (excludes self from availability check)

**BillingManager.cs**
- `GetAllBills()`, `GetBillById()`, `GetBillByBookingId()` — retrieval methods
- `GenerateBill(booking, ratePerNight, additionalCharges)` — calculates charges, generates invoice number
- `MarkAsPaid(billId)` — checks not already paid, updates PaymentStatus and PaidAt

**AuthManager.cs**
- `Login(username, password)` — validates non-empty, calls StaffDAL
- `ChangePassword(staffId, currentPassword, newPassword)` — verifies current password matches before updating
- `GetStaffById(staffId)` — passthrough to DAL

### 20.3 Data Access Layer (DAL)

The DAL classes contain all SQL queries. No business logic lives here — only data fetching and persistence.

**DatabaseHelper.cs — Singleton Connection Manager**
```csharp
private static string connectionString = ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;
public static SqlConnection GetConnection() => new SqlConnection(connectionString);
```
All DAL classes call `DatabaseHelper.GetConnection()` to obtain a database connection.

**StaffDAL.cs**
- `GetByUsernameAndPassword(username, password)` — Used for login; returns Staff or null
- `GetById(staffId)` — Used for password change verification
- `UpdatePassword(staffId, newPassword)` — Used when changing password

**GuestDAL.cs**
- `GetAllGuests()` — SELECT * FROM tbl_Guests ORDER BY FullName
- `GetGuestById(guestId)` — SELECT * FROM tbl_Guests WHERE GuestID = @GuestID
- `SearchGuests(searchTerm)` — LIKE query on FullName, Phone, GuestID
- `AddGuest(guest)` — INSERT with parameterized values
- `UpdateGuest(guest)` — UPDATE with parameterized values
- `DeleteGuest(guestId)` — DELETE WHERE GuestID = @GuestID

**RoomDAL.cs**
- `GetAllRooms()` — SELECT * FROM tbl_Rooms ORDER BY RoomNumber
- `GetRoomById(roomId)` — SELECT * FROM tbl_Rooms WHERE RoomID = @RoomID
- `GetRoomsByStatus(status)` — WHERE Status = @Status
- `GetAvailableRooms()` — calls GetRoomsByStatus("Available")
- `AddRoom(room)` — INSERT
- `UpdateRoom(room)` — UPDATE (all fields)
- `UpdateRoomStatus(roomId, status)` — UPDATE Status only (used by booking workflow)
- `DeleteRoom(roomId)` — DELETE WHERE RoomID = @RoomID

**BookingDAL.cs**
- `GetAllBookings()` — JOINs with tbl_Guests and tbl_Rooms for display names
- `GetBookingById(bookingId)` — single booking with joins
- `GetActiveBookings()` — WHERE Status IN ('Confirmed', 'CheckedIn')
- `SearchBookings(searchTerm)` — searches guest name, room number, booking ID
- `IsRoomAvailable(roomId, checkIn, checkOut, excludeBookingId)` — overlap detection query
- `AddBooking(booking)` — INSERT with `SCOPE_IDENTITY()` to return new ID
- `UpdateBooking(booking)` — UPDATE all fields
- `UpdateBookingStatus(bookingId, status)` — UPDATE Status only
- `DeleteBooking(bookingId)` — DELETE WHERE BookingID = @BookingID

**BillingDAL.cs**
- `GetAllBills()` — SELECT * FROM tbl_Billing ORDER BY GeneratedAt DESC
- `GetBillById(billId)` — single bill fetch
- `GetBillByBookingId(bookingId)` — used to check if booking already has a bill
- `AddBill(bill)` — INSERT with SCOPE_IDENTITY()
- `UpdatePaymentStatus(billId, status)` — UPDATE status; if "Paid", also set PaidAt to current time
- `GetNextInvoiceNumber()` — SELECT TOP 1 InvoiceNumber, parses and increments counter

### 20.4 Models Layer (POCOs)

Model classes are simple data containers with only properties and no methods:

| Model | Properties |
|---|---|
| **Guest** | GuestID, FullName, Phone, Email, Address, NationalID, CreatedAt |
| **Room** | RoomID, RoomNumber, RoomType, RatePerNight, Status, Description, CreatedAt |
| **Booking** | BookingID, GuestID, GuestName (joined), RoomID, RoomNumber (joined), CheckInDate, CheckOutDate, Status, Notes, CreatedAt |
| **Bill** | BillID, BookingID, InvoiceNumber, RatePerNight, NumberOfNights, SubTotal, AdditionalCharges, TotalAmount, PaymentStatus, GeneratedAt, PaidAt |
| **Staff** | StaffID, Username, Password, FullName, Role, IsActive |

### 20.5 Helpers Layer

| Class | Responsibility |
|---|---|
| **DatabaseSetup** | On first run: creates HotelManagementDB, creates all 5 tables, seeds admin + rooms |
| **SessionManager** | Static class holding `CurrentUser` (Staff object), login/logout methods, helper properties |
| **ValidationHelper** | Static validation methods: phone, email, date range, positive decimal, room number |
| **InvoiceHelper** | Generates invoice numbers (INV-YYYYMMDD-NNNN), generates formatted invoice text |
| **DwmApi** | P/Invoke declarations for Windows DWM API (Mica backdrop, dark mode, rounded corners) |

### 20.6 UI Layer

| Class | Responsibility |
|---|---|
| **Theme** | Centralized static definitions for all colors, fonts, sizes, icon font family detection |
| **UIHelpers** | `RoundedRect()` — creates a GDI+ GraphicsPath for rounded rectangles |
| **GlassFormBase** | Base form with OnLoad → calls ApplyWindowsGlassEffects() for Mica/dark mode |
| **GlassCard** | Custom Panel that paints itself as a rounded rectangle with optional border |
| **GlassButton** | Custom Button with flat style, rounded corners, hover effect, optional icon glyph |
| **GlassNavButton** | Navigation sidebar button with icon + label, active/hover highlight |
| **GlassInput** | GlassCard container wrapping a borderless TextBox with focus state |
| **AppIcons** | Static constants for icon glyph codepoints (Segoe Fluent Icons / MDL2 Assets) |

---

## Appendix A: Database Initialization Script Reference

The `DatabaseSetup.cs` class generates the following SQL on first run:

```sql
-- Creates HotelManagementDB if not exists
CREATE DATABASE HotelManagementDB;

-- tbl_Staff
CREATE TABLE tbl_Staff (
    StaffID INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(255) NOT NULL,
    FullName NVARCHAR(100) NOT NULL,
    Role NVARCHAR(50) NOT NULL DEFAULT 'Staff',
    IsActive BIT NOT NULL DEFAULT 1,
    CreatedAt DATETIME NOT NULL DEFAULT GETDATE()
);

-- tbl_Rooms
CREATE TABLE tbl_Rooms (
    RoomID INT IDENTITY(1,1) PRIMARY KEY,
    RoomNumber NVARCHAR(10) NOT NULL UNIQUE,
    RoomType NVARCHAR(50) NOT NULL,
    RatePerNight DECIMAL(10,2) NOT NULL,
    Status NVARCHAR(30) NOT NULL DEFAULT 'Available',
    Description NVARCHAR(255) NULL,
    CreatedAt DATETIME NOT NULL DEFAULT GETDATE()
);

-- tbl_Guests
CREATE TABLE tbl_Guests (
    GuestID INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    Phone NVARCHAR(20) NOT NULL,
    Email NVARCHAR(100) NULL,
    Address NVARCHAR(255) NULL,
    NationalID NVARCHAR(50) NULL,
    CreatedAt DATETIME NOT NULL DEFAULT GETDATE()
);

-- tbl_Bookings
CREATE TABLE tbl_Bookings (
    BookingID INT IDENTITY(1,1) PRIMARY KEY,
    GuestID INT NOT NULL REFERENCES tbl_Guests(GuestID),
    RoomID INT NOT NULL REFERENCES tbl_Rooms(RoomID),
    CheckInDate DATE NOT NULL,
    CheckOutDate DATE NOT NULL,
    Status NVARCHAR(30) NOT NULL DEFAULT 'Confirmed',
    CreatedBy INT NULL REFERENCES tbl_Staff(StaffID),
    CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),
    Notes NVARCHAR(500) NULL,
    CONSTRAINT chk_dates CHECK (CheckOutDate > CheckInDate)
);

-- tbl_Billing
CREATE TABLE tbl_Billing (
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
);

-- Seed Data
INSERT INTO tbl_Staff (Username, Password, FullName, Role) 
VALUES ('admin', 'admin123', 'Administrator', 'Admin');

INSERT INTO tbl_Rooms (RoomNumber, RoomType, RatePerNight, Status) VALUES 
('101', 'Single', 800.00, 'Available'),
('102', 'Single', 800.00, 'Available'),
('201', 'Double', 1400.00, 'Available'),
('202', 'Deluxe', 2200.00, 'Available'),
('301', 'Suite', 4000.00, 'Available');
```

---

## Appendix B: Connection String Configuration

The application reads its database connection string from `App.config`:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <connectionStrings>
        <add name="HotelDB"
             connectionString="Server=localhost;Database=HotelManagementDB;User Id=sa;Password=root123;"
             providerName="System.Data.SqlClient" />
    </connectionStrings>
    <startup>
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.7.2" />
    </startup>
</configuration>
```

**Connection String Parameters:**
- `Server=localhost` — SQL Server instance on the local machine
- `Database=HotelManagementDB` — The database name (created automatically)
- `User Id=sa` — SQL Server authentication username
- `Password=root123` — SQL Server authentication password

---

*Document generated for academic reference — Hotel Management System, BCA 3rd Semester, Gomendra Multiple College*