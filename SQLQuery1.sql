Create database CNPM
On Primary(
Name = CNPM_Data,
Filename = 'F:\Học\CNPM.mdf',
Size = 5 MB,
MaxSize = 50 MB,
FileGrowth = 1 MB)
Log On(
Name = CNPM_Log,
Filename = 'F:\Học\CNPM.ldf',
Size = 5 MB,
MaxSize = 20 MB,
FileGrowth = 1 MB);

Use CNPM
Create table SanPham(
MaHang int identity(1,1) primary key not null,
TenHang nvarchar(30),
KhoiLuong int,
Xuatxu nvarchar(20),
DonGia float );
select *from SanPham

Use CNPM
Create table KhachHang(
MaKhach int identity(1,1) primary key not null,
TenKH nvarchar(30),
DiaChi nvarchar(30),
SoDienThoai nvarchar(10),
Tuoi int);


Use CNPM
Create table NhanVien(
MaNV int identity(1,1) primary key not null,
TenNV nvarchar(30),
DiaChi nvarchar(30),
SoDienThoai nvarchar(10),
Tuoi int);

use CNPM
create table DonHang(
MaDonHang int identity(1,1) primary key not null,
MaHang int,
TenHang nvarchar(30),
MaKhach int,
TenKH nvarchar(30),
DonGia float,
);
foreign key (MaHang) references SanPham(MaHang),
foreign key (MaKhach) references KhachHang(MaKhach));
select *From DonHang

drop table DonHang

use CNPM
create table DoanhThu(
ID int identity(1,1) primary key not null,
MaDonHang int,
ThuNhap float);
foreign key (MaDonHang) references DonHang(MaDonHang));
select *from DoanhThu
drop table DoanhThu
insert into DoanhThu values (8,2000)

insert into SanPham
	Values (N'Táo Mỹ',5,N'Bắc Giang',10000)
insert into SanPham
	Values (N'Nho Việt',10,N'Hà Nội',20000)
insert into SanPham
	Values (N'Vải Thiều',4,N'Bắc Giang',50000)



insert into KhachHang
	Values (N'Nguyễn Tiến Huy',N'Bắc Giang',01111111111,21)
insert into KhachHang
	Values (N'Nguyễn Minh Hưng',N'Hà Nội',02222222222,22)
insert into KhachHang
	Values (N'Nguyễn Quốc Hưng',N'Ý',03333333333,23)


insert into NhanVien
	Values (N'Nguyễn Văn A',N'Bắc Giang',0373476342,50)
insert into NhanVien
	Values (N'Nguyễn Văn B',N'Hà Nội',013232323,40)
insert into NhanVien
	Values (N'Nguyễn thị C',N'Trung Quốc',0565656565,30)






