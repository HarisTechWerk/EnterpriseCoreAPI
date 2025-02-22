# Task 1: EF Core Setup & Migrations

##  Overview
This task focuses on setting up **Entity Framework Core (EF Core)** to manage database interactions.

##  What We Did:
- Installed **EF Core & SQL Server Provider**
- Created **User & Product Models** with relationships
- Configured **ApplicationDbContext**
- Ran **Migrations** and created **EnterpriseCoreDB**
- Verified **Database & Tables in SQL Server**

##  Code Changes:
- **Added `User.cs` and `Product.cs`**
- **Configured `ApplicationDbContext.cs`**
- **Updated `Program.cs` to use EF Core**
- **Ran `dotnet ef migrations add InitialCreate`**
- **Ran `dotnet ef database update`**
