USE [master]
GO
/****** Object:  Database [TruongTHPT]    Script Date: 10/6/2016 9:25:49 PM ******/
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
/****** Object:  Table [dbo].[tblGiaoVien]    Script Date: 10/6/2016 9:25:49 PM ******/
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
/****** Object:  Table [dbo].[tblHocSinh]    Script Date: 10/6/2016 9:25:49 PM ******/
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
/****** Object:  Table [dbo].[tblLogin]    Script Date: 10/6/2016 9:25:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLogin](
	[Username] [nvarchar](50) NOT NULL,
	[Pass] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblLop]    Script Date: 10/6/2016 9:25:49 PM ******/
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
/****** Object:  Table [dbo].[tblMonHoc]    Script Date: 10/6/2016 9:25:49 PM ******/
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
INSERT [dbo].[tblGiaoVien] ([MaGV], [HoTen], [GT], [NgaySinh], [DiaChi], [SDT], [Luong], [MaMon]) VALUES (N'GV00000001', N'Bùi Thu Lâm', N'Nam','1/1/1990', N'Nghệ An', NULL, NULL, N'MH02      ')
INSERT [dbo].[tblGiaoVien] ([MaGV], [HoTen], [GT], [NgaySinh], [DiaChi], [SDT], [Luong], [MaMon]) VALUES (N'GV00000002', N'Nguyễn Hoàng Long', N'Nam', '1/1/1990', N'Hải Phòng', NULL, NULL, N'MH05      ')
INSERT [dbo].[tblGiaoVien] ([MaGV], [HoTen], [GT], [NgaySinh], [DiaChi], [SDT], [Luong], [MaMon]) VALUES (N'GV00000003', N'Tống Minh Đức', N'Nam', '1/1/1990', N'Thanh Hóa', NULL, NULL, N'MH01      ')
INSERT [dbo].[tblGiaoVien] ([MaGV], [HoTen], [GT], [NgaySinh], [DiaChi], [SDT], [Luong], [MaMon]) VALUES (N'GV00000004', N'Hà Đại Dương', N'Nu ', '1/1/1990', N'Hà Tĩnh', NULL, NULL, N'MH06      ')
INSERT [dbo].[tblGiaoVien] ([MaGV], [HoTen], [GT], [NgaySinh], [DiaChi], [SDT], [Luong], [MaMon]) VALUES (N'GV00000005', N'Trần Nguyên Ngọc', N'Nu ', '1/1/1990', N'Hòa Bình', NULL, NULL, N'MH03      ')
INSERT [dbo].[tblGiaoVien] ([MaGV], [HoTen], [GT], [NgaySinh], [DiaChi], [SDT], [Luong], [MaMon]) VALUES (N'GV00000006', N'Nguyễn Việt Hùng', N'Nam', '1/1/1990', N'Hải Dương', NULL, NULL, N'MH01      ')
INSERT [dbo].[tblGiaoVien] ([MaGV], [HoTen], [GT], [NgaySinh], [DiaChi], [SDT], [Luong], [MaMon]) VALUES (N'GV00000007', N'Tạ Minh Thanh', N'Nam', '1/1/1990', N'Ninh Bình', NULL, NULL, N'MH07      ')
INSERT [dbo].[tblGiaoVien] ([MaGV], [HoTen], [GT], [NgaySinh], [DiaChi], [SDT], [Luong], [MaMon]) VALUES (N'GV00000008', N'Nguyễn Quang Uy', N'Nam', '1/1/1990', N'An Giang', NULL, NULL, N'MH05      ')
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
INSERT [dbo].[tblHocSinh] ([MaHS], [HovaTen], [GT], [NgaySinh], [DiaChi], [PhuHuynh], [MaLop], [QueQuan]) VALUES (N'HS00000011', N'Nguyễn Hữu Huy', N'Nam', NULL, NULL, NULL, N'LOP0000002', NULL)
INSERT [dbo].[tblHocSinh] ([MaHS], [HovaTen], [GT], [NgaySinh], [DiaChi], [PhuHuynh], [MaLop], [QueQuan]) VALUES (N'HS00000012', N'Nguyễn Duy Hùng', NULL, NULL, NULL, NULL, N'LOP0000007', NULL)
INSERT [dbo].[tblHocSinh] ([MaHS], [HovaTen], [GT], [NgaySinh], [DiaChi], [PhuHuynh], [MaLop], [QueQuan]) VALUES (N'HS00000013', N'Phạm Quang Hưng', NULL, NULL, NULL, NULL, N'LOP0000004', NULL)
INSERT [dbo].[tblHocSinh] ([MaHS], [HovaTen], [GT], [NgaySinh], [DiaChi], [PhuHuynh], [MaLop], [QueQuan]) VALUES (N'HS00000014', N'Nguyễn Du Tùng Khánh', NULL, NULL, NULL, NULL, N'LOP0000001', NULL)
INSERT [dbo].[tblHocSinh] ([MaHS], [HovaTen], [GT], [NgaySinh], [DiaChi], [PhuHuynh], [MaLop], [QueQuan]) VALUES (N'HS00000015', N'Nguyễn Duy Long', NULL, NULL, NULL, NULL, N'LOP0000008', NULL)
INSERT [dbo].[tblHocSinh] ([MaHS], [HovaTen], [GT], [NgaySinh], [DiaChi], [PhuHuynh], [MaLop], [QueQuan]) VALUES (N'HS00000016', N'Trần Mạnh Linh', NULL, NULL, NULL, NULL, N'LOP0000006', NULL)
INSERT [dbo].[tblLogin] ([Username], [Pass]) VALUES (N'admin1', N'admin1')
INSERT [dbo].[tblLogin] ([Username], [Pass]) VALUES (N'admin2', N'admin2')
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






---Thủ tục suaGiaoVien
USE [TruongTHPT]
GO
/****** Object:  StoredProcedure [dbo].[suaGiaoVien]    Script Date: 20/10/2016 3:43:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[suaGiaoVien] (@MaGV nchar(10),@HoTen nvarchar(50),@GT nchar(3),@NgaySinh date,@DiaChi nvarchar(50),@SDT int,@Luong int,@MaMon nchar(10))
	-- Add the parameters for the stored procedure her
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	
	UPDATE tblGiaoVien SET MaGV = @MaGV, HoTen=@HoTen, GT = @GT, NgaySinh=@NgaySinh, DiaChi = @DiaChi, SDT = @SDT, Luong=@Luong, MaMon=@MaMon
						   WHERE MaGV = @MaGV 
    -- Insert statements for procedure here
	--SELECT <@Param1, sysname, @p1>, <@Param2, sysname, @p2>
END




--Thủ tục themGiaoVien
USE [TruongTHPT]
GO
/****** Object:  StoredProcedure [dbo].[themGiaoVien]    Script Date: 20/10/2016 3:44:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[themGiaoVien] (@MaGV nchar(10),@HoTen nvarchar(50),@GT nchar(3),@NgaySinh date,@DiaChi nvarchar(50),@SDT int,@Luong int,@MaMon nchar(10))
	-- Add the parameters for the stored procedure her
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	
	INSERT INTO tblGiaoVien(MaGV, HoTen, GT, NgaySinh, DiaChi, SDT, Luong, MaMon)
    VALUES(@MaGV, @HoTen, @GT, @NgaySinh, @DiaChi, @SDT, @Luong, @MaMon)
    -- Insert statements for procedure here
	--SELECT <@Param1, sysname, @p1>, <@Param2, sysname, @p2>
END



--Thủ tục xoaGiaoVien
USE [TruongTHPT]
GO
/****** Object:  StoredProcedure [dbo].[xoaGiaoVien]    Script Date: 20/10/2016 3:44:39 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[xoaGiaoVien] (@MaGV nchar(10))
	-- Add the parameters for the stored procedure her
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.	
	DELETE FROM tblGiaoVien WHERE MaGV = @MaGV
	DELETE FROM tblLop WHERE GVCN=@MaGV 
	DELETE FROM tblHocSinh WHERE tblHocSinh.MaLop=(SELECT MaLop FROM tblLop WHERE GVCN=@MaGV)
    -- Insert statements for procedure here
	--SELECT <@Param1, sysname, @p1>, <@Param2, sysname, @p2>
END


-- Thêm thủ tục sửa thông tin học sinh, anh em chạy hết những dòng lệnh sau
create proc Sua_TTHS (@mahs nchar(10), @hodem nvarchar(50),@gt nchar(3), @ngaysinh date,@diachi nvarchar(50),@quequan nvarchar(50),@phuhuynh nvarchar(50),@lop nvarchar(50))
as 
begin
	declare @malop nchar(10)
	select @malop=malop from tblLop where tenlop=@lop
	update tblHocSinh set Hovaten=@hodem,GT=@gt,NgaySinh=@ngaysinh,DiaChi=@diachi,MaLop=@malop,PhuHuynh=@phuhuynh,QueQuan=@quequan
	where Mahs=@mahs
end
alter table tblHocSinh alter column QueQuan nvarchar(50)
