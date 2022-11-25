2022-10-24
1154 Created Project (MVC using Core 3.1, Indivudual account authentication, razor runtime enabled)
1156 Commented out ssl port for lab
1157 Created this readme
1158 Tested app, everything working as expected
1205 Created git repository and pushed to github
1325 Disabled setting in Startup.cs that required email confirmed accounts
1328 Populated database with identity tables, using command "Update-Database -Context ApplicationDbContext"




2022-10-31
1148 Updated project name in nav bar
1338 Updated footer to change copyright date every year
1240 Replaced bootstrap.css and changed reference in _Layout.cshtml
1243 Replaced site.css
1247 Removed background colour and box shadow classes from navbar
1251 Turned _LoginPartial links into buttons using bootstrap
1254 Tested app, bootswatch theme applied as expected

1323 Updated _Layout to add various 3rd party tools and scripts
1330 Added Content management dropdown in navbar on _Layout page
1334 Created DataAccess library and moved data folder into new project directory
1339 Added EF Core Relational and EF Core SqlServer NuGet Packages
1340 Deleted migrations folder
1347 Built project, got errors, dont have time to fix - "NU1605  Detected package downgrade. Reference the package directly from the project to select a different version."
				Packages affected are - Microsoft.AspNetCore.Identity.EntityFrameworkCore	(AlexBookstore)
									  - Microsoft.EntityFrameworkCore.SqlServer	(AlexBookstore)



2022-11-02
1230 Tried rebuilding project, didnt solve errors
1236 Tried updating packages in AlexBookstore
1244 Tried uninstalling problem packages and reinstalling, still nothing, uninstalling and leaving it out for now, possibly forever
1301 Moved models folder to models project and renamed it ViewModels, deleted original
1304 Added project references for .DataAccess and .Models in AlexBookstore
1309 Edited references to ErrorViewModel

1505 Tested app, runs and presentation is correct
1559 Added static details class in utility project
1600 Added utility project reference to main project
1601 Added .Models and .Utility references to .DataAccess project
1611 Scaffolded Customers area
1629 Changed routes in startup cs to use areas in patterns
1630 Moved HomeController to customer area and deleted Customer Data and Model directories
1632 Moved "Home" views to customer views folder
1648 Edited namespace of HomeController and defined that it is in Customer area
1735 ***ERROR 404: Getting 404 error when testing app
1740 Issue solved, forgot to specify default area in Startup.cs
1742 Coppied _ViewImports and _ViewStart to customer area, tested app, bootstrap is working again
1748 Added links to dropdown in nav, just noticed privacy link isn't working
1817 Solved, forgot to comment out old endpoint route in startup.cs
1820 Commiting code and pushing to github



============
   Part 2
============
2022-11-07
1157 Got to class pulled repo beginning work on part 2 of assignment
1215 Tested app, working, no errors
1220 Ran "Add-Migration IdentityInitialCreate" got: target project (AlexBookstore) doesn't match your migrations assembly (AlexsBooks.DataAccess)
1221 Ran command again after chaning project in dropdown menu, migration created		 **********(20221107172245_IdentityInitialCreate.cs)
1225 Modified name of database in appsettings.json
1228 Created AlexsBookStoreDB by running Update-Database
1231 Tested app, working, no errors
1237 Added Category to ApplicationDbContext
1238 Updated namespace of Category model
1243 Updated visibility of Category class so it can be accessed by ApplicationDbContext
1244 Created migration AddCategoryToDb			 *********(20221107174427_AddCategoryToDb.cs)
1245 Updated the database, Categories table added
1247 Tested app, working, no errors
1248 Commiting code and pushing to github



2022-11-13
2030 Pulled repo and continuing work on part two of assignment
2033 Tested app, working no errors
2049 Created repository class and interface
2050 Committed code
2104 Created CategoryRepository and interface
2105 Built solution, no errors
2106 Committed code
2204 Created SP_Call class and interface
2228 Created UnitOfWork class and interface
2253 Built and tested app, working
2254 Committed code
2301 Added CategoryController to Admin Area
2308 Getting Error: ICategoryRepository does not contain a definition for GetAll, must be a problem with implementation
2312 Solved, forgot to implement IRepository in ICategoryRepository
2317 Created index view in Admin area
2319 Tested app, working, no errors
2325 Added category link to dropdown menu
2326 Committed code and pushed to github
2336 Added icons and javascript to category index

2022-11-14
1050 Added Upsert action in CategoryController
1102 Created Upsert view and partials
1105 Tested app, working
1106 Added section call with validation scripts partial
1121 Added api calls for save and delete
1122 Next is implement httpdelete with a delete method in category.js

============
   Part 3
============
*** Section 1 ***
2022-11-24
1700 Pulled repo, beginning work on part 3 section 1
1705 Created covertype class
1711 Updated namespaces of CoverType and Category class from Repository to Repository.IRepository
1925 Created CoverTypeRepository, added same update method from category repository
1930 Generated interface from CoverTypeRepository
1944 Trying to add CoverType to UnitOfWork class and interface, getting CS0266 error, Cannot implicitly convert type CoverTypeRepo to ICovertypeRepo, also applying to category
1953 Problem solved, forgot to finish updating namespaces. Each class couldnt use its interface as they were in a different namespace