CREATE TABLE Products
(
    Id INT NOT NULL PRIMARY KEY,
    Name VARCHAR(50) NULL
);

INSERT INTO Products
VALUES
    (1,'Butter'),
    (2,'Milk'),
    (3,'Soap'),
    (4, 'Cycle');

CREATE TABLE Categories
(
    Id INT NOT NULL PRIMARY KEY,
    Name VARCHAR(50) NULL
);

INSERT INTO Categories
VALUES
    (1,'Food'),
    (2,'Household chemicals'),
    (3,'Liquid');

CREATE TABLE ProductsCategories
(
    Id INT NOT NULL PRIMARY KEY,
    ProductId INT NOT NULL FOREIGN KEY REFERENCES Products(Id),
    CategoryId INT NOT NULL FOREIGN KEY REFERENCES Categories(Id)
);

INSERT INTO ProductsCategories
VALUES
    (1,1,1),
    (2,2,1),
    (3,3,2),
    (4,2,3);

SELECT P."Name", C."Name"
FROM Products P
LEFT JOIN ProductsCategories PC
    ON P.Id = PC.ProductId
LEFT JOIN Categories C
    ON PC.CategoryId = C.Id;