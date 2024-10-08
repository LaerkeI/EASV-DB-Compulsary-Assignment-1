CREATE TABLE Categories (
    Id INT PRIMARY KEY,
    Name VARCHAR(100)
);

ALTER TABLE Products ADD category_id INT;

ALTER TABLE Products ADD CONSTRAINT FK_Product_Category FOREIGN KEY (category_id) REFERENCES Categories(Id);
