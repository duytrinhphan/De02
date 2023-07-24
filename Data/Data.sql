CREATE DATABASE QLSanpham
GO

USE QLSanPham
GO

CREATE TABLE LoaiSP
(
	MaLoai char(2) primary key,
	TenLoai nvarchar(30)
)

create table Sanpham
(
	MaSP char(6) primary key,
	TenSP nvarchar(30),
	Ngaynhap datetime, 
	MaLoai char(2),
	constraint pk_MaLoai foreign key(MaLoai) references LoaiSP(MaLoai)
)