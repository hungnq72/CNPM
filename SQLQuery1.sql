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
MaHang char(20) not null primary key,
TenHang nvarchar(30),
KhoiLuong int,
Xuatxu nvarchar(20),
DonGia float );


Use CNPM
Create table KhachHang(
TenKH nvarchar(30)not null primary key,
DiaChi nvarchar(30),
SoDienThoai nvarchar(10),
Tuoi int);


Use CNPM
Create table NhanVien(
TenNV nvarchar(30)not null primary key,
DiaChi nvarchar(30),
SoDienThoai nvarchar(10),
Tuoi int);

insert into SanPham
	Values ('0001',N'Táo Mỹ',5,N'Bắc Giang',10000)
insert into SanPham
	Values ('0002',N'Nho Việt',10,N'Hà Nội',20000)
insert into SanPham
	Values ('0003',N'Vải Thiều',4,N'Bắc Giang',50000)



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


--	Tạo login
sp_addlogin 'Huy','123'
sp_addlogin 'MinhHung','1234'
sp_addlogin 'QuocHung','12345'




