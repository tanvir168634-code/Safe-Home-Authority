# Safe Home Authority

Safe Home Authority is a desktop-based residential management system developed using C#, Windows Forms, and SQL Server. The project was designed to improve tenant information management and strengthen coordination between building owners and law enforcement agencies through a secure and centralized platform.

## Project Overview

The system provides two separate user roles:

- **Building Owners**
  - Register and manage buildings
  - Manage flats, tenants, and workers
  - View information related only to their own properties

- **Police Officers**
  - Access a dedicated administrative dashboard
  - Search and verify tenant information
  - View registered building and resident records for security purposes

The application ensures role-based access control and maintains data privacy while supporting safer residential management.

---

## Features

- Owner Authentication System
- Police Authentication System
- Building Registration & Management
- Flat Management
- Tenant Information Management
- Worker Information Management
- Secure SQL Server Database Integration
- Dashboard-Based Desktop Interface
- Search & Verification Functionality

---

## Technologies Used

| Technology | Purpose |
|---|---|
| C# | Application Development |
| Windows Forms | Graphical User Interface |
| SQL Server | Database Management |
| ADO.NET | Database Connectivity |
| Visual Studio | Development Environment |

---

## Database Setup

The database backup file is included inside the project.

Location:
```text
database/authority.bak
```

### Restore Database in SQL Server

1. Open SQL Server Management Studio (SSMS)
2. Right-click `Databases`
3. Select `Restore Database`
4. Choose `Device`
5. Select `authority.bak`
6. Restore the database

---

## Project Report

The complete academic project report is available in:

```text
docs/Project Report Group_05.pdf
```

---

## How to Run the Project

1. Install:
   - Visual Studio
   - SQL Server
   - SQL Server Management Studio (SSMS)

2. Restore the database using:
```text
authority.bak
```

3. Open:
```text
Safe Home Authurity.sln
```

4. Update the SQL Server connection string if necessary

5. Run the project from Visual Studio

---

## Project Structure

```text
safe-home-authority/
│
├── database/
│   └── authority.bak
│
├── docs/
│   └── Project Report Group_05.pdf
│
├── Safe Home Authurity/
│   ├── Forms/
│   ├── Classes/
│   ├── Resources/
│   └── ...
│
├── README.md
├── .gitignore
└── Safe Home Authurity.sln
```

---

## Developed By

### Md. Tanvir Islam Sarker Tamim
Project Developer & Team Member

### Team Members
- Tanvir Mahatab Anan
- Motiur Rahman Nayem
- Md. Mahmodul Hasan

---

## Academic Information

**Course:** Object Oriented Programming 2  
**University:** American International University-Bangladesh (AIUB)  
**Semester:** Spring 2024-2025

---

## License

This project was developed for academic and educational purposes.
