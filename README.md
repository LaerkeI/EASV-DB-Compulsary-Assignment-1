# EASV-DB-Compulsary-Assignment-1

Part 2 Task 4: Merge and Conflict Resolution: When merging ef/initial-setup, ef/add-categories and ef/add-ratings into main-ef, there were several merge conflicts. They were handle by merging the branches in order of creation and accepting the changes from the branch merging into main-ef, as each branch just extends the previous code.

Part 2 Task 5: Rollback Plan: If you want to rollback the last migration, you can use the automatically generated Down() method by specifying the previous migration.
- For rolling back the changes from the ef/add-ratings merge, you run this command to drop the ProductRatings table: 
    dotnet ef database update AddCategories
- For rolling back the changes from the ef/add-categories merge, you run this command that drops the foreign key constraint to the categories table, drops the category_id from the products table and drops the         Categories table:
    dotnet ef database update InitialSchema
- For rolling back all migrations (undo all schema changes and reset the database), you run this command:
    dotnet ef database update 0
- There will however be errors if you have migrations where e.g. the same table is created as in InitialSchema and AddCategories. Then you would either:
  - Create an SQL script that deletes what you want to be deleted.
  - Make sure you don't have any redundant code in your migration schemas to begin with. 
  - Rollback all migrations and run the specific schemas you want in the database.
