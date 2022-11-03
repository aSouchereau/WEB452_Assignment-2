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