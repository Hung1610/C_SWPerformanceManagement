USE [master]
GO
/****** Object:  Database [SW_PerformanceManagement]    Script Date: 12/6/2018 4:15:21 PM ******/
CREATE DATABASE [SW_PerformanceManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SW_PerformanceManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\SW_PerformanceManagement.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SW_PerformanceManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\SW_PerformanceManagement_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SW_PerformanceManagement] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SW_PerformanceManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SW_PerformanceManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SW_PerformanceManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SW_PerformanceManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SW_PerformanceManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SW_PerformanceManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [SW_PerformanceManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SW_PerformanceManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SW_PerformanceManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SW_PerformanceManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SW_PerformanceManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SW_PerformanceManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SW_PerformanceManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SW_PerformanceManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SW_PerformanceManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SW_PerformanceManagement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SW_PerformanceManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SW_PerformanceManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SW_PerformanceManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SW_PerformanceManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SW_PerformanceManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SW_PerformanceManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SW_PerformanceManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SW_PerformanceManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SW_PerformanceManagement] SET  MULTI_USER 
GO
ALTER DATABASE [SW_PerformanceManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SW_PerformanceManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SW_PerformanceManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SW_PerformanceManagement] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [SW_PerformanceManagement]
GO
/****** Object:  Table [dbo].[000TB_Priority]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[000TB_Priority](
	[PriorityID] [int] NOT NULL,
	[PriorityName] [nvarchar](50) NULL,
	[PriorityCode] [int] NULL,
	[Remark] [nvarchar](max) NULL,
 CONSTRAINT [PK_000TB_Priority] PRIMARY KEY CLUSTERED 
(
	[PriorityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[001TB_Right]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[001TB_Right](
	[RightID] [int] NOT NULL,
	[RightName] [nvarchar](50) NULL,
 CONSTRAINT [PK_001TB_Right] PRIMARY KEY CLUSTERED 
(
	[RightID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[002TB_PriorityRight]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[002TB_PriorityRight](
	[PriorityRightID] [int] IDENTITY(1,1) NOT NULL,
	[PriorityID] [int] NOT NULL,
	[RightID] [int] NOT NULL,
	[Remark] [nvarchar](50) NULL,
 CONSTRAINT [PK_002TB_PriorityRight] PRIMARY KEY CLUSTERED 
(
	[PriorityRightID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[100TB_Performance]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[100TB_Performance](
	[PerformanceID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NULL,
	[ProjectID] [int] NULL,
	[WorkingDate] [date] NULL,
	[WorkingHour] [float] NULL,
	[WorkingName] [nvarchar](50) NULL,
	[WorkingDetail] [nvarchar](50) NULL,
 CONSTRAINT [PK_100TB_Performance] PRIMARY KEY CLUSTERED 
(
	[PerformanceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[200TB_Project]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[200TB_Project](
	[ProjectID] [int] IDENTITY(1,1) NOT NULL,
	[ProjectName] [nvarchar](50) NULL,
	[ProjectInfo] [nvarchar](max) NULL,
	[CustomerName] [nvarchar](50) NULL,
	[CustomerInfo] [nvarchar](max) NULL,
	[StartDate] [date] NULL,
	[EndDate] [date] NULL,
	[DelFlag] [tinyint] NULL,
	[Remark] [nvarchar](max) NULL,
 CONSTRAINT [PK_200TB_Project] PRIMARY KEY CLUSTERED 
(
	[ProjectID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[201TB_ProjectAssign]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[201TB_ProjectAssign](
	[ProjectAssignID] [int] IDENTITY(1,1) NOT NULL,
	[ProjectID] [int] NULL,
	[EmployeeID] [int] NULL,
	[ProjectRoleID] [int] NULL,
	[StartDate] [date] NULL,
	[EndDate] [date] NULL,
	[Remark] [nvarchar](max) NULL,
 CONSTRAINT [PK_201TB_ProjectAssign] PRIMARY KEY CLUSTERED 
(
	[ProjectAssignID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[202TB_ProjectRole]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[202TB_ProjectRole](
	[ProjectRoleID] [int] NOT NULL,
	[ProjectRoleName] [nvarchar](50) NULL,
	[DelFlag] [tinyint] NULL,
	[Remark] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[300TB_Employee]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[300TB_Employee](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[PositionID] [int] NULL,
	[BranchID] [int] NULL,
	[StartDate] [date] NULL,
	[EndDate] [date] NULL,
	[EmailPrivate] [nvarchar](50) NULL,
	[Mobile] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[BirthDay] [date] NULL,
	[LevelID] [int] NULL,
	[Desire] [nvarchar](50) NULL,
	[DelFlag] [tinyint] NULL,
	[Remark] [nvarchar](max) NULL,
 CONSTRAINT [PK_300TB_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[301TB_Email]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[301TB_Email](
	[EmailID] [int] IDENTITY(1,1) NOT NULL,
	[EmailAddress] [nvarchar](50) NULL,
	[EmployeeID] [int] NULL,
	[EmployeePass] [nvarchar](50) NULL,
	[DelFlag] [tinyint] NULL,
	[Remark] [nvarchar](max) NULL,
 CONSTRAINT [PK_301TB_Email] PRIMARY KEY CLUSTERED 
(
	[EmailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[302TB_Level]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[302TB_Level](
	[LevelID] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[DelFlag] [tinyint] NULL,
	[Remark] [nvarchar](max) NULL,
 CONSTRAINT [PK_302TB_Level] PRIMARY KEY CLUSTERED 
(
	[LevelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[303TB_Position]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[303TB_Position](
	[PositionID] [int] NOT NULL,
	[PositionName] [nvarchar](50) NULL,
	[PositionType] [int] NULL,
	[PriorityID] [int] NULL,
	[DelFlag] [tinyint] NULL,
	[Remark] [nvarchar](max) NULL,
 CONSTRAINT [PK_303TB_Position] PRIMARY KEY CLUSTERED 
(
	[PositionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[400TB_Branch]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[400TB_Branch](
	[BranchID] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Location] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[StartDate] [date] NULL,
	[EndDate] [date] NULL,
	[DelFlag] [tinyint] NULL,
	[Remark] [nvarchar](max) NULL,
 CONSTRAINT [PK_400TB_Branch] PRIMARY KEY CLUSTERED 
(
	[BranchID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[500TB_SkillManage]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[500TB_SkillManage](
	[SkillID] [int] NOT NULL,
	[EmployeeID] [int] NULL,
	[SkillListID] [int] NULL,
	[StartDate] [date] NULL,
	[DelFlag] [tinyint] NULL,
	[Remark] [nvarchar](max) NULL,
 CONSTRAINT [PK_500TB_SkillManage] PRIMARY KEY CLUSTERED 
(
	[SkillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[501TB_SkillList]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[501TB_SkillList](
	[SkillListID] [int] IDENTITY(1,1) NOT NULL,
	[SkillName] [nvarchar](50) NULL,
	[SkillType] [nvarchar](50) NULL,
	[DelFlag] [tinyint] NULL,
	[Remark] [nvarchar](max) NULL,
 CONSTRAINT [PK_501TB_SkillList] PRIMARY KEY CLUSTERED 
(
	[SkillListID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProcedureLog]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProcedureLog](
	[LogDate] [datetime] NOT NULL,
	[DatabaseID] [int] NULL,
	[ObjectID] [int] NULL,
	[ProcedureName] [nvarchar](400) NULL,
	[ErrorLine] [int] NULL,
	[ErrorMessage] [nvarchar](max) NULL,
	[AdditionalInfo] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [cx_LogDate]    Script Date: 12/6/2018 4:15:21 PM ******/
CREATE CLUSTERED INDEX [cx_LogDate] ON [dbo].[ProcedureLog]
(
	[LogDate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
INSERT [dbo].[000TB_Priority] ([PriorityID], [PriorityName], [PriorityCode], [Remark]) VALUES (1, N'full', NULL, NULL)
INSERT [dbo].[000TB_Priority] ([PriorityID], [PriorityName], [PriorityCode], [Remark]) VALUES (2, N'employee', NULL, NULL)
INSERT [dbo].[001TB_Right] ([RightID], [RightName]) VALUES (1, N'ProjectAssign')
INSERT [dbo].[001TB_Right] ([RightID], [RightName]) VALUES (2, N'ProjectAdd')
INSERT [dbo].[001TB_Right] ([RightID], [RightName]) VALUES (3, N'ProjectEdit')
INSERT [dbo].[001TB_Right] ([RightID], [RightName]) VALUES (4, N'EmployeeAdd')
INSERT [dbo].[001TB_Right] ([RightID], [RightName]) VALUES (5, N'EmployeeEdit')
INSERT [dbo].[001TB_Right] ([RightID], [RightName]) VALUES (6, N'SkillManagement')
INSERT [dbo].[001TB_Right] ([RightID], [RightName]) VALUES (7, N'ProfileUpdate')
INSERT [dbo].[001TB_Right] ([RightID], [RightName]) VALUES (8, N'WorkReport')
SET IDENTITY_INSERT [dbo].[002TB_PriorityRight] ON 

INSERT [dbo].[002TB_PriorityRight] ([PriorityRightID], [PriorityID], [RightID], [Remark]) VALUES (1, 1, 1, NULL)
INSERT [dbo].[002TB_PriorityRight] ([PriorityRightID], [PriorityID], [RightID], [Remark]) VALUES (2, 1, 2, NULL)
INSERT [dbo].[002TB_PriorityRight] ([PriorityRightID], [PriorityID], [RightID], [Remark]) VALUES (3, 1, 3, NULL)
INSERT [dbo].[002TB_PriorityRight] ([PriorityRightID], [PriorityID], [RightID], [Remark]) VALUES (4, 1, 4, NULL)
INSERT [dbo].[002TB_PriorityRight] ([PriorityRightID], [PriorityID], [RightID], [Remark]) VALUES (5, 1, 5, NULL)
INSERT [dbo].[002TB_PriorityRight] ([PriorityRightID], [PriorityID], [RightID], [Remark]) VALUES (6, 1, 6, NULL)
INSERT [dbo].[002TB_PriorityRight] ([PriorityRightID], [PriorityID], [RightID], [Remark]) VALUES (7, 1, 7, NULL)
INSERT [dbo].[002TB_PriorityRight] ([PriorityRightID], [PriorityID], [RightID], [Remark]) VALUES (8, 1, 8, NULL)
INSERT [dbo].[002TB_PriorityRight] ([PriorityRightID], [PriorityID], [RightID], [Remark]) VALUES (9, 2, 2, NULL)
INSERT [dbo].[002TB_PriorityRight] ([PriorityRightID], [PriorityID], [RightID], [Remark]) VALUES (10, 2, 3, NULL)
INSERT [dbo].[002TB_PriorityRight] ([PriorityRightID], [PriorityID], [RightID], [Remark]) VALUES (11, 2, 4, NULL)
INSERT [dbo].[002TB_PriorityRight] ([PriorityRightID], [PriorityID], [RightID], [Remark]) VALUES (12, 2, 5, NULL)
INSERT [dbo].[002TB_PriorityRight] ([PriorityRightID], [PriorityID], [RightID], [Remark]) VALUES (13, 2, 6, NULL)
INSERT [dbo].[002TB_PriorityRight] ([PriorityRightID], [PriorityID], [RightID], [Remark]) VALUES (14, 2, 7, NULL)
INSERT [dbo].[002TB_PriorityRight] ([PriorityRightID], [PriorityID], [RightID], [Remark]) VALUES (15, 2, 8, NULL)
SET IDENTITY_INSERT [dbo].[002TB_PriorityRight] OFF
SET IDENTITY_INSERT [dbo].[100TB_Performance] ON 

INSERT [dbo].[100TB_Performance] ([PerformanceID], [EmployeeID], [ProjectID], [WorkingDate], [WorkingHour], [WorkingName], [WorkingDetail]) VALUES (1, 1, 1, CAST(N'2018-08-30' AS Date), 5, N'InternSW', N'brilliant')
INSERT [dbo].[100TB_Performance] ([PerformanceID], [EmployeeID], [ProjectID], [WorkingDate], [WorkingHour], [WorkingName], [WorkingDetail]) VALUES (2, 1, 1, CAST(N'2018-08-30' AS Date), 8, N'InternSW', N'Confused as hell.')
INSERT [dbo].[100TB_Performance] ([PerformanceID], [EmployeeID], [ProjectID], [WorkingDate], [WorkingHour], [WorkingName], [WorkingDetail]) VALUES (3, 1, 3, CAST(N'2018-09-14' AS Date), 4, N'Secondary fun time', N'fine stuff')
INSERT [dbo].[100TB_Performance] ([PerformanceID], [EmployeeID], [ProjectID], [WorkingDate], [WorkingHour], [WorkingName], [WorkingDetail]) VALUES (4, 1, 1, CAST(N'2018-09-17' AS Date), 5, N'InternSW', N'going well.')
INSERT [dbo].[100TB_Performance] ([PerformanceID], [EmployeeID], [ProjectID], [WorkingDate], [WorkingHour], [WorkingName], [WorkingDetail]) VALUES (5, 1, 2, CAST(N'2018-09-13' AS Date), 5, N'Ass', N'Fine')
INSERT [dbo].[100TB_Performance] ([PerformanceID], [EmployeeID], [ProjectID], [WorkingDate], [WorkingHour], [WorkingName], [WorkingDetail]) VALUES (6, 1, 2, CAST(N'2018-10-05' AS Date), 2, N'Ass', N'nhộn')
INSERT [dbo].[100TB_Performance] ([PerformanceID], [EmployeeID], [ProjectID], [WorkingDate], [WorkingHour], [WorkingName], [WorkingDetail]) VALUES (7, 1, 3, CAST(N'2018-10-05' AS Date), 4, N'Secondary fun time', N'fun')
INSERT [dbo].[100TB_Performance] ([PerformanceID], [EmployeeID], [ProjectID], [WorkingDate], [WorkingHour], [WorkingName], [WorkingDetail]) VALUES (8, 2, 2, CAST(N'2018-10-05' AS Date), 4, N'Ass', N'got promoted.')
INSERT [dbo].[100TB_Performance] ([PerformanceID], [EmployeeID], [ProjectID], [WorkingDate], [WorkingHour], [WorkingName], [WorkingDetail]) VALUES (9, 2, 1, CAST(N'2018-10-05' AS Date), 2, N'SoftWorldIntern', N'Just got in')
INSERT [dbo].[100TB_Performance] ([PerformanceID], [EmployeeID], [ProjectID], [WorkingDate], [WorkingHour], [WorkingName], [WorkingDetail]) VALUES (10, 2, 3, CAST(N'2018-10-05' AS Date), 8, N'Secondary fun time', N'too random for my taste')
INSERT [dbo].[100TB_Performance] ([PerformanceID], [EmployeeID], [ProjectID], [WorkingDate], [WorkingHour], [WorkingName], [WorkingDetail]) VALUES (11, 2, 2, CAST(N'2018-10-05' AS Date), 8, N'Ass', N'win or die')
SET IDENTITY_INSERT [dbo].[100TB_Performance] OFF
SET IDENTITY_INSERT [dbo].[200TB_Project] ON 

INSERT [dbo].[200TB_Project] ([ProjectID], [ProjectName], [ProjectInfo], [CustomerName], [CustomerInfo], [StartDate], [EndDate], [DelFlag], [Remark]) VALUES (1, N'SoftWorldIntern', N'some stuff', N'H the beautiful', N'He''s beautiful.', CAST(N'2018-06-07' AS Date), CAST(N'2018-08-08' AS Date), 0, N'Done.')
INSERT [dbo].[200TB_Project] ([ProjectID], [ProjectName], [ProjectInfo], [CustomerName], [CustomerInfo], [StartDate], [EndDate], [DelFlag], [Remark]) VALUES (2, N'Ass', N'some stuff', N'H the brave', N'He''s fabulous', CAST(N'2018-08-30' AS Date), CAST(N'2018-08-30' AS Date), 0, N'Perfume')
INSERT [dbo].[200TB_Project] ([ProjectID], [ProjectName], [ProjectInfo], [CustomerName], [CustomerInfo], [StartDate], [EndDate], [DelFlag], [Remark]) VALUES (3, N'Secondary fun time', N'random rando', N'Uncle H', N'his face is on the dollar', CAST(N'2018-03-29' AS Date), CAST(N'2018-08-30' AS Date), 0, N'real important')
SET IDENTITY_INSERT [dbo].[200TB_Project] OFF
SET IDENTITY_INSERT [dbo].[201TB_ProjectAssign] ON 

INSERT [dbo].[201TB_ProjectAssign] ([ProjectAssignID], [ProjectID], [EmployeeID], [ProjectRoleID], [StartDate], [EndDate], [Remark]) VALUES (32, 2, 2, 1, CAST(N'2018-09-10' AS Date), CAST(N'2018-09-10' AS Date), N'ass')
INSERT [dbo].[201TB_ProjectAssign] ([ProjectAssignID], [ProjectID], [EmployeeID], [ProjectRoleID], [StartDate], [EndDate], [Remark]) VALUES (40, 1, 1, 1, CAST(N'2018-10-04' AS Date), CAST(N'2018-10-04' AS Date), N'aa')
INSERT [dbo].[201TB_ProjectAssign] ([ProjectAssignID], [ProjectID], [EmployeeID], [ProjectRoleID], [StartDate], [EndDate], [Remark]) VALUES (41, 3, 2, 2, CAST(N'2018-10-12' AS Date), CAST(N'2018-10-12' AS Date), N'')
INSERT [dbo].[201TB_ProjectAssign] ([ProjectAssignID], [ProjectID], [EmployeeID], [ProjectRoleID], [StartDate], [EndDate], [Remark]) VALUES (42, 3, 1, 1, CAST(N'2018-10-12' AS Date), CAST(N'2018-10-12' AS Date), N'')
SET IDENTITY_INSERT [dbo].[201TB_ProjectAssign] OFF
INSERT [dbo].[202TB_ProjectRole] ([ProjectRoleID], [ProjectRoleName], [DelFlag], [Remark]) VALUES (1, N'lead', 0, N'important')
INSERT [dbo].[202TB_ProjectRole] ([ProjectRoleID], [ProjectRoleName], [DelFlag], [Remark]) VALUES (2, N'Coffee carrier', 0, N'very important')
SET IDENTITY_INSERT [dbo].[300TB_Employee] ON 

INSERT [dbo].[300TB_Employee] ([EmployeeID], [Name], [PositionID], [BranchID], [StartDate], [EndDate], [EmailPrivate], [Mobile], [Address], [BirthDay], [LevelID], [Desire], [DelFlag], [Remark]) VALUES (1, N'Đỗ Doãn Phước Hưng', 1, 1, CAST(N'2015-08-09' AS Date), CAST(N'2020-10-30' AS Date), N'phuochung008@gmail.com', N'0914307633', N'5 Hoàng Hoa Thám, TP Huế', CAST(N'1998-10-16' AS Date), 2, N'Nothing', 0, N'Gud Boi')
INSERT [dbo].[300TB_Employee] ([EmployeeID], [Name], [PositionID], [BranchID], [StartDate], [EndDate], [EmailPrivate], [Mobile], [Address], [BirthDay], [LevelID], [Desire], [DelFlag], [Remark]) VALUES (2, N'Jack', 2, 2, CAST(N'2016-10-16' AS Date), CAST(N'2020-08-12' AS Date), N'jack@gmail.com', N'0935476852', N'none', CAST(N'1990-10-16' AS Date), 2, N'Want to rule the world', 0, N'Bad Boi')
SET IDENTITY_INSERT [dbo].[300TB_Employee] OFF
SET IDENTITY_INSERT [dbo].[301TB_Email] ON 

INSERT [dbo].[301TB_Email] ([EmailID], [EmailAddress], [EmployeeID], [EmployeePass], [DelFlag], [Remark]) VALUES (1, N'H@gmail.com', 1, N'123', 0, N'Very Pro, Much Skilled.')
INSERT [dbo].[301TB_Email] ([EmailID], [EmailAddress], [EmployeeID], [EmployeePass], [DelFlag], [Remark]) VALUES (2, N'jack@gmail.com', 2, N'123', 0, N'kay')
SET IDENTITY_INSERT [dbo].[301TB_Email] OFF
INSERT [dbo].[302TB_Level] ([LevelID], [Name], [DelFlag], [Remark]) VALUES (1, N'Level1', NULL, NULL)
INSERT [dbo].[302TB_Level] ([LevelID], [Name], [DelFlag], [Remark]) VALUES (2, N'Level2', NULL, NULL)
INSERT [dbo].[302TB_Level] ([LevelID], [Name], [DelFlag], [Remark]) VALUES (3, N'Level3', NULL, NULL)
INSERT [dbo].[303TB_Position] ([PositionID], [PositionName], [PositionType], [PriorityID], [DelFlag], [Remark]) VALUES (1, N'Lead', NULL, 1, 0, NULL)
INSERT [dbo].[303TB_Position] ([PositionID], [PositionName], [PositionType], [PriorityID], [DelFlag], [Remark]) VALUES (2, N'Employee', NULL, 2, 0, NULL)
INSERT [dbo].[400TB_Branch] ([BranchID], [Name], [Location], [Address], [StartDate], [EndDate], [DelFlag], [Remark]) VALUES (1, N'HueSW', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[400TB_Branch] ([BranchID], [Name], [Location], [Address], [StartDate], [EndDate], [DelFlag], [Remark]) VALUES (2, N'SaigonSW', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[500TB_SkillManage] ([SkillID], [EmployeeID], [SkillListID], [StartDate], [DelFlag], [Remark]) VALUES (11, 1, 1, CAST(N'2018-09-27' AS Date), 0, N'pretty skilled')
INSERT [dbo].[500TB_SkillManage] ([SkillID], [EmployeeID], [SkillListID], [StartDate], [DelFlag], [Remark]) VALUES (12, 1, 2, CAST(N'2018-09-27' AS Date), 0, N'Educated.')
INSERT [dbo].[500TB_SkillManage] ([SkillID], [EmployeeID], [SkillListID], [StartDate], [DelFlag], [Remark]) VALUES (13, 1, 3, CAST(N'2018-09-27' AS Date), 1, N'not skilled')
INSERT [dbo].[500TB_SkillManage] ([SkillID], [EmployeeID], [SkillListID], [StartDate], [DelFlag], [Remark]) VALUES (14, 1, 4, CAST(N'2018-09-27' AS Date), 0, N'just started learning')
SET IDENTITY_INSERT [dbo].[501TB_SkillList] ON 

INSERT [dbo].[501TB_SkillList] ([SkillListID], [SkillName], [SkillType], [DelFlag], [Remark]) VALUES (1, N'C#', N'Coding', 0, N'JAVA rival.')
INSERT [dbo].[501TB_SkillList] ([SkillListID], [SkillName], [SkillType], [DelFlag], [Remark]) VALUES (2, N'JAVA', N'Coding', 0, N'Popular Language')
INSERT [dbo].[501TB_SkillList] ([SkillListID], [SkillName], [SkillType], [DelFlag], [Remark]) VALUES (3, N'HR', N'Management', 0, N'Essential')
INSERT [dbo].[501TB_SkillList] ([SkillListID], [SkillName], [SkillType], [DelFlag], [Remark]) VALUES (4, N'PHP', N'Coding', 0, N'good')
INSERT [dbo].[501TB_SkillList] ([SkillListID], [SkillName], [SkillType], [DelFlag], [Remark]) VALUES (5, N'Resource Manager', N'Management', 0, N'')
SET IDENTITY_INSERT [dbo].[501TB_SkillList] OFF
INSERT [dbo].[ProcedureLog] ([LogDate], [DatabaseID], [ObjectID], [ProcedureName], [ErrorLine], [ErrorMessage], [AdditionalInfo]) VALUES (CAST(N'2018-10-04T15:55:36.943' AS DateTime), 6, 1813581499, N'[SW_PerformanceManagement].[dbo].[AddAssign]', 21, N'String or binary data would be truncated.', N'')
INSERT [dbo].[ProcedureLog] ([LogDate], [DatabaseID], [ObjectID], [ProcedureName], [ErrorLine], [ErrorMessage], [AdditionalInfo]) VALUES (CAST(N'2018-10-04T16:00:32.967' AS DateTime), 6, 1813581499, N'[SW_PerformanceManagement].[dbo].[AddAssign]', 21, N'String or binary data would be truncated.', N'AddAssign Error')
INSERT [dbo].[ProcedureLog] ([LogDate], [DatabaseID], [ObjectID], [ProcedureName], [ErrorLine], [ErrorMessage], [AdditionalInfo]) VALUES (CAST(N'2018-10-08T16:51:46.230' AS DateTime), 6, 1877581727, N'[SW_PerformanceManagement].[dbo].[SaveReport]', 21, N'String or binary data would be truncated.', N'SaveReport Error')
INSERT [dbo].[ProcedureLog] ([LogDate], [DatabaseID], [ObjectID], [ProcedureName], [ErrorLine], [ErrorMessage], [AdditionalInfo]) VALUES (CAST(N'2018-10-08T17:17:42.360' AS DateTime), 6, 1877581727, N'[SW_PerformanceManagement].[dbo].[SaveReport]', 21, N'String or binary data would be truncated.', N'SaveReport Error')
INSERT [dbo].[ProcedureLog] ([LogDate], [DatabaseID], [ObjectID], [ProcedureName], [ErrorLine], [ErrorMessage], [AdditionalInfo]) VALUES (CAST(N'2018-10-11T14:18:54.360' AS DateTime), 6, 1877581727, N'[SW_PerformanceManagement].[dbo].[SaveReport]', 21, N'String or binary data would be truncated.', N'SaveReport Error')
INSERT [dbo].[ProcedureLog] ([LogDate], [DatabaseID], [ObjectID], [ProcedureName], [ErrorLine], [ErrorMessage], [AdditionalInfo]) VALUES (CAST(N'2018-10-11T15:06:31.530' AS DateTime), 6, 1877581727, N'[SW_PerformanceManagement].[dbo].[SaveReport]', 21, N'String or binary data would be truncated.', N'SaveReport Error')
INSERT [dbo].[ProcedureLog] ([LogDate], [DatabaseID], [ObjectID], [ProcedureName], [ErrorLine], [ErrorMessage], [AdditionalInfo]) VALUES (CAST(N'2018-10-11T15:20:25.613' AS DateTime), 6, 1877581727, N'[SW_PerformanceManagement].[dbo].[SaveReport]', 21, N'String or binary data would be truncated.', N'SaveReport Error')
INSERT [dbo].[ProcedureLog] ([LogDate], [DatabaseID], [ObjectID], [ProcedureName], [ErrorLine], [ErrorMessage], [AdditionalInfo]) VALUES (CAST(N'2018-10-11T15:21:16.833' AS DateTime), 6, 1877581727, N'[SW_PerformanceManagement].[dbo].[SaveReport]', 21, N'String or binary data would be truncated.', N'SaveReport Error')
INSERT [dbo].[ProcedureLog] ([LogDate], [DatabaseID], [ObjectID], [ProcedureName], [ErrorLine], [ErrorMessage], [AdditionalInfo]) VALUES (CAST(N'2018-10-11T15:22:04.227' AS DateTime), 6, 1877581727, N'[SW_PerformanceManagement].[dbo].[SaveReport]', 21, N'String or binary data would be truncated.', N'SaveReport Error')
INSERT [dbo].[ProcedureLog] ([LogDate], [DatabaseID], [ObjectID], [ProcedureName], [ErrorLine], [ErrorMessage], [AdditionalInfo]) VALUES (CAST(N'2018-10-11T15:22:51.863' AS DateTime), 6, 1877581727, N'[SW_PerformanceManagement].[dbo].[SaveReport]', 21, N'String or binary data would be truncated.', N'SaveReport Error')
INSERT [dbo].[ProcedureLog] ([LogDate], [DatabaseID], [ObjectID], [ProcedureName], [ErrorLine], [ErrorMessage], [AdditionalInfo]) VALUES (CAST(N'2018-10-11T15:24:03.507' AS DateTime), 6, 1877581727, N'[SW_PerformanceManagement].[dbo].[SaveReport]', 21, N'String or binary data would be truncated.', N'SaveReport Error')
INSERT [dbo].[ProcedureLog] ([LogDate], [DatabaseID], [ObjectID], [ProcedureName], [ErrorLine], [ErrorMessage], [AdditionalInfo]) VALUES (CAST(N'2018-10-11T15:24:46.360' AS DateTime), 6, 1877581727, N'[SW_PerformanceManagement].[dbo].[SaveReport]', 21, N'String or binary data would be truncated.', N'SaveReport Error')
INSERT [dbo].[ProcedureLog] ([LogDate], [DatabaseID], [ObjectID], [ProcedureName], [ErrorLine], [ErrorMessage], [AdditionalInfo]) VALUES (CAST(N'2018-10-11T15:25:30.413' AS DateTime), 6, 1877581727, N'[SW_PerformanceManagement].[dbo].[SaveReport]', 21, N'String or binary data would be truncated.', N'SaveReport Error')
INSERT [dbo].[ProcedureLog] ([LogDate], [DatabaseID], [ObjectID], [ProcedureName], [ErrorLine], [ErrorMessage], [AdditionalInfo]) VALUES (CAST(N'2018-10-11T15:33:49.903' AS DateTime), 6, 1877581727, N'[SW_PerformanceManagement].[dbo].[SaveReport]', 21, N'String or binary data would be truncated.', N'SaveReport Error')
INSERT [dbo].[ProcedureLog] ([LogDate], [DatabaseID], [ObjectID], [ProcedureName], [ErrorLine], [ErrorMessage], [AdditionalInfo]) VALUES (CAST(N'2018-10-11T15:34:37.037' AS DateTime), 6, 1877581727, N'[SW_PerformanceManagement].[dbo].[SaveReport]', 21, N'String or binary data would be truncated.', N'SaveReport Error')
INSERT [dbo].[ProcedureLog] ([LogDate], [DatabaseID], [ObjectID], [ProcedureName], [ErrorLine], [ErrorMessage], [AdditionalInfo]) VALUES (CAST(N'2018-10-11T15:35:51.470' AS DateTime), 6, 1877581727, N'[SW_PerformanceManagement].[dbo].[SaveReport]', 21, N'String or binary data would be truncated.', N'SaveReport Error')
INSERT [dbo].[ProcedureLog] ([LogDate], [DatabaseID], [ObjectID], [ProcedureName], [ErrorLine], [ErrorMessage], [AdditionalInfo]) VALUES (CAST(N'2018-10-11T15:36:43.253' AS DateTime), 6, 1877581727, N'[SW_PerformanceManagement].[dbo].[SaveReport]', 21, N'String or binary data would be truncated.', N'SaveReport Error')
INSERT [dbo].[ProcedureLog] ([LogDate], [DatabaseID], [ObjectID], [ProcedureName], [ErrorLine], [ErrorMessage], [AdditionalInfo]) VALUES (CAST(N'2018-10-11T15:36:49.420' AS DateTime), 6, 1877581727, N'[SW_PerformanceManagement].[dbo].[SaveReport]', 21, N'String or binary data would be truncated.', N'SaveReport Error')
INSERT [dbo].[ProcedureLog] ([LogDate], [DatabaseID], [ObjectID], [ProcedureName], [ErrorLine], [ErrorMessage], [AdditionalInfo]) VALUES (CAST(N'2018-10-11T15:46:12.283' AS DateTime), 6, 1877581727, N'[SW_PerformanceManagement].[dbo].[SaveReport]', 21, N'String or binary data would be truncated.', N'SaveReport Error')
INSERT [dbo].[ProcedureLog] ([LogDate], [DatabaseID], [ObjectID], [ProcedureName], [ErrorLine], [ErrorMessage], [AdditionalInfo]) VALUES (CAST(N'2018-10-11T15:57:17.883' AS DateTime), 6, 1877581727, N'[SW_PerformanceManagement].[dbo].[SaveReport]', 21, N'String or binary data would be truncated.', N'SaveReport Error')
INSERT [dbo].[ProcedureLog] ([LogDate], [DatabaseID], [ObjectID], [ProcedureName], [ErrorLine], [ErrorMessage], [AdditionalInfo]) VALUES (CAST(N'2018-10-11T15:57:55.243' AS DateTime), 6, 1877581727, N'[SW_PerformanceManagement].[dbo].[SaveReport]', 21, N'String or binary data would be truncated.', N'SaveReport Error')
INSERT [dbo].[ProcedureLog] ([LogDate], [DatabaseID], [ObjectID], [ProcedureName], [ErrorLine], [ErrorMessage], [AdditionalInfo]) VALUES (CAST(N'2018-10-11T15:58:01.050' AS DateTime), 6, 1877581727, N'[SW_PerformanceManagement].[dbo].[SaveReport]', 21, N'String or binary data would be truncated.', N'SaveReport Error')
INSERT [dbo].[ProcedureLog] ([LogDate], [DatabaseID], [ObjectID], [ProcedureName], [ErrorLine], [ErrorMessage], [AdditionalInfo]) VALUES (CAST(N'2018-10-11T16:01:43.520' AS DateTime), 6, 1877581727, N'[SW_PerformanceManagement].[dbo].[SaveReport]', 21, N'String or binary data would be truncated.', N'SaveReport Error')
INSERT [dbo].[ProcedureLog] ([LogDate], [DatabaseID], [ObjectID], [ProcedureName], [ErrorLine], [ErrorMessage], [AdditionalInfo]) VALUES (CAST(N'2018-10-11T16:10:16.940' AS DateTime), 6, 1877581727, N'[SW_PerformanceManagement].[dbo].[SaveReport]', 21, N'String or binary data would be truncated.', N'SaveReport Error')
INSERT [dbo].[ProcedureLog] ([LogDate], [DatabaseID], [ObjectID], [ProcedureName], [ErrorLine], [ErrorMessage], [AdditionalInfo]) VALUES (CAST(N'2018-10-11T16:10:39.200' AS DateTime), 6, 1877581727, N'[SW_PerformanceManagement].[dbo].[SaveReport]', 21, N'String or binary data would be truncated.', N'SaveReport Error')
INSERT [dbo].[ProcedureLog] ([LogDate], [DatabaseID], [ObjectID], [ProcedureName], [ErrorLine], [ErrorMessage], [AdditionalInfo]) VALUES (CAST(N'2018-10-11T16:11:05.417' AS DateTime), 6, 1877581727, N'[SW_PerformanceManagement].[dbo].[SaveReport]', 21, N'String or binary data would be truncated.', N'SaveReport Error')
INSERT [dbo].[ProcedureLog] ([LogDate], [DatabaseID], [ObjectID], [ProcedureName], [ErrorLine], [ErrorMessage], [AdditionalInfo]) VALUES (CAST(N'2018-10-11T16:12:18.170' AS DateTime), 6, 1877581727, N'[SW_PerformanceManagement].[dbo].[SaveReport]', 21, N'String or binary data would be truncated.', N'SaveReport Error')
INSERT [dbo].[ProcedureLog] ([LogDate], [DatabaseID], [ObjectID], [ProcedureName], [ErrorLine], [ErrorMessage], [AdditionalInfo]) VALUES (CAST(N'2018-10-11T16:12:47.870' AS DateTime), 6, 1877581727, N'[SW_PerformanceManagement].[dbo].[SaveReport]', 21, N'String or binary data would be truncated.', N'SaveReport Error')
INSERT [dbo].[ProcedureLog] ([LogDate], [DatabaseID], [ObjectID], [ProcedureName], [ErrorLine], [ErrorMessage], [AdditionalInfo]) VALUES (CAST(N'2018-10-11T16:13:43.673' AS DateTime), 6, 1877581727, N'[SW_PerformanceManagement].[dbo].[SaveReport]', 21, N'String or binary data would be truncated.', N'SaveReport Error')
ALTER TABLE [dbo].[ProcedureLog] ADD  DEFAULT (getdate()) FOR [LogDate]
GO
ALTER TABLE [dbo].[201TB_ProjectAssign]  WITH CHECK ADD  CONSTRAINT [FK_201TB_ProjectAssign_300TB_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[300TB_Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[201TB_ProjectAssign] CHECK CONSTRAINT [FK_201TB_ProjectAssign_300TB_Employee]
GO
/****** Object:  StoredProcedure [dbo].[AddAssign]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddAssign] 
	-- Add the parameters for the stored procedure here
	@pID int,
	@eID int,
	@rID int,
	@startDate Date,
	@endDate Date,
	@remark NVarChar(max)
AS
BEGIN TRY
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
		INSERT INTO [201TB_ProjectAssign](ProjectID,EmployeeID,ProjectRoleID,StartDate,EndDate,Remark) 
		VALUES (@pID,@eID,@rID,@startDate,@endDate,@remark)
END TRY
BEGIN CATCH
		DECLARE @msg NVARCHAR(MAX);
		SET @msg = 'AddAssign Error';
		EXEC dbo.sp_CallProcedureLog 
			@ObjectID       = @@PROCID,
			@AdditionalInfo = @msg;

		DECLARE @ErrorMessage NVARCHAR(MAX);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT 
			@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE();

    -- Use RAISERROR inside the CATCH block to return error
    -- information about the original error that caused
    -- execution to jump to the CATCH block.
		RAISERROR (@ErrorMessage, -- Message text.
				@ErrorSeverity, -- Severity.
				@ErrorState -- State.
				);               
END CATCH 
GO
/****** Object:  StoredProcedure [dbo].[AddEmployee]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddEmployee] 
	-- Add the parameters for the stored procedure here
	@eName NVarChar(50),
	@posID int,
	@braID int,
	@startDate Date,
	@endDate Date,
	@email NVarChar(50),
	@mobile NvarChar(50),
	@address NVarChar(50),
	@birth Date,
	@lvlID int,
	@desire NVarChar(50),
	@del tinyint,
	@remark NVarChar(max)
AS
BEGIN TRY
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [300TB_Employee](Name,PositionID,BranchID,StartDate,EndDate,EmailPrivate,Mobile,Address,BirthDay,LevelID,Desire,DelFlag,Remark) 
	VALUES (@eName,@posID,@braID,@startDate,@endDate,@email,@mobile,@address,@birth,@lvlID,@desire,@del,@remark)
	
END TRY
BEGIN CATCH
		DECLARE @msg NVARCHAR(MAX);
		SET @msg = 'AddEmployee Error';
		EXEC dbo.sp_CallProcedureLog 
			@ObjectID       = @@PROCID,
			@AdditionalInfo = @msg;

		DECLARE @ErrorMessage NVARCHAR(MAX);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT 
			@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE();

    -- Use RAISERROR inside the CATCH block to return error
    -- information about the original error that caused
    -- execution to jump to the CATCH block.
		RAISERROR (@ErrorMessage, -- Message text.
				@ErrorSeverity, -- Severity.
				@ErrorState -- State.
				);               
END CATCH 
GO
/****** Object:  StoredProcedure [dbo].[AddProject]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddProject] 
	-- Add the parameters for the stored procedure here
	@pName NVarChar(50),
	@pInfo NVarChar(max),
	@cName NVarChar(50),
	@cInfo NVarChar(max),
	@startDate Date,
	@endDate Date,
	@del tinyint,
	@remark NVarChar(max)
AS
BEGIN TRY
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [200TB_Project](ProjectName,ProjectInfo,CustomerName,CustomerInfo,StartDate,EndDate,DelFlag,Remark) 
	VALUES (@pName,@pInfo,@cName,@cInfo,@startDate,@endDate,@del,@remark)
END TRY
BEGIN CATCH
		DECLARE @msg NVARCHAR(MAX);
		SET @msg = 'AddProject Error';
		EXEC dbo.sp_CallProcedureLog 
			@ObjectID       = @@PROCID,
			@AdditionalInfo = @msg;

		DECLARE @ErrorMessage NVARCHAR(MAX);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT 
			@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE();

    -- Use RAISERROR inside the CATCH block to return error
    -- information about the original error that caused
    -- execution to jump to the CATCH block.
		RAISERROR (@ErrorMessage, -- Message text.
				@ErrorSeverity, -- Severity.
				@ErrorState -- State.
				);               
END CATCH 
GO
/****** Object:  StoredProcedure [dbo].[AddSkill]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddSkill] 
	-- Add the parameters for the stored procedure here
	@name NVarChar(50),
	@type NVarChar(50),
	@del tinyint,
	@remark NVarChar(max)

AS
BEGIN TRY
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [501TB_SkillList](SkillName, SkillType, DelFlag, Remark) 
	VALUES (@name, @type, @del, @remark)
	
END TRY
BEGIN CATCH
		DECLARE @msg NVARCHAR(MAX);
		SET @msg = 'AddSkill Error';
		EXEC dbo.sp_CallProcedureLog 
			@ObjectID       = @@PROCID,
			@AdditionalInfo = @msg;

		DECLARE @ErrorMessage NVARCHAR(MAX);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT 
			@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE();

    -- Use RAISERROR inside the CATCH block to return error
    -- information about the original error that caused
    -- execution to jump to the CATCH block.
		RAISERROR (@ErrorMessage, -- Message text.
				@ErrorSeverity, -- Severity.
				@ErrorState -- State.
				);               
END CATCH 
GO
/****** Object:  StoredProcedure [dbo].[AssignList]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AssignList] 
	-- Add the parameters for the stored procedure here
AS
BEGIN TRY
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [ProjectAssignID], 
	[201TB_ProjectAssign].[ProjectID], 
	[201TB_ProjectAssign].[EmployeeID], 
	[201TB_ProjectAssign].[ProjectRoleID], 
	[200TB_Project].[ProjectName], 
	[300TB_Employee].Name, 
	[202TB_ProjectRole].[ProjectRoleName], 
	[201TB_ProjectAssign].StartDate, 
	[201TB_ProjectAssign].EndDate, 
	[201TB_ProjectAssign].Remark 
	FROM [200TB_Project] 
	JOIN [201TB_ProjectAssign] on [200TB_Project].ProjectID = [201TB_ProjectAssign].ProjectID 
	JOIN [202TB_ProjectRole] on [201TB_ProjectAssign].ProjectRoleID = [202TB_ProjectRole].ProjectRoleID 
	JOIN [300TB_Employee] on [201TB_ProjectAssign].EmployeeID = [300TB_Employee].EmployeeID
	
END TRY
BEGIN CATCH
		DECLARE @msg NVARCHAR(MAX);
		SET @msg = 'AssignList Error';
		EXEC dbo.sp_CallProcedureLog 
			@ObjectID       = @@PROCID,
			@AdditionalInfo = @msg;

		DECLARE @ErrorMessage NVARCHAR(MAX);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT 
			@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE();

    -- Use RAISERROR inside the CATCH block to return error
    -- information about the original error that caused
    -- execution to jump to the CATCH block.
		RAISERROR (@ErrorMessage, -- Message text.
				@ErrorSeverity, -- Severity.
				@ErrorState -- State.
				);               
END CATCH 
GO
/****** Object:  StoredProcedure [dbo].[AssignSkill]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AssignSkill]
	-- Add the parameters for the stored procedure here
	@sID int,
	@ID int,
	@skillID int,
	@start Date,
	@del tinyint,
	@remark NVarChar(max)

AS
BEGIN TRY
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [500TB_SkillManage](SkillID, EmployeeID, SkillListID, StartDate, DelFlag, Remark) 
	VALUES (@sID, @ID, @skillID, @start, @del, @remark)
	
END TRY
BEGIN CATCH
		DECLARE @msg NVARCHAR(MAX);
		SET @msg = 'AssignSkill Error';
		EXEC dbo.sp_CallProcedureLog 
			@ObjectID       = @@PROCID,
			@AdditionalInfo = @msg;

		DECLARE @ErrorMessage NVARCHAR(MAX);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT 
			@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE();

    -- Use RAISERROR inside the CATCH block to return error
    -- information about the original error that caused
    -- execution to jump to the CATCH block.
		RAISERROR (@ErrorMessage, -- Message text.
				@ErrorSeverity, -- Severity.
				@ErrorState -- State.
				);               
END CATCH 
GO
/****** Object:  StoredProcedure [dbo].[BranchList]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BranchList]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN TRY
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT BranchID, Name FROM [400TB_Branch]
END TRY
BEGIN CATCH
		DECLARE @msg NVARCHAR(MAX);
		SET @msg = 'BranchList Error';
		EXEC dbo.sp_CallProcedureLog 
			@ObjectID       = @@PROCID,
			@AdditionalInfo = @msg;

		DECLARE @ErrorMessage NVARCHAR(MAX);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT 
			@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE();

    -- Use RAISERROR inside the CATCH block to return error
    -- information about the original error that caused
    -- execution to jump to the CATCH block.
		RAISERROR (@ErrorMessage, -- Message text.
				@ErrorSeverity, -- Severity.
				@ErrorState -- State.
				);               
END CATCH 
GO
/****** Object:  StoredProcedure [dbo].[CredCheck]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[CredCheck]
	-- Add the parameters for the stored procedure here
	@user nvarchar(50), 
	@password nvarchar(50)
AS
BEGIN TRY
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [EmployeeID]
		FROM [301TB_Email]  
		WHERE EmailAddress = @user
			AND EmployeePass = @password
			AND DelFlag = 0
END TRY
BEGIN CATCH
		DECLARE @msg NVARCHAR(MAX);
		SET @msg = 'CredCheck Error';
		EXEC dbo.sp_CallProcedureLog 
			@ObjectID       = @@PROCID,
			@AdditionalInfo = @msg;

		DECLARE @ErrorMessage NVARCHAR(MAX);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT 
			@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE();

    -- Use RAISERROR inside the CATCH block to return error
    -- information about the original error that caused
    -- execution to jump to the CATCH block.
		RAISERROR (@ErrorMessage, -- Message text.
				@ErrorSeverity, -- Severity.
				@ErrorState -- State.
				);               
END CATCH 
GO
/****** Object:  StoredProcedure [dbo].[DeleteAssign]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteAssign] 
	-- Add the parameters for the stored procedure here
	@paID int
AS
BEGIN TRY
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM [201TB_ProjectAssign] 
	WHERE ProjectAssignID = @paID
END TRY
BEGIN CATCH
		DECLARE @msg NVARCHAR(MAX);
		SET @msg = 'DeleteAssign Error';
		EXEC dbo.sp_CallProcedureLog 
			@ObjectID       = @@PROCID,
			@AdditionalInfo = @msg;

		DECLARE @ErrorMessage NVARCHAR(MAX);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT 
			@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE();

    -- Use RAISERROR inside the CATCH block to return error
    -- information about the original error that caused
    -- execution to jump to the CATCH block.
		RAISERROR (@ErrorMessage, -- Message text.
				@ErrorSeverity, -- Severity.
				@ErrorState -- State.
				);               
END CATCH 

GO
/****** Object:  StoredProcedure [dbo].[EmailCheck]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[EmailCheck] 
	-- Add the parameters for the stored procedure here
	@ID Int,
	@email NVarChar(50)
AS
BEGIN TRY
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * 
	FROM [301TB_Email] 
	WHERE EmailAddress = @email 
	AND EmployeeID <> @ID
END TRY
BEGIN CATCH
		DECLARE @msg NVARCHAR(MAX);
		SET @msg = 'EmailCheck Error';
		EXEC dbo.sp_CallProcedureLog 
			@ObjectID       = @@PROCID,
			@AdditionalInfo = @msg;

		DECLARE @ErrorMessage NVARCHAR(MAX);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT 
			@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE();

    -- Use RAISERROR inside the CATCH block to return error
    -- information about the original error that caused
    -- execution to jump to the CATCH block.
		RAISERROR (@ErrorMessage, -- Message text.
				@ErrorSeverity, -- Severity.
				@ErrorState -- State.
				);               
END CATCH 
GO
/****** Object:  StoredProcedure [dbo].[GetEmployee]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetEmployee]
	-- Add the parameters for the stored procedure here
	@ID int
AS
BEGIN TRY
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM [300TB_Employee] WHERE EmployeeID = @ID
END TRY
BEGIN CATCH
		DECLARE @msg NVARCHAR(MAX);
		SET @msg = 'GetEmployee Error';
		EXEC dbo.sp_CallProcedureLog 
			@ObjectID       = @@PROCID,
			@AdditionalInfo = @msg;

		DECLARE @ErrorMessage NVARCHAR(MAX);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT 
			@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE();

    -- Use RAISERROR inside the CATCH block to return error
    -- information about the original error that caused
    -- execution to jump to the CATCH block.
		RAISERROR (@ErrorMessage, -- Message text.
				@ErrorSeverity, -- Severity.
				@ErrorState -- State.
				);               
END CATCH 
GO
/****** Object:  StoredProcedure [dbo].[GetEmployeeDatas]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetEmployeeDatas] 
	-- Add the parameters for the stored procedure here
AS
BEGIN TRY
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [EmployeeID],[Name] FROM [300TB_Employee]
	
END TRY
BEGIN CATCH
		DECLARE @msg NVARCHAR(MAX);
		SET @msg = 'GetEmployeeDatas Error';
		EXEC dbo.sp_CallProcedureLog 
			@ObjectID       = @@PROCID,
			@AdditionalInfo = @msg;

		DECLARE @ErrorMessage NVARCHAR(MAX);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT 
			@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE();

    -- Use RAISERROR inside the CATCH block to return error
    -- information about the original error that caused
    -- execution to jump to the CATCH block.
		RAISERROR (@ErrorMessage, -- Message text.
				@ErrorSeverity, -- Severity.
				@ErrorState -- State.
				);               
END CATCH 
GO
/****** Object:  StoredProcedure [dbo].[GetPerfList]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetPerfList] 
	-- Add the parameters for the stored procedure here
AS
BEGIN TRY
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT per.*, 
	emp.[Name], 
	pro.[ProjectName] 
	FROM [100TB_Performance] per 
	JOIN [300TB_Employee] emp ON per.EmployeeID = emp.EmployeeID 
	JOIN [200TB_Project] pro ON per.ProjectID = pro.ProjectID
END TRY
BEGIN CATCH
		DECLARE @msg NVARCHAR(MAX);
		SET @msg = 'GetPerfList Error';
		EXEC dbo.sp_CallProcedureLog 
			@ObjectID       = @@PROCID,
			@AdditionalInfo = @msg;

		DECLARE @ErrorMessage NVARCHAR(MAX);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT 
			@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE();

    -- Use RAISERROR inside the CATCH block to return error
    -- information about the original error that caused
    -- execution to jump to the CATCH block.
		RAISERROR (@ErrorMessage, -- Message text.
				@ErrorSeverity, -- Severity.
				@ErrorState -- State.
				);               
END CATCH 
GO
/****** Object:  StoredProcedure [dbo].[GetProfile]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetProfile] 
	-- Add the parameters for the stored procedure here
	@ID Int
AS
BEGIN TRY
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * 
	FROM [301TB_Email] 
	WHERE EmployeeID = @ID
	
END TRY
BEGIN CATCH
		DECLARE @msg NVARCHAR(MAX);
		SET @msg = 'GetProfile Error';
		EXEC dbo.sp_CallProcedureLog 
			@ObjectID       = @@PROCID,
			@AdditionalInfo = @msg;

		DECLARE @ErrorMessage NVARCHAR(MAX);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT 
			@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE();

    -- Use RAISERROR inside the CATCH block to return error
    -- information about the original error that caused
    -- execution to jump to the CATCH block.
		RAISERROR (@ErrorMessage, -- Message text.
				@ErrorSeverity, -- Severity.
				@ErrorState -- State.
				);               
END CATCH 
GO
/****** Object:  StoredProcedure [dbo].[GetProject]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetProject] 
	-- Add the parameters for the stored procedure here
	@ID int
AS
BEGIN TRY
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ProjectName, ProjectInfo, CustomerName, CustomerInfo, Remark, StartDate, EndDate 
	FROM [200TB_Project] 
					WHERE ProjectID = @ID
					AND DelFlag = 0
END TRY
BEGIN CATCH
		DECLARE @msg NVARCHAR(MAX);
		SET @msg = 'GetProject Error';
		EXEC dbo.sp_CallProcedureLog 
			@ObjectID       = @@PROCID,
			@AdditionalInfo = @msg;

		DECLARE @ErrorMessage NVARCHAR(MAX);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT 
			@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE();

    -- Use RAISERROR inside the CATCH block to return error
    -- information about the original error that caused
    -- execution to jump to the CATCH block.
		RAISERROR (@ErrorMessage, -- Message text.
				@ErrorSeverity, -- Severity.
				@ErrorState -- State.
				);               
END CATCH 
GO
/****** Object:  StoredProcedure [dbo].[GetRights]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetRights]
	-- Add the parameters for the stored procedure here
	@ID Int
AS
BEGIN TRY
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT pr.RightID
	FROM [002TB_PriorityRight] pr
	WHERE pr.PriorityID =(SELECT p.PriorityID FROM [000TB_Priority] p
						WHERE p.PriorityID = (SELECT pos.PriorityID FROM [303TB_Position] pos
											WHERE pos.PositionID =(SELECT emp.PositionID FROM [300TB_Employee] emp
																WHERE emp.EmployeeID = @ID)))
END TRY
BEGIN CATCH
		DECLARE @msg NVARCHAR(MAX);
		SET @msg = 'GetRights Error';
		EXEC dbo.sp_CallProcedureLog 
			@ObjectID       = @@PROCID,
			@AdditionalInfo = @msg;

		DECLARE @ErrorMessage NVARCHAR(MAX);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT 
			@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE();

    -- Use RAISERROR inside the CATCH block to return error
    -- information about the original error that caused
    -- execution to jump to the CATCH block.
		RAISERROR (@ErrorMessage, -- Message text.
				@ErrorSeverity, -- Severity.
				@ErrorState -- State.
				);               
END CATCH 
GO
/****** Object:  StoredProcedure [dbo].[GetRoleData]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetRoleData] 
	-- Add the parameters for the stored procedure here
AS
BEGIN TRY
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [ProjectRoleID],[ProjectRoleName] 
	FROM [202TB_ProjectRole]
	
END TRY
BEGIN CATCH
		DECLARE @msg NVARCHAR(MAX);
		SET @msg = 'GetRoleData Error';
		EXEC dbo.sp_CallProcedureLog 
			@ObjectID       = @@PROCID,
			@AdditionalInfo = @msg;

		DECLARE @ErrorMessage NVARCHAR(MAX);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT 
			@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE();

    -- Use RAISERROR inside the CATCH block to return error
    -- information about the original error that caused
    -- execution to jump to the CATCH block.
		RAISERROR (@ErrorMessage, -- Message text.
				@ErrorSeverity, -- Severity.
				@ErrorState -- State.
				);               
END CATCH 
GO
/****** Object:  StoredProcedure [dbo].[GetUser]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetUser]
	-- Add the parameters for the stored procedure here
	@ID Int
AS
BEGIN TRY
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Name 
		FROM [300TB_Employee] Employee
		JOIN [301TB_Email] Email
		ON Employee.EmployeeID = Email.EmployeeID
		WHERE Email.EmployeeID = @ID
		
END TRY
BEGIN CATCH
		DECLARE @msg NVARCHAR(MAX);
		SET @msg = 'GetUser Error';
		EXEC dbo.sp_CallProcedureLog 
			@ObjectID       = @@PROCID,
			@AdditionalInfo = @msg;

		DECLARE @ErrorMessage NVARCHAR(MAX);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT 
			@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE();

    -- Use RAISERROR inside the CATCH block to return error
    -- information about the original error that caused
    -- execution to jump to the CATCH block.
		RAISERROR (@ErrorMessage, -- Message text.
				@ErrorSeverity, -- Severity.
				@ErrorState -- State.
				);               
END CATCH 
GO
/****** Object:  StoredProcedure [dbo].[GetUserSkill]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetUserSkill]
	-- Add the parameters for the stored procedure here
	@ID int
AS
BEGIN TRY
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT skill.SkillListID, skill.SkillName, skill.SkillType, skillmanage.DelFlag, skillmanage.Remark, skillmanage.StartDate
	FROM [501TB_SkillList] skill JOIN [500TB_SkillManage] skillmanage
	ON skill.SkillListID = skillmanage.SkillListID
	WHERE skillmanage.EmployeeID = @ID
	AND skillmanage.DelFlag = 0
	AND skill.DelFlag = 0
END TRY
BEGIN CATCH
		DECLARE @msg NVARCHAR(MAX);
		SET @msg = 'GetUserSkill Error';
		EXEC dbo.sp_CallProcedureLog 
			@ObjectID       = @@PROCID,
			@AdditionalInfo = @msg;

		DECLARE @ErrorMessage NVARCHAR(MAX);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT 
			@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE();

    -- Use RAISERROR inside the CATCH block to return error
    -- information about the original error that caused
    -- execution to jump to the CATCH block.
		RAISERROR (@ErrorMessage, -- Message text.
				@ErrorSeverity, -- Severity.
				@ErrorState -- State.
				);               
END CATCH 

GO
/****** Object:  StoredProcedure [dbo].[LevelList]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[LevelList]
	-- Add the parameters for the stored procedure here
AS
BEGIN TRY
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [LevelID], [Name] FROM [302TB_Level]
END TRY
BEGIN CATCH
		DECLARE @msg NVARCHAR(MAX);
		SET @msg = 'LevelList Error';
		EXEC dbo.sp_CallProcedureLog 
			@ObjectID       = @@PROCID,
			@AdditionalInfo = @msg;

		DECLARE @ErrorMessage NVARCHAR(MAX);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT 
			@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE();

    -- Use RAISERROR inside the CATCH block to return error
    -- information about the original error that caused
    -- execution to jump to the CATCH block.
		RAISERROR (@ErrorMessage, -- Message text.
				@ErrorSeverity, -- Severity.
				@ErrorState -- State.
				);               
END CATCH 
GO
/****** Object:  StoredProcedure [dbo].[PositionList]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PositionList]
	-- Add the parameters for the stored procedure here
AS
BEGIN TRY
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [PositionID], [PositionName] FROM [303TB_Position]
END TRY
BEGIN CATCH
		DECLARE @msg NVARCHAR(MAX);
		SET @msg = 'PositionList Error';
		EXEC dbo.sp_CallProcedureLog 
			@ObjectID       = @@PROCID,
			@AdditionalInfo = @msg;

		DECLARE @ErrorMessage NVARCHAR(MAX);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT 
			@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE();

    -- Use RAISERROR inside the CATCH block to return error
    -- information about the original error that caused
    -- execution to jump to the CATCH block.
		RAISERROR (@ErrorMessage, -- Message text.
				@ErrorSeverity, -- Severity.
				@ErrorState -- State.
				);               
END CATCH 
GO
/****** Object:  StoredProcedure [dbo].[ProjectList]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ProjectList]
	-- Add the parameters for the stored procedure here
AS
BEGIN TRY
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select [ProjectID],
                                    [ProjectName] from [200TB_Project]
END TRY
BEGIN CATCH
		DECLARE @msg NVARCHAR(MAX);
		SET @msg = 'ProjectList Error';
		EXEC dbo.sp_CallProcedureLog 
			@ObjectID       = @@PROCID,
			@AdditionalInfo = @msg;

		DECLARE @ErrorMessage NVARCHAR(MAX);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT 
			@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE();

    -- Use RAISERROR inside the CATCH block to return error
    -- information about the original error that caused
    -- execution to jump to the CATCH block.
		RAISERROR (@ErrorMessage, -- Message text.
				@ErrorSeverity, -- Severity.
				@ErrorState -- State.
				);               
END CATCH 
GO
/****** Object:  StoredProcedure [dbo].[SaveEmployee]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SaveEmployee]
	-- Add the parameters for the stored procedure here
	@eName NVarChar(50),
	@posID int,
	@braID int,
	@startDate Date,
	@endDate Date,
	@email NVarChar(50),
	@mobile NvarChar(50),
	@address NVarChar(50),
	@birth Date,
	@lvlID int,
	@desire NVarChar(50),
	@del tinyint,
	@remark NVarChar(max),
	@proID int
AS
BEGIN TRY
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
		UPDATE [300TB_Employee] SET 
		Name = @eName, 
		PositionID = @posID, 
		BranchID = @braID, 
		StartDate = @startDate, 
		EndDate = @endDate, 
		EmailPrivate = @email,
		Mobile = @mobile, 
		Address = @address, 
		BirthDay = @birth, 
		LevelID = @lvlID, 
		Desire = @desire, 
		DelFlag = @del, 
		Remark = @remark 
		WHERE EmployeeID = @proID
END TRY
BEGIN CATCH
		DECLARE @msg NVARCHAR(MAX);
		SET @msg = 'SaveEmployee Error';
		EXEC dbo.sp_CallProcedureLog 
			@ObjectID       = @@PROCID,
			@AdditionalInfo = @msg;

		DECLARE @ErrorMessage NVARCHAR(MAX);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT 
			@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE();

    -- Use RAISERROR inside the CATCH block to return error
    -- information about the original error that caused
    -- execution to jump to the CATCH block.
		RAISERROR (@ErrorMessage, -- Message text.
				@ErrorSeverity, -- Severity.
				@ErrorState -- State.
				);               
END CATCH 
GO
/****** Object:  StoredProcedure [dbo].[SaveProfile]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SaveProfile] 
	-- Add the parameters for the stored procedure here
	@eID Int,
	@eAddress NVarChar(50),
	@pass NVarChar(50),
	@del tinyint,
	@remark NvarChar(50)
AS
BEGIN TRY
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [301TB_Email] 
	SET 
	EmailAddress = @eAddress, 
	EmployeePass = @pass, 
	DelFlag = @del, 
	Remark = @remark 
	WHERE EmployeeID = @eID
END TRY
BEGIN CATCH
		DECLARE @msg NVARCHAR(MAX);
		SET @msg = 'SaveProfile Error';
		EXEC dbo.sp_CallProcedureLog 
			@ObjectID       = @@PROCID,
			@AdditionalInfo = @msg;

		DECLARE @ErrorMessage NVARCHAR(MAX);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT 
			@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE();

    -- Use RAISERROR inside the CATCH block to return error
    -- information about the original error that caused
    -- execution to jump to the CATCH block.
		RAISERROR (@ErrorMessage, -- Message text.
				@ErrorSeverity, -- Severity.
				@ErrorState -- State.
				);               
END CATCH 
GO
/****** Object:  StoredProcedure [dbo].[SaveProject]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SaveProject] 
	-- Add the parameters for the stored procedure here
	
	@pName NVarChar(50),
	@pInfo NVarChar(max),
	@cName NVarChar(50),
	@cInfo NVarChar(max),
	@startDate Date,
	@endDate Date,
	@remark NVarChar(max),
	@ID int

AS
BEGIN TRY
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [200TB_Project] 
	SET ProjectName = @pName, 
	ProjectInfo = @pInfo, 
	CustomerName = @cName, 
	CustomerInfo = @cInfo, 
	StartDate = @startDate, 
	EndDate = @endDate, 
	DelFlag = 0, 
	Remark = @remark 
	WHERE ProjectID = @ID
END TRY
BEGIN CATCH
		DECLARE @msg NVARCHAR(MAX);
		SET @msg = 'SaveProject Error';
		EXEC dbo.sp_CallProcedureLog 
			@ObjectID       = @@PROCID,
			@AdditionalInfo = @msg;

		DECLARE @ErrorMessage NVARCHAR(MAX);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT 
			@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE();

    -- Use RAISERROR inside the CATCH block to return error
    -- information about the original error that caused
    -- execution to jump to the CATCH block.
		RAISERROR (@ErrorMessage, -- Message text.
				@ErrorSeverity, -- Severity.
				@ErrorState -- State.
				);               
END CATCH 
GO
/****** Object:  StoredProcedure [dbo].[SaveReport]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SaveReport] 
	-- Add the parameters for the stored procedure here
	@pID int,
	@eID int,
	@wDate Date,
	@wHour float,
	@wName NVarChar(50),
	@wDetail NvarChar(max)
AS
BEGIN TRY
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into [100TB_Performance]([ProjectID],[EmployeeID],[WorkingDate],[WorkingHour],[WorkingName],[WorkingDetail]) 
	values (@pID,@eID,@wDate,@wHour,@wName,@wDetail)
END TRY
BEGIN CATCH
		DECLARE @msg NVARCHAR(MAX);
		SET @msg = 'SaveReport Error';
		EXEC dbo.sp_CallProcedureLog 
			@ObjectID       = @@PROCID,
			@AdditionalInfo = @msg;

		DECLARE @ErrorMessage NVARCHAR(MAX);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT 
			@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE();

    -- Use RAISERROR inside the CATCH block to return error
    -- information about the original error that caused
    -- execution to jump to the CATCH block.
		RAISERROR (@ErrorMessage, -- Message text.
				@ErrorSeverity, -- Severity.
				@ErrorState -- State.
				);               
END CATCH 
GO
/****** Object:  StoredProcedure [dbo].[SaveSkill]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SaveSkill]
	-- Add the parameters for the stored procedure here
	
	@name NVarChar(50),
	@type NVarChar(50),
	@del tinyint,
	@remark NVarChar(max),
	@editID int
AS
BEGIN TRY
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [501TB_SkillList] SET 
		SkillName = @name, 
		SkillType = @type, 
		DelFlag = @del, 
		Remark = @remark 
		WHERE SkillListID = @editID
END TRY
BEGIN CATCH
		DECLARE @msg NVARCHAR(MAX);
		SET @msg = 'SaveSkill Error';
		EXEC dbo.sp_CallProcedureLog 
			@ObjectID       = @@PROCID,
			@AdditionalInfo = @msg;

		DECLARE @ErrorMessage NVARCHAR(MAX);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT 
			@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE();

    -- Use RAISERROR inside the CATCH block to return error
    -- information about the original error that caused
    -- execution to jump to the CATCH block.
		RAISERROR (@ErrorMessage, -- Message text.
				@ErrorSeverity, -- Severity.
				@ErrorState -- State.
				);               
END CATCH 
GO
/****** Object:  StoredProcedure [dbo].[SaveSkillAssign]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SaveSkillAssign]
	-- Add the parameters for the stored procedure here
	
	
	@eID int,
	@skillID int,
	@start Date,
	@del tinyint,
	@remark NVarChar(max),
	@sID int
AS
BEGIN TRY
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [500TB_SkillManage] SET 
		EmployeeID = @eID, 
		SkillListID = @skillID, 
		StartDate = @start,
		DelFlag = @del, 
		Remark = @remark 
		WHERE SkillID = @sID
END TRY
BEGIN CATCH
		DECLARE @msg NVARCHAR(MAX);
		SET @msg = 'SaveSkillAssign Error';
		EXEC dbo.sp_CallProcedureLog 
			@ObjectID       = @@PROCID,
			@AdditionalInfo = @msg;

		DECLARE @ErrorMessage NVARCHAR(MAX);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT 
			@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE();

    -- Use RAISERROR inside the CATCH block to return error
    -- information about the original error that caused
    -- execution to jump to the CATCH block.
		RAISERROR (@ErrorMessage, -- Message text.
				@ErrorSeverity, -- Severity.
				@ErrorState -- State.
				);               
END CATCH 
GO
/****** Object:  StoredProcedure [dbo].[SearchID]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SearchID]
	-- Add the parameters for the stored procedure here
	@ID Int
AS
BEGIN TRY
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select [ProjectID]
                    FROM [200TB_Project]
                    WHERE ProjectID = @ID
                    AND DelFlag = 0
END TRY
BEGIN CATCH
		DECLARE @msg NVARCHAR(MAX);
		SET @msg = 'SearchID Error';
		EXEC dbo.sp_CallProcedureLog 
			@ObjectID       = @@PROCID,
			@AdditionalInfo = @msg;

		DECLARE @ErrorMessage NVARCHAR(MAX);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT 
			@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE();

    -- Use RAISERROR inside the CATCH block to return error
    -- information about the original error that caused
    -- execution to jump to the CATCH block.
		RAISERROR (@ErrorMessage, -- Message text.
				@ErrorSeverity, -- Severity.
				@ErrorState -- State.
				);               
END CATCH 
GO
/****** Object:  StoredProcedure [dbo].[SkillList]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SkillList]
	-- Add the parameters for the stored procedure here
AS
BEGIN TRY
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM [501TB_SkillList] WHERE DelFlag=0
END TRY
BEGIN CATCH
		DECLARE @msg NVARCHAR(MAX);
		SET @msg = 'SkillList Error';
		EXEC dbo.sp_CallProcedureLog 
			@ObjectID       = @@PROCID,
			@AdditionalInfo = @msg;

		DECLARE @ErrorMessage NVARCHAR(MAX);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT 
			@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE();

    -- Use RAISERROR inside the CATCH block to return error
    -- information about the original error that caused
    -- execution to jump to the CATCH block.
		RAISERROR (@ErrorMessage, -- Message text.
				@ErrorSeverity, -- Severity.
				@ErrorState -- State.
				);               
END CATCH 
GO
/****** Object:  StoredProcedure [dbo].[sp_CallProcedureLog]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_CallProcedureLog]
	-- Add the parameters for the stored procedure here
	@ObjectID       INT,
	@DatabaseID     INT = NULL,
	@AdditionalInfo NVARCHAR(MAX) = NULL

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DECLARE 
		@ProcedureName NVARCHAR(400);

	SELECT
		@DatabaseID = COALESCE(@DatabaseID, DB_ID()),
		@ProcedureName = COALESCE
		(
			 QUOTENAME(DB_NAME(@DatabaseID)) + '.'
			+QUOTENAME(OBJECT_SCHEMA_NAME(@ObjectID, @DatabaseID)) 
			+ '.' + QUOTENAME(OBJECT_NAME(@ObjectID, @DatabaseID)),
			 ERROR_PROCEDURE()
		);

	INSERT dbo.ProcedureLog
		(
			DatabaseID,
			ObjectID,
			ProcedureName,
			ErrorLine,
			ErrorMessage,
			AdditionalInfo
		)
	SELECT
		@DatabaseID,
		@ObjectID,
		@ProcedureName,
		ERROR_LINE(),
		ERROR_MESSAGE(),
		@AdditionalInfo;

END
GO
/****** Object:  StoredProcedure [dbo].[UpdateAssign]    Script Date: 12/6/2018 4:15:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateAssign] 
	-- Add the parameters for the stored procedure here
	@paID int,
	@pID int,
	@eID int,
	@rID int,
	@startDate Date,
	@endDate Date,
	@remark NvarChar(max)
AS
BEGIN TRY
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [201TB_ProjectAssign] 
	SET ProjectID = @pID, 
	EmployeeID = @eID, 
	ProjectRoleID = @rID, 
	StartDate = @startDate, 
	EndDate = @endDate, 
	Remark = @remark 
	WHERE ProjectAssignID = @paID
END TRY
BEGIN CATCH
		DECLARE @msg NVARCHAR(MAX);
		SET @msg = 'UpdateAssign Error';
		EXEC dbo.sp_CallProcedureLog 
			@ObjectID       = @@PROCID,
			@AdditionalInfo = @msg;

		DECLARE @ErrorMessage NVARCHAR(MAX);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT 
			@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE();

    -- Use RAISERROR inside the CATCH block to return error
    -- information about the original error that caused
    -- execution to jump to the CATCH block.
		RAISERROR (@ErrorMessage, -- Message text.
				@ErrorSeverity, -- Severity.
				@ErrorState -- State.
				);               
END CATCH 
GO
USE [master]
GO
ALTER DATABASE [SW_PerformanceManagement] SET  READ_WRITE 
GO
