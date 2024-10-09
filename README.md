# EASV-DB-Compulsary-Assignment-1
Please view the README in raw/code format.

# Instructions for setting up the project.
The project is implemented in .NET 7 and you need these three package for .NET 7: 
- dotnet add package Microsoft.EntityFrameworkCore --version 7.0.0
- dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 7.0.0
- dotnet add package Microsoft.EntityFrameworkCore.Tools --version 7.0.0

Make sure you have a database in SSMS named EASV-DB-Compulsary-Assignment-1 that can be accessed with the connection string in ApplicationContext.cs
or changes the connection string to fit your own database. 

The SQL scripts can be found in root/migrations. 
Download or copy the scripts and execute them in your database.

# Documentation for the manual migrations.
Create a table for each class (Product, Category and ProductRating) in the Entities folder by executing the SQL command: 
- CREATE TABLE <table-name> (
    ...
  );
Each property in the class should be a column in the table.

If an Entity class has a navigation property to another Entity class and a property named after the identifier (primary key) of the other Entity class,
there should be a foreign key to the other Entity class in the database. Foreign keys and navigation properties work together to establish relationships between entities.

E.g. in ProductRating.cs the property "Product Product" is a navigation property to Product and the property named "ProductId" is named afther the identifier of Product.cs. 

By adding this SQL code when you create the ProductRating table, you can create the foreign key:
- ProductId INT,
- FOREIGN KEY (ProductId) REFERENCES Products(Id)

How "Part 1 Task 4: Merge and Conflict Resolution" was solved:
When merging manual/initial-schema, manual/add-categories and manual/add-ratings into main-manual, there were no merge conflicts at all.

# Rollback instructions for manual migrations.
Part 1 Task 5: Rollback Plan:
- For rolling back the changes from the manual/add-ratings merge, you can use this script to drop the ProductRatings table: 
    DROP TABLE ProductRatings;
- For rolling back the changes from the manual/add-categories merge, you can use this script that drops the foreign key constraint to the categories table,
  drops the category_id from the products table and then lastly drops the Categories table:
    ALTER TABLE Products DROP CONSTRAINT FK_Product_Category;
    ALTER TABLE Products DROP COLUMN category_id;
    DROP TABLE Categories;
- For rolling back the changes from the manual/initial-schema merge, you can use this script to drop the Products table:
    DROP TABLE Products;
