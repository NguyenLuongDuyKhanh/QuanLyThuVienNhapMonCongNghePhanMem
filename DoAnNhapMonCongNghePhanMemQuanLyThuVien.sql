﻿CREATE DATABASE DoAnNhapMonCongNghePhanMemQuanLyThuVien
Go

USE DoAnNhapMonCongNghePhanMemQuanLyThuVien
Go

--drop database DoAnNhapMonCongNghePhanMemQuanLyThuVien

create table TheLoaiSach
(
	ID_TheLoaiSach			int identity(1,1) primary key,
	Ten_TheLoaiSach			nvarchar(10),
	TrangThai_TheLoaiSach	nvarchar(100)
)

create table NhaXuatBan
(
	ID_NXB					int identity(1,1) primary key,
	Ten_NXB					nvarchar(100),
	TrangThai_NXB			nvarchar(100),
)

create table TacGia
(
	ID_TacGia				int identity(1,1) primary key,
	Ten_TacGia				nvarchar(100),
	DiaChi_TacGia			nvarchar(100),
	SDT_TacGia				nvarchar(11),
	TrangThai_TacGia		nvarchar(100),
)

create table Sach
(
	ID_Sach					int identity(1,1) primary key,
	ID_TheLoaiSach			int,
	ID_TacGia				int,
	ID_NXB					int,
	Ten_Sach				nvarchar(100),
	Gia						decimal,
	Sl_Nhap					int,
	MoTa					nvarchar(500),
	NamXuatBan				varchar(10),
	NgayNhap				datetime,
	TrangThai_Sach			nvarchar(100),
	TrangThai_MuonSach		nvarchar(100),
	foreign key (ID_TheLoaiSach) references TheLoaiSach(ID_TheLoaiSach) on update cascade,
	foreign key (ID_TacGia) references TacGia(ID_TacGia) on update cascade,
	foreign key (ID_NXB) references NhaXuatBan(ID_NXB) on update cascade
)

create table LoaiDocGia
(
	ID_LoaiDocGia			int identity(1,1) primary key,
	Ten_LoaiDocGia			nvarchar(100),
	GhiChu_LoaiDocGia		nvarchar(100),
	TrangThai_LoaiDocGia	nvarchar(100),
)

create table TheDocGia
(
	ID_TheDocGia			int identity(1,1) primary key,
	ID_LoaiDocGia			int,
	HoTen_DocGia			nvarchar(100),
	NgaySinh_DocGia			datetime,
	DiaChi_DocGia			nvarchar(100),
	Email_DocGia			nvarchar(100),
	NgayLapThe				datetime,
	NgayHetHan				datetime,
	TrangThai_TheDocGia		nvarchar(100),
	foreign key (ID_LoaiDocGia) references LoaiDocGia(ID_LoaiDocGia) on update cascade
)

create table PhieuMuonSach
(
	ID_PhieuMuonSach		int identity(1,1) primary key,
	ID_TheDocGia			int,
	ID_Sach					int,
	Ten_NguoiMuon			nvarchar(100),
	NgayMuon				datetime,
	NgayHenTra				datetime,
	Sl_SachMuon				int,
	GhiChu					nvarchar(100),
	TrangThai_PhieuMuon		nvarchar(100),
	foreign key (ID_TheDocGia) references TheDocGia(ID_TheDocGia) on update cascade,
	foreign key (ID_Sach) references Sach(ID_Sach) on update cascade

)

create table PhieuTraSach
(
	ID_PhieuTraSach			int identity(1,1) primary key,
	ID_PhieuMuonSach		int,
	Ten_NguoiTra			nvarchar(100),
	NgayTraSach				datetime,
	SachChuaTra				int,
	TienPhat				decimal,
	TrangThai_PhieuTraSach	nvarchar(100),
	foreign key (ID_PhieuMuonSach) references PhieuMuonSach(ID_PhieuMuonSach) on update cascade
)

create table PhieuPhat
(
	ID_PhieuThu				int identity(1,1) primary key,
	ID_PhieuTraSach			int,
	SoTienThu				decimal,
	Ten_NguoiNopTien		nvarchar(100),
	DaThu					decimal,
	TrangThai_PhieuThuTienPhat	nvarchar(100),
	foreign key (ID_PhieuTraSach) references PhieuTraSach(ID_PhieuTraSach) on update cascade
)

--Quy định về loại độc giả
Insert into LoaiDocGia Values ('X',N'','')
Insert into LoaiDocGia Values ('Y',N'','')
Insert into LoaiDocGia Values ('Z',N'','')
Insert into LoaiDocGia Values ('TamBay',N'','')
select * from  LoaiDocGia

--Quy định về các tác giả
Insert into TacGia Values (N'Tác giả 1',N'Gần nhà tác giả 2',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 2',N'Gần nhà tác giả 3',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 3',N'Gần nhà tác giả 4',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 4',N'Gần nhà tác giả 5',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 5',N'Gần nhà tác giả 6',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 6',N'Gần nhà tác giả 7',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 7',N'Gần nhà tác giả 8',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 8',N'Gần nhà tác giả 9',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 9',N'Gần nhà tác giả 10',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 10',N'Gần nhà tác giả 11',N'0123456789',N'')

Insert into TacGia Values (N'Tác giả 11',N'Gần nhà tác giả 12',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 12',N'Gần nhà tác giả 13',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 13',N'Gần nhà tác giả 14',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 14',N'Gần nhà tác giả 15',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 15',N'Gần nhà tác giả 16',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 16',N'Gần nhà tác giả 17',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 17',N'Gần nhà tác giả 18',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 18',N'Gần nhà tác giả 19',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 19',N'Gần nhà tác giả 20',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 20',N'Gần nhà tác giả 21',N'0123456789',N'')

Insert into TacGia Values (N'Tác giả 21',N'Gần nhà tác giả 22',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 22',N'Gần nhà tác giả 23',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 23',N'Gần nhà tác giả 24',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 24',N'Gần nhà tác giả 25',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 25',N'Gần nhà tác giả 26',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 26',N'Gần nhà tác giả 27',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 27',N'Gần nhà tác giả 28',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 28',N'Gần nhà tác giả 29',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 29',N'Gần nhà tác giả 20',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 30',N'Gần nhà tác giả 31',N'0123456789',N'')

Insert into TacGia Values (N'Tác giả 31',N'Gần nhà tác giả 32',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 32',N'Gần nhà tác giả 33',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 33',N'Gần nhà tác giả 34',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 34',N'Gần nhà tác giả 35',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 35',N'Gần nhà tác giả 36',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 36',N'Gần nhà tác giả 37',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 37',N'Gần nhà tác giả 38',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 38',N'Gần nhà tác giả 39',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 39',N'Gần nhà tác giả 40',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 40',N'Gần nhà tác giả 41',N'0123456789',N'')

Insert into TacGia Values (N'Tác giả 41',N'Gần nhà tác giả 42',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 42',N'Gần nhà tác giả 43',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 43',N'Gần nhà tác giả 44',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 44',N'Gần nhà tác giả 45',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 45',N'Gần nhà tác giả 46',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 46',N'Gần nhà tác giả 47',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 47',N'Gần nhà tác giả 48',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 48',N'Gần nhà tác giả 49',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 49',N'Gần nhà tác giả 50',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 50',N'Gần nhà tác giả 51',N'0123456789',N'')

Insert into TacGia Values (N'Tác giả 51',N'Gần nhà tác giả 52',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 52',N'Gần nhà tác giả 53',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 53',N'Gần nhà tác giả 54',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 54',N'Gần nhà tác giả 55',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 55',N'Gần nhà tác giả 56',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 56',N'Gần nhà tác giả 57',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 57',N'Gần nhà tác giả 58',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 58',N'Gần nhà tác giả 59',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 59',N'Gần nhà tác giả 60',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 50',N'Gần nhà tác giả 21',N'0123456789',N'')

Insert into TacGia Values (N'Tác giả 61',N'Gần nhà tác giả 62',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 62',N'Gần nhà tác giả 63',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 63',N'Gần nhà tác giả 64',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 64',N'Gần nhà tác giả 65',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 65',N'Gần nhà tác giả 66',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 66',N'Gần nhà tác giả 67',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 67',N'Gần nhà tác giả 68',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 68',N'Gần nhà tác giả 69',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 69',N'Gần nhà tác giả 70',N'0123456789',N'')

Insert into TacGia Values (N'Tác giả 70',N'Gần nhà tác giả 71',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 71',N'Gần nhà tác giả 72',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 72',N'Gần nhà tác giả 73',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 73',N'Gần nhà tác giả 74',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 74',N'Gần nhà tác giả 75',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 75',N'Gần nhà tác giả 76',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 76',N'Gần nhà tác giả 77',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 77',N'Gần nhà tác giả 78',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 78',N'Gần nhà tác giả 79',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 79',N'Gần nhà tác giả 80',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 80',N'Gần nhà tác giả 81',N'0123456789',N'')

Insert into TacGia Values (N'Tác giả 81',N'Gần nhà tác giả 82',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 82',N'Gần nhà tác giả 83',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 83',N'Gần nhà tác giả 84',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 84',N'Gần nhà tác giả 85',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 85',N'Gần nhà tác giả 86',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 86',N'Gần nhà tác giả 87',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 87',N'Gần nhà tác giả 88',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 88',N'Gần nhà tác giả 89',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 89',N'Gần nhà tác giả 90',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 90',N'Gần nhà tác giả 91',N'0123456789',N'')

Insert into TacGia Values (N'Tác giả 91',N'Gần nhà tác giả 92',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 92',N'Gần nhà tác giả 93',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 93',N'Gần nhà tác giả 94',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 94',N'Gần nhà tác giả 95',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 95',N'Gần nhà tác giả 96',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 96',N'Gần nhà tác giả 97',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 97',N'Gần nhà tác giả 98',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 98',N'Gần nhà tác giả 99',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 99',N'Gần nhà tác giả 100',N'0123456789',N'')
Insert into TacGia Values (N'Tác giả 100',N'Gần nhà tác giả 1',N'0123456789',N'')
select * from  TacGia

--Quy định về thể loại sách
Insert into TheLoaiSach Values ('A','')
Insert into TheLoaiSach Values ('B','')
Insert into TheLoaiSach Values ('C','')
select * from  TheLoaiSach

set dateformat dmy
Insert into TheDocGia Values (1,N'Khánh','02/11/1997','22/4//2','a@cdd','01/07/2019','1/11/2019','')
select * from TheDocGia


select ID_LoaiDocGia,Ten_LoaiDocGia from LoaiDocGia where  TrangThai_LoaiDocGia=N''


set dateformat dmy
Insert into TheDocGia Values (1,N'Khánh','02/11/1997','22/4//2','a@cdd','01/07/2019','1/11/2019','')



select ID_LoaiDocGia,Ten_LoaiDocGia from LoaiDocGia where  TrangThai_LoaiDocGia=N''

select * from TheDocGia
