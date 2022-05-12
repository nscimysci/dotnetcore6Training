
# Install dotnetcore
https://dotnet.microsoft.com/en-us/download/dotnet/6.0

dotnet --version

# Setting Env For Mac
1 Command + shift + P
2 shell
3 select Shell Command: Install code
4
- install vscode extensions;
  code --install-extension vscode-icons-team.vscode-icons
  code --install-extension esbenp.prettier-vscode
  code --install-extension ms-dotnettools.csharp
  code --install-extension matijarmk.dotnet-core-commands
  code --install-extension eamodio.gitlens
  code --install-extension esbenp.prettier-vscode
  code --install-extension bierner.color-info

5 sudo dotnet dev-certs https --trust
# Step 1 : Create a web project

dotnet new webapi -o training.gulf.services
cd training.gulf.services
dotnet add package Microsoft.EntityFrameworkCore.InMemory
code -r ../training.gulf.services
===================================
# Step 2 : dotnet dev-certs https --trust

dotnet dev-certs https --trust
===================================
# Step 3 : Run the app

1 Press Ctrl+F5
2 choose .NET Core.
3 Replace <insert-target-framework-here>, with net6.0.
4 Replace <insert-project-name-here> with training.gulf.services.dll.
5 Result :  "program": "${workspaceFolder}/bin/Debug/net6.0/training.gulf.services.dll",
6 Press Ctrl+F5
7 select Configure Task.
8 Create tasks.json
9 Select the .NET Core
10 Press Ctrl+F5.
11 https://localhost:<port>/swagger
===================================
# Step 4 : New Controllers And Route
 [HttpGet("GetProduct")]

# Step 5 : Swager program.cs
builder.Services.AddSwaggerGen(c =>
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo{Title = "CodeMobiles .NET 6 Demo", Version="v2"})
);

# Step 6 : Run Start swagger

            "serverReadyAction": {
                "action": "openExternally",
                "pattern": "\\bNow listening on:\\s+(https?://\\S+)",
                "uriFormat": "%s/swagger"
            },
            "env": {
                "ASPNETCORE_ENVIRONMENT": "Development"
            },
            "sourceFileMap": {
                "/Views": "${workspaceFolder}/Views"
            }


# Step 7 : sln SOLUTION_FILE
dotnet new classlib -o demo.gulf.repositories
dotnet new classlib -o demo.gulf.business
dotnet new classlib -o demo.gulf.model

dotnet new sln -n demo
dotnet sln demo.sln add demo.gulf.services/demo.gulf.services.csproj
dotnet sln demo.sln add demo.gulf.repositories/demo.gulf.repositories.csproj
dotnet sln demo.sln add demo.gulf.business/demo.gulf.business.csproj
dotnet sln demo.sln add demo.gulf.model/demo.gulf.model.csproj

dotnet add demo.gulf.business reference demo.gulf.repositories/demo.gulf.repositories.csproj
dotnet add demo.gulf.business reference demo.gulf.model/demo.gulf.model.csproj
dotnet add demo.gulf.repositories reference demo.gulf.model/demo.gulf.model.csproj

dotnet add demo.gulf.services reference demo.gulf.model/demo.gulf.model.csproj
dotnet add demo.gulf.services reference demo.gulf.business/demo.gulf.business.csproj
dotnet add demo.gulf.services reference demo.gulf.repositories/demo.gulf.repositories.csproj

# Step 8 : EntityFramworkCore demo.gulf.repositories

dotnet add package Microsoft.EntityFrameworkCore --version 6.0.5
dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0.5
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 6.0.5
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 6.0.5


dotnet ef dbcontext scaffold "Server=;Persist Security Info=False;User ID=;Password=; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30; Database=; " Microsoft.EntityFrameworkCore.SqlServer -o entities --force