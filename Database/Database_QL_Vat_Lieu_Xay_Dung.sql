USE [master]
GO
/****** Object:  Database [QL_Vat_Lieu_Xay_Dung]    Script Date: 6/14/2020 8:00:37 PM ******/
CREATE DATABASE [QL_Vat_Lieu_Xay_Dung]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QL_Vat_Lieu_Xay_Dung', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QL_Vat_Lieu_Xay_Dung.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QL_Vat_Lieu_Xay_Dung_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QL_Vat_Lieu_Xay_Dung_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QL_Vat_Lieu_Xay_Dung] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QL_Vat_Lieu_Xay_Dung].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QL_Vat_Lieu_Xay_Dung] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QL_Vat_Lieu_Xay_Dung] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QL_Vat_Lieu_Xay_Dung] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QL_Vat_Lieu_Xay_Dung] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QL_Vat_Lieu_Xay_Dung] SET ARITHABORT OFF 
GO
ALTER DATABASE [QL_Vat_Lieu_Xay_Dung] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QL_Vat_Lieu_Xay_Dung] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QL_Vat_Lieu_Xay_Dung] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QL_Vat_Lieu_Xay_Dung] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QL_Vat_Lieu_Xay_Dung] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QL_Vat_Lieu_Xay_Dung] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QL_Vat_Lieu_Xay_Dung] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QL_Vat_Lieu_Xay_Dung] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QL_Vat_Lieu_Xay_Dung] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QL_Vat_Lieu_Xay_Dung] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QL_Vat_Lieu_Xay_Dung] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QL_Vat_Lieu_Xay_Dung] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QL_Vat_Lieu_Xay_Dung] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QL_Vat_Lieu_Xay_Dung] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QL_Vat_Lieu_Xay_Dung] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QL_Vat_Lieu_Xay_Dung] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [QL_Vat_Lieu_Xay_Dung] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QL_Vat_Lieu_Xay_Dung] SET RECOVERY FULL 
GO
ALTER DATABASE [QL_Vat_Lieu_Xay_Dung] SET  MULTI_USER 
GO
ALTER DATABASE [QL_Vat_Lieu_Xay_Dung] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QL_Vat_Lieu_Xay_Dung] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QL_Vat_Lieu_Xay_Dung] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QL_Vat_Lieu_Xay_Dung] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QL_Vat_Lieu_Xay_Dung] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QL_Vat_Lieu_Xay_Dung', N'ON'
GO
ALTER DATABASE [QL_Vat_Lieu_Xay_Dung] SET QUERY_STORE = OFF
GO
USE [QL_Vat_Lieu_Xay_Dung]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 6/14/2020 8:00:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Announcements]    Script Date: 6/14/2020 8:00:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Announcements](
	[Id] [nvarchar](450) NOT NULL,
	[Title] [nvarchar](250) NOT NULL,
	[Content] [nvarchar](250) NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[DateCreated] [datetime2](7) NOT NULL,
	[DateModified] [datetime2](7) NOT NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_Announcements] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AnnouncementUsers]    Script Date: 6/14/2020 8:00:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnnouncementUsers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[HasRead] [bit] NULL,
	[AnnouncementId] [nvarchar](450) NULL,
 CONSTRAINT [PK_AnnouncementUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppRoleClaims]    Script Date: 6/14/2020 8:00:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [uniqueidentifier] NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AppRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppRoles]    Script Date: 6/14/2020 8:00:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppRoles](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[NormalizedName] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[Description] [nvarchar](250) NULL,
 CONSTRAINT [PK_AppRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppUserClaims]    Script Date: 6/14/2020 8:00:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AppUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppUserLogins]    Script Date: 6/14/2020 8:00:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppUserLogins](
	[UserId] [uniqueidentifier] NOT NULL,
	[LoginProvider] [nvarchar](max) NULL,
	[ProviderKey] [nvarchar](max) NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
 CONSTRAINT [PK_AppUserLogins] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppUserRoles]    Script Date: 6/14/2020 8:00:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppUserRoles](
	[UserId] [uniqueidentifier] NOT NULL,
	[RoleId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_AppUserRoles] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppUsers]    Script Date: 6/14/2020 8:00:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppUsers](
	[Id] [uniqueidentifier] NOT NULL,
	[UserName] [nvarchar](max) NULL,
	[NormalizedUserName] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[NormalizedEmail] [nvarchar](max) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[FullName] [nvarchar](max) NULL,
	[BirthDay] [datetime2](7) NULL,
	[Avatar] [nvarchar](max) NULL,
	[DateCreated] [datetime2](7) NOT NULL,
	[DateModified] [datetime2](7) NOT NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_AppUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppUserTokens]    Script Date: 6/14/2020 8:00:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppUserTokens](
	[UserId] [uniqueidentifier] NOT NULL,
	[LoginProvider] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AppUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillDetails]    Script Date: 6/14/2020 8:00:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BillId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[SizeId] [int] NOT NULL,
 CONSTRAINT [PK_BillDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bills]    Script Date: 6/14/2020 8:00:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bills](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](256) NOT NULL,
	[CustomerAddress] [nvarchar](256) NOT NULL,
	[CustomerMobile] [nvarchar](256) NOT NULL,
	[CustomerMessage] [nvarchar](256) NOT NULL,
	[PaymentMethod] [int] NOT NULL,
	[BillStatus] [int] NOT NULL,
	[CustomerId] [uniqueidentifier] NOT NULL,
	[Status] [int] NOT NULL,
	[DateCreated] [datetime2](7) NOT NULL,
	[DateModified] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Bills] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContactDetails]    Script Date: 6/14/2020 8:00:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContactDetails](
	[Id] [nvarchar](255) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[Phone] [nvarchar](50) NULL,
	[Email] [nvarchar](250) NULL,
	[Website] [nvarchar](250) NULL,
	[Address] [nvarchar](250) NULL,
	[Other] [nvarchar](max) NULL,
	[Lat] [float] NULL,
	[Lng] [float] NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_ContactDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Feedbacks]    Script Date: 6/14/2020 8:00:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feedbacks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[Email] [nvarchar](250) NULL,
	[Message] [nvarchar](500) NULL,
	[Status] [int] NOT NULL,
	[DateCreated] [datetime2](7) NOT NULL,
	[DateModified] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Feedbacks] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Footers]    Script Date: 6/14/2020 8:00:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Footers](
	[Id] [varchar](255) NOT NULL,
	[Content] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Footers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Functions]    Script Date: 6/14/2020 8:00:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Functions](
	[Id] [varchar](128) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[URL] [nvarchar](250) NOT NULL,
	[ParentId] [nvarchar](128) NULL,
	[IconCss] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[SortOrder] [int] NOT NULL,
 CONSTRAINT [PK_Functions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permissions]    Script Date: 6/14/2020 8:00:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permissions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [uniqueidentifier] NOT NULL,
	[FunctionId] [varchar](128) NOT NULL,
	[CanCreate] [bit] NOT NULL,
	[CanRead] [bit] NOT NULL,
	[CanUpdate] [bit] NOT NULL,
	[CanDelete] [bit] NOT NULL,
 CONSTRAINT [PK_Permissions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductCategories]    Script Date: 6/14/2020 8:00:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductCategories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[ParentId] [int] NULL,
	[HomeOrder] [int] NULL,
	[Image] [nvarchar](max) NULL,
	[HomeFlag] [bit] NULL,
	[Status] [int] NOT NULL,
	[DateCreated] [datetime2](7) NOT NULL,
	[DateModified] [datetime2](7) NOT NULL,
	[SeoPageTitle] [nvarchar](max) NULL,
	[SeoAlias] [varchar](255) NULL,
	[SeoKeywords] [nvarchar](255) NULL,
	[SeoDescription] [nvarchar](255) NULL,
	[SortOrder] [int] NOT NULL,
 CONSTRAINT [PK_ProductCategories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductImages]    Script Date: 6/14/2020 8:00:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductImages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[Path] [nvarchar](250) NULL,
	[Caption] [nvarchar](250) NULL,
 CONSTRAINT [PK_ProductImages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductQuantities]    Script Date: 6/14/2020 8:00:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductQuantities](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[SizeId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_ProductQuantities] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 6/14/2020 8:00:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[Image] [nvarchar](255) NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[PromotionPrice] [decimal](18, 2) NULL,
	[OriginalPrice] [decimal](18, 2) NOT NULL,
	[Description] [nvarchar](255) NULL,
	[Content] [nvarchar](max) NULL,
	[HomeFlag] [bit] NULL,
	[HotFlag] [bit] NOT NULL,
	[ViewCount] [int] NULL,
	[Tags] [nvarchar](255) NULL,
	[Unit] [nvarchar](255) NULL,
	[Status] [int] NOT NULL,
	[DateCreated] [datetime2](7) NOT NULL,
	[DateModified] [datetime2](7) NOT NULL,
	[SeoPageTitle] [nvarchar](max) NULL,
	[SeoAlias] [varchar](255) NULL,
	[SeoKeywords] [nvarchar](255) NULL,
	[SeoDescription] [nvarchar](255) NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sizes]    Script Date: 6/14/2020 8:00:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sizes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NULL,
 CONSTRAINT [PK_Sizes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Slides]    Script Date: 6/14/2020 8:00:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Slides](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[Description] [nvarchar](250) NULL,
	[Image] [nvarchar](250) NOT NULL,
	[Url] [nvarchar](250) NULL,
	[DisplayOrder] [int] NULL,
	[Status] [bit] NOT NULL,
	[Content] [nvarchar](max) NULL,
	[GroupAlias] [nvarchar](25) NOT NULL,
 CONSTRAINT [PK_Slides] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SystemConfigs]    Script Date: 6/14/2020 8:00:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SystemConfigs](
	[Id] [nvarchar](255) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Value1] [nvarchar](max) NULL,
	[Value2] [int] NULL,
	[Value3] [bit] NULL,
	[Value4] [datetime2](7) NULL,
	[Value5] [decimal](18, 2) NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_SystemConfigs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tags]    Script Date: 6/14/2020 8:00:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tags](
	[Id] [varchar](50) NOT NULL,
	[ProductId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Tags] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200614114946_initial', N'3.1.4')
GO
INSERT [dbo].[AppRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp], [Description]) VALUES (N'fb1da705-3bf6-4c90-0ba0-08d810620e53', N'Admin', N'ADMIN', N'f712300d-4d79-4f5f-a555-af4e4a8a626e', N'Top manager')
INSERT [dbo].[AppRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp], [Description]) VALUES (N'570290e6-4a17-44f5-0ba1-08d810620e53', N'Staff', N'STAFF', N'2cdf6694-8ee2-4c80-9d6b-bd7df228997c', N'Staff')
INSERT [dbo].[AppRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp], [Description]) VALUES (N'013ac792-259a-43fe-0ba2-08d810620e53', N'Customer', N'CUSTOMER', N'2002cf90-6185-44c5-826d-5e3356283661', N'Customer')
GO
INSERT [dbo].[AppUserRoles] ([UserId], [RoleId]) VALUES (N'82427aca-8e02-4c27-2f51-08d810620e7b', N'fb1da705-3bf6-4c90-0ba0-08d810620e53')
GO
INSERT [dbo].[AppUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FullName], [BirthDay], [Avatar], [DateCreated], [DateModified], [Status]) VALUES (N'82427aca-8e02-4c27-2f51-08d810620e7b', N'admin', N'ADMIN', N'admin@gmail.com', N'ADMIN@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEHKe9Fr76DR736aglQXK8U+zgsnrUI/ddAB8R3S9B9RvzvjlGAYRKFxZOW5HQG3mag==', N'TA3RHSIY4BXFHZ5MFCJF3VEJOWNMKJBS', N'cb8dac82-878a-4dc1-a9bc-e9636ccc5b7a', NULL, 0, 0, NULL, 1, 0, N'Administrator', NULL, NULL, CAST(N'2020-06-14T19:54:20.7889823' AS DateTime2), CAST(N'2020-06-14T19:54:20.7905634' AS DateTime2), 1)
GO
INSERT [dbo].[Footers] ([Id], [Content]) VALUES (N'DefaultFooterId', N'Footer')
GO
INSERT [dbo].[Functions] ([Id], [Name], [URL], [ParentId], [IconCss], [Status], [SortOrder]) VALUES (N'ACCESS', N'Báo cáo truy cập', N'/admin/report/visitor', N'REPORT', N'fa-bar-chart-o', 1, 2)
INSERT [dbo].[Functions] ([Id], [Name], [URL], [ParentId], [IconCss], [Status], [SortOrder]) VALUES (N'ACTIVITY', N'Nhật ký', N'/admin/activity/index', N'SYSTEM', N'fa-home', 1, 4)
INSERT [dbo].[Functions] ([Id], [Name], [URL], [ParentId], [IconCss], [Status], [SortOrder]) VALUES (N'ANNOUNCEMENT', N'Thông báo', N'/admin/announcement/index', N'UTILITY', N'fa-clone', 1, 3)
INSERT [dbo].[Functions] ([Id], [Name], [URL], [ParentId], [IconCss], [Status], [SortOrder]) VALUES (N'BILL', N'Hóa đơn', N'/admin/bill/index', N'PRODUCT', N'fa-chevron-down', 1, 3)
INSERT [dbo].[Functions] ([Id], [Name], [URL], [ParentId], [IconCss], [Status], [SortOrder]) VALUES (N'CONTACT', N'Liên hệ', N'/admin/contact/index', N'UTILITY', N'fa-clone', 1, 4)
INSERT [dbo].[Functions] ([Id], [Name], [URL], [ParentId], [IconCss], [Status], [SortOrder]) VALUES (N'CONTENT', N'Nội dung', N'/', NULL, N'fa-table', 1, 3)
INSERT [dbo].[Functions] ([Id], [Name], [URL], [ParentId], [IconCss], [Status], [SortOrder]) VALUES (N'ERROR', N'Lỗi', N'/admin/error/index', N'SYSTEM', N'fa-home', 1, 5)
INSERT [dbo].[Functions] ([Id], [Name], [URL], [ParentId], [IconCss], [Status], [SortOrder]) VALUES (N'FEEDBACK', N'Phản hồi', N'/admin/feedback/index', N'UTILITY', N'fa-clone', 1, 2)
INSERT [dbo].[Functions] ([Id], [Name], [URL], [ParentId], [IconCss], [Status], [SortOrder]) VALUES (N'FOOTER', N'Footer', N'/admin/footer/index', N'UTILITY', N'fa-clone', 1, 1)
INSERT [dbo].[Functions] ([Id], [Name], [URL], [ParentId], [IconCss], [Status], [SortOrder]) VALUES (N'FUNCTION', N'Chức năng', N'/admin/function/index', N'SYSTEM', N'fa-home', 1, 2)
INSERT [dbo].[Functions] ([Id], [Name], [URL], [ParentId], [IconCss], [Status], [SortOrder]) VALUES (N'PRODUCT', N'Sản phẩm', N'/', NULL, N'fa-chevron-down', 1, 2)
INSERT [dbo].[Functions] ([Id], [Name], [URL], [ParentId], [IconCss], [Status], [SortOrder]) VALUES (N'PRODUCT_CATEGORY', N'Danh mục', N'/admin/productcategory/index', N'PRODUCT', N'fa-chevron-down', 1, 1)
INSERT [dbo].[Functions] ([Id], [Name], [URL], [ParentId], [IconCss], [Status], [SortOrder]) VALUES (N'PRODUCT_LIST', N'Sản phẩm', N'/admin/product/index', N'PRODUCT', N'fa-chevron-down', 1, 2)
INSERT [dbo].[Functions] ([Id], [Name], [URL], [ParentId], [IconCss], [Status], [SortOrder]) VALUES (N'REPORT', N'Báo cáo', N'/', NULL, N'fa-bar-chart-o', 1, 5)
INSERT [dbo].[Functions] ([Id], [Name], [URL], [ParentId], [IconCss], [Status], [SortOrder]) VALUES (N'REVENUES', N'Báo cáo doanh thu', N'/admin/report/revenues', N'REPORT', N'fa-bar-chart-o', 1, 1)
INSERT [dbo].[Functions] ([Id], [Name], [URL], [ParentId], [IconCss], [Status], [SortOrder]) VALUES (N'ROLE', N'Nhóm', N'/admin/role/index', N'SYSTEM', N'fa-home', 1, 1)
INSERT [dbo].[Functions] ([Id], [Name], [URL], [ParentId], [IconCss], [Status], [SortOrder]) VALUES (N'SETTING', N'Cấu hình', N'/admin/setting/index', N'SYSTEM', N'fa-home', 1, 6)
INSERT [dbo].[Functions] ([Id], [Name], [URL], [ParentId], [IconCss], [Status], [SortOrder]) VALUES (N'SLIDE', N'Slide', N'/admin/slide/index', N'UTILITY', N'fa-clone', 1, 5)
INSERT [dbo].[Functions] ([Id], [Name], [URL], [ParentId], [IconCss], [Status], [SortOrder]) VALUES (N'SYSTEM', N'Hệ thống', N'/', NULL, N'fa-desktop', 1, 1)
INSERT [dbo].[Functions] ([Id], [Name], [URL], [ParentId], [IconCss], [Status], [SortOrder]) VALUES (N'USER', N'Người dùng', N'/admin/user/index', N'SYSTEM', N'fa-home', 1, 3)
INSERT [dbo].[Functions] ([Id], [Name], [URL], [ParentId], [IconCss], [Status], [SortOrder]) VALUES (N'UTILITY', N'Tiện ích', N'/', NULL, N'fa-clone', 1, 4)
GO
/****** Object:  Index [IX_Announcements_UserId]    Script Date: 6/14/2020 8:00:38 PM ******/
CREATE NONCLUSTERED INDEX [IX_Announcements_UserId] ON [dbo].[Announcements]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AnnouncementUsers_AnnouncementId]    Script Date: 6/14/2020 8:00:38 PM ******/
CREATE NONCLUSTERED INDEX [IX_AnnouncementUsers_AnnouncementId] ON [dbo].[AnnouncementUsers]
(
	[AnnouncementId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_BillDetails_BillId]    Script Date: 6/14/2020 8:00:38 PM ******/
CREATE NONCLUSTERED INDEX [IX_BillDetails_BillId] ON [dbo].[BillDetails]
(
	[BillId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_BillDetails_ProductId]    Script Date: 6/14/2020 8:00:38 PM ******/
CREATE NONCLUSTERED INDEX [IX_BillDetails_ProductId] ON [dbo].[BillDetails]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_BillDetails_SizeId]    Script Date: 6/14/2020 8:00:38 PM ******/
CREATE NONCLUSTERED INDEX [IX_BillDetails_SizeId] ON [dbo].[BillDetails]
(
	[SizeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Bills_CustomerId]    Script Date: 6/14/2020 8:00:38 PM ******/
CREATE NONCLUSTERED INDEX [IX_Bills_CustomerId] ON [dbo].[Bills]
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Permissions_FunctionId]    Script Date: 6/14/2020 8:00:38 PM ******/
CREATE NONCLUSTERED INDEX [IX_Permissions_FunctionId] ON [dbo].[Permissions]
(
	[FunctionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Permissions_RoleId]    Script Date: 6/14/2020 8:00:38 PM ******/
CREATE NONCLUSTERED INDEX [IX_Permissions_RoleId] ON [dbo].[Permissions]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductImages_ProductId]    Script Date: 6/14/2020 8:00:38 PM ******/
CREATE NONCLUSTERED INDEX [IX_ProductImages_ProductId] ON [dbo].[ProductImages]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductQuantities_ProductId]    Script Date: 6/14/2020 8:00:38 PM ******/
CREATE NONCLUSTERED INDEX [IX_ProductQuantities_ProductId] ON [dbo].[ProductQuantities]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductQuantities_SizeId]    Script Date: 6/14/2020 8:00:38 PM ******/
CREATE NONCLUSTERED INDEX [IX_ProductQuantities_SizeId] ON [dbo].[ProductQuantities]
(
	[SizeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Products_CategoryId]    Script Date: 6/14/2020 8:00:38 PM ******/
CREATE NONCLUSTERED INDEX [IX_Products_CategoryId] ON [dbo].[Products]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Tags_ProductId]    Script Date: 6/14/2020 8:00:38 PM ******/
CREATE NONCLUSTERED INDEX [IX_Tags_ProductId] ON [dbo].[Tags]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Announcements]  WITH CHECK ADD  CONSTRAINT [FK_Announcements_AppUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AppUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Announcements] CHECK CONSTRAINT [FK_Announcements_AppUsers_UserId]
GO
ALTER TABLE [dbo].[AnnouncementUsers]  WITH CHECK ADD  CONSTRAINT [FK_AnnouncementUsers_Announcements_AnnouncementId] FOREIGN KEY([AnnouncementId])
REFERENCES [dbo].[Announcements] ([Id])
GO
ALTER TABLE [dbo].[AnnouncementUsers] CHECK CONSTRAINT [FK_AnnouncementUsers_Announcements_AnnouncementId]
GO
ALTER TABLE [dbo].[BillDetails]  WITH CHECK ADD  CONSTRAINT [FK_BillDetails_Bills_BillId] FOREIGN KEY([BillId])
REFERENCES [dbo].[Bills] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BillDetails] CHECK CONSTRAINT [FK_BillDetails_Bills_BillId]
GO
ALTER TABLE [dbo].[BillDetails]  WITH CHECK ADD  CONSTRAINT [FK_BillDetails_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BillDetails] CHECK CONSTRAINT [FK_BillDetails_Products_ProductId]
GO
ALTER TABLE [dbo].[BillDetails]  WITH CHECK ADD  CONSTRAINT [FK_BillDetails_Sizes_SizeId] FOREIGN KEY([SizeId])
REFERENCES [dbo].[Sizes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BillDetails] CHECK CONSTRAINT [FK_BillDetails_Sizes_SizeId]
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD  CONSTRAINT [FK_Bills_AppUsers_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[AppUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Bills] CHECK CONSTRAINT [FK_Bills_AppUsers_CustomerId]
GO
ALTER TABLE [dbo].[Permissions]  WITH CHECK ADD  CONSTRAINT [FK_Permissions_AppRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AppRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Permissions] CHECK CONSTRAINT [FK_Permissions_AppRoles_RoleId]
GO
ALTER TABLE [dbo].[Permissions]  WITH CHECK ADD  CONSTRAINT [FK_Permissions_Functions_FunctionId] FOREIGN KEY([FunctionId])
REFERENCES [dbo].[Functions] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Permissions] CHECK CONSTRAINT [FK_Permissions_Functions_FunctionId]
GO
ALTER TABLE [dbo].[ProductImages]  WITH CHECK ADD  CONSTRAINT [FK_ProductImages_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProductImages] CHECK CONSTRAINT [FK_ProductImages_Products_ProductId]
GO
ALTER TABLE [dbo].[ProductQuantities]  WITH CHECK ADD  CONSTRAINT [FK_ProductQuantities_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProductQuantities] CHECK CONSTRAINT [FK_ProductQuantities_Products_ProductId]
GO
ALTER TABLE [dbo].[ProductQuantities]  WITH CHECK ADD  CONSTRAINT [FK_ProductQuantities_Sizes_SizeId] FOREIGN KEY([SizeId])
REFERENCES [dbo].[Sizes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProductQuantities] CHECK CONSTRAINT [FK_ProductQuantities_Sizes_SizeId]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_ProductCategories_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[ProductCategories] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_ProductCategories_CategoryId]
GO
ALTER TABLE [dbo].[Tags]  WITH CHECK ADD  CONSTRAINT [FK_Tags_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tags] CHECK CONSTRAINT [FK_Tags_Products_ProductId]
GO
USE [master]
GO
ALTER DATABASE [QL_Vat_Lieu_Xay_Dung] SET  READ_WRITE 
GO
