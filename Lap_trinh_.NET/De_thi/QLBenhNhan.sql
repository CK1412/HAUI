CREATE DATABASE [QLBenhNhan]
GO
USE [QLBenhNhan]
GO
--Tạo bảng KhoaKham
CREATE TABLE [dbo].[KhoaKham](
[Makhoa] [nchar](10) NOT NULL PRIMARY KEY,
[Tenkhoa] [nvarchar](50) NULL)
GO
--Tạo bảng BenhNhan
CREATE TABLE [dbo].[BenhNhan](
[Mabn] [nchar](10) NOT NULL PRIMARY KEY,
[Hoten] [nvarchar](50) NULL,
[Diachi] [nvarchar](100) NULL,
[SongayNV] [int] NULL,
[Makhoa] [nchar](10) NULL)
GO
--Tạo các khóa ngoài
ALTER TABLE [dbo].[BenhNhan] WITH CHECK ADD CONSTRAINT [FK_BenhNhan_KhoaKham]
FOREIGN KEY([Makhoa])
REFERENCES [dbo].[KhoaKham] ([Makhoa])
GO
--Chèn dữ liệu cho bảng KhoaKham
Insert into KhoaKham(Makhoa,Tenkhoa) values('A01',N'Khoa nội')
Insert into KhoaKham(Makhoa,Tenkhoa) values('A02',N'khoa ngoại')
--Chèn dữ liệu cho bảng BenhNhan
Insert into BenhNhan(Mabn,Hoten,Diachi,SongayNV,Makhoa) values('01',N'Lê Thị Hà',N'Hà Nội',26,'A01')
Insert into BenhNhan(Mabn,Hoten,Diachi,SongayNV,Makhoa) values('02',N'Trần Minh Đại',N'Hải Phòng',18,'A01')
Insert into BenhNhan(Mabn,Hoten,Diachi,SongayNV,Makhoa) values('03',N'Đỗ Thị Vân',N'Thái Bình',28,'A02')
Insert into BenhNhan(Mabn,Hoten,Diachi,SongayNV,Makhoa) values('04',N'Ngô Văn Hà',N'Vĩnh Phúc',16,'A02')

Create table BacSy(
	MaBS nchar(10) not null primary key,
	HoTen nvarchar(50) null,
	SoDT nchar(10) null,
)

select * from KhoaKham
select * from BenhNhan
