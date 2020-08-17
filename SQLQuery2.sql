USE ECommerceData;
CREATE TABLE Products(
ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
ProductId INT NOT NULL,
ProductName varchar(50) NOT NULL,
ProductDescription varchar(100) NOT NULL,
Price money NOT NULL
)
SELECT *from sys.Tables;
INSERT INTO Products(ProductId, ProductName, ProductDescription, Price)VAlUES(1, 'THING','Its a thing good God', 1000.90);
SELECT *from Products;