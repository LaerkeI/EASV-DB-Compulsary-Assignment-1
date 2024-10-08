--ROLLBACK

-- For ProductRatings
DROP TABLE ProductRatings;

-- For Categories and Products
ALTER TABLE Products DROP CONSTRAINT FK_Product_Category;
ALTER TABLE Products DROP COLUMN category_id;
DROP TABLE Categories;

-- For Products
DROP TABLE Products;