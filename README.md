# CoreRazorPagesDemo1 — ASP.NET Core Razor Pages

## 📌 Project Overview
ASP.NET Core Razor Pages application with complete
CRUD operations using Entity Framework Core and SQL Server.

## 📁 Pages Created

### 1. Index Page (Display All Customers)
- Displays all active customers from database
- Links to Details, Edit, Delete actions
- Add New Customer link

### 2. DisplayCustomer Page
- Displays single customer details
- Back to Customer Details link

### 3. AddCustomer Page
- Form to add new customer
- OnPost handler saves to database
- Redirects to Index after save

### 4. EditCustomer Page
- Form to edit existing customer
- OnGet loads customer data
- OnPost updates database
- Redirects to Index after update

### 5. DeleteCustomer Page
- Shows customer details before delete
- OnPost removes from database
- Redirects to Index after delete

## 💻 Tech Stack
- C# | ASP.NET Core Razor Pages
- Entity Framework Core
- SQL Server
- HTML | CSS | Bootstrap

## 🔑 Key Concepts
- Razor Pages Architecture
- Entity Framework Core (Database First)
- Scaffold-DbContext Command
- OnGet & OnPost Handlers
- Dependency Injection
- CRUD Operations with EF Core
