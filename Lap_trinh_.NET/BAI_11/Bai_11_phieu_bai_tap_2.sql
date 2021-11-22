use master
go
create database QLBanHang
go
use QLBanHang
go

create table LoaiSanPham (
	MaLoai char(3) not null primary key,
	TenLoai nvarchar(50) not null,
)
go
create table KhachHang (
	MaKH char(4) not null primary key,
	TenKH nvarchar(50),
	soDT varchar(12),
	DiaChi nvarchar(50),
)
go
create table NguoiDung (
	TenDangNhap varchar(10) not null primary key,
	MatKhau varchar(10) not null,
	HoTen nvarchar(50) not null,
)
go
create table SanPham (
	MaSP char(4) not null primary key,
	TenSP nvarchar(50) not null,
	MaLoai char(3) foreign key references LoaiSanPham(MaLoai) on update cascade on delete cascade,
	SoLuong int,
	DonGia int,
)
go
create table HoaDon (
	MaHD char(4) not null primary key ,
	NgayLap date,
	MaKH char(4) foreign key references KhachHang(MaKH) on update cascade on delete cascade,
	NguoiLap varchar(10),
)
go
create table HoaDonChiTiet (
	MaHD char(4) not null,
	MaSP char(4) not null,
	SoLuongMua int,
	constraint pk_hdct primary key(MaHD, MaSP),
	constraint fk_masp foreign key(MaSP) references SanPham(MaSP) on update cascade on delete cascade,
	constraint fk_mahd foreign key(MaHD) references HoaDon(MaHD) on update cascade on delete cascade
)
go

insert into LoaiSanPham values('L01',N'Loại sản phẩm A')
insert into LoaiSanPham values('L02',N'Loại sản phẩm B')
insert into LoaiSanPham values('L03',N'Loại sản phẩm C')
go
insert into KhachHang values('KH01',N'Trần Văn A','0111111111',N'Địa chỉ A')
insert into KhachHang values('KH02',N'Trần Văn B','0222222222',N'Địa chỉ B')
insert into KhachHang values('KH03',N'Trần Thị C','0333333333',N'Địa chỉ C')
go
insert into NguoiDung values('userA','Abcd@1234',N'Vũ Văn A')
insert into NguoiDung values('userB','Abcd@3231',N'Vũ Văn B')
insert into NguoiDung values('userC','Abcd@5667',N'Vũ Văn C')
go
insert into SanPham values('SP01',N'Sản phẩm A','L01',200,150000)
insert into SanPham values('SP02',N'Sản phẩm B','L02',300,350000)
insert into SanPham values('SP03',N'Sản phẩm C','L03',400,450000)
go
insert into HoaDon values('HD01','02-03-2021','KH01','Nguoi A')
insert into HoaDon values('HD02','12-15-2021','KH02','Nguoi B')
insert into HoaDon values('HD03','06-23-2021','KH03','Nguoi C')
go
insert into HoaDonChiTiet values('HD01','SP01',10)
insert into HoaDonChiTiet values('HD02','SP02',20)
insert into HoaDonChiTiet values('HD03','SP03',30)
go

select * from LoaiSanPham
select * from KhachHang
select * from NguoiDung
select * from SanPham
select * from HoaDon
select * from HoaDonChiTiet
go