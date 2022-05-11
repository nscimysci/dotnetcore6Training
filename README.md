
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

# Step 6 : 