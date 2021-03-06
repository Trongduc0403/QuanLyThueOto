USE [master]
GO
/****** Object:  Database [CNPM]    Script Date: 21/01/2021 4:22:43 PM ******/
CREATE DATABASE [CNPM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CNPM', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CNPM.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CNPM_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CNPM_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CNPM] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CNPM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CNPM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CNPM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CNPM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CNPM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CNPM] SET ARITHABORT OFF 
GO
ALTER DATABASE [CNPM] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CNPM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CNPM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CNPM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CNPM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CNPM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CNPM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CNPM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CNPM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CNPM] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CNPM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CNPM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CNPM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CNPM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CNPM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CNPM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CNPM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CNPM] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CNPM] SET  MULTI_USER 
GO
ALTER DATABASE [CNPM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CNPM] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CNPM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CNPM] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CNPM] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CNPM] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [CNPM] SET QUERY_STORE = OFF
GO
USE [CNPM]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 21/01/2021 4:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[TaiKhoan] [nchar](100) NOT NULL,
	[MatKhau] [nchar](100) NOT NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BBGN]    Script Date: 21/01/2021 4:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BBGN](
	[idBBGN] [int] IDENTITY(1,1) NOT NULL,
	[idXe] [int] NULL,
	[idKH] [int] NULL,
	[idNV] [int] NULL,
	[MaBBGN] [nchar](10) NULL,
	[NgayGiao] [datetime] NULL,
	[KmDi] [int] NULL,
	[XangDi] [char](20) NULL,
	[TrangThaiDi] [nvarchar](100) NULL,
	[NgayNhan] [datetime] NULL,
	[KmVe] [int] NULL,
	[XangVe] [char](20) NULL,
	[TrangThaiVe] [nvarchar](100) NULL,
 CONSTRAINT [PK_Table_6] PRIMARY KEY CLUSTERED 
(
	[idBBGN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BBSC]    Script Date: 21/01/2021 4:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BBSC](
	[id_BBSC] [int] IDENTITY(1,1) NOT NULL,
	[idXe] [int] NOT NULL,
	[idKH] [int] NOT NULL,
	[idNV] [int] NOT NULL,
	[MaBBSC] [nchar](10) NULL,
	[TenSC] [nvarchar](50) NULL,
	[NgayBBSC] [datetime] NULL,
	[NoiDungSC] [nvarchar](100) NULL,
	[TienPhat] [char](11) NULL,
 CONSTRAINT [PK_BBSC] PRIMARY KEY CLUSTERED 
(
	[id_BBSC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HopDong]    Script Date: 21/01/2021 4:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HopDong](
	[idHopDong] [int] IDENTITY(1,1) NOT NULL,
	[MaHD] [nchar](10) NULL,
	[idXe] [int] NULL,
	[idKH] [int] NULL,
	[idNV] [int] NULL,
	[NgayHD] [datetime] NULL,
	[NoiDungHD] [nvarchar](1000) NULL,
	[TienDat] [char](11) NULL,
	[KhuyenMai] [char](11) NULL,
	[GiayToGiuLai] [nvarchar](50) NULL,
 CONSTRAINT [PK_Table_5] PRIMARY KEY CLUSTERED 
(
	[idHopDong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 21/01/2021 4:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[idKH] [int] IDENTITY(1,1) NOT NULL,
	[MaKH] [nchar](10) NULL,
	[TenKH] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[sdtKH] [char](11) NULL,
	[cmtKH] [char](11) NULL,
	[GPLX] [char](11) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[idKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiXe]    Script Date: 21/01/2021 4:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiXe](
	[idLoaiXe] [int] IDENTITY(1,1) NOT NULL,
	[MaLoai] [nchar](10) NULL,
	[TenLoai] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[MoTa] [nvarchar](50) NULL,
 CONSTRAINT [PK_Table_3] PRIMARY KEY CLUSTERED 
(
	[idLoaiXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 21/01/2021 4:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[idNV] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [nchar](10) NULL,
	[TenNV] [nvarchar](50) NULL,
	[VaiTro] [nvarchar](50) NULL,
	[cmtNV] [char](11) NULL,
	[sdtNV] [char](11) NULL,
 CONSTRAINT [PK_Table_2] PRIMARY KEY CLUSTERED 
(
	[idNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThanhToan]    Script Date: 21/01/2021 4:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThanhToan](
	[id_Thanhtoan] [nchar](10) NOT NULL,
	[id_hopdong] [int] NOT NULL,
	[idNV] [int] NULL,
	[NgayTT] [datetime] NULL,
	[LyDo] [nvarchar](50) NULL,
	[HoSoKem] [nvarchar](50) NULL,
	[TienTT] [char](11) NULL,
 CONSTRAINT [PK_ThanhToan_1] PRIMARY KEY CLUSTERED 
(
	[id_Thanhtoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Xe]    Script Date: 21/01/2021 4:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Xe](
	[idXe] [int] IDENTITY(1,1) NOT NULL,
	[Biensoxe] [nchar](10) NULL,
	[idLoaiXe] [int] NULL,
	[TenXe] [nvarchar](50) NULL,
	[PhiXang] [char](11) NULL,
	[PhiQuaKm] [char](11) NULL,
	[DonGia] [char](11) NULL,
	[MoTaTT] [nvarchar](100) NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_Table_4] PRIMARY KEY CLUSTERED 
(
	[idXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([TaiKhoan], [MatKhau]) VALUES (N'123                                                                                                 ', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3                                    ')
GO
SET IDENTITY_INSERT [dbo].[BBGN] ON 

INSERT [dbo].[BBGN] ([idBBGN], [idXe], [idKH], [idNV], [MaBBGN], [NgayGiao], [KmDi], [XangDi], [TrangThaiDi], [NgayNhan], [KmVe], [XangVe], [TrangThaiVe]) VALUES (7, 10, 1007, 1010, N'111111    ', CAST(N'2021-01-25T00:00:00.000' AS DateTime), 15000, N'23                  ', N'cc', CAST(N'2021-01-26T00:00:00.000' AS DateTime), 15100, N'21                  ', N'dd')
INSERT [dbo].[BBGN] ([idBBGN], [idXe], [idKH], [idNV], [MaBBGN], [NgayGiao], [KmDi], [XangDi], [TrangThaiDi], [NgayNhan], [KmVe], [XangVe], [TrangThaiVe]) VALUES (8, 10, 1007, 1010, N'222222    ', CAST(N'2021-02-24T00:00:00.000' AS DateTime), 657657, N'76                  ', N'Á hihi', CAST(N'2021-03-26T00:00:00.000' AS DateTime), 768, N'87                  ', N'Ối dồi ôi')
INSERT [dbo].[BBGN] ([idBBGN], [idXe], [idKH], [idNV], [MaBBGN], [NgayGiao], [KmDi], [XangDi], [TrangThaiDi], [NgayNhan], [KmVe], [XangVe], [TrangThaiVe]) VALUES (10, 6, 1006, 1011, N'3333      ', CAST(N'2021-02-24T00:00:00.000' AS DateTime), 657657, N'76                  ', N'yt', CAST(N'2021-03-26T00:00:00.000' AS DateTime), 768, N'87                  ', N'ỷt')
SET IDENTITY_INSERT [dbo].[BBGN] OFF
GO
SET IDENTITY_INSERT [dbo].[BBSC] ON 

INSERT [dbo].[BBSC] ([id_BBSC], [idXe], [idKH], [idNV], [MaBBSC], [TenSC], [NgayBBSC], [NoiDungSC], [TienPhat]) VALUES (1, 3, 1006, 1009, N'SC111     ', N'Thủng lốp', CAST(N'2021-01-12T00:00:00.000' AS DateTime), N'Đang đi trên đường tự nhiên cán phải cái đinh. Đĩ mẹ nó cuộc đời', N'100000     ')
INSERT [dbo].[BBSC] ([id_BBSC], [idXe], [idKH], [idNV], [MaBBSC], [TenSC], [NgayBBSC], [NoiDungSC], [TienPhat]) VALUES (5, 6, 1007, 1010, N'SC1654    ', N'Bùm', CAST(N'2021-01-21T00:00:00.000' AS DateTime), N'Chết người', N'999999     ')
INSERT [dbo].[BBSC] ([id_BBSC], [idXe], [idKH], [idNV], [MaBBSC], [TenSC], [NgayBBSC], [NoiDungSC], [TienPhat]) VALUES (6, 6, 1007, 1010, N'SC1657    ', N'Rớt bánh', CAST(N'2021-01-21T00:00:00.000' AS DateTime), N'Rầm', N'65987      ')
SET IDENTITY_INSERT [dbo].[BBSC] OFF
GO
SET IDENTITY_INSERT [dbo].[HopDong] ON 

INSERT [dbo].[HopDong] ([idHopDong], [MaHD], [idXe], [idKH], [idNV], [NgayHD], [NoiDungHD], [TienDat], [KhuyenMai], [GiayToGiuLai]) VALUES (1015, N'11111     ', 1, 1006, 1011, CAST(N'2020-12-30T00:00:00.000' AS DateTime), N'a', N'1500000    ', N'15000      ', N'a')
INSERT [dbo].[HopDong] ([idHopDong], [MaHD], [idXe], [idKH], [idNV], [NgayHD], [NoiDungHD], [TienDat], [KhuyenMai], [GiayToGiuLai]) VALUES (1016, N'22222     ', 4, 1005, 1009, CAST(N'2021-05-19T00:00:00.000' AS DateTime), N'haha', N'150000     ', N'14000      ', N'á')
SET IDENTITY_INSERT [dbo].[HopDong] OFF
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([idKH], [MaKH], [TenKH], [DiaChi], [sdtKH], [cmtKH], [GPLX]) VALUES (1005, N'K0001     ', N'Thành Quang', N'Thủ Đức', N'0914648415 ', N'197454614  ', N'0454988    ')
INSERT [dbo].[KhachHang] ([idKH], [MaKH], [TenKH], [DiaChi], [sdtKH], [cmtKH], [GPLX]) VALUES (1006, N'K0002     ', N'Phước Đạt', N'Thủ Đức', N'091446547  ', N'197454447  ', N'04549487   ')
INSERT [dbo].[KhachHang] ([idKH], [MaKH], [TenKH], [DiaChi], [sdtKH], [cmtKH], [GPLX]) VALUES (1007, N'K0003     ', N'Thành Đạt', N'Quận 9', N'09144564   ', N'197454564  ', N'045494864  ')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
GO
SET IDENTITY_INSERT [dbo].[LoaiXe] ON 

INSERT [dbo].[LoaiXe] ([idLoaiXe], [MaLoai], [TenLoai], [SoLuong], [MoTa]) VALUES (1, N'TY15      ', N'Toyota', 2, N'Mới ')
INSERT [dbo].[LoaiXe] ([idLoaiXe], [MaLoai], [TenLoai], [SoLuong], [MoTa]) VALUES (2, N'HN51      ', N'Huyndai', 3, N'Mới ')
INSERT [dbo].[LoaiXe] ([idLoaiXe], [MaLoai], [TenLoai], [SoLuong], [MoTa]) VALUES (3, N'MZ26      ', N'Mazda', 2, N'Mới ')
SET IDENTITY_INSERT [dbo].[LoaiXe] OFF
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([idNV], [MaNV], [TenNV], [VaiTro], [cmtNV], [sdtNV]) VALUES (1009, N'N001      ', N'Trọng Đức', N'Chủ tịch', N'197454194  ', N'0942663145 ')
INSERT [dbo].[NhanVien] ([idNV], [MaNV], [TenNV], [VaiTro], [cmtNV], [sdtNV]) VALUES (1010, N'N002      ', N'Đình Hùng', N'Quét nhà', N'197455454  ', N'094214564  ')
INSERT [dbo].[NhanVien] ([idNV], [MaNV], [TenNV], [VaiTro], [cmtNV], [sdtNV]) VALUES (1011, N'N003      ', N'Thành Quang', N'Quét nhà vệ sinh', N'197454814  ', N'094254654  ')
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
GO
SET IDENTITY_INSERT [dbo].[Xe] ON 

INSERT [dbo].[Xe] ([idXe], [Biensoxe], [idLoaiXe], [TenXe], [PhiXang], [PhiQuaKm], [DonGia], [MoTaTT], [TrangThai]) VALUES (1, N'74B1-00000', 1, N'Toyota Vios ', N'17000      ', N'20000      ', N'500000     ', N'Còn mới', 1)
INSERT [dbo].[Xe] ([idXe], [Biensoxe], [idLoaiXe], [TenXe], [PhiXang], [PhiQuaKm], [DonGia], [MoTaTT], [TrangThai]) VALUES (2, N'74B1-11111', 2, N'Hyundai Elantra 2020', N'17000      ', N'20000      ', N'500000     ', N'Còn mới', 1)
INSERT [dbo].[Xe] ([idXe], [Biensoxe], [idLoaiXe], [TenXe], [PhiXang], [PhiQuaKm], [DonGia], [MoTaTT], [TrangThai]) VALUES (3, N'74B1-22222', 2, N'Hyundai Accent 2021', N'17000      ', N'20000      ', N'500000     ', N'Còn mới', 0)
INSERT [dbo].[Xe] ([idXe], [Biensoxe], [idLoaiXe], [TenXe], [PhiXang], [PhiQuaKm], [DonGia], [MoTaTT], [TrangThai]) VALUES (4, N'74C1-33333', 1, N'Toyota Fortuner', N'18000      ', N'25000      ', N'600000     ', N'Còn mới', 0)
INSERT [dbo].[Xe] ([idXe], [Biensoxe], [idLoaiXe], [TenXe], [PhiXang], [PhiQuaKm], [DonGia], [MoTaTT], [TrangThai]) VALUES (5, N'74B1-55555', 3, N'Mazda 6', N'20000      ', N'25000      ', N'700000     ', N'Còn mới', 1)
INSERT [dbo].[Xe] ([idXe], [Biensoxe], [idLoaiXe], [TenXe], [PhiXang], [PhiQuaKm], [DonGia], [MoTaTT], [TrangThai]) VALUES (6, N'74B1-66666', 3, N'Mazda CX5', N'21000      ', N'25000      ', N'800000     ', N'Còn mới', 1)
INSERT [dbo].[Xe] ([idXe], [Biensoxe], [idLoaiXe], [TenXe], [PhiXang], [PhiQuaKm], [DonGia], [MoTaTT], [TrangThai]) VALUES (7, N'74B1-77777', 2, N'Hyundai Santafe 2020', N'20000      ', N'25000      ', N'700000     ', N'Còn mới', 1)
INSERT [dbo].[Xe] ([idXe], [Biensoxe], [idLoaiXe], [TenXe], [PhiXang], [PhiQuaKm], [DonGia], [MoTaTT], [TrangThai]) VALUES (9, N'74B1-88888', 1, N'jhaf', N'154        ', N'16         ', N'16         ', N'sdfhjk', 1)
INSERT [dbo].[Xe] ([idXe], [Biensoxe], [idLoaiXe], [TenXe], [PhiXang], [PhiQuaKm], [DonGia], [MoTaTT], [TrangThai]) VALUES (10, N'74B1-99999', 2, N'jhaf', N'154        ', N'16         ', N'16         ', N'sdfhjk', 1)
SET IDENTITY_INSERT [dbo].[Xe] OFF
GO
ALTER TABLE [dbo].[BBGN]  WITH CHECK ADD  CONSTRAINT [FK_BBGN_Xe] FOREIGN KEY([idXe])
REFERENCES [dbo].[Xe] ([idXe])
GO
ALTER TABLE [dbo].[BBGN] CHECK CONSTRAINT [FK_BBGN_Xe]
GO
ALTER TABLE [dbo].[BBGN]  WITH CHECK ADD  CONSTRAINT [FK_Table_6_KhachHang] FOREIGN KEY([idKH])
REFERENCES [dbo].[KhachHang] ([idKH])
GO
ALTER TABLE [dbo].[BBGN] CHECK CONSTRAINT [FK_Table_6_KhachHang]
GO
ALTER TABLE [dbo].[BBGN]  WITH CHECK ADD  CONSTRAINT [FK_Table_6_Table_2] FOREIGN KEY([idNV])
REFERENCES [dbo].[NhanVien] ([idNV])
GO
ALTER TABLE [dbo].[BBGN] CHECK CONSTRAINT [FK_Table_6_Table_2]
GO
ALTER TABLE [dbo].[BBSC]  WITH CHECK ADD  CONSTRAINT [FK_BBSC_NhanVien] FOREIGN KEY([idNV])
REFERENCES [dbo].[NhanVien] ([idNV])
GO
ALTER TABLE [dbo].[BBSC] CHECK CONSTRAINT [FK_BBSC_NhanVien]
GO
ALTER TABLE [dbo].[BBSC]  WITH CHECK ADD  CONSTRAINT [FK_Table_7_KhachHang] FOREIGN KEY([idKH])
REFERENCES [dbo].[KhachHang] ([idKH])
GO
ALTER TABLE [dbo].[BBSC] CHECK CONSTRAINT [FK_Table_7_KhachHang]
GO
ALTER TABLE [dbo].[BBSC]  WITH CHECK ADD  CONSTRAINT [FK_Table_7_Table_4] FOREIGN KEY([idXe])
REFERENCES [dbo].[Xe] ([idXe])
GO
ALTER TABLE [dbo].[BBSC] CHECK CONSTRAINT [FK_Table_7_Table_4]
GO
ALTER TABLE [dbo].[HopDong]  WITH CHECK ADD  CONSTRAINT [FK_Table_5_KhachHang] FOREIGN KEY([idKH])
REFERENCES [dbo].[KhachHang] ([idKH])
GO
ALTER TABLE [dbo].[HopDong] CHECK CONSTRAINT [FK_Table_5_KhachHang]
GO
ALTER TABLE [dbo].[HopDong]  WITH CHECK ADD  CONSTRAINT [FK_Table_5_Table_2] FOREIGN KEY([idNV])
REFERENCES [dbo].[NhanVien] ([idNV])
GO
ALTER TABLE [dbo].[HopDong] CHECK CONSTRAINT [FK_Table_5_Table_2]
GO
ALTER TABLE [dbo].[HopDong]  WITH CHECK ADD  CONSTRAINT [FK_Table_5_Table_4] FOREIGN KEY([idXe])
REFERENCES [dbo].[Xe] ([idXe])
GO
ALTER TABLE [dbo].[HopDong] CHECK CONSTRAINT [FK_Table_5_Table_4]
GO
ALTER TABLE [dbo].[ThanhToan]  WITH CHECK ADD  CONSTRAINT [FK_ThanhToan_HopDong] FOREIGN KEY([id_hopdong])
REFERENCES [dbo].[HopDong] ([idHopDong])
GO
ALTER TABLE [dbo].[ThanhToan] CHECK CONSTRAINT [FK_ThanhToan_HopDong]
GO
ALTER TABLE [dbo].[ThanhToan]  WITH CHECK ADD  CONSTRAINT [FK_ThanhToan_NhanVien] FOREIGN KEY([id_hopdong])
REFERENCES [dbo].[NhanVien] ([idNV])
GO
ALTER TABLE [dbo].[ThanhToan] CHECK CONSTRAINT [FK_ThanhToan_NhanVien]
GO
ALTER TABLE [dbo].[Xe]  WITH CHECK ADD  CONSTRAINT [FK_Table_4_Table_3] FOREIGN KEY([idLoaiXe])
REFERENCES [dbo].[LoaiXe] ([idLoaiXe])
GO
ALTER TABLE [dbo].[Xe] CHECK CONSTRAINT [FK_Table_4_Table_3]
GO
USE [master]
GO
ALTER DATABASE [CNPM] SET  READ_WRITE 
GO
