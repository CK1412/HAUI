# CSDL sử dụng:
```
use master
go
if DB_ID('QLNhanvien') is not null
	drop database QLNhanvien
go
create database QLNhanvien
go
use QLNhanvien
go
create table PhongBan(
MaPhong nvarchar(2) primary key,
TenPhong nvarchar(25)
)
go

insert into PhongBan values('DT','Dao tao')
insert into PhongBan values('HC','Hanh chinh')
insert into PhongBan values('TH','Tong hop')
go
 
create table Nhanvien(
MaNV varchar(4) primary key,
Hoten nvarchar(30), 
Luong int,
Thuong int,
MaPhong nvarchar(2) foreign key references PhongBan(MaPhong))
go

insert into Nhanvien values('nv01','Long An',5000,200,'HC')
insert into Nhanvien values('nv02','Hai Long',7000,300,'DT')
insert into Nhanvien values('nv03','Van Tung',6000,300,'HC')
insert into Nhanvien values('nv04','Hong Yen',5000,150,'TH')
 
select * from Nhanvien
select * from PhongBan

```
