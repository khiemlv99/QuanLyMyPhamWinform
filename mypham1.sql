USE [master]
GO
/****** Object:  Database [QuanLyShopMyPham]    Script Date: 7/10/2020 9:09:09 AM ******/
CREATE DATABASE [QuanLyShopMyPham]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyShopMyPham', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QuanLyShopMyPham.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyShopMyPham_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QuanLyShopMyPham_log.ldf' , SIZE = 784KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyShopMyPham] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyShopMyPham].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyShopMyPham] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyShopMyPham] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyShopMyPham] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyShopMyPham] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyShopMyPham] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyShopMyPham] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyShopMyPham] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyShopMyPham] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyShopMyPham] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyShopMyPham] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyShopMyPham] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyShopMyPham] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyShopMyPham] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyShopMyPham] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyShopMyPham] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyShopMyPham] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyShopMyPham] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyShopMyPham] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyShopMyPham] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyShopMyPham] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyShopMyPham] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyShopMyPham] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyShopMyPham] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyShopMyPham] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyShopMyPham] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyShopMyPham] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyShopMyPham] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyShopMyPham] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyShopMyPham] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QuanLyShopMyPham]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 7/10/2020 9:09:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaHD] [int] NOT NULL,
	[MaSP] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[GiaBan] [money] NULL,
	[ThanhTien] [money] NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 7/10/2020 9:09:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[MaPN] [int] NOT NULL,
	[MaSP] [int] NOT NULL,
	[NgayNhap] [datetime] NOT NULL,
	[SoLuong] [int] NULL,
	[NhaCungCap] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChiTietPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC,
	[MaSP] ASC,
	[NgayNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 7/10/2020 9:09:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[TaiKhoan] [nvarchar](50) NOT NULL,
	[NgayBan] [datetime] NULL,
	[MaKH] [int] NULL,
	[TongTien] [money] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 7/10/2020 9:09:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[SĐT] [nchar](10) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Diem] [int] NULL,
	[MaLoaiKH] [int] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Kho]    Script Date: 7/10/2020 9:09:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kho](
	[MaPN] [int] IDENTITY(1,1) NOT NULL,
	[MaSP] [int] NOT NULL,
	[SoLuongTon] [int] NULL,
 CONSTRAINT [PK_Kho] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiKH]    Script Date: 7/10/2020 9:09:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiKH](
	[MaLoaiKH] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiKH] [nvarchar](50) NULL,
	[MocDiem] [int] NULL,
	[KhuyenMai] [int] NULL,
 CONSTRAINT [PK_LoaiKH] PRIMARY KEY CLUSTERED 
(
	[MaLoaiKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhomNV]    Script Date: 7/10/2020 9:09:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomNV](
	[MaNhomNV] [int] IDENTITY(1,1) NOT NULL,
	[TenNhomNV] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhomNV] PRIMARY KEY CLUSTERED 
(
	[MaNhomNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhomSP]    Script Date: 7/10/2020 9:09:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomSP](
	[MaNhomSP] [int] IDENTITY(1,1) NOT NULL,
	[TenNhomSP] [nchar](10) NULL,
 CONSTRAINT [PK_NhomSP] PRIMARY KEY CLUSTERED 
(
	[MaNhomSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 7/10/2020 9:09:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPN] [int] IDENTITY(1,1) NOT NULL,
	[TenPN] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 7/10/2020 9:09:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [int] IDENTITY(1,1) NOT NULL,
	[TenSP] [nvarchar](50) NULL,
	[MaNhomSP] [int] NULL,
	[GiaNhapSP] [money] NULL,
	[GiaBanSP] [money] NULL,
	[MoTaSP] [nvarchar](200) NULL,
	[HinhAnh] [bit] NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 7/10/2020 9:09:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TaiKhoan] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NULL,
	[HoTenNV] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[MaNhomNV] [int] NULL,
 CONSTRAINT [PK_TaiKhoan_1] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan], [ThanhTien]) VALUES (1, 3, 2, 250000.0000, 500000.0000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan], [ThanhTien]) VALUES (1, 4, 1, 230000.0000, 230000.0000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan], [ThanhTien]) VALUES (1, 9, 5, 200000.0000, 1000000.0000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan], [ThanhTien]) VALUES (1, 12, 1, 270000.0000, 270000.0000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan], [ThanhTien]) VALUES (2, 6, 5, 300000.0000, 1500000.0000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan], [ThanhTien]) VALUES (3, 4, 1, 230000.0000, 230000.0000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan], [ThanhTien]) VALUES (3, 5, 1, 220000.0000, 220000.0000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan], [ThanhTien]) VALUES (3, 8, 1, 220000.0000, 220000.0000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan], [ThanhTien]) VALUES (3, 9, 10, 200000.0000, 2000000.0000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan], [ThanhTien]) VALUES (3, 10, 1, 330000.0000, 330000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [NgayNhap], [SoLuong], [NhaCungCap]) VALUES (1, 5, CAST(N'2020-02-05 00:00:00.000' AS DateTime), 100, N'MCTCBI')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [NgayNhap], [SoLuong], [NhaCungCap]) VALUES (2, 2, CAST(N'2020-02-05 00:00:00.000' AS DateTime), 120, N'Manis')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [NgayNhap], [SoLuong], [NhaCungCap]) VALUES (3, 3, CAST(N'2020-02-05 00:00:00.000' AS DateTime), 300, N'Dove')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [NgayNhap], [SoLuong], [NhaCungCap]) VALUES (4, 1, CAST(N'2020-02-05 00:00:00.000' AS DateTime), 300, N'White conc')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [NgayNhap], [SoLuong], [NhaCungCap]) VALUES (5, 6, CAST(N'2020-02-04 00:00:00.000' AS DateTime), 100, N'3CE')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [NgayNhap], [SoLuong], [NhaCungCap]) VALUES (6, 4, CAST(N'2020-02-05 00:00:00.000' AS DateTime), 400, N'MSMI')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [NgayNhap], [SoLuong], [NhaCungCap]) VALUES (7, 7, CAST(N'2020-02-05 00:00:00.000' AS DateTime), 300, N'MOC')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [NgayNhap], [SoLuong], [NhaCungCap]) VALUES (8, 8, CAST(N'2020-02-05 00:00:00.000' AS DateTime), 150, N'DHC')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [NgayNhap], [SoLuong], [NhaCungCap]) VALUES (9, 9, CAST(N'2020-02-05 00:00:00.000' AS DateTime), 250, N'TFSRB')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [NgayNhap], [SoLuong], [NhaCungCap]) VALUES (10, 10, CAST(N'2020-02-05 00:00:00.000' AS DateTime), 180, N'LWTUP')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [NgayNhap], [SoLuong], [NhaCungCap]) VALUES (11, 11, CAST(N'2020-02-05 00:00:00.000' AS DateTime), 170, N'CML')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [NgayNhap], [SoLuong], [NhaCungCap]) VALUES (12, 12, CAST(N'2020-02-05 00:00:00.000' AS DateTime), 500, N'KSC')
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

INSERT [dbo].[HoaDon] ([MaHD], [TaiKhoan], [NgayBan], [MaKH], [TongTien]) VALUES (1, N'NV001', CAST(N'2020-02-06 00:00:00.000' AS DateTime), 1, 2000000.0000)
INSERT [dbo].[HoaDon] ([MaHD], [TaiKhoan], [NgayBan], [MaKH], [TongTien]) VALUES (2, N'NV001', CAST(N'2020-02-06 00:00:00.000' AS DateTime), 2, 1500000.0000)
INSERT [dbo].[HoaDon] ([MaHD], [TaiKhoan], [NgayBan], [MaKH], [TongTien]) VALUES (3, N'NV001', CAST(N'2020-02-06 00:00:00.000' AS DateTime), 3, 3000000.0000)
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SĐT], [DiaChi], [Diem], [MaLoaiKH]) VALUES (1, N'Phan Thanh Hải', N'0371458159', N'tan binh', 10, 1)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SĐT], [DiaChi], [Diem], [MaLoaiKH]) VALUES (2, N'Lê Vĩnh Khiêm', N'0987265366', N'Tan Phu', 30, 2)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SĐT], [DiaChi], [Diem], [MaLoaiKH]) VALUES (3, N'Nguyễn Hải Nam', N'0359139943', N'Phu Nhuân', 45, 3)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SĐT], [DiaChi], [Diem], [MaLoaiKH]) VALUES (4, N'Hồ Văn Đạt', N'0982602395', N'go vap', 35, 2)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SĐT], [DiaChi], [Diem], [MaLoaiKH]) VALUES (5, N'Nguyễn Quang Huy', N'0782239411', N'Binh Thanh', 5, 1)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SĐT], [DiaChi], [Diem], [MaLoaiKH]) VALUES (6, N'Vương Huỳnh Thanh Tuấn', N'0358915698', N'Binh Tan', 40, 3)
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
SET IDENTITY_INSERT [dbo].[Kho] ON 

INSERT [dbo].[Kho] ([MaPN], [MaSP], [SoLuongTon]) VALUES (1, 5, 100)
INSERT [dbo].[Kho] ([MaPN], [MaSP], [SoLuongTon]) VALUES (2, 2, 120)
INSERT [dbo].[Kho] ([MaPN], [MaSP], [SoLuongTon]) VALUES (3, 3, 300)
INSERT [dbo].[Kho] ([MaPN], [MaSP], [SoLuongTon]) VALUES (4, 1, 300)
INSERT [dbo].[Kho] ([MaPN], [MaSP], [SoLuongTon]) VALUES (5, 6, 400)
SET IDENTITY_INSERT [dbo].[Kho] OFF
SET IDENTITY_INSERT [dbo].[LoaiKH] ON 

INSERT [dbo].[LoaiKH] ([MaLoaiKH], [TenLoaiKH], [MocDiem], [KhuyenMai]) VALUES (1, N'Vip1', 10, 2)
INSERT [dbo].[LoaiKH] ([MaLoaiKH], [TenLoaiKH], [MocDiem], [KhuyenMai]) VALUES (2, N'Vip2', 25, 5)
INSERT [dbo].[LoaiKH] ([MaLoaiKH], [TenLoaiKH], [MocDiem], [KhuyenMai]) VALUES (3, N'Vip3', 40, 10)
SET IDENTITY_INSERT [dbo].[LoaiKH] OFF
SET IDENTITY_INSERT [dbo].[NhomNV] ON 

INSERT [dbo].[NhomNV] ([MaNhomNV], [TenNhomNV]) VALUES (1, N'QuanLy')
INSERT [dbo].[NhomNV] ([MaNhomNV], [TenNhomNV]) VALUES (2, N'NhanVien')
SET IDENTITY_INSERT [dbo].[NhomNV] OFF
SET IDENTITY_INSERT [dbo].[NhomSP] ON 

INSERT [dbo].[NhomSP] ([MaNhomSP], [TenNhomSP]) VALUES (1, N'Kem       ')
INSERT [dbo].[NhomSP] ([MaNhomSP], [TenNhomSP]) VALUES (2, N'Son       ')
INSERT [dbo].[NhomSP] ([MaNhomSP], [TenNhomSP]) VALUES (3, N'Tay trang ')
INSERT [dbo].[NhomSP] ([MaNhomSP], [TenNhomSP]) VALUES (4, N'Sua Tam   ')
SET IDENTITY_INSERT [dbo].[NhomSP] OFF
SET IDENTITY_INSERT [dbo].[PhieuNhap] ON 

INSERT [dbo].[PhieuNhap] ([MaPN], [TenPN]) VALUES (1, N'PN_001')
INSERT [dbo].[PhieuNhap] ([MaPN], [TenPN]) VALUES (2, N'PN_002')
INSERT [dbo].[PhieuNhap] ([MaPN], [TenPN]) VALUES (3, N'PN_003')
INSERT [dbo].[PhieuNhap] ([MaPN], [TenPN]) VALUES (4, N'PN_004')
INSERT [dbo].[PhieuNhap] ([MaPN], [TenPN]) VALUES (5, N'PN_005')
INSERT [dbo].[PhieuNhap] ([MaPN], [TenPN]) VALUES (6, N'PN_006')
INSERT [dbo].[PhieuNhap] ([MaPN], [TenPN]) VALUES (7, N'PN_007')
INSERT [dbo].[PhieuNhap] ([MaPN], [TenPN]) VALUES (8, N'PN_008')
INSERT [dbo].[PhieuNhap] ([MaPN], [TenPN]) VALUES (9, N'PN_009')
INSERT [dbo].[PhieuNhap] ([MaPN], [TenPN]) VALUES (10, N'PN_010')
INSERT [dbo].[PhieuNhap] ([MaPN], [TenPN]) VALUES (11, N'PN_011')
INSERT [dbo].[PhieuNhap] ([MaPN], [TenPN]) VALUES (12, N'PN_012')
SET IDENTITY_INSERT [dbo].[PhieuNhap] OFF
SET IDENTITY_INSERT [dbo].[SanPham] ON 

INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaNhomSP], [GiaNhapSP], [GiaBanSP], [MoTaSP], [HinhAnh]) VALUES (1, N'White conc', 4, 100000.0000, 150000.0000, N'Nhật Bản vẫn thường được biết tới là một quốc gia vô cùng chăm chút về những sản phẩm làm đẹp. Vì vậy sữa tắm White conc đến từ Nhật luôn nằm trong top sữa tắm tốt nhất hiện nay.', NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaNhomSP], [GiaNhapSP], [GiaBanSP], [MoTaSP], [HinhAnh]) VALUES (2, N'Sữa tắm Manis', 4, 200000.0000, 230000.0000, N' Manis là loại sữa tắm có khả năng tẩy tế bào chết tương đối tốt cho da, mang lại cho bạn một làn da trắng hồng tự nhiên', NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaNhomSP], [GiaNhapSP], [GiaBanSP], [MoTaSP], [HinhAnh]) VALUES (3, N'Sữa tắm Dove', 4, 230000.0000, 250000.0000, N'Dove là một thương hiệu đến từ Mỹ và đã tạo được một tầm ảnh hưởng rất lớn đối với thị trường Việt Nam nhiều năm trở lại đây.', NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaNhomSP], [GiaNhapSP], [GiaBanSP], [MoTaSP], [HinhAnh]) VALUES (4, N'Son môi Maybelline SuperStay Matte Ink', 2, 205000.0000, 230000.0000, N'Đây là ứng viên son kem lì được yêu thích chỉ sau Creamy Matte nhờ chất son mềm mịn, tôn màu môi và khả năng lưu màu lên đến 10 giờ đồng hồ.', NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaNhomSP], [GiaNhapSP], [GiaBanSP], [MoTaSP], [HinhAnh]) VALUES (5, N'Son môi Mamonde Creamy Tint Color Balm Intense', 2, 200000.0000, 220000.0000, N'Ưu điểm của dòng son này là bảng màu đa dạng, phù hợp với tông da của phụ nữ châu Á, khả năng bám màu tốt, chất son nhẹ mượt', NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaNhomSP], [GiaNhapSP], [GiaBanSP], [MoTaSP], [HinhAnh]) VALUES (6, N'Son môi 3CE Velvet Lip Tint', 2, 250000.0000, 300000.0000, N' Đây cũng là màu son xu hướng năm 2019 với sắc son nhẹ nhàng, mượt mà, lâu trôi lại đầy nữ tính', NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaNhomSP], [GiaNhapSP], [GiaBanSP], [MoTaSP], [HinhAnh]) VALUES (7, N'Dầu tẩy trang Muji Oil Cleansing', 3, 200000.0000, 250000.0000, N'Muji là một thương hiệu mỹ phẩm nổi tiếng đến từ Nhật, sản phẩm của hãng luôn được ưa chuộng bởi chất lượng và công dụng tốt', NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaNhomSP], [GiaNhapSP], [GiaBanSP], [MoTaSP], [HinhAnh]) VALUES (8, N'Dầu tẩy trang DHC Deep Cleansing Oil', 3, 170000.0000, 220000.0000, N'Dầu tẩy trang DHC Deep Cleansing Oil là một sản phẩm giúp làm sạch sâu cho da giống như cái tên của nó.', NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaNhomSP], [GiaNhapSP], [GiaBanSP], [MoTaSP], [HinhAnh]) VALUES (9, N'Dầu tẩy trang The Face Shop Real Blend', 3, 175000.0000, 200000.0000, N'Đây là một sản phẩm có hình thức rất “nịnh người” và thiên nhiên khi thấy cả nhánh cúc bên trong chai, nếu bạn nào yêu thích sự xinh xắn đi kèm với chất lượng thì không nên bỏ qua', NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaNhomSP], [GiaNhapSP], [GiaBanSP], [MoTaSP], [HinhAnh]) VALUES (10, N'Kem dưỡng da Laneige White Dew Tone Up Cream', 1, 300000.0000, 330000.0000, N'Điểm nổi bật nhất của một trong top 10 kem dưỡng trắng da tốt nhất này là nâng tông màu da ngay tức thì sau khi thoa', NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaNhomSP], [GiaNhapSP], [GiaBanSP], [MoTaSP], [HinhAnh]) VALUES (11, N'Kem CeraVe Moisturizing Lotion', 1, 270000.0000, 320000.0000, N'Kem được thiết kế đơn giản dạng cream, có dung tích 89ml nhỏ gọn và sang trọng nên dễ dàng trong việc mang theo', NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaNhomSP], [GiaNhapSP], [GiaBanSP], [MoTaSP], [HinhAnh]) VALUES (12, N'Kem Kose Medicated Sekkisei Cream', NULL, 230000.0000, 270000.0000, N'Đây là sản phẩm đến từ thương hiệu mỹ phẩm đình đám của Nhật Bản Sekkisei Kose. Sản phẩm được chiết xuất hoàn toàn từ thảo dược nên thích hợp cho mọi loại da', NULL)
SET IDENTITY_INSERT [dbo].[SanPham] OFF
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [HoTenNV], [DiaChi], [MaNhomNV]) VALUES (N' QL001', N'123', N'Khiemdaica', N'TanPhu', 1)
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [HoTenNV], [DiaChi], [MaNhomNV]) VALUES (N'NV001', N'123', N'Dat', N'Go Vap', 2)
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [HoTenNV], [DiaChi], [MaNhomNV]) VALUES (N'QL002', N'123', N'Huydeptrai', N'TanPhu', 1)
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_SanPham]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap] FOREIGN KEY([MaPN])
REFERENCES [dbo].[PhieuNhap] ([MaPN])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_SanPham]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_TaiKhoan] FOREIGN KEY([TaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([TaiKhoan])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_TaiKhoan]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_LoaiKH] FOREIGN KEY([MaLoaiKH])
REFERENCES [dbo].[LoaiKH] ([MaLoaiKH])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_LoaiKH]
GO
ALTER TABLE [dbo].[Kho]  WITH CHECK ADD  CONSTRAINT [FK_Kho_PhieuNhap] FOREIGN KEY([MaPN])
REFERENCES [dbo].[PhieuNhap] ([MaPN])
GO
ALTER TABLE [dbo].[Kho] CHECK CONSTRAINT [FK_Kho_PhieuNhap]
GO
ALTER TABLE [dbo].[Kho]  WITH CHECK ADD  CONSTRAINT [FK_Kho_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[Kho] CHECK CONSTRAINT [FK_Kho_SanPham]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_NhomSP] FOREIGN KEY([MaNhomSP])
REFERENCES [dbo].[NhomSP] ([MaNhomSP])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_NhomSP]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_NhomNV] FOREIGN KEY([MaNhomNV])
REFERENCES [dbo].[NhomNV] ([MaNhomNV])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_NhomNV]
GO
USE [master]
GO
ALTER DATABASE [QuanLyShopMyPham] SET  READ_WRITE 
GO
