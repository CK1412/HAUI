## CSDL sử dụng:
```
CREATE DATABASE SALESMANAGEMENT
GO
USE SALESMANAGEMENT
GO
-- Category table
CREATE TABLE Category(
CatID varchar(10) PRIMARY KEY,
CatName nvarchar(50) )
GO
INSERT INTO Category VALUES('CAT01',N'Laptop')
INSERT INTO Category VALUES('CAT02',N'Smart phone')
INSERT INTO Category VALUES('CAT03',N'Laptop accesories')
GO
--Product table
CREATE TABLE Product(
ProductID varchar(10) PRIMARY KEY,
ProductName nvarchar(30),
UnitPrice int,
Quantity int,
CatID varchar(10) FOREIGN KEY REFERENCES Category(CatID))
GO
INSERT INTO Product VALUES('Prod01',N'Sony Vaio SX14',1200,100,'CAT01')
INSERT INTO Product VALUES('Prod02',N'Samsung Galaxy S10',900,200,'CAT02')
INSERT INTO Product VALUES('Prod03',N'Dell 15 inch adapter',40,300,'CAT01')
GO

select * from Category
select * from Product

\\ này tạo thêm

CREATE TABLE Supplier(
ID varchar(10) PRIMARY KEY,
Name nvarchar(50),
Telephone nchar(10),
)
GO
```
