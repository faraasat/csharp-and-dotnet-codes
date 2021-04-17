* We have created this project using MVC Core 3.1 with have set authentication to Individual
* After this we have created 3 class Libraries to divide project: BulkyBook.DataAccess, BulkyBook.Models, BulkyBook.Utility
* After that we move data folder to .DataAccess and remove content of migrations
* After that moved ErrorViewModel.cs from Model folder to .Models in a folder ViewModels which we have created
* Then we will add all refrence by right clicking on main project and clicking add>references
* Then we will add .Model and .Utility refrence in .DataAccess
* Now creae a new area in area folder with name Customer and then change the routes
* Then change the pattern in Startup.cs>endpoints to {area=Customer}{controller=Home}/{action=Index}/{id?}
* Move HomeController to Areas>Customer>Controllers and explicitly mention above HomeController Class [Area("Customer")]
* Move HomeController Views to Areas>Customer>Views
* Since we have moved Views that's why we have to copy paste and change _ViewImports.cshtml and _ViewStart.cshtml
* Change path of _ViewStart.cshtml to Layout = "~/Views/Shared/_Layout.cshtml";
* Now we will create an Admin Area same as Customer and Delete Data and Models folder and add _ViewImports.cshtml and _ViewStart.cshtml also in Views
* Now we will copy the content from bootstrap.css of yeti theme of BootSwatch and paste into wwwroot>lib>bootstrap>dist>css>bootstrap.css
* Now We will replace wwwroot>css>site.css content from https://github.com/bhrugen/BulkyBook/blob/master/BulkyBook/wwwroot/css/site.css
* Now we will change the path in _Layout.cshtml to ~/lib/bootstrap/dist/css/bootstrap.css
* Then we will change Navbar properties in _Layout.cshtml to navbar-dark and bg-primary
* Remove text-dark property from nav-link class in both _Layout and _LoginPartial and change footer to bg-primary and text-white-50
* Now we will add these references to our _Layout.cshtml:
    <link rel="stylesheet" href="https://cdn.datatables.net/1.10.16/css/jquery.dataTables.min.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/css/toastr.min.css" />
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"></script>
    <script src="https://cdn.datatables.net/1.10.16/js/jquery.dataTables.min.js"></script>
    <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/js/toastr.min.js"></script>
    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
    <script src="https://kit.fontawesome.com/e19c476714.js"></script>
* Now we will change some properties in ConnectionString in AppSetting.json 
* First select .DataAccess in DefaultProject in PackageManagerConsole and then we add Migration with name AddDefaultIdentityMigration and update database
* Now add the dropdown with name Content Management bootstrap code in navbar in _Layout.cshtml
* Now we will create a class with name Category.cs in .Models and add it to dbContext so that we can use this to create a table in database
* Then add migration with name AddCategoryToDb and update database
* We will follow repository pattern and we cannot use Save, Update functionality and database symentics in repository
* For these we use Unit of Work and in unit of work there can be several repositories but only one DbContext
* First we will create an interface for repository which contains all method definition and then create a repository
* Now Create folder Repository in .DataAccess and then IRepository folder in Repository and then IRepository class in IRepository Folder
* We have done Category CRUD Using Unit Of Work 
* We have done CoverType CRUD Using Stored Procedure
* In stored procedure we directly run add-migration AddStoredProcForcoverTypes and write our own code in migration file
* Identity is a scaffolded item to reveal it click on BulkyBook right click---> New Scaffolded Item> Identity > Add







