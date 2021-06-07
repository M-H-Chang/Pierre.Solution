# Pierre.Solution

## Tech Used
1. C#
2. .NET
3. ASP .NET Core
4. Entity Framework
5. MySQL
6. Razor Templates
7. HTML5/CSS3
8. Identity Framework for Auth(entication/orization)

## Requirements
- C#/.NET
- MySql
- Entity Framework

## Setup Instructions
1. Clone repo in to destinated directory
2. Change directory to Pierre.Solution/Candy
3. Install Dependencies with `dotnet restore`
4. Create file name appsettings.json and enter following: `{ "ConnectionStrings": { "DefaultConnection": "Server=localhost;Port=3306;database=min_chang;uid=[user mysql username];pwd=[user mysql password];" } }`
5. To create the database needed using the migrations tool `dotnet ef database update`
6. To watch for live changes `dotnet watch run` in http://localhost:5000/

### Known Bugs
- None identified

### License
- GPL 3.0 or later

#### Contact Information
- Min Chang: minchangmhc at gmail dot com
