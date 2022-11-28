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

1205 Got to class, pulled repo, and updated database
1225 Added delete method and delete button functionality in category.js
1228 Getting invalid regex error "Flag c"
1234 Issue solved, caused by quotation marks in wrong position on the delete button
1236 Tested app, able to create and delete categories, cannot edit

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
2004 Created migration for the new CoverType table, and updated the database

2022-11-25
0030 Fixed merge conflict involving the readme, category controller, and category.js script
0041 Created Product class
0050 Added Product to Application DbContext
0105 Created migration for product table ***************20221125060355_AddProductsToDb.cs
0106 Updated the database
0110 Added additional validation to the product class
0111 Created migration for updated product class
0112 Updated the database
0115 Created product repository and added update method
0116 Created product repository interface
0120 Added product to UnitOfWork and its interface
0122 Tested app, error, forgot to specify type of repository in the ProductRepository class implementations
0125 Tested app again, no errors this time
0126 Pushing code to github

*** Section 2 ***
1004 Created product controller
1006 Created Product View Model
1008 Installed package: Microsoft.AspNetCore.Mvc.ViewFeatures
1020 Added upsert methods to Product Controller
1025 Created product index view
1028 Created product.js and referenced in in product index
1030 Added product link to nav bar dropdown
1034 Tested app, working as expected. Exception when loading product list page, caused by Upsert view not found, which we haven't created yet.
1035 Committing code and pushing to github

*** Section 3 ***
1300 Pulled repo, beginning work on part 3 section 3
1308 Created Product upsert view, added tiny cloud api key and script
1312 Uncommented Upsert post method and removed save method call from conditional statement that adds a product
1316 Tested app, product upsert page loads, text box works, still getting "Navigation not found exception"
1319 Going to use provided completed assignmennt example to find whats causing the exception

============
   Part 4
============
1330 Added validation to covertype model
1331 Added migration for covertype validation and updated the database
1333 Found potential solution to problem, in Product.cs the foreign key reference for CoverType was set to Category, meaning [ForeignKey("CategoryID")] was written twice
1336 Added migration to fix foreign key error
1340 Updated database, got ALTER TABLE statement conflicted with the FOREIGN KEY constraint
1344 Solved by deleting test data from created tables
1345 Tested app, foreign key update didn't fix exception

1548 Updated product controller Upsert post method to match example
1550 Tested app, still getting same exception, also, product upsert view displays list of categories instead of covertype