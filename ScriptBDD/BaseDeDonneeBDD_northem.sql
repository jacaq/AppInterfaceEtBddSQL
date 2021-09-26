USE [master]
GO
/****** Object:  Database [BDD_northern]    Script Date: 2021-07-11 15:42:26 ******/
CREATE DATABASE [BDD_northern]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BDD_northern', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BDD_northern.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BDD_northern_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BDD_northern_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BDD_northern] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BDD_northern].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BDD_northern] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BDD_northern] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BDD_northern] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BDD_northern] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BDD_northern] SET ARITHABORT OFF 
GO
ALTER DATABASE [BDD_northern] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BDD_northern] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BDD_northern] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BDD_northern] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BDD_northern] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BDD_northern] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BDD_northern] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BDD_northern] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BDD_northern] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BDD_northern] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BDD_northern] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BDD_northern] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BDD_northern] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BDD_northern] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BDD_northern] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BDD_northern] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BDD_northern] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BDD_northern] SET RECOVERY FULL 
GO
ALTER DATABASE [BDD_northern] SET  MULTI_USER 
GO
ALTER DATABASE [BDD_northern] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BDD_northern] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BDD_northern] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BDD_northern] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BDD_northern] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BDD_northern] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'BDD_northern', N'ON'
GO
ALTER DATABASE [BDD_northern] SET QUERY_STORE = OFF
GO
USE [BDD_northern]
GO
/****** Object:  Table [dbo].[Admission]    Script Date: 2021-07-11 15:42:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admission](
	[ID_admission] [int] IDENTITY(1,1) NOT NULL,
	[Chirurchie_programmee] [bit] NULL,
	[date_admission] [date] NULL,
	[date_chirurgie] [date] NULL,
	[date_congee] [date] NULL,
	[televiseur] [bit] NULL,
	[telephone] [bit] NULL,
	[NAS] [nchar](11) NOT NULL,
	[Numero_lit] [varchar](10) NULL,
	[IDMedecin] [varchar](10) NULL,
 CONSTRAINT [PK_Admission] PRIMARY KEY CLUSTERED 
(
	[ID_admission] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Assurance]    Script Date: 2021-07-11 15:42:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Assurance](
	[IDAssurance] [varchar](20) NOT NULL,
	[nom_compagnie] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Assurance] PRIMARY KEY CLUSTERED 
(
	[IDAssurance] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departement]    Script Date: 2021-07-11 15:42:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departement](
	[IDDepartement] [nvarchar](10) NOT NULL,
	[nom_departement] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Departement] PRIMARY KEY CLUSTERED 
(
	[IDDepartement] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lit]    Script Date: 2021-07-11 15:42:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lit](
	[Numero_lit] [varchar](10) NOT NULL,
	[occupee] [bit] NOT NULL,
	[IDType] [char](1) NOT NULL,
	[IDDepartement] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Lit] PRIMARY KEY CLUSTERED 
(
	[Numero_lit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medecin]    Script Date: 2021-07-11 15:42:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medecin](
	[IDMedecin] [varchar](10) NOT NULL,
	[nom] [nvarchar](80) NOT NULL,
	[prenom] [nvarchar](80) NOT NULL,
 CONSTRAINT [PK_Medecin] PRIMARY KEY CLUSTERED 
(
	[IDMedecin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 2021-07-11 15:42:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[NAS] [nchar](11) NOT NULL,
	[Date_naissance] [date] NULL,
	[Nom] [nvarchar](80) NOT NULL,
	[Prenom] [nvarchar](80) NOT NULL,
	[Adresse_civique] [nvarchar](100) NOT NULL,
	[App] [varchar](10) NULL,
	[Ville] [nvarchar](50) NOT NULL,
	[Province] [nvarchar](50) NOT NULL,
	[Code_postal] [varchar](7) NOT NULL,
	[Telephone] [varchar](14) NOT NULL,
	[IDAssurance] [varchar](20) NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[NAS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Type_lit]    Script Date: 2021-07-11 15:42:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type_lit](
	[IDType] [char](1) NOT NULL,
	[description] [nchar](12) NOT NULL,
 CONSTRAINT [PK_Type_lit] PRIMARY KEY CLUSTERED 
(
	[IDType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Admission] ON 

INSERT [dbo].[Admission] ([ID_admission], [Chirurchie_programmee], [date_admission], [date_chirurgie], [date_congee], [televiseur], [telephone], [NAS], [Numero_lit], [IDMedecin]) VALUES (2, 1, CAST(N'2021-07-11' AS Date), CAST(N'2021-07-11' AS Date), NULL, 0, 0, N'123-456-789', N'S1', N'1JR')
INSERT [dbo].[Admission] ([ID_admission], [Chirurchie_programmee], [date_admission], [date_chirurgie], [date_congee], [televiseur], [telephone], [NAS], [Numero_lit], [IDMedecin]) VALUES (3, 1, CAST(N'2021-07-11' AS Date), CAST(N'2021-07-11' AS Date), NULL, 1, 1, N'222-222-222', N'S2', N'1JR')
INSERT [dbo].[Admission] ([ID_admission], [Chirurchie_programmee], [date_admission], [date_chirurgie], [date_congee], [televiseur], [telephone], [NAS], [Numero_lit], [IDMedecin]) VALUES (4, 1, CAST(N'2021-07-11' AS Date), CAST(N'2021-07-11' AS Date), CAST(N'2021-07-11' AS Date), 0, 0, N'444-444-444', N'S3', N'1JR')
INSERT [dbo].[Admission] ([ID_admission], [Chirurchie_programmee], [date_admission], [date_chirurgie], [date_congee], [televiseur], [telephone], [NAS], [Numero_lit], [IDMedecin]) VALUES (5, 0, CAST(N'2021-07-11' AS Date), CAST(N'2021-07-11' AS Date), NULL, 0, 0, N'333-333-333', N'S4', N'1JR')
INSERT [dbo].[Admission] ([ID_admission], [Chirurchie_programmee], [date_admission], [date_chirurgie], [date_congee], [televiseur], [telephone], [NAS], [Numero_lit], [IDMedecin]) VALUES (6, 1, CAST(N'2021-07-11' AS Date), CAST(N'2021-07-11' AS Date), CAST(N'2021-07-11' AS Date), 0, 0, N'777-777-777', N'S5', N'1JR')
SET IDENTITY_INSERT [dbo].[Admission] OFF
GO
INSERT [dbo].[Assurance] ([IDAssurance], [nom_compagnie]) VALUES (N'er4', N'Assurance Vitalité')
GO
INSERT [dbo].[Departement] ([IDDepartement], [nom_departement]) VALUES (N'intensif', N'soins intensifs')
INSERT [dbo].[Departement] ([IDDepartement], [nom_departement]) VALUES (N'ped', N'Pédiatrie')
INSERT [dbo].[Departement] ([IDDepartement], [nom_departement]) VALUES (N'urg', N'Urgence')
GO
INSERT [dbo].[Lit] ([Numero_lit], [occupee], [IDType], [IDDepartement]) VALUES (N'S0', 1, N'C', N'urg')
INSERT [dbo].[Lit] ([Numero_lit], [occupee], [IDType], [IDDepartement]) VALUES (N'S1', 1, N'C', N'urg')
INSERT [dbo].[Lit] ([Numero_lit], [occupee], [IDType], [IDDepartement]) VALUES (N'S10', 0, N'A', N'intensif')
INSERT [dbo].[Lit] ([Numero_lit], [occupee], [IDType], [IDDepartement]) VALUES (N'S11', 0, N'A', N'intensif')
INSERT [dbo].[Lit] ([Numero_lit], [occupee], [IDType], [IDDepartement]) VALUES (N'S12', 0, N'C', N'ped')
INSERT [dbo].[Lit] ([Numero_lit], [occupee], [IDType], [IDDepartement]) VALUES (N'S13', 0, N'C', N'ped')
INSERT [dbo].[Lit] ([Numero_lit], [occupee], [IDType], [IDDepartement]) VALUES (N'S14', 0, N'C', N'ped')
INSERT [dbo].[Lit] ([Numero_lit], [occupee], [IDType], [IDDepartement]) VALUES (N'S15', 0, N'A', N'ped')
INSERT [dbo].[Lit] ([Numero_lit], [occupee], [IDType], [IDDepartement]) VALUES (N'S16', 0, N'A', N'ped')
INSERT [dbo].[Lit] ([Numero_lit], [occupee], [IDType], [IDDepartement]) VALUES (N'S17', 0, N'A', N'ped')
INSERT [dbo].[Lit] ([Numero_lit], [occupee], [IDType], [IDDepartement]) VALUES (N'S18', 0, N'B', N'urg')
INSERT [dbo].[Lit] ([Numero_lit], [occupee], [IDType], [IDDepartement]) VALUES (N'S19', 0, N'B', N'urg')
INSERT [dbo].[Lit] ([Numero_lit], [occupee], [IDType], [IDDepartement]) VALUES (N'S2', 1, N'C', N'urg')
INSERT [dbo].[Lit] ([Numero_lit], [occupee], [IDType], [IDDepartement]) VALUES (N'S20', 0, N'B', N'urg')
INSERT [dbo].[Lit] ([Numero_lit], [occupee], [IDType], [IDDepartement]) VALUES (N'S21', 0, N'C', N'intensif')
INSERT [dbo].[Lit] ([Numero_lit], [occupee], [IDType], [IDDepartement]) VALUES (N'S22', 0, N'C', N'intensif')
INSERT [dbo].[Lit] ([Numero_lit], [occupee], [IDType], [IDDepartement]) VALUES (N'S23', 0, N'C', N'intensif')
INSERT [dbo].[Lit] ([Numero_lit], [occupee], [IDType], [IDDepartement]) VALUES (N'S24', 0, N'C', N'intensif')
INSERT [dbo].[Lit] ([Numero_lit], [occupee], [IDType], [IDDepartement]) VALUES (N'S25', 0, N'A', N'urg')
INSERT [dbo].[Lit] ([Numero_lit], [occupee], [IDType], [IDDepartement]) VALUES (N'S26', 0, N'A', N'urg')
INSERT [dbo].[Lit] ([Numero_lit], [occupee], [IDType], [IDDepartement]) VALUES (N'S27', 0, N'A', N'urg')
INSERT [dbo].[Lit] ([Numero_lit], [occupee], [IDType], [IDDepartement]) VALUES (N'S28', 0, N'A', N'urg')
INSERT [dbo].[Lit] ([Numero_lit], [occupee], [IDType], [IDDepartement]) VALUES (N'S3', 1, N'C', N'urg')
INSERT [dbo].[Lit] ([Numero_lit], [occupee], [IDType], [IDDepartement]) VALUES (N'S4', 1, N'C', N'urg')
INSERT [dbo].[Lit] ([Numero_lit], [occupee], [IDType], [IDDepartement]) VALUES (N'S5', 1, N'B', N'ped')
INSERT [dbo].[Lit] ([Numero_lit], [occupee], [IDType], [IDDepartement]) VALUES (N'S6', 0, N'B', N'ped')
INSERT [dbo].[Lit] ([Numero_lit], [occupee], [IDType], [IDDepartement]) VALUES (N'S7', 0, N'B', N'ped')
INSERT [dbo].[Lit] ([Numero_lit], [occupee], [IDType], [IDDepartement]) VALUES (N'S8', 0, N'B', N'ped')
INSERT [dbo].[Lit] ([Numero_lit], [occupee], [IDType], [IDDepartement]) VALUES (N'S9', 0, N'A', N'intensif')
GO
INSERT [dbo].[Medecin] ([IDMedecin], [nom], [prenom]) VALUES (N'1JR', N'Ranger', N'Joannie')
INSERT [dbo].[Medecin] ([IDMedecin], [nom], [prenom]) VALUES (N'1VR', N'Ranger', N'Véronique')
INSERT [dbo].[Medecin] ([IDMedecin], [nom], [prenom]) VALUES (N'2EM', N'Martinez', N'Eli')
INSERT [dbo].[Medecin] ([IDMedecin], [nom], [prenom]) VALUES (N'34B', N'Subban', N'PK')
INSERT [dbo].[Medecin] ([IDMedecin], [nom], [prenom]) VALUES (N'3RD', N'Dion', N'Raphael')
INSERT [dbo].[Medecin] ([IDMedecin], [nom], [prenom]) VALUES (N'3SR', N'Ranger', N'Stefany')
INSERT [dbo].[Medecin] ([IDMedecin], [nom], [prenom]) VALUES (N'5YU', N'Polo', N'MARCO')
INSERT [dbo].[Medecin] ([IDMedecin], [nom], [prenom]) VALUES (N'7fg', N'Bonjour', N'mon ami')
INSERT [dbo].[Medecin] ([IDMedecin], [nom], [prenom]) VALUES (N'ID', N'Nom', N'Prenom')
INSERT [dbo].[Medecin] ([IDMedecin], [nom], [prenom]) VALUES (N'ID6', N'Fortin', N'Marie')
GO
INSERT [dbo].[Patient] ([NAS], [Date_naissance], [Nom], [Prenom], [Adresse_civique], [App], [Ville], [Province], [Code_postal], [Telephone], [IDAssurance]) VALUES (N'123-456-789', CAST(N'1983-09-26' AS Date), N'Richard', N'Samuel', N'123 Brossard', N'1', N'Montréal', N'Québec', N'h1g6l1', N'514-321-2343', NULL)
INSERT [dbo].[Patient] ([NAS], [Date_naissance], [Nom], [Prenom], [Adresse_civique], [App], [Ville], [Province], [Code_postal], [Telephone], [IDAssurance]) VALUES (N'222-222-222', CAST(N'2000-07-11' AS Date), N'Salut', N'bonjour', N'14 rue de la Douleur', N'', N'Montreal', N'Province', N'g2l3r0', N'555-689-8123', NULL)
INSERT [dbo].[Patient] ([NAS], [Date_naissance], [Nom], [Prenom], [Adresse_civique], [App], [Ville], [Province], [Code_postal], [Telephone], [IDAssurance]) VALUES (N'333-333-333', CAST(N'2055-09-24' AS Date), N'Lafontaine', N'Diane', N'125 picolo', N'1B', N'Magog', N'Québec', N'h1r5p2', N'555-555-555', NULL)
INSERT [dbo].[Patient] ([NAS], [Date_naissance], [Nom], [Prenom], [Adresse_civique], [App], [Ville], [Province], [Code_postal], [Telephone], [IDAssurance]) VALUES (N'444-444-444', CAST(N'1982-01-16' AS Date), N'Constant', N'Richard', N'13 Habs', N'', N'Laval', N'Québec', N'h6L7k3', N'666-666-666', N'er4')
INSERT [dbo].[Patient] ([NAS], [Date_naissance], [Nom], [Prenom], [Adresse_civique], [App], [Ville], [Province], [Code_postal], [Telephone], [IDAssurance]) VALUES (N'777-777-777', CAST(N'1981-07-11' AS Date), N'SIRI', N'SIRI', N'3 apple street', N'', N'USA', N'USA', N'sfgd', N'111-111-1111', NULL)
GO
INSERT [dbo].[Type_lit] ([IDType], [description]) VALUES (N'A', N'Privée      ')
INSERT [dbo].[Type_lit] ([IDType], [description]) VALUES (N'B', N'Semi-privée ')
INSERT [dbo].[Type_lit] ([IDType], [description]) VALUES (N'C', N'Standart    ')
GO
ALTER TABLE [dbo].[Admission]  WITH CHECK ADD  CONSTRAINT [FK_Admission_Lit] FOREIGN KEY([Numero_lit])
REFERENCES [dbo].[Lit] ([Numero_lit])
GO
ALTER TABLE [dbo].[Admission] CHECK CONSTRAINT [FK_Admission_Lit]
GO
ALTER TABLE [dbo].[Admission]  WITH CHECK ADD  CONSTRAINT [FK_Admission_Medecin] FOREIGN KEY([IDMedecin])
REFERENCES [dbo].[Medecin] ([IDMedecin])
GO
ALTER TABLE [dbo].[Admission] CHECK CONSTRAINT [FK_Admission_Medecin]
GO
ALTER TABLE [dbo].[Admission]  WITH CHECK ADD  CONSTRAINT [FK_Admission_Patient] FOREIGN KEY([NAS])
REFERENCES [dbo].[Patient] ([NAS])
GO
ALTER TABLE [dbo].[Admission] CHECK CONSTRAINT [FK_Admission_Patient]
GO
ALTER TABLE [dbo].[Lit]  WITH CHECK ADD  CONSTRAINT [FK_Lit_Departement] FOREIGN KEY([IDDepartement])
REFERENCES [dbo].[Departement] ([IDDepartement])
GO
ALTER TABLE [dbo].[Lit] CHECK CONSTRAINT [FK_Lit_Departement]
GO
ALTER TABLE [dbo].[Lit]  WITH CHECK ADD  CONSTRAINT [FK_Lit_Type_lit] FOREIGN KEY([IDType])
REFERENCES [dbo].[Type_lit] ([IDType])
GO
ALTER TABLE [dbo].[Lit] CHECK CONSTRAINT [FK_Lit_Type_lit]
GO
ALTER TABLE [dbo].[Patient]  WITH CHECK ADD  CONSTRAINT [FK_Patient_Assurance] FOREIGN KEY([IDAssurance])
REFERENCES [dbo].[Assurance] ([IDAssurance])
GO
ALTER TABLE [dbo].[Patient] CHECK CONSTRAINT [FK_Patient_Assurance]
GO
USE [master]
GO
ALTER DATABASE [BDD_northern] SET  READ_WRITE 
GO
