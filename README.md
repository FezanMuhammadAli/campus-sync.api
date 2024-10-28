# Campus Sync API

## Project Overview
Campus Sync is an API project developed as part of our Final Year Project. The goal of this project is to provide a seamless platform for managing campus activities and services.

## Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) installed
- A SQL Server instance set up and running

## Setting Up User Secrets for Database Connection

To avoid hardcoding sensitive information, we will use user secrets to manage the database connection string.

### Step 1: Initialize User Secrets
In your project directory, run the following command to initialize user secrets:
```bash
dotnet user-secrets init
```

### Step 2: Set the Connection String
Set the connection string using the following command, replacing `{SERVER_NAME}` with your actual SQL Server instance name:
```bash
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Data Source={SERVER_NAME};Initial Catalog=CampusSync.APi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
```

### Step 3: Configure `appsettings.json`
Ensure that your `appsettings.json` file contains the connection string key with an empty value:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": ""
  }
}
```

### Step 4: Access the Connection String in Code
In your `Startup.cs` or `Program.cs`, add the following code to fetch the connection string from user secrets:
```csharp

builder.Services.AddDbContext<CampusSyncDbContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
```

## Collaboration
This is a private repository. To collaborate, ensure you have access to the repository. Each developer can set their own connection strings using user secrets, allowing for a seamless development experience.

## Conclusion
By following these steps, each developer can configure their local environment without conflicts, enabling a smoother collaborative experience. Happy coding!

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.
```
