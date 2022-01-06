# CSDL sử dụng:
```
CREATE DATABASE QLDuocPham
GO
USE QLDuocPham
GO
-- bảng Danh mục thuốc
CREATE TABLE DanhMucThuoc(
MaDM varchar(10) PRIMARY KEY,
TenDM nvarchar(50) )
GO
INSERT INTO DanhMucThuoc VALUES('DM01',N'Thuốc kháng sinh')
INSERT INTO DanhMucThuoc VALUES('DM02',N'Thuốc đặc trị')
INSERT INTO DanhMucThuoc VALUES('DM03',N'Thực phẩm chức năng')
GO
--bảng Thuốc	
CREATE TABLE Thuoc(
MaThuoc varchar(10) PRIMARY KEY,
TenThuoc nvarchar(30),
GiaBan float,
SoLuong int,
MaDM varchar(10) FOREIGN KEY REFERENCES DanhMucThuoc(MaDM))
GO
INSERT INTO Thuoc VALUES('Thuoc01',N'Amoxicillin 500mg',20000,100,'DM01')
INSERT INTO Thuoc VALUES('Thuoc02',N'Molnupiravir 400mg',50000,200,'DM02')
INSERT INTO Thuoc VALUES('Thuoc03',N'Viên khớp Tâm Bình',10000,300,'DM01')
GO

select * from DanhMucThuoc
select * from Thuoc

```
