USE [master]
GO
/****** Object:  Database [Valuta]    Script Date: 2018-09-07 16:34:28 ******/
CREATE DATABASE [Valuta]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Valuta', FILENAME = N'C:\Users\Administrator\Valuta.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Valuta_log', FILENAME = N'C:\Users\Administrator\Valuta_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Valuta] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Valuta].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Valuta] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Valuta] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Valuta] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Valuta] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Valuta] SET ARITHABORT OFF 
GO
ALTER DATABASE [Valuta] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Valuta] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Valuta] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Valuta] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Valuta] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Valuta] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Valuta] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Valuta] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Valuta] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Valuta] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Valuta] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Valuta] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Valuta] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Valuta] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Valuta] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Valuta] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Valuta] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Valuta] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Valuta] SET  MULTI_USER 
GO
ALTER DATABASE [Valuta] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Valuta] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Valuta] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Valuta] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Valuta] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Valuta] SET QUERY_STORE = OFF
GO
USE [Valuta]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Valuta]
GO
/****** Object:  Table [dbo].[CurrencyLocation]    Script Date: 2018-09-07 16:34:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CurrencyLocation](
	[CodeID] [char](3) NOT NULL,
	[Country] [varchar](50) NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[CodeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExchangeRate]    Script Date: 2018-09-07 16:34:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExchangeRate](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [char](3) NOT NULL,
	[Rate] [decimal](18, 10) NULL,
	[Date] [datetime] NULL,
 CONSTRAINT [PK_ExchangeRate] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'AED', N'Förenade Arabemiraten')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'AFN', N'Afganistan')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'ALL', N'Albanien')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'AMD', N'Armenien')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'ANG', N'Nederländska Antillerna')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'AOA', N'Angola')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'ARS', N'Argentina')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'AUD', N'Australien')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'AWG', N'Aruba')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'AZN', N'Azerbajdzjan')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'BAM', N'Bosnien Herzegovina')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'BBD', N'Barbados')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'BDT', N'Bangladesh')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'BGN', N'Bulgarien')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'BHD', N'Bahrain')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'BIF', N'Burundi')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'BMD', N'Bermuda')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'BND', N'Brunei')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'BOB', N'Bolivia')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'BRL', N'Brasilien')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'BSD', N'Bahamas')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'BTC', N'Bitcoin')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'BTN', N'Bhutan')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'BWP', N'Botswana')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'BYN', N'Vitryssland')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'BYR', N'Vitryssland2')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'BZD', N'Belize')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'CAD', N'Kanada')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'CDF', N'Kongo')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'CHF', N'Schweiz')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'CLF', N'Chile')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'CLP', N'Chile2')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'CNY', N'China')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'COP', N'Colombia')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'CRC', N'Costa Rica')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'CUC', N' Cuba Convertable')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'CUP', N'Cuba Peso')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'CVE', N'Cap Verde')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'CZK', N'Tjeckien')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'DJF', N'Djibouti')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'DKK', N'Danmark')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'DOP', N'Dominikanska Republiken')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'DZD', N'Algeriet')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'EGP', N'Egypten')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'ERN', N'Eritrea')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'ETB', N'Etiopien')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'EUR', N'Euro')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'FJD', N'Fiji')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'FKP', N'Falklandsöarna')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'GBP', N'Storbrittanien')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'GEL', N'Georgien')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'GGP', N'Guernsey ')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'GHS', N'Ghana')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'GIP', N'Gibraltar')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'GMD', N'Gambia')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'GNF', N'Guinea')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'GTQ', N'Guatemala')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'GYD', N'Guyana')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'HKD', N'Hong Kong')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'HNL', N'Honduras')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'HRK', N'Kroatien')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'HTG', N'Haiti')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'HUF', N'Ungern')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'IDR', N'Indonesien')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'ILS', N'Israel')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'IMP', N'Isle Of Man')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'INR', N'Indien')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'IQD', N'Irak')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'IRR', N'Iran')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'ISK', N'Island')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'JEP', N'Jersey Pund')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'JMD', N'Jamaica')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'JOD', N'Jordanien')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'JPY', N'Japan')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'KES', N'Kenya')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'KGS', N'Kirgizistan')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'KHR', N'Kambodja')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'KMF', N'Komoros')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'KPW', N'Nordkorea')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'KRW', N'Sydkorea')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'KWD', N'Kuwait')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'KYD', N'Caymanöarna')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'KZT', N'Kazakstan')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'LAK', N'Laos')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'LBP', N'Libanon')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'LKR', N'Sri Lanka')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'LRD', N'Liberia')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'LSL', N'Lesoto')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'LTL', N'Litauen')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'LVL', N'Lettland')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'LYD', N'Libyen')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'MAD', N'Madagaskar')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'MDL', N'Moldavien')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'MGA', N'Madgaskar 2')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'MKD', N'Makedonien')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'MMK', N'Miyanmar')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'MNT', N'Mongoliet')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'MOP', N'Macao')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'MRO', N'Mauretanien')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'MUR', N'Mauritius')
GO
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'MVR', N'Maldiverna')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'MWK', N'Malawi')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'MXN', N'Mexiko')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'MYR', N'Malaysia')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'MZN', N'Mozambique')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'NAD', N'Namibia')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'NGN', N'Nigeria')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'NIO', N'Nicaragua')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'NOK', N'Norge')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'NPR', N'Nepal')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'NZD', N'Nya Zeeland')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'OMR', N'Oman')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'PAB', N'Panama')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'PEN', N'Peru')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'PGK', N'Papa Nya Guinea')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'PHP', N'Filippinierna')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'PKR', N'Pakistan')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'PLN', N'Polen')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'PYG', N'Paraguay')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'QAR', N'Qatar')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'RON', N'Rumänien')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'RSD', N'Serbien')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'RUB', N'Ryssland')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'RWF', N'Rwanda')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'SAR', N'Saudiarabien')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'SBD', N'Solomonöarna')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'SCR', N'Seychellerna')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'SDG', N'Sudan')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'SEK', N'Sverige')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'SGD', N'Singapore')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'SHP', N'Sankt Helena')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'SLL', N'Sierra Leone')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'SOS', N'Somalia')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'SRD', N'Surinam')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'STD', N'Sao Tome ')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'SVC', N'El Salvadaor')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'SYP', N'Syrien')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'SZL', N'Swaziland')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'THB', N'Thailand')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'TJS', N'Tajikistan')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'TMT', N'Turkmenistan')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'TND', N'Tunisien')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'TOP', N'Tonga')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'TRY', N'Turkiet')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'TTD', N'Trinidad Tobago')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'TWD', N'Taiwan')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'TZS', N'Tanzania')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'UAH', N'Ukraina')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'UGX', N'Uganda')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'USD', N'USA')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'UYU', N'Uruguay')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'UZS', N'Uzbekistan')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'VEF', N'Venezuela')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'VND', N'Vietnam')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'VUV', N'Vanautu')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'WST', N'Samoa')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'XAF', N'Kamerun')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'XAG', N'Silver')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'XAU', N'Guld')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'XCD', N'Östkaribisk Dollar')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'XDR', N'International Monetary Found')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'XOF', N'Västafrika')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'XPF', N'Franska Polynesien')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'YER', N'Yemen')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'ZAR', N'Sydafrika')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'ZMK', N'Zambia')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'ZMW', N'Zambia2')
INSERT [dbo].[CurrencyLocation] ([CodeID], [Country]) VALUES (N'ZWL', N'Zimbabwe')
SET IDENTITY_INSERT [dbo].[ExchangeRate] ON 

INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3858, N'AED', CAST(4.2788580000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3859, N'AFN', CAST(86.1916300000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3860, N'ALL', CAST(126.6792920000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3861, N'AMD', CAST(565.3462250000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3862, N'ANG', CAST(2.1506400000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3863, N'AOA', CAST(326.7174540000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3864, N'ARS', CAST(43.5835720000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3865, N'AUD', CAST(1.6269160000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3866, N'AWG', CAST(2.0880290000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3867, N'AZN', CAST(1.9831930000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3868, N'BAM', CAST(1.9605910000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3869, N'BBD', CAST(2.3331180000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3870, N'BDT', CAST(97.6824700000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3871, N'BGN', CAST(1.9559330000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3872, N'BHD', CAST(0.4390980000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3873, N'BIF', CAST(2063.6834350000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3874, N'BMD', CAST(1.1648700000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3875, N'BND', CAST(1.7597460000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3876, N'BOB', CAST(8.0545510000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3877, N'BRL', CAST(4.7291420000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3878, N'BSD', CAST(1.1656270000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3879, N'BTC', CAST(0.0001800000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3880, N'BTN', CAST(83.5754810000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3881, N'BWP', CAST(12.8088600000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3882, N'BYN', CAST(2.4716190000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3883, N'BYR', CAST(22831.4491560000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3884, N'BZD', CAST(2.3429610000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3885, N'CAD', CAST(1.5298820000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3886, N'CDF', CAST(1882.4298260000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3887, N'CHF', CAST(1.1240050000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3888, N'CLF', CAST(0.0263230000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3889, N'CLP', CAST(800.1369870000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3890, N'CNY', CAST(7.9684050000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3891, N'COP', CAST(3594.7883720000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3892, N'CRC', CAST(678.8164930000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3893, N'CUC', CAST(1.1648700000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3894, N'CUP', CAST(30.8690510000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3895, N'CVE', CAST(110.5391410000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3896, N'CZK', CAST(25.6894570000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3897, N'DJF', CAST(207.0204030000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3898, N'DKK', CAST(7.4571590000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3899, N'DOP', CAST(58.3232870000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3900, N'DZD', CAST(137.5070360000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3901, N'EGP', CAST(20.8324590000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3902, N'ERN', CAST(17.4733500000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3903, N'ETB', CAST(32.2389790000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3904, N'EUR', CAST(1.0000000000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3905, N'FJD', CAST(2.4711530000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3906, N'FKP', CAST(0.8969270000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3907, N'GBP', CAST(0.9000310000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3908, N'GEL', CAST(2.9010760000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3909, N'GGP', CAST(0.9003370000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3910, N'GHS', CAST(5.5266660000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3911, N'GIP', CAST(0.8969620000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3912, N'GMD', CAST(55.9544780000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3913, N'GNF', CAST(10543.4118730000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3914, N'GTQ', CAST(8.8647820000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3915, N'GYD', CAST(243.3937150000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3916, N'HKD', CAST(9.1438750000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3917, N'HNL', CAST(27.9819180000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3918, N'HRK', CAST(7.4288410000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3919, N'HTG', CAST(80.5513350000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3920, N'HUF', CAST(324.7808730000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3921, N'IDR', CAST(17302.9768250000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3922, N'ILS', CAST(4.1690880000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3923, N'IMP', CAST(0.9003370000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3924, N'INR', CAST(83.5741730000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3925, N'IQD', CAST(1390.8546070000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3926, N'IRR', CAST(49046.8449940000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3927, N'ISK', CAST(128.7997550000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3928, N'JEP', CAST(0.9003370000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3929, N'JMD', CAST(159.0628000000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3930, N'JOD', CAST(0.8269060000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3931, N'JPY', CAST(129.0233540000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3932, N'KES', CAST(117.2910540000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3933, N'KGS', CAST(80.5923390000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3934, N'KHR', CAST(4749.5823460000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3935, N'KMF', CAST(496.3394940000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3936, N'KPW', CAST(1048.4137120000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3937, N'KRW', CAST(1306.9720160000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3938, N'KWD', CAST(0.3524910000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3939, N'KYD', CAST(0.9713670000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3940, N'KZT', CAST(435.8251440000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3941, N'LAK', CAST(9931.2731140000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3942, N'LBP', CAST(1763.5548250000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3943, N'LKR', CAST(188.6971000000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3944, N'LRD', CAST(179.6807860000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3945, N'LSL', CAST(16.5935460000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3946, N'LTL', CAST(3.5513430000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3947, N'LVL', CAST(0.7228600000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3948, N'LYD', CAST(1.6135770000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3949, N'MAD', CAST(10.9617780000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3950, N'MDL', CAST(19.4952220000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3951, N'MGA', CAST(3939.8814750000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3952, N'MKD', CAST(61.6041710000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3953, N'MMK', CAST(1804.9656430000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3954, N'MNT', CAST(2889.3747200000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3955, N'MOP', CAST(9.4246110000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3956, N'MRO', CAST(416.3615100000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3957, N'MUR', CAST(40.0486240000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3958, N'MVR', CAST(18.0092240000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3959, N'MWK', CAST(847.0468850000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3960, N'MXN', CAST(22.2876290000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3961, N'MYR', CAST(4.8275120000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3962, N'MZN', CAST(70.1426710000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3963, N'NAD', CAST(16.8032240000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3964, N'NGN', CAST(419.0503300000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3965, N'NIO', CAST(37.2210440000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3966, N'NOK', CAST(9.7954370000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3967, N'NPR', CAST(134.0650930000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3968, N'NZD', CAST(1.7697850000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3969, N'OMR', CAST(0.4484280000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3970, N'PAB', CAST(1.1655110000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3971, N'PEN', CAST(3.8702220000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3972, N'PGK', CAST(3.8749970000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3973, N'PHP', CAST(62.5995240000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3974, N'PKR', CAST(143.5236260000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3975, N'PLN', CAST(4.3054400000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3976, N'PYG', CAST(6802.0184540000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3977, N'QAR', CAST(4.2418730000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3978, N'RON', CAST(4.6410160000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3979, N'RSD', CAST(118.3275810000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3980, N'RUB', CAST(80.2215570000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3981, N'RWF', CAST(1026.6929930000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3982, N'SAR', CAST(4.3689630000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3983, N'SBD', CAST(9.2229150000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3984, N'SCR', CAST(15.8468960000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3985, N'SDG', CAST(20.9816500000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3986, N'SEK', CAST(10.5733720000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3987, N'SGD', CAST(1.6015820000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3988, N'SHP', CAST(1.5386780000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3989, N'SLL', CAST(10134.3675840000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3990, N'SOS', CAST(672.7122620000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3991, N'SRD', CAST(8.6875900000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3992, N'STD', CAST(24574.5603080000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3993, N'SVC', CAST(10.1998910000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3994, N'SYP', CAST(599.9080540000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3995, N'SZL', CAST(17.8935170000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3996, N'THB', CAST(38.1745320000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3997, N'TJS', CAST(10.9867610000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3998, N'TMT', CAST(4.0828690000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (3999, N'TND', CAST(3.2248840000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (4000, N'TOP', CAST(2.6715090000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (4001, N'TRY', CAST(7.5448040000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (4002, N'TTD', CAST(7.8562900000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (4003, N'TWD', CAST(35.8331510000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (4004, N'TZS', CAST(2659.2788840000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (4005, N'UAH', CAST(32.9180630000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (4006, N'UGX', CAST(4400.3542970000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (4007, N'USD', CAST(1.1648700000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (4008, N'UYU', CAST(37.8591900000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (4009, N'UZS', CAST(9123.8452670000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (4010, N'VEF', CAST(289493.3983910000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (4011, N'VND', CAST(27144.9622290000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (4012, N'VUV', CAST(132.4175890000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (4013, N'WST', CAST(3.0443650000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (4014, N'XAF', CAST(657.5577050000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (4015, N'XAG', CAST(0.0822440000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (4016, N'XAU', CAST(0.0009700000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (4017, N'XCD', CAST(3.1481190000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (4018, N'XDR', CAST(0.8320480000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (4019, N'XOF', CAST(657.5463460000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (4020, N'XPF', CAST(119.5511250000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (4021, N'YER', CAST(291.6253440000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (4022, N'ZAR', CAST(17.6233290000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (4023, N'ZMK', CAST(10485.2245680000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (4024, N'ZMW', CAST(12.0121060000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[ExchangeRate] ([Id], [Code], [Rate], [Date]) VALUES (4025, N'ZWL', CAST(375.5016350000 AS Decimal(18, 10)), CAST(N'2018-09-07T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[ExchangeRate] OFF
ALTER TABLE [dbo].[ExchangeRate]  WITH CHECK ADD  CONSTRAINT [FK_ExchangeRate_Country] FOREIGN KEY([Code])
REFERENCES [dbo].[CurrencyLocation] ([CodeID])
GO
ALTER TABLE [dbo].[ExchangeRate] CHECK CONSTRAINT [FK_ExchangeRate_Country]
GO
USE [master]
GO
ALTER DATABASE [Valuta] SET  READ_WRITE 
GO
