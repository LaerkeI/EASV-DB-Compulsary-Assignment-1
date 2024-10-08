# EASV-DB-Compulsary-Assignment-1

Part 1 Task 4: Merge and Conflict Resolution:
When merging manual/initial-schema, manual/add-categories and manual/add-ratings into main-manual, there were no merge conflicts at all.

Part 1 Task 5: Rollback Plan:
- For rolling back the changes from the manual/add-ratings merge, you can use this script to drop the ProductRatings table: 
    DROP TABLE ProductRatings;
- For rolling back the changes from the manual/add-categories merge, you can use this script that drops the foreign key constraint to the categories table, drops the category_id from the products table and then       lastly drops the Categories table:
    ALTER TABLE Products DROP CONSTRAINT FK_Product_Category;
    ALTER TABLE Products DROP COLUMN category_id;
    DROP TABLE Categories;
- For rolling back the changes from the manual/initial-schema merge, you can use this script to drop the Products table:
    DROP TABLE Products;
