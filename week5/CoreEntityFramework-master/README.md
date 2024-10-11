# Core Entity Framework
This sample project contains features for Entity Framework Core Code First Migrations. 

## These are the key dependencies:
- Microsoft.EntityFrameWorkCore
- Microsoft.EntityFrameWorkCore.Tools
- Microsoft.EntityFrameWorkCore.SqlServer

## Running the Project
1. View > Sql Server Object Explorer
2. (localdb)\MSSQLLocalDB
- No Database, Option 1: Tools > Get Tools and Features > Data Storage and Processing > Sql Server Data Tools
- No Database, Option 2: [You can also use a tool like SQL Server Management Studio](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16).
3. Create New Database
4. Right Click Database > Properties > Connection String
5. Use template in AppSettings.json, Program.cs
6. Tools > NuGet Package Manager > Package Manager Console
7. update-database
8. Enter records for products
9. localhost:xx/swagger/index.html
10. Try It Out on GET api/product

## Index of Examples
1. [Core Entity Framework](https://github.com/christinebittle/CoreEntityFramework)
2. [Core API](https://github.com/christinebittle/CoreAPI)
3. [Core Services](https://github.com/christinebittle/CoreServices)
4. [MVC & ViewModels](https://github.com/christinebittle/OnlineStore)
5. [Simple Authentication](https://github.com/christinebittle/OnlineStore/tree/Authentication1)

## Test your understanding!
- Modify Product.cs to include ProductPrice (decimal)
- Tools > NuGet Package Manager > Package Manager Console > add-migration productprice
- Update the database with the new product price migration, creating the price column on the product table
- Add a new entity /Models/Review.cs
- Register 'Reviews' in AppDbContext.cs
- Add a migration 'review'
- Update the database with the review migration, creating a reviews table
- Link Customers and Reviews (One customer may write many reviews, each review for one customer)
- Add-Migration 'customer-reviews'
- Update the database with the customer reviews migration, creating a customer ID FK on the review table
- Create a migration which links the review to the product as well (one product has many reviews, each review for one product)
- Modify Review.cs to have 'Stars' as an integer
- add-migration 'stars'
- update database customer reviews to go back to customer reviews migration
- remove-migration
- update database
- change Review.cs Stars to a float
- add-migration
- update-database
