# BaseballStat 🎯
A web application for tracking baseball player and team statistics

## 📚 Course Project
**ASP.NET Core at SoftUni (December 2024)**

## 🚀 How It Works
### 👥 Guest Visitors:
- 👀 View players
- ⚾ View teams

### 🔑 Logged Users:
- 📊 View detailed player statistics
- 🏟️ View detailed team statistics
- 🌟 View All-Time Great Players
- 🏅 View Records
- 🏆 View Awards

### 🛠️ Admin Features:
- ➕ Create/Delete players and teams
- ✍️ Create/Delete player statistics
- 🏆 Create awards
- 📜 Create records
- 🏅 Add All-Time Great Players
- 📖 Review statistics history

## 🛠️ Built With
- ✅ ASP.NET Core 8.0
- ✅ Entity Framework (EF) Core 8.0
- ✅ Microsoft SQL Server Express
- ✅ ASP.NET Identity System
- ✅ Blazor Components
- ✅ Repository Pattern
- ✅ Auto Mapping
- ✅ Dependency Injection
- ✅ Status Code Pages Middleware
- ✅ Exception Handling Middleware
- ✅ Sorting, Filtering, and Paging
- ✅ Client-side and Server-side Validation
- ✅ Custom Validation Attributes
- ✅ Responsive Design with Bootstrap
- ✅ jQuery

## ⚙️ Application Configurations
### 🔗 Connection String
Located in `appsettings.json`. If you're not using SQLEXPRESS, update:

If you're not using SQLEXPRESS, update:
json
Copy code
"ConnectionStrings": {
    "DefaultConnection": "Server=.;Database=BaseballStatDB;Trusted_Connection=True;MultipleActiveResultSets=true"
}
### 🛠️ Database Migrations
Automatically applied during application startup when ASPNETCORE_ENVIRONMENT is set to Development.
For production, apply migrations manually.
### ☁️ Cloudinary Setup (Optional)
Without Cloudinary credentials, predefined images will be used.
To enable image uploads, configure appsettings.json:
json
Copy code
"Cloudinary": {
    "CloudName": "your-cloud-name",
    "ApiKey": "your-api-key",
    "ApiSecret": "your-api-secret"
}
### 📊 Seeding Sample Data
Test accounts are created upon the first run:
User: user@user.com / 16051979
Admin: adminZlati@admin.com / 16051979
### 📸 Screenshots

### 🏠 Home Page
![Not Registret User](https://res.cloudinary.com/dsbprqxc5/image/upload/v1733158152/Players/BaseballStat_xsallf.jpg)

### 🏟️ Players Overview

![Players Overview](https://res.cloudinary.com/dsbprqxc5/image/upload/v1733158323/Players/Players_l6us5m.jpg)
### ⚾ Teams Overview

![Teams Overview](https://res.cloudinary.com/dsbprqxc5/image/upload/v1733158432/Players/Teams_doyyzg.jpg)

### 📜 License
This project is licensed under the MIT License.

### 🙏 Acknowledgments

### Special thanks to:

### Nikolay Kostov
### Vladislav Karamfilov
### Stoyan Shopov

