# EASV-DB-Compulsary-Assignment-1
Please view the README in raw/code format.  

# Instructions for setting up the project.
The project is implemented in .NET 7 and you need these three package for .NET 7: 
- dotnet add package Microsoft.EntityFrameworkCore --version 7.0.0
- dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 7.0.0
- dotnet add package Microsoft.EntityFrameworkCore.Tools --version 7.0.0

Make sure you have a database in SSMS named EASV-DB-Compulsary-Assignment-1 that can be accessed with the connection string in ApplicationContext.cs
or changes the connection string to fit your own database. 

If you want to view the migrations in the database one-by-one, run this command: 

- dotnet ef migrations add <name-of-schema-you-want-to-apply>

And then follow with this command to drop the changes again:

- dotnet ef database update 0
  
Repeat this until you have viewed all the schemas in the database.

If you want the up-to-date migrations, run this command: 

- dotnet ef migrations add AddProductRatings

# Documentation for the EF Core migrations.
Before you create migrations, you need to define your data model which is made up of DbContext.cs (or a class that inherites DbContext.cs) and Entities. 
Each DbSet<TEntity> properties in ApplicationContext.cs represent tables in the database.

After defining the data model, you can create a migration based on your current model by running this command:
- dotnet ef migrations add <MigrationName>

Once the migration is created, you need to apply it to the database by running this command: 
- dotnet ef database update

How "Part 2 Task 4: Merge and Conflict Resolution" was solved: When merging ef/initial-setup, ef/add-categories and ef/add-ratings into main-ef, there were several merge conflicts. 
They were handle by merging the branches in order of creation and accepting the changes from the branch merging into main-ef, as each branch just extends the previous code.)

# Rollback instructions for EF Core migrations.
Part 2 Task 5: Rollback Plan: If you want to rollback the last migration, you can use the automatically generated Down() method by specifying the previous migration.
- For rolling back the changes from the ef/add-ratings merge, you run this command to drop the ProductRatings table:
  
    dotnet ef database update AddCategories
  
- For rolling back the changes from the ef/add-categories merge, you run this command that drops the foreign key constraint to the categories table,
  drops the category_id from the products table and drops the Categories table:
  
    dotnet ef database update InitialSchema
  
- For rolling back all migrations (undo all schema changes and reset the database), you run this command:
  
    dotnet ef database update 0
  
- There will however be errors if you have migrations where e.g. the same table is created as in InitialSchema and AddCategories. Then you would either:
  - Create an SQL script that deletes what you want to be deleted.
  - Make sure you don't have any redundant code in your migration schemas to begin with. 
  - Rollback all migrations and run the specific schemas you want in the database.
