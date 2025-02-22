# EnterpriseCoreAPI 

##  Project Overview
EnterpriseCoreAPI is a **modern .NET 9 Web API** built with **Clean Architecture**.  
It demonstrates **real-world enterprise development**, covering:
- **EF Core & SQL Performance Optimization**
- **Soft Deletes & Transactions**
- **Redis Caching & MongoDB Logging**
- **Concurrency Handling & Stored Procedures**

## Project Structure

### `EnterpriseCoreAPI/`
- **src/**: Main application code
  - **EnterpriseCore.API/**: Web API Layer
  - **EnterpriseCore.Application/**: Business Logic Layer
  - **EnterpriseCore.Domain/**: Entities & Interfaces
  - **EnterpriseCore.Infrastructure/**: EF Core, Redis, MongoDB
  - **tests/**: Unit & Integration Tests
- **EnterpriseCoreAPI.sln**: Solution File
- **.gitignore**
- **README.md**



## ️ Getting Started

###  Prerequisites
Make sure you have the following installed:
- **.NET 9 SDK**
- **SQL Server 2022**
- **Redis & MongoDB** (for caching & logging)
- **Git** (for version control)

###  Setup & Run
Clone the project and set it up:
```sh
git clone https://github.com/YOUR-GITHUB-USERNAME/EnterpriseCoreAPI.git
cd EnterpriseCoreAPI

dotnet build
dotnet run --project src/EnterpriseCore.API

 Features & Technologies

.NET 9 Web API
 Clean Architecture
 Entity Framework Core 8 (EF Core)
 MediatR for CQRS
 Redis for caching
 MongoDB for logs
 Unit Testing with xUnit
️ Next Steps

EF Core Setup & Migrations  (Next Task)
Implement Soft Deletes
Transaction Handling
SQL Query Optimization
Concurrency Handling
Redis Caching
MongoDB Logging