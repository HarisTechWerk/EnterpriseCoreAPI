# Soft Delete & Restore - EnterpriseCoreAPI

##  Overview
This document explains the **Soft Delete & Restore** functionality in `EnterpriseCoreAPI`.  
Instead of permanently deleting user records, we mark them as **deleted** using a `DeletedAt` timestamp.

---

##  **Implementation Details**
###  **Soft Delete (DELETE /api/Users/{id})**
- Marks a user as **deleted** by setting `DeletedAt = CURRENT_TIMESTAMP`
- The record **remains in the database** but is hidden from queries.

###  **Auto-Filtering of Deleted Records**
- The `ApplicationDbContext` automatically **filters out soft-deleted users**:
```csharp
modelBuilder.Entity<User>().HasQueryFilter(u => u.DeletedAt == null);

    Soft-deleted users won’t appear in GET requests.

 Restore Deleted User (PUT /api/Users/restore/{id})

    Restores a soft-deleted user by removing the DeletedAt timestamp.

 How to Test
 1. Get All Users

GET /api/Users

Expected: Returns only active users.
 2. Soft Delete a User

DELETE /api/Users/{id}

Expected: The user disappears from GET /api/Users but remains in the database.
 3. Restore the User

PUT /api/Users/restore/{id}

Expected: The user is visible again in GET /api/Users.

Database Schema Changes
Column	Type	Description
DeletedAt	DATETIME NULL	Soft delete timestamp. If NULL, the user is active.
