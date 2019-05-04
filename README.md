# demomvc

Controllers/StudentsController.cs 

Models/MvcContext.cs 

Models/Student.cs 

Startup.cs 

Views/Shared/_Layout.cshtml 

   Views/Students/Create.cshtml 
   
   Views/Students/Index.cshtml 
  
demomvc.csproj 
	
dotnet add package MySql.Data.EntityFrameworkCore -v 6.10.8

dotnet ef migrations add Initial
dotnet ef database update

dotnet restore
dotnet build
dotnet run
