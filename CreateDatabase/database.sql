USE [master]
GO
/****** Object:  Database [QuanLyDaiLy_NMCNPM]    Script Date: 5/31/2019 8:03:11 PM ******/
CREATE DATABASE [QuanLyDaiLy_NMCNPM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyDaiLy_NMCNPM', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\QuanLyDaiLy_NMCNPM.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyDaiLy_NMCNPM_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\QuanLyDaiLy_NMCNPM_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [QuanLyDaiLy_NMCNPM] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyDaiLy_NMCNPM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyDaiLy_NMCNPM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyDaiLy_NMCNPM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyDaiLy_NMCNPM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyDaiLy_NMCNPM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyDaiLy_NMCNPM] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyDaiLy_NMCNPM] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyDaiLy_NMCNPM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyDaiLy_NMCNPM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyDaiLy_NMCNPM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyDaiLy_NMCNPM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyDaiLy_NMCNPM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyDaiLy_NMCNPM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyDaiLy_NMCNPM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyDaiLy_NMCNPM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyDaiLy_NMCNPM] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyDaiLy_NMCNPM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyDaiLy_NMCNPM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyDaiLy_NMCNPM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyDaiLy_NMCNPM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyDaiLy_NMCNPM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyDaiLy_NMCNPM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyDaiLy_NMCNPM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyDaiLy_NMCNPM] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyDaiLy_NMCNPM] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyDaiLy_NMCNPM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyDaiLy_NMCNPM] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyDaiLy_NMCNPM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyDaiLy_NMCNPM] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyDaiLy_NMCNPM] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyDaiLy_NMCNPM', N'ON'
GO
ALTER DATABASE [QuanLyDaiLy_NMCNPM] SET QUERY_STORE = OFF
GO
USE [QuanLyDaiLy_NMCNPM]
GO
/****** Object:  Table [dbo].[tblAccount]    Script Date: 5/31/2019 8:03:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAccount](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[userName] [varchar](250) NULL,
	[passWord] [varchar](250) NULL,
 CONSTRAINT [PK_tblAccount] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblBaoCaoCongNo]    Script Date: 5/31/2019 8:03:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBaoCaoCongNo](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[maDL] [bigint] NULL,
	[noDau] [money] NULL,
	[phatSinh] [money] NULL,
	[noCuoi] [money] NULL,
	[maTG] [bigint] NULL,
 CONSTRAINT [PK_tblBaoCaoCongNo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblBaoCaoDoanhSo]    Script Date: 5/31/2019 8:03:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBaoCaoDoanhSo](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[soPhieuXuat] [int] NULL,
	[maDL] [bigint] NULL,
	[tongTriGia] [money] NULL,
	[tyLe] [float] NULL,
	[maTG] [bigint] NULL,
 CONSTRAINT [PK_tblBaoCaoDoanhSo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChiTietPX]    Script Date: 5/31/2019 8:03:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietPX](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[maPX] [bigint] NULL,
	[maDVT] [bigint] NULL,
	[maMH] [bigint] NULL,
	[soLuong] [int] NULL,
	[thanhTien] [money] NULL,
 CONSTRAINT [PK_tblChiTietPX] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDaiLy]    Script Date: 5/31/2019 8:03:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDaiLy](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[tenDL] [nvarchar](250) NOT NULL,
	[maLoaiDL] [bigint] NULL,
	[sdt] [varchar](15) NULL,
	[diaChi] [nvarchar](500) NULL,
	[maQuan] [bigint] NULL,
	[ngayTiepNhan] [datetime2](7) NULL,
	[tongNo] [money] NULL,
 CONSTRAINT [PK_tblDaiLy] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDonViTinh]    Script Date: 5/31/2019 8:03:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDonViTinh](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[tenDVT] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_tblDonViTinh] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLoaiDaiLy]    Script Date: 5/31/2019 8:03:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLoaiDaiLy](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[tenLDL] [nvarchar](250) NOT NULL,
	[noToiDa] [money] NULL,
 CONSTRAINT [PK_tblLoaiDaiLy] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblMatHang]    Script Date: 5/31/2019 8:03:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMatHang](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[tenMatHang] [nvarchar](250) NOT NULL,
	[maDonViTinh] [bigint] NULL,
	[donGia] [money] NULL,
 CONSTRAINT [PK_tblMatHang] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPhieuThu]    Script Date: 5/31/2019 8:03:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhieuThu](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[ngayThu] [datetime2](7) NULL,
	[maDL] [bigint] NULL,
	[soTienThu] [money] NULL,
 CONSTRAINT [PK_tblPhieuThu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPhieuXuat]    Script Date: 5/31/2019 8:03:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhieuXuat](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[maDL] [bigint] NULL,
	[ngayLapPhieu] [datetime2](7) NULL,
	[tongTriGia] [money] NULL,
 CONSTRAINT [PK_tblPhieuXuat] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblQuan]    Script Date: 5/31/2019 8:03:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblQuan](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[tenQuan] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_tblQuan] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblThamSo]    Script Date: 5/31/2019 8:03:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblThamSo](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[soQuan] [int] NULL,
	[soDLToiDa] [int] NULL,
	[soMH] [int] NULL,
	[soDVT] [int] NULL,
 CONSTRAINT [PK_tblThamSo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblThoiGian]    Script Date: 5/31/2019 8:03:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblThoiGian](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[thang] [int] NULL,
	[nam] [int] NULL,
 CONSTRAINT [PK_tblThoiGian] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblAccount] ON 

INSERT [dbo].[tblAccount] ([id], [userName], [passWord]) VALUES (1, N'admin', N'123456')
SET IDENTITY_INSERT [dbo].[tblAccount] OFF
SET IDENTITY_INSERT [dbo].[tblChiTietPX] ON 

INSERT [dbo].[tblChiTietPX] ([id], [maPX], [maDVT], [maMH], [soLuong], [thanhTien]) VALUES (1, 1, 1, 1, 3, 90000.0000)
SET IDENTITY_INSERT [dbo].[tblChiTietPX] OFF
SET IDENTITY_INSERT [dbo].[tblDaiLy] ON 

INSERT [dbo].[tblDaiLy] ([id], [tenDL], [maLoaiDL], [sdt], [diaChi], [maQuan], [ngayTiepNhan], [tongNo]) VALUES (1, N'Đại lý 1', 1, N'0123456789', N'HCM', 1, CAST(N'2019-01-01T12:20:53.0000000' AS DateTime2), 10000.0000)
INSERT [dbo].[tblDaiLy] ([id], [tenDL], [maLoaiDL], [sdt], [diaChi], [maQuan], [ngayTiepNhan], [tongNo]) VALUES (2, N'Vinamilk', 2, N'0343333333', N'HCM', 1, CAST(N'2019-01-01T12:21:53.0000000' AS DateTime2), 0.0000)
INSERT [dbo].[tblDaiLy] ([id], [tenDL], [maLoaiDL], [sdt], [diaChi], [maQuan], [ngayTiepNhan], [tongNo]) VALUES (3, N'Cô Gái Hà Lan', 2, N'03412221112', N'Phường 2', 1, CAST(N'2019-01-01T12:22:53.0000000' AS DateTime2), 0.0000)
INSERT [dbo].[tblDaiLy] ([id], [tenDL], [maLoaiDL], [sdt], [diaChi], [maQuan], [ngayTiepNhan], [tongNo]) VALUES (4, N'Đại lý 4', 2, N'0303', N'HCM', 1, CAST(N'2019-01-01T12:23:53.0000000' AS DateTime2), 0.0000)
INSERT [dbo].[tblDaiLy] ([id], [tenDL], [maLoaiDL], [sdt], [diaChi], [maQuan], [ngayTiepNhan], [tongNo]) VALUES (9, N'Number 1', 2, N'0342525111', N'Phường 1', 5, CAST(N'2019-05-31T19:43:17.1666667' AS DateTime2), 0.0000)
SET IDENTITY_INSERT [dbo].[tblDaiLy] OFF
SET IDENTITY_INSERT [dbo].[tblDonViTinh] ON 

INSERT [dbo].[tblDonViTinh] ([id], [tenDVT]) VALUES (1, N'Đơn vị tính 1')
INSERT [dbo].[tblDonViTinh] ([id], [tenDVT]) VALUES (2, N'Đơn vị tính 2')
INSERT [dbo].[tblDonViTinh] ([id], [tenDVT]) VALUES (3, N'Đơn vị tính 3')
SET IDENTITY_INSERT [dbo].[tblDonViTinh] OFF
SET IDENTITY_INSERT [dbo].[tblLoaiDaiLy] ON 

INSERT [dbo].[tblLoaiDaiLy] ([id], [tenLDL], [noToiDa]) VALUES (1, N'Đại lý loại 1', 20000.0000)
INSERT [dbo].[tblLoaiDaiLy] ([id], [tenLDL], [noToiDa]) VALUES (2, N'Đại lý loại 2', 50000.0000)
SET IDENTITY_INSERT [dbo].[tblLoaiDaiLy] OFF
SET IDENTITY_INSERT [dbo].[tblMatHang] ON 

INSERT [dbo].[tblMatHang] ([id], [tenMatHang], [maDonViTinh], [donGia]) VALUES (1, N'Mặt hàng 1', 1, 30000.0000)
INSERT [dbo].[tblMatHang] ([id], [tenMatHang], [maDonViTinh], [donGia]) VALUES (2, N'Mặt hàng 2', 1, 40000.0000)
INSERT [dbo].[tblMatHang] ([id], [tenMatHang], [maDonViTinh], [donGia]) VALUES (3, N'Mặt hàng 3', 2, 50000.0000)
INSERT [dbo].[tblMatHang] ([id], [tenMatHang], [maDonViTinh], [donGia]) VALUES (4, N'Mặt hàng 4', 2, 60000.0000)
INSERT [dbo].[tblMatHang] ([id], [tenMatHang], [maDonViTinh], [donGia]) VALUES (5, N'Mặt hàng 5', 3, 70000.0000)
SET IDENTITY_INSERT [dbo].[tblMatHang] OFF
SET IDENTITY_INSERT [dbo].[tblPhieuThu] ON 

INSERT [dbo].[tblPhieuThu] ([id], [ngayThu], [maDL], [soTienThu]) VALUES (1, CAST(N'2019-01-01T12:23:53.0000000' AS DateTime2), 1, 5000.0000)
SET IDENTITY_INSERT [dbo].[tblPhieuThu] OFF
SET IDENTITY_INSERT [dbo].[tblPhieuXuat] ON 

INSERT [dbo].[tblPhieuXuat] ([id], [maDL], [ngayLapPhieu], [tongTriGia]) VALUES (1, 1, CAST(N'2019-01-01T12:23:53.0000000' AS DateTime2), 90000.0000)
SET IDENTITY_INSERT [dbo].[tblPhieuXuat] OFF
SET IDENTITY_INSERT [dbo].[tblQuan] ON 

INSERT [dbo].[tblQuan] ([id], [tenQuan]) VALUES (1, N'Quận 1')
INSERT [dbo].[tblQuan] ([id], [tenQuan]) VALUES (2, N'Quận 2')
INSERT [dbo].[tblQuan] ([id], [tenQuan]) VALUES (3, N'Quận 3')
INSERT [dbo].[tblQuan] ([id], [tenQuan]) VALUES (4, N'Quận 4')
INSERT [dbo].[tblQuan] ([id], [tenQuan]) VALUES (5, N'Quận 5')
INSERT [dbo].[tblQuan] ([id], [tenQuan]) VALUES (6, N'Quận 6')
INSERT [dbo].[tblQuan] ([id], [tenQuan]) VALUES (7, N'Quận 7')
INSERT [dbo].[tblQuan] ([id], [tenQuan]) VALUES (8, N'Quận 8')
INSERT [dbo].[tblQuan] ([id], [tenQuan]) VALUES (9, N'Quận 9')
INSERT [dbo].[tblQuan] ([id], [tenQuan]) VALUES (10, N'Quận 10')
INSERT [dbo].[tblQuan] ([id], [tenQuan]) VALUES (11, N'Quận 11')
INSERT [dbo].[tblQuan] ([id], [tenQuan]) VALUES (12, N'Quận 12')
INSERT [dbo].[tblQuan] ([id], [tenQuan]) VALUES (13, N'Quận 13')
INSERT [dbo].[tblQuan] ([id], [tenQuan]) VALUES (14, N'Quận 14')
INSERT [dbo].[tblQuan] ([id], [tenQuan]) VALUES (15, N'Quận 15')
INSERT [dbo].[tblQuan] ([id], [tenQuan]) VALUES (16, N'Quận 16')
INSERT [dbo].[tblQuan] ([id], [tenQuan]) VALUES (17, N'Quận 17')
INSERT [dbo].[tblQuan] ([id], [tenQuan]) VALUES (18, N'Quận 18')
INSERT [dbo].[tblQuan] ([id], [tenQuan]) VALUES (19, N'Quận 19')
INSERT [dbo].[tblQuan] ([id], [tenQuan]) VALUES (20, N'Quận 20')
SET IDENTITY_INSERT [dbo].[tblQuan] OFF
SET IDENTITY_INSERT [dbo].[tblThamSo] ON 

INSERT [dbo].[tblThamSo] ([id], [soQuan], [soDLToiDa], [soMH], [soDVT]) VALUES (1, 20, 4, 5, 3)
SET IDENTITY_INSERT [dbo].[tblThamSo] OFF
SET IDENTITY_INSERT [dbo].[tblThoiGian] ON 

INSERT [dbo].[tblThoiGian] ([id], [thang], [nam]) VALUES (1, 1, 2019)
SET IDENTITY_INSERT [dbo].[tblThoiGian] OFF
ALTER TABLE [dbo].[tblBaoCaoCongNo] ADD  DEFAULT ((0)) FOR [noDau]
GO
ALTER TABLE [dbo].[tblBaoCaoCongNo] ADD  DEFAULT ((0)) FOR [phatSinh]
GO
ALTER TABLE [dbo].[tblBaoCaoCongNo] ADD  DEFAULT ((0)) FOR [noCuoi]
GO
ALTER TABLE [dbo].[tblBaoCaoDoanhSo] ADD  DEFAULT ((0)) FOR [soPhieuXuat]
GO
ALTER TABLE [dbo].[tblBaoCaoDoanhSo] ADD  DEFAULT ((0)) FOR [tongTriGia]
GO
ALTER TABLE [dbo].[tblBaoCaoDoanhSo] ADD  DEFAULT ((0)) FOR [tyLe]
GO
ALTER TABLE [dbo].[tblChiTietPX] ADD  DEFAULT ((0)) FOR [thanhTien]
GO
ALTER TABLE [dbo].[tblDaiLy] ADD  DEFAULT ((0)) FOR [tongNo]
GO
ALTER TABLE [dbo].[tblPhieuXuat] ADD  DEFAULT ((0)) FOR [tongTriGia]
GO
ALTER TABLE [dbo].[tblBaoCaoCongNo]  WITH CHECK ADD  CONSTRAINT [FK_tblBaoCaoCongNo_MaDL] FOREIGN KEY([maDL])
REFERENCES [dbo].[tblDaiLy] ([id])
GO
ALTER TABLE [dbo].[tblBaoCaoCongNo] CHECK CONSTRAINT [FK_tblBaoCaoCongNo_MaDL]
GO
ALTER TABLE [dbo].[tblBaoCaoCongNo]  WITH CHECK ADD  CONSTRAINT [FK_tblBaoCaoCongNo_MaTG] FOREIGN KEY([maTG])
REFERENCES [dbo].[tblThoiGian] ([id])
GO
ALTER TABLE [dbo].[tblBaoCaoCongNo] CHECK CONSTRAINT [FK_tblBaoCaoCongNo_MaTG]
GO
ALTER TABLE [dbo].[tblBaoCaoDoanhSo]  WITH CHECK ADD  CONSTRAINT [FK_tblBaoCaoDoanhSo_MaDL] FOREIGN KEY([maDL])
REFERENCES [dbo].[tblDaiLy] ([id])
GO
ALTER TABLE [dbo].[tblBaoCaoDoanhSo] CHECK CONSTRAINT [FK_tblBaoCaoDoanhSo_MaDL]
GO
ALTER TABLE [dbo].[tblBaoCaoDoanhSo]  WITH CHECK ADD  CONSTRAINT [FK_tblBaoCaoDoanhSo_MaTG] FOREIGN KEY([maTG])
REFERENCES [dbo].[tblThoiGian] ([id])
GO
ALTER TABLE [dbo].[tblBaoCaoDoanhSo] CHECK CONSTRAINT [FK_tblBaoCaoDoanhSo_MaTG]
GO
ALTER TABLE [dbo].[tblChiTietPX]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietPX_MaDVT] FOREIGN KEY([maDVT])
REFERENCES [dbo].[tblDonViTinh] ([id])
GO
ALTER TABLE [dbo].[tblChiTietPX] CHECK CONSTRAINT [FK_tblChiTietPX_MaDVT]
GO
ALTER TABLE [dbo].[tblChiTietPX]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietPX_MaMH] FOREIGN KEY([maMH])
REFERENCES [dbo].[tblMatHang] ([id])
GO
ALTER TABLE [dbo].[tblChiTietPX] CHECK CONSTRAINT [FK_tblChiTietPX_MaMH]
GO
ALTER TABLE [dbo].[tblChiTietPX]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietPX_MaPX] FOREIGN KEY([maPX])
REFERENCES [dbo].[tblPhieuXuat] ([id])
GO
ALTER TABLE [dbo].[tblChiTietPX] CHECK CONSTRAINT [FK_tblChiTietPX_MaPX]
GO
ALTER TABLE [dbo].[tblDaiLy]  WITH CHECK ADD  CONSTRAINT [FK_tblDaiLy_MaLoaiDL] FOREIGN KEY([maLoaiDL])
REFERENCES [dbo].[tblLoaiDaiLy] ([id])
GO
ALTER TABLE [dbo].[tblDaiLy] CHECK CONSTRAINT [FK_tblDaiLy_MaLoaiDL]
GO
ALTER TABLE [dbo].[tblDaiLy]  WITH CHECK ADD  CONSTRAINT [FK_tblDaiLy_MaQuan] FOREIGN KEY([maQuan])
REFERENCES [dbo].[tblQuan] ([id])
GO
ALTER TABLE [dbo].[tblDaiLy] CHECK CONSTRAINT [FK_tblDaiLy_MaQuan]
GO
ALTER TABLE [dbo].[tblMatHang]  WITH CHECK ADD  CONSTRAINT [FK_tblMatHang_maDonViTinh] FOREIGN KEY([maDonViTinh])
REFERENCES [dbo].[tblDonViTinh] ([id])
GO
ALTER TABLE [dbo].[tblMatHang] CHECK CONSTRAINT [FK_tblMatHang_maDonViTinh]
GO
ALTER TABLE [dbo].[tblPhieuThu]  WITH CHECK ADD  CONSTRAINT [FK_tblPhieuThu_MaDL] FOREIGN KEY([maDL])
REFERENCES [dbo].[tblDaiLy] ([id])
GO
ALTER TABLE [dbo].[tblPhieuThu] CHECK CONSTRAINT [FK_tblPhieuThu_MaDL]
GO
ALTER TABLE [dbo].[tblPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_tblPhieuXuat_MaDL] FOREIGN KEY([maDL])
REFERENCES [dbo].[tblDaiLy] ([id])
GO
ALTER TABLE [dbo].[tblPhieuXuat] CHECK CONSTRAINT [FK_tblPhieuXuat_MaDL]
GO
/****** Object:  StoredProcedure [dbo].[CheckLogin]    Script Date: 5/31/2019 8:03:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CheckLogin]
(
	@username varchar(250),
	@password varchar(250)	
)
as
begin
	select * from tblAccount where @username = userName and @password = [passWord]
end
GO
USE [master]
GO
ALTER DATABASE [QuanLyDaiLy_NMCNPM] SET  READ_WRITE 
GO
create trigger [dbo].[tr_bcds] on [dbo].[tblPhieuThu]
after insert as
begin
	declare @m datetime =( select (ngaythu) from inserted)
	declare  @month int = month(@m)
	declare @year int = year(@m)
	declare @idtime int
	declare @iddaily int  = (select madl from inserted)
	declare @money money = (select soTienThu from inserted)
	
if( exists( select * from tblThoiGian where thang = @month and nam = @year))
	begin
		
		select @idtime = id from tblThoiGian where thang = @month and nam = @year
	end
else
	begin
		insert into tblThoiGian values ( @month , @year )
		select @idtime = id from tblThoiGian where thang = @month and nam = @year
	end
if (exists (select * from tblBaoCaoDoanhSo where maDL = @iddaily and maTG = @idtime ))
	begin
		update tblBaoCaoDoanhSo 
		set 
			soPhieuXuat = (soPhieuXuat + 1 ),
			Tongtrigia = tongtrigia +  @money
		where maDL = @iddaily and maTG = @idtime		
	end
else
	begin 
		insert into tblBaoCaoDoanhSo([maDL],[soPhieuXuat],[tongTriGia],[maTG]) values(@iddaily,1,@money,@idtime)
	end
end 
go
create trigger [dbo].[tr_delete_bcds] on [dbo].[tblPhieuThu]
after delete as
begin
	declare @m datetime =( select (ngaythu) from deleted)
	declare  @month int = month(@m)
	declare @year int = year(@m)
	declare @idtime int
	declare @iddaily int  = (select madl from deleted)
	declare @money money = (select soTienThu from deleted)
	

select @idtime = id from tblThoiGian where thang = @month and nam = @year

	update tblBaoCaoDoanhSo 
	set 
		soPhieuXuat = (soPhieuXuat - 1 ),
		Tongtrigia = tongtrigia -  @money
	where maDL = @iddaily and maTG = @idtime		
delete from tblBaoCaoDoanhSo where soPhieuXuat = 0

end 
create trigger [dbo].[tr_update_bcds] on [dbo].[tblPhieuThu]
after update as
begin
	declare @m datetime =( select (ngaythu) from inserted)
	declare  @month int = month(@m)
	declare @year int = year(@m)
	declare @idtime int
	declare @iddaily int  = (select madl from deleted)
	declare @money money = (select soTienThu from deleted)
	

select @idtime = id from tblThoiGian where thang = @month and nam = @year

	update tblBaoCaoDoanhSo 
	set 
		Tongtrigia = tongtrigia -  (select soTienThu from deleted  ) + (select soTienThu from inserted)
	where maDL = @iddaily and maTG = @idtime		
	

end 
    
