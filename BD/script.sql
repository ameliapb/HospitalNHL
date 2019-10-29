USE [master]
GO
/****** Object:  Database [NLH]    Script Date: 2019-10-16 15:17:06 ******/
CREATE DATABASE [NLH]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'NLH', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\NLH.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'NLH_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\NLH_log.ldf' , SIZE = 1040KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [NLH] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NLH].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [NLH] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [NLH] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [NLH] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [NLH] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [NLH] SET ARITHABORT OFF 
GO
ALTER DATABASE [NLH] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [NLH] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [NLH] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [NLH] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [NLH] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [NLH] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [NLH] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [NLH] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [NLH] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [NLH] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [NLH] SET  DISABLE_BROKER 
GO
ALTER DATABASE [NLH] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [NLH] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [NLH] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [NLH] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [NLH] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [NLH] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [NLH] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [NLH] SET RECOVERY FULL 
GO
ALTER DATABASE [NLH] SET  MULTI_USER 
GO
ALTER DATABASE [NLH] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [NLH] SET DB_CHAINING OFF 
GO
ALTER DATABASE [NLH] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [NLH] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'NLH', N'ON'
GO
USE [NLH]
GO
/****** Object:  Table [dbo].[Compagnie_Assurance]    Script Date: 2019-10-16 15:17:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compagnie_Assurance](
	[ID_compagnie] [int] IDENTITY(1,1) NOT NULL,
	[nom_compagnie] [nchar](50) NULL,
 CONSTRAINT [PK_Compagnie_Assurance] PRIMARY KEY CLUSTERED 
(
	[ID_compagnie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Departement]    Script Date: 2019-10-16 15:17:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departement](
	[ID_Departement] [int] IDENTITY(1,1) NOT NULL,
	[nom_departement] [nchar](50) NULL,
 CONSTRAINT [PK_Departement] PRIMARY KEY CLUSTERED 
(
	[ID_Departement] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Dossier_Admission]    Script Date: 2019-10-16 15:17:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dossier_Admission](
	[ID_Admission] [int] IDENTITY(1,1) NOT NULL,
	[chirurgie_programme] [nchar](1) NULL,
	[date_admission] [date] NULL,
	[date_chirurgie] [date] NULL,
	[date_conge] [date] NULL,
	[NSS] [int] NULL,
	[Numéro_Lit] [int] NULL,
	[ID_Medecin] [int] NULL,
 CONSTRAINT [PK_Dossier_Admission] PRIMARY KEY CLUSTERED 
(
	[ID_Admission] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Lit]    Script Date: 2019-10-16 15:17:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Lit](
	[Numero_Lit] [int] IDENTITY(1,1) NOT NULL,
	[occupe] [char](1) NULL,
	[numero_Type] [int] NULL,
	[ID_Departement] [int] NULL,
 CONSTRAINT [PK_Lit] PRIMARY KEY CLUSTERED 
(
	[Numero_Lit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MedecinT]    Script Date: 2019-10-16 15:17:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedecinT](
	[ID_Medecin] [int] IDENTITY(1,1) NOT NULL,
	[nom] [nchar](50) NULL,
	[prenom] [nchar](50) NULL,
	[specialite] [nchar](50) NULL,
 CONSTRAINT [PK_Medecin] PRIMARY KEY CLUSTERED 
(
	[ID_Medecin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Parent]    Script Date: 2019-10-16 15:17:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parent](
	[Ref_Parent] [int] IDENTITY(1,1) NOT NULL,
	[nom] [nchar](50) NULL,
	[prenom] [nchar](50) NULL,
	[adresse] [nchar](100) NULL,
	[ville] [nchar](50) NULL,
	[province] [nchar](50) NULL,
	[code_postal] [nchar](10) NULL,
	[telephone] [nchar](20) NULL,
 CONSTRAINT [PK_Parent] PRIMARY KEY CLUSTERED 
(
	[Ref_Parent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Patient]    Script Date: 2019-10-16 15:17:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[NSS] [int] NOT NULL,
	[date_naissance] [date] NULL,
	[nom] [nchar](50) NULL,
	[prenom] [nchar](50) NULL,
	[adresse] [nchar](100) NULL,
	[ville] [nchar](50) NULL,
	[province] [nchar](50) NULL,
	[code_postal] [nchar](10) NULL,
	[telephone] [nchar](20) NULL,
	[IDCompagnie] [int] NULL,
	[Ref_Parent] [int] NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[NSS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Type_Lit]    Script Date: 2019-10-16 15:17:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type_Lit](
	[Numero_Type] [int] IDENTITY(1,1) NOT NULL,
	[description] [nchar](100) NULL,
 CONSTRAINT [PK_Type_Lit] PRIMARY KEY CLUSTERED 
(
	[Numero_Type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Compagnie_Assurance] ON 

INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (1, N'csacdssd                                          ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (2, N'cddf                                              ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (3, N'sdsadsdf                                          ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (4, N'csdcsdsd                                          ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (5, N'dsdcfasdfsdf                                      ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (6, N'cdscsd                                            ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (7, N'dsfsdf                                            ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (8, N'x cxzcx                                           ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (9, N'xcxcz                                             ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (10, N'sdsdfdsf                                          ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (11, N'xcxzc                                             ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (12, N'xcxzczx                                           ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (13, N'sccsd                                             ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (14, N'xczxc                                             ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (15, N'csdcsd                                            ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (16, N'xczxcxz                                           ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (17, N'cvxvxcv                                           ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (18, N'cxczxc                                            ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (19, N'sdsdsf                                            ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (20, N'assia                                             ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (21, N'assia                                             ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (22, N'assssssssssss                                     ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (23, N'kechit                                            ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (24, N'yanis                                             ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (25, N'iles                                              ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (26, N'yazid                                             ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (27, N'nelya                                             ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (28, N'dfsdf                                             ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (29, N'sdsa                                              ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (30, N'assia23                                           ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (31, N'vvcxv                                             ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (32, N'vcxvxcv                                           ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (35, N'public                                            ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (36, N'compagnie1                                        ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (37, N'compagnie2                                        ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (38, N'compagnie3                                        ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (39, N'compagnie4                                        ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (40, N'dasda                                             ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (41, N'dfdf                                              ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (42, N'hdjgh                                             ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (43, N'444                                               ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (44, N'aaa                                               ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (45, N'teste                                             ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (46, N'aa                                                ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (47, N'kkkk                                              ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (48, N'tata                                              ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (49, N'jjj                                               ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (50, N'aaa                                               ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (51, N'lllllll                                           ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (52, N'aff                                               ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (53, N'aes                                               ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (54, N'fff                                               ')
INSERT [dbo].[Compagnie_Assurance] ([ID_compagnie], [nom_compagnie]) VALUES (55, N'teste                                             ')
SET IDENTITY_INSERT [dbo].[Compagnie_Assurance] OFF
SET IDENTITY_INSERT [dbo].[Departement] ON 

INSERT [dbo].[Departement] ([ID_Departement], [nom_departement]) VALUES (1, N'pediaterie                                        ')
INSERT [dbo].[Departement] ([ID_Departement], [nom_departement]) VALUES (2, N'ophtalmologie                                     ')
INSERT [dbo].[Departement] ([ID_Departement], [nom_departement]) VALUES (3, N'chirurgie                                         ')
SET IDENTITY_INSERT [dbo].[Departement] OFF
SET IDENTITY_INSERT [dbo].[Dossier_Admission] ON 

INSERT [dbo].[Dossier_Admission] ([ID_Admission], [chirurgie_programme], [date_admission], [date_chirurgie], [date_conge], [NSS], [Numéro_Lit], [ID_Medecin]) VALUES (22, N'1', CAST(N'2019-10-16' AS Date), CAST(N'2019-10-16' AS Date), CAST(N'2019-10-16' AS Date), 1, 8, 19)
INSERT [dbo].[Dossier_Admission] ([ID_Admission], [chirurgie_programme], [date_admission], [date_chirurgie], [date_conge], [NSS], [Numéro_Lit], [ID_Medecin]) VALUES (23, N'1', CAST(N'2019-10-16' AS Date), CAST(N'2019-10-17' AS Date), NULL, 44, 8, 19)
SET IDENTITY_INSERT [dbo].[Dossier_Admission] OFF
SET IDENTITY_INSERT [dbo].[Lit] ON 

INSERT [dbo].[Lit] ([Numero_Lit], [occupe], [numero_Type], [ID_Departement]) VALUES (4, N'1', 16, 1)
INSERT [dbo].[Lit] ([Numero_Lit], [occupe], [numero_Type], [ID_Departement]) VALUES (5, N'1', 16, 1)
INSERT [dbo].[Lit] ([Numero_Lit], [occupe], [numero_Type], [ID_Departement]) VALUES (6, N'1', 17, 2)
INSERT [dbo].[Lit] ([Numero_Lit], [occupe], [numero_Type], [ID_Departement]) VALUES (7, N'1', 18, 3)
INSERT [dbo].[Lit] ([Numero_Lit], [occupe], [numero_Type], [ID_Departement]) VALUES (8, N'1', 18, 3)
INSERT [dbo].[Lit] ([Numero_Lit], [occupe], [numero_Type], [ID_Departement]) VALUES (9, N'1', 18, 1)
INSERT [dbo].[Lit] ([Numero_Lit], [occupe], [numero_Type], [ID_Departement]) VALUES (10, N'0', 18, 1)
INSERT [dbo].[Lit] ([Numero_Lit], [occupe], [numero_Type], [ID_Departement]) VALUES (11, N'1', 18, 1)
INSERT [dbo].[Lit] ([Numero_Lit], [occupe], [numero_Type], [ID_Departement]) VALUES (12, N'1', 16, 2)
INSERT [dbo].[Lit] ([Numero_Lit], [occupe], [numero_Type], [ID_Departement]) VALUES (13, N'0', 16, 2)
INSERT [dbo].[Lit] ([Numero_Lit], [occupe], [numero_Type], [ID_Departement]) VALUES (14, N'1', 17, 3)
INSERT [dbo].[Lit] ([Numero_Lit], [occupe], [numero_Type], [ID_Departement]) VALUES (15, N'1', 17, 3)
INSERT [dbo].[Lit] ([Numero_Lit], [occupe], [numero_Type], [ID_Departement]) VALUES (16, N'1', 17, 2)
INSERT [dbo].[Lit] ([Numero_Lit], [occupe], [numero_Type], [ID_Departement]) VALUES (18, N'1', 17, 2)
SET IDENTITY_INSERT [dbo].[Lit] OFF
SET IDENTITY_INSERT [dbo].[MedecinT] ON 

INSERT [dbo].[MedecinT] ([ID_Medecin], [nom], [prenom], [specialite]) VALUES (19, N'Marleyts                                          ', N'Bobs                                              ', N'Cardiologiste                                     ')
INSERT [dbo].[MedecinT] ([ID_Medecin], [nom], [prenom], [specialite]) VALUES (20, N'Celine                                            ', N'Dionss                                            ', N'Generaliste                                       ')
INSERT [dbo].[MedecinT] ([ID_Medecin], [nom], [prenom], [specialite]) VALUES (22, N'Amelia                                            ', N'Bernardes                                         ', N'Chirurgian                                        ')
SET IDENTITY_INSERT [dbo].[MedecinT] OFF
SET IDENTITY_INSERT [dbo].[Parent] ON 

INSERT [dbo].[Parent] ([Ref_Parent], [nom], [prenom], [adresse], [ville], [province], [code_postal], [telephone]) VALUES (1, N'assia                                             ', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Parent] ([Ref_Parent], [nom], [prenom], [adresse], [ville], [province], [code_postal], [telephone]) VALUES (2, N'yazid                                             ', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Parent] ([Ref_Parent], [nom], [prenom], [adresse], [ville], [province], [code_postal], [telephone]) VALUES (3, N'yanis                                             ', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Parent] ([Ref_Parent], [nom], [prenom], [adresse], [ville], [province], [code_postal], [telephone]) VALUES (4, N'dfdsf                                             ', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Parent] ([Ref_Parent], [nom], [prenom], [adresse], [ville], [province], [code_postal], [telephone]) VALUES (5, N'dsfs                                              ', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Parent] ([Ref_Parent], [nom], [prenom], [adresse], [ville], [province], [code_postal], [telephone]) VALUES (6, N'sdasd                                             ', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Parent] ([Ref_Parent], [nom], [prenom], [adresse], [ville], [province], [code_postal], [telephone]) VALUES (7, N'cxzczx                                            ', N'xcx                                               ', N'xczx                                                                                                ', N'xzczx                                             ', N'xczx                                              ', N'czxc      ', N'545                 ')
INSERT [dbo].[Parent] ([Ref_Parent], [nom], [prenom], [adresse], [ville], [province], [code_postal], [telephone]) VALUES (8, N'aS                                                ', N'dsds                                              ', N'sds                                                                                                 ', N'sdsad                                             ', N'sdsd                                              ', N'sds       ', N'666                 ')
INSERT [dbo].[Parent] ([Ref_Parent], [nom], [prenom], [adresse], [ville], [province], [code_postal], [telephone]) VALUES (9, N'dasd                                              ', N'sdas                                              ', N'sda                                                                                                 ', N'sad                                               ', N'sda                                               ', N'          ', N'                    ')
INSERT [dbo].[Parent] ([Ref_Parent], [nom], [prenom], [adresse], [ville], [province], [code_postal], [telephone]) VALUES (10, N'czxczx                                            ', N'czxc                                              ', N'xczxc                                                                                               ', N'czx                                               ', N'czx                                               ', N'xczx      ', N'656                 ')
INSERT [dbo].[Parent] ([Ref_Parent], [nom], [prenom], [adresse], [ville], [province], [code_postal], [telephone]) VALUES (14, N'xcxc                                              ', N'                                                  ', N'                                                                                                    ', N'                                                  ', N'                                                  ', N'          ', N'                    ')
INSERT [dbo].[Parent] ([Ref_Parent], [nom], [prenom], [adresse], [ville], [province], [code_postal], [telephone]) VALUES (15, N'sfsf                                              ', N'                                                  ', N'                                                                                                    ', N'                                                  ', N'                                                  ', N'          ', N'                    ')
INSERT [dbo].[Parent] ([Ref_Parent], [nom], [prenom], [adresse], [ville], [province], [code_postal], [telephone]) VALUES (16, N'sdsds                                             ', N'                                                  ', N'                                                                                                    ', N'                                                  ', N'                                                  ', N'          ', N'                    ')
INSERT [dbo].[Parent] ([Ref_Parent], [nom], [prenom], [adresse], [ville], [province], [code_postal], [telephone]) VALUES (17, N'sdsd                                              ', N'                                                  ', N'                                                                                                    ', N'                                                  ', N'                                                  ', N'          ', N'                    ')
INSERT [dbo].[Parent] ([Ref_Parent], [nom], [prenom], [adresse], [ville], [province], [code_postal], [telephone]) VALUES (18, N'ggg                                               ', N'                                                  ', N'                                                                                                    ', N'                                                  ', N'                                                  ', N'          ', N'                    ')
INSERT [dbo].[Parent] ([Ref_Parent], [nom], [prenom], [adresse], [ville], [province], [code_postal], [telephone]) VALUES (19, N'ùfag                                              ', N'hgfhfg                                            ', N'hgsf                                                                                                ', N'hfsg                                              ', N'hfghfg                                            ', N'hfsh      ', N'hfshg               ')
INSERT [dbo].[Parent] ([Ref_Parent], [nom], [prenom], [adresse], [ville], [province], [code_postal], [telephone]) VALUES (20, N'a                                                 ', N'                                                  ', N'                                                                                                    ', N'                                                  ', N'                                                  ', N'          ', N'                    ')
INSERT [dbo].[Parent] ([Ref_Parent], [nom], [prenom], [adresse], [ville], [province], [code_postal], [telephone]) VALUES (21, N's                                                 ', N's                                                 ', N's                                                                                                   ', N's                                                 ', N's                                                 ', N's         ', N'5478888888          ')
INSERT [dbo].[Parent] ([Ref_Parent], [nom], [prenom], [adresse], [ville], [province], [code_postal], [telephone]) VALUES (22, N'lll                                               ', N'                                                  ', N'                                                                                                    ', N'                                                  ', N'                                                  ', N'          ', N'                    ')
INSERT [dbo].[Parent] ([Ref_Parent], [nom], [prenom], [adresse], [ville], [province], [code_postal], [telephone]) VALUES (23, N'a                                                 ', N'a                                                 ', N'a                                                                                                   ', N'a                                                 ', N'a                                                 ', N'a         ', N'5677888             ')
INSERT [dbo].[Parent] ([Ref_Parent], [nom], [prenom], [adresse], [ville], [province], [code_postal], [telephone]) VALUES (24, N'                                                  ', N'                                                  ', N'                                                                                                    ', N'                                                  ', N'                                                  ', N'          ', N'                    ')
INSERT [dbo].[Parent] ([Ref_Parent], [nom], [prenom], [adresse], [ville], [province], [code_postal], [telephone]) VALUES (25, N'                                                  ', N'                                                  ', N'                                                                                                    ', N'                                                  ', N'                                                  ', N'          ', N'                    ')
INSERT [dbo].[Parent] ([Ref_Parent], [nom], [prenom], [adresse], [ville], [province], [code_postal], [telephone]) VALUES (26, N'aaa                                               ', N'                                                  ', N'                                                                                                    ', N'                                                  ', N'                                                  ', N'          ', N'                    ')
INSERT [dbo].[Parent] ([Ref_Parent], [nom], [prenom], [adresse], [ville], [province], [code_postal], [telephone]) VALUES (27, N'aa                                                ', N'                                                  ', N'                                                                                                    ', N'                                                  ', N'                                                  ', N'          ', N'                    ')
INSERT [dbo].[Parent] ([Ref_Parent], [nom], [prenom], [adresse], [ville], [province], [code_postal], [telephone]) VALUES (28, N'a                                                 ', N'                                                  ', N'                                                                                                    ', N'                                                  ', N'                                                  ', N'          ', N'                    ')
INSERT [dbo].[Parent] ([Ref_Parent], [nom], [prenom], [adresse], [ville], [province], [code_postal], [telephone]) VALUES (29, N'aa                                                ', N'                                                  ', N'                                                                                                    ', N'                                                  ', N'                                                  ', N'          ', N'666666666           ')
INSERT [dbo].[Parent] ([Ref_Parent], [nom], [prenom], [adresse], [ville], [province], [code_postal], [telephone]) VALUES (30, N'a                                                 ', N'                                                  ', N'                                                                                                    ', N'                                                  ', N'                                                  ', N'          ', N'4444444444          ')
SET IDENTITY_INSERT [dbo].[Parent] OFF
INSERT [dbo].[Patient] ([NSS], [date_naissance], [nom], [prenom], [adresse], [ville], [province], [code_postal], [telephone], [IDCompagnie], [Ref_Parent]) VALUES (1, CAST(N'2010-06-09' AS Date), N'amelia                                            ', N'bernardes                                         ', N'a                                                                                                   ', N'a                                                 ', N'a                                                 ', N'a         ', N'6666666666          ', 55, 30)
INSERT [dbo].[Patient] ([NSS], [date_naissance], [nom], [prenom], [adresse], [ville], [province], [code_postal], [telephone], [IDCompagnie], [Ref_Parent]) VALUES (44, CAST(N'2019-10-08' AS Date), N'Assia                                             ', N'Hamouna                                           ', N'a                                                                                                   ', N'a                                                 ', N'a                                                 ', N'a         ', N'4444444444          ', 1, 10)
SET IDENTITY_INSERT [dbo].[Type_Lit] ON 

INSERT [dbo].[Type_Lit] ([Numero_Type], [description]) VALUES (16, N'Prive                                                                                               ')
INSERT [dbo].[Type_Lit] ([Numero_Type], [description]) VALUES (17, N'Semi Prive                                                                                          ')
INSERT [dbo].[Type_Lit] ([Numero_Type], [description]) VALUES (18, N'Public                                                                                              ')
SET IDENTITY_INSERT [dbo].[Type_Lit] OFF
ALTER TABLE [dbo].[Dossier_Admission]  WITH CHECK ADD  CONSTRAINT [FK_Dossier_Admission_Lit] FOREIGN KEY([Numéro_Lit])
REFERENCES [dbo].[Lit] ([Numero_Lit])
GO
ALTER TABLE [dbo].[Dossier_Admission] CHECK CONSTRAINT [FK_Dossier_Admission_Lit]
GO
ALTER TABLE [dbo].[Dossier_Admission]  WITH CHECK ADD  CONSTRAINT [FK_Dossier_Admission_MedecinT] FOREIGN KEY([ID_Medecin])
REFERENCES [dbo].[MedecinT] ([ID_Medecin])
GO
ALTER TABLE [dbo].[Dossier_Admission] CHECK CONSTRAINT [FK_Dossier_Admission_MedecinT]
GO
ALTER TABLE [dbo].[Dossier_Admission]  WITH CHECK ADD  CONSTRAINT [FK_Dossier_Admission_MedecinT1] FOREIGN KEY([ID_Medecin])
REFERENCES [dbo].[MedecinT] ([ID_Medecin])
GO
ALTER TABLE [dbo].[Dossier_Admission] CHECK CONSTRAINT [FK_Dossier_Admission_MedecinT1]
GO
ALTER TABLE [dbo].[Dossier_Admission]  WITH CHECK ADD  CONSTRAINT [FK_Dossier_Admission_Patient] FOREIGN KEY([NSS])
REFERENCES [dbo].[Patient] ([NSS])
GO
ALTER TABLE [dbo].[Dossier_Admission] CHECK CONSTRAINT [FK_Dossier_Admission_Patient]
GO
ALTER TABLE [dbo].[Lit]  WITH CHECK ADD  CONSTRAINT [FK_Lit_Departement] FOREIGN KEY([ID_Departement])
REFERENCES [dbo].[Departement] ([ID_Departement])
GO
ALTER TABLE [dbo].[Lit] CHECK CONSTRAINT [FK_Lit_Departement]
GO
ALTER TABLE [dbo].[Lit]  WITH CHECK ADD  CONSTRAINT [FK_Lit_Type_Lit] FOREIGN KEY([numero_Type])
REFERENCES [dbo].[Type_Lit] ([Numero_Type])
GO
ALTER TABLE [dbo].[Lit] CHECK CONSTRAINT [FK_Lit_Type_Lit]
GO
ALTER TABLE [dbo].[Patient]  WITH CHECK ADD  CONSTRAINT [FK_Patient_Compagnie_Assurance] FOREIGN KEY([IDCompagnie])
REFERENCES [dbo].[Compagnie_Assurance] ([ID_compagnie])
GO
ALTER TABLE [dbo].[Patient] CHECK CONSTRAINT [FK_Patient_Compagnie_Assurance]
GO
ALTER TABLE [dbo].[Patient]  WITH CHECK ADD  CONSTRAINT [FK_Patient_Parent] FOREIGN KEY([Ref_Parent])
REFERENCES [dbo].[Parent] ([Ref_Parent])
GO
ALTER TABLE [dbo].[Patient] CHECK CONSTRAINT [FK_Patient_Parent]
GO
USE [master]
GO
ALTER DATABASE [NLH] SET  READ_WRITE 
GO
