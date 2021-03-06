USE [master]
GO
/****** Object:  Database [Baza1]    Script Date: 12/11/2020 2:13:56 PM ******/
CREATE DATABASE [Baza1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Baza1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Baza1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Baza1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Baza1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Baza1] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Baza1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Baza1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Baza1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Baza1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Baza1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Baza1] SET ARITHABORT OFF 
GO
ALTER DATABASE [Baza1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Baza1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Baza1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Baza1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Baza1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Baza1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Baza1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Baza1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Baza1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Baza1] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Baza1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Baza1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Baza1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Baza1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Baza1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Baza1] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [Baza1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Baza1] SET RECOVERY FULL 
GO
ALTER DATABASE [Baza1] SET  MULTI_USER 
GO
ALTER DATABASE [Baza1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Baza1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Baza1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Baza1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Baza1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Baza1] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Baza1', N'ON'
GO
ALTER DATABASE [Baza1] SET QUERY_STORE = OFF
GO
USE [Baza1]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 12/11/2020 2:13:56 PM ******/
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
/****** Object:  Table [dbo].[Exams]    Script Date: 12/11/2020 2:13:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exams](
	[ExamId] [int] IDENTITY(1,1) NOT NULL,
	[SubjectId] [int] NOT NULL,
	[StudentId] [int] NOT NULL,
	[Grade] [int] NOT NULL,
	[ExamDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Exams] PRIMARY KEY CLUSTERED 
(
	[ExamId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 12/11/2020 2:13:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[IndexNumber] [nvarchar](max) NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[City] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 12/11/2020 2:13:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subjects](
	[SubjectId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Subjects] PRIMARY KEY CLUSTERED 
(
	[SubjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201209043528_Init', N'5.0.0')
GO
SET IDENTITY_INSERT [dbo].[Exams] ON 

INSERT [dbo].[Exams] ([ExamId], [SubjectId], [StudentId], [Grade], [ExamDate]) VALUES (2, 1, 1, 7, CAST(N'2020-12-03T07:00:00.0000000' AS DateTime2))
INSERT [dbo].[Exams] ([ExamId], [SubjectId], [StudentId], [Grade], [ExamDate]) VALUES (3, 6, 3, 10, CAST(N'2020-12-04T07:03:00.0000000' AS DateTime2))
INSERT [dbo].[Exams] ([ExamId], [SubjectId], [StudentId], [Grade], [ExamDate]) VALUES (4, 2, 4, 6, CAST(N'2020-12-02T14:28:00.0000000' AS DateTime2))
INSERT [dbo].[Exams] ([ExamId], [SubjectId], [StudentId], [Grade], [ExamDate]) VALUES (5, 3, 3, 7, CAST(N'2020-12-02T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Exams] ([ExamId], [SubjectId], [StudentId], [Grade], [ExamDate]) VALUES (6, 1, 12, 6, CAST(N'2020-12-04T13:21:00.0000000' AS DateTime2))
INSERT [dbo].[Exams] ([ExamId], [SubjectId], [StudentId], [Grade], [ExamDate]) VALUES (7, 4, 11, 6, CAST(N'2020-11-29T13:22:00.0000000' AS DateTime2))
INSERT [dbo].[Exams] ([ExamId], [SubjectId], [StudentId], [Grade], [ExamDate]) VALUES (8, 8, 2, 10, CAST(N'2020-12-09T13:22:00.0000000' AS DateTime2))
INSERT [dbo].[Exams] ([ExamId], [SubjectId], [StudentId], [Grade], [ExamDate]) VALUES (9, 6, 4, 5, CAST(N'2020-12-04T13:22:00.0000000' AS DateTime2))
INSERT [dbo].[Exams] ([ExamId], [SubjectId], [StudentId], [Grade], [ExamDate]) VALUES (14, 9, 1, 10, CAST(N'2020-12-03T21:43:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Exams] OFF
GO
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([StudentId], [IndexNumber], [FirstName], [LastName], [City]) VALUES (1, N'2020/0001', N'Perica', N'Peric', N'Beograd')
INSERT [dbo].[Students] ([StudentId], [IndexNumber], [FirstName], [LastName], [City]) VALUES (2, N'2020/0002', N'Mika', N'Mikic', N'Nis')
INSERT [dbo].[Students] ([StudentId], [IndexNumber], [FirstName], [LastName], [City]) VALUES (3, N'2020/0009', N'Nikola', N'Nikolic', N'Kragujevac')
INSERT [dbo].[Students] ([StudentId], [IndexNumber], [FirstName], [LastName], [City]) VALUES (4, N'2020/0019', N'Marko', N'Nikolic', N'Kragujevac')
INSERT [dbo].[Students] ([StudentId], [IndexNumber], [FirstName], [LastName], [City]) VALUES (5, N'2020/0119', N'Marina', N'Peric', N'Krusevac')
INSERT [dbo].[Students] ([StudentId], [IndexNumber], [FirstName], [LastName], [City]) VALUES (6, N'2020/1019', N'Jelena', N'Marinkovic', N'Zrenjanin')
INSERT [dbo].[Students] ([StudentId], [IndexNumber], [FirstName], [LastName], [City]) VALUES (7, N'2020/0100', N'Marko', N'Jovanovic', N'Beograd')
INSERT [dbo].[Students] ([StudentId], [IndexNumber], [FirstName], [LastName], [City]) VALUES (10, N'2020/4567', N'Ana', N'Stanic', N'Brus')
INSERT [dbo].[Students] ([StudentId], [IndexNumber], [FirstName], [LastName], [City]) VALUES (11, N'2020/6762', N'Uros', N'Savov', N'Jagodina')
INSERT [dbo].[Students] ([StudentId], [IndexNumber], [FirstName], [LastName], [City]) VALUES (12, N'2020/1267', N'Katarina', N'Simic', N'Prokuplje')
SET IDENTITY_INSERT [dbo].[Students] OFF
GO
SET IDENTITY_INSERT [dbo].[Subjects] ON 

INSERT [dbo].[Subjects] ([SubjectId], [Title]) VALUES (1, N'Inteligentni sistemi')
INSERT [dbo].[Subjects] ([SubjectId], [Title]) VALUES (2, N'Programski jezici')
INSERT [dbo].[Subjects] ([SubjectId], [Title]) VALUES (3, N'Internet tehnologije')
INSERT [dbo].[Subjects] ([SubjectId], [Title]) VALUES (4, N'Osnovi organizacije')
INSERT [dbo].[Subjects] ([SubjectId], [Title]) VALUES (6, N'Baze podataka')
INSERT [dbo].[Subjects] ([SubjectId], [Title]) VALUES (7, N'Projektovanje softvera')
INSERT [dbo].[Subjects] ([SubjectId], [Title]) VALUES (8, N'Engleski 1')
INSERT [dbo].[Subjects] ([SubjectId], [Title]) VALUES (9, N'Osnovi kvaliteta')
INSERT [dbo].[Subjects] ([SubjectId], [Title]) VALUES (10, N'Matematika 1')
INSERT [dbo].[Subjects] ([SubjectId], [Title]) VALUES (11, N'Internet tehnologije 2')
SET IDENTITY_INSERT [dbo].[Subjects] OFF
GO
/****** Object:  Index [IX_Exams_StudentId]    Script Date: 12/11/2020 2:13:57 PM ******/
CREATE NONCLUSTERED INDEX [IX_Exams_StudentId] ON [dbo].[Exams]
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Exams_SubjectId]    Script Date: 12/11/2020 2:13:57 PM ******/
CREATE NONCLUSTERED INDEX [IX_Exams_SubjectId] ON [dbo].[Exams]
(
	[SubjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Exams]  WITH CHECK ADD  CONSTRAINT [FK_Exams_Students_StudentId] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Students] ([StudentId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Exams] CHECK CONSTRAINT [FK_Exams_Students_StudentId]
GO
ALTER TABLE [dbo].[Exams]  WITH CHECK ADD  CONSTRAINT [FK_Exams_Subjects_SubjectId] FOREIGN KEY([SubjectId])
REFERENCES [dbo].[Subjects] ([SubjectId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Exams] CHECK CONSTRAINT [FK_Exams_Subjects_SubjectId]
GO
USE [master]
GO
ALTER DATABASE [Baza1] SET  READ_WRITE 
GO
