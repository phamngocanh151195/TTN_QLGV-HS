USE [master]
GO
/****** Object:  Database [TruongTHPT]    Script Date: 10/6/2016 8:34:30 PM ******/
CREATE DATABASE [TruongTHPT]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TruongTHPT', FILENAME = N'E:\Tai lieu\nam 4_ki 1\Thuc tap nhom\Bai2_TruongTHPT\TruongTHPT.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TruongTHPT_log', FILENAME = N'E:\Tai lieu\nam 4_ki 1\Thuc tap nhom\Bai2_TruongTHPT\TruongTHPT_log.ldf' , SIZE = 3136KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TruongTHPT] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TruongTHPT].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TruongTHPT] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TruongTHPT] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TruongTHPT] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TruongTHPT] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TruongTHPT] SET ARITHABORT OFF 
GO
ALTER DATABASE [TruongTHPT] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [TruongTHPT] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [TruongTHPT] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TruongTHPT] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TruongTHPT] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TruongTHPT] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TruongTHPT] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TruongTHPT] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TruongTHPT] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TruongTHPT] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TruongTHPT] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TruongTHPT] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TruongTHPT] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TruongTHPT] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TruongTHPT] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TruongTHPT] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TruongTHPT] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TruongTHPT] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TruongTHPT] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TruongTHPT] SET  MULTI_USER 
GO
ALTER DATABASE [TruongTHPT] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TruongTHPT] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TruongTHPT] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TruongTHPT] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [TruongTHPT]
GO
/****** Object:  Table [dbo].[tblGiaoVien]    Script Date: 10/6/2016 8:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblGiaoVien](
	[MaGV] [nchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[GT] [nchar](3) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [int] NULL,
	[Luong] [bigint] NULL,
	[MaMon] [nchar](10) NULL,
 CONSTRAINT [PK_tblGiaoVien] PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblHocSinh]    Script Date: 10/6/2016 8:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHocSinh](
	[MaHS] [nchar](10) NOT NULL,
	[HovaTen] [nvarchar](50) NOT NULL,
	[GT] [nchar](3) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[PhuHuynh] [nvarchar](50) NULL,
	[MaLop] [nchar](10) NULL,
	[QueQuan] [nchar](50) NULL,
 CONSTRAINT [PK_tblHocSinh] PRIMARY KEY CLUSTERED 
(
	[MaHS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblLop]    Script Date: 10/6/2016 8:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLop](
	[MaLop] [nchar](10) NOT NULL,
	[TenLop] [nchar](10) NOT NULL,
	[GVCN] [nchar](10) NULL,
 CONSTRAINT [PK_tblLop] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblMonHoc]    Script Date: 10/6/2016 8:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMonHoc](
	[MaMon] [nchar](10) NOT NULL,
	[TenMon] [nvarchar](50) NOT NULL,
	[SoTiet/tuan] [int] NULL,
 CONSTRAINT [PK_tblMonHoc] PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[tblGiaoVien] ([MaGV], [HoTen], [GT], [NgaySinh], [DiaChi], [SDT], [Luong], [MaMon]) VALUES (N'GV00000001', N'Bùi Thu Lâm', N'Nam', NULL, N'Nghệ An', NULL, NULL, N'MH02      ')
INSERT [dbo].[tblGiaoVien] ([MaGV], [HoTen], [GT], [NgaySinh], [DiaChi], [SDT], [Luong], [MaMon]) VALUES (N'GV00000002', N'Nguyễn Hoàng Long', N'Nam', NULL, N'Hải Phòng', NULL, NULL, N'MH05      ')
INSERT [dbo].[tblGiaoVien] ([MaGV], [HoTen], [GT], [NgaySinh], [DiaChi], [SDT], [Luong], [MaMon]) VALUES (N'GV00000003', N'Tống Minh Đức', N'Nam', NULL, N'Thanh Hóa', NULL, NULL, N'MH01      ')
INSERT [dbo].[tblGiaoVien] ([MaGV], [HoTen], [GT], [NgaySinh], [DiaChi], [SDT], [Luong], [MaMon]) VALUES (N'GV00000004', N'Hà Đại Dương', N'Nu ', NULL, N'Hà Tĩnh', NULL, NULL, N'MH06      ')
INSERT [dbo].[tblGiaoVien] ([MaGV], [HoTen], [GT], [NgaySinh], [DiaChi], [SDT], [Luong], [MaMon]) VALUES (N'GV00000005', N'Trần Nguyên Ngọc', N'Nu ', NULL, N'Hòa Bình', NULL, NULL, N'MH03      ')
INSERT [dbo].[tblGiaoVien] ([MaGV], [HoTen], [GT], [NgaySinh], [DiaChi], [SDT], [Luong], [MaMon]) VALUES (N'GV00000006', N'Nguyễn Việt Hùng', N'Nam', NULL, N'Hải Dương', NULL, NULL, N'MH01      ')
INSERT [dbo].[tblGiaoVien] ([MaGV], [HoTen], [GT], [NgaySinh], [DiaChi], [SDT], [Luong], [MaMon]) VALUES (N'GV00000007', N'Tạ Minh Thanh', N'Nam', NULL, N'Ninh Bình', NULL, NULL, N'MH07      ')
INSERT [dbo].[tblGiaoVien] ([MaGV], [HoTen], [GT], [NgaySinh], [DiaChi], [SDT], [Luong], [MaMon]) VALUES (N'GV00000008', N'Nguyễn Quang Uy', N'Nam', NULL, N'An Giang', NULL, NULL, N'MH05      ')
INSERT [dbo].[tblGiaoVien] ([MaGV], [HoTen], [GT], [NgaySinh], [DiaChi], [SDT], [Luong], [MaMon]) VALUES (N'GV00000009', N'Lưu Hồng Dũng', N'Nam', NULL, N'Điện Biên', NULL, NULL, N'MH04      ')
INSERT [dbo].[tblHocSinh] ([MaHS], [HovaTen], [GT], [NgaySinh], [DiaChi], [PhuHuynh], [MaLop], [QueQuan]) VALUES (N'HS00000001', N'Nguyễn Văn Tuấn Anh', N'Nam', NULL, NULL, NULL, N'LOP0000001', NULL)
INSERT [dbo].[tblHocSinh] ([MaHS], [HovaTen], [GT], [NgaySinh], [DiaChi], [PhuHuynh], [MaLop], [QueQuan]) VALUES (N'HS00000002', N'Phạm Ngọc Anh', N'Nam', NULL, NULL, NULL, N'LOP0000009', NULL)
INSERT [dbo].[tblHocSinh] ([MaHS], [HovaTen], [GT], [NgaySinh], [DiaChi], [PhuHuynh], [MaLop], [QueQuan]) VALUES (N'HS00000003', N'Nguyễn Thế Công', N'Nam', NULL, NULL, NULL, N'LOP0000005', NULL)
INSERT [dbo].[tblHocSinh] ([MaHS], [HovaTen], [GT], [NgaySinh], [DiaChi], [PhuHuynh], [MaLop], [QueQuan]) VALUES (N'HS00000004', N'Phạm Văn Công', N'Nam', NULL, NULL, NULL, N'LOP0000001', NULL)
INSERT [dbo].[tblHocSinh] ([MaHS], [HovaTen], [GT], [NgaySinh], [DiaChi], [PhuHuynh], [MaLop], [QueQuan]) VALUES (N'HS00000005', N'Nguyễn Quốc Dũng', N'Nam', NULL, NULL, NULL, N'LOP0000002', NULL)
INSERT [dbo].[tblHocSinh] ([MaHS], [HovaTen], [GT], [NgaySinh], [DiaChi], [PhuHuynh], [MaLop], [QueQuan]) VALUES (N'HS00000006', N'Phan Trọng Duy', N'Nam', NULL, NULL, NULL, N'LOP0000006', NULL)
INSERT [dbo].[tblHocSinh] ([MaHS], [HovaTen], [GT], [NgaySinh], [DiaChi], [PhuHuynh], [MaLop], [QueQuan]) VALUES (N'HS00000007', N'Vi Đình Diệm', N'Nam', NULL, NULL, NULL, N'LOP0000005', NULL)
INSERT [dbo].[tblHocSinh] ([MaHS], [HovaTen], [GT], [NgaySinh], [DiaChi], [PhuHuynh], [MaLop], [QueQuan]) VALUES (N'HS00000008', N'Hà Đức Hiến', N'Nam', NULL, NULL, NULL, N'LOP0000004', NULL)
INSERT [dbo].[tblHocSinh] ([MaHS], [HovaTen], [GT], [NgaySinh], [DiaChi], [PhuHuynh], [MaLop], [QueQuan]) VALUES (N'HS00000009', N'Bạch Ngọc Hiệp', N'Nam', NULL, NULL, NULL, N'LOP0000008', NULL)
INSERT [dbo].[tblHocSinh] ([MaHS], [HovaTen], [GT], [NgaySinh], [DiaChi], [PhuHuynh], [MaLop], [QueQuan]) VALUES (N'HS00000010', N'Phạm Trọng Hiếu', N'Nam', NULL, NULL, NULL, N'LOP0000008', NULL)
INSERT [dbo].[tblLop] ([MaLop], [TenLop], [GVCN]) VALUES (N'LOP0000001', N'10A       ', N'GV00000001')
INSERT [dbo].[tblLop] ([MaLop], [TenLop], [GVCN]) VALUES (N'LOP0000002', N'10B       ', N'GV00000006')
INSERT [dbo].[tblLop] ([MaLop], [TenLop], [GVCN]) VALUES (N'LOP0000003', N'10C       ', N'GV00000004')
INSERT [dbo].[tblLop] ([MaLop], [TenLop], [GVCN]) VALUES (N'LOP0000004', N'11A       ', N'GV00000002')
INSERT [dbo].[tblLop] ([MaLop], [TenLop], [GVCN]) VALUES (N'LOP0000005', N'11B       ', N'GV00000005')
INSERT [dbo].[tblLop] ([MaLop], [TenLop], [GVCN]) VALUES (N'LOP0000006', N'11C       ', N'GV00000003')
INSERT [dbo].[tblLop] ([MaLop], [TenLop], [GVCN]) VALUES (N'LOP0000007', N'12A       ', N'GV00000009')
INSERT [dbo].[tblLop] ([MaLop], [TenLop], [GVCN]) VALUES (N'LOP0000008', N'12B       ', N'GV00000007')
INSERT [dbo].[tblLop] ([MaLop], [TenLop], [GVCN]) VALUES (N'LOP0000009', N'12C       ', N'GV00000008')
INSERT [dbo].[tblMonHoc] ([MaMon], [TenMon], [SoTiet/tuan]) VALUES (N'MH01      ', N'Toán', NULL)
INSERT [dbo].[tblMonHoc] ([MaMon], [TenMon], [SoTiet/tuan]) VALUES (N'MH02      ', N'Vật Lý', NULL)
INSERT [dbo].[tblMonHoc] ([MaMon], [TenMon], [SoTiet/tuan]) VALUES (N'MH03      ', N'Hóa Học', NULL)
INSERT [dbo].[tblMonHoc] ([MaMon], [TenMon], [SoTiet/tuan]) VALUES (N'MH04      ', N'Ngữ Văn', NULL)
INSERT [dbo].[tblMonHoc] ([MaMon], [TenMon], [SoTiet/tuan]) VALUES (N'MH05      ', N'Lịch Sử', NULL)
INSERT [dbo].[tblMonHoc] ([MaMon], [TenMon], [SoTiet/tuan]) VALUES (N'MH06      ', N'Địa Lý', NULL)
INSERT [dbo].[tblMonHoc] ([MaMon], [TenMon], [SoTiet/tuan]) VALUES (N'MH07      ', N'Tiếng Anh', NULL)
ALTER TABLE [dbo].[tblGiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_tblGiaoVien_tblMonHoc] FOREIGN KEY([MaMon])
REFERENCES [dbo].[tblMonHoc] ([MaMon])
GO
ALTER TABLE [dbo].[tblGiaoVien] CHECK CONSTRAINT [FK_tblGiaoVien_tblMonHoc]
GO
ALTER TABLE [dbo].[tblHocSinh]  WITH CHECK ADD  CONSTRAINT [FK_tblHocSinh_tblLop] FOREIGN KEY([MaLop])
REFERENCES [dbo].[tblLop] ([MaLop])
GO
ALTER TABLE [dbo].[tblHocSinh] CHECK CONSTRAINT [FK_tblHocSinh_tblLop]
GO
ALTER TABLE [dbo].[tblLop]  WITH CHECK ADD  CONSTRAINT [FK_tblLop_tblGiaoVien] FOREIGN KEY([GVCN])
REFERENCES [dbo].[tblGiaoVien] ([MaGV])
GO
ALTER TABLE [dbo].[tblLop] CHECK CONSTRAINT [FK_tblLop_tblGiaoVien]
GO
USE [master]
GO
ALTER DATABASE [TruongTHPT] SET  READ_WRITE 
GO
