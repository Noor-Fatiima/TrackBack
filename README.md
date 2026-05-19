# TrackBack — Lost & Found Management System

A desktop application built with C# Windows Forms 
and SQLite to manage lost and found items on 
university campus.

## Features
- User registration and secure login (BCrypt)
- Report lost and found items
- Search items by keyword
- Submit claims for found items
- Admin panel — manage users, items, claims
- Role-based access (Admin / User)
- Dashboard with statistics

## Technologies
- C# (.NET 8.0)
- Windows Forms
- SQLite (System.Data.SQLite)
- BCrypt.Net-Next
- ADO.NET

## How to Run
1. Open `Trackback.sln` in Visual Studio 2022
2. Build — Ctrl+Shift+B
3. Run — F5

## Default Login
- **Admin Email:** a.dmin@gmail.com
- **Password:** admin123

## Database
SQLite file included at `Database/db.sqlite`
No extra setup needed.
