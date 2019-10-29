

Dotnet Project Structure Rebuild 
```
dotnet new sln
dotnet new blazorwasm --name DeviceClientWebApplication
dotnet sln add .\DeviceClientWebApplication\DeviceClientWebApplication.csproj
dotnet new classlib --framework netcoreapp3.1 --name DeviceManagementClassLibrary
dotnet sln add .\DeviceManagementClassLibrary\DeviceManagementClassLibrary.csproj

dotnet build 
dotnet add .\DeviceTesting\DeviceTesting.csproj reference .\DeviceManagementClassLibrary\DeviceManagementClassLibrary.csproj
dotnet test .\DeviceTesting\DeviceTesting.csproj
dotnet test 
```