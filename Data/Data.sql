USE [master]
GO
/****** Object:  Database [DoAnNhapMonCongNghePhanMemQuanLyThuVien]    Script Date: 02/07/2019 10:47:15 ******/
CREATE DATABASE [DoAnNhapMonCongNghePhanMemQuanLyThuVien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DoAnNhapMonCongNghePhanMemQuanLyThuVien', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DoAnNhapMonCongNghePhanMemQuanLyThuVien.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DoAnNhapMonCongNghePhanMemQuanLyThuVien_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DoAnNhapMonCongNghePhanMemQuanLyThuVien_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DoAnNhapMonCongNghePhanMemQuanLyThuVien] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DoAnNhapMonCongNghePhanMemQuanLyThuVien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DoAnNhapMonCongNghePhanMemQuanLyThuVien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DoAnNhapMonCongNghePhanMemQuanLyThuVien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DoAnNhapMonCongNghePhanMemQuanLyThuVien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DoAnNhapMonCongNghePhanMemQuanLyThuVien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DoAnNhapMonCongNghePhanMemQuanLyThuVien] SET ARITHABORT OFF 
GO
ALTER DATABASE [DoAnNhapMonCongNghePhanMemQuanLyThuVien] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DoAnNhapMonCongNghePhanMemQuanLyThuVien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DoAnNhapMonCongNghePhanMemQuanLyThuVien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DoAnNhapMonCongNghePhanMemQuanLyThuVien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DoAnNhapMonCongNghePhanMemQuanLyThuVien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DoAnNhapMonCongNghePhanMemQuanLyThuVien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DoAnNhapMonCongNghePhanMemQuanLyThuVien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DoAnNhapMonCongNghePhanMemQuanLyThuVien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DoAnNhapMonCongNghePhanMemQuanLyThuVien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DoAnNhapMonCongNghePhanMemQuanLyThuVien] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DoAnNhapMonCongNghePhanMemQuanLyThuVien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DoAnNhapMonCongNghePhanMemQuanLyThuVien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DoAnNhapMonCongNghePhanMemQuanLyThuVien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DoAnNhapMonCongNghePhanMemQuanLyThuVien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DoAnNhapMonCongNghePhanMemQuanLyThuVien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DoAnNhapMonCongNghePhanMemQuanLyThuVien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DoAnNhapMonCongNghePhanMemQuanLyThuVien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DoAnNhapMonCongNghePhanMemQuanLyThuVien] SET RECOVERY FULL 
GO
ALTER DATABASE [DoAnNhapMonCongNghePhanMemQuanLyThuVien] SET  MULTI_USER 
GO
ALTER DATABASE [DoAnNhapMonCongNghePhanMemQuanLyThuVien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DoAnNhapMonCongNghePhanMemQuanLyThuVien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DoAnNhapMonCongNghePhanMemQuanLyThuVien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DoAnNhapMonCongNghePhanMemQuanLyThuVien] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DoAnNhapMonCongNghePhanMemQuanLyThuVien] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'DoAnNhapMonCongNghePhanMemQuanLyThuVien', N'ON'
GO
USE [DoAnNhapMonCongNghePhanMemQuanLyThuVien]
GO
/****** Object:  Table [dbo].[LoaiDocGia]    Script Date: 02/07/2019 10:47:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiDocGia](
	[ID_LoaiDocGia] [int] IDENTITY(1,1) NOT NULL,
	[Ten_LoaiDocGia] [nvarchar](100) NULL,
	[GhiChu_LoaiDocGia] [nvarchar](100) NULL,
	[TrangThai_LoaiDocGia] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_LoaiDocGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaXuatBan]    Script Date: 02/07/2019 10:47:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaXuatBan](
	[ID_NXB] [int] IDENTITY(1,1) NOT NULL,
	[Ten_NXB] [nvarchar](100) NULL,
	[TrangThai_NXB] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_NXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuMuonSach]    Script Date: 02/07/2019 10:47:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuMuonSach](
	[ID_PhieuMuonSach] [int] IDENTITY(1,1) NOT NULL,
	[ID_TheDocGia] [int] NULL,
	[ID_Sach] [int] NULL,
	[Ten_NguoiMuon] [nvarchar](100) NULL,
	[NgayMuon] [datetime] NULL,
	[NgayHenTra] [datetime] NULL,
	[Sl_SachMuon] [int] NULL,
	[GhiChu] [nvarchar](100) NULL,
	[TrangThai_PhieuMuon] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_PhieuMuonSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuPhat]    Script Date: 02/07/2019 10:47:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuPhat](
	[ID_PhieuThu] [int] IDENTITY(1,1) NOT NULL,
	[ID_PhieuTraSach] [int] NULL,
	[SoTienThu] [decimal](18, 0) NULL,
	[Ten_NguoiNopTien] [nvarchar](100) NULL,
	[DaThu] [decimal](18, 0) NULL,
	[TrangThai_PhieuThuTienPhat] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_PhieuThu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuTraSach]    Script Date: 02/07/2019 10:47:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuTraSach](
	[ID_PhieuTraSach] [int] IDENTITY(1,1) NOT NULL,
	[ID_PhieuMuonSach] [int] NULL,
	[Ten_NguoiTra] [nvarchar](100) NULL,
	[NgayTraSach] [datetime] NULL,
	[SachChuaTra] [int] NULL,
	[TienPhat] [decimal](18, 0) NULL,
	[TrangThai_PhieuTraSach] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_PhieuTraSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sach]    Script Date: 02/07/2019 10:47:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sach](
	[ID_Sach] [int] IDENTITY(1,1) NOT NULL,
	[ID_TheLoaiSach] [int] NULL,
	[ID_TacGia] [int] NULL,
	[ID_NXB] [int] NULL,
	[Ten_Sach] [nvarchar](100) NULL,
	[Gia] [decimal](18, 0) NULL,
	[Sl_Nhap] [int] NULL,
	[MoTa] [nvarchar](500) NULL,
	[NamXuatBan] [varchar](10) NULL,
	[NgayNhap] [datetime] NULL,
	[TrangThai_Sach] [nvarchar](100) NULL,
	[TrangThai_MuonSach] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Sach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TacGia]    Script Date: 02/07/2019 10:47:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TacGia](
	[ID_TacGia] [int] IDENTITY(1,1) NOT NULL,
	[Ten_TacGia] [nvarchar](100) NULL,
	[DiaChi_TacGia] [nvarchar](100) NULL,
	[SDT_TacGia] [nvarchar](11) NULL,
	[TrangThai_TacGia] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_TacGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TheDocGia]    Script Date: 02/07/2019 10:47:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheDocGia](
	[ID_TheDocGia] [int] IDENTITY(1,1) NOT NULL,
	[ID_LoaiDocGia] [int] NULL,
	[HoTen_DocGia] [nvarchar](100) NULL,
	[NgaySinh_DocGia] [datetime] NULL,
	[DiaChi_DocGia] [nvarchar](100) NULL,
	[Email_DocGia] [nvarchar](100) NULL,
	[NgayLapThe] [datetime] NULL,
	[NgayHetHan] [datetime] NULL,
	[TrangThai_TheDocGia] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_TheDocGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TheLoaiSach]    Script Date: 02/07/2019 10:47:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheLoaiSach](
	[ID_TheLoaiSach] [int] IDENTITY(1,1) NOT NULL,
	[Ten_TheLoaiSach] [nvarchar](10) NULL,
	[TrangThai_TheLoaiSach] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_TheLoaiSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[PhieuMuonSach]  WITH CHECK ADD FOREIGN KEY([ID_Sach])
REFERENCES [dbo].[Sach] ([ID_Sach])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[PhieuMuonSach]  WITH CHECK ADD FOREIGN KEY([ID_TheDocGia])
REFERENCES [dbo].[TheDocGia] ([ID_TheDocGia])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[PhieuPhat]  WITH CHECK ADD FOREIGN KEY([ID_PhieuTraSach])
REFERENCES [dbo].[PhieuTraSach] ([ID_PhieuTraSach])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[PhieuTraSach]  WITH CHECK ADD FOREIGN KEY([ID_PhieuMuonSach])
REFERENCES [dbo].[PhieuMuonSach] ([ID_PhieuMuonSach])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD FOREIGN KEY([ID_NXB])
REFERENCES [dbo].[NhaXuatBan] ([ID_NXB])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD FOREIGN KEY([ID_TacGia])
REFERENCES [dbo].[TacGia] ([ID_TacGia])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD FOREIGN KEY([ID_TheLoaiSach])
REFERENCES [dbo].[TheLoaiSach] ([ID_TheLoaiSach])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[TheDocGia]  WITH CHECK ADD FOREIGN KEY([ID_LoaiDocGia])
REFERENCES [dbo].[LoaiDocGia] ([ID_LoaiDocGia])
ON UPDATE CASCADE
GO
USE [master]
GO
ALTER DATABASE [DoAnNhapMonCongNghePhanMemQuanLyThuVien] SET  READ_WRITE 
GO
