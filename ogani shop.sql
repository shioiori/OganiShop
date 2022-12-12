USE [master]
GO
/****** Object:  Database [OganiShop]    Script Date: 4/12/2022 5:56:42 PM ******/
CREATE DATABASE [OganiShop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'OganiShop', FILENAME = N'F:\SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\OganiShop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'OganiShop_log', FILENAME = N'F:\SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\OganiShop_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [OganiShop] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OganiShop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OganiShop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OganiShop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OganiShop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OganiShop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OganiShop] SET ARITHABORT OFF 
GO
ALTER DATABASE [OganiShop] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [OganiShop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OganiShop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OganiShop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OganiShop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OganiShop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OganiShop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OganiShop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OganiShop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OganiShop] SET  ENABLE_BROKER 
GO
ALTER DATABASE [OganiShop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OganiShop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OganiShop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OganiShop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OganiShop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OganiShop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OganiShop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OganiShop] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [OganiShop] SET  MULTI_USER 
GO
ALTER DATABASE [OganiShop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OganiShop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OganiShop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OganiShop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [OganiShop] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [OganiShop] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [OganiShop] SET QUERY_STORE = OFF
GO
USE [OganiShop]
GO
/****** Object:  Table [dbo].[Banner]    Script Date: 4/12/2022 5:56:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Banner](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FileId] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](200) NULL,
	[UpdatedBy] [nvarchar](200) NULL,
	[Status] [int] NULL,
	[IsDeleted] [bit] NULL,
	[Type] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 4/12/2022 5:56:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NULL,
	[Slug] [varchar](200) NULL,
	[FileId] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](200) NULL,
	[UpdatedBy] [nvarchar](200) NULL,
	[Status] [int] NULL,
	[IsDeleted] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 4/12/2022 5:56:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Phone] [nvarchar](30) NULL,
	[Email] [nvarchar](50) NULL,
	[Account] [nvarchar](50) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[UpdatedBy] [nvarchar](50) NULL,
	[Status] [int] NULL,
	[IsDelete] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Discount]    Script Date: 4/12/2022 5:56:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Discount](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NULL,
	[DiscountType] [int] NULL,
	[DiscountValue] [decimal](18, 0) NOT NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](200) NULL,
	[UpdatedBy] [nvarchar](200) NULL,
	[Status] [int] NULL,
	[IsDeleted] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FileManage]    Script Date: 4/12/2022 5:56:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FileManage](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NULL,
	[FilePath] [nvarchar](200) NULL,
	[FileType] [varchar](50) NULL,
	[FileFormat] [varchar](30) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](200) NULL,
	[UpdatedBy] [nvarchar](200) NULL,
	[Status] [int] NULL,
	[IsDeleted] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manager]    Script Date: 4/12/2022 5:56:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manager](
	[Account] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NULL,
	[Role] [nvarchar](50) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](200) NULL,
	[UpdatedBy] [nvarchar](200) NULL,
	[Status] [int] NULL,
	[IsDeleted] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Account] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 4/12/2022 5:56:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[ShopOrderId] [int] NULL,
	[ProductId] [int] NULL,
	[Quantity] [int] NULL,
	[Price] [int] NULL,
	[TotalPrice] [decimal](18, 0) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](200) NULL,
	[UpdatedBy] [nvarchar](200) NULL,
	[Status] [int] NULL,
	[IsDeleted] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 4/12/2022 5:56:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NULL,
	[Slug] [varchar](200) NULL,
	[Price] [decimal](18, 0) NULL,
	[OldPrice] [decimal](18, 0) NULL,
	[Description] [nvarchar](max) NULL,
	[Summary] [nvarchar](1000) NULL,
	[Quantity] [int] NULL,
	[Weight] [float] NULL,
	[Unit] [varchar](10) NULL,
	[CategoryId] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](200) NULL,
	[UpdatedBy] [nvarchar](200) NULL,
	[Status] [int] NULL,
	[IsDeleted] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductImage]    Script Date: 4/12/2022 5:56:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductImage](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NULL,
	[FileId] [int] NULL,
	[IsAvatar] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](200) NULL,
	[UpdatedBy] [nvarchar](200) NULL,
	[Status] [int] NULL,
	[IsDeleted] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShippingAddress]    Script Date: 4/12/2022 5:56:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShippingAddress](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Account] [nvarchar](50) NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[City] [nvarchar](30) NULL,
	[Country] [nvarchar](30) NULL,
	[Phone] [nvarchar](30) NULL,
	[Postcode] [nvarchar](10) NULL,
	[Note] [nvarchar](200) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[UpdatedBy] [nvarchar](50) NULL,
	[Status] [int] NULL,
	[IsDeleted] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShopOrder]    Script Date: 4/12/2022 5:56:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShopOrder](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderStatus] [int] NULL,
	[TotalPrice] [decimal](18, 0) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](200) NULL,
	[UpdatedBy] [nvarchar](200) NULL,
	[Status] [int] NULL,
	[IsDeleted] [bit] NULL,
	[Account] [nvarchar](50) NULL,
	[AddressId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

create table CategoryBlog(
	Id int primary key identity(1,1),
	Slug nvarchar(50),
	Name nvarchar(50),
	PostQuantity int,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](200) NULL,
	[UpdatedBy] [nvarchar](200) NULL,
	[Status] [int] NULL,
	[IsDeleted] [bit] NULL
)

create table Post(
	Id int primary key identity(1,1),
	Slug nvarchar(50),
	Title nvarchar(50),
	Description nvarchar(200),
	Content nvarchar(max),
	CategoryId int FOREIGN KEY REFERENCES CategoryBlog(id),
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](200) NULL,
	[UpdatedBy] [nvarchar](200) NULL,
	[Status] [int] NULL,
	[IsDeleted] [bit] NULL
)

CREATE TABLE PostImage(
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PostId] [int] FOREIGN KEY REFERENCES Post(id),
	[FileId] [int] FOREIGN KEY REFERENCES FileManage(id),
	[IsAvatar] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](200) NULL,
	[UpdatedBy] [nvarchar](200) NULL,
	[Status] [int] NULL,
	[IsDeleted] [bit] NULL,
)

CREATE TABLE AccountImage(
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Account] NVARCHAR(50) FOREIGN KEY REFERENCES AccountManager(account),
	[FileId] [int] FOREIGN KEY REFERENCES FileManage(id),
	[IsAvatar] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](200) NULL,
	[UpdatedBy] [nvarchar](200) NULL,
	[Status] [int] NULL,
	[IsDeleted] [bit] NULL,
)

create table PostTag(
	PostId int FOREIGN KEY REFERENCES Post(id),
	TagId int FOREIGN KEY REFERENCES Tag(id),
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](200) NULL,
	[UpdatedBy] [nvarchar](200) NULL,
	[Status] [int] NULL,
	[IsDeleted] [bit] NULL,
)

create table Tag(
	Id int primary key identity(1,1),
	Slug nvarchar(50),
	Name nvarchar(50),
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](200) NULL,
	[UpdatedBy] [nvarchar](200) NULL,
	[Status] [int] NULL,
	[IsDeleted] [bit] NULL,
)
/****** Object:  Table [dbo].[ShoppingCart]    Script Date: 4/12/2022 5:56:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShoppingCart](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NULL,
	[Quantity] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](200) NULL,
	[UpdatedBy] [nvarchar](200) NULL,
	[Status] [int] NULL,
	[IsDeleted] [bit] NULL,
	[Customer] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Banner] ON 

INSERT [dbo].[Banner] ([Id], [FileId], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted], [Type]) VALUES (1, 34, CAST(N'2022-11-09T20:05:44.850' AS DateTime), CAST(N'2022-11-09T20:05:44.850' AS DateTime), N'admin', NULL, NULL, NULL, 0)
INSERT [dbo].[Banner] ([Id], [FileId], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted], [Type]) VALUES (2, 6, CAST(N'2022-11-09T20:05:44.850' AS DateTime), CAST(N'2022-11-09T20:05:44.850' AS DateTime), NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[Banner] ([Id], [FileId], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted], [Type]) VALUES (3, 7, CAST(N'2022-11-14T15:33:47.343' AS DateTime), CAST(N'2022-11-14T15:33:47.343' AS DateTime), NULL, NULL, NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[Banner] OFF
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [Name], [Slug], [FileId], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (1, N'Fresh Meat', N'fresh-meat', 60, CAST(N'2022-11-09T20:05:44.850' AS DateTime), CAST(N'2022-11-09T20:05:44.850' AS DateTime), N'admin', N'admin', 0, 0)
INSERT [dbo].[Category] ([Id], [Name], [Slug], [FileId], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (2, N'Vegetables', N'vegetables', 2, CAST(N'2022-11-09T20:05:44.850' AS DateTime), CAST(N'2022-11-09T20:05:44.850' AS DateTime), N'admin', N'admin', 0, 1)
INSERT [dbo].[Category] ([Id], [Name], [Slug], [FileId], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (3, N'Fruit & Nut Gift', N'fruit-nut-gifts', 3, CAST(N'2022-11-09T20:05:44.850' AS DateTime), CAST(N'2022-11-09T20:05:44.850' AS DateTime), N'admin', N'admin', 0, 0)
INSERT [dbo].[Category] ([Id], [Name], [Slug], [FileId], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (4, N'Fresh Berries', N'fresh-berries', 4, CAST(N'2022-11-09T20:05:44.850' AS DateTime), CAST(N'2022-11-09T20:05:44.850' AS DateTime), N'admin', N'admin', 0, 0)
INSERT [dbo].[Category] ([Id], [Name], [Slug], [FileId], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (5, N'Ocean Foods', N'ocean-foods', 5, CAST(N'2022-11-09T20:05:44.850' AS DateTime), CAST(N'2022-11-09T20:05:44.850' AS DateTime), N'admin', N'admin', 0, 0)
INSERT [dbo].[Category] ([Id], [Name], [Slug], [FileId], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (7, N'Fruit', NULL, 59, CAST(N'2022-11-27T00:25:22.900' AS DateTime), CAST(N'2022-11-27T00:25:22.930' AS DateTime), NULL, NULL, 0, 1)
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
INSERT [dbo].[Customer] ([FirstName], [LastName], [Phone], [Email], [Account], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDelete]) VALUES (N'Phùng', N'Anh', N'0973153650', N'pna7702@gmail.com', N'pna', CAST(N'2022-12-01T00:00:00.000' AS DateTime), CAST(N'2022-12-01T00:00:00.000' AS DateTime), NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Discount] ON 

INSERT [dbo].[Discount] ([Id], [ProductId], [DiscountType], [DiscountValue], [StartDate], [EndDate], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (1, 1, 1, CAST(20 AS Decimal(18, 0)), CAST(N'2022-11-29T00:00:00.000' AS DateTime), CAST(N'2022-12-30T00:00:00.000' AS DateTime), CAST(N'2022-11-29T00:00:00.000' AS DateTime), CAST(N'2022-11-29T00:00:00.000' AS DateTime), NULL, NULL, NULL, NULL)
INSERT [dbo].[Discount] ([Id], [ProductId], [DiscountType], [DiscountValue], [StartDate], [EndDate], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (2, 5, 0, CAST(2 AS Decimal(18, 0)), CAST(N'2022-11-29T00:00:00.000' AS DateTime), CAST(N'2022-12-30T00:00:00.000' AS DateTime), CAST(N'2022-11-29T00:00:00.000' AS DateTime), CAST(N'2022-11-29T00:00:00.000' AS DateTime), NULL, NULL, NULL, NULL)
INSERT [dbo].[Discount] ([Id], [ProductId], [DiscountType], [DiscountValue], [StartDate], [EndDate], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (3, 4, 1, CAST(10 AS Decimal(18, 0)), CAST(N'2022-11-29T00:00:00.000' AS DateTime), CAST(N'2022-12-30T00:00:00.000' AS DateTime), CAST(N'2022-11-29T00:00:00.000' AS DateTime), CAST(N'2022-11-29T00:00:00.000' AS DateTime), NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Discount] OFF
GO
SET IDENTITY_INSERT [dbo].[FileManage] ON 

INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (1, N'file', N'/img/categories/cat-1.jpg', N'image', NULL, CAST(N'2022-11-07T21:29:03.540' AS DateTime), CAST(N'2022-11-07T21:29:03.540' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (2, N'file', N'/img/categories/cat-2.jpg', N'image', NULL, CAST(N'2022-11-07T21:30:13.750' AS DateTime), CAST(N'2022-11-07T21:30:13.750' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (3, N'file', N'/img/categories/cat-3.jpg', N'image', NULL, CAST(N'2022-11-09T19:39:03.707' AS DateTime), CAST(N'2022-11-09T19:39:03.707' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (4, N'file', N'/img/categories/cat-4.jpg', N'image', NULL, CAST(N'2022-11-09T19:39:37.033' AS DateTime), CAST(N'2022-11-09T19:39:37.033' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (5, N'file', N'/img/categories/cat-5.jpg', N'image', NULL, CAST(N'2022-11-09T19:39:42.080' AS DateTime), CAST(N'2022-11-09T19:39:42.080' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (6, N'file', N'/img/banner/banner-1.jpg
', N'image', NULL, CAST(N'2022-11-09T19:39:51.960' AS DateTime), CAST(N'2022-11-09T19:39:51.960' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (7, N'file', N'/img/banner/banner-2.jpg', N'image', NULL, CAST(N'2022-11-09T19:41:12.540' AS DateTime), CAST(N'2022-11-09T19:41:12.540' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (8, N'file', N'/img/cart/cart-1.jpg', N'image', NULL, CAST(N'2022-11-09T19:44:35.160' AS DateTime), CAST(N'2022-11-09T19:44:35.160' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (9, N'file', N'/img/cart/cart-2.jpg', N'image', NULL, CAST(N'2022-11-09T19:47:08.257' AS DateTime), CAST(N'2022-11-09T19:47:08.257' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (10, N'file', N'/img/cart/cart-3.jpg', N'image', NULL, CAST(N'2022-11-09T19:48:31.593' AS DateTime), CAST(N'2022-11-09T19:48:31.593' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (11, N'file', N'/img/featured/feature-1.jpg', N'image', NULL, CAST(N'2022-11-09T19:49:08.573' AS DateTime), CAST(N'2022-11-09T19:49:08.577' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (12, N'file', N'/img/featured/feature-2.jpg
', N'image', NULL, CAST(N'2022-11-09T19:51:28.430' AS DateTime), CAST(N'2022-11-09T19:51:28.427' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (13, N'file', N'/img/featured/feature-3.jpg', N'image', NULL, CAST(N'2022-11-09T19:53:10.240' AS DateTime), CAST(N'2022-11-09T19:53:10.240' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (14, N'file', N'/img/featured/feature-4.jpg', N'image', NULL, CAST(N'2022-11-09T19:53:41.317' AS DateTime), CAST(N'2022-11-09T19:53:41.317' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (15, N'file', N'/img/featured/feature-5.jpg', N'image', NULL, CAST(N'2022-11-09T19:57:48.543' AS DateTime), CAST(N'2022-11-09T19:57:48.543' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (16, N'file', N'/img/featured/feature-6.jpg', N'image', NULL, CAST(N'2022-11-09T20:03:22.007' AS DateTime), CAST(N'2022-11-09T20:03:22.007' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (17, N'file', N'/img/featured/feature-7.jpg', N'image', NULL, CAST(N'2022-11-09T20:04:24.597' AS DateTime), CAST(N'2022-11-09T20:04:24.600' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (18, N'file', N'/img/featured/feature-8.jpg', N'image', NULL, CAST(N'2022-11-09T20:05:44.313' AS DateTime), CAST(N'2022-11-09T20:05:44.313' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (19, N'file', N'/img/latest-product/lp-1.jpg', N'image', NULL, CAST(N'2022-11-09T20:10:16.120' AS DateTime), CAST(N'2022-11-09T20:10:16.120' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (20, N'file', N'/img/latest-product/lp-2.jpg', N'image', NULL, CAST(N'2022-11-09T20:13:12.033' AS DateTime), CAST(N'2022-11-09T20:13:12.033' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (21, N'file', N'/img/latest-product/lp-3.jpg', N'image', NULL, CAST(N'2022-11-14T13:21:14.437' AS DateTime), CAST(N'2022-11-14T13:21:14.437' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (22, N'file', N'/img/product/product-1.jpg', N'image', NULL, CAST(N'2022-11-14T13:31:07.290' AS DateTime), CAST(N'2022-11-14T13:31:07.287' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (23, N'file', N'/img/product/product-2.jpg', N'image', NULL, CAST(N'2022-11-14T13:32:35.613' AS DateTime), CAST(N'2022-11-14T13:32:35.610' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (24, N'file', N'/img/product/product-3.jpg', N'image', NULL, CAST(N'2022-11-14T13:40:51.247' AS DateTime), CAST(N'2022-11-14T13:40:51.243' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (25, N'file', N'/img/product/product-4.jpg', N'image', NULL, CAST(N'2022-11-14T13:42:57.053' AS DateTime), CAST(N'2022-11-14T13:42:57.053' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (26, N'file', N'/img/product/product-5.jpg', N'image', NULL, CAST(N'2022-11-14T13:44:05.483' AS DateTime), CAST(N'2022-11-14T13:44:05.480' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (27, N'file', N'/img/product/product-6.jpg', N'image', NULL, CAST(N'2022-11-14T14:46:04.560' AS DateTime), CAST(N'2022-11-14T14:46:04.560' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (28, N'file', N'/img/product/product-7.jpg', N'image', NULL, CAST(N'2022-11-14T15:26:01.190' AS DateTime), CAST(N'2022-11-14T15:26:01.190' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (29, N'file', N'/img/product/product-8.jpg', N'image', NULL, CAST(N'2022-11-14T15:26:14.640' AS DateTime), CAST(N'2022-11-14T15:26:14.640' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (30, N'file', N'/img/product/product-9.jpg', N'image', NULL, CAST(N'2022-11-14T15:26:57.577' AS DateTime), CAST(N'2022-11-14T15:26:57.577' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (31, N'file', N'/img/product/product-10.jpg', N'image', NULL, CAST(N'2022-11-14T15:28:22.660' AS DateTime), CAST(N'2022-11-14T15:28:22.660' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (32, N'file', N'/img/product/product-11.jpg', N'image', NULL, CAST(N'2022-11-14T15:29:47.240' AS DateTime), CAST(N'2022-11-14T15:29:47.237' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (33, N'file', N'/img/product/product-12.jpg', N'image', NULL, CAST(N'2022-11-14T15:33:47.343' AS DateTime), CAST(N'2022-11-14T15:33:47.343' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (34, N'file', N'/img/banner/banner.jpg
', N'image', NULL, CAST(N'2022-11-14T15:33:47.343' AS DateTime), CAST(N'2022-11-14T15:33:47.343' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (35, N'file', N'/img/blog/blog-1.jpg', N'image', NULL, CAST(N'2022-11-14T15:33:47.343' AS DateTime), CAST(N'2022-11-14T15:33:47.343' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (36, N'file', N'/img/blog/blog-2.jpg', N'image', NULL, CAST(N'2022-11-14T15:33:47.343' AS DateTime), CAST(N'2022-11-14T15:33:47.343' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (37, N'file', N'/img/blog/blog-3.jpg', N'image', NULL, CAST(N'2022-11-14T15:33:47.343' AS DateTime), CAST(N'2022-11-14T15:33:47.343' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (38, N'file', N'/img/blog/blog-4.jpg', N'image', NULL, CAST(N'2022-11-14T15:33:47.343' AS DateTime), CAST(N'2022-11-14T15:33:47.343' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (39, N'file', N'/img/blog/blog-5.jpg', N'image', NULL, CAST(N'2022-11-14T15:33:47.343' AS DateTime), CAST(N'2022-11-14T15:33:47.343' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (40, N'file', N'/img/blog/blog-6.jpg', N'image', NULL, CAST(N'2022-11-14T15:33:47.343' AS DateTime), CAST(N'2022-11-14T15:33:47.343' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (41, N'file', N'/img/category/d35a8e0a-0b70-48f1-ac52-a9447d5c96e1anh7.png', N'image', NULL, CAST(N'2022-11-26T23:32:01.677' AS DateTime), CAST(N'2022-11-26T23:32:01.677' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (42, N'file', N'/img/category/84d60993-e9b6-4038-a057-8770d1565250Screenshot (18).png', N'image', NULL, CAST(N'2022-11-26T23:32:18.377' AS DateTime), CAST(N'2022-11-26T23:32:18.377' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (43, N'file', N'/img/category/95e0e89c-502a-4658-904e-b2ceaa8ce39bblog-2.jpg', N'image', NULL, CAST(N'2022-11-27T00:15:37.753' AS DateTime), CAST(N'2022-11-27T00:15:37.753' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (44, N'file', N'/img/category/9ceac93d-cb93-435f-ac0c-8125c2951d9fblog-5.jpg', N'image', NULL, CAST(N'2022-11-27T00:17:21.757' AS DateTime), CAST(N'2022-11-27T00:17:21.757' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (45, N'file', N'/img/category/49319ba8-8c2b-4b2e-ac2d-a6ffc3642be2blog-5.jpg', N'image', NULL, CAST(N'2022-11-27T00:24:51.330' AS DateTime), CAST(N'2022-11-27T00:24:51.330' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (46, N'file', N'/img/product-image/c878f4ac-1985-4f18-abf4-a46f9782385dproduct-8.jpg', N'image', NULL, CAST(N'2022-11-28T17:34:25.207' AS DateTime), CAST(N'2022-11-28T17:34:25.210' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (47, N'file', N'/img/product-image/c8f42012-85ba-46ef-b1bf-df45cbd1be3fproduct-8.jpg', N'image', NULL, CAST(N'2022-11-28T17:34:59.737' AS DateTime), CAST(N'2022-11-28T17:34:59.737' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (48, N'file', N'/img/product-image/117b0613-f3c5-470a-b96c-83758f0ddf36product-7.jpg', N'image', NULL, CAST(N'2022-11-28T19:44:46.530' AS DateTime), CAST(N'2022-11-28T19:44:46.530' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (49, N'file', N'/img/product-image/76d7c753-7fb5-4929-b102-437429dd7691product-7.jpg', N'image', NULL, CAST(N'2022-11-28T19:48:11.823' AS DateTime), CAST(N'2022-11-28T19:48:11.823' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (50, N'file', N'/img/product-image/2506e0f9-8b02-4aed-b878-f00910641c9aproduct-7.jpg', N'image', NULL, CAST(N'2022-11-28T19:51:13.363' AS DateTime), CAST(N'2022-11-28T19:51:13.363' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (51, N'file', N'/img/product-image/166e6138-c2b1-464e-a372-40437ae8f19eproduct-7.jpg', N'image', NULL, CAST(N'2022-11-28T19:52:42.870' AS DateTime), CAST(N'2022-11-28T19:52:42.870' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (52, N'file', N'/img/product-image/1e89a02b-b890-4713-9423-86b55ef98492product-3.jpg', N'image', NULL, CAST(N'2022-11-28T19:53:10.857' AS DateTime), CAST(N'2022-11-28T19:53:10.857' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (53, N'file', N'/img/product-image/ea81e77a-28f2-4e0d-891b-ac390e9ea889product-4.jpg', N'image', NULL, CAST(N'2022-11-28T19:53:30.603' AS DateTime), CAST(N'2022-11-28T19:53:30.603' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (54, N'file', N'/img/product-image/6c511b16-90b8-4cdf-8780-b7ed0df6a564product-1.jpg', N'image', NULL, CAST(N'2022-11-28T19:54:16.030' AS DateTime), CAST(N'2022-11-28T19:54:16.030' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (55, N'file', N'/img/product-image/28515cc0-b660-4c01-b15e-5a856ec967f8product-8.jpg', N'image', NULL, CAST(N'2022-11-28T19:55:52.943' AS DateTime), CAST(N'2022-11-28T19:55:52.943' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (56, N'file', N'/img/product-image/9c590846-6a33-4a46-8718-7b04a3df6949product-7.jpg', N'image', NULL, CAST(N'2022-11-28T19:56:51.000' AS DateTime), CAST(N'2022-11-28T19:56:51.000' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (57, N'file', N'/img/product-image/8236e0da-4e10-4ca0-be81-72069713b872product-12.jpg', N'image', NULL, CAST(N'2022-11-29T15:52:22.907' AS DateTime), CAST(N'2022-11-29T15:52:22.907' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (58, N'file', N'/img/product-image/295dc82b-9e2b-4812-ba79-49d215cf807bproduct-2.jpg', N'image', NULL, CAST(N'2022-11-29T15:52:50.827' AS DateTime), CAST(N'2022-11-29T15:52:50.827' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (59, N'file', N'/img/category/f79baa3e-6877-4c56-9149-727bca78f1cfcat-1.jpg', N'image', NULL, CAST(N'2022-11-29T15:53:49.910' AS DateTime), CAST(N'2022-11-29T15:53:49.910' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (60, N'file', N'/img/category/83e32f5b-0f69-4598-9169-d6160470050ccat-5.jpg', N'image', NULL, CAST(N'2022-11-29T15:53:59.287' AS DateTime), CAST(N'2022-11-29T15:53:59.287' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[FileManage] ([Id], [Name], [FilePath], [FileType], [FileFormat], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (61, N'file', N'/img/product-image/6caf5031-4a68-4dbf-9a7a-74e91435ad06cat-1.jpg', N'image', NULL, CAST(N'2022-11-29T21:10:57.503' AS DateTime), CAST(N'2022-11-29T21:10:57.503' AS DateTime), NULL, NULL, 0, 0)
SET IDENTITY_INSERT [dbo].[FileManage] OFF
GO
INSERT [dbo].[Manager] ([Account], [Password], [Role], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (N'admin', N'123', N'admin', CAST(N'2022-10-22T00:00:00.000' AS DateTime), CAST(N'2022-10-22T00:00:00.000' AS DateTime), NULL, NULL, NULL, NULL)
INSERT [dbo].[Manager] ([Account], [Password], [Role], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (N'pna', N'123', N'customer', CAST(N'2022-01-12T00:00:00.000' AS DateTime), CAST(N'2022-01-12T00:00:00.000' AS DateTime), NULL, NULL, NULL, NULL)
INSERT [dbo].[Manager] ([Account], [Password], [Role], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (N'staff', N'123', N'staff', CAST(N'2022-10-22T00:00:00.000' AS DateTime), CAST(N'2022-10-22T00:00:00.000' AS DateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[OrderDetail] ([ShopOrderId], [ProductId], [Quantity], [Price], [TotalPrice], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (1, 1, 3, 2, CAST(6 AS Decimal(18, 0)), CAST(N'2022-11-25T00:00:00.000' AS DateTime), CAST(N'2022-11-25T00:00:00.000' AS DateTime), NULL, NULL, NULL, NULL)
INSERT [dbo].[OrderDetail] ([ShopOrderId], [ProductId], [Quantity], [Price], [TotalPrice], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (1, 2, 3, 5, CAST(12 AS Decimal(18, 0)), CAST(N'2022-11-25T00:00:00.000' AS DateTime), CAST(N'2022-11-25T00:00:00.000' AS DateTime), NULL, NULL, NULL, NULL)
INSERT [dbo].[OrderDetail] ([ShopOrderId], [ProductId], [Quantity], [Price], [TotalPrice], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (2, 4, 10, 2, CAST(20 AS Decimal(18, 0)), CAST(N'2022-11-25T00:00:00.000' AS DateTime), CAST(N'2022-11-25T00:00:00.000' AS DateTime), NULL, NULL, NULL, NULL)
INSERT [dbo].[OrderDetail] ([ShopOrderId], [ProductId], [Quantity], [Price], [TotalPrice], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (2, 5, 6, 6, CAST(36 AS Decimal(18, 0)), CAST(N'2022-11-25T00:00:00.000' AS DateTime), CAST(N'2022-11-25T00:00:00.000' AS DateTime), NULL, NULL, NULL, NULL)
INSERT [dbo].[OrderDetail] ([ShopOrderId], [ProductId], [Quantity], [Price], [TotalPrice], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (3, 1, 1, 8, CAST(8 AS Decimal(18, 0)), CAST(N'2022-12-02T22:49:02.423' AS DateTime), CAST(N'2022-12-02T22:49:02.423' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[OrderDetail] ([ShopOrderId], [ProductId], [Quantity], [Price], [TotalPrice], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (3, 5, 1, 3, CAST(3 AS Decimal(18, 0)), CAST(N'2022-12-02T22:49:02.430' AS DateTime), CAST(N'2022-12-02T22:49:02.430' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[OrderDetail] ([ShopOrderId], [ProductId], [Quantity], [Price], [TotalPrice], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (4, 1, 2, 8, CAST(16 AS Decimal(18, 0)), CAST(N'2022-12-03T22:18:46.633' AS DateTime), CAST(N'2022-12-03T22:18:46.633' AS DateTime), NULL, NULL, 0, 0)
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([Id], [Name], [Slug], [Price], [OldPrice], [Description], [Summary], [Quantity], [Weight], [Unit], [CategoryId], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (1, N'Apple', NULL, CAST(10 AS Decimal(18, 0)), CAST(5 AS Decimal(18, 0)), NULL, NULL, 200, 0.6, N'kg', 2, CAST(N'2022-11-20T00:00:00.000' AS DateTime), CAST(N'2022-11-28T18:48:55.123' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[Product] ([Id], [Name], [Slug], [Price], [OldPrice], [Description], [Summary], [Quantity], [Weight], [Unit], [CategoryId], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (2, N'Grape', NULL, CAST(15 AS Decimal(18, 0)), CAST(10 AS Decimal(18, 0)), NULL, NULL, 200, 0.3, N'kg', 2, CAST(N'2022-11-20T00:00:00.000' AS DateTime), CAST(N'2022-11-20T00:00:00.000' AS DateTime), NULL, NULL, NULL, 0)
INSERT [dbo].[Product] ([Id], [Name], [Slug], [Price], [OldPrice], [Description], [Summary], [Quantity], [Weight], [Unit], [CategoryId], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (3, N'Orange', NULL, CAST(20 AS Decimal(18, 0)), CAST(15 AS Decimal(18, 0)), NULL, NULL, 200, 0.5, N'kg', 3, CAST(N'2022-11-20T00:00:00.000' AS DateTime), CAST(N'2022-11-20T00:00:00.000' AS DateTime), NULL, NULL, NULL, 0)
INSERT [dbo].[Product] ([Id], [Name], [Slug], [Price], [OldPrice], [Description], [Summary], [Quantity], [Weight], [Unit], [CategoryId], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (4, N'Egg', NULL, CAST(5 AS Decimal(18, 0)), CAST(3 AS Decimal(18, 0)), NULL, NULL, 200, 0.2, N'kg', 5, CAST(N'2022-11-20T00:00:00.000' AS DateTime), CAST(N'2022-11-20T00:00:00.000' AS DateTime), NULL, NULL, NULL, 0)
INSERT [dbo].[Product] ([Id], [Name], [Slug], [Price], [OldPrice], [Description], [Summary], [Quantity], [Weight], [Unit], [CategoryId], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (5, N'Spinach', NULL, CAST(5 AS Decimal(18, 0)), CAST(3 AS Decimal(18, 0)), NULL, NULL, 200, 0.2, N'kg', 1, CAST(N'2022-11-20T00:00:00.000' AS DateTime), CAST(N'2022-11-20T00:00:00.000' AS DateTime), NULL, NULL, NULL, 0)
INSERT [dbo].[Product] ([Id], [Name], [Slug], [Price], [OldPrice], [Description], [Summary], [Quantity], [Weight], [Unit], [CategoryId], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (6, N'Carrot', NULL, CAST(10 AS Decimal(18, 0)), CAST(8 AS Decimal(18, 0)), NULL, NULL, 200, 0.3, N'kg', 1, CAST(N'2022-11-20T00:00:00.000' AS DateTime), CAST(N'2022-11-20T00:00:00.000' AS DateTime), NULL, NULL, NULL, 0)
INSERT [dbo].[Product] ([Id], [Name], [Slug], [Price], [OldPrice], [Description], [Summary], [Quantity], [Weight], [Unit], [CategoryId], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (11, N'Watermelon', NULL, CAST(20 AS Decimal(18, 0)), CAST(10 AS Decimal(18, 0)), NULL, NULL, 100, 2.3, N'kg', 3, CAST(N'2022-11-28T19:52:55.957' AS DateTime), CAST(N'2022-11-28T19:52:55.957' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[Product] ([Id], [Name], [Slug], [Price], [OldPrice], [Description], [Summary], [Quantity], [Weight], [Unit], [CategoryId], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (14, N'Chuỗi đẹp', NULL, CAST(10000 AS Decimal(18, 0)), CAST(5 AS Decimal(18, 0)), NULL, N'Dưa hấu nhập từ Long Biên', 5, 1, N'1', 1, CAST(N'2022-11-28T19:56:53.363' AS DateTime), CAST(N'2022-11-28T19:56:53.363' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Product] ([Id], [Name], [Slug], [Price], [OldPrice], [Description], [Summary], [Quantity], [Weight], [Unit], [CategoryId], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (15, N'Banana', NULL, CAST(20 AS Decimal(18, 0)), CAST(10 AS Decimal(18, 0)), NULL, NULL, 100, 1.3, N'kg', 4, CAST(N'2022-11-29T15:53:12.563' AS DateTime), CAST(N'2022-11-29T15:53:12.563' AS DateTime), NULL, NULL, 0, 0)
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductImage] ON 

INSERT [dbo].[ProductImage] ([Id], [ProductId], [FileId], [IsAvatar], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (1, 1, 22, 0, CAST(N'2022-11-22T00:00:00.000' AS DateTime), CAST(N'2022-11-28T14:54:39.593' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[ProductImage] ([Id], [ProductId], [FileId], [IsAvatar], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (2, 2, 23, 0, CAST(N'2022-11-22T00:00:00.000' AS DateTime), CAST(N'2022-11-28T19:53:35.460' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[ProductImage] ([Id], [ProductId], [FileId], [IsAvatar], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (3, 3, 24, 0, CAST(N'2022-11-22T00:00:00.000' AS DateTime), CAST(N'2022-11-29T15:52:28.130' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[ProductImage] ([Id], [ProductId], [FileId], [IsAvatar], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (4, 4, 25, 0, CAST(N'2022-11-22T00:00:00.000' AS DateTime), CAST(N'2022-11-28T14:55:47.503' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[ProductImage] ([Id], [ProductId], [FileId], [IsAvatar], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (5, 5, 26, 0, CAST(N'2022-11-22T00:00:00.000' AS DateTime), CAST(N'2022-11-28T14:48:54.500' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[ProductImage] ([Id], [ProductId], [FileId], [IsAvatar], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (6, 1, 27, 0, CAST(N'2022-11-22T00:00:00.000' AS DateTime), CAST(N'2022-11-29T21:10:52.547' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[ProductImage] ([Id], [ProductId], [FileId], [IsAvatar], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (7, 1, 28, 0, CAST(N'2022-11-22T00:00:00.000' AS DateTime), CAST(N'2022-11-28T17:35:27.187' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[ProductImage] ([Id], [ProductId], [FileId], [IsAvatar], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (8, 2, 29, 0, CAST(N'2022-11-22T00:00:00.000' AS DateTime), CAST(N'2022-11-28T14:57:43.287' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[ProductImage] ([Id], [ProductId], [FileId], [IsAvatar], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (9, 5, 30, 1, CAST(N'2022-11-22T00:00:00.000' AS DateTime), CAST(N'2022-11-28T14:48:54.527' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[ProductImage] ([Id], [ProductId], [FileId], [IsAvatar], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (10, 4, 31, 1, CAST(N'2022-11-22T00:00:00.000' AS DateTime), CAST(N'2022-11-28T14:55:47.527' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[ProductImage] ([Id], [ProductId], [FileId], [IsAvatar], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (11, 1, 47, 1, CAST(N'2022-11-28T17:35:19.600' AS DateTime), CAST(N'2022-11-29T21:10:52.553' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[ProductImage] ([Id], [ProductId], [FileId], [IsAvatar], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (13, 1, 47, 0, CAST(N'2022-11-28T18:48:55.207' AS DateTime), CAST(N'2022-11-29T21:10:43.517' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[ProductImage] ([Id], [ProductId], [FileId], [IsAvatar], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (16, 11, 51, 1, CAST(N'2022-11-28T19:52:56.007' AS DateTime), CAST(N'2022-11-28T19:53:19.310' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[ProductImage] ([Id], [ProductId], [FileId], [IsAvatar], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (17, 11, 52, 0, CAST(N'2022-11-28T19:53:11.950' AS DateTime), CAST(N'2022-11-28T19:53:19.307' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[ProductImage] ([Id], [ProductId], [FileId], [IsAvatar], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (18, 2, 53, 1, CAST(N'2022-11-28T19:53:31.643' AS DateTime), CAST(N'2022-11-28T19:53:35.460' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[ProductImage] ([Id], [ProductId], [FileId], [IsAvatar], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (19, 14, 56, 1, CAST(N'2022-11-28T19:56:53.400' AS DateTime), CAST(N'2022-11-28T19:56:53.400' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[ProductImage] ([Id], [ProductId], [FileId], [IsAvatar], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (20, 3, 57, 1, CAST(N'2022-11-29T15:52:24.323' AS DateTime), CAST(N'2022-11-29T15:52:28.137' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[ProductImage] ([Id], [ProductId], [FileId], [IsAvatar], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (21, 15, 58, 1, CAST(N'2022-11-29T15:53:12.613' AS DateTime), CAST(N'2022-11-29T15:53:12.613' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[ProductImage] ([Id], [ProductId], [FileId], [IsAvatar], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (22, 1, 61, 0, CAST(N'2022-11-29T21:10:58.847' AS DateTime), CAST(N'2022-11-29T21:10:58.847' AS DateTime), NULL, NULL, 0, 0)
SET IDENTITY_INSERT [dbo].[ProductImage] OFF
GO
SET IDENTITY_INSERT [dbo].[ShippingAddress] ON 

INSERT [dbo].[ShippingAddress] ([Id], [Account], [FirstName], [LastName], [Address], [City], [Country], [Phone], [Postcode], [Note], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (2, N'pna', N'Phùng', N'Ngọc Anh', N'Ngõ 1194 Đường Láng', N'Hà Nội', N'Việt Nam', N'(+84) 971037465', N'100000', NULL, CAST(N'2022-12-02T22:48:59.730' AS DateTime), CAST(N'2022-12-02T22:48:59.733' AS DateTime), N'pna', N'pna', 0, 0)
INSERT [dbo].[ShippingAddress] ([Id], [Account], [FirstName], [LastName], [Address], [City], [Country], [Phone], [Postcode], [Note], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted]) VALUES (3, N'c7e66bde-d4e3-4296-829c-3b816f1d04ca', N'Táo', NULL, N'Láng Thượng, Đống Đa, Hà Nội, Việt Nam', N'Hà Nội', N'Việt Nam', N'(+84) 971037465', N'100000', NULL, CAST(N'2022-12-03T22:18:46.540' AS DateTime), CAST(N'2022-12-03T22:18:46.540' AS DateTime), N'c7e66bde-d4e3-4296-829c-3b816f1d04ca', N'c7e66bde-d4e3-4296-829c-3b816f1d04ca', 0, 0)
SET IDENTITY_INSERT [dbo].[ShippingAddress] OFF
GO
SET IDENTITY_INSERT [dbo].[ShopOrder] ON 

INSERT [dbo].[ShopOrder] ([Id], [OrderStatus], [TotalPrice], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted], [Account], [AddressId]) VALUES (1, 1, CAST(100 AS Decimal(18, 0)), CAST(N'2022-11-25T00:00:00.000' AS DateTime), CAST(N'2022-11-25T00:00:00.000' AS DateTime), NULL, NULL, NULL, 1, NULL, NULL)
INSERT [dbo].[ShopOrder] ([Id], [OrderStatus], [TotalPrice], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted], [Account], [AddressId]) VALUES (2, 1, CAST(56 AS Decimal(18, 0)), CAST(N'2022-11-25T00:00:00.000' AS DateTime), CAST(N'2022-11-25T00:00:00.000' AS DateTime), NULL, NULL, NULL, 1, NULL, NULL)
INSERT [dbo].[ShopOrder] ([Id], [OrderStatus], [TotalPrice], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted], [Account], [AddressId]) VALUES (3, 1, CAST(11 AS Decimal(18, 0)), CAST(N'2022-12-02T22:49:02.403' AS DateTime), CAST(N'2022-12-02T22:49:02.403' AS DateTime), NULL, NULL, 0, 0, N'pna', 2)
INSERT [dbo].[ShopOrder] ([Id], [OrderStatus], [TotalPrice], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted], [Account], [AddressId]) VALUES (4, 1, CAST(16 AS Decimal(18, 0)), CAST(N'2022-12-03T22:18:46.610' AS DateTime), CAST(N'2022-12-03T22:18:46.610' AS DateTime), NULL, NULL, 0, 0, N'c7e66bde-d4e3-4296-829c-3b816f1d04ca', 3)
SET IDENTITY_INSERT [dbo].[ShopOrder] OFF
GO
SET IDENTITY_INSERT [dbo].[ShoppingCart] ON 

INSERT [dbo].[ShoppingCart] ([Id], [ProductId], [Quantity], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted], [Customer]) VALUES (1, 5, 2, CAST(N'2022-12-01T16:35:46.247' AS DateTime), CAST(N'2022-12-01T16:42:53.743' AS DateTime), NULL, NULL, 0, 0, N'9bc53a90-ec85-46ff-9a74-0c02c04d2f29')
INSERT [dbo].[ShoppingCart] ([Id], [ProductId], [Quantity], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted], [Customer]) VALUES (2, 4, 1, CAST(N'2022-12-01T16:39:50.047' AS DateTime), CAST(N'2022-12-01T16:39:50.073' AS DateTime), NULL, NULL, 0, 0, N'9bc53a90-ec85-46ff-9a74-0c02c04d2f29')
INSERT [dbo].[ShoppingCart] ([Id], [ProductId], [Quantity], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted], [Customer]) VALUES (4, 1, 1, CAST(N'2022-12-01T16:44:44.137' AS DateTime), CAST(N'2022-12-01T16:44:44.140' AS DateTime), NULL, NULL, 0, 0, N'9bc53a90-ec85-46ff-9a74-0c02c04d2f29')
INSERT [dbo].[ShoppingCart] ([Id], [ProductId], [Quantity], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted], [Customer]) VALUES (5, 5, 1, CAST(N'2022-12-01T18:23:25.277' AS DateTime), CAST(N'2022-12-01T18:23:25.277' AS DateTime), NULL, NULL, 0, 0, N'fa055efa-21bd-405c-a375-8edffb02123f')
INSERT [dbo].[ShoppingCart] ([Id], [ProductId], [Quantity], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted], [Customer]) VALUES (6, 5, 1, CAST(N'2022-12-01T19:05:31.967' AS DateTime), CAST(N'2022-12-01T19:05:31.967' AS DateTime), NULL, NULL, 0, 0, N'admin')
INSERT [dbo].[ShoppingCart] ([Id], [ProductId], [Quantity], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted], [Customer]) VALUES (7, 1, 1, CAST(N'2022-12-01T21:19:26.887' AS DateTime), CAST(N'2022-12-01T21:19:26.887' AS DateTime), NULL, NULL, 1, 0, N'pna')
INSERT [dbo].[ShoppingCart] ([Id], [ProductId], [Quantity], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted], [Customer]) VALUES (8, 5, 1, CAST(N'2022-12-02T22:44:04.967' AS DateTime), CAST(N'2022-12-02T22:44:04.970' AS DateTime), NULL, NULL, 1, 0, N'pna')
INSERT [dbo].[ShoppingCart] ([Id], [ProductId], [Quantity], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted], [Customer]) VALUES (9, 1, 5, CAST(N'2022-12-03T21:28:47.263' AS DateTime), CAST(N'2022-12-03T22:47:56.130' AS DateTime), NULL, NULL, 0, 0, N'c7e66bde-d4e3-4296-829c-3b816f1d04ca')
INSERT [dbo].[ShoppingCart] ([Id], [ProductId], [Quantity], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted], [Customer]) VALUES (10, 4, 4, CAST(N'2022-12-03T22:26:40.773' AS DateTime), CAST(N'2022-12-03T22:48:38.100' AS DateTime), NULL, NULL, 0, 0, N'c7e66bde-d4e3-4296-829c-3b816f1d04ca')
INSERT [dbo].[ShoppingCart] ([Id], [ProductId], [Quantity], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted], [Customer]) VALUES (11, 5, 5, CAST(N'2022-12-03T22:26:46.333' AS DateTime), CAST(N'2022-12-03T22:51:30.120' AS DateTime), NULL, NULL, 0, 0, N'c7e66bde-d4e3-4296-829c-3b816f1d04ca')
INSERT [dbo].[ShoppingCart] ([Id], [ProductId], [Quantity], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted], [Customer]) VALUES (15, 1, 5, CAST(N'2022-12-04T13:29:55.943' AS DateTime), CAST(N'2022-12-04T14:01:29.047' AS DateTime), NULL, NULL, 0, 0, N'pna')
INSERT [dbo].[ShoppingCart] ([Id], [ProductId], [Quantity], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted], [Customer]) VALUES (16, 4, 10, CAST(N'2022-12-04T13:30:00.943' AS DateTime), CAST(N'2022-12-04T14:16:21.527' AS DateTime), NULL, NULL, 0, 0, N'pna')
INSERT [dbo].[ShoppingCart] ([Id], [ProductId], [Quantity], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted], [Customer]) VALUES (17, 2, 2, CAST(N'2022-12-04T14:28:33.993' AS DateTime), CAST(N'2022-12-04T14:40:21.740' AS DateTime), NULL, NULL, 0, 0, N'pna')
INSERT [dbo].[ShoppingCart] ([Id], [ProductId], [Quantity], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted], [Customer]) VALUES (18, 15, 2, CAST(N'2022-12-04T14:28:44.690' AS DateTime), CAST(N'2022-12-04T14:40:18.530' AS DateTime), NULL, NULL, 0, 0, N'pna')
INSERT [dbo].[ShoppingCart] ([Id], [ProductId], [Quantity], [CreatedDate], [UpdatedDate], [CreatedBy], [UpdatedBy], [Status], [IsDeleted], [Customer]) VALUES (19, 11, 2, CAST(N'2022-12-04T14:28:48.793' AS DateTime), CAST(N'2022-12-04T14:40:18.993' AS DateTime), NULL, NULL, 0, 0, N'pna')
SET IDENTITY_INSERT [dbo].[ShoppingCart] OFF
GO
ALTER TABLE [dbo].[Banner]  WITH CHECK ADD FOREIGN KEY([FileId])
REFERENCES [dbo].[FileManage] ([Id])
GO
ALTER TABLE [dbo].[Category]  WITH CHECK ADD FOREIGN KEY([FileId])
REFERENCES [dbo].[FileManage] ([Id])
GO
ALTER TABLE [dbo].[Discount]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD FOREIGN KEY([ShopOrderId])
REFERENCES [dbo].[ShopOrder] ([Id])
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[ProductImage]  WITH CHECK ADD FOREIGN KEY([FileId])
REFERENCES [dbo].[FileManage] ([Id])
GO
ALTER TABLE [dbo].[ProductImage]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
GO
ALTER TABLE [dbo].[ShoppingCart]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
GO
USE [master]
GO
ALTER DATABASE [OganiShop] SET  READ_WRITE 
GO
