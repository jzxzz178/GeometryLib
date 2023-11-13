CREATE TABLE Products
(
    Id     INT PRIMARY KEY,
    "Name" TEXT
);

INSERT INTO Products
VALUES (1, 'Guitar'),
       (2, 'Thunderbook 4'),
       (3, 'Sprats'),
       (4, 'T-shirt');

CREATE TABLE Categories
(
    Id     INT PRIMARY KEY,
    "Name" TEXT
);

INSERT INTO Categories
VALUES (1, 'Food'),
       (2, 'Musical instrument'),
       (3, 'Laptop');

CREATE TABLE ProductCategoriesСonnections
(
    ProductId  INT FOREIGN KEY REFERENCES Products(Id),
    CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
    PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductCategoriesСonnections
VALUES (1, 2),
       (1, 3),
       (3, 1);

SELECT P."Name", C."Name"
FROM Products AS P
         LEFT JOIN ProductCategoriesСonnections AS PC
                   ON P.Id = PC.ProductId
         LEFT JOIN Categories AS C
                   ON PC.CategoryId = C.Id;