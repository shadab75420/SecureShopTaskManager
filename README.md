# SecureShopTaskManager

# ASP.NET Core MVC Secure Shopping & Task Management System

SecureShopTaskManager is a secure ASP.NET Core MVC web application developed using ASP.NET Core Identity and Entity Framework Core. The application combines secure shopping functionality and task management functionality into a single platform while following secure coding best practices.

The project focuses on implementing:

- Secure Authentication and Authorization
- Role-Based Access Control
- Claims-Based Authorization
- SQL Injection Prevention
- Cross-Site Scripting (XSS) Protection
- Cross-Site Request Forgery (CSRF) Protection
- Secure Session Management
- Secure Input Validation
- Secure Password Policies

This project was built to demonstrate secure web application development using ASP.NET Core MVC.

---

# Project Objectives

The main objective of this project is to create a secure web application using ASP.NET Core MVC and implement industry-standard security practices to protect user data and application functionality.

The application demonstrates:

- ASP.NET Core MVC Architecture
- ASP.NET Core Identity
- Entity Framework Core ORM
- Authentication & Authorization
- Secure Form Handling
- Dependency Injection
- Database Integration with SQL Server

---

# Features

# Authentication Features

- User Registration
- User Login
- User Logout
- ASP.NET Core Identity Integration
- Secure Password Hashing and Salting
- Session Timeout
- Secure Cookies
- Account Lockout After Failed Login Attempts

---

# Authorization Features

## Role-Based Authorization

Two roles are implemented:

### Admin
Admin users can:
- Access Admin Dashboard
- Create Products
- Manage Tasks

### Customer/User
Customer users can:
- View Products
- View Tasks

---

# Claims-Based Authorization

The application uses claims-based authorization for additional permissions.

Example:
- Users with `CanEditTask` claim can edit tasks.

---

# Product Management Module

The Product Module allows:

- Viewing product list
- Creating products (Admin only)

The module uses:
- Entity Framework Core
- Model Validation
- Secure Form Submission

---

# Task Management Module

The Task Module allows:

- Viewing tasks
- Editing tasks
- Managing task completion status

The module demonstrates:
- Claims-Based Authorization
- Secure Input Validation
- Razor Form Handling

---

# Security Features

# SQL Injection Prevention

The application prevents SQL Injection attacks by:

- Using Entity Framework Core ORM
- Using Parameterized Queries
- Avoiding Dynamic SQL Queries

Entity Framework Core automatically parameterizes queries and protects database operations from malicious SQL input.

---

# Cross-Site Scripting (XSS) Protection

The application prevents XSS attacks using Razor automatic HTML encoding.

All user-generated content is safely encoded before rendering on the browser.

---

# CSRF Protection

The application uses Anti-Forgery Tokens to prevent CSRF attacks.

Security measures include:
- Anti-Forgery Token Validation
- Secure Form Submission
- Request Verification

---

# Secure Password Policy

Password rules implemented:

- Minimum 8 characters
- At least one uppercase letter
- At least one number
- At least one special character

These rules improve password strength and reduce security risks.

---

# Secure Session Management

The application uses secure session management techniques including:

- HttpOnly Cookies
- Secure Cookies
- HTTPS Enforcement
- Session Expiration after 15 minutes

This protects user sessions from unauthorized access and session hijacking attacks.

---

# Technologies Used

| Technology | Purpose |
|---|---|
| ASP.NET Core MVC | Web Application Framework |
| Entity Framework Core | ORM |
| SQL Server | Database |
| ASP.NET Core Identity | Authentication & Authorization |
| Bootstrap | Frontend UI |
| Razor Views | UI Rendering |
| Dependency Injection | Service Management |

---

# Project Architecture

The application follows the MVC (Model-View-Controller) architecture.

# Models
Models represent application data.

Examples:
- Product
- UserTask

---

# Views
Views are responsible for UI rendering using Razor syntax.

Examples:
- Product Views
- Task Views
- Admin Dashboard
- Identity Pages

---

# Controllers
Controllers handle HTTP requests and application logic.

Examples:
- ProductController
- UserTaskController
- AdminController

---

# Database Design

The application uses SQL Server database with Entity Framework Core migrations.

Tables include:

- AspNetUsers
- AspNetRoles
- AspNetUserRoles
- Products
- UserTasks

---

# Dependency Injection

Dependency Injection is used throughout the application to manage services and database context efficiently.

Benefits:
- Loose Coupling
- Better Maintainability
- Improved Testability
- Cleaner Architecture

---

# Project Structure

```txt
SecureShopTaskManager
│
├── Areas
│   └── Identity
│
├── Controllers
│   ├── AdminController.cs
│   ├── ProductController.cs
│   └── UserTaskController.cs
│
├── Data
│   └── ApplicationDbContext.cs
│
├── Models
│   ├── Product.cs
│   └── UserTask.cs
│
├── Views
│   ├── Admin
│   ├── Product
│   ├── Shared
│   └── UserTask
│
├── wwwroot
│
├── appsettings.json
│
├── Program.cs
│
└── SecureShopTaskManager.csproj
```

---

# Setup Instructions

# Step 1 — Clone Repository

```bash
git clone <repository-url>
```

---

# Step 2 — Open Project

Open the solution in:

```txt
Visual Studio 2022
```

---

# Step 3 — Install Required Packages

Open Package Manager Console and install the required NuGet packages for Entity Framework Core and ASP.NET Core Identity.

Required packages:
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.AspNetCore.Identity.EntityFrameworkCore
- Microsoft.AspNetCore.Identity.UI

---

# Step 4 — Configure Database Connection

Update the database connection string inside:

```txt
appsettings.json
```

Use SQL Server or LocalDB connection.

---

# Step 5 — Run Migrations

Run Entity Framework Core migrations to create the database and tables.

Commands:
- Add-Migration InitialCreate
- Update-Database

---

# Step 6 — Run Application

Run the application using:

```txt
Ctrl + F5
```

---

# Application URLs

# Register

```txt
/Identity/Account/Register
```

# Login

```txt
/Identity/Account/Login
```

# Product List

```txt
/Product/Index
```

# Create Product

```txt
/Product/Create
```

# Task List

```txt
/UserTask/Index
```

# Admin Dashboard

```txt
/Admin/Dashboard
```

---

# Default Route

The application opens directly to:

```txt
/Product/Index
```

---

# Security Best Practices Implemented

- Authentication using ASP.NET Core Identity
- Role-Based Authorization
- Claims-Based Authorization
- Secure Password Policies
- SQL Injection Prevention
- XSS Protection
- CSRF Protection
- Secure Cookies
- HTTPS Enforcement
- Session Timeout
- Secure Logout
- Input Validation
- Output Encoding

---

# Challenges Faced During Development

- Identity Configuration Errors
- Migration Conflicts
- Missing Razor Identity Pages
- Role Management Setup
- Authentication Routing Issues
- Database Recreation Issues

These issues were resolved using:
- ASP.NET Core Identity UI
- Clean Migrations
- Correct Program.cs Configuration
- Secure Cookie Configuration

---

# Future Enhancements

Future improvements can include:

- Shopping Cart
- Order Placement System
- Payment Gateway Integration
- JWT Authentication
- Email Verification
- Forgot Password Feature
- CAPTCHA Integration
- Repository Pattern
- Logging and Monitoring
- Admin User Management
- Product Image Upload

---

# Learning Outcomes

This project helped in understanding:

- ASP.NET Core MVC Architecture
- ASP.NET Core Identity
- Entity Framework Core
- Authentication & Authorization
- Secure Coding Practices
- Session Management
- MVC Routing
- SQL Server Integration
- Claims-Based Security
- Role-Based Security
