USE [master]
GO
/****** Object:  Database [Fastfood]    Script Date: 29.12.2023 10:10:48 ******/
CREATE DATABASE [Fastfood]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Fastfood', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Fastfood.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Fastfood_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Fastfood_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Fastfood] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Fastfood].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Fastfood] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Fastfood] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Fastfood] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Fastfood] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Fastfood] SET ARITHABORT OFF 
GO
ALTER DATABASE [Fastfood] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Fastfood] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Fastfood] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Fastfood] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Fastfood] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Fastfood] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Fastfood] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Fastfood] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Fastfood] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Fastfood] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Fastfood] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Fastfood] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Fastfood] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Fastfood] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Fastfood] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Fastfood] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Fastfood] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Fastfood] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Fastfood] SET  MULTI_USER 
GO
ALTER DATABASE [Fastfood] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Fastfood] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Fastfood] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Fastfood] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Fastfood] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Fastfood] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Fastfood] SET QUERY_STORE = ON
GO
ALTER DATABASE [Fastfood] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Fastfood]
GO
/****** Object:  Table [dbo].[Kategorie]    Script Date: 29.12.2023 10:10:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kategorie](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nazwa] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Kategorie] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 29.12.2023 10:10:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nazwa] [nvarchar](50) NOT NULL,
	[Kategoria] [int] NOT NULL,
	[Cena] [numeric](5, 2) NOT NULL,
	[Zdjecie] [nvarchar](100) NOT NULL,
	[Dostepnosc] [bit] NOT NULL,
 CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SzczegolyZamowienia]    Script Date: 29.12.2023 10:10:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SzczegolyZamowienia](
	[ZamowienieID] [int] NOT NULL,
	[ProduktID] [int] NOT NULL,
	[Ilosc] [int] NOT NULL,
	[Przygotowane] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Uzytkownicy]    Script Date: 29.12.2023 10:10:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Uzytkownicy](
	[Login] [nvarchar](30) NOT NULL,
	[Haslo] [nvarchar](30) NOT NULL,
	[Rola] [int] NOT NULL,
 CONSTRAINT [PK_Uzytkownicy] PRIMARY KEY CLUSTERED 
(
	[Login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zamowienia]    Script Date: 29.12.2023 10:10:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zamowienia](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Data] [date] NOT NULL,
	[Godzina] [time](7) NOT NULL,
	[NaWynos] [bit] NOT NULL,
	[Zrealizowano] [bit] NOT NULL,
 CONSTRAINT [PK_Zamowienia] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Kategorie] ON 

INSERT [dbo].[Kategorie] ([ID], [Nazwa]) VALUES (1, N'Burgery')
INSERT [dbo].[Kategorie] ([ID], [Nazwa]) VALUES (2, N'Kawałki kurczaka')
INSERT [dbo].[Kategorie] ([ID], [Nazwa]) VALUES (3, N'Wrapy')
INSERT [dbo].[Kategorie] ([ID], [Nazwa]) VALUES (4, N'Zestawy')
INSERT [dbo].[Kategorie] ([ID], [Nazwa]) VALUES (5, N'Shakes')
INSERT [dbo].[Kategorie] ([ID], [Nazwa]) VALUES (6, N'Zimne napoje')
INSERT [dbo].[Kategorie] ([ID], [Nazwa]) VALUES (7, N'Lody')
SET IDENTITY_INSERT [dbo].[Kategorie] OFF
GO
SET IDENTITY_INSERT [dbo].[Menu] ON 

INSERT [dbo].[Menu] ([ID], [Nazwa], [Kategoria], [Cena], [Zdjecie], [Dostepnosc]) VALUES (1, N'Grand Mac', 1, CAST(23.00 AS Numeric(5, 2)), N'grandMac.png', 1)
INSERT [dbo].[Menu] ([ID], [Nazwa], [Kategoria], [Cena], [Zdjecie], [Dostepnosc]) VALUES (2, N'Double Grand Mac', 1, CAST(28.00 AS Numeric(5, 2)), N'doubleGrandMac.png', 1)
INSERT [dbo].[Menu] ([ID], [Nazwa], [Kategoria], [Cena], [Zdjecie], [Dostepnosc]) VALUES (3, N'Zing King', 1, CAST(20.00 AS Numeric(5, 2)), N'zingKing.png', 1)
INSERT [dbo].[Menu] ([ID], [Nazwa], [Kategoria], [Cena], [Zdjecie], [Dostepnosc]) VALUES (4, N'Cheeseburger', 1, CAST(12.00 AS Numeric(5, 2)), N'cheeseburger.png', 1)
INSERT [dbo].[Menu] ([ID], [Nazwa], [Kategoria], [Cena], [Zdjecie], [Dostepnosc]) VALUES (5, N'MacBingKing', 1, CAST(25.00 AS Numeric(5, 2)), N'MacBigKing.png', 1)
INSERT [dbo].[Menu] ([ID], [Nazwa], [Kategoria], [Cena], [Zdjecie], [Dostepnosc]) VALUES (6, N'Triple MacKing', 1, CAST(35.00 AS Numeric(5, 2)), N'tripleMacKing.png', 1)
INSERT [dbo].[Menu] ([ID], [Nazwa], [Kategoria], [Cena], [Zdjecie], [Dostepnosc]) VALUES (7, N'MacKing Of Kings', 1, CAST(79.99 AS Numeric(5, 2)), N'gigaMegaFatMacKingOfKings.png', 1)
INSERT [dbo].[Menu] ([ID], [Nazwa], [Kategoria], [Cena], [Zdjecie], [Dostepnosc]) VALUES (8, N'p4k1', 1, CAST(1.00 AS Numeric(5, 2)), N'a.jpg', 1)
INSERT [dbo].[Menu] ([ID], [Nazwa], [Kategoria], [Cena], [Zdjecie], [Dostepnosc]) VALUES (9, N'p5k1', 1, CAST(1.00 AS Numeric(5, 2)), N'a.jpg', 1)
INSERT [dbo].[Menu] ([ID], [Nazwa], [Kategoria], [Cena], [Zdjecie], [Dostepnosc]) VALUES (10, N'p6k1', 1, CAST(1.00 AS Numeric(5, 2)), N'a.jpg', 1)
INSERT [dbo].[Menu] ([ID], [Nazwa], [Kategoria], [Cena], [Zdjecie], [Dostepnosc]) VALUES (11, N'p7k1', 1, CAST(1.00 AS Numeric(5, 2)), N'a.jpg', 1)
INSERT [dbo].[Menu] ([ID], [Nazwa], [Kategoria], [Cena], [Zdjecie], [Dostepnosc]) VALUES (12, N'p8k1', 1, CAST(1.00 AS Numeric(5, 2)), N'a.jpg', 1)
INSERT [dbo].[Menu] ([ID], [Nazwa], [Kategoria], [Cena], [Zdjecie], [Dostepnosc]) VALUES (13, N'p9k1', 1, CAST(1.00 AS Numeric(5, 2)), N'a.jpg', 1)
INSERT [dbo].[Menu] ([ID], [Nazwa], [Kategoria], [Cena], [Zdjecie], [Dostepnosc]) VALUES (14, N'a', 1, CAST(1.10 AS Numeric(5, 2)), N'a', 0)
INSERT [dbo].[Menu] ([ID], [Nazwa], [Kategoria], [Cena], [Zdjecie], [Dostepnosc]) VALUES (17, N'a', 1, CAST(12.00 AS Numeric(5, 2)), N'a', 0)
INSERT [dbo].[Menu] ([ID], [Nazwa], [Kategoria], [Cena], [Zdjecie], [Dostepnosc]) VALUES (18, N'a', 1, CAST(12.12 AS Numeric(5, 2)), N'a', 0)
INSERT [dbo].[Menu] ([ID], [Nazwa], [Kategoria], [Cena], [Zdjecie], [Dostepnosc]) VALUES (20, N'a', 1, CAST(12.12 AS Numeric(5, 2)), N'a', 0)
INSERT [dbo].[Menu] ([ID], [Nazwa], [Kategoria], [Cena], [Zdjecie], [Dostepnosc]) VALUES (21, N'a', 1, CAST(12.12 AS Numeric(5, 2)), N'a', 0)
INSERT [dbo].[Menu] ([ID], [Nazwa], [Kategoria], [Cena], [Zdjecie], [Dostepnosc]) VALUES (22, N'a', 1, CAST(12.00 AS Numeric(5, 2)), N'a', 0)
INSERT [dbo].[Menu] ([ID], [Nazwa], [Kategoria], [Cena], [Zdjecie], [Dostepnosc]) VALUES (23, N'a', 7, CAST(12.00 AS Numeric(5, 2)), N'a', 0)
SET IDENTITY_INSERT [dbo].[Menu] OFF
GO
INSERT [dbo].[SzczegolyZamowienia] ([ZamowienieID], [ProduktID], [Ilosc], [Przygotowane]) VALUES (14, 1, 1, 0)
INSERT [dbo].[SzczegolyZamowienia] ([ZamowienieID], [ProduktID], [Ilosc], [Przygotowane]) VALUES (14, 13, 1, 0)
INSERT [dbo].[SzczegolyZamowienia] ([ZamowienieID], [ProduktID], [Ilosc], [Przygotowane]) VALUES (14, 6, 1, 0)
INSERT [dbo].[SzczegolyZamowienia] ([ZamowienieID], [ProduktID], [Ilosc], [Przygotowane]) VALUES (15, 6, 1, 0)
INSERT [dbo].[SzczegolyZamowienia] ([ZamowienieID], [ProduktID], [Ilosc], [Przygotowane]) VALUES (15, 1, 1, 0)
INSERT [dbo].[SzczegolyZamowienia] ([ZamowienieID], [ProduktID], [Ilosc], [Przygotowane]) VALUES (16, 1, 2, 0)
INSERT [dbo].[SzczegolyZamowienia] ([ZamowienieID], [ProduktID], [Ilosc], [Przygotowane]) VALUES (16, 10, 1, 0)
INSERT [dbo].[SzczegolyZamowienia] ([ZamowienieID], [ProduktID], [Ilosc], [Przygotowane]) VALUES (16, 7, 5, 0)
INSERT [dbo].[SzczegolyZamowienia] ([ZamowienieID], [ProduktID], [Ilosc], [Przygotowane]) VALUES (1016, 3, 4, 0)
INSERT [dbo].[SzczegolyZamowienia] ([ZamowienieID], [ProduktID], [Ilosc], [Przygotowane]) VALUES (1016, 2, 4, 0)
INSERT [dbo].[SzczegolyZamowienia] ([ZamowienieID], [ProduktID], [Ilosc], [Przygotowane]) VALUES (1016, 6, 1, 0)
INSERT [dbo].[SzczegolyZamowienia] ([ZamowienieID], [ProduktID], [Ilosc], [Przygotowane]) VALUES (1017, 1, 1, 1)
INSERT [dbo].[SzczegolyZamowienia] ([ZamowienieID], [ProduktID], [Ilosc], [Przygotowane]) VALUES (1018, 7, 9, 1)
INSERT [dbo].[SzczegolyZamowienia] ([ZamowienieID], [ProduktID], [Ilosc], [Przygotowane]) VALUES (1019, 7, 1, 1)
INSERT [dbo].[SzczegolyZamowienia] ([ZamowienieID], [ProduktID], [Ilosc], [Przygotowane]) VALUES (1019, 6, 1, 1)
INSERT [dbo].[SzczegolyZamowienia] ([ZamowienieID], [ProduktID], [Ilosc], [Przygotowane]) VALUES (1020, 7, 1, 1)
INSERT [dbo].[SzczegolyZamowienia] ([ZamowienieID], [ProduktID], [Ilosc], [Przygotowane]) VALUES (1021, 6, 1, 1)
INSERT [dbo].[SzczegolyZamowienia] ([ZamowienieID], [ProduktID], [Ilosc], [Przygotowane]) VALUES (1021, 7, 99, 1)
INSERT [dbo].[SzczegolyZamowienia] ([ZamowienieID], [ProduktID], [Ilosc], [Przygotowane]) VALUES (2016, 7, 1, 1)
INSERT [dbo].[SzczegolyZamowienia] ([ZamowienieID], [ProduktID], [Ilosc], [Przygotowane]) VALUES (2017, 2, 7, 0)
INSERT [dbo].[SzczegolyZamowienia] ([ZamowienieID], [ProduktID], [Ilosc], [Przygotowane]) VALUES (2017, 7, 5, 0)
INSERT [dbo].[SzczegolyZamowienia] ([ZamowienieID], [ProduktID], [Ilosc], [Przygotowane]) VALUES (2018, 6, 1, 0)
INSERT [dbo].[SzczegolyZamowienia] ([ZamowienieID], [ProduktID], [Ilosc], [Przygotowane]) VALUES (16, 8, 1, 0)
INSERT [dbo].[SzczegolyZamowienia] ([ZamowienieID], [ProduktID], [Ilosc], [Przygotowane]) VALUES (16, 11, 1, 0)
INSERT [dbo].[SzczegolyZamowienia] ([ZamowienieID], [ProduktID], [Ilosc], [Przygotowane]) VALUES (16, 3, 1, 0)
INSERT [dbo].[SzczegolyZamowienia] ([ZamowienieID], [ProduktID], [Ilosc], [Przygotowane]) VALUES (16, 6, 1, 0)
INSERT [dbo].[SzczegolyZamowienia] ([ZamowienieID], [ProduktID], [Ilosc], [Przygotowane]) VALUES (1022, 6, 3, 1)
INSERT [dbo].[SzczegolyZamowienia] ([ZamowienieID], [ProduktID], [Ilosc], [Przygotowane]) VALUES (2019, 1, 1, 0)
INSERT [dbo].[SzczegolyZamowienia] ([ZamowienieID], [ProduktID], [Ilosc], [Przygotowane]) VALUES (2020, 1, 1, 0)
INSERT [dbo].[SzczegolyZamowienia] ([ZamowienieID], [ProduktID], [Ilosc], [Przygotowane]) VALUES (2021, 7, 1, 0)
INSERT [dbo].[SzczegolyZamowienia] ([ZamowienieID], [ProduktID], [Ilosc], [Przygotowane]) VALUES (2022, 1, 1, 0)
INSERT [dbo].[SzczegolyZamowienia] ([ZamowienieID], [ProduktID], [Ilosc], [Przygotowane]) VALUES (2023, 3, 1, 0)
INSERT [dbo].[SzczegolyZamowienia] ([ZamowienieID], [ProduktID], [Ilosc], [Przygotowane]) VALUES (2024, 2, 1, 0)
INSERT [dbo].[SzczegolyZamowienia] ([ZamowienieID], [ProduktID], [Ilosc], [Przygotowane]) VALUES (2024, 4, 2, 0)
INSERT [dbo].[SzczegolyZamowienia] ([ZamowienieID], [ProduktID], [Ilosc], [Przygotowane]) VALUES (2024, 3, 1, 0)
INSERT [dbo].[SzczegolyZamowienia] ([ZamowienieID], [ProduktID], [Ilosc], [Przygotowane]) VALUES (2025, 1, 1, 0)
INSERT [dbo].[SzczegolyZamowienia] ([ZamowienieID], [ProduktID], [Ilosc], [Przygotowane]) VALUES (2026, 7, 1, 0)
INSERT [dbo].[SzczegolyZamowienia] ([ZamowienieID], [ProduktID], [Ilosc], [Przygotowane]) VALUES (2027, 4, 1, 0)
GO
INSERT [dbo].[Uzytkownicy] ([Login], [Haslo], [Rola]) VALUES (N'Admin', N'Admin', 1)
INSERT [dbo].[Uzytkownicy] ([Login], [Haslo], [Rola]) VALUES (N'Pracownik', N'Pracownik123!@', 2)
GO
SET IDENTITY_INSERT [dbo].[Zamowienia] ON 

INSERT [dbo].[Zamowienia] ([ID], [Data], [Godzina], [NaWynos], [Zrealizowano]) VALUES (14, CAST(N'2023-12-19' AS Date), CAST(N'22:13:31.6200000' AS Time), 1, 0)
INSERT [dbo].[Zamowienia] ([ID], [Data], [Godzina], [NaWynos], [Zrealizowano]) VALUES (15, CAST(N'2023-12-19' AS Date), CAST(N'22:14:24.5600000' AS Time), 1, 0)
INSERT [dbo].[Zamowienia] ([ID], [Data], [Godzina], [NaWynos], [Zrealizowano]) VALUES (16, CAST(N'2023-12-21' AS Date), CAST(N'17:54:03.2800000' AS Time), 1, 0)
INSERT [dbo].[Zamowienia] ([ID], [Data], [Godzina], [NaWynos], [Zrealizowano]) VALUES (1016, CAST(N'2023-12-23' AS Date), CAST(N'12:39:09.6300000' AS Time), 0, 0)
INSERT [dbo].[Zamowienia] ([ID], [Data], [Godzina], [NaWynos], [Zrealizowano]) VALUES (1017, CAST(N'2023-12-23' AS Date), CAST(N'15:23:19.2533333' AS Time), 1, 1)
INSERT [dbo].[Zamowienia] ([ID], [Data], [Godzina], [NaWynos], [Zrealizowano]) VALUES (1018, CAST(N'2023-12-23' AS Date), CAST(N'15:26:58.0500000' AS Time), 1, 1)
INSERT [dbo].[Zamowienia] ([ID], [Data], [Godzina], [NaWynos], [Zrealizowano]) VALUES (1019, CAST(N'2023-12-23' AS Date), CAST(N'15:44:33.7600000' AS Time), 1, 1)
INSERT [dbo].[Zamowienia] ([ID], [Data], [Godzina], [NaWynos], [Zrealizowano]) VALUES (1020, CAST(N'2023-12-23' AS Date), CAST(N'15:46:22.2566667' AS Time), 1, 1)
INSERT [dbo].[Zamowienia] ([ID], [Data], [Godzina], [NaWynos], [Zrealizowano]) VALUES (1021, CAST(N'2023-12-23' AS Date), CAST(N'17:09:55.6866667' AS Time), 1, 1)
INSERT [dbo].[Zamowienia] ([ID], [Data], [Godzina], [NaWynos], [Zrealizowano]) VALUES (1022, CAST(N'2023-12-23' AS Date), CAST(N'17:17:44.7000000' AS Time), 1, 1)
INSERT [dbo].[Zamowienia] ([ID], [Data], [Godzina], [NaWynos], [Zrealizowano]) VALUES (2016, CAST(N'2023-12-25' AS Date), CAST(N'09:38:49.0166667' AS Time), 1, 1)
INSERT [dbo].[Zamowienia] ([ID], [Data], [Godzina], [NaWynos], [Zrealizowano]) VALUES (2017, CAST(N'2023-12-25' AS Date), CAST(N'09:43:28.9400000' AS Time), 1, 0)
INSERT [dbo].[Zamowienia] ([ID], [Data], [Godzina], [NaWynos], [Zrealizowano]) VALUES (2018, CAST(N'2023-12-25' AS Date), CAST(N'09:51:10.0333333' AS Time), 1, 0)
INSERT [dbo].[Zamowienia] ([ID], [Data], [Godzina], [NaWynos], [Zrealizowano]) VALUES (2019, CAST(N'2023-12-27' AS Date), CAST(N'17:47:18.3033333' AS Time), 1, 0)
INSERT [dbo].[Zamowienia] ([ID], [Data], [Godzina], [NaWynos], [Zrealizowano]) VALUES (2020, CAST(N'2023-12-27' AS Date), CAST(N'17:47:38.1133333' AS Time), 1, 0)
INSERT [dbo].[Zamowienia] ([ID], [Data], [Godzina], [NaWynos], [Zrealizowano]) VALUES (2021, CAST(N'2023-12-27' AS Date), CAST(N'17:47:59.5900000' AS Time), 1, 0)
INSERT [dbo].[Zamowienia] ([ID], [Data], [Godzina], [NaWynos], [Zrealizowano]) VALUES (2022, CAST(N'2023-12-27' AS Date), CAST(N'17:48:06.9233333' AS Time), 0, 0)
INSERT [dbo].[Zamowienia] ([ID], [Data], [Godzina], [NaWynos], [Zrealizowano]) VALUES (2023, CAST(N'2023-12-27' AS Date), CAST(N'17:48:16.3833333' AS Time), 1, 0)
INSERT [dbo].[Zamowienia] ([ID], [Data], [Godzina], [NaWynos], [Zrealizowano]) VALUES (2024, CAST(N'2023-12-27' AS Date), CAST(N'17:49:07.7800000' AS Time), 1, 0)
INSERT [dbo].[Zamowienia] ([ID], [Data], [Godzina], [NaWynos], [Zrealizowano]) VALUES (2025, CAST(N'2023-12-27' AS Date), CAST(N'17:53:37.2833333' AS Time), 1, 0)
INSERT [dbo].[Zamowienia] ([ID], [Data], [Godzina], [NaWynos], [Zrealizowano]) VALUES (2026, CAST(N'2023-12-27' AS Date), CAST(N'17:53:49.8300000' AS Time), 1, 0)
INSERT [dbo].[Zamowienia] ([ID], [Data], [Godzina], [NaWynos], [Zrealizowano]) VALUES (2027, CAST(N'2023-12-27' AS Date), CAST(N'17:53:59.0966667' AS Time), 1, 0)
SET IDENTITY_INSERT [dbo].[Zamowienia] OFF
GO
/****** Object:  Index [IX_Menu]    Script Date: 29.12.2023 10:10:48 ******/
CREATE NONCLUSTERED INDEX [IX_Menu] ON [dbo].[Menu]
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Menu]  WITH CHECK ADD  CONSTRAINT [FK_Menu_Kategorie] FOREIGN KEY([Kategoria])
REFERENCES [dbo].[Kategorie] ([ID])
GO
ALTER TABLE [dbo].[Menu] CHECK CONSTRAINT [FK_Menu_Kategorie]
GO
ALTER TABLE [dbo].[SzczegolyZamowienia]  WITH CHECK ADD  CONSTRAINT [FK_SzczegolyZamowienia_Menu] FOREIGN KEY([ProduktID])
REFERENCES [dbo].[Menu] ([ID])
GO
ALTER TABLE [dbo].[SzczegolyZamowienia] CHECK CONSTRAINT [FK_SzczegolyZamowienia_Menu]
GO
ALTER TABLE [dbo].[SzczegolyZamowienia]  WITH CHECK ADD  CONSTRAINT [FK_SzczegolyZamowienia_Zamowienia] FOREIGN KEY([ZamowienieID])
REFERENCES [dbo].[Zamowienia] ([ID])
GO
ALTER TABLE [dbo].[SzczegolyZamowienia] CHECK CONSTRAINT [FK_SzczegolyZamowienia_Zamowienia]
GO
USE [master]
GO
ALTER DATABASE [Fastfood] SET  READ_WRITE 
GO
