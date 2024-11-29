# BaseballStat
A web application for tracking baseball player and team statistics. ???

?? My project for the ASP.NET Core course at SoftUni. (December 2024)

## ?? How It Works

### Guest visitors:
- View player 
- View teams

### Logged Users:
- View detailed player statistics
- View detailed team statistics
- View team statistics
- View AllTimeGreatPlayers
- View Records
- View Awards


### Admin:
- Creates/deletes players, and teams
- Creates/deletes player statistics
- Create awards
- Create records
- Create AllTimeGreatPlayers
- Can review the statistics history

## ?? Built With
- ASP.NET Core 8.0
- Entity Framework (EF) Core 8.0
- Microsoft SQL Server Express
- ASP.NET Identity System
- Blazor Components
- Repository Pattern
- Auto Mapping
- Dependency Injection
- Status Code Pages Middleware
- Exception Handling Middleware
- Sorting, Filtering, and Paging with EF Core
- Data Validation, both Client-side and Server-side
- Data Validation in the Models and Input View Models
- Custom Validation Attributes
- Responsive Design
- Bootstrap
- jQuery

## ?? Application Configurations

1. **The Connection string**
   - Is in `appsettings.json`. If you don't use SQLEXPRESS, you should replace `Server=.\\SQLEXPRESS;` with `Server=.`;

2. **Database Migrations**
   - Would be applied when you run the application, since the `ASPNETCORE-ENVIRONMENT` is set to `Development`. If you change it, you should apply the migrations yourself.

3. **Seeding sample data**
   - Would happen once you run the application, including Test Accounts:
     - User: `user@user.com` / password: `16051979`
     - Admin: `adminZlati@admin.com` / password: `16051979`

4. **Cloudinary Setup - optionally**
   - Running without it:
     - You won't get an error for missing Cloudinary Credentials - it is handled by using predefined (already uploaded) image, when Cloudinary configuration is missing. So when you are creating content in admin panel, it will be added but not with the image you have chosen.
   - If you want to actually upload images, you should:
     - Add Cloudinary Credentials in `appsettings.json` in the format:

## License
This project is licensed under the MIT License.

## Acknowledgments
Using ASP.NET-MVC-Template developed by:
Nikolay Kostov
Vladislav Karamfilov
Stoyan Shopov