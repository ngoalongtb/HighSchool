USE [master]
GO
/****** Object:  Database [QuanLyDiem]    Script Date: 2/21/2018 11:42:46 PM ******/
CREATE DATABASE [QuanLyDiem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyDiem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QuanLyDiem.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyDiem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QuanLyDiem_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyDiem] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyDiem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyDiem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyDiem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyDiem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyDiem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyDiem] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyDiem] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyDiem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyDiem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyDiem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyDiem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyDiem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyDiem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyDiem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyDiem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyDiem] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyDiem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyDiem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyDiem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyDiem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyDiem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyDiem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyDiem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyDiem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyDiem] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyDiem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyDiem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyDiem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyDiem] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLyDiem] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QuanLyDiem]
GO
/****** Object:  Table [dbo].[BaiViet]    Script Date: 2/21/2018 11:42:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BaiViet](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[noi_dung] [nvarchar](max) NULL,
	[do_uu_tien] [int] NULL,
	[tai_khoan] [char](10) NULL,
	[hinh_anh] [varchar](255) NULL,
	[ma_danh_muc] [char](10) NULL,
	[tieu_de] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DanhMuc]    Script Date: 2/21/2018 11:42:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DanhMuc](
	[ma] [char](10) NOT NULL,
	[ten] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 2/21/2018 11:42:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GiaoVien](
	[ma] [char](10) NOT NULL,
	[ten] [nvarchar](255) NULL,
	[ngay_sinh] [date] NULL,
	[url_anh] [varchar](255) NULL,
	[so_dien_thoai] [varchar](20) NULL,
	[email] [varchar](255) NULL,
	[ngay_vao_truong] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HocSinh]    Script Date: 2/21/2018 11:42:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HocSinh](
	[ma] [char](10) NOT NULL,
	[ten] [nvarchar](255) NULL,
	[ngay_sinh] [date] NULL,
	[ma_lop_on_dinh] [char](10) NULL,
	[so_dien_thoai] [varchar](20) NULL,
	[email] [varchar](255) NULL,
	[url_anh] [varchar](255) NULL,
	[ngay_nhap_hoc] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KyHoc]    Script Date: 2/21/2018 11:42:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KyHoc](
	[ma] [char](10) NOT NULL,
	[ky_hoc] [nvarchar](10) NULL,
	[bat_dau] [date] NULL,
	[ket_thuc] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LopHoc]    Script Date: 2/21/2018 11:42:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LopHoc](
	[ma] [char](10) NOT NULL,
	[ma_mon_hoc] [char](10) NULL,
	[ma_ky_hoc] [char](10) NULL,
	[ma_giao_vien] [char](10) NULL,
	[ma_lop_on_dinh] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LopHocHocSinh]    Script Date: 2/21/2018 11:42:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LopHocHocSinh](
	[ma_lop] [char](10) NOT NULL,
	[ma_hoc_sinh] [char](10) NOT NULL,
	[diemTrenLop] [float] NULL,
	[diemThi] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_lop] ASC,
	[ma_hoc_sinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LopOnDinh]    Script Date: 2/21/2018 11:42:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LopOnDinh](
	[ma] [char](10) NOT NULL,
	[ten] [nvarchar](255) NULL,
	[ma_khoa] [char](10) NULL,
	[ma_gv_chu_nhiem] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 2/21/2018 11:42:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MonHoc](
	[ma] [char](10) NOT NULL,
	[ten] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 2/21/2018 11:42:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[tai_khoan] [char](10) NOT NULL,
	[mat_khau] [varchar](255) NULL,
	[ten_hien_thi] [nvarchar](255) NULL,
	[url_anh] [varchar](255) NULL,
	[la_admin] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[tai_khoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[BaiViet] ON 

INSERT [dbo].[BaiViet] ([ma], [noi_dung], [do_uu_tien], [tai_khoan], [hinh_anh], [ma_danh_muc], [tieu_de]) VALUES (8, N'<p><a href="http://localhost:59671/">Báo cáo trường đạt chuẩn quốc gia</a></p>', 1, NULL, N'8.jpg', N'DM1       ', N'Báo cáo trường đạt chuẩn quốc gia')
INSERT [dbo].[BaiViet] ([ma], [noi_dung], [do_uu_tien], [tai_khoan], [hinh_anh], [ma_danh_muc], [tieu_de]) VALUES (9, N'<p><a href="http://localhost:59671/">Văn nghệ chào mừng ngày 20-11</a></p>', 2, NULL, N'9.png', N'DM2       ', N'Văn nghệ chào mừng ngày 20-11')
INSERT [dbo].[BaiViet] ([ma], [noi_dung], [do_uu_tien], [tai_khoan], [hinh_anh], [ma_danh_muc], [tieu_de]) VALUES (10, N'<p><a href="http://localhost:59671/">Mọi thông tin xin liên hệ</a></p>', 1, NULL, N'10.gif', N'DM4       ', N'Mọi thông tin xin liên hệ')
INSERT [dbo].[BaiViet] ([ma], [noi_dung], [do_uu_tien], [tai_khoan], [hinh_anh], [ma_danh_muc], [tieu_de]) VALUES (11, N'<p><a href="http://localhost:59671/">Nguyễn Văn A-Tấm gương sáng lớp 12A3</a></p>', 1, NULL, N'11.jpg', N'DM5       ', N'Nguyễn Văn A-Tấm gương sáng lớp 12A3')
INSERT [dbo].[BaiViet] ([ma], [noi_dung], [do_uu_tien], [tai_khoan], [hinh_anh], [ma_danh_muc], [tieu_de]) VALUES (12, N'<p>trường vip</p>', 2, NULL, N'12.png', N'DM1       ', N'trường VIP')
SET IDENTITY_INSERT [dbo].[BaiViet] OFF
INSERT [dbo].[DanhMuc] ([ma], [ten]) VALUES (N'DM1       ', N'Giới thiệu')
INSERT [dbo].[DanhMuc] ([ma], [ten]) VALUES (N'DM2       ', N'Tin tức')
INSERT [dbo].[DanhMuc] ([ma], [ten]) VALUES (N'DM3       ', N'Dành cho học sinh')
INSERT [dbo].[DanhMuc] ([ma], [ten]) VALUES (N'DM4       ', N'Đường dây nóng')
INSERT [dbo].[DanhMuc] ([ma], [ten]) VALUES (N'DM5       ', N'Người tốt việc tốt')
INSERT [dbo].[GiaoVien] ([ma], [ten], [ngay_sinh], [url_anh], [so_dien_thoai], [email], [ngay_vao_truong]) VALUES (N'GV001     ', N'Giáo viên 1', CAST(N'1996-11-25' AS Date), N'GV001.png', N'0966810905', N'ngoalongtb001@gmail.com', CAST(N'2000-10-20' AS Date))
INSERT [dbo].[GiaoVien] ([ma], [ten], [ngay_sinh], [url_anh], [so_dien_thoai], [email], [ngay_vao_truong]) VALUES (N'GV002     ', N'Giáo viên 2', NULL, N'GV002.png', NULL, NULL, NULL)
INSERT [dbo].[GiaoVien] ([ma], [ten], [ngay_sinh], [url_anh], [so_dien_thoai], [email], [ngay_vao_truong]) VALUES (N'luantm    ', N'luantm', CAST(N'1996-11-25' AS Date), N'luantm    .jpg', N'0966 810 905', N'luantm@localhost', CAST(N'2011-10-20' AS Date))
INSERT [dbo].[HocSinh] ([ma], [ten], [ngay_sinh], [ma_lop_on_dinh], [so_dien_thoai], [email], [url_anh], [ngay_nhap_hoc]) VALUES (N'HS01      ', N'Học sinh 1', CAST(N'1996-11-25' AS Date), N'CT01      ', N'0966 810 905', N'ngoalongtb001@gmail.com', N'HS01.png', NULL)
INSERT [dbo].[HocSinh] ([ma], [ten], [ngay_sinh], [ma_lop_on_dinh], [so_dien_thoai], [email], [url_anh], [ngay_nhap_hoc]) VALUES (N'HS02      ', N'Học sinh 2', NULL, N'CT01      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[KyHoc] ([ma], [ky_hoc], [bat_dau], [ket_thuc]) VALUES (N'KH01-2018 ', N'kỳ 1 2018', NULL, NULL)
INSERT [dbo].[KyHoc] ([ma], [ky_hoc], [bat_dau], [ket_thuc]) VALUES (N'KH2-2018  ', N'Kỳ 2 2018', CAST(N'2018-06-01' AS Date), CAST(N'2018-12-01' AS Date))
INSERT [dbo].[LopOnDinh] ([ma], [ten], [ma_khoa], [ma_gv_chu_nhiem]) VALUES (N'CT01      ', N'Chuyên toán 1', NULL, N'GV001     ')
INSERT [dbo].[MonHoc] ([ma], [ten]) VALUES (N'MH01      ', N'Toán')
INSERT [dbo].[MonHoc] ([ma], [ten]) VALUES (N'MH02      ', N'Văn')
INSERT [dbo].[MonHoc] ([ma], [ten]) VALUES (N'MH03      ', N'Anh')
INSERT [dbo].[TaiKhoan] ([tai_khoan], [mat_khau], [ten_hien_thi], [url_anh], [la_admin]) VALUES (N'GV001     ', N'admin', N'Giáo viên 1', NULL, 1)
INSERT [dbo].[TaiKhoan] ([tai_khoan], [mat_khau], [ten_hien_thi], [url_anh], [la_admin]) VALUES (N'GV002     ', N'user', N'Giáo viên 2', NULL, 0)
ALTER TABLE [dbo].[BaiViet]  WITH CHECK ADD FOREIGN KEY([ma_danh_muc])
REFERENCES [dbo].[DanhMuc] ([ma])
GO
ALTER TABLE [dbo].[BaiViet]  WITH CHECK ADD FOREIGN KEY([tai_khoan])
REFERENCES [dbo].[TaiKhoan] ([tai_khoan])
GO
ALTER TABLE [dbo].[HocSinh]  WITH CHECK ADD FOREIGN KEY([ma_lop_on_dinh])
REFERENCES [dbo].[LopOnDinh] ([ma])
GO
ALTER TABLE [dbo].[LopHoc]  WITH CHECK ADD FOREIGN KEY([ma_giao_vien])
REFERENCES [dbo].[GiaoVien] ([ma])
GO
ALTER TABLE [dbo].[LopHoc]  WITH CHECK ADD FOREIGN KEY([ma_ky_hoc])
REFERENCES [dbo].[KyHoc] ([ma])
GO
ALTER TABLE [dbo].[LopHoc]  WITH CHECK ADD FOREIGN KEY([ma_lop_on_dinh])
REFERENCES [dbo].[LopOnDinh] ([ma])
GO
ALTER TABLE [dbo].[LopHoc]  WITH CHECK ADD FOREIGN KEY([ma_mon_hoc])
REFERENCES [dbo].[MonHoc] ([ma])
GO
ALTER TABLE [dbo].[LopHocHocSinh]  WITH CHECK ADD FOREIGN KEY([ma_hoc_sinh])
REFERENCES [dbo].[HocSinh] ([ma])
GO
ALTER TABLE [dbo].[LopHocHocSinh]  WITH CHECK ADD FOREIGN KEY([ma_lop])
REFERENCES [dbo].[LopHoc] ([ma])
GO
ALTER TABLE [dbo].[LopOnDinh]  WITH CHECK ADD FOREIGN KEY([ma_gv_chu_nhiem])
REFERENCES [dbo].[GiaoVien] ([ma])
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD FOREIGN KEY([tai_khoan])
REFERENCES [dbo].[GiaoVien] ([ma])
GO
USE [master]
GO
ALTER DATABASE [QuanLyDiem] SET  READ_WRITE 
GO
