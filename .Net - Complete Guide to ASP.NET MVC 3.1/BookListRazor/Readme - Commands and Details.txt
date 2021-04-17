We have selected ASP.NET Core 3.1 Razor Page Application for this project
* In this we have first installed a NuGet package "Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation" so that we can refresh our code while it is running
* After installing package we configure "services.AddRazorPages().AddRazorRuntimeCompilation()" in Configuration method of startup.cs
* Ater creating our model we will install "Microsoft.EntityFrameworkCore", "Microsoft.EntityFrameworkCore.sqlserver", "Microsoft.EntityFrameworkCore.tools"
* Now we will setup connection string in appsetting.json above Logging as:
"ConnectionStrings": {
    // We can also give any other name to DefaultConnection
    "DefaultConnection": "Server=LAP-D;Database=BookListRazor;Trusted_Connection=True;MultipleActiveResultSets=True"
},
* Then we configure our Database in Startup.cs but before that we will add a class DbContext in Model with our choosing name "ApplicationDbContext" and inherit it from DbContext
* After that we will configure it in Startup.cs:
services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
* Then we will go to nugrt console to Add Migrations
    >  add-migration <AnyName>
    >  update-database
* Then we create empty razor pages in View>Books 
* To work with controller we have to write services.AddControllersWithViews(); in Configuration and
endpoints.MapControllers(); in app.UseEndpoints()


