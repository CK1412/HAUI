## CSDL QLBanHang:
```
CREATE DATABASE QLBanHang
GO
USE QLBanHang
GO
CREATE TABLE LoaiSP(
MaLoai char(3) PRIMARY KEY,
TenLoai nvarchar(20) )
GO
INSERT INTO LoaiSP VALUES('L01',N'Điện lạnh')
INSERT INTO LoaiSP VALUES('L02',N'Điện tử')
INSERT INTO LoaiSP VALUES('L03',N'Gia dụng')
GO
CREATE TABLE SanPham
(
MaSP char(3) PRIMARY KEY,
TenSP nvarchar(30),
DonGia int,
SoLuongCo int,
MaLoai char(3) FOREIGN KEY REFERENCES LoaiSP(MaLoai))
GO
INSERT INTO SanPham VALUES('S01',N'Tủ lạnh',2000,100,'L01')
INSERT INTO SanPham VALUES('S02',N'Điều hòa',3000,200,'L01')
INSERT INTO SanPham VALUES('S03',N'Ti vi',1000,300,'L02')
GO
CREATE TABLE HoaDonChiTiet
(MaHD char(3),
MaSP char(3) FOREIGN KEY REFERENCES SanPham(MaSP),
NgayBan date,
SoLuongMua int,
PRIMARY KEY(MaHD,MaSP),
)
GO
INSERT INTO HoaDonChiTiet VALUES('H01','S01','2021/09/20',10)
INSERT INTO HoaDonChiTiet VALUES('H01','S02','2021/09/20',20)
INSERT INTO HoaDonChiTiet VALUES('H02','S01','2021/09/20',30)
INSERT INTO HoaDonChiTiet VALUES('H03','S02','2021/09/20',40)


SELECT * FROM LoaiSP
SELECT * FROM SanPham
SELECT * FROM HoaDonChiTiet
```
## Tạo và cập nhật model
### 1. Tạo model từ database
  `Scaffold-Dbcontext "Data Source=COOL-KID\SQLEXPRESS;Initial Catalog=QLBanHang;Integrated Security=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir model`
### 2. cập nhật model khi database thay đổi
  `Scaffold-Dbcontext "Data Source=COOL-KID\SQLEXPRESS;Initial Catalog=QLBanHang;Integrated Security=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir models -Force`
