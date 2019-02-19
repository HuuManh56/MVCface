USE [master]
GO
/****** Object:  Database [sms]    Script Date: 2/19/2019 2:00:49 PM ******/
CREATE DATABASE [sms]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'sms', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\sms.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'sms_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\sms_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [sms] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [sms].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [sms] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [sms] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [sms] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [sms] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [sms] SET ARITHABORT OFF 
GO
ALTER DATABASE [sms] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [sms] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [sms] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [sms] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [sms] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [sms] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [sms] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [sms] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [sms] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [sms] SET  DISABLE_BROKER 
GO
ALTER DATABASE [sms] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [sms] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [sms] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [sms] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [sms] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [sms] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [sms] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [sms] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [sms] SET  MULTI_USER 
GO
ALTER DATABASE [sms] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [sms] SET DB_CHAINING OFF 
GO
ALTER DATABASE [sms] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [sms] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [sms] SET DELAYED_DURABILITY = DISABLED 
GO
USE [sms]
GO
/****** Object:  Table [dbo].[DiemDanh]    Script Date: 2/19/2019 2:00:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiemDanh](
	[ID] [int] NOT NULL,
	[SinhVienID] [int] NOT NULL,
	[LopHocPhanID] [int] NULL,
	[Ngay] [date] NOT NULL,
	[TinhTrang] [int] NULL,
 CONSTRAINT [PK_DiemDanh] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HocKy]    Script Date: 2/19/2019 2:00:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocKy](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenHocKy] [nvarchar](50) NULL,
	[NamBatDau] [int] NULL,
	[NamKetThuc] [int] NULL,
 CONSTRAINT [PK_HocKy] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HocPhan]    Script Date: 2/19/2019 2:00:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocPhan](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenHocPhan] [nvarchar](100) NULL,
	[SoDVHT] [int] NULL,
 CONSTRAINT [PK_HocPhan] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HocPhan_HocKy]    Script Date: 2/19/2019 2:00:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocPhan_HocKy](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HocKyID] [int] NOT NULL,
	[HocPhanID] [int] NOT NULL,
 CONSTRAINT [PK_HocPhan_HocKy_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Lop]    Script Date: 2/19/2019 2:00:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenLop] [nvarchar](100) NULL,
 CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LopHocPhan]    Script Date: 2/19/2019 2:00:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LopHocPhan](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenLopHocPhan] [nvarchar](100) NULL,
	[HocPhan_HocKyID] [int] NULL,
 CONSTRAINT [PK_LopHocPhan] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Role]    Script Date: 2/19/2019 2:00:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[ID] [int] NOT NULL,
	[NhiemVu] [nvarchar](50) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 2/19/2019 2:00:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SinhVien](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](100) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [int] NULL,
	[LopID] [int] NULL,
	[image] [binary](1000) NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SV_LHP]    Script Date: 2/19/2019 2:00:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SV_LHP](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SinhVienID] [int] NULL,
	[LopHocPhanID] [int] NULL,
	[Diem1] [decimal](2, 2) NULL,
	[Diem2] [decimal](2, 2) NULL,
	[Diem3] [decimal](2, 2) NULL,
 CONSTRAINT [PK_SV_LHP] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 2/19/2019 2:00:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NULL,
	[Password] [varchar](200) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User_Role]    Script Date: 2/19/2019 2:00:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_Role](
	[UserID] [int] NULL,
	[RoleID] [int] NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_User_Role] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Role] ([ID], [NhiemVu]) VALUES (1, N'Them')
INSERT [dbo].[Role] ([ID], [NhiemVu]) VALUES (2, N'Sua')
INSERT [dbo].[Role] ([ID], [NhiemVu]) VALUES (3, N'Xoa')
INSERT [dbo].[Role] ([ID], [NhiemVu]) VALUES (4, N'admin')
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([ID], [Username], [Password]) VALUES (1, N'xuanson', N'123')
INSERT [dbo].[User] ([ID], [Username], [Password]) VALUES (2, N'xuanson', N'123')
INSERT [dbo].[User] ([ID], [Username], [Password]) VALUES (3, N'xuanson', N'123')
INSERT [dbo].[User] ([ID], [Username], [Password]) VALUES (4, N'xuanson', N'123')
INSERT [dbo].[User] ([ID], [Username], [Password]) VALUES (5, N'xuanson', N'123')
INSERT [dbo].[User] ([ID], [Username], [Password]) VALUES (6, N'xuanson', N'123')
INSERT [dbo].[User] ([ID], [Username], [Password]) VALUES (7, N'xuanson', N'123')
INSERT [dbo].[User] ([ID], [Username], [Password]) VALUES (8, N'xuanson', N'123')
SET IDENTITY_INSERT [dbo].[User] OFF
ALTER TABLE [dbo].[DiemDanh]  WITH CHECK ADD  CONSTRAINT [FK_DiemDanh_LopHocPhan] FOREIGN KEY([LopHocPhanID])
REFERENCES [dbo].[LopHocPhan] ([ID])
GO
ALTER TABLE [dbo].[DiemDanh] CHECK CONSTRAINT [FK_DiemDanh_LopHocPhan]
GO
ALTER TABLE [dbo].[DiemDanh]  WITH CHECK ADD  CONSTRAINT [FK_DiemDanh_SinhVien] FOREIGN KEY([SinhVienID])
REFERENCES [dbo].[SinhVien] ([ID])
GO
ALTER TABLE [dbo].[DiemDanh] CHECK CONSTRAINT [FK_DiemDanh_SinhVien]
GO
ALTER TABLE [dbo].[HocPhan_HocKy]  WITH CHECK ADD  CONSTRAINT [FK_HocPhan_HocKy_HocKy] FOREIGN KEY([HocKyID])
REFERENCES [dbo].[HocKy] ([ID])
GO
ALTER TABLE [dbo].[HocPhan_HocKy] CHECK CONSTRAINT [FK_HocPhan_HocKy_HocKy]
GO
ALTER TABLE [dbo].[HocPhan_HocKy]  WITH CHECK ADD  CONSTRAINT [FK_HocPhan_HocKy_HocPhan1] FOREIGN KEY([HocPhanID])
REFERENCES [dbo].[HocPhan] ([ID])
GO
ALTER TABLE [dbo].[HocPhan_HocKy] CHECK CONSTRAINT [FK_HocPhan_HocKy_HocPhan1]
GO
ALTER TABLE [dbo].[LopHocPhan]  WITH CHECK ADD  CONSTRAINT [FK_LopHocPhan_HocPhan_HocKy] FOREIGN KEY([HocPhan_HocKyID])
REFERENCES [dbo].[HocPhan_HocKy] ([ID])
GO
ALTER TABLE [dbo].[LopHocPhan] CHECK CONSTRAINT [FK_LopHocPhan_HocPhan_HocKy]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_Lop1] FOREIGN KEY([LopID])
REFERENCES [dbo].[Lop] ([ID])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_Lop1]
GO
ALTER TABLE [dbo].[SV_LHP]  WITH CHECK ADD  CONSTRAINT [FK_SV_LHP_LopHocPhan] FOREIGN KEY([LopHocPhanID])
REFERENCES [dbo].[LopHocPhan] ([ID])
GO
ALTER TABLE [dbo].[SV_LHP] CHECK CONSTRAINT [FK_SV_LHP_LopHocPhan]
GO
ALTER TABLE [dbo].[SV_LHP]  WITH CHECK ADD  CONSTRAINT [FK_SV_LHP_SinhVien] FOREIGN KEY([SinhVienID])
REFERENCES [dbo].[SinhVien] ([ID])
GO
ALTER TABLE [dbo].[SV_LHP] CHECK CONSTRAINT [FK_SV_LHP_SinhVien]
GO
ALTER TABLE [dbo].[User_Role]  WITH CHECK ADD  CONSTRAINT [FK_User_Role_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([ID])
GO
ALTER TABLE [dbo].[User_Role] CHECK CONSTRAINT [FK_User_Role_Role]
GO
ALTER TABLE [dbo].[User_Role]  WITH CHECK ADD  CONSTRAINT [FK_User_Role_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[User_Role] CHECK CONSTRAINT [FK_User_Role_User]
GO
USE [master]
GO
ALTER DATABASE [sms] SET  READ_WRITE 
GO
