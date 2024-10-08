CREATE TABLE ProductRatings (
    Id INT PRIMARY KEY,
    ProductId INT,
    Rating DECIMAL(3, 2),
    FOREIGN KEY (ProductId) REFERENCES Products(Id)
);