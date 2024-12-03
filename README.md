BaseballStat
🎯 A web application for tracking baseball player and team statistics

📚 My project for the ASP.NET Core course at SoftUni. (December 2024)

🚀 How It Works
👥 Guest Visitors:
👀 View players
⚾ View teams
🔑 Logged Users:
📊 View detailed player statistics
🏟️ View detailed team statistics
🌟 View All-Time Great Players
🏅 View Records
🏆 View Awards
🛠️ Admin Features:
➕ Create/Delete players and teams
✍️ Create/Delete player statistics
🏆 Create awards
📜 Create records
🏅 Add All-Time Great Players
📖 Review statistics history
🛠️ Built With
✅ ASP.NET Core 8.0
✅ Entity Framework (EF) Core 8.0
✅ Microsoft SQL Server Express
✅ ASP.NET Identity System
✅ Blazor Components
✅ Repository Pattern
✅ Auto Mapping
✅ Dependency Injection
✅ Status Code Pages Middleware
✅ Exception Handling Middleware
✅ Sorting, Filtering, and Paging
✅ Client-side and Server-side Validation
✅ Custom Validation Attributes
✅ Responsive Design with Bootstrap
✅ jQuery
⚙️ Application Configurations
🔗 Connection String
Located in appsettings.json. If you're not using SQLEXPRESS, update Server=.\\SQLEXPRESS; to Server=.
🛠️ Database Migrations
Automatically applied during application startup when ASPNETCORE_ENVIRONMENT is set to Development. For production, apply them manually.
📊 Seeding Sample Data
Test accounts created upon first run:
User: user@user.com / 16051979
Admin: adminZlati@admin.com / 16051979
☁️ Cloudinary Setup (Optional)
Without Cloudinary credentials:
Predefined images will be used when creating content.
To upload images, configure appsettings.json:
json
Copy code
"Cloudinary": {
  "CloudName": "your-cloud-name",
  "ApiKey": "your-api-key",
  "ApiSecret": "your-api-secret"
}
📸 Screenshots
🏟️ Players Overview


⚾ Teams Overview


📜 License
This project is licensed under the MIT License.

🙏 Acknowledgments
Special thanks to:

Nikolay Kostov
Vladislav Karamfilov
Stoyan Shopov
📂 Adding Icons
Tips for adding icons in README.md:
You can use emojis (like above) or integrate small custom icons using HTML tags.

Using Custom Icons Example
markdown
Copy code
<img src="https://img.icons8.com/ios-filled/50/000000/baseball.png" alt="Baseball Icon" width="30" height="30"/> View Players  
For example, you can use free icons from websites like Icons8 or FontAwesome to make your README more visually appealing.

Let me know if you'd like additional help! 😊
