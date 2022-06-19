
/****** Object:  Database [SicParvisMagnaProduction]    Script Date: 16-Sep-19 8:53:28 PM ******/
CREATE DATABASE [SicParvisMagnaProduction]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SicParvisMagnaProduction', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\SicParvisMagnaProduction.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SicParvisMagnaProduction_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\SicParvisMagnaProduction_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [SicParvisMagnaProduction] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SicParvisMagnaProduction].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SicParvisMagnaProduction] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SicParvisMagnaProduction] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SicParvisMagnaProduction] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SicParvisMagnaProduction] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SicParvisMagnaProduction] SET ARITHABORT OFF 
GO
ALTER DATABASE [SicParvisMagnaProduction] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SicParvisMagnaProduction] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SicParvisMagnaProduction] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SicParvisMagnaProduction] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SicParvisMagnaProduction] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SicParvisMagnaProduction] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SicParvisMagnaProduction] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SicParvisMagnaProduction] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SicParvisMagnaProduction] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SicParvisMagnaProduction] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SicParvisMagnaProduction] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SicParvisMagnaProduction] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SicParvisMagnaProduction] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SicParvisMagnaProduction] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SicParvisMagnaProduction] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SicParvisMagnaProduction] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SicParvisMagnaProduction] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SicParvisMagnaProduction] SET RECOVERY FULL 
GO
ALTER DATABASE [SicParvisMagnaProduction] SET  MULTI_USER 
GO
ALTER DATABASE [SicParvisMagnaProduction] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SicParvisMagnaProduction] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SicParvisMagnaProduction] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SicParvisMagnaProduction] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SicParvisMagnaProduction] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SicParvisMagnaProduction', N'ON'
GO
ALTER DATABASE [SicParvisMagnaProduction] SET QUERY_STORE = OFF
GO
USE [SicParvisMagnaProduction]
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
USE [SicParvisMagnaProduction]
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[Account_id] [uniqueidentifier] NOT NULL,
	[Title] [varchar](100) NOT NULL,
	[Type] [varchar](20) NOT NULL,
	[Description] [varchar](191) NULL,
	[Timestamp] [datetime] NOT NULL,
	[Add_by] [varchar](191) NOT NULL,
	[Status] [varchar](50) NOT NULL,
	[Flag] [tinyint] NOT NULL,
 CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED 
(
	[Account_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Adress]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adress](
	[Adress_id] [int] IDENTITY(1,1) NOT NULL,
	[User_id] [int] NOT NULL,
	[Name] [varchar](20) NOT NULL,
	[Short_name] [varchar](10) NOT NULL,
	[Description] [varchar](191) NULL,
	[Calling_Code] [varchar](5) NOT NULL,
	[Parent_id] [int] NOT NULL,
	[Timestamp] [date] NOT NULL,
	[Add_by] [varchar](191) NOT NULL,
	[status] [nvarchar](20) NOT NULL,
	[Flag] [tinyint] NULL,
 CONSTRAINT [PK_Adress] PRIMARY KEY CLUSTERED 
(
	[Adress_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Area]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Area](
	[area_id] [uniqueidentifier] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[shortname] [varchar](50) NOT NULL,
	[desc] [varchar](50) NOT NULL,
	[code] [varchar](50) NOT NULL,
	[country_id] [uniqueidentifier] NOT NULL,
	[state_id] [uniqueidentifier] NOT NULL,
	[city_id] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Area] PRIMARY KEY CLUSTERED 
(
	[area_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Assign_Experties]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Assign_Experties](
	[AssignId] [uniqueidentifier] NOT NULL,
	[ExpertiesId] [uniqueidentifier] NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[Timestamp] [datetime] NOT NULL,
	[Addby] [varchar](50) NOT NULL,
	[Status] [varchar](50) NOT NULL,
	[Flag] [tinyint] NOT NULL,
 CONSTRAINT [PK_Assign_Experties] PRIMARY KEY CLUSTERED 
(
	[AssignId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Campaign]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Campaign](
	[Campaign_id] [varchar](50) NOT NULL,
	[User_id] [int] NOT NULL,
	[Organization_id] [int] NOT NULL,
	[Organization_branch_id] [int] NOT NULL,
	[Campaign_title] [varchar](100) NOT NULL,
	[Campaign_type] [varchar](15) NOT NULL,
	[Summary] [varchar](200) NULL,
	[Amount_goal] [varchar](20) NOT NULL,
	[Adress] [varchar](100) NOT NULL,
	[Start_date] [date] NOT NULL,
	[End_date] [date] NOT NULL,
	[Timestamp] [datetime] NOT NULL,
	[Add_by] [varchar](191) NOT NULL,
	[Status] [varchar](20) NULL,
	[Flag] [tinyint] NOT NULL,
 CONSTRAINT [PK_Campaign] PRIMARY KEY CLUSTERED 
(
	[Campaign_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[City]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[City](
	[city_id] [uniqueidentifier] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[shortname] [varchar](50) NOT NULL,
	[desc] [varchar](50) NOT NULL,
	[code] [varchar](50) NOT NULL,
	[country_id] [uniqueidentifier] NOT NULL,
	[state_id] [uniqueidentifier] NOT NULL,
	[add_by] [varchar](50) NULL,
	[add_date] [datetime] NULL,
	[edit_by] [varchar](50) NULL,
	[edit_date] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comment_tab]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comment_tab](
	[Comm_id] [uniqueidentifier] NOT NULL,
	[Issue_id] [uniqueidentifier] NOT NULL,
	[title] [varchar](100) NOT NULL,
	[descript] [varchar](100) NOT NULL,
	[date] [datetime] NOT NULL,
	[flag] [tinyint] NOT NULL,
	[status] [varchar](50) NOT NULL,
	[edit_by] [varchar](50) NOT NULL,
	[attachments] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Comment_tab] PRIMARY KEY CLUSTERED 
(
	[Comm_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contact]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contact](
	[ContID] [uniqueidentifier] NOT NULL,
	[User_id] [uniqueidentifier] NOT NULL,
	[Number] [varchar](13) NOT NULL,
	[Descrip] [varchar](50) NULL,
	[AddBy] [varchar](50) NULL,
	[AddDate] [datetime] NULL,
	[Status] [varchar](50) NULL,
	[Flag] [int] NULL,
	[EditBy] [varchar](50) NULL,
	[EditDate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Country]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[country_id] [uniqueidentifier] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[shortname] [varchar](50) NOT NULL,
	[desc] [varchar](50) NOT NULL,
	[code] [varchar](50) NOT NULL,
	[add_by] [varchar](50) NULL,
	[add_date] [datetime] NULL,
	[edit_by] [varchar](50) NULL,
	[edit_date] [datetime] NULL,
 CONSTRAINT [PK_CountryEMP] PRIMARY KEY CLUSTERED 
(
	[country_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Credential_Table]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Credential_Table](
	[Id] [uniqueidentifier] NOT NULL,
	[User_id] [uniqueidentifier] NOT NULL,
	[Organization_Id] [uniqueidentifier] NOT NULL,
	[DomainAccType] [varchar](50) NOT NULL,
	[primary_email] [varchar](100) NOT NULL,
	[Recovery_Email] [varchar](100) NOT NULL,
	[Password] [varchar](15) NOT NULL,
	[Timestamp] [datetime] NOT NULL,
	[Add_by] [varchar](20) NOT NULL,
	[Status] [varchar](20) NOT NULL,
	[Flag] [tinyint] NOT NULL,
 CONSTRAINT [PK_Credential_Table] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomAttendance]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomAttendance](
	[ca_id] [int] IDENTITY(1,1) NOT NULL,
	[time_in] [datetime] NOT NULL,
	[time_out] [datetime] NOT NULL,
	[short_leave] [datetime] NOT NULL,
	[grace_time] [datetime] NOT NULL,
	[absent_after] [datetime] NOT NULL,
	[break_start] [datetime] NOT NULL,
	[employee_id] [int] NOT NULL,
	[break_end] [datetime] NOT NULL,
	[local] [bit] NULL,
	[web] [bit] NULL,
	[add_by] [varchar](50) NULL,
	[edit_by] [varchar](50) NULL,
	[add_date] [date] NULL,
	[edit_date] [date] NULL,
 CONSTRAINT [PK_CustomAttendance] PRIMARY KEY CLUSTERED 
(
	[ca_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerInvoice]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerInvoice](
	[CusIvID] [uniqueidentifier] NOT NULL,
	[ProID] [uniqueidentifier] NOT NULL,
	[Status] [varchar](50) NULL,
	[AddBy] [varchar](50) NULL,
	[AddDate] [datetime] NULL,
	[Flag] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[dept_id] [uniqueidentifier] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[shortname] [varchar](50) NOT NULL,
	[desc] [varchar](50) NOT NULL,
	[code] [varchar](50) NOT NULL,
	[company_id] [uniqueidentifier] NOT NULL,
	[branch_id] [uniqueidentifier] NOT NULL,
	[time_in] [datetime] NOT NULL,
	[time_out] [datetime] NOT NULL,
	[short_leave] [datetime] NOT NULL,
	[grace_time] [datetime] NOT NULL,
	[absent_after] [datetime] NOT NULL,
	[break_start] [datetime] NOT NULL,
	[break_end] [datetime] NOT NULL,
	[local] [bit] NULL,
	[web] [bit] NULL,
	[add_by] [varchar](50) NULL,
	[edit_by] [varchar](50) NULL,
	[add_date] [date] NULL,
	[edit_date] [date] NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[dept_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Domain_AccountTable]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Domain_AccountTable](
	[Domain_id] [uniqueidentifier] NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[Decription] [varchar](100) NULL,
	[Timestamp] [datetime] NOT NULL,
	[Add_by] [varchar](20) NOT NULL,
	[Status] [varchar](20) NOT NULL,
	[Flag] [tinyint] NOT NULL,
 CONSTRAINT [PK_Domain_AccountTable] PRIMARY KEY CLUSTERED 
(
	[Domain_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Donation]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Donation](
	[Donation_id] [int] IDENTITY(1,1) NOT NULL,
	[User_id] [int] NOT NULL,
	[Campaign_id] [int] NOT NULL,
	[donor_id] [int] NOT NULL,
	[Reciever_id] [int] NOT NULL,
	[Expense_id] [int] NOT NULL,
	[Timestamp] [datetime] NOT NULL,
	[Add_by] [varchar](191) NOT NULL,
	[Status] [nvarchar](20) NOT NULL,
	[Flag] [tinyint] NULL,
 CONSTRAINT [PK_Donation] PRIMARY KEY CLUSTERED 
(
	[Donation_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee_CompanyInfo]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee_CompanyInfo](
	[employeeCompany_id] [uniqueidentifier] NOT NULL,
	[jobstatus_id] [uniqueidentifier] NOT NULL,
	[employee_id] [uniqueidentifier] NOT NULL,
	[salary] [varchar](50) NOT NULL,
	[designation] [varchar](50) NOT NULL,
	[scale] [varchar](50) NOT NULL,
	[date_of_join] [date] NOT NULL,
	[leavedate] [date] NULL,
 CONSTRAINT [PK_Employee_CompanyInfo] PRIMARY KEY CLUSTERED 
(
	[employeeCompany_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee_CustomAttendence]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee_CustomAttendence](
	[Attendence_id] [uniqueidentifier] NOT NULL,
	[Employee_id] [uniqueidentifier] NOT NULL,
	[time_in] [datetime] NULL,
	[time_out] [datetime] NULL,
	[short_leave] [datetime] NULL,
	[grace_time] [datetime] NULL,
	[absent_after] [datetime] NULL,
	[break_start] [datetime] NULL,
	[break_end] [datetime] NULL,
	[add_by] [varchar](50) NULL,
	[edit_by] [varchar](50) NULL,
	[add_date] [date] NULL,
	[edit_date] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee_Fmd]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee_Fmd](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[employ_id] [int] NULL,
	[fmd] [nvarchar](999) NULL,
 CONSTRAINT [PK_Employee_Fmd] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee_PersonalInfo]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee_PersonalInfo](
	[employee_id] [uniqueidentifier] NOT NULL,
	[firstname] [varchar](50) NOT NULL,
	[lastname] [varchar](50) NOT NULL,
	[CNIC] [nvarchar](50) NOT NULL,
	[dob] [date] NOT NULL,
	[phone] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[country_id] [uniqueidentifier] NOT NULL,
	[state_id] [uniqueidentifier] NOT NULL,
	[city_id] [uniqueidentifier] NOT NULL,
	[area_id] [uniqueidentifier] NOT NULL,
	[address_type] [varchar](50) NOT NULL,
	[address1] [varchar](50) NOT NULL,
	[address2] [varchar](50) NOT NULL,
	[Organization_id] [uniqueidentifier] NOT NULL,
	[Branch_id] [uniqueidentifier] NOT NULL,
	[dept_id] [uniqueidentifier] NOT NULL,
	[office_id] [uniqueidentifier] NOT NULL,
	[section_id] [uniqueidentifier] NOT NULL,
	[attendance_type] [varchar](50) NOT NULL,
	[registration] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Employee_PersonalInfo] PRIMARY KEY CLUSTERED 
(
	[employee_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Expense]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expense](
	[Expense_id] [int] IDENTITY(1,1) NOT NULL,
	[User_id] [int] NOT NULL,
	[Campaign_id] [int] NOT NULL,
	[Item_name] [varchar](100) NOT NULL,
	[Price] [varchar](15) NOT NULL,
	[Description] [varchar](200) NOT NULL,
	[Timestamp] [datetime] NOT NULL,
	[Add_by] [varchar](20) NULL,
	[Status] [nvarchar](20) NULL,
	[Flag] [tinyint] NOT NULL,
 CONSTRAINT [PK_Expense] PRIMARY KEY CLUSTERED 
(
	[Expense_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fetch]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fetch](
	[id] [uniqueidentifier] NOT NULL,
	[text] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Global_attendance]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Global_attendance](
	[ga_id] [int] IDENTITY(1,1) NOT NULL,
	[time_in] [datetime] NOT NULL,
	[time_out] [datetime] NOT NULL,
	[short_leave] [datetime] NOT NULL,
	[grace_time] [datetime] NOT NULL,
	[absent_after] [datetime] NOT NULL,
	[break_start] [datetime] NOT NULL,
	[break_end] [datetime] NOT NULL,
	[local] [bit] NULL,
	[web] [bit] NULL,
	[add_by] [varchar](50) NULL,
	[edit_by] [varchar](50) NULL,
	[add_date] [date] NULL,
	[edit_date] [date] NULL,
 CONSTRAINT [PK_Global_attendance] PRIMARY KEY CLUSTERED 
(
	[ga_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HCC_Balance]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HCC_Balance](
	[id] [uniqueidentifier] NOT NULL,
	[amount] [float] NULL,
	[type] [nvarchar](50) NULL,
	[date] [date] NULL,
	[AddDate] [datetime] NULL,
	[Addby] [varchar](50) NULL,
	[Editby] [varchar](50) NULL,
	[EditDate] [datetime] NULL,
	[Flag] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[InvoiceID] [uniqueidentifier] NOT NULL,
	[InvoiceNo] [varchar](50) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[ShortName] [varchar](50) NOT NULL,
	[Code] [varchar](50) NOT NULL,
	[Descrip] [varchar](50) NULL,
	[SerialNo] [varchar](50) NOT NULL,
	[DesignatedCost] [varchar](50) NOT NULL,
	[PurchaseOrderNo] [varchar](50) NOT NULL,
	[User_id] [uniqueidentifier] NOT NULL,
	[FromDate] [date] NOT NULL,
	[ToDate] [date] NOT NULL,
	[Date] [date] NOT NULL,
	[Status] [varchar](50) NOT NULL,
	[AddBy] [varchar](50) NULL,
	[AddDate] [datetime] NULL,
	[Flag] [int] NULL,
	[EditBy] [varchar](50) NULL,
	[EditDate] [datetime] NULL,
	[TaxID] [uniqueidentifier] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InvoiceItems]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvoiceItems](
	[InVoiceItemID] [uniqueidentifier] NOT NULL,
	[EntryNo] [varchar](50) NOT NULL,
	[CustomerNo] [varchar](50) NOT NULL,
	[InvoiceID] [uniqueidentifier] NOT NULL,
	[ProID] [uniqueidentifier] NOT NULL,
	[Qty] [varchar](50) NOT NULL,
	[Price] [varchar](50) NOT NULL,
	[ValueExclusiveTax] [varchar](50) NOT NULL,
	[RatesOFSalesTax] [varchar](50) NOT NULL,
	[SalesTaxPayable] [varchar](50) NOT NULL,
	[ValueIncludingTax] [varchar](50) NOT NULL,
	[Status] [varchar](50) NOT NULL,
	[AddBy] [varchar](50) NULL,
	[AddDate] [datetime] NULL,
	[Flag] [int] NULL,
	[EditBy] [varchar](50) NULL,
	[EditDate] [datetime] NULL,
	[Remaining] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[issue_abuse_tab]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[issue_abuse_tab](
	[Abuse_id] [int] NOT NULL,
	[issue_id] [int] NOT NULL,
	[Addby] [nchar](20) NOT NULL,
	[status] [nchar](20) NOT NULL,
	[flag] [tinyint] NOT NULL,
	[timestampp] [datetime] NOT NULL,
 CONSTRAINT [PK_issue_abuse_tab] PRIMARY KEY CLUSTERED 
(
	[Abuse_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Issue_labels]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Issue_labels](
	[Id] [uniqueidentifier] NOT NULL,
	[Issue_id] [uniqueidentifier] NOT NULL,
	[label_id] [uniqueidentifier] NOT NULL,
	[addby] [varchar](50) NOT NULL,
	[flag] [tinyint] NOT NULL,
	[status] [varchar](50) NOT NULL,
	[timestamp] [datetime] NOT NULL,
 CONSTRAINT [PK_Issue_labels] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[issue_like_tab]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[issue_like_tab](
	[issue_id] [int] NOT NULL,
	[likes] [nchar](30) NOT NULL,
	[dislikes] [nchar](30) NOT NULL,
	[Addby] [nchar](30) NOT NULL,
	[status] [nchar](20) NOT NULL,
	[flag] [tinyint] NOT NULL,
	[timestampp] [datetime] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Issue_tab]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Issue_tab](
	[Issue_id] [uniqueidentifier] NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[descript] [varchar](50) NOT NULL,
	[Addby] [varchar](50) NOT NULL,
	[due_date] [datetime] NOT NULL,
	[status] [varchar](50) NOT NULL,
	[flag] [tinyint] NOT NULL,
	[timestampp] [datetime] NOT NULL,
	[label_id] [uniqueidentifier] NOT NULL,
	[dept_id] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_issue_tab] PRIMARY KEY CLUSTERED 
(
	[Issue_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item](
	[item_id] [uniqueidentifier] NOT NULL,
	[name] [nvarchar](max) NOT NULL,
	[shortname] [nvarchar](max) NOT NULL,
	[code] [nvarchar](max) NOT NULL,
	[desc] [nvarchar](max) NOT NULL,
	[price] [int] NOT NULL,
	[itemCat_id] [uniqueidentifier] NOT NULL,
	[status] [bit] NOT NULL,
	[AddDate] [datetime] NULL,
	[Addby] [varchar](50) NULL,
	[EditDate] [datetime] NULL,
	[Editby] [varchar](50) NULL,
	[Flag] [int] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item_Category]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item_Category](
	[itemCat_id] [uniqueidentifier] NOT NULL,
	[name] [nvarchar](max) NOT NULL,
	[shortname] [nvarchar](max) NOT NULL,
	[code] [nvarchar](max) NOT NULL,
	[desc] [nvarchar](max) NOT NULL,
	[status] [bit] NOT NULL,
	[Addby] [varchar](50) NULL,
	[AddDate] [datetime] NULL,
	[Editby] [varchar](50) NULL,
	[EditDate] [datetime] NULL,
	[Flag] [int] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Jobstatus]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jobstatus](
	[jobstatus_id] [uniqueidentifier] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[shortname] [varchar](50) NOT NULL,
	[desc] [varchar](50) NOT NULL,
	[code] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Jobstatus] PRIMARY KEY CLUSTERED 
(
	[jobstatus_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lab]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lab](
	[lab_id] [uniqueidentifier] NOT NULL,
	[name] [nvarchar](max) NOT NULL,
	[shortname] [nvarchar](max) NOT NULL,
	[code] [nvarchar](max) NOT NULL,
	[desctiption] [nvarchar](max) NOT NULL,
	[National_Tax_Number] [nvarchar](max) NOT NULL,
	[Goods_And_Services_Tax] [nvarchar](max) NOT NULL,
	[Guarranty] [nvarchar](max) NOT NULL,
	[Standard_Report_Number] [nvarchar](max) NOT NULL,
	[phone] [nvarchar](max) NOT NULL,
	[address] [nvarchar](max) NOT NULL,
	[email] [nvarchar](max) NOT NULL,
	[Bank_account_number] [nvarchar](max) NOT NULL,
	[International_Account_Number] [nvarchar](max) NOT NULL,
	[status] [bit] NOT NULL,
	[type] [nvarchar](max) NULL,
	[Addby] [varchar](50) NULL,
	[AddDate] [datetime] NULL,
	[Editby] [varchar](50) NULL,
	[EditDate] [datetime] NULL,
	[Flag] [int] NOT NULL,
 CONSTRAINT [PK_dbo.lab] PRIMARY KEY CLUSTERED 
(
	[lab_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lab_invoice]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lab_invoice](
	[lab_invoice_id] [uniqueidentifier] NOT NULL,
	[lab_test_id] [uniqueidentifier] NOT NULL,
	[patient_id] [uniqueidentifier] NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[price] [int] NOT NULL,
	[discountAmt] [float] NULL,
	[discount] [float] NOT NULL,
	[netAmount] [int] NOT NULL,
	[status] [bit] NOT NULL,
	[Date] [datetime] NULL,
	[Addby] [varchar](50) NULL,
	[AddDate] [datetime] NULL,
	[Editby] [varchar](50) NULL,
	[EditDate] [datetime] NULL,
	[Flag] [int] NULL,
 CONSTRAINT [PK_dbo.lab_invoice] PRIMARY KEY CLUSTERED 
(
	[lab_invoice_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lab_invoice_income]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lab_invoice_income](
	[lab_invoice_income_id] [uniqueidentifier] NOT NULL,
	[lab_test_id] [uniqueidentifier] NOT NULL,
	[patient_id] [uniqueidentifier] NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[price] [int] NOT NULL,
	[discountAmt] [float] NULL,
	[discount] [float] NOT NULL,
	[netAmount] [int] NOT NULL,
	[welfarediscount] [int] NOT NULL,
	[nettotal] [int] NOT NULL,
	[status] [bit] NOT NULL,
	[Date] [datetime] NULL,
	[Addby] [varchar](50) NULL,
	[AddDate] [datetime] NULL,
	[Editby] [varchar](50) NULL,
	[EditDate] [datetime] NULL,
	[Flag] [int] NULL,
 CONSTRAINT [PK_dbo.lab_invoice_income] PRIMARY KEY CLUSTERED 
(
	[lab_invoice_income_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lab_test]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lab_test](
	[lab_test_id] [uniqueidentifier] NOT NULL,
	[lab_id] [uniqueidentifier] NOT NULL,
	[test_id] [uniqueidentifier] NOT NULL,
	[name] [nvarchar](max) NOT NULL,
	[price] [float] NOT NULL,
	[status] [bit] NOT NULL,
	[Addby] [varchar](50) NULL,
	[AddDate] [datetime] NULL,
	[Editby] [varchar](50) NULL,
	[EditDate] [datetime] NULL,
	[Flag] [int] NULL,
 CONSTRAINT [PK_dbo.lab_test] PRIMARY KEY CLUSTERED 
(
	[lab_test_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[label_tab]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[label_tab](
	[label_id] [uniqueidentifier] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[description] [varchar](50) NOT NULL,
	[color_code] [varchar](50) NOT NULL,
	[Addby] [varchar](50) NOT NULL,
	[Status] [varchar](50) NOT NULL,
	[flag] [tinyint] NOT NULL,
	[timestampp] [datetime] NOT NULL,
 CONSTRAINT [PK_label_tab] PRIMARY KEY CLUSTERED 
(
	[label_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[Login_id] [int] IDENTITY(1,1) NOT NULL,
	[User_id] [int] NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Password] [varchar](15) NOT NULL,
	[Account_type] [varchar](50) NOT NULL,
	[Timestamp] [datetime] NOT NULL,
	[Add_by] [varchar](191) NOT NULL,
	[Status] [varchar](20) NOT NULL,
	[Flag] [tinyint] NOT NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[Login_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicine]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicine](
	[Medicine_id] [uniqueidentifier] NOT NULL,
	[Medicine_Category_id] [uniqueidentifier] NOT NULL,
	[name] [nvarchar](max) NOT NULL,
	[shortname] [nvarchar](max) NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[code] [nvarchar](max) NOT NULL,
	[company_name] [nvarchar](max) NOT NULL,
	[formula_name] [nvarchar](max) NOT NULL,
	[rs] [float] NOT NULL,
	[rm] [float] NOT NULL,
	[status] [bit] NOT NULL,
	[opened] [float] NOT NULL,
	[quantityineach] [float] NOT NULL,
	[unit] [nvarchar](50) NULL,
	[InStock] [bit] NULL,
	[Addby] [varchar](50) NULL,
	[AddDate] [datetime] NULL,
	[Editby] [varchar](50) NULL,
	[EditDate] [datetime] NULL,
	[Flag] [int] NULL,
 CONSTRAINT [PK_dbo.Medicine] PRIMARY KEY CLUSTERED 
(
	[Medicine_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicine_Category]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicine_Category](
	[Medicine_Category_id] [uniqueidentifier] NOT NULL,
	[name] [nvarchar](max) NOT NULL,
	[shortname] [nvarchar](max) NOT NULL,
	[code] [nvarchar](max) NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[AddDate] [datetime] NULL,
	[Addby] [nvarchar](max) NULL,
	[EditDate] [datetime] NULL,
	[Editby] [nvarchar](max) NULL,
	[status] [bit] NOT NULL,
	[Flag] [int] NULL,
 CONSTRAINT [PK_dbo.Medicine_Category] PRIMARY KEY CLUSTERED 
(
	[Medicine_Category_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MedicineInvoice]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedicineInvoice](
	[PartyName] [varchar](50) NULL,
	[PartyPhone] [varchar](50) NULL,
	[PartyAddress] [varchar](50) NULL,
	[Date] [datetime] NULL,
	[Name] [varchar](50) NULL,
	[Batch] [varchar](50) NULL,
	[Price] [float] NULL,
	[Qty] [varchar](50) NULL,
	[Discount] [float] NULL,
	[DiscountAmount] [float] NULL,
	[Tax] [float] NULL,
	[TaxAmount] [float] NULL,
	[NetAmount] [float] NULL,
	[InvoiceNumber] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MedicineList]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedicineList](
	[Category] [varchar](50) NULL,
	[Name] [varchar](50) NULL,
	[Company] [varchar](50) NULL,
	[Formula] [varchar](50) NULL,
	[Rs] [float] NULL,
	[Rm] [float] NULL,
	[Total] [float] NULL,
	[Qty] [varchar](50) NULL,
	[Date] [datetime] NULL,
	[TotalQty] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Office]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Office](
	[office_id] [uniqueidentifier] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[shortname] [varchar](50) NOT NULL,
	[desc] [varchar](50) NOT NULL,
	[code] [varchar](50) NOT NULL,
	[dept_id] [uniqueidentifier] NOT NULL,
	[time_in] [datetime] NOT NULL,
	[time_out] [datetime] NOT NULL,
	[short_leave] [datetime] NOT NULL,
	[grace_time] [datetime] NOT NULL,
	[absent_after] [datetime] NOT NULL,
	[break_start] [datetime] NOT NULL,
	[break_end] [datetime] NOT NULL,
	[local] [bit] NULL,
	[web] [bit] NULL,
	[add_by] [varchar](50) NULL,
	[edit_by] [varchar](50) NULL,
	[add_date] [date] NULL,
	[edit_date] [date] NULL,
 CONSTRAINT [PK_Office] PRIMARY KEY CLUSTERED 
(
	[office_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Organization]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Organization](
	[Organization_id] [uniqueidentifier] NOT NULL,
	[User_id] [uniqueidentifier] NOT NULL,
	[Parent_id] [uniqueidentifier] NULL,
	[Title] [varchar](100) NULL,
	[Short_Name] [varchar](20) NULL,
	[Description] [varchar](200) NULL,
	[Type] [varchar](20) NOT NULL,
	[Regestration_Date] [date] NULL,
	[Expiry_Date] [date] NULL,
	[Update_Date] [date] NULL,
	[Regestrar_Name] [varchar](100) NULL,
	[Tech_Persoan_Name] [varchar](100) NULL,
	[Regestration_Email] [varchar](100) NULL,
	[Name_Server1] [varchar](100) NULL,
	[Name_Server2] [varchar](100) NULL,
	[Name_Server3] [varchar](100) NULL,
	[Name_Server4] [varchar](100) NULL,
	[Name_Server5] [varchar](100) NULL,
	[Timestamp] [datetime] NULL,
	[Add_by] [varchar](191) NULL,
	[Status] [varchar](50) NOT NULL,
	[Flag] [tinyint] NOT NULL,
	[HeaderPicturePath] [varchar](max) NULL,
 CONSTRAINT [PK_Organization] PRIMARY KEY CLUSTERED 
(
	[Organization_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pages]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pages](
	[PgID] [uniqueidentifier] NOT NULL,
	[PgURL] [varchar](50) NOT NULL,
	[Timestamp] [datetime] NULL,
	[AddBy] [varchar](50) NULL,
	[Status] [varchar](50) NULL,
	[Flag] [int] NULL,
	[EditBy] [varchar](50) NULL,
	[EditDate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Party]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Party](
	[p_id] [uniqueidentifier] NOT NULL,
	[name] [nvarchar](max) NOT NULL,
	[shortname] [nvarchar](max) NOT NULL,
	[code] [nvarchar](max) NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[add] [nvarchar](max) NOT NULL,
	[National_Tax_Number] [nvarchar](max) NOT NULL,
	[Goods_And_Services_Tax] [nvarchar](max) NOT NULL,
	[Guarranty] [nvarchar](max) NOT NULL,
	[Standard_Report_Number] [nvarchar](max) NOT NULL,
	[phone] [nvarchar](max) NOT NULL,
	[address] [nvarchar](max) NOT NULL,
	[email] [nvarchar](max) NOT NULL,
	[Bank_account_number] [nvarchar](max) NOT NULL,
	[International_Account_Number] [nvarchar](max) NOT NULL,
	[status] [bit] NOT NULL,
	[Addby] [varchar](50) NULL,
	[AddDate] [datetime] NULL,
	[Editby] [varchar](50) NULL,
	[EditDate] [datetime] NULL,
	[Flag] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Party] PRIMARY KEY CLUSTERED 
(
	[p_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[party_invoice]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[party_invoice](
	[party_invoice_id] [uniqueidentifier] NOT NULL,
	[entry_no] [varchar](50) NOT NULL,
	[customer_no] [int] NOT NULL,
	[p_id] [uniqueidentifier] NOT NULL,
	[status] [bit] NOT NULL,
	[date] [datetime] NULL,
	[Addby] [varchar](50) NULL,
	[AddDate] [datetime] NULL,
	[Editby] [varchar](50) NULL,
	[EditDate] [datetime] NULL,
	[Flag] [int] NOT NULL,
 CONSTRAINT [PK_dbo.party_invoice] PRIMARY KEY CLUSTERED 
(
	[party_invoice_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[party_invoice_medicine]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[party_invoice_medicine](
	[party_invoice_medicine_id] [uniqueidentifier] NOT NULL,
	[medicine_id] [uniqueidentifier] NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[price] [float] NOT NULL,
	[quantity] [float] NOT NULL,
	[discount_percentage] [float] NOT NULL,
	[discount_amount] [float] NOT NULL,
	[tax_percentage] [int] NOT NULL,
	[tax_amount] [float] NOT NULL,
	[net_amount] [float] NOT NULL,
	[party_invoice_id] [uniqueidentifier] NOT NULL,
	[Date] [datetime] NULL,
	[status] [bit] NOT NULL,
	[packprice] [float] NULL,
	[Addby] [varchar](50) NULL,
	[AddDate] [datetime] NULL,
	[Editby] [varchar](50) NULL,
	[EditDate] [datetime] NULL,
	[Flag] [int] NOT NULL,
 CONSTRAINT [PK_dbo.party_invoice_medicine] PRIMARY KEY CLUSTERED 
(
	[party_invoice_medicine_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[party_invoice_product]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[party_invoice_product](
	[party_invoice_product_id] [uniqueidentifier] NOT NULL,
	[Pro_id] [uniqueidentifier] NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[price] [float] NOT NULL,
	[quantity] [float] NOT NULL,
	[discount_percentage] [float] NOT NULL,
	[discount_amount] [float] NOT NULL,
	[tax_percentage] [int] NOT NULL,
	[tax_amount] [float] NOT NULL,
	[net_amount] [float] NOT NULL,
	[party_invoice_id] [uniqueidentifier] NOT NULL,
	[Date] [datetime] NULL,
	[status] [bit] NOT NULL,
	[packprice] [float] NULL,
	[Addby] [varchar](50) NULL,
	[AddDate] [datetime] NULL,
	[Editby] [varchar](50) NULL,
	[EditDate] [datetime] NULL,
	[Flag] [int] NOT NULL,
 CONSTRAINT [PK_dbo.party_invoice_product] PRIMARY KEY CLUSTERED 
(
	[party_invoice_product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[patient_basic]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patient_basic](
	[patient_id] [uniqueidentifier] NOT NULL,
	[patient_name] [nvarchar](max) NOT NULL,
	[patient_gender] [nvarchar](max) NOT NULL,
	[patient_Age] [int] NOT NULL,
	[patient_Date_of_Birth] [datetime] NULL,
	[patient_record_no] [nvarchar](max) NOT NULL,
	[Addby] [nvarchar](max) NULL,
	[AddDate] [datetime] NULL,
	[Editby] [nvarchar](max) NULL,
	[EditDate] [datetime] NULL,
	[status] [bit] NULL,
	[patient_Age_month] [int] NULL,
	[Flag] [int] NULL,
 CONSTRAINT [PK_dbo.patient_basic] PRIMARY KEY CLUSTERED 
(
	[patient_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[patient_contact_address]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patient_contact_address](
	[patient_contact_address_id] [uniqueidentifier] NOT NULL,
	[patient_id] [uniqueidentifier] NOT NULL,
	[email] [nvarchar](max) NOT NULL,
	[home_phone] [nvarchar](max) NOT NULL,
	[personal_phone] [nvarchar](max) NOT NULL,
	[office_phone] [nvarchar](max) NOT NULL,
	[first_address] [nvarchar](max) NOT NULL,
	[second_address] [nvarchar](max) NOT NULL,
	[country_id] [uniqueidentifier] NOT NULL,
	[state_id] [uniqueidentifier] NOT NULL,
	[city_id] [uniqueidentifier] NOT NULL,
	[area_id] [uniqueidentifier] NOT NULL,
	[zipcode] [int] NOT NULL,
	[Addby] [nvarchar](max) NULL,
	[AddDate] [datetime] NULL,
	[Editby] [nvarchar](max) NULL,
	[EditDate] [nvarchar](max) NULL,
	[status] [bit] NULL,
	[Flag] [int] NULL,
 CONSTRAINT [PK_dbo.patient_contact_address] PRIMARY KEY CLUSTERED 
(
	[patient_contact_address_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[patient_Next_of_kin]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patient_Next_of_kin](
	[patient_Next_of_kin_id] [uniqueidentifier] NOT NULL,
	[patient_id] [uniqueidentifier] NOT NULL,
	[name] [nvarchar](max) NOT NULL,
	[relation_to_patient] [nvarchar](max) NOT NULL,
	[phone_no] [nvarchar](max) NOT NULL,
	[first_address] [nvarchar](max) NOT NULL,
	[second_address] [nvarchar](max) NOT NULL,
	[country_id] [uniqueidentifier] NOT NULL,
	[state_id] [uniqueidentifier] NOT NULL,
	[city_id] [uniqueidentifier] NOT NULL,
	[area_id] [uniqueidentifier] NOT NULL,
	[zipcode] [nvarchar](max) NOT NULL,
	[AddDate] [datetime] NULL,
	[Addby] [nvarchar](max) NULL,
	[EditDate] [datetime] NULL,
	[Editby] [nvarchar](max) NULL,
	[status] [bit] NOT NULL,
	[Flag] [int] NULL,
 CONSTRAINT [PK_dbo.patient_Next_of_kin] PRIMARY KEY CLUSTERED 
(
	[patient_Next_of_kin_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[patient_prescription]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patient_prescription](
	[patient_prescription_id] [uniqueidentifier] NOT NULL,
	[patient_id] [uniqueidentifier] NOT NULL,
	[assigned_Date] [datetime] NULL,
	[total_cost] [int] NOT NULL,
	[status] [bit] NOT NULL,
	[type] [varchar](50) NULL,
	[Addby] [varchar](50) NULL,
	[AddDate] [datetime] NULL,
	[Editby] [varchar](50) NULL,
	[EditDate] [datetime] NULL,
	[Flag] [int] NULL,
 CONSTRAINT [PK_dbo.patient_prescription] PRIMARY KEY CLUSTERED 
(
	[patient_prescription_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[patient_prescription_LabTest]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patient_prescription_LabTest](
	[patient_prescription_LabTest_id] [uniqueidentifier] NOT NULL,
	[patient_prescription_id] [uniqueidentifier] NOT NULL,
	[lab_test_id] [uniqueidentifier] NOT NULL,
	[price] [int] NOT NULL,
	[discount] [float] NOT NULL,
	[total_price] [float] NOT NULL,
	[status] [bit] NOT NULL,
	[welfare_discount] [float] NULL,
	[net_total] [float] NULL,
	[Addby] [varchar](50) NULL,
	[AddDate] [datetime] NULL,
	[Editby] [varchar](50) NULL,
	[EditDate] [datetime] NULL,
	[Flag] [int] NULL,
 CONSTRAINT [PK_dbo.patient_prescription_LabTest] PRIMARY KEY CLUSTERED 
(
	[patient_prescription_LabTest_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[patient_prescription_medicine]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patient_prescription_medicine](
	[patient_prescription_medicine_id] [uniqueidentifier] NOT NULL,
	[patient_prescription_id] [uniqueidentifier] NOT NULL,
	[medicine_id] [uniqueidentifier] NOT NULL,
	[price] [float] NOT NULL,
	[quantity] [int] NOT NULL,
	[total_price] [float] NOT NULL,
	[status] [bit] NOT NULL,
	[pricing_id] [int] NULL,
	[welfare_discount] [float] NULL,
	[net_total] [float] NULL,
	[Addby] [varchar](50) NULL,
	[AddDate] [datetime] NULL,
	[Editby] [varchar](50) NULL,
	[EditDate] [datetime] NULL,
	[Flag] [int] NULL,
 CONSTRAINT [PK_dbo.patient_prescription_medicine] PRIMARY KEY CLUSTERED 
(
	[patient_prescription_medicine_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permission]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permission](
	[PerID] [uniqueidentifier] NOT NULL,
	[PerUID] [varchar](50) NULL,
	[PgID] [uniqueidentifier] NOT NULL,
	[User_id] [uniqueidentifier] NOT NULL,
	[PerAdd] [bit] NULL,
	[PerEdit] [bit] NULL,
	[PerView] [bit] NULL,
	[PerDel] [bit] NULL,
	[Timestamp] [datetime] NULL,
	[AddBy] [varchar](50) NULL,
	[Status] [varchar](50) NULL,
	[Flag] [int] NULL,
	[EditBy] [varchar](50) NULL,
	[EditDate] [datetime] NULL,
 CONSTRAINT [PK_Permission] PRIMARY KEY CLUSTERED 
(
	[PerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pricing]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pricing](
	[PriceID] [uniqueidentifier] NOT NULL,
	[ProID] [uniqueidentifier] NOT NULL,
	[CatID] [uniqueidentifier] NOT NULL,
	[Price] [varchar](50) NOT NULL,
	[Qty] [varchar](50) NOT NULL,
	[Total] [varchar](50) NOT NULL,
	[Date] [date] NOT NULL,
	[Status] [varchar](50) NOT NULL,
	[Remaining] [varchar](50) NOT NULL,
	[InvoiceID] [uniqueidentifier] NOT NULL,
	[AddBy] [varchar](50) NULL,
	[AddDate] [datetime] NULL,
	[Flag] [int] NULL,
	[EditBy] [varchar](50) NULL,
	[EditDate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Pro_id] [uniqueidentifier] NOT NULL,
	[Product_Category_id] [uniqueidentifier] NOT NULL,
	[name] [nvarchar](max) NOT NULL,
	[shortname] [nvarchar](max) NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[code] [nvarchar](max) NOT NULL,
	[company_name] [nvarchar](max) NOT NULL,
	[formula_name] [nvarchar](max) NOT NULL,
	[rs] [float] NOT NULL,
	[rm] [float] NOT NULL,
	[status] [bit] NOT NULL,
	[opened] [float] NOT NULL,
	[quantityineach] [float] NOT NULL,
	[unit] [nvarchar](50) NULL,
	[InStock] [bit] NULL,
	[Addby] [varchar](50) NULL,
	[AddDate] [datetime] NULL,
	[Editby] [varchar](50) NULL,
	[EditDate] [datetime] NULL,
	[Flag] [int] NULL,
 CONSTRAINT [PK_dbo.Product] PRIMARY KEY CLUSTERED 
(
	[Pro_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product_Category]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product_Category](
	[id] [uniqueidentifier] NOT NULL,
	[parent_id] [nvarchar](max) NULL,
	[name] [nvarchar](max) NOT NULL,
	[shortname] [nvarchar](max) NOT NULL,
	[code] [nvarchar](max) NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[AddDate] [datetime] NULL,
	[Addby] [nvarchar](max) NULL,
	[EditDate] [datetime] NULL,
	[Editby] [nvarchar](max) NULL,
	[status] [bit] NOT NULL,
	[Flag] [int] NULL,
 CONSTRAINT [PK_dbo.Product_Category] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductCategory]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductCategory](
	[ProCatID] [uniqueidentifier] NOT NULL,
	[ProID] [uniqueidentifier] NOT NULL,
	[User_id] [uniqueidentifier] NOT NULL,
	[CatID] [uniqueidentifier] NOT NULL,
	[Timestamp] [datetime] NULL,
	[AddBy] [varchar](50) NULL,
	[Status] [varchar](50) NULL,
	[Flag] [int] NULL,
	[EditBy] [varchar](50) NULL,
	[EditDate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductInvoice]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductInvoice](
	[PartyName] [varchar](50) NULL,
	[PartyPhone] [varchar](50) NULL,
	[PartyAddress] [varchar](50) NULL,
	[Date] [datetime] NULL,
	[Name] [varchar](50) NULL,
	[Batch] [varchar](50) NULL,
	[Price] [float] NULL,
	[Qty] [varchar](50) NULL,
	[Discount] [float] NULL,
	[DiscountAmount] [float] NULL,
	[Tax] [float] NULL,
	[TaxAmount] [float] NULL,
	[NetAmount] [float] NULL,
	[InvoiceNumber] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductList]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductList](
	[Category] [varchar](50) NULL,
	[Name] [varchar](50) NULL,
	[Company] [varchar](50) NULL,
	[Formula] [varchar](50) NULL,
	[Rs] [float] NULL,
	[Rm] [float] NULL,
	[Total] [float] NULL,
	[Qty] [varchar](50) NULL,
	[Date] [datetime] NULL,
	[TotalQty] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductMultiCategory]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductMultiCategory](
	[CatID] [uniqueidentifier] NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[ParentID] [varchar](50) NULL,
	[Code] [varchar](50) NULL,
	[Descrip] [varchar](50) NULL,
	[TimeStamp] [datetime] NULL,
	[AddBy] [varchar](191) NULL,
	[Status] [nvarchar](191) NULL,
	[Flag] [int] NULL,
	[EditBy] [varchar](191) NULL,
	[EditDate] [datetime] NULL,
 CONSTRAINT [Pk_Product Category_CatID] PRIMARY KEY CLUSTERED 
(
	[CatID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductSales]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductSales](
	[ProSales_id] [uniqueidentifier] NULL,
	[Pro_id] [uniqueidentifier] NULL,
	[unitprice] [float] NULL,
	[qtysold] [float] NULL,
	[total] [float] NULL,
	[date] [datetime] NULL,
	[transaction_no] [varchar](50) NULL,
	[add_by] [uniqueidentifier] NULL,
	[add_date] [datetime] NULL,
	[edit_by] [uniqueidentifier] NULL,
	[edit_date] [datetime] NULL,
	[flag] [bit] NULL
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Promotion]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Promotion](
	[PromID] [uniqueidentifier] NOT NULL,
	[ProID] [uniqueidentifier] NOT NULL,
	[Descrip] [varchar](50) NULL,
	[TimeStamp] [datetime] NULL,
	[AddBy] [varchar](191) NULL,
	[Status] [nvarchar](191) NULL,
	[Flag] [int] NULL,
	[EditBy] [varchar](50) NULL,
	[EditDate] [datetime] NULL,
 CONSTRAINT [Pk_Promotion_PromID] PRIMARY KEY CLUSTERED 
(
	[PromID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Payment_type](
	[Payment_id] [uniqueidentifier] NOT NULL,
	[Payment_type] [varchar](50) NOT NULL
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[SectionEMP]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SectionEMP](
	[section_id] [uniqueidentifier] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[shortname] [varchar](50) NOT NULL,
	[desc] [varchar](50) NOT NULL,
	[code] [varchar](50) NOT NULL,
	[office_id] [uniqueidentifier] NOT NULL,
	[time_in] [datetime] NULL,
	[time_out] [datetime] NULL,
	[short_leave] [datetime] NULL,
	[grace_time] [datetime] NULL,
	[absent_after] [datetime] NULL,
	[break_start] [datetime] NULL,
	[break_end] [datetime] NULL,
	[local] [bit] NULL,
	[web] [bit] NULL,
	[add_by] [varchar](50) NULL,
	[add_date] [date] NULL,
	[edit_by] [varchar](50) NULL,
	[edit_date] [date] NULL,
 CONSTRAINT [PK_SectionEMP] PRIMARY KEY CLUSTERED 
(
	[section_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[State]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[State](
	[state_id] [uniqueidentifier] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[shortname] [varchar](50) NOT NULL,
	[desc] [varchar](50) NOT NULL,
	[code] [varchar](50) NOT NULL,
	[country_id] [uniqueidentifier] NOT NULL,
	[add_by] [varchar](50) NULL,
	[add_date] [datetime] NULL,
	[edit_by] [varchar](50) NULL,
	[edit_date] [datetime] NULL,
 CONSTRAINT [PK_State] PRIMARY KEY CLUSTERED 
(
	[state_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stock]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stock](
	[id] [varchar](max) NOT NULL,
	[Product_Category_id] [varchar](max) NULL,
	[Product_id] [varchar](max) NOT NULL,
	[Branch_id] [varchar](max) NULL,
	[POS_id] [varchar](max) NULL,
	[Organization_id] [varchar](max) NULL,
	[RemainingQuantity] [float] NULL,
	[Quantity] [float] NOT NULL,
	[PurchasePrice] [float] NULL,
	[SellPrice] [float] NULL,
	[barcode] [varchar](max) NOT NULL,
	[expiryDate] [datetime] NULL,
	[qie] [float] NULL,
	[instock] [bit] NULL,
	[AddDate] [datetime] NULL,
	[AddBy] [varchar](max) NULL,
	[EditDate] [datetime] NULL,
	[EditBy] [varchar](max) NULL,
	[Flag] [bit] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[students]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[students](
	[id] [int] IDENTITY(1557,1) NOT NULL,
	[name] [varchar](100) NOT NULL,
	[fathername] [varchar](100) NULL,
	[address] [varchar](255) NULL,
	[rollno] [varchar](30) NULL,
	[Add_by] [varchar](50) NULL,
	[Add_Date] [datetime] NULL,
	[Edit_By] [varchar](50) NULL,
	[Edit_Date] [datetime] NULL,
	[country_id] [int] NULL,
	[city_id] [int] NULL,
 CONSTRAINT [PK_students_id] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tax]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tax](
	[TaxID] [uniqueidentifier] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Descrip] [varchar](50) NULL,
	[ShortName] [varchar](50) NOT NULL,
	[Code] [varchar](50) NOT NULL,
	[TaxPercen] [varchar](50) NOT NULL,
	[Status] [varchar](50) NULL,
	[TimeStamp] [datetime] NULL,
	[AddBy] [varchar](50) NULL,
	[EditBy] [varchar](50) NULL,
	[EditDate] [datetime] NULL,
	[Flag] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[test]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[test](
	[test_id] [uniqueidentifier] NOT NULL,
	[name] [nvarchar](max) NOT NULL,
	[shortname] [nvarchar](max) NOT NULL,
	[code] [nvarchar](max) NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[status] [bit] NOT NULL,
	[Addby] [varchar](50) NULL,
	[AddDate] [datetime] NULL,
	[Editby] [varchar](50) NULL,
	[EditDate] [datetime] NULL,
	[Flag] [int] NULL,
 CONSTRAINT [PK_dbo.test] PRIMARY KEY CLUSTERED 
(
	[test_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User_Education]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_Education](
	[Education_id] [uniqueidentifier] NOT NULL,
	[User_id] [uniqueidentifier] NOT NULL,
	[Board] [varchar](50) NOT NULL,
	[Image] [image] NULL,
	[Specilization] [varchar](50) NOT NULL,
	[OBT_CGPA] [varchar](15) NOT NULL,
	[Totalmarks_Cgpa] [varchar](15) NOT NULL,
	[Percentage] [varchar](10) NOT NULL,
	[Timestamp] [datetime] NOT NULL,
	[Add_by] [varchar](191) NOT NULL,
	[status] [nvarchar](20) NOT NULL,
	[Flag] [tinyint] NOT NULL,
 CONSTRAINT [PK_User_Education] PRIMARY KEY CLUSTERED 
(
	[Education_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User_Experience]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_Experience](
	[Experience_id] [uniqueidentifier] NOT NULL,
	[User_id] [uniqueidentifier] NOT NULL,
	[Job_title] [varchar](50) NOT NULL,
	[Image] [image] NOT NULL,
	[Company_name] [varchar](100) NOT NULL,
	[Start_date] [date] NOT NULL,
	[End_date] [date] NOT NULL,
	[Start_designation] [varchar](50) NOT NULL,
	[End_designation] [varchar](50) NOT NULL,
	[Resign] [varchar](191) NOT NULL,
	[Timestamp] [date] NOT NULL,
	[Add_by] [varchar](191) NOT NULL,
	[status] [nvarchar](20) NOT NULL,
	[Flag] [tinyint] NOT NULL,
 CONSTRAINT [PK_User_Experience] PRIMARY KEY CLUSTERED 
(
	[Experience_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User_Experties]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_Experties](
	[Experties_id] [uniqueidentifier] NOT NULL,
	[User_id] [uniqueidentifier] NOT NULL,
	[ImagePath] [varchar](50) NOT NULL,
	[Certifcates] [varchar](191) NOT NULL,
	[Divison] [varchar](50) NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[Date] [date] NOT NULL,
	[Description] [varchar](191) NOT NULL,
	[Timestamp] [datetime] NOT NULL,
	[Add_by] [varchar](191) NOT NULL,
	[Status] [varchar](20) NOT NULL,
	[Flag] [tinyint] NOT NULL,
 CONSTRAINT [PK_User_Experties] PRIMARY KEY CLUSTERED 
(
	[Experties_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Purchase_Order](
	[id] [uniqueidentifier] NULL,
	[party_id] [uniqueidentifier] NOT NULL,
	[organization_id] [uniqueidentifier] NOT NULL,
	[branch_id] [uniqueidentifier] NOT NULL,
	[total_amount] [float] NULL,
	[sub_total_amount] [float] NULL,
	[discount_amount] [float] NULL,
	[discount_percentage] [int] NULL,
	[paid_amount] [float] NULL,
	[remaning_amount] [float] NULL,
	[remarks] [varchar](max) NULL,
	[payment_type] [varchar](max) NULL,
	[Invoice_no] [varchar](100) NULL,
	[status] [varchar](50) NULL,
	[date] [datetime] NULL,
	[add_by] [uniqueidentifier] NULL,
	[add_date] [datetime] NULL,
	[edit_by] [uniqueidentifier] NULL,
	[edit_date] [datetime] NULL,
	[flag] [bit] NULL,
	[tax_id] [uniqueidentifier] NULL,
	[tax_amount] [float] NULL,
	[Order_no] [varchar](100) NULL,
	[non_vendor_cost_amount] [float] NULL,
	[non_vendor_cost_percentage] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Purchase_Order_Details]    Script Date: 19-Sep-19 8:01:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Purchase_Order_Details](
	[id] [uniqueidentifier] NULL,
	[purchase_order_id] [uniqueidentifier] NULL,
	[product_id] [uniqueidentifier] NULL,
	[product_category_id] [uniqueidentifier] NULL,
	[quantity] [int] NULL,
	[purchase_amount] [float] NULL,
	[sale_amount] [float] NULL,
	[tax_id] [uniqueidentifier] NULL,
	[tax_amount] [uniqueidentifier] NULL,
	[discount_amount] [float] NULL,
	[discount_percentage] [int] NULL,
	[date] [datetime] NULL,
	[add_by] [uniqueidentifier] NULL,
	[add_date] [datetime] NULL,
	[edit_by] [uniqueidentifier] NULL,
	[edit_date] [datetime] NULL,
	[status] [varchar](50) NULL,
	[flag] [bit] NULL
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'- Items Recieved
- Paid
- Paid & Items recieved' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Purchase_Order', @level2type=N'COLUMN',@level2name=N'status'
GO


CREATE TABLE [dbo].[Purchase_Order_Return](
	[id] [uniqueidentifier] NULL,
	[party_id] [uniqueidentifier] NOT NULL,
	[organization_id] [uniqueidentifier] NOT NULL,
	[branch_id] [uniqueidentifier] NOT NULL,
	[total_amount] [float] NULL,
	[sub_total_amount] [float] NULL,
	[discount_amount] [float] NULL,
	[discount_percentage] [int] NULL,
	[paid_amount] [float] NULL,
	[remaning_amount] [float] NULL,
	[remarks] [varchar](max) NULL,
	[payment_type] [uniqueidentifier] NULL,
	[Invoice_no] [varchar](100) NULL,
	[status] [varchar](50) NULL,
	[date] [datetime] NULL,
	[add_by] [uniqueidentifier] NULL,
	[add_date] [datetime] NULL,
	[edit_by] [uniqueidentifier] NULL,
	[edit_date] [datetime] NULL,
	[flag] [bit] NULL,
	[tax_id] [uniqueidentifier] NULL,
	[tax_amount] [float] NULL,
	[Order_no] [varchar](100) NULL,
	[non_vendor_cost_amount] [float] NULL,
	[non_vendor_cost_percentage] [int] NULL,
	[return_date] [datetime] NULL,
	[return_fee] [float] NULL,
	[refund] [float] NULL,
	[credit] [float] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchaseParty]    Script Date: 10/1/2019 2:16:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseParty](
	[party_id] [uniqueidentifier] NOT NULL,
	[name] [nvarchar](max) NOT NULL,
	[shortname] [nvarchar](max) NOT NULL,
	[code] [nvarchar](max) NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[add] [nvarchar](max) NOT NULL,
	[National_Tax_Number] [nvarchar](max) NOT NULL,
	[Goods_And_Services_Tax] [nvarchar](max) NOT NULL,
	[Guarranty] [nvarchar](max) NOT NULL,
	[Standard_Report_Number] [nvarchar](max) NOT NULL,
	[phone] [nvarchar](max) NOT NULL,
	[address] [nvarchar](max) NOT NULL,
	[email] [nvarchar](max) NOT NULL,
	[Bank_account_number] [nvarchar](max) NOT NULL,
	[International_Account_Number] [nvarchar](max) NOT NULL,
	[status] [bit] NOT NULL,
	[Addby] [varchar](50) NULL,
	[AddDate] [datetime] NULL,
	[Editby] [varchar](50) NULL,
	[EditDate] [datetime] NULL,
	[Flag] [int] NOT NULL,
	[organization_id] [uniqueidentifier] NULL,
	[branch_id] [uniqueidentifier] NULL,
 CONSTRAINT [PK_dbo.PurchaseParty] PRIMARY KEY CLUSTERED 
(
	[party_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[PurchaseParty] ADD  CONSTRAINT [DF_PurchaseParty_party_id]  DEFAULT (newid()) FOR [party_id]
GO


/****** Object:  Table [dbo].[Purchase_Order_Details]    Script Date: 19-Sep-19 8:01:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Purchase_Order_Return_Details](
	[id] [uniqueidentifier] NULL,
	[purchase_order_Return_id] [uniqueidentifier] NULL,
	[product_id] [uniqueidentifier] NULL,
	[product_category_id] [uniqueidentifier] NULL,
	[quantity] [int] NULL,
	[purchase_amount] [float] NULL,
	[sale_amount] [float] NULL,
	[tax_id] [uniqueidentifier] NULL,
	[tax_amount] [uniqueidentifier] NULL,
	[discount_amount] [float] NULL,
	[discount_percentage] [int] NULL,
	[date] [datetime] NULL,
	[add_by] [uniqueidentifier] NULL,
	[add_date] [datetime] NULL,
	[edit_by] [uniqueidentifier] NULL,
	[edit_date] [datetime] NULL,
	[status] [varchar](50) NULL,
	[flag] [bit] NULL,
	[return_date] [datetime] NULL,
	[refund] [float] NULL
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 16-Sep-19 8:53:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[User_id] [uniqueidentifier] NOT NULL,
	[First_name] [varchar](20) NOT NULL,
	[Last_name] [varchar](20) NOT NULL,
	[User_name] [varchar](40) NOT NULL,
	[Father_name] [varchar](50) NOT NULL,
	[Cnic] [varchar](15) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[password] [nvarchar](4000) NOT NULL,
	[contact] [varchar](13) NOT NULL,
	[Phone] [varchar](13) NOT NULL,
	[country_id] [uniqueidentifier] NOT NULL,
	[state_id] [uniqueidentifier] NOT NULL,
	[city_id] [uniqueidentifier] NOT NULL,
	[Area_id] [uniqueidentifier] NULL,
	[Adress] [varchar](50) NOT NULL,
	[Gender] [varchar](6) NOT NULL,
	[DOB] [date] NOT NULL,
	[Account_type] [varchar](50) NOT NULL,
	[Timestamp] [datetime] NULL,
	[Add_by] [varchar](191) NOT NULL,
	[Status] [varchar](20) NOT NULL,
	[Flag] [tinyint] NOT NULL,
	[FirstTimeLogin] [tinyint] NULL,
	[Editby] [varchar](50) NULL,
	[EditDate] [datetime] NULL,
	[Organization_id] [uniqueidentifier] NULL,
	[Branch_id] [uniqueidentifier] NULL,
	[Employee_id] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[User_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Area] ([area_id], [name], [shortname], [desc], [code], [country_id], [state_id], [city_id]) VALUES (N'1bd44ef0-89b0-43ee-a5f5-20f8024fd444', N'Shahdara', N'', N'', N'', N'08ba5227-7134-41ff-9711-18970b4d5904', N'e9a3ad1d-f272-4e48-90e8-9c9a0fa6dc4f', N'c2f98a37-1819-418b-be62-855110433f99')
GO
INSERT [dbo].[Area] ([area_id], [name], [shortname], [desc], [code], [country_id], [state_id], [city_id]) VALUES (N'f0826f11-e92e-4a24-bdcf-58f57539b719', N'Allama Iqbal Town', N'', N'', N'', N'08ba5227-7134-41ff-9711-18970b4d5904', N'e9a3ad1d-f272-4e48-90e8-9c9a0fa6dc4f', N'c2f98a37-1819-418b-be62-855110433f99')
GO
INSERT [dbo].[Area] ([area_id], [name], [shortname], [desc], [code], [country_id], [state_id], [city_id]) VALUES (N'a0cb993c-41fc-4b53-a43c-78e74b44dfe4', N'Model Town', N'', N'', N'', N'08ba5227-7134-41ff-9711-18970b4d5904', N'e9a3ad1d-f272-4e48-90e8-9c9a0fa6dc4f', N'c2f98a37-1819-418b-be62-855110433f99')
GO
INSERT [dbo].[Area] ([area_id], [name], [shortname], [desc], [code], [country_id], [state_id], [city_id]) VALUES (N'528c6732-ce1e-4c42-ad21-c91478ef2dff', N'Samanabad', N'', N'', N'', N'08ba5227-7134-41ff-9711-18970b4d5904', N'e9a3ad1d-f272-4e48-90e8-9c9a0fa6dc4f', N'c2f98a37-1819-418b-be62-855110433f99')
GO
INSERT [dbo].[Area] ([area_id], [name], [shortname], [desc], [code], [country_id], [state_id], [city_id]) VALUES (N'8b7ffc2e-fa9a-48af-8ce8-ed45731aeedb', N'Ghari Shahu', N'', N'', N'', N'08ba5227-7134-41ff-9711-18970b4d5904', N'e9a3ad1d-f272-4e48-90e8-9c9a0fa6dc4f', N'c2f98a37-1819-418b-be62-855110433f99')
GO
INSERT [dbo].[City] ([city_id], [name], [shortname], [desc], [code], [country_id], [state_id], [add_by], [add_date], [edit_by], [edit_date]) VALUES (N'c2f98a37-1819-418b-be62-855110433f99', N'Lahore', N'', N'', N'', N'08ba5227-7134-41ff-9711-18970b4d5904', N'e9a3ad1d-f272-4e48-90e8-9c9a0fa6dc4f', N'Admin', CAST(N'2019-09-16T10:41:00.000' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Country] ([country_id], [name], [shortname], [desc], [code], [add_by], [add_date], [edit_by], [edit_date]) VALUES (N'08ba5227-7134-41ff-9711-18970b4d5904', N'Pakistan', N'pk', N'', N'92', N'Admin', CAST(N'2019-09-16T10:41:01.910' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Organization] ([Organization_id], [User_id], [Parent_id], [Title], [Short_Name], [Description], [Type], [Regestration_Date], [Expiry_Date], [Update_Date], [Regestrar_Name], [Tech_Persoan_Name], [Regestration_Email], [Name_Server1], [Name_Server2], [Name_Server3], [Name_Server4], [Name_Server5], [Timestamp], [Add_by], [Status], [Flag], [HeaderPicturePath]) VALUES (N'2f3b201d-9ffc-46ce-91cb-00fd9d4fdf36', N'00000000-0000-0000-0000-000000000000', N'00000000-0000-0000-0000-000000000000', N'Ncba', NULL, N'', N'Organization', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2019-05-23T16:47:51.190' AS DateTime), N'Admin', N'Active', 1, N'a9fd4d51-336c-46a0-b90c-cd1dfb918ea4.jpg')
GO
INSERT [dbo].[Organization] ([Organization_id], [User_id], [Parent_id], [Title], [Short_Name], [Description], [Type], [Regestration_Date], [Expiry_Date], [Update_Date], [Regestrar_Name], [Tech_Persoan_Name], [Regestration_Email], [Name_Server1], [Name_Server2], [Name_Server3], [Name_Server4], [Name_Server5], [Timestamp], [Add_by], [Status], [Flag], [HeaderPicturePath]) VALUES (N'ddaaebe8-a6ab-4ca1-8df9-0c6194a37b04', N'00000000-0000-0000-0000-000000000000', N'00000000-0000-0000-0000-000000000000', N'POS - HUsman', NULL, NULL, N'Organization', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Admin', N'Active', 1, NULL)
GO
INSERT [dbo].[Organization] ([Organization_id], [User_id], [Parent_id], [Title], [Short_Name], [Description], [Type], [Regestration_Date], [Expiry_Date], [Update_Date], [Regestrar_Name], [Tech_Persoan_Name], [Regestration_Email], [Name_Server1], [Name_Server2], [Name_Server3], [Name_Server4], [Name_Server5], [Timestamp], [Add_by], [Status], [Flag], [HeaderPicturePath]) VALUES (N'bdcd2070-dbbc-4274-81e9-0ce4123a75c6', N'00000000-0000-0000-0000-000000000000', N'00000000-0000-0000-0000-000000000000', N'POS - HUsman', NULL, NULL, N'Organization', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Admin', N'Active', 1, NULL)
GO
INSERT [dbo].[Organization] ([Organization_id], [User_id], [Parent_id], [Title], [Short_Name], [Description], [Type], [Regestration_Date], [Expiry_Date], [Update_Date], [Regestrar_Name], [Tech_Persoan_Name], [Regestration_Email], [Name_Server1], [Name_Server2], [Name_Server3], [Name_Server4], [Name_Server5], [Timestamp], [Add_by], [Status], [Flag], [HeaderPicturePath]) VALUES (N'47fa2591-a8ab-493c-b68e-375bb7e0ce25', N'00000000-0000-0000-0000-000000000000', N'00000000-0000-0000-0000-000000000000', N'HBL', NULL, N'Lahore', N'Organization', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2019-05-21T15:59:11.447' AS DateTime), N'Admin', N'Active', 0, N'68ab201b-0d69-481c-8aad-ca787f1e6641.jpg')
GO
INSERT [dbo].[Organization] ([Organization_id], [User_id], [Parent_id], [Title], [Short_Name], [Description], [Type], [Regestration_Date], [Expiry_Date], [Update_Date], [Regestrar_Name], [Tech_Persoan_Name], [Regestration_Email], [Name_Server1], [Name_Server2], [Name_Server3], [Name_Server4], [Name_Server5], [Timestamp], [Add_by], [Status], [Flag], [HeaderPicturePath]) VALUES (N'c2b9c670-c195-400d-a591-3eb934b3c280', N'00000000-0000-0000-0000-000000000000', N'00000000-0000-0000-0000-000000000000', N'GTSLA', NULL, N'', N'Organization', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2019-05-21T16:12:30.260' AS DateTime), N'Admin', N'Active', 1, N'GTSLA.jpgf046251e-1905-4cb8-90e6-b67278dfb40c.jpg')
GO
INSERT [dbo].[Organization] ([Organization_id], [User_id], [Parent_id], [Title], [Short_Name], [Description], [Type], [Regestration_Date], [Expiry_Date], [Update_Date], [Regestrar_Name], [Tech_Persoan_Name], [Regestration_Email], [Name_Server1], [Name_Server2], [Name_Server3], [Name_Server4], [Name_Server5], [Timestamp], [Add_by], [Status], [Flag], [HeaderPicturePath]) VALUES (N'93755b82-5b8e-405b-964f-5974d708f47c', N'00000000-0000-0000-0000-000000000000', N'2f3b201d-9ffc-46ce-91cb-00fd9d4fdf36', N'Lcu', NULL, N'', N'Branch', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2019-04-18T02:36:51.377' AS DateTime), N'Admin', N'Active', 1, NULL)
GO
INSERT [dbo].[Organization] ([Organization_id], [User_id], [Parent_id], [Title], [Short_Name], [Description], [Type], [Regestration_Date], [Expiry_Date], [Update_Date], [Regestrar_Name], [Tech_Persoan_Name], [Regestration_Email], [Name_Server1], [Name_Server2], [Name_Server3], [Name_Server4], [Name_Server5], [Timestamp], [Add_by], [Status], [Flag], [HeaderPicturePath]) VALUES (N'ed933606-a522-463e-97d4-8c541bd7f221', N'00000000-0000-0000-0000-000000000000', N'ddaaebe8-a6ab-4ca1-8df9-0c6194a37b04', N'Main Branch', NULL, NULL, N'Branch', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Admin', N'Active', 1, NULL)
GO
INSERT [dbo].[Organization] ([Organization_id], [User_id], [Parent_id], [Title], [Short_Name], [Description], [Type], [Regestration_Date], [Expiry_Date], [Update_Date], [Regestrar_Name], [Tech_Persoan_Name], [Regestration_Email], [Name_Server1], [Name_Server2], [Name_Server3], [Name_Server4], [Name_Server5], [Timestamp], [Add_by], [Status], [Flag], [HeaderPicturePath]) VALUES (N'3f420d01-8574-483a-8276-b875c8b91a64', N'00000000-0000-0000-0000-000000000000', N'00000000-0000-0000-0000-000000000000', N'Bata', NULL, N'', N'Organization', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2019-05-21T16:01:17.607' AS DateTime), N'Admin', N'Active', 0, N'.jpg')
GO
INSERT [dbo].[Organization] ([Organization_id], [User_id], [Parent_id], [Title], [Short_Name], [Description], [Type], [Regestration_Date], [Expiry_Date], [Update_Date], [Regestrar_Name], [Tech_Persoan_Name], [Regestration_Email], [Name_Server1], [Name_Server2], [Name_Server3], [Name_Server4], [Name_Server5], [Timestamp], [Add_by], [Status], [Flag], [HeaderPicturePath]) VALUES (N'a1c18cce-9efe-4532-a88b-ca2b7a55e9f1', N'00000000-0000-0000-0000-000000000000', N'00000000-0000-0000-0000-000000000000', N'GTS', NULL, N'', N'Organization', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2019-04-18T02:31:33.963' AS DateTime), N'Admin', N'Active', 1, NULL)
GO
INSERT [dbo].[Organization] ([Organization_id], [User_id], [Parent_id], [Title], [Short_Name], [Description], [Type], [Regestration_Date], [Expiry_Date], [Update_Date], [Regestrar_Name], [Tech_Persoan_Name], [Regestration_Email], [Name_Server1], [Name_Server2], [Name_Server3], [Name_Server4], [Name_Server5], [Timestamp], [Add_by], [Status], [Flag], [HeaderPicturePath]) VALUES (N'0456834b-62f7-4a35-8bd2-ccae9dab2e20', N'00000000-0000-0000-0000-000000000000', N'2f3b201d-9ffc-46ce-91cb-00fd9d4fdf36', N'Dha Campus', NULL, N'', N'Branch', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2019-04-18T02:37:14.280' AS DateTime), N'Admin', N'Active', 1, NULL)
GO
INSERT [dbo].[Organization] ([Organization_id], [User_id], [Parent_id], [Title], [Short_Name], [Description], [Type], [Regestration_Date], [Expiry_Date], [Update_Date], [Regestrar_Name], [Tech_Persoan_Name], [Regestration_Email], [Name_Server1], [Name_Server2], [Name_Server3], [Name_Server4], [Name_Server5], [Timestamp], [Add_by], [Status], [Flag], [HeaderPicturePath]) VALUES (N'6ae2cf50-06d2-4b50-ba0f-d2254e5bbdc0', N'00000000-0000-0000-0000-000000000000', N'93755b82-5b8e-405b-964f-5974d708f47c', N'Facebook', N'fb', N'', N'Domain', CAST(N'2019-04-18' AS Date), CAST(N'2019-04-18' AS Date), CAST(N'2019-04-18' AS Date), N'Toqeer', N'toqeer', N'toqeer@gmail.com', N'google.com', N'', N'', N'', N'', CAST(N'2019-04-18T02:52:26.133' AS DateTime), N'Admin', N'Active', 1, NULL)
GO
INSERT [dbo].[Organization] ([Organization_id], [User_id], [Parent_id], [Title], [Short_Name], [Description], [Type], [Regestration_Date], [Expiry_Date], [Update_Date], [Regestrar_Name], [Tech_Persoan_Name], [Regestration_Email], [Name_Server1], [Name_Server2], [Name_Server3], [Name_Server4], [Name_Server5], [Timestamp], [Add_by], [Status], [Flag], [HeaderPicturePath]) VALUES (N'5513b349-64a0-403a-bbe7-de1d7cb27dac', N'00000000-0000-0000-0000-000000000000', N'a1c18cce-9efe-4532-a88b-ca2b7a55e9f1', N'GTS_Lahore', NULL, N'Near LinkRoad Shamimar', N'Branch', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2019-05-20T03:42:11.327' AS DateTime), N'Admin', N'Active', 1, NULL)
GO
INSERT [dbo].[Organization] ([Organization_id], [User_id], [Parent_id], [Title], [Short_Name], [Description], [Type], [Regestration_Date], [Expiry_Date], [Update_Date], [Regestrar_Name], [Tech_Persoan_Name], [Regestration_Email], [Name_Server1], [Name_Server2], [Name_Server3], [Name_Server4], [Name_Server5], [Timestamp], [Add_by], [Status], [Flag], [HeaderPicturePath]) VALUES (N'8a4e7334-973e-4667-a48d-e825eed2f370', N'00000000-0000-0000-0000-000000000000', N'2f3b201d-9ffc-46ce-91cb-00fd9d4fdf36', N'East Canal Campus', NULL, N'', N'Branch', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2019-04-18T02:37:05.430' AS DateTime), N'Admin', N'Active', 1, NULL)
GO
INSERT [dbo].[Organization] ([Organization_id], [User_id], [Parent_id], [Title], [Short_Name], [Description], [Type], [Regestration_Date], [Expiry_Date], [Update_Date], [Regestrar_Name], [Tech_Persoan_Name], [Regestration_Email], [Name_Server1], [Name_Server2], [Name_Server3], [Name_Server4], [Name_Server5], [Timestamp], [Add_by], [Status], [Flag], [HeaderPicturePath]) VALUES (N'b2d88918-223f-4a9c-8539-f769539e88e4', N'00000000-0000-0000-0000-000000000000', N'00000000-0000-0000-0000-000000000000', N' Bata', NULL, N'Lahore', N'Organization', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2019-05-21T16:09:28.263' AS DateTime), N'Admin', N'Active', 1, N'.jpg')
GO
INSERT [dbo].[Pages] ([PgID], [PgURL], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'1a839de9-0551-4b7b-8131-1cf510e4f5fd', N'Home', CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'Super Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Pages] ([PgID], [PgURL], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'c0e5ac6c-ca47-412e-8d21-353c9c6e8994', N'Users', CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'Super Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Pages] ([PgID], [PgURL], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'd939e49b-dad7-426f-8cfe-2559b6649a62', N'Organizations', CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'Super Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Pages] ([PgID], [PgURL], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'31141c19-8ab5-4670-89f0-14a503f22208', N'Branches', CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'Super Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Pages] ([PgID], [PgURL], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'251f16d9-3c8d-4135-a485-6d0cf8ca2a0c', N'Domains', CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'Super Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Pages] ([PgID], [PgURL], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'ac040e34-20fb-467f-873d-f958ae6028b2', N'Departments', CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'Super Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Pages] ([PgID], [PgURL], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'5a977168-0e60-4a90-8f32-1c93436cd4bd', N'Offices', CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'Super Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Pages] ([PgID], [PgURL], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'2596b75f-8ddb-42f4-9ce1-59d7263b2607', N'Sections', CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'Super Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Pages] ([PgID], [PgURL], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'b67c1f5d-5b2d-4d86-9a38-efc1d75c82ed', N'Add Credentials', CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'Super Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Pages] ([PgID], [PgURL], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'b0ab4458-408c-4ddc-8828-98520923bb61', N'Country', CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'Super Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Pages] ([PgID], [PgURL], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'ce747579-10c4-4b1d-a699-4bf5a37b60b9', N'State', CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'Super Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Pages] ([PgID], [PgURL], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'2059fde2-dcd3-43d0-806f-e1653cc83f73', N'City', CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'Super Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Pages] ([PgID], [PgURL], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'80769a0a-6843-42e9-8db0-fa44e36e4026', N'Area', CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'Super Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Pages] ([PgID], [PgURL], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'86323212-b262-40d3-b1ae-2e9c64bcaff2', N'Labels', CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'Super Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Pages] ([PgID], [PgURL], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'cec855ef-6cdf-4eb4-902d-72e4831f660b', N'Employees', CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'Super Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Pages] ([PgID], [PgURL], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'a801b5fc-ecd1-4b5b-8cea-dc57078aa939', N'Manual Attendence', CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'Super Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Pages] ([PgID], [PgURL], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'633f79da-ec81-448c-8a0d-5084fe9e3bd0', N'Multiple Attendence', CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'Super Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Pages] ([PgID], [PgURL], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'c043bf45-d57d-47cc-aca0-2dabbe308aee', N'Change Password', CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'Super Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Pages] ([PgID], [PgURL], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'024f7b2b-5ebd-4918-a6b4-0559a53e1bd5', N'Manage Permissions', CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'Super Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Pages] ([PgID], [PgURL], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'e8c92524-b4d0-4292-a14b-206a0f3ffa07', N'Domain Types', CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'Super Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Pages] ([PgID], [PgURL], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'37f61c96-b625-4d25-ac90-026e15fdeef8', N'Accounts', CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'Super Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Pages] ([PgID], [PgURL], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'f15093c9-9347-4799-8ce6-790482e1e63f', N'Manage Fee Head', CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'Super Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Pages] ([PgID], [PgURL], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'9e6e8686-259f-4f04-8f78-9ad2f3079f0f', N'Manage Department Classes', CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'Super Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Pages] ([PgID], [PgURL], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'b0955029-8317-446f-ac96-f13084dd9ba0', N'Generate Fee', CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'Super Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Pages] ([PgID], [PgURL], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'77ac4eec-7228-490d-a86b-f68887b76bc9', N'Form Fee Submit ', CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'Super Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Pages] ([PgID], [PgURL], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'604077ed-72bf-41d0-b1f1-b3cd03663da8', N'Fee Head Edit', CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'Super Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Pages] ([PgID], [PgURL], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'690c503e-5f8f-44fc-a14c-6f10d73775aa', N'Manage Arrear And Discounts', CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'Super Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Party] ([p_id], [name], [shortname], [code], [description], [add], [National_Tax_Number], [Goods_And_Services_Tax], [Guarranty], [Standard_Report_Number], [phone], [address], [email], [Bank_account_number], [International_Account_Number], [status], [Addby], [AddDate], [Editby], [EditDate], [Flag]) VALUES (N'7224eaed-12d0-417b-a88f-6cd8b307172e', N'GTS Traders', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', 0, N'Admin', CAST(N'2019-09-13T16:11:27.423' AS DateTime), N'Admin', CAST(N'2019-09-13T16:11:37.253' AS DateTime), 1)
GO
INSERT [dbo].[Party] ([p_id], [name], [shortname], [code], [description], [add], [National_Tax_Number], [Goods_And_Services_Tax], [Guarranty], [Standard_Report_Number], [phone], [address], [email], [Bank_account_number], [International_Account_Number], [status], [Addby], [AddDate], [Editby], [EditDate], [Flag]) VALUES (N'0cafed76-7834-49b2-ba8a-6eea0da56ada', N'asd', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', 0, N'Admin', CAST(N'2019-09-16T11:22:24.517' AS DateTime), NULL, NULL, 0)
GO
INSERT [dbo].[Party] ([p_id], [name], [shortname], [code], [description], [add], [National_Tax_Number], [Goods_And_Services_Tax], [Guarranty], [Standard_Report_Number], [phone], [address], [email], [Bank_account_number], [International_Account_Number], [status], [Addby], [AddDate], [Editby], [EditDate], [Flag]) VALUES (N'e54153b2-3d8d-460f-9a24-bf590f4509b5', N'asd', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', 0, N'Admin', CAST(N'2019-09-16T11:22:29.840' AS DateTime), NULL, NULL, 0)
GO
INSERT [dbo].[Permission] ([PerID], [PerUID], [PgID], [User_id], [PerAdd], [PerEdit], [PerView], [PerDel], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'b81bace9-b978-4184-80f9-001de3699683', N'2', N'ac040e34-20fb-467f-873d-f958ae6028b2', N'680e99a8-02d7-4c10-8e27-3ea917e94cd0', 1, 1, 1, 1, CAST(N'2019-08-04T23:38:28.133' AS DateTime), N'Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Permission] ([PerID], [PerUID], [PgID], [User_id], [PerAdd], [PerEdit], [PerView], [PerDel], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'72951c6f-8a4c-4b5b-8163-01d068e51446', N'2', N'e8c92524-b4d0-4292-a14b-206a0f3ffa07', N'680e99a8-02d7-4c10-8e27-3ea917e94cd0', 1, 1, 1, 1, CAST(N'2019-08-04T23:38:28.140' AS DateTime), N'Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Permission] ([PerID], [PerUID], [PgID], [User_id], [PerAdd], [PerEdit], [PerView], [PerDel], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'7e2358c6-0365-437e-91e2-035a11420b35', N'2', N'b67c1f5d-5b2d-4d86-9a38-efc1d75c82ed', N'680e99a8-02d7-4c10-8e27-3ea917e94cd0', 1, 1, 1, 1, CAST(N'2019-08-04T23:38:28.137' AS DateTime), N'Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Permission] ([PerID], [PerUID], [PgID], [User_id], [PerAdd], [PerEdit], [PerView], [PerDel], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'5bbac458-8dcc-4291-bbbc-0657c34e659f', N'2', N'c0e5ac6c-ca47-412e-8d21-353c9c6e8994', N'680e99a8-02d7-4c10-8e27-3ea917e94cd0', 1, 1, 1, 1, CAST(N'2019-08-04T23:38:28.057' AS DateTime), N'Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Permission] ([PerID], [PerUID], [PgID], [User_id], [PerAdd], [PerEdit], [PerView], [PerDel], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'7ad13580-d55d-4cd8-b90d-0adba0f04284', N'2', N'37f61c96-b625-4d25-ac90-026e15fdeef8', N'680e99a8-02d7-4c10-8e27-3ea917e94cd0', 1, 1, 1, 1, CAST(N'2019-08-04T23:38:28.143' AS DateTime), N'Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Permission] ([PerID], [PerUID], [PgID], [User_id], [PerAdd], [PerEdit], [PerView], [PerDel], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'de05360c-44fe-4243-afe7-0e8da5df17d6', N'2', N'77ac4eec-7228-490d-a86b-f68887b76bc9', N'680e99a8-02d7-4c10-8e27-3ea917e94cd0', 1, 1, 1, 1, CAST(N'2019-08-04T23:38:28.143' AS DateTime), N'Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Permission] ([PerID], [PerUID], [PgID], [User_id], [PerAdd], [PerEdit], [PerView], [PerDel], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'f94d37c5-a1e4-42a0-8d94-158f28488914', N'2', N'604077ed-72bf-41d0-b1f1-b3cd03663da8', N'680e99a8-02d7-4c10-8e27-3ea917e94cd0', 1, 1, 1, 1, CAST(N'2019-08-04T23:38:28.143' AS DateTime), N'Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Permission] ([PerID], [PerUID], [PgID], [User_id], [PerAdd], [PerEdit], [PerView], [PerDel], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'2e8f3a51-4674-440a-a12f-1811ce5c0115', N'1', N'77ac4eec-7228-490d-a86b-f68887b76bc9', N'1a47706a-3d8b-4dae-aa6a-f2f2ad0858de', 1, 1, 1, 1, CAST(N'1990-01-01T00:00:00.000' AS DateTime), N'Super Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Permission] ([PerID], [PerUID], [PgID], [User_id], [PerAdd], [PerEdit], [PerView], [PerDel], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'8f60decf-f3f9-450d-a3e0-21340bf755d0', N'2', N'2059fde2-dcd3-43d0-806f-e1653cc83f73', N'680e99a8-02d7-4c10-8e27-3ea917e94cd0', 1, 1, 1, 1, CAST(N'2019-08-04T23:38:28.137' AS DateTime), N'Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Permission] ([PerID], [PerUID], [PgID], [User_id], [PerAdd], [PerEdit], [PerView], [PerDel], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'1314a5bd-33c8-4da3-8f49-24bd829ec5b2', N'2', N'9e6e8686-259f-4f04-8f78-9ad2f3079f0f', N'680e99a8-02d7-4c10-8e27-3ea917e94cd0', 1, 1, 1, 1, CAST(N'2019-08-04T23:38:28.143' AS DateTime), N'Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Permission] ([PerID], [PerUID], [PgID], [User_id], [PerAdd], [PerEdit], [PerView], [PerDel], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'ca0851dd-99e2-4a49-9b70-30991994b32f', N'2', N'86323212-b262-40d3-b1ae-2e9c64bcaff2', N'680e99a8-02d7-4c10-8e27-3ea917e94cd0', 1, 1, 1, 1, CAST(N'2019-08-04T23:38:28.137' AS DateTime), N'Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Permission] ([PerID], [PerUID], [PgID], [User_id], [PerAdd], [PerEdit], [PerView], [PerDel], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'6c3fc807-ebfc-4f5d-bf8d-3d56f12d1643', N'2', N'c043bf45-d57d-47cc-aca0-2dabbe308aee', N'680e99a8-02d7-4c10-8e27-3ea917e94cd0', 1, 1, 1, 1, CAST(N'2019-08-04T23:38:28.140' AS DateTime), N'Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Permission] ([PerID], [PerUID], [PgID], [User_id], [PerAdd], [PerEdit], [PerView], [PerDel], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'952e6829-1557-46a3-9f2d-47790bfc8d38', N'2', N'251f16d9-3c8d-4135-a485-6d0cf8ca2a0c', N'680e99a8-02d7-4c10-8e27-3ea917e94cd0', 1, 1, 1, 1, CAST(N'2019-08-04T23:38:28.130' AS DateTime), N'Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Permission] ([PerID], [PerUID], [PgID], [User_id], [PerAdd], [PerEdit], [PerView], [PerDel], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'20b37a6b-2d83-4f12-aec5-520734050a60', N'2', N'024f7b2b-5ebd-4918-a6b4-0559a53e1bd5', N'680e99a8-02d7-4c10-8e27-3ea917e94cd0', 1, 1, 1, 1, CAST(N'2019-08-04T23:38:28.140' AS DateTime), N'Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Permission] ([PerID], [PerUID], [PgID], [User_id], [PerAdd], [PerEdit], [PerView], [PerDel], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'cd0ad0fb-0778-45f4-8847-58a16aecc8a5', N'2', N'cec855ef-6cdf-4eb4-902d-72e4831f660b', N'680e99a8-02d7-4c10-8e27-3ea917e94cd0', 1, 1, 1, 1, CAST(N'2019-08-04T23:38:28.140' AS DateTime), N'Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Permission] ([PerID], [PerUID], [PgID], [User_id], [PerAdd], [PerEdit], [PerView], [PerDel], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'236763ab-b5c4-4466-9c1e-58ff3ca66657', N'2', N'31141c19-8ab5-4670-89f0-14a503f22208', N'680e99a8-02d7-4c10-8e27-3ea917e94cd0', 1, 1, 1, 1, CAST(N'2019-08-04T23:38:28.060' AS DateTime), N'Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Permission] ([PerID], [PerUID], [PgID], [User_id], [PerAdd], [PerEdit], [PerView], [PerDel], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'7394a3aa-3a3e-4cb6-8575-612d1b9c227b', N'2', N'5a977168-0e60-4a90-8f32-1c93436cd4bd', N'680e99a8-02d7-4c10-8e27-3ea917e94cd0', 1, 1, 1, 1, CAST(N'2019-08-04T23:38:28.133' AS DateTime), N'Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Permission] ([PerID], [PerUID], [PgID], [User_id], [PerAdd], [PerEdit], [PerView], [PerDel], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'661ecd9c-e46e-41fb-a120-6267d3937e89', N'2', N'd939e49b-dad7-426f-8cfe-2559b6649a62', N'680e99a8-02d7-4c10-8e27-3ea917e94cd0', 1, 1, 1, 1, CAST(N'2019-08-04T23:38:28.057' AS DateTime), N'Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Permission] ([PerID], [PerUID], [PgID], [User_id], [PerAdd], [PerEdit], [PerView], [PerDel], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'cd6e4d89-1816-42d4-baa9-73969e1708ff', N'2', N'1a839de9-0551-4b7b-8131-1cf510e4f5fd', N'680e99a8-02d7-4c10-8e27-3ea917e94cd0', 1, 1, 1, 1, CAST(N'2019-08-04T23:38:28.053' AS DateTime), N'Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Permission] ([PerID], [PerUID], [PgID], [User_id], [PerAdd], [PerEdit], [PerView], [PerDel], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'88d43b77-8787-4801-88dc-83bcd3b788d9', N'2', N'ce747579-10c4-4b1d-a699-4bf5a37b60b9', N'680e99a8-02d7-4c10-8e27-3ea917e94cd0', 1, 1, 1, 1, CAST(N'2019-08-04T23:38:28.137' AS DateTime), N'Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Permission] ([PerID], [PerUID], [PgID], [User_id], [PerAdd], [PerEdit], [PerView], [PerDel], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'92781b5c-947b-41ee-8b53-8e9f08a9c448', N'1', N'b0955029-8317-446f-ac96-f13084dd9ba0', N'1a47706a-3d8b-4dae-aa6a-f2f2ad0858de', 1, 1, 1, 1, CAST(N'1990-01-01T00:00:00.000' AS DateTime), N'Super Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Permission] ([PerID], [PerUID], [PgID], [User_id], [PerAdd], [PerEdit], [PerView], [PerDel], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'a1ee23d8-9f36-4791-a984-961610d7b0a8', N'1', N'f15093c9-9347-4799-8ce6-790482e1e63f', N'1a47706a-3d8b-4dae-aa6a-f2f2ad0858de', 1, 1, 1, 1, CAST(N'1990-01-01T00:00:00.000' AS DateTime), N'Super Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Permission] ([PerID], [PerUID], [PgID], [User_id], [PerAdd], [PerEdit], [PerView], [PerDel], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'51ddbe67-b28a-45d5-ae0e-99a30e1560e5', N'1', N'9e6e8686-259f-4f04-8f78-9ad2f3079f0f', N'1a47706a-3d8b-4dae-aa6a-f2f2ad0858de', 1, 1, 1, 1, CAST(N'1990-01-01T00:00:00.000' AS DateTime), N'Super Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Permission] ([PerID], [PerUID], [PgID], [User_id], [PerAdd], [PerEdit], [PerView], [PerDel], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'cf92d4d9-5f28-4e76-984d-bb6b02e2faf4', N'2', N'633f79da-ec81-448c-8a0d-5084fe9e3bd0', N'680e99a8-02d7-4c10-8e27-3ea917e94cd0', 1, 1, 1, 1, CAST(N'2019-08-04T23:38:28.140' AS DateTime), N'Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Permission] ([PerID], [PerUID], [PgID], [User_id], [PerAdd], [PerEdit], [PerView], [PerDel], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'61c835fd-2c74-4deb-b78f-cd3c0d230b0c', N'2', N'80769a0a-6843-42e9-8db0-fa44e36e4026', N'680e99a8-02d7-4c10-8e27-3ea917e94cd0', 1, 1, 1, 1, CAST(N'2019-08-04T23:38:28.137' AS DateTime), N'Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Permission] ([PerID], [PerUID], [PgID], [User_id], [PerAdd], [PerEdit], [PerView], [PerDel], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'5100e845-9568-4f3d-8b99-d80c773bfc70', N'2', N'a801b5fc-ecd1-4b5b-8cea-dc57078aa939', N'680e99a8-02d7-4c10-8e27-3ea917e94cd0', 1, 1, 1, 1, CAST(N'2019-08-04T23:38:28.140' AS DateTime), N'Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Permission] ([PerID], [PerUID], [PgID], [User_id], [PerAdd], [PerEdit], [PerView], [PerDel], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'db474ec3-9708-4c43-a286-db221bb66e5b', N'1', N'604077ed-72bf-41d0-b1f1-b3cd03663da8', N'1a47706a-3d8b-4dae-aa6a-f2f2ad0858de', 1, 1, 1, 1, CAST(N'1990-01-01T00:00:00.000' AS DateTime), N'Super Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Permission] ([PerID], [PerUID], [PgID], [User_id], [PerAdd], [PerEdit], [PerView], [PerDel], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'baed8fdf-0dee-4cf0-a7c0-e30217caaa5c', N'1', N'c0e5ac6c-ca47-412e-8d21-353c9c6e8994', N'1a47706a-3d8b-4dae-aa6a-f2f2ad0858de', 1, 1, 1, 0, CAST(N'1990-01-01T00:00:00.000' AS DateTime), N'Super Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Permission] ([PerID], [PerUID], [PgID], [User_id], [PerAdd], [PerEdit], [PerView], [PerDel], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'cfea4c17-c5bf-48ad-9e1b-e927c2c99d26', N'2', N'690c503e-5f8f-44fc-a14c-6f10d73775aa', N'1a47706a-3d8b-4dae-aa6a-f2f2ad0858de', 1, 1, 1, 1, CAST(N'2019-08-04T00:00:00.000' AS DateTime), N'Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Permission] ([PerID], [PerUID], [PgID], [User_id], [PerAdd], [PerEdit], [PerView], [PerDel], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'c73f61a0-7cfa-4ca8-87aa-ebdeb950d28f', N'2', N'2596b75f-8ddb-42f4-9ce1-59d7263b2607', N'680e99a8-02d7-4c10-8e27-3ea917e94cd0', 1, 1, 1, 1, CAST(N'2019-08-04T23:38:28.137' AS DateTime), N'Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Permission] ([PerID], [PerUID], [PgID], [User_id], [PerAdd], [PerEdit], [PerView], [PerDel], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'992de63c-2ed1-4b59-aa73-f2ba1573c52d', N'2', N'f15093c9-9347-4799-8ce6-790482e1e63f', N'680e99a8-02d7-4c10-8e27-3ea917e94cd0', 1, 1, 1, 1, CAST(N'2019-08-04T23:38:28.143' AS DateTime), N'Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Permission] ([PerID], [PerUID], [PgID], [User_id], [PerAdd], [PerEdit], [PerView], [PerDel], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'a3d7394c-b6c3-4848-a6e8-f465d8e278a2', N'2', N'b0955029-8317-446f-ac96-f13084dd9ba0', N'680e99a8-02d7-4c10-8e27-3ea917e94cd0', 1, 1, 1, 1, CAST(N'2019-08-04T23:38:28.143' AS DateTime), N'Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Permission] ([PerID], [PerUID], [PgID], [User_id], [PerAdd], [PerEdit], [PerView], [PerDel], [Timestamp], [AddBy], [Status], [Flag], [EditBy], [EditDate]) VALUES (N'95afbcc8-4f99-4b2b-8963-fcf9eca261dc', N'2', N'b0ab4458-408c-4ddc-8828-98520923bb61', N'680e99a8-02d7-4c10-8e27-3ea917e94cd0', 1, 1, 1, 1, CAST(N'2019-08-04T23:38:28.137' AS DateTime), N'Admin', N'Active', 1, NULL, NULL)
GO
INSERT [dbo].[Product] ([Pro_id], [Product_Category_id], [name], [shortname], [description], [code], [company_name], [formula_name], [rs], [rm], [status], [opened], [quantityineach], [unit], [InStock], [Addby], [AddDate], [Editby], [EditDate], [Flag]) VALUES (N'260d1967-f357-42d8-bef1-60ed89bfd2b7', N'024cd0b6-d0c8-4f46-ac85-6d34be503907', N'Yellow Label TEA', N'', N'', N'8961014016048', N'Lipton', N'', 0, 0, 0, 0, 0, NULL, 0, N'00000000-0000-0000-0000-000000000000', CAST(N'2019-09-16T11:36:47.297' AS DateTime), NULL, NULL, 1)
GO
INSERT [dbo].[Product] ([Pro_id], [Product_Category_id], [name], [shortname], [description], [code], [company_name], [formula_name], [rs], [rm], [status], [opened], [quantityineach], [unit], [InStock], [Addby], [AddDate], [Editby], [EditDate], [Flag]) VALUES (N'588656a6-74bf-4961-9b6b-6bb8a3d719da', N'024cd0b6-d0c8-4f46-ac85-6d34be503907', N'Bunny Bread Sweet', N'', N'', N'', N'Bunny', N'', 0, 0, 0, 0, 0, NULL, 0, N'00000000-0000-0000-0000-000000000000', CAST(N'2019-09-14T20:01:46.027' AS DateTime), N'00000000-0000-0000-0000-000000000000', CAST(N'2019-09-14T22:59:04.170' AS DateTime), 1)
GO
INSERT [dbo].[Product] ([Pro_id], [Product_Category_id], [name], [shortname], [description], [code], [company_name], [formula_name], [rs], [rm], [status], [opened], [quantityineach], [unit], [InStock], [Addby], [AddDate], [Editby], [EditDate], [Flag]) VALUES (N'f8957463-d937-43be-9844-fa10f31a0175', N'024cd0b6-d0c8-4f46-ac85-6d34be503907', N'Pepsi 750ml', N'', N'', N'5424710400014', N'Pepsi Co', N'', 0, 0, 0, 0, 0, NULL, 0, N'00000000-0000-0000-0000-000000000000', CAST(N'2019-09-14T21:06:26.877' AS DateTime), N'680E99A8-02D7-4C10-8E27-3EA917E94CD0', CAST(N'2019-09-16T14:34:26.473' AS DateTime), 1)
GO
INSERT [dbo].[Product_Category] ([id], [parent_id], [name], [shortname], [code], [description], [AddDate], [Addby], [EditDate], [Editby], [status], [Flag]) VALUES (N'cfa644bb-4286-4088-a15f-02efbcddee81', NULL, N'sd', N'', N'', N'', CAST(N'2019-09-16T11:24:16.777' AS DateTime), N'Admin', NULL, NULL, 0, 0)
GO
INSERT [dbo].[Product_Category] ([id], [parent_id], [name], [shortname], [code], [description], [AddDate], [Addby], [EditDate], [Editby], [status], [Flag]) VALUES (N'f635910a-61c1-4907-a6ba-05d325b029a5', NULL, N'asd', N'', N'', N'asd', CAST(N'2019-09-16T11:20:58.203' AS DateTime), N'Admin', NULL, NULL, 0, 0)
GO
INSERT [dbo].[Product_Category] ([id], [parent_id], [name], [shortname], [code], [description], [AddDate], [Addby], [EditDate], [Editby], [status], [Flag]) VALUES (N'd02d0c2a-5457-4938-bab5-0f8b952731ec', NULL, N'Electronics', N' ', N' ', N'', NULL, NULL, CAST(N'2019-09-16T11:30:26.963' AS DateTime), N'Admin', 1, 1)
GO
INSERT [dbo].[Product_Category] ([id], [parent_id], [name], [shortname], [code], [description], [AddDate], [Addby], [EditDate], [Editby], [status], [Flag]) VALUES (N'80d08987-3fa3-45df-85db-45629f4c832c', NULL, N'asd', N'', N'', N'', CAST(N'2019-09-16T11:18:53.290' AS DateTime), N'Admin', NULL, NULL, 0, 0)
GO
INSERT [dbo].[Product_Category] ([id], [parent_id], [name], [shortname], [code], [description], [AddDate], [Addby], [EditDate], [Editby], [status], [Flag]) VALUES (N'024cd0b6-d0c8-4f46-ac85-6d34be503907', NULL, N'Groceries', N' ', N' ', N' ', NULL, NULL, NULL, NULL, 1, 1)
GO
INSERT [dbo].[Product_Category] ([id], [parent_id], [name], [shortname], [code], [description], [AddDate], [Addby], [EditDate], [Editby], [status], [Flag]) VALUES (N'c6fe3312-fa71-46e4-8842-6ebed345898b', NULL, N'asd', N'', N'', N'', CAST(N'2019-09-16T11:28:19.423' AS DateTime), N'Admin', NULL, NULL, 0, 0)
GO
INSERT [dbo].[Product_Category] ([id], [parent_id], [name], [shortname], [code], [description], [AddDate], [Addby], [EditDate], [Editby], [status], [Flag]) VALUES (N'3810da03-2b3e-4305-88c9-79effaba029a', NULL, N'Misc', N'', N'', N'', CAST(N'2019-09-16T11:30:13.677' AS DateTime), N'Admin', CAST(N'2019-09-16T11:30:24.930' AS DateTime), N'Admin', 1, 1)
GO
INSERT [dbo].[Product_Category] ([id], [parent_id], [name], [shortname], [code], [description], [AddDate], [Addby], [EditDate], [Editby], [status], [Flag]) VALUES (N'f6f7727f-17ab-4473-b0dd-98ccd9173761', NULL, N'asdasd', N'', N'', N'', CAST(N'2019-09-16T11:20:55.793' AS DateTime), N'Admin', NULL, NULL, 0, 0)
GO
INSERT [dbo].[Product_Category] ([id], [parent_id], [name], [shortname], [code], [description], [AddDate], [Addby], [EditDate], [Editby], [status], [Flag]) VALUES (N'3636aa94-f12a-4da5-aba2-a3cb5f23779d', NULL, N'asd', N'', N'', N'', CAST(N'2019-09-16T11:20:53.683' AS DateTime), N'Admin', NULL, NULL, 0, 0)
GO
INSERT [dbo].[Product_Category] ([id], [parent_id], [name], [shortname], [code], [description], [AddDate], [Addby], [EditDate], [Editby], [status], [Flag]) VALUES (N'83e1fa67-1622-4e11-8c37-b4cc35ee662d', NULL, N'asd', N'', N'', N'', CAST(N'2019-09-16T11:18:51.077' AS DateTime), N'Admin', NULL, NULL, 0, 0)
GO
INSERT [dbo].[Product_Category] ([id], [parent_id], [name], [shortname], [code], [description], [AddDate], [Addby], [EditDate], [Editby], [status], [Flag]) VALUES (N'70cf147e-8238-4362-b40a-bb6484c4663a', NULL, N'asd', N'', N'', N'', CAST(N'2019-09-16T11:16:42.763' AS DateTime), N'Admin', NULL, NULL, 0, 0)
GO
INSERT [dbo].[Product_Category] ([id], [parent_id], [name], [shortname], [code], [description], [AddDate], [Addby], [EditDate], [Editby], [status], [Flag]) VALUES (N'9b0d9390-d82f-4834-9177-c086eb64c70b', NULL, N'asd', N'', N'', N'', CAST(N'2019-09-16T11:19:47.110' AS DateTime), N'Admin', NULL, NULL, 0, 0)
GO
INSERT [dbo].[Product_Category] ([id], [parent_id], [name], [shortname], [code], [description], [AddDate], [Addby], [EditDate], [Editby], [status], [Flag]) VALUES (N'08a853e1-3d28-41f0-97c5-d53d470df49e', NULL, N'asd', N'', N'', N'', CAST(N'2019-09-16T11:19:19.487' AS DateTime), N'Admin', NULL, NULL, 0, 0)
GO
INSERT [dbo].[Product_Category] ([id], [parent_id], [name], [shortname], [code], [description], [AddDate], [Addby], [EditDate], [Editby], [status], [Flag]) VALUES (N'5f3f1449-6fa5-4e53-8c4d-e57b9ea671cb', NULL, N'Juice', N'', N'', N'', CAST(N'2019-09-16T11:37:36.463' AS DateTime), N'Admin', NULL, NULL, 1, 1)
GO
INSERT [dbo].[Product_Category] ([id], [parent_id], [name], [shortname], [code], [description], [AddDate], [Addby], [EditDate], [Editby], [status], [Flag]) VALUES (N'85fd9bc1-9d1b-4c5e-8bbe-f048a12ad5fe', NULL, N'asdasd', N'', N'', N'asd', CAST(N'2019-09-16T11:28:21.733' AS DateTime), N'Admin', NULL, NULL, 0, 0)
GO
INSERT [dbo].[Product_Category] ([id], [parent_id], [name], [shortname], [code], [description], [AddDate], [Addby], [EditDate], [Editby], [status], [Flag]) VALUES (N'2ef4a152-c10b-4179-8c26-f350a3bb634d', NULL, N'asd', N'', N'', N'', CAST(N'2019-09-16T11:24:12.857' AS DateTime), N'Admin', NULL, NULL, 0, 0)
GO
INSERT [dbo].[Product_Category] ([id], [parent_id], [name], [shortname], [code], [description], [AddDate], [Addby], [EditDate], [Editby], [status], [Flag]) VALUES (N'46a2e97d-e535-44ff-81cf-f93758ac5331', NULL, N'asd', N'', N'', N'', CAST(N'2019-09-16T11:28:22.310' AS DateTime), N'Admin', NULL, NULL, 0, 0)
GO
INSERT [dbo].[State] ([state_id], [name], [shortname], [desc], [code], [country_id], [add_by], [add_date], [edit_by], [edit_date]) VALUES (N'e9a3ad1d-f272-4e48-90e8-9c9a0fa6dc4f', N'Punjab', N'', N'', N'', N'08ba5227-7134-41ff-9711-18970b4d5904', N'Admin', CAST(N'2019-09-16T10:41:00.000' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Stock] ([id], [Product_Category_id], [Product_id], [Branch_id], [POS_id], [Organization_id], [RemainingQuantity], [Quantity], [PurchasePrice], [SellPrice], [barcode], [expiryDate], [qie], [instock], [AddDate], [AddBy], [EditDate], [EditBy], [Flag]) VALUES (N'B5A1620B-BFAA-4598-A7B5-EA9981E01C58', NULL, N'588656A6-74BF-4961-9B6B-6BB8A3D719DA', N'00000000-0000-0000-0000-000000000000', N'00000000-0000-0000-0000-000000000000', N'00000000-0000-0000-0000-000000000000', 4, 4, 60, 70, N'123123123123', NULL, 1, NULL, CAST(N'2019-09-14T20:01:46.047' AS DateTime), N'00000000-0000-0000-0000-000000000000', CAST(N'2019-09-14T22:59:04.187' AS DateTime), N'00000000-0000-0000-0000-000000000000', 1)
GO
INSERT [dbo].[Stock] ([id], [Product_Category_id], [Product_id], [Branch_id], [POS_id], [Organization_id], [RemainingQuantity], [Quantity], [PurchasePrice], [SellPrice], [barcode], [expiryDate], [qie], [instock], [AddDate], [AddBy], [EditDate], [EditBy], [Flag]) VALUES (N'9D834759-CF71-4D6B-94A9-A301323C0AED', NULL, N'588656A6-74BF-4961-9B6B-6BB8A3D719DA', N'00000000-0000-0000-0000-000000000000', N'00000000-0000-0000-0000-000000000000', N'00000000-0000-0000-0000-000000000000', 6, 6, 55, 70, N'123412341234', NULL, 1, NULL, CAST(N'2019-09-14T20:28:02.823' AS DateTime), N'00000000-0000-0000-0000-000000000000', CAST(N'2019-09-14T22:59:04.197' AS DateTime), N'00000000-0000-0000-0000-000000000000', 1)
GO
INSERT [dbo].[Stock] ([id], [Product_Category_id], [Product_id], [Branch_id], [POS_id], [Organization_id], [RemainingQuantity], [Quantity], [PurchasePrice], [SellPrice], [barcode], [expiryDate], [qie], [instock], [AddDate], [AddBy], [EditDate], [EditBy], [Flag]) VALUES (N'6AE024F8-262E-4EA4-AC99-8199119608A4', NULL, N'F8957463-D937-43BE-9844-FA10F31A0175', N'00000000-0000-0000-0000-000000000000', N'00000000-0000-0000-0000-000000000000', N'00000000-0000-0000-0000-000000000000', 0, 0, 0, 0, N'0', NULL, 0, NULL, CAST(N'2019-09-14T21:06:26.900' AS DateTime), N'00000000-0000-0000-0000-000000000000', CAST(N'2019-09-16T14:34:26.840' AS DateTime), N'680E99A8-02D7-4C10-8E27-3EA917E94CD0', 1)
GO
INSERT [dbo].[Stock] ([id], [Product_Category_id], [Product_id], [Branch_id], [POS_id], [Organization_id], [RemainingQuantity], [Quantity], [PurchasePrice], [SellPrice], [barcode], [expiryDate], [qie], [instock], [AddDate], [AddBy], [EditDate], [EditBy], [Flag]) VALUES (N'93A5FA1B-BCC9-4785-B94F-4ED8B13B85F1', NULL, N'260D1967-F357-42D8-BEF1-60ED89BFD2B7', N'00000000-0000-0000-0000-000000000000', N'00000000-0000-0000-0000-000000000000', N'00000000-0000-0000-0000-000000000000', 0, 0, 0, 0, N'', NULL, 0, NULL, CAST(N'2019-09-16T11:36:47.320' AS DateTime), N'00000000-0000-0000-0000-000000000000', NULL, NULL, 1)
GO
INSERT [dbo].[Users] ([User_id], [First_name], [Last_name], [User_name], [Father_name], [Cnic], [Email], [password], [contact], [Phone], [country_id], [state_id], [city_id], [Area_id], [Adress], [Gender], [DOB], [Account_type], [Timestamp], [Add_by], [Status], [Flag], [FirstTimeLogin], [Editby], [EditDate], [Organization_id], [Branch_id], [Employee_id]) VALUES (N'680e99a8-02d7-4c10-8e27-3ea917e94cd0', N'POS', N'', N'pos', N'', N'3520112345671', N'fariha@gmail.com', N'f9a1b0d0ed2322e03db42cb0657349365a6ef1e40e61a844c7bcb83eaa25a683', N'03014643476', N'03014643476', N'08ba5227-7134-41ff-9711-18970b4d5904', N'e9a3ad1d-f272-4e48-90e8-9c9a0fa6dc4f', N'c2f98a37-1819-418b-be62-855110433f99', N'528c6732-ce1e-4c42-ad21-c91478ef2dff', N'Lahore', N'Female', CAST(N'2019-08-04' AS Date), N'Organization Admin', CAST(N'2019-08-04T23:38:28.043' AS DateTime), N'Admin', N'Activate', 1, 1, NULL, NULL, N'ddaaebe8-a6ab-4ca1-8df9-0c6194a37b04', N'ed933606-a522-463e-97d4-8c541bd7f221', N'00000000-0000-0000-0000-000000000000')
GO
INSERT [dbo].[Users] ([User_id], [First_name], [Last_name], [User_name], [Father_name], [Cnic], [Email], [password], [contact], [Phone], [country_id], [state_id], [city_id], [Area_id], [Adress], [Gender], [DOB], [Account_type], [Timestamp], [Add_by], [Status], [Flag], [FirstTimeLogin], [Editby], [EditDate], [Organization_id], [Branch_id], [Employee_id]) VALUES (N'da9ee1ab-f13a-45d4-8a72-4b3a32e05a2d', N'Ramsha', N'Raheel', N'Ramsha Raheel', N'Muhammad Raheel', N'3520112345671', N'ramsha@gmail.com', N'8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', N'03078875229', N'03078875229', N'08ba5227-7134-41ff-9711-18970b4d5904', N'e9a3ad1d-f272-4e48-90e8-9c9a0fa6dc4f', N'c2f98a37-1819-418b-be62-855110433f99', N'528c6732-ce1e-4c42-ad21-c91478ef2dff', N'Gajjumata Lahore', N'Female', CAST(N'1999-03-09' AS Date), N'Super Admin', CAST(N'2019-08-11T00:37:13.420' AS DateTime), N'Admin', N'Activate', 1, 1, NULL, NULL, N'2f3b201d-9ffc-46ce-91cb-00fd9d4fdf36', N'93755b82-5b8e-405b-964f-5974d708f47c', N'00000000-0000-0000-0000-000000000000')
GO
INSERT [dbo].[Users] ([User_id], [First_name], [Last_name], [User_name], [Father_name], [Cnic], [Email], [password], [contact], [Phone], [country_id], [state_id], [city_id], [Area_id], [Adress], [Gender], [DOB], [Account_type], [Timestamp], [Add_by], [Status], [Flag], [FirstTimeLogin], [Editby], [EditDate], [Organization_id], [Branch_id], [Employee_id]) VALUES (N'd6e9c662-4a89-465d-8d99-63d3339d863f', N'Faisal', N'Muneer', N'Faisal Muneer', N'Muneer', N'3520112345671', N'faisal@gmail.com', N'8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', N'03014643476', N'03014643476', N'08ba5227-7134-41ff-9711-18970b4d5904', N'e9a3ad1d-f272-4e48-90e8-9c9a0fa6dc4f', N'c2f98a37-1819-418b-be62-855110433f99', N'528c6732-ce1e-4c42-ad21-c91478ef2dff', N'Lahore', N'Male', CAST(N'2019-03-09' AS Date), N'Organization Admin', CAST(N'2019-08-04T23:40:39.010' AS DateTime), N'Admin', N'Activate', 1, 1, NULL, NULL, N'2f3b201d-9ffc-46ce-91cb-00fd9d4fdf36', N'93755b82-5b8e-405b-964f-5974d708f47c', N'00000000-0000-0000-0000-000000000000')
GO
INSERT [dbo].[Users] ([User_id], [First_name], [Last_name], [User_name], [Father_name], [Cnic], [Email], [password], [contact], [Phone], [country_id], [state_id], [city_id], [Area_id], [Adress], [Gender], [DOB], [Account_type], [Timestamp], [Add_by], [Status], [Flag], [FirstTimeLogin], [Editby], [EditDate], [Organization_id], [Branch_id], [Employee_id]) VALUES (N'e0ef4d88-9265-42f5-a64a-7ef4b8b0b986', N'Inaam', N'Rehman', N'Inaam-ur-rehman', N'rehman', N'3520112345672', N'toqeernaqvi66@gmail.com', N'8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', N'0305438787190', N'03078875229', N'08ba5227-7134-41ff-9711-18970b4d5904', N'e9a3ad1d-f272-4e48-90e8-9c9a0fa6dc4f', N'c2f98a37-1819-418b-be62-855110433f99', N'528c6732-ce1e-4c42-ad21-c91478ef2dff', N'Batapur Lahore', N'Male', CAST(N'2019-03-09' AS Date), N'Organization Admin', CAST(N'2019-08-04T23:40:58.990' AS DateTime), N'Admin', N'Activate', 1, 1, NULL, NULL, N'2f3b201d-9ffc-46ce-91cb-00fd9d4fdf36', N'93755b82-5b8e-405b-964f-5974d708f47c', N'00000000-0000-0000-0000-000000000000')
GO
INSERT [dbo].[Users] ([User_id], [First_name], [Last_name], [User_name], [Father_name], [Cnic], [Email], [password], [contact], [Phone], [country_id], [state_id], [city_id], [Area_id], [Adress], [Gender], [DOB], [Account_type], [Timestamp], [Add_by], [Status], [Flag], [FirstTimeLogin], [Editby], [EditDate], [Organization_id], [Branch_id], [Employee_id]) VALUES (N'a6a73545-8a1e-4c95-86c1-8ad31e809bc3', N'Sara', N'Rana', N'Sara Rana', N'Rana', N'3520112345671', N'sara@gmail.com', N'8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', N'03014643476', N'03014643476', N'08ba5227-7134-41ff-9711-18970b4d5904', N'e9a3ad1d-f272-4e48-90e8-9c9a0fa6dc4f', N'c2f98a37-1819-418b-be62-855110433f99', N'528c6732-ce1e-4c42-ad21-c91478ef2dff', N'Lahore', N'Female', CAST(N'2019-03-09' AS Date), N'Super Admin', CAST(N'2019-08-04T23:41:09.557' AS DateTime), N'Admin', N'Activate', 1, 1, NULL, NULL, N'2f3b201d-9ffc-46ce-91cb-00fd9d4fdf36', N'93755b82-5b8e-405b-964f-5974d708f47c', N'00000000-0000-0000-0000-000000000000')
GO
INSERT [dbo].[Users] ([User_id], [First_name], [Last_name], [User_name], [Father_name], [Cnic], [Email], [password], [contact], [Phone], [country_id], [state_id], [city_id], [Area_id], [Adress], [Gender], [DOB], [Account_type], [Timestamp], [Add_by], [Status], [Flag], [FirstTimeLogin], [Editby], [EditDate], [Organization_id], [Branch_id], [Employee_id]) VALUES (N'002b474e-81f6-4348-b284-90957761b921', N'Kiran', N'Shahzadi', N'Kiran Shahzadi', N'Muhammad Ramzan', N'3520112345671', N'kiranshahzadi@gmail.com', N'8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', N'03078875229', N'03078875229', N'08ba5227-7134-41ff-9711-18970b4d5904', N'e9a3ad1d-f272-4e48-90e8-9c9a0fa6dc4f', N'c2f98a37-1819-418b-be62-855110433f99', N'528c6732-ce1e-4c42-ad21-c91478ef2dff', N'ittifaq colony Lahore', N'Female', CAST(N'1998-01-15' AS Date), N'Organization Admin', CAST(N'2019-08-04T23:41:20.127' AS DateTime), N'Admin', N'Activate', 1, 1, NULL, NULL, N'2f3b201d-9ffc-46ce-91cb-00fd9d4fdf36', N'93755b82-5b8e-405b-964f-5974d708f47c', N'00000000-0000-0000-0000-000000000000')
GO
INSERT [dbo].[Users] ([User_id], [First_name], [Last_name], [User_name], [Father_name], [Cnic], [Email], [password], [contact], [Phone], [country_id], [state_id], [city_id], [Area_id], [Adress], [Gender], [DOB], [Account_type], [Timestamp], [Add_by], [Status], [Flag], [FirstTimeLogin], [Editby], [EditDate], [Organization_id], [Branch_id], [Employee_id]) VALUES (N'2d1533e9-f9a7-4a45-93f3-ad3eb094812d', N'Ali', N'zaib', N'Ali ', N'ZAib', N'3520123456765', N'ali@gmail.com', N'8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', N'03014643476', N'03014643476', N'08ba5227-7134-41ff-9711-18970b4d5904', N'e9a3ad1d-f272-4e48-90e8-9c9a0fa6dc4f', N'c2f98a37-1819-418b-be62-855110433f99', N'528c6732-ce1e-4c42-ad21-c91478ef2dff', N'Lahore', N'Male', CAST(N'2019-03-09' AS Date), N'Organization Admin', CAST(N'2019-08-04T23:41:31.693' AS DateTime), N'Admin', N'Activate', 1, 1, NULL, NULL, N'2f3b201d-9ffc-46ce-91cb-00fd9d4fdf36', N'93755b82-5b8e-405b-964f-5974d708f47c', N'00000000-0000-0000-0000-000000000000')
GO
INSERT [dbo].[Users] ([User_id], [First_name], [Last_name], [User_name], [Father_name], [Cnic], [Email], [password], [contact], [Phone], [country_id], [state_id], [city_id], [Area_id], [Adress], [Gender], [DOB], [Account_type], [Timestamp], [Add_by], [Status], [Flag], [FirstTimeLogin], [Editby], [EditDate], [Organization_id], [Branch_id], [Employee_id]) VALUES (N'1a47706a-3d8b-4dae-aa6a-f2f2ad0858de', N'Syed ', N'Toqeer Abbas', N'Syed Toqeer Abbas', N'Syed Tahir Nasir', N'3520112345671', N'toqeernaqvi66@gmail.com', N'8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', N'03014643476', N'03078875229', N'08ba5227-7134-41ff-9711-18970b4d5904', N'e9a3ad1d-f272-4e48-90e8-9c9a0fa6dc4f', N'c2f98a37-1819-418b-be62-855110433f99', N'528c6732-ce1e-4c42-ad21-c91478ef2dff', N'Lahore', N'Male', CAST(N'2019-03-09' AS Date), N'Organization Admin', CAST(N'2019-08-31T12:45:54.707' AS DateTime), N'Admin', N'Activate', 1, 1, NULL, NULL, N'ddaaebe8-a6ab-4ca1-8df9-0c6194a37b04', N'ed933606-a522-463e-97d4-8c541bd7f221', N'00000000-0000-0000-0000-000000000000')
GO
ALTER TABLE [dbo].[Accounts] ADD  CONSTRAINT [DF_Accounts_Account_id]  DEFAULT (newid()) FOR [Account_id]
GO
ALTER TABLE [dbo].[Area] ADD  CONSTRAINT [DF_Area_area_id]  DEFAULT (newid()) FOR [area_id]
GO
ALTER TABLE [dbo].[Assign_Experties] ADD  CONSTRAINT [DF_Assign_Experties_AssignId]  DEFAULT (newid()) FOR [AssignId]
GO
ALTER TABLE [dbo].[City] ADD  CONSTRAINT [DF_City_city_id]  DEFAULT (newid()) FOR [city_id]
GO
ALTER TABLE [dbo].[Country] ADD  CONSTRAINT [DF_Country_country_id]  DEFAULT (newid()) FOR [country_id]
GO
ALTER TABLE [dbo].[Credential_Table] ADD  CONSTRAINT [DF_Credential_Table_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[Department] ADD  CONSTRAINT [DF_Department_dept_id]  DEFAULT (newid()) FOR [dept_id]
GO
ALTER TABLE [dbo].[Employee_CompanyInfo] ADD  CONSTRAINT [DF_Employee_CompanyInfo_employeeCompany_id]  DEFAULT (newid()) FOR [employeeCompany_id]
GO
ALTER TABLE [dbo].[Employee_CustomAttendence] ADD  CONSTRAINT [DF_Employee_CustomAttendence_Attendence_id]  DEFAULT (newid()) FOR [Attendence_id]
GO
ALTER TABLE [dbo].[Employee_PersonalInfo] ADD  CONSTRAINT [DF_Employee_PersonalInfo_employee_id]  DEFAULT (newid()) FOR [employee_id]
GO
ALTER TABLE [dbo].[Fetch] ADD  CONSTRAINT [DF_Fetch_id]  DEFAULT (newid()) FOR [id]
GO
ALTER TABLE [dbo].[HCC_Balance] ADD  CONSTRAINT [DF_HCC_Balance_id]  DEFAULT (newid()) FOR [id]
GO
ALTER TABLE [dbo].[Item_Category] ADD  CONSTRAINT [DF_Item_Category_itemCat_id]  DEFAULT (newid()) FOR [itemCat_id]
GO
ALTER TABLE [dbo].[Jobstatus] ADD  CONSTRAINT [DF_Jobstatus_jobstatus_id]  DEFAULT (newid()) FOR [jobstatus_id]
GO
ALTER TABLE [dbo].[lab] ADD  CONSTRAINT [DF_lab_lab_id]  DEFAULT (newid()) FOR [lab_id]
GO
ALTER TABLE [dbo].[lab_invoice] ADD  CONSTRAINT [DF_lab_invoice_lab_invoice_id]  DEFAULT (newid()) FOR [lab_invoice_id]
GO
ALTER TABLE [dbo].[lab_invoice_income] ADD  CONSTRAINT [DF_lab_invoice_income_lab_invoice_income_id]  DEFAULT (newid()) FOR [lab_invoice_income_id]
GO
ALTER TABLE [dbo].[lab_test] ADD  CONSTRAINT [DF_lab_test_lab_test_id]  DEFAULT (newid()) FOR [lab_test_id]
GO
ALTER TABLE [dbo].[label_tab] ADD  CONSTRAINT [DF_label_tab_label_id]  DEFAULT (newid()) FOR [label_id]
GO
ALTER TABLE [dbo].[Medicine] ADD  CONSTRAINT [DF_Medicine_Medicine_id]  DEFAULT (newid()) FOR [Medicine_id]
GO
ALTER TABLE [dbo].[Medicine] ADD  CONSTRAINT [DF_Medicine_opened]  DEFAULT ((0)) FOR [opened]
GO
ALTER TABLE [dbo].[Medicine] ADD  CONSTRAINT [DF_Medicine_quantityineach]  DEFAULT ((1)) FOR [quantityineach]
GO
ALTER TABLE [dbo].[Medicine_Category] ADD  CONSTRAINT [DF_Medicine_Category_Medicine_Category_id]  DEFAULT (newid()) FOR [Medicine_Category_id]
GO
ALTER TABLE [dbo].[Office] ADD  CONSTRAINT [DF_Office_office_id]  DEFAULT (newid()) FOR [office_id]
GO
ALTER TABLE [dbo].[Organization] ADD  CONSTRAINT [DF_Organization_Organization_id]  DEFAULT (newid()) FOR [Organization_id]
GO
ALTER TABLE [dbo].[Pages] ADD  CONSTRAINT [DF_Pages_PgID]  DEFAULT (newid()) FOR [PgID]
GO
ALTER TABLE [dbo].[Party] ADD  CONSTRAINT [DF_Party_p_id]  DEFAULT (newid()) FOR [p_id]
GO
ALTER TABLE [dbo].[party_invoice] ADD  CONSTRAINT [DF_party_invoice_party_invoice_id]  DEFAULT (newid()) FOR [party_invoice_id]
GO
ALTER TABLE [dbo].[party_invoice_medicine] ADD  CONSTRAINT [DF_party_invoice_medicine_party_invoice_medicine_id]  DEFAULT (newid()) FOR [party_invoice_medicine_id]
GO
ALTER TABLE [dbo].[party_invoice_product] ADD  CONSTRAINT [DF_party_invoice_product_party_invoice_product_id]  DEFAULT (newid()) FOR [party_invoice_product_id]
GO
ALTER TABLE [dbo].[patient_basic] ADD  CONSTRAINT [DF_patient_basic_patient_id]  DEFAULT (newid()) FOR [patient_id]
GO
ALTER TABLE [dbo].[patient_contact_address] ADD  CONSTRAINT [DF_patient_contact_address_patient_contact_address_id]  DEFAULT (newid()) FOR [patient_contact_address_id]
GO
ALTER TABLE [dbo].[patient_Next_of_kin] ADD  CONSTRAINT [DF_patient_Next_of_kin_patient_Next_of_kin_id]  DEFAULT (newid()) FOR [patient_Next_of_kin_id]
GO
ALTER TABLE [dbo].[patient_prescription] ADD  CONSTRAINT [DF_patient_prescription_patient_prescription_id]  DEFAULT (newid()) FOR [patient_prescription_id]
GO
ALTER TABLE [dbo].[patient_prescription_LabTest] ADD  CONSTRAINT [DF_patient_prescription_LabTest_patient_prescription_LabTest_id]  DEFAULT (newid()) FOR [patient_prescription_LabTest_id]
GO
ALTER TABLE [dbo].[patient_prescription_medicine] ADD  CONSTRAINT [DF_patient_prescription_medicine_patient_prescription_medicine_id]  DEFAULT (newid()) FOR [patient_prescription_medicine_id]
GO
ALTER TABLE [dbo].[Permission] ADD  CONSTRAINT [DF_Permission_PerID]  DEFAULT (newid()) FOR [PerID]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_Pro_id]  DEFAULT (newid()) FOR [Pro_id]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_opened]  DEFAULT ((0)) FOR [opened]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_quantityineach]  DEFAULT ((1)) FOR [quantityineach]
GO
ALTER TABLE [dbo].[Product_Category] ADD  CONSTRAINT [DF_Product_Category_Product_Category_id]  DEFAULT (newid()) FOR [id]
GO
ALTER TABLE [dbo].[SectionEMP] ADD  CONSTRAINT [DF_SectionEMP_section_id]  DEFAULT (newid()) FOR [section_id]
GO
ALTER TABLE [dbo].[State] ADD  CONSTRAINT [DF_State_state_id]  DEFAULT (newid()) FOR [state_id]
GO
ALTER TABLE [dbo].[Stock] ADD  CONSTRAINT [DF_Stock_id]  DEFAULT (newid()) FOR [id]
GO
ALTER TABLE [dbo].[test] ADD  CONSTRAINT [DF_test_test_id]  DEFAULT (newid()) FOR [test_id]
GO
ALTER TABLE [dbo].[User_Education] ADD  CONSTRAINT [DF_User_Education_Education_id]  DEFAULT (newid()) FOR [Education_id]
GO
ALTER TABLE [dbo].[User_Experience] ADD  CONSTRAINT [DF_User_Experience_Experience_id]  DEFAULT (newid()) FOR [Experience_id]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_User_id]  DEFAULT (newid()) FOR [User_id]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_First_name]  DEFAULT ('(newid())') FOR [First_name]
GO
/****** Object:  StoredProcedure [dbo].[add_organization]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[add_organization]
@title varchar(50),@status varchar(20), @flg tinyint
as
begin
insert into organization(title, Status,Flag)
values(@title,@status,@flg)
end
GO
/****** Object:  StoredProcedure [dbo].[AreaDelete]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AreaDelete]	
(
	@Area_id UNIQUEIDENTIFIER
)
AS
BEGIN
	Delete From Area WHERE area_id=@Area_id
END
GO
/****** Object:  StoredProcedure [dbo].[AreaInsert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AreaInsert]
(
	@name varchar(50),
	@shortname varchar(50),
	@desc varchar(50),
	@code varchar(50),
	@country_id UNIQUEIDENTIFIER,
	@state_id UNIQUEIDENTIFIER,
	@city_id UNIQUEIDENTIFIER
) 
	
AS
BEGIN
	INSERT INTO Area (name,shortname,[desc],code,country_id,state_id,city_id)
	VALUES(@name,@shortname,@desc,@code,@country_id,@state_id,@city_id)
END
-- ========================================uPDATE====================================================
GO
/****** Object:  StoredProcedure [dbo].[AreaLoadALL]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AreaLoadALL]	
AS
BEGIN
	Select Area.name as 'Name',Area.shortname as 'Short Name',Area.code as'Code', Area.[desc] as 'Description' ,CountryEMP.name as 'Country' ,State.name as 'State',
	City.name as 'City', Area.area_id as 'ID'
	From Area
	JOIN CountryEMP ON CountryEMP.country_id=Area.country_id
	JOIN State ON State.state_id=Area.state_id
	JOIN City ON City.city_id=Area.city_id
END
-- ==========================================LoadByID===================================================
GO
/****** Object:  StoredProcedure [dbo].[AreaLoadbyID]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AreaLoadbyID]	
(
	@city_id UNIQUEIDENTIFIER
)
AS
BEGIN
	 SELECT * FROM dbo.Area
	WHERE dbo.Area.city_id=@city_id
END
GO
/****** Object:  StoredProcedure [dbo].[AreaUpdate]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AreaUpdate]
(
	@name varchar(50),
	@shortname varchar(50),
	@desc varchar(50),
	@code varchar(50),	
	@country_id UNIQUEIDENTIFIER,
	@state_id UNIQUEIDENTIFIER,
	@city_id UNIQUEIDENTIFIER,
	@area_id UNIQUEIDENTIFIER
) 
	
AS
BEGIN
	UPDATE Area 
	SET 
	name=@name,
	shortname=@shortname,
	[desc]=@desc,
	code=@code,
	country_id=	@country_id,
	state_id=@state_id,
	city_id=@city_id
	WHERE area_id=@area_id
	
END
-- ==========================================LoadALL==================================================
GO
/****** Object:  StoredProcedure [dbo].[City_Add]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[City_Add]
(
@name varchar(50),
@shortname varchar(50),
@code varchar(50),
@description varchar(50),
@country_id UNIQUEIDENTIFIER,
@state_id UNIQUEIDENTIFIER,
@add_by varchar(50),
@add_date varchar(50)
)
AS
BEGIN


INSERT INTO [dbo].[City]
           ([name]
           ,[shortname]
           ,[desc]
           ,[code]
           ,[country_id]
		   ,[state_id]
           ,[add_by]
           ,[add_date])
     VALUES
           (@name
		   ,@shortname
		   ,@description
		   ,@code
		   ,@country_id
		   ,@state_id
		   ,@add_by
		   ,@add_date
		    
		   )


END
GO
/****** Object:  StoredProcedure [dbo].[City_Delete]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[City_Delete]
(
@id UniqueIdentifier
)
AS
BEGIN

DELETE FROM City
WHERE City_id = @id
	END
GO
/****** Object:  StoredProcedure [dbo].[City_LoadAll]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[City_LoadAll]
--@id int 
AS
BEGIN
 SELECT * FROM city
 -- where country_id = @id and state_id = @id
	END

 
GO
/****** Object:  StoredProcedure [dbo].[City_LoadBy_State]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[City_LoadBy_State]
@id UNIQUEIDENTIFIER
as
begin
SELECT * 
FROM City WHERE state_id = @id
end
GO
/****** Object:  StoredProcedure [dbo].[City_LoadByCountry]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[City_LoadByCountry]
(
@country_id uniqueidentifier,
@state_id uniqueidentifier
)

AS
BEGIN

SELECT * FROM city WHERE city.country_id = @country_id and city.state_id = @state_id
	END
GO
/****** Object:  StoredProcedure [dbo].[City_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[City_Update]
(
@id UNIQUEIDENTIFIER,
@name varchar(50),
@shortname varchar(50),
@code varchar(50),
@description varchar(50),
@country_id UNIQUEIDENTIFIER,
@state_id UNIQUEIDENTIFIER,
@edit_by varchar(50),
@edit_date varchar(50)

)
AS
BEGIN


UPDATE [dbo].[City]
   SET [name]       = @name
      ,[shortname]  = @shortname
      ,[desc]		= @description
      ,[code]		= @code
      ,[country_id] = @country_id
	  ,[state_id] = @state_id
      ,[edit_by]    = @edit_by
	  ,[edit_date]  = @edit_date

WHERE City.City_id = @id



	END
GO
/****** Object:  StoredProcedure [dbo].[Comment_LoadAll]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[Comment_LoadAll]
AS
BEGIN

Select*from Comment_tab
END
GO
/****** Object:  StoredProcedure [dbo].[Comment_LoadByIssue]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure[dbo].[Comment_LoadByIssue]
(@issue_id uniqueidentifier)

AS
BEGIN
select*from Comment_tab where Issue_id =@issue_id
END
GO
/****** Object:  StoredProcedure [dbo].[Country_Add]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Country_Add]
(
	@Name varchar(50),
	@Shortname varchar(50),
	@Description varchar(50),
	@Code varchar(50),
	@Add_By varchar(50),
	@Add_Date DATETIME
) 
	
AS
BEGIN
	INSERT INTO Country (name,shortname,[desc],code,add_by,add_date)
	VALUES(@name,@shortname,@Description,@code,@Add_By,@Add_Date)
END

exec Country_Add 'Pakistan','PAK','Muslim country','+92','Admin','18/07/2019'
GO
/****** Object:  StoredProcedure [dbo].[Country_Delete]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[Country_Delete]	
(
	@id uniqueidentifier
)
AS
BEGIN
	Delete From Country WHERE country_id=@id
END
GO
/****** Object:  StoredProcedure [dbo].[Country_LoadALL]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[Country_LoadALL]	
AS
BEGIN
	Select * FROM Country
END
GO
/****** Object:  StoredProcedure [dbo].[Country_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Country_Update]
(
	@id UNIQUEIDENTIFIER,
	@name NVARCHAR(50),
	@shortname NVARCHAR(50),
	@description NVARCHAR(50),
	@code NVARCHAR(50),
	@edit_by NVARCHAR(50),
	@edit_date DATETIME
) 
	
AS
BEGIN
	UPDATE Country 
	SET 
	name=@name,
	shortname=@shortname,
	[desc]=@description,
	code=@code,
	edit_by = @edit_by,
	edit_date = @edit_date
	WHERE
	country_id=@id
END
GO
/****** Object:  StoredProcedure [dbo].[CustomAttendanceDelete]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CustomAttendanceDelete]	
(
	@ca_id int
)
AS
BEGIN
	Delete From CustomAttendance WHERE ca_id=@ca_id
END
GO
/****** Object:  StoredProcedure [dbo].[CustomAttendanceInsert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CustomAttendanceInsert]
(
	@time_in datetime,
	@time_out datetime,
	@short_leave datetime,
	@grace_time datetime,
	@absent_after datetime,
	@break_start datetime,
	@break_end datetime,
	@employee_id int,
	@local bit,
	@web bit,
	@add_by varchar(50),
	@add_date date
	
	
) 
	
AS
BEGIN
	INSERT INTO CustomAttendance 
	(
		time_in ,
		time_out ,
		short_leave ,
		grace_time ,
		absent_after ,
		break_start ,
		break_end,
		employee_id,
		local ,
		web,
		add_by,
		add_date
	)
	VALUES(
		@time_in ,
		@time_out ,
		@short_leave ,
		@grace_time ,
		@absent_after ,
		@break_start ,
		@break_end,
		@employee_id,
		@local ,
		@web,
		@add_by,
		@add_date
		)
		END
-- ========================================uPDATE====================================================
GO
/****** Object:  StoredProcedure [dbo].[CustomAttendanceUpdate]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CustomAttendanceUpdate]
(

	@time_in datetime,
	@time_out datetime,
	@short_leave datetime,
	@grace_time datetime,
	@absent_after datetime,
	@break_start datetime,
	@break_end datetime,
	@employee_id int,
	@local bit,
	@web bit,
	@edit_by varchar(50),
	@edit_date date,
	@ca_id int
) 
	
AS
BEGIN
	UPDATE CustomAttendance 
	SET 	
	time_in=@time_in,
	time_out=@time_out,
	short_leave=@short_leave,
	grace_time=@grace_time,
	absent_after=@absent_after,
	break_start=@break_start,
	break_end=@break_end,
	employee_id=@employee_id,
	local=@local,
	web=@web,
	edit_by=@edit_by,
	edit_date=@edit_date
	

	WHERE ca_id=@ca_id
	
END
-- ==========================================LoadALL==================================================
GO
/****** Object:  StoredProcedure [dbo].[DELETE_Iss_labels]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[DELETE_Iss_labels]
@id uniqueidentifier
as
begin
delete from Issue_labels where Id =@id
end
GO
/****** Object:  StoredProcedure [dbo].[DELETE_Iss_labels_by_issue]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[DELETE_Iss_labels_by_issue]
@Issue_id uniqueidentifier
as
begin
delete from Issue_labels where Issue_id =@Issue_id
end

GO
/****** Object:  StoredProcedure [dbo].[Employee_CompanyInfoDelete]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Employee_CompanyInfoDelete]	
(
	@employee_id uniqueidentifier
)
AS
BEGIN
	Delete From Employee_CompanyInfo WHERE @employee_id=@employee_id
END
GO
/****** Object:  StoredProcedure [dbo].[Employee_CompanyInfoInsert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Employee_CompanyInfoInsert]
(
	@jobstatus_id uniqueidentifier,
	@employee_id uniqueidentifier,
	@salary varchar(50),
	@designation varchar(50),
	@scale varchar(50),
 	@date_of_join date,
	@leavedate date
	
	
	
) 
	
AS
BEGIN
	INSERT INTO Employee_CompanyInfo 
	(jobstatus_id,employee_id,Salary,designation,scale, date_of_join,leavedate )
	VALUES(@jobstatus_id,@employee_id,@salary,@designation,@scale, @date_of_join,@leavedate)
END
-- ========================================uPDATE====================================================
GO
/****** Object:  StoredProcedure [dbo].[Employee_CompanyInfoLoadALL]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Employee_CompanyInfoLoadALL]	
AS
BEGIN
	SELECT 
 * from Employee_CompanyInfo
END
-- ==========================================LoadByID===================================================
GO
/****** Object:  StoredProcedure [dbo].[Employee_CompanyInfoLoadbyID]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Employee_CompanyInfoLoadbyID]	
(
	@employee_id uniqueidentifier
)
AS
BEGIN
		SELECT 
	* from Employee_CompanyInfo      WHERE Employee_CompanyInfo.employee_id=@employee_id
END
-- ===========================================Delete=================================================
GO
/****** Object:  StoredProcedure [dbo].[Employee_CompanyInfoUpdate]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Employee_CompanyInfoUpdate]
(
	@jobstatus_id uniqueidentifier,
	@employee_id uniqueidentifier,
	@salary varchar(50),
	@designation varchar(50),
	@scale varchar(50),
 	@date_of_join date,
	@leavedate date
	
) 
	
AS
BEGIN
	UPDATE Employee_CompanyInfo 
	SET 
	designation=@designation,
	scale=@scale,
	jobstatus_id=@jobstatus_id,
	date_of_join=@date_of_join,
	leavedate=@leavedate
	,salary = @salary
	WHERE 
	employee_id=@employee_id
	
END
-- ==========================================LoadALL==================================================
GO
/****** Object:  StoredProcedure [dbo].[Employee_PersonalInfoDelete]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Employee_PersonalInfoDelete]	
(
	@employee_id UNIQUEIDENTIFIER
)
AS
BEGIN
	Delete From Employee_PersonalInfo WHERE employee_id=@employee_id
END
GO
/****** Object:  StoredProcedure [dbo].[Employee_PersonalInfoGetid]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Employee_PersonalInfoGetid]	
AS
BEGIN
	SELECT 
	Employee_PersonalInfo.employee_id as 'ID'
	From Employee_PersonalInfo
END
-- ==========================================LoadByID===================================================
GO
/****** Object:  StoredProcedure [dbo].[Employee_PersonalInfoGetidbyName]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Employee_PersonalInfoGetidbyName]
(
	@firstname varchar(max)
)	
AS
BEGIN
	SELECT DISTINCT
	Employee_PersonalInfo.employee_id as 'ID'
	From Employee_PersonalInfo WHERE firstname=@firstname
END
-- ==========================================LoadByID===================================================
GO
/****** Object:  StoredProcedure [dbo].[Employee_PersonalInfoInsert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Employee_PersonalInfoInsert]
(
	@firstname varchar(50),
	@lastname varchar(50),
	@registration varchar(100),
	@dob date,
	@phone varchar(MAX),
	@email  varchar(50),
	--@Martial_status	varchar(MAX)	,
	--@Refrence	varchar(MAX)	,
	--@Parent_CNIC	varchar(MAX)	,
	@CNIC	varchar(MAX)	,
	@country_id  UNIQUEIDENTIFIER,
	@state_id  UNIQUEIDENTIFIER,
	@city_id  UNIQUEIDENTIFIER,
	@area_id  UNIQUEIDENTIFIER,

	@Organization_id UNIQUEIDENTIFIER,
	@Branch_id UNIQUEIDENTIFIER ,
	@dept_id  UNIQUEIDENTIFIER,
	@office_id  UNIQUEIDENTIFIER,
	@section_id  UNIQUEIDENTIFIER,
 
	@attendance_type varchar(50),
		@address_type  varchar(50),
	@address1  varchar(50),
	@address2  varchar(50)
	
--	@img varchar(max)
	
) 
	
AS
BEGIN
	INSERT INTO Employee_PersonalInfo 
	(
	firstname,
	lastname,
	registration,
	dob,
	phone,
	email,
--Martial_status	,
	--Refrence	,
	--Parent_CNIC	,
	CNIC	,
	country_id,
	state_id,
	city_id,
	area_id,
	Organization_id,
	Branch_id,
	dept_id,
	office_id,
	section_id,
 	attendance_type,
	address_type,
	address1,
	address2)
	VALUES(
	@firstname,
	@lastname,
	@registration,
	@dob,
	@phone,
	@email,
--Martial_status	,
	--Refrence	,
	--Parent_CNIC	,
	@CNIC	,
	@country_id,
	@state_id,
	@city_id,
	@area_id,
	@Organization_id,
	@Branch_id,
	@dept_id,
	@office_id,
	@section_id,
 	@attendance_type,
	@address_type,
	@address1,
	@address2)
END
-- ========================================uPDATE====================================================
GO
/****** Object:  StoredProcedure [dbo].[Employee_PersonalInfoLoadALL]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Employee_PersonalInfoLoadALL]	
AS
BEGIN
	SELECT  * FROM dbo.Employee_PersonalInfo;
 
END
-- ==========================================LoadByID===================================================
GO
/****** Object:  StoredProcedure [dbo].[Employee_PersonalInfoLoadbyDept]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Employee_PersonalInfoLoadbyDept]	
(
	@dept_id UNIQUEIDENTIFIER
)
AS
BEGIN
	SELECT 
	Employee_PersonalInfo.employee_id as 'emp_id',
	Employee_PersonalInfo.firstname as 'Employee Name',
	--Employee_PersonalInfo.date_of_join as 'Date of join',
	(SELECT designation FROM Employee_CompanyInfo 	WHERE employee_id=Employee_PersonalInfo.employee_id)
	as 'Designation'
	From Employee_PersonalInfo
	 --JOIN Employee_CompanyInfo ON Employee_CompanyInfo.employeeCompany_id=Employee_PersonalInfo.employeeCompany_id
	WHERE dept_id=@dept_id
END
-- ===========================================Delete=================================================
GO
/****** Object:  StoredProcedure [dbo].[Employee_PersonalInfoLoadbyID]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Employee_PersonalInfoLoadbyID]	
(
	@employee_id UNIQUEIDENTIFIER
)
AS
BEGIN
	SELECT 
	 * FROM  dbo.Employee_PersonalInfo
	WHERE employee_id=@employee_id
END
-- ===========================================Delete=================================================
GO
/****** Object:  StoredProcedure [dbo].[Employee_PersonalInfoLoadbyOffice]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Employee_PersonalInfoLoadbyOffice]	
(
	@office_id UNIQUEIDENTIFIER
)
AS
BEGIN
	SELECT 
	Employee_PersonalInfo.employee_id as 'emp_id',
	Employee_PersonalInfo.firstname as 'Employee Name',
	--Employee_PersonalInfo.date_of_join as 'Date of join',
	(SELECT designation FROM Employee_CompanyInfo 	WHERE employee_id=Employee_PersonalInfo.employee_id)
	as 'Designation'
	From Employee_PersonalInfo
	 --JOIN Employee_CompanyInfo ON Employee_CompanyInfo.employeeCompany_id=Employee_PersonalInfo.employeeCompany_id
	WHERE office_id=@office_id
END
-- ===========================================Delete=================================================
GO
/****** Object:  StoredProcedure [dbo].[Employee_PersonalInfoLoadByRegistration]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Employee_PersonalInfoLoadByRegistration]	
(
	@registration varchar(max)
)
AS
BEGIN
	SELECT 
	Employee_PersonalInfo.firstname as 'FirstName',
	Employee_PersonalInfo.lastname as 'Lastname',
	Employee_PersonalInfo.dob as 'Date-of-Birth',
	Employee_PersonalInfo.phone as 'Phone',
	Employee_PersonalInfo.email as 'Email',
---	Employee_PersonalInfo.Martial_status as 'Martial Status',
---	Employee_PersonalInfo.Refrence as 'Refrence',
--	Employee_PersonalInfo.Parent_CNIC as 'Parent CNIC',
	Employee_PersonalInfo.CNIC as 'CNIC',
	CountryEMP.name as 'Country',
	State.name as 'State',
	City.name as 'City',
	Area.name as 'Area',
	Employee_PersonalInfo.address_type as 'Address Type',
	Employee_PersonalInfo.address1 as 'Address1',
	Employee_PersonalInfo.address2 as 'Address2',
	Department.name as 'Department',
	Office.name as 'Office',
	SectionEMP.name as 'Section',
	Employee_PersonalInfo.date_of_join as 'Date of join',
	Employee_PersonalInfo.attendance_type as 'Attendance Type',
	Employee_PersonalInfo.employee_id as 'ID'
	--Employee_PersonalInfo.img as 'Image'
	From Employee_PersonalInfo
	LEFT JOIN CountryEMP ON CountryEMP.country_id=Employee_PersonalInfo.country_id
	LEFT JOIN State ON State.state_id=Employee_PersonalInfo.state_id
	LEFT JOIN City ON City.city_id=Employee_PersonalInfo.city_id
	LEFT Join Area ON Area.area_id=Employee_PersonalInfo.area_id
	LEFT JOIN Department ON Department.dept_id=Employee_PersonalInfo.dept_id
	LEFT JOIN Office ON Office.office_id=Employee_PersonalInfo.office_id
	LEFT JOIN SectionEMP ON SectionEMP.section_id=Employee_PersonalInfo.section_id
	WHERE registration = @registration
END
-- ===========================================Delete=================================================
GO
/****** Object:  StoredProcedure [dbo].[Employee_PersonalInfoUpdate]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Employee_PersonalInfoUpdate]
(
	@firstname varchar(50),
	@lastname varchar(50),
	@registration varchar(100),
	@dob date,
	@phone varchar(MAX),
	@email  varchar(50),
--	@Martial_status	varchar(MAX)	,
--	@Refrence	varchar(MAX)	,
--	@Parent_CNIC	varchar(MAX)	,
	@CNIC	varchar(MAX)	,
	@country_id UNIQUEIDENTIFIER,
	@state_id UNIQUEIDENTIFIER,
	@city_id UNIQUEIDENTIFIER,
	@area_id UNIQUEIDENTIFIER,
	@address_type  varchar(50),
	@address1  varchar(50),
	@address2  varchar(50),
	@Organization_id UNIQUEIDENTIFIER,
	@Branch_id UNIQUEIDENTIFIER,
	@dept_id UNIQUEIDENTIFIER,
	@office_id UNIQUEIDENTIFIER,
	@section_id UNIQUEIDENTIFIER,
	 
	@attendance_type varchar(50),
	@employee_id UNIQUEIDENTIFIER
--	@img varchar(max)
) 
	
AS
BEGIN
	UPDATE Employee_PersonalInfo 
	SET 
	firstname=@firstname,
	lastname=@lastname,
	registration=@registration,
	dob=@dob,
	phone=@phone,
	email=@email,
--	Martial_status=@Martial_status		,
--	Refrence=@Refrence		,
--	Parent_CNIC=@Parent_CNIC		,
	CNIC=@CNIC		,
	country_id=@country_id,
	state_id=@state_id,
	city_id=@city_id,
	area_id=@area_id,
	address_type=@address_type,
	address1=@address1,
	address2=@address2,
	dept_id=@dept_id,
	office_id=@office_id,
	section_id=@section_id,
 	attendance_type=@attendance_type,
 	Organization_id  = @Organization_id,
	Branch_id = @Branch_id
--	img=@img
	WHERE employee_id=@employee_id
	
END
-- ==========================================LoadALL==================================================
GO
/****** Object:  StoredProcedure [dbo].[Employee_Search]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Employee_Search]
(
	@firstname varchar(50),
	@lastname varchar(50),
	@dob date,
	@phone varchar(50),
	@email  varchar(50),
	--@Martial_status	varchar(MAX)	,
	--@Refrence	varchar(MAX)	,
	--@Parent_CNIC	varchar(MAX)	,
	@CNIC	varchar(MAX)	,	
	@address_type  varchar(50),
	@address1  varchar(50),
	@address2  varchar(50),	
	@date_of_join date,
	@attendance_type varchar(50)
)
AS
BEGIN
SELECT 
	Employee_PersonalInfo.firstname as 'FirstName',
	Employee_PersonalInfo.lastname as 'Lastname',
	Employee_PersonalInfo.dob as 'Date-of-Birth',
	Employee_PersonalInfo.registration as 'Registration',
	Employee_PersonalInfo.phone as 'Phone',
	Employee_PersonalInfo.email as 'Email',
---	Employee_PersonalInfo.Martial_status as 'Martial Status',
---	Employee_PersonalInfo.Refrence as 'Refrence',
---	Employee_PersonalInfo.Parent_CNIC as 'Parent CNIC',
	Employee_PersonalInfo.CNIC as 'CNIC',
	CountryEMP.name as 'Country',
	State.name as 'State',
	City.name as 'City',
	Area.name as 'Area',
	Employee_PersonalInfo.address_type as 'Address Type',
	Employee_PersonalInfo.address1 as 'Address1',
	Employee_PersonalInfo.address2 as 'Address2',
	Department.name as 'Department',
	Office.name as 'Office',
	SectionEMP.name as 'Section',
	Employee_PersonalInfo.date_of_join as 'Date of join',
	Employee_PersonalInfo.attendance_type as 'Attendance Type',
	Employee_PersonalInfo.employee_id as 'ID'
	--Employee_PersonalInfo.img as 'Image'
	From Employee_PersonalInfo
	LEFT JOIN CountryEMP ON CountryEMP.country_id=Employee_PersonalInfo.country_id
	LEFT JOIN State ON State.state_id=Employee_PersonalInfo.state_id
	LEFT JOIN City ON City.city_id=Employee_PersonalInfo.city_id
	LEFT Join Area ON Area.area_id=Employee_PersonalInfo.area_id
	LEFT JOIN Department ON Department.dept_id=Employee_PersonalInfo.dept_id
	LEFT JOIN Office ON Office.office_id=Employee_PersonalInfo.office_id
	LEFT JOIN SectionEMP ON SectionEMP.section_id=Employee_PersonalInfo.section_id
WHERE    (firstname IS NULL OR firstname LIKE '%' + @firstname + '%')
	 
      OR (@lastname IS NULL OR lastname LIKE '%' + @lastname + '%')
      --OR (@dob IS NULL OR dob LIKE '%' + @dob + '%')
      OR (@phone IS NULL OR phone LIKE '%' + @phone + '%')
      OR (@email IS NULL OR email LIKE '%' + @email + '%')
      
       
      OR (@CNIC IS NULL OR CNIC LIKE '%' + @CNIC + '%')     
     
      
     -- AND (@address_type IS NULL OR address_type LIKE '%' + @address_type + '%')
      OR (@address1 IS NULL OR address1 LIKE '%' + @address1 + '%')
      --OR (@date_of_join IS NULL OR date_of_join LIKE '%' + @date_of_join + '%')
     -- AND (@attendance_type IS NULL OR attendance_type LIKE '%' + @attendance_type + '%')
      
END
GO
/****** Object:  StoredProcedure [dbo].[Enrollment]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[Enrollment]
@StudentID varchar(50)=null
AS
BEGIN
	
	SET NOCOUNT ON;
	update Downloads set EnrollmentStatus ='Enrolled'
	where StudentID=@StudentID
END
GO
/****** Object:  StoredProcedure [dbo].[getMedicineInvoiceInfo1]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[getMedicineInvoiceInfo1]
(
@medicine_id uniqueidentifier
)
AS
BEGIN
SELECT

 Party.name as 'PartyName'
,Party.phone as 'PartyPhone'
,Party.address as 'PartyAddress'
,Medicine.name as 'Name'
,party_invoice_medicine.packprice as 'Price'
,party_invoice_medicine.quantity as 'Qty'
,party_invoice_medicine.discount_percentage as 'Discount'
,party_invoice_medicine.discount_amount as 'DiscountAmount'
,party_invoice_medicine.tax_percentage as 'Tax'
,party_invoice_medicine.tax_amount as 'TaxAmount'
,party_invoice_medicine.net_amount as 'NetAmount'
,party_invoice_medicine.party_invoice_id as 'InvoiceNumber'

FROM party_invoice_medicine

INNER JOIN party_invoice on party_invoice.party_invoice_id = party_invoice_medicine.party_invoice_id
INNER JOIN Party on party_invoice.p_id = party.p_id
INNER JOIN Medicine on Medicine.Medicine_id = party_invoice_medicine.medicine_id

WHERE medicine.Medicine_id = @medicine_id

END
GO
/****** Object:  StoredProcedure [dbo].[getMedicineInvoiceInfoBeforeDate]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[getMedicineInvoiceInfoBeforeDate]
(
@medicine_id uniqueidentifier,
@Date DATETIME
)

AS
BEGIN
SELECT  

 Party.name as 'PartyName'
,Party.phone as 'PartyPhone'
,Party.address as 'PartyAddress'
,Medicine.name as 'Name'
,party_invoice_medicine.packprice as 'Price'
,party_invoice_medicine.quantity as 'Qty'
,party_invoice_medicine.discount_percentage as 'Discount'
,party_invoice_medicine.discount_amount as 'DiscountAmount'
,party_invoice_medicine.tax_percentage as 'Tax'
,party_invoice_medicine.tax_amount as 'TaxAmount'
,party_invoice_medicine.net_amount as 'NetAmount'
,party_invoice_medicine.party_invoice_id as 'InvoiceNumber'

FROM party_invoice_medicine

INNER JOIN party_invoice on party_invoice.party_invoice_id = party_invoice_medicine.party_invoice_id
INNER JOIN Party on party_invoice.p_id = party.p_id
INNER JOIN Medicine on Medicine.Medicine_id = party_invoice_medicine.medicine_id

WHERE medicine.Medicine_id = @medicine_id
  AND MONTH(dbo.party_invoice.date) <= MONTH(@Date)
  AND  YEAR(dbo.party_invoice.date) <=  YEAR(@Date) 
END
GO
/****** Object:  StoredProcedure [dbo].[getMedicinePatientPrescriptionInfo]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[getMedicinePatientPrescriptionInfo]
(
@medicine_id uniqueidentifier
)

AS
BEGIN

SELECT dbo.patient_basic.patient_name,patient_basic.patient_record_no,dbo.patient_prescription.assigned_Date,dbo.patient_prescription_mdeicine.quantity FROM
dbo.patient_prescription

INNER JOIN dbo.patient_basic ON patient_basic.patient_id = patient_prescription.patient_id
INNER JOIN dbo.patient_prescription_mdeicine ON patient_prescription_mdeicine.patient_prescription_id = patient_prescription.patient_prescription_id

WHERE dbo.patient_prescription_mdeicine.medicine_id = @medicine_id
END
GO
/****** Object:  StoredProcedure [dbo].[getMedicinePatientPrescriptionInfoBeforeDate]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[getMedicinePatientPrescriptionInfoBeforeDate]
(
@medicine_id uniqueidentifier,
@Date datetime
)

AS
BEGIN

SELECT dbo.patient_basic.patient_name,patient_basic.patient_record_no,dbo.patient_prescription.assigned_Date,dbo.patient_prescription_mdeicine.quantity FROM
dbo.patient_prescription

INNER JOIN dbo.patient_basic ON patient_basic.patient_id = patient_prescription.patient_id
INNER JOIN dbo.patient_prescription_mdeicine ON patient_prescription_mdeicine.patient_prescription_id = patient_prescription.patient_prescription_id

WHERE dbo.patient_prescription_mdeicine.medicine_id = @medicine_id

	  AND  MONTH(patient_prescription.assigned_Date) <= MONTH(@Date)
	  AND  YEAR(patient_prescription.assigned_Date)  <=  YEAR(@Date)
	  AND  DAY(patient_prescription.assigned_Date)   <=  DAY(@Date)
END
GO
/****** Object:  StoredProcedure [dbo].[getMedicinePatientPrescriptionInfoBetweenDate]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[getMedicinePatientPrescriptionInfoBetweenDate]
(
@medicine_id uniqueidentifier,
@Date datetime
)

AS
BEGIN

SELECT dbo.patient_basic.patient_name,patient_basic.patient_record_no,dbo.patient_prescription.assigned_Date,dbo.patient_prescription_mdeicine.quantity FROM
dbo.patient_prescription

INNER JOIN dbo.patient_basic ON patient_basic.patient_id = patient_prescription.patient_id
INNER JOIN dbo.patient_prescription_mdeicine ON patient_prescription_mdeicine.patient_prescription_id = patient_prescription.patient_prescription_id

WHERE dbo.patient_prescription_mdeicine.medicine_id = @medicine_id

	  AND  MONTH(patient_prescription.assigned_Date) <= MONTH(@Date)
	  AND  YEAR(patient_prescription.assigned_Date)  <=  YEAR(@Date)
	  AND  DAY(patient_prescription.assigned_Date)   <=  DAY(@Date)
END
GO
/****** Object:  StoredProcedure [dbo].[Global_attendanceDelete]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Global_attendanceDelete]	
(
	@ga_id int
)
AS
BEGIN
	Delete From Global_attendance WHERE ga_id=@ga_id
END
GO
/****** Object:  StoredProcedure [dbo].[Global_attendanceInsert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Global_attendanceInsert]
(
	@time_in datetime,
	@time_out datetime,
	@short_leave datetime,
	@grace_time datetime,
	@absent_after datetime,
	@break_start datetime,
	@break_end datetime,
	@local bit,
	@web bit,
	@add_by varchar(50),
	@add_date date
	
	
) 
	
AS
BEGIN
	INSERT INTO Global_attendance 
	(
		time_in ,
		time_out ,
		short_leave ,
		grace_time ,
		absent_after ,
		break_start ,
		break_end,
		local ,
		web,
		add_by,
		add_date
	)
	VALUES(
		@time_in ,
		@time_out ,
		@short_leave ,
		@grace_time ,
		@absent_after ,
		@break_start ,
		@break_end,
		@local ,
		@web,
		@add_by,
		@add_date
		)
		END
-- ========================================uPDATE====================================================
GO
/****** Object:  StoredProcedure [dbo].[Global_attendanceLoadALL]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Global_attendanceLoadALL]	
AS
BEGIN
	SELECT 
	time_in as 'Time in',
	time_out as 'Time Out',
	short_leave as 'Short Leave',
	grace_time as 'Grace Time',
	absent_after as 'Absent After',	
	break_start as 'Break Start',
	break_end as 'Break end',
	ga_id as 'ID'
	FROM Global_attendance
	
END
-- ==========================================LoadByID===================================================
GO
/****** Object:  StoredProcedure [dbo].[Global_attendanceLoadbyID]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Global_attendanceLoadbyID]	
(
	@ga_id int
)
AS
BEGIN
	SELECT 
	time_in as 'Time in',
	time_out as 'Time Out',
	short_leave as 'Short Leave',
	grace_time as 'Grace Time',
	absent_after as 'Absent After',	
	break_start as 'Break Start',
	break_end as 'Break end',
	ga_id as 'ID'
	FROM Global_attendance
	WHERE ga_id=@ga_id
END
-- ===========================================Delete=================================================
GO
/****** Object:  StoredProcedure [dbo].[Global_attendanceUpdate]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Global_attendanceUpdate]
(

	@time_in datetime,
	@time_out datetime,
	@short_leave datetime,
	@grace_time datetime,
	@absent_after datetime,
	@break_start datetime,
	@break_end datetime,
	@local bit,
	@web bit,
	@edit_by varchar(50),
	@edit_date date,
	@ga_id int
) 
	
AS
BEGIN
	UPDATE Global_attendance 
	SET 	
	time_in=@time_in,
	time_out=@time_out,
	short_leave=@short_leave,
	grace_time=@grace_time,
	absent_after=@absent_after,
	break_start=@break_start,
	break_end=@break_end,
	local=@local,
	web=@web,
	edit_by=@edit_by,
	edit_date=@edit_date
	

	WHERE ga_id=@ga_id
	
END
-- ==========================================LoadALL==================================================
GO
/****** Object:  StoredProcedure [dbo].[HCC_Balance_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[HCC_Balance_Insert]
(
@amount float,
@type nvarchar(50),
@date date,
@addate datetime, 
@flag int, 
@adby varchar(50)
)
AS
BEGIN

INSERT INTO [dbo].[HCC_Balance]
           (
           [amount]
           ,[type]
           ,[date]
           ,[AddDate]
		   ,[Addby]
		   ,[Flag])
     VALUES
           (
           @amount
           ,@type
           ,@date
           ,@addate
		   ,@adby
		   ,@flag
		   )

END
GO
/****** Object:  StoredProcedure [dbo].[HCC_Balance_LoadAll]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[HCC_Balance_LoadAll]

AS
BEGIN
SELECT * FROM [dbo].[HCC_Balance]
WHERE Flag = 1

END
GO
/****** Object:  StoredProcedure [dbo].[InsertAttendance]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertAttendance]
@StudentID varchar(50)  = '65',
@Attendance varchar(50) = '2',
@Messsage varchar(1000) = null,
@Timein varchar(100)    = '12:12am'
AS
BEGIN
	
	SET NOCOUNT ON;
	insert into Student_Attendence(Student_ID,TimeIn,Attendence,date,Status) Values(@StudentID,@TimeIn,@Attendance,GETDATE(),'NO')
	if(@Messsage is not Null)
	begin
    insert into OutBox(ContactNumber,Message)values((select ContactNumber from Downloads where StudentID=@StudentID),@Messsage)
    END
End
GO
/****** Object:  StoredProcedure [dbo].[InsertData_Issu_labels]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[InsertData_Issu_labels]
@iss_id uniqueidentifier, @lab_id uniqueidentifier, @addby varchar(50),@flag tinyint,@stat varchar(50) ,@tmp datetime

as
begin
Insert Into Issue_labels (Issue_id,label_id,addby,flag,status,timestamp)
Values(@iss_id,@lab_id,@addby,@flag,@stat,@tmp)
END
GO
/****** Object:  StoredProcedure [dbo].[Insertinto_OfficeTab]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure[dbo].[Insertinto_OfficeTab]

@dpt_id uniqueidentifier, @titl varchar(50),@desc varchar(50),@adby varchar(50),@stat varchar(20),@flg tinyint ,@tmp datetime
AS
BEGIN
INSERT INTO office_tab (dept_id,title,descrp,addby,status,flag,Date)
VALUES(@dpt_id,@titl,@desc,@adby,@stat,@flg,@tmp)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertIntoIssueTab]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[InsertIntoIssueTab]
@title varchar(50),@descrp varchar(50),@addby varchar(20),
@duedate datetime,@status varchar(50), @flag tinyint,@timestamp datetime, @lab_id uniqueidentifier
AS
BEGIN
Insert Into issue_tab (Title,descript,Addby,due_date,status,flag,timestampp,label_id)
values (@title,@descrp,@addby,@duedate,@status,@flag,@timestamp,@lab_id)
End
GO
/****** Object:  StoredProcedure [dbo].[InsertManualAttendance]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertManualAttendance]
@StudentID varchar(50)  = '65',
@Class varchar(50)  = null,
@Section varchar(50)  = null,
@Attendance varchar(50) = '2',
@Messsage varchar(1000) = null,
@Timein varchar(100)    = '12:12am',
@Date date = null
AS
BEGIN
	
	SET NOCOUNT ON;
IF NOT EXISTS(	select * from Student_Attendence WHERE Student_Attendence.Student_ID = @StudentID AND Student_Attendence.date = @Date)
  BEGIN

	insert into Student_Attendence(Student_ID,TimeIn,Attendence,date,Status,Class,Section) Values(@StudentID,@TimeIn,@Attendance,@Date,'NO',@Class,@Section)
	if(@Messsage is not Null)
	BEGIN
    insert into OutBox(ContactNumber,Message)values((select ContactNumber from Downloads where StudentID=@StudentID),@Messsage)
    END
  END
ELSE
   BEGIN

	UPDATE Student_Attendence SET 
	Student_ID = @StudentID,
	TimeIn = @Timein,
	Attendence=@Attendance,
	date=@Date,
	Status='NO',
	Class=@Class,
	Section=@Section

	WHERE Student_ID = @StudentID AND date = @Date

	IF (@Messsage is not Null)
	 BEGIN
    insert into OutBox(ContactNumber,Message)values((select ContactNumber from Downloads where StudentID=@StudentID),@Messsage)
     END
   END
END
GO
/****** Object:  StoredProcedure [dbo].[InsertManualTeacherAttandance]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[InsertManualTeacherAttandance]
@TeacherId varchar(50),
@TimeIn varchar(50),
@TimeOut varchar(50),
@Date varchar(50),
@LeftStatus varchar(50),
@Type varchar(50)
AS
BEGIN
	
	SET NOCOUNT ON;
	insert into Teacher_Attendance(Teacher_ID,TimeIn,TimeOut,Type,LeftStatuse,date) Values(@TeacherId,@TimeIn,@TimeOut,@Type,@LeftStatus,@Date)
END
GO
/****** Object:  StoredProcedure [dbo].[Issue_LoadByID]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[Issue_LoadByID]
(
@id uniqueidentifier
)
as
begin


SELECT Issue_id ,Title,descript ,status FROM Issue_tab where Issue_id = @id
end
GO
/****** Object:  StoredProcedure [dbo].[IssueClose]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[IssueClose]
as
begin
Select Title,descript  from Issue_tab where status  = 'Inactive';
end


GO
/****** Object:  StoredProcedure [dbo].[IssueOpen]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[IssueOpen]
as
begin
Select Issue_id,Title,descript from Issue_tab where status  = 'Active';
end
GO
/****** Object:  StoredProcedure [dbo].[JobstatusDelete]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[JobstatusDelete]	
(
	@jobstatus_id UNIQUEIDENTIFIER
)
AS
BEGIN
	Delete From Jobstatus WHERE jobstatus_id=@jobstatus_id
END
GO
/****** Object:  StoredProcedure [dbo].[JobstatusInsert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[JobstatusInsert]
(
	@name varchar(50),
	@shortname varchar(50),
	@desc varchar(50),
	@code varchar(50)
	
) 
	
AS
BEGIN
	INSERT INTO Jobstatus (name,shortname,[desc],code)
	VALUES(@name,@shortname,@desc,@code)
END
-- ========================================uPDATE====================================================
GO
/****** Object:  StoredProcedure [dbo].[JobstatusLoadALL]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[JobstatusLoadALL]	
AS
BEGIN
	Select Jobstatus.name as 'Name',
	Jobstatus.shortname as 'Short Name',
	Jobstatus.code as'Code', 
	Jobstatus.[desc] as 'Description' ,
	Jobstatus.jobstatus_id as 'ID'
	From Jobstatus
END
-- ==========================================LoadByID===================================================
GO
/****** Object:  StoredProcedure [dbo].[JobstatusLoadbyID]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[JobstatusLoadbyID]	
(
	@jobstatus_id UNIQUEIDENTIFIER
)
AS
BEGIN
	Select Jobstatus.name as 'Name',
	Jobstatus.shortname as 'Short Name',
	Jobstatus.code as'Code', 
	Jobstatus.[desc] as 'Description' ,
	Jobstatus.jobstatus_id as 'ID'
	From Jobstatus
	WHERE jobstatus_id=@jobstatus_id
END
-- ===========================================Delete=================================================
GO
/****** Object:  StoredProcedure [dbo].[JobstatusUpdate]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[JobstatusUpdate]
(
	@name varchar(50),
	@shortname varchar(50),
	@desc varchar(50),
	@code varchar(50),	
	@jobstatus_id UNIQUEIDENTIFIER
) 
	
AS
BEGIN
	UPDATE Jobstatus 
	SET 
	name=@name,
	shortname=@shortname,
	[desc]=@desc,
	code=@code
	WHERE jobstatus_id=@jobstatus_id
	
END
-- ==========================================LoadALL==================================================
GO
/****** Object:  StoredProcedure [dbo].[lab_Delete]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[lab_Delete]      (
@lab_id uniqueidentifier      )
AS
BEGIN
update [lab]
set flag = 0
WHERE   [lab_id]=@lab_id            
END
GO
/****** Object:  StoredProcedure [dbo].[lab_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[lab_Insert]      
(         @name varchar(max)  ,      @Type varchar(max),  @shortname varchar(max)  ,       
@code varchar(max)  ,       @desctiption varchar(max)  ,
@National_Tax_Number varchar(max)  ,       @Goods_And_Services_Tax varchar(max)  ,       @Guarranty varchar(max)  ,       
@Standard_Report_Number varchar(max)  ,       @phone varchar(max)  ,       @address varchar(max)  ,       
@email varchar(max)  ,       @Bank_account_number varchar(max)  ,       @International_Account_Number varchar(max)  ,       
@status bit  , @adby varchar(50), @addate datetime, @flag int )   
AS    
BEGIN         
INSERT INTO [lab](     [name],     [shortname],     [code],     [desctiption],    
[National_Tax_Number],     [Goods_And_Services_Tax],     [Guarranty],     [Standard_Report_Number],  
[phone],     [address],     [email],     [Bank_account_number],     [International_Account_Number], status , [Type],
[Addby],[AddDate],[Flag])          
Values(     @name,     @shortname,     @code,     @desctiption,     @National_Tax_Number,     @Goods_And_Services_Tax,    
@Guarranty,     @Standard_Report_Number,     @phone,     @address,     @email,     @Bank_account_number,    
@International_Account_Number, @status ,@Type  ,
@adby, @addate, @flag)       
END
GO
/****** Object:  StoredProcedure [dbo].[lab_invoice_Delete]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[lab_invoice_Delete]      (         @lab_invoice_id uniqueidentifier     )   
AS    
BEGIN         
update [lab_invoice]
set Flag = 0
WHERE   [lab_invoice_id]=@lab_invoice_id           
END
GO
/****** Object:  StoredProcedure [dbo].[lab_invoice_income_Delete]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE[dbo].[lab_invoice_income_Delete]      
(         @lab_invoice_income_id uniqueidentifier     )  
AS    BEGIN         
update [lab_invoice_income]
set Flag = 0
WHERE   [lab_invoice_income_id]=@lab_invoice_income_id           
END
GO
/****** Object:  StoredProcedure [dbo].[lab_invoice_income_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE[dbo].[lab_invoice_income_Insert]     
 (         
 @lab_test_id uniqueidentifier  ,       
 @patient_id uniqueidentifier  ,      
 @description varchar(max)  ,       
 @price int  ,       
 @discount float  ,    
 @discountAmt float  , 
 @welfarediscount int,    
 @nettotal int,
 @netAmount int  ,       
 @status bit ,
 @adby varchar (50), @addate datetime, 
 
 @flag int
 )   
 AS    
 BEGIN         
 INSERT INTO [lab_invoice_income]
 (     
 [lab_test_id],     
 [patient_id],     
 [description],     
 [price],     
 [discount], 
 [discountAmt],    
 [welfarediscount],
 [netAmount], 
 [nettotal],
 status ,
 [Date]  ,
 Addby,AddDate,Flag
 )          
 Values
 (     
 @lab_test_id,     
 @patient_id,     
 @description,     
 @price,     
 @discount, 
 @discountAmt ,  
 @welfarediscount, 
 @netAmount, 
 @nettotal,
 @status   ,
 GETDATE() ,@adby,@addate, @flag
 )       
 END
GO
/****** Object:  StoredProcedure [dbo].[lab_invoice_income_LOADALL]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  PROCEDURE[dbo].[lab_invoice_income_LOADALL]    AS    BEGIN    
SELECT * FROM [lab_invoice_income]     
WHERE Flag =1
END
GO
/****** Object:  StoredProcedure [dbo].[lab_invoice_income_LOADByID]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[lab_invoice_income_LOADByID]      
(         @lab_invoice_income_id uniqueidentifier      )   AS    BEGIN         
SELECT * FROM [lab_invoice_income] 
WHERE   [lab_invoice_income_id]=@lab_invoice_income_id   
AND Flag =1
END
GO
/****** Object:  StoredProcedure [dbo].[lab_invoice_income_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE[dbo].[lab_invoice_income_Update]
(        
@lab_invoice_income_id uniqueidentifier        ,     
@lab_test_id uniqueidentifier           ,   
@patient_id uniqueidentifier			   ,   
@description varchar(max)  ,
@price int				   ,    
@discount float			   ,
@discountAmt float		   , 
@welfarediscount int       ,
@nettotal      int         ,
@netAmount int			   ,   
@status bit				   ,
@Date datetime  ,

@editby varchar(50), @editdate datetime
)  
AS    BEGIN         
UPDATE [lab_invoice_income] 
SET   
   
[lab_test_id]=@lab_test_id,
[patient_id]=@patient_id,     
[description]=@description,     
[price]=@price,     
[discount]=@discount,  
[discountAmt]=@discountAmt ,
[welfarediscount]=@welfarediscount ,
[nettotal] = @nettotal,
[netAmount]=@netAmount, 
status=@status ,
Date = @Date  ,
Editby = @editby, EditDate = @editdate
WHERE   [lab_invoice_income_id]=@lab_invoice_income_id            

END
GO
/****** Object:  StoredProcedure [dbo].[lab_invoice_LOADALL]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[lab_invoice_LOADALL]    AS    BEGIN        
SELECT * FROM [lab_invoice]  
WHERE Flag =1

END
GO
/****** Object:  StoredProcedure [dbo].[lab_invoice_LOADByID]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[lab_invoice_LOADByID]    
(         @lab_invoice_id uniqueidentifier      )   AS    BEGIN        
SELECT * FROM [lab_invoice]  
WHERE   [lab_invoice_id]=@lab_invoice_id   
AND Flag =1
END
GO
/****** Object:  StoredProcedure [dbo].[lab_LOADALL]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[lab_LOADALL]   
AS    BEGIN      
SELECT * FROM [lab] 
WHERE Flag =1  
END
GO
/****** Object:  StoredProcedure [dbo].[lab_LOADByID]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[lab_LOADByID]   
(         @lab_id uniqueidentifier     )   AS    BEGIN        
SELECT * FROM [lab]   WHERE   [lab_id]=@lab_id   AND Flag = 1         END
GO
/****** Object:  StoredProcedure [dbo].[lab_test_Delete]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[lab_test_Delete]    
(         @lab_test_id uniqueidentifier     )   AS    BEGIN         
update [lab_test]
set Flag =0
WHERE   [lab_test_id]=@lab_test_id            END
GO
/****** Object:  StoredProcedure [dbo].[lab_test_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[lab_test_Insert]     
(         @lab_id uniqueidentifier ,       @test_id uniqueidentifier  , 
@name varchar(max)  ,       @price float  ,    
@status bit , @adby varchar(50), @addate datetime, @flag int   )  
AS    BEGIN      
INSERT INTO [lab_test](     [lab_id],     [test_id],
[name],     [price], status ,Addby, AddDate, Flag   )        
Values(     @lab_id,     @test_id,   
@name,     @price, @status,@adby, @addate, @flag
)     
END
GO
/****** Object:  StoredProcedure [dbo].[lab_test_LOADALL]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[lab_test_LOADALL]    AS    BEGIN         SELECT * FROM [lab_test]
WHERE Flag = 1
END
GO
/****** Object:  StoredProcedure [dbo].[lab_test_LOADByID]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[lab_test_LOADByID]     
(         @lab_test_id uniqueidentifier      )   AS    BEGIN        
SELECT * FROM [lab_test]   WHERE   [lab_test_id]=@lab_test_id        
AND Flag = 1
END
GO
/****** Object:  StoredProcedure [dbo].[lab_test_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[lab_test_Update]     
(         @lab_test_id uniqueidentifier  ,       @lab_id uniqueidentifier  ,       @test_id uniqueidentifier  ,       
@name varchar(max)  ,       @price float  ,       @status bit , @editby varchar(50), @editdate datetime   )  
AS    BEGIN         
UPDATE [lab_test] SET     
[lab_id]=@lab_id,     [test_id]=@test_id,     [name]=@name,    
[price]=@price, status=@status  , Editby= @editby, EditDate = @editdate    
WHERE   [lab_test_id]=@lab_test_id           
END
GO
/****** Object:  StoredProcedure [dbo].[lab_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[lab_Update]     
(         @lab_id uniqueidentifier  ,  @Type varchar(max),     @name varchar(max)  ,       
@shortname varchar(max)  ,       @code varchar(max)  ,       @desctiption varchar(max)  ,    
@National_Tax_Number varchar(max)  ,       @Goods_And_Services_Tax varchar(max)  ,     
@Guarranty varchar(max)  ,       @Standard_Report_Number varchar(max)  ,      
@phone varchar(max)  ,       @address varchar(max)  ,       @email varchar(max)  ,      
@Bank_account_number varchar(max)  ,       @International_Account_Number varchar(max)  
, @editby varchar(50), @editdate datetime )   
AS    BEGIN        
UPDATE [lab]
SET      [name]=@name,     [shortname]=@shortname,     [code]=@code,     
[desctiption]=@desctiption,     [National_Tax_Number]=@National_Tax_Number,  
[Type] =  @Type  ,  [Goods_And_Services_Tax]=@Goods_And_Services_Tax,    
[Guarranty]=@Guarranty,     [Standard_Report_Number]=@Standard_Report_Number,   
[phone]=@phone,     [address]=@address,     [email]=@email,     [Bank_account_number]=@Bank_account_number,   
[International_Account_Number]=@International_Account_Number, 
 Editby = @editby, EditDate = @editdate     
WHERE   [lab_id]=@lab_id           
END
GO
/****** Object:  StoredProcedure [dbo].[LoadAll_Closetab]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[LoadAll_Closetab]

as
begin


SELECT Issue_id ,Title,descript  FROM Issue_tab where status =  'close'
		AND dept_id = '2'
end
GO
/****** Object:  StoredProcedure [dbo].[LoadALL_Issues]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[LoadALL_Issues]
AS
BEGIN
Select*From Issue_tab where flag = 1
END
GO
/****** Object:  StoredProcedure [dbo].[LoadAll_Opentab]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[LoadAll_Opentab]

as
begin

SELECT Issue_id ,Title,descript  FROM Issue_tab where status =  'active'
		AND dept_id = '1'
end

GO
/****** Object:  StoredProcedure [dbo].[LoadAllBylabelid_Iss_labels]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[LoadAllBylabelid_Iss_labels]

as
begin
select * from Issue_labels 

end
GO
/****** Object:  StoredProcedure [dbo].[LoadAllDepts]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[LoadAllDepts]
AS
BEGIN
select*from Department_tab
END
GO
/****** Object:  StoredProcedure [dbo].[LoadAllOffices]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[LoadAllOffices]
AS
BEGIN
select*from office_tab
END
GO
/****** Object:  StoredProcedure [dbo].[LoadALLSubOffices]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[LoadALLSubOffices]
AS
BEGIN
SELECT*FROM Sub_Office_Table
END
GO
/****** Object:  StoredProcedure [dbo].[LoadByIssueID_Iss_labels]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[LoadByIssueID_Iss_labels]
@id uniqueidentifier

as
begin

SELECT Issue_labels.Issue_id,label_tab.name FROM Issue_labels
INNER JOIN label_tab on label_tab.label_id = Issue_labels.label_id
WHERE Issue_id = @id
end
GO
/****** Object:  StoredProcedure [dbo].[LOADBYLabelid_Iss_labels]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[LOADBYLabelid_Iss_labels]

as
begin
select label_id, name from label_tab 
end

GO
/****** Object:  StoredProcedure [dbo].[LoadComments]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[LoadComments] 
as
begin
select Comm_id,Issue_id , descript from Comment_tab
end
GO
/****** Object:  StoredProcedure [dbo].[LoadtAllFromIssu_DetailTab]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[LoadtAllFromIssu_DetailTab]
AS
BEGIN
Select*From Issue_detail_tab

END

GO
/****** Object:  StoredProcedure [dbo].[MatchLogin]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  procedure [dbo].[MatchLogin]
@Em varchar(100),
@password   nvarchar(4000)
as
begin
Select Users.User_id from Users Where  password = @password and(Email = @Em or User_name = @em)and Flag!=0
  
end
GO
/****** Object:  StoredProcedure [dbo].[Medicine_Category_Delete]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[Medicine_Category_Delete] 
( @Medicine_Category_id uniqueidentifier ) 
AS    BEGIN       
update [Medicine_Category]  
set Flag = 0
WHERE   [Medicine_Category_id]=@Medicine_Category_id   
END
GO
/****** Object:  StoredProcedure [dbo].[Medicine_Category_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[Medicine_Category_Insert]   
(         @name varchar(max)  ,       @shortname varchar(max)  ,  
@code varchar(max)  ,       @description varchar(max)  ,     
@addate DateTime ,        @adby varchar(max)  ,   @flag int  ,    
@status bit    )  
AS    BEGIN     
INSERT INTO [Medicine_Category](     [name],     [shortname],     [code],  
[description],     [AddDate],     [Addby],  Flag,status    )          
Values(     @name,     @shortname,     @code,     @description,    
@addate,     @adby, @flag ,  @status    )   
END
GO
/****** Object:  StoredProcedure [dbo].[Medicine_Category_LOADALL]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[Medicine_Category_LOADALL] 
AS    BEGIN     
SELECT * FROM [Medicine_Category] 
WHERE Flag = 1
END
GO
/****** Object:  StoredProcedure [dbo].[Medicine_Category_LOADByID]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[Medicine_Category_LOADByID]    
( @Medicine_Category_id uniqueidentifier)  
AS    BEGIN       
SELECT * FROM [Medicine_Category]  
WHERE   [Medicine_Category_id]=@Medicine_Category_id  
AND Flag = 1
END
GO
/****** Object:  StoredProcedure [dbo].[Medicine_Category_Search]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[Medicine_Category_Search]  
    (  
       @Medicine_Category_id uniqueidentifier  ,
       @name varchar(max)  ,
       @shortname varchar(max)  ,
       @code varchar(max)  ,
       @description varchar(max)  ,
       
       @status bit  
    ) 
  AS  
  BEGIN  
       SELECT * FROM [Medicine_Category]  
WHERE 
(Medicine_Category_id IS NULL OR Medicine_Category_id = @Medicine_Category_id )
 OR (name IS NULL OR name LIKE '%' + @name + '%')
 OR (shortname IS NULL OR shortname LIKE '%' + @shortname + '%')
 OR (code IS NULL OR code LIKE '%' + @code + '%')
 OR (description IS NULL OR description LIKE '%' + @description + '%')
 
     END
GO
/****** Object:  StoredProcedure [dbo].[Medicine_Category_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[Medicine_Category_Update]    
( @Medicine_Category_id uniqueidentifier  ,    @name varchar(max)  ,  
@shortname varchar(max)  ,    @code varchar(max)  ,      
@description varchar(max)  ,  @editdate DateTime  ,     
@editby varchar(max)     ) 
AS    BEGIN   
UPDATE [Medicine_Category]
SET      [name]=@name,     [shortname]=@shortname,     [code]=@code, 
[description]=@description,    
[EditDate]=@editdate,     [Editby]=@editby

WHERE   [Medicine_Category_id]=@Medicine_Category_id 
END
GO
/****** Object:  StoredProcedure [dbo].[Medicine_Delete]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[Medicine_Delete]     
(@Medicine_id uniqueidentifier)  
AS    BEGIN    
update [Medicine] 
set Flag = 0
WHERE   [Medicine_id]=@Medicine_id      
END
GO
/****** Object:  StoredProcedure [dbo].[Medicine_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[Medicine_Insert]     
	 (  @Medicine_Category_id uniqueidentifier  , 
	    @name varchar(max)  ,       @shortname varchar(max)  , 
	    @description varchar(max)  ,       @code varchar(max)  ,    
	    @company_name varchar(max)  ,       @formula_name varchar(max)  ,   
		@rs float  ,       @rm float  ,       @status bit  ,
		@qie float, @opn float,
		@InStock float, @adby varchar(50), @addate datetime, @flag int )   
AS    BEGIN 
INSERT INTO [Medicine]
(    [Medicine_Category_id],
     [name],[shortname],
     [description],[code],     [company_name],    
	 [formula_name],     [rs],     [rm], status , 
	 opened , quantityineach,InStock, Addby, AddDate, Flag )        
Values(     @Medicine_Category_id,     @name,     @shortname,     @description,     @code,  
@company_name,     @formula_name,     @rs,     @rm, @status  ,@opn,@qie,@InStock, @adby, @addate, @flag  ) 
END
GO
/****** Object:  StoredProcedure [dbo].[Medicine_LOADALL]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[Medicine_LOADALL]   
AS    BEGIN      
SELECT * FROM [Medicine] 
WHERE Flag = 1
ORDER BY Medicine.Medicine_Category_id ASC , Medicine.name ASC 
END
GO
/****** Object:  StoredProcedure [dbo].[Medicine_LOADByID]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[Medicine_LOADByID]     
(         @Medicine_id uniqueidentifier      )  
AS    BEGIN         
SELECT * FROM [Medicine]  
WHERE   [Medicine_id]=@Medicine_id 
AND Flag = 1
END
GO
/****** Object:  StoredProcedure [dbo].[Medicine_Search]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[Medicine_Search]  
    (  
       @Medicine_id uniqueidentifier  ,
       @Medicine_Category_id uniqueidentifier  ,
       @name varchar(max)  ,
       @shortname varchar(max)  ,
       @description varchar(max)  ,
       @code varchar(max)  ,
       @company_name varchar(max)  ,
       @formula_name varchar(max)  ,
       @rs int  ,
       @rm int  ,
       @status bit  
    ) 
  AS  
  BEGIN  
       SELECT * FROM [Medicine]  
WHERE 
(Medicine_id IS NULL OR Medicine_id = @Medicine_id )
 OR (Medicine_Category_id IS NULL OR Medicine_Category_id = @Medicine_Category_id )
 OR (name IS NULL OR name LIKE '%' + @name + '%')
 OR (shortname IS NULL OR shortname LIKE '%' + @shortname + '%')
 OR (description IS NULL OR description LIKE '%' + @description + '%')
 OR (code IS NULL OR code LIKE '%' + @code + '%')
 OR (company_name IS NULL OR company_name LIKE '%' + @company_name + '%')
 OR (formula_name IS NULL OR formula_name LIKE '%' + @formula_name + '%')
 OR (rs IS NULL OR rs LIKE '%' + @rs + '%')
 OR (rm IS NULL OR rm LIKE '%' + @rm + '%')
     END
GO
/****** Object:  StoredProcedure [dbo].[Medicine_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[Medicine_Update]     
(         @Medicine_id uniqueidentifier  ,       @Medicine_Category_id uniqueidentifier  ,     
@name varchar(max)  ,       @shortname varchar(max)  ,      
@description varchar(max)  ,       @code varchar(max)  ,       
@company_name varchar(max)  ,       @formula_name varchar(max)  ,   
@rs float  ,       @rm float  ,       @status bit  , @opn float,
@qie float ,@InStock bit, @editby varchar(50), @editdate datetime)  
AS    BEGIN      
UPDATE [Medicine]
SET      [Medicine_Category_id]=@Medicine_Category_id,    
[name]=@name,     [shortname]=@shortname,     [description]=@description,   
[code]=@code,     [company_name]=@company_name,     [formula_name]=@formula_name, 
[rs]=@rs,     [rm]=@rm, status=@status 
, quantityineach=@qie, opened=@opn , InStock=@InStock, Editby = @editby, EditDate = @editdate  
WHERE   [Medicine_id]=@Medicine_id          
END
GO
/****** Object:  StoredProcedure [dbo].[OfficeDelete]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[OfficeDelete]	
(
	@office_id UNIQUEIDENTIFIER
)
AS
BEGIN
	Delete From Office WHERE office_id=@office_id
END
GO
/****** Object:  StoredProcedure [dbo].[OfficeInsert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[OfficeInsert]
(
	@name varchar(50),
	@shortname varchar(50),
	@desc varchar(50),
	@code varchar(50),
	@dept_id UNIQUEIDENTIFIER,
	@time_in datetime,
	@time_out datetime,
	@short_leave datetime,
	@grace_time datetime,
	@absent_after datetime,
	@break_start datetime,
	@break_end datetime,
	@local bit,
	@web bit,
	@add_by varchar(50),
	@add_date date
) 
	
AS
BEGIN
	INSERT INTO Office (name,shortname,[desc],code,dept_id,
		time_in,
		time_out ,
		short_leave ,
		grace_time ,
		absent_after ,
		break_start ,
		break_end,
		local ,
		web,
		add_by,
		add_date)
	VALUES(@name,@shortname,@desc,@code,@dept_id,
		@time_in,
		@time_out ,
		@short_leave ,
		@grace_time ,
		@absent_after ,
		@break_start ,
		@break_end,
		@local ,
		@web,
		@add_by,
		@add_date)
END
-- ========================================uPDATE====================================================
GO
/****** Object:  StoredProcedure [dbo].[OfficeLoadALL]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[OfficeLoadALL]	
AS
BEGIN
	Select Office.name as 'Name',Office.shortname as 'Short Name',Office.code as'Code', Office.[desc] as 'Description',
	Department.name as 'Department',
	Office.time_in as 'Time in',
	Office.time_out as 'Time Out',
	Office.short_leave as 'Short Leave',
	Office.grace_time as 'Grace Time',
	Office.absent_after as 'Absent After',	
	Office.break_start as 'Break Start',
	Office.break_end as 'Break end',
	Office.office_id as 'ID'
	From Office
	JOIN Department ON Department.dept_id=Office.dept_id
END
-- ==========================================LoadByID===================================================
GO
/****** Object:  StoredProcedure [dbo].[OfficeLoadbyID]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[OfficeLoadbyID]	
(
	@dept_id UNIQUEIDENTIFIER
)
AS
BEGIN
		Select Office.name as 'Name',Office.shortname as 'Short Name',Office.code as'Code', Office.[desc] as 'Description',
	Department.name as 'Department',
	Office.time_in as 'Time in',
	Office.time_out as 'Time Out',
	Office.short_leave as 'Short Leave',
	Office.grace_time as 'Grace Time',
	Office.absent_after as 'Absent After',	
	Office.break_start as 'Break Start',
	Office.break_end as 'Break end',
	Office.office_id as 'ID'
	From Office
	JOIN Department ON Department.dept_id=Office.dept_id
	WHERE Office.dept_id=@dept_id
END
-- ===========================================Delete=================================================
GO
/****** Object:  StoredProcedure [dbo].[OfficeUpdate]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[OfficeUpdate]
(
	@name varchar(50),
	@shortname varchar(50),
	@desc varchar(50),
	@code varchar(50),
	@office_id UNIQUEIDENTIFIER,
	@dept_id UNIQUEIDENTIFIER,
	@time_in datetime,
	@time_out datetime,
	@short_leave datetime,
	@grace_time datetime,
	@absent_after datetime,
	@break_start datetime,
	@break_end datetime,
	@local bit,
	@web bit,
	@edit_by varchar(50),
	@edit_date date
) 
	
AS
BEGIN
	UPDATE Office 
	SET 
	name=@name,
	shortname=@shortname,
	[desc]=@desc,
	code=@code,
	dept_id=@dept_id,
	time_in=@time_in,
	time_out=@time_out,
	short_leave=@short_leave,
	grace_time=@grace_time,
	absent_after=@absent_after,
	break_start=@break_start,
	break_end=@break_end,
	local=@local,
	web=@web,
	edit_by=@edit_by,
	edit_date=@edit_date
	WHERE office_id=@office_id
	
END
-- ==========================================LoadALL==================================================
GO
/****** Object:  StoredProcedure [dbo].[Party_Delete]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[Party_Delete]     
(         @p_id uniqueidentifier     )  
AS    BEGIN       
update Party 
set Flag = 0
WHERE   [p_id]=@p_id          
END
GO
/****** Object:  StoredProcedure [dbo].[Party_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[Party_Insert]     
(         @name varchar(max)  ,       @shortname varchar(max)  ,      
@code varchar(max)  ,       @description varchar(max)  ,      
@add varchar(max)  ,       @National_Tax_Number varchar(max)  ,  
@Goods_And_Services_Tax varchar(max)  ,       @Guarranty varchar(max)  ,  
@Standard_Report_Number varchar(max)  ,       @phone varchar(max)  ,   
@address varchar(max)  ,       @email varchar(max)  ,      
@Bank_account_number varchar(max)  ,       @International_Account_Number varchar(max)  , 
@status bit  , @adby varchar(50), @addate datetime, @flag int  )
AS    BEGIN        
INSERT INTO Party(     [name],     [shortname],     [code],   
[description],     [add],     [National_Tax_Number],   
[Goods_And_Services_Tax],     [Guarranty],     [Standard_Report_Number], 
[phone],     [address],     [email],     [Bank_account_number], 
[International_Account_Number], status , [Addby] , [AddDate],[Flag]   )      
Values(     @name,     @shortname,     @code,     @description,     @add,  
@National_Tax_Number,     @Goods_And_Services_Tax,     @Guarranty,   
@Standard_Report_Number,     @phone,     @address,     @email,   
@Bank_account_number,     @International_Account_Number, @status,@adby, @addate,@flag    ) 
END
GO
/****** Object:  StoredProcedure [dbo].[party_invoice_Delete]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[party_invoice_Delete]     
(         @party_invoice_id uniqueidentifier      )  
AS    BEGIN        
update [party_invoice]  
set Flag = 0
WHERE   [party_invoice_id]=@party_invoice_id  
END
GO
/****** Object:  StoredProcedure [dbo].[party_invoice_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[party_invoice_Insert]    
(   @date datetime,      @entry_no varchar(50)  ,   
@customer_no int  ,       @p_id uniqueidentifier  ,       @status bit , @adby varchar(50),
@addate datetime, @flag int)  
AS    BEGIN       
INSERT INTO [party_invoice](     [entry_no],     [customer_no],
[p_id], status ,date , Addby, AddDate, Flag  )          
Values(     @entry_no,     @customer_no,     @p_id, @status   ,
@date , @adby, @addate, @flag) 
END
GO
/****** Object:  StoredProcedure [dbo].[party_invoice_LOADALL]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[party_invoice_LOADALL]  
AS    BEGIN        
SELECT * FROM [party_invoice] 
WHERE Flag = 1
END
GO
/****** Object:  StoredProcedure [dbo].[party_invoice_LOADByID]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[party_invoice_LOADByID]     
(         @party_invoice_id uniqueidentifier     )  
AS    BEGIN         
SELECT * FROM [party_invoice]   
WHERE   [party_invoice_id]=@party_invoice_id   
AND Flag = 1
END
GO
/****** Object:  StoredProcedure [dbo].[party_invoice_medicine_Delete]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[party_invoice_medicine_Delete]
(         @party_invoice_medicine_id uniqueidentifier      )
AS    BEGIN  
update [party_invoice_medicine] 
set Flag =0
WHERE   [party_invoice_medicine_id]=@party_invoice_medicine_id  
END
GO
/****** Object:  StoredProcedure [dbo].[party_invoice_medicine_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[party_invoice_medicine_Insert]      (    
     @medicine_id uniqueidentifier  ,       @description varchar(max)  ,   
	    @packprice float  ,     @price float  ,   
		@quantity float  ,       @discount_percentage float  ,   
		@discount_amount float  ,       @tax_percentage int  ,  
		@tax_amount float  ,       @net_amount float  ,     
		@party_invoice_id uniqueidentifier  ,       @Date DateTime ,   
		@status bit  , @adby varchar(50),
		@addate datetime, @flag int)  
		AS    BEGIN    
INSERT INTO [party_invoice_medicine](  
   [medicine_id],     [description],   [packprice],  [price],    
    [quantity],     [discount_percentage],     [discount_amount],    
	 [tax_percentage],     [tax_amount],     [net_amount],    
	  [party_invoice_id],     [Date], status , Addby, AddDate, Flag   )       
	     Values(     @medicine_id,     @description,  @packprice,  
		 @price,     @quantity,     @discount_percentage,     @discount_amount,  
		 @tax_percentage,     @tax_amount,     @net_amount,     @party_invoice_id, 
		 @Date, @status , @adby, @addate, @flag   )    
		 END
GO
/****** Object:  StoredProcedure [dbo].[party_invoice_medicine_LOADALL]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[party_invoice_medicine_LOADALL]  
AS    BEGIN    
SELECT * FROM [party_invoice_medicine] 
WHERE Flag = 1
END
GO
/****** Object:  StoredProcedure [dbo].[party_invoice_medicine_LOADByID]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[party_invoice_medicine_LOADByID]  
(         @party_invoice_medicine_id uniqueidentifier      )  
AS    BEGIN       
SELECT * FROM [party_invoice_medicine]   
WHERE   [party_invoice_medicine_id]=@party_invoice_medicine_id   
AND Flag = 1
END
GO
/****** Object:  StoredProcedure [dbo].[party_invoice_medicine_Search]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[party_invoice_medicine_Search]  
    (  
       @party_invoice_medicine_id uniqueidentifier  ,
       @medicine_id uniqueidentifier   ,  @packprice float  ,
       @description varchar(max)  ,
       @price float  ,
       @quantity float  ,
       @discount_percentage float  ,
       @discount_amount float  ,
       @tax_percentage int  ,
       @tax_amount float  ,
       @net_amount float  ,
       @party_invoice_id uniqueidentifier  ,
       @Date DateTime  ,
       @status bit  
    ) 
  AS  
  BEGIN  
       SELECT * FROM [party_invoice_medicine]  
WHERE 
(party_invoice_medicine_id IS NULL OR party_invoice_medicine_id = @party_invoice_medicine_id )
 OR (medicine_id IS NULL OR medicine_id = @medicine_id )
 OR (description IS NULL OR description LIKE '%' + @description + '%')
 OR (price IS NULL OR price LIKE '%' + @price + '%')
 OR (packprice IS NULL OR price LIKE '%' + @packprice + '%')
 OR (quantity IS NULL OR quantity LIKE '%' + @quantity + '%')
 OR (discount_percentage IS NULL OR discount_percentage LIKE '%' + @discount_percentage + '%')
 OR (discount_amount IS NULL OR discount_amount LIKE '%' + @discount_amount + '%')
 OR (tax_percentage IS NULL OR tax_percentage LIKE '%' + @tax_percentage + '%')
 OR (tax_amount IS NULL OR tax_amount LIKE '%' + @tax_amount + '%')
 OR (net_amount IS NULL OR net_amount LIKE '%' + @net_amount + '%')
 OR (party_invoice_id IS NULL OR party_invoice_id = @party_invoice_id )
 OR (Date IS NULL OR Date LIKE '%' + @Date + '%')
     END

GO
/****** Object:  StoredProcedure [dbo].[party_invoice_medicine_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[party_invoice_medicine_Update]     
 (         @party_invoice_medicine_id uniqueidentifier  ,    
    @medicine_id uniqueidentifier  ,   
	    @description varchar(max)  ,   
		@packprice float  ,  @price float  ,    
		@quantity float  ,       @discount_percentage float  , 
		@discount_amount float  ,       @tax_percentage int  ,    
		@tax_amount float  ,       @net_amount float  ,   
		@party_invoice_id uniqueidentifier  ,       @Date DateTime  , 
		@status bit , @editby varchar(50), @editdate datetime   )   
		AS    BEGIN     
		UPDATE [party_invoice_medicine] 
		SET      [medicine_id]=@medicine_id,     
		[description]=@description,  [packprice]=@packprice,    
		[price]=@price,     [quantity]=@quantity,    
		[discount_percentage]=@discount_percentage,     [discount_amount]=@discount_amount,    
		[tax_percentage]=@tax_percentage,     [tax_amount]=@tax_amount,    
		[net_amount]=@net_amount,     [party_invoice_id]=@party_invoice_id, 
		[Date]=@Date, status=@status , Editby = @editby, EditDate = @editdate     
		WHERE   [party_invoice_medicine_id]=@party_invoice_medicine_id   
		END
GO
/****** Object:  StoredProcedure [dbo].[party_invoice_product_Delete]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[party_invoice_product_Delete]
(         @party_invoice_product_id uniqueidentifier      )
AS    BEGIN  
update [party_invoice_product] 
set Flag =0
WHERE   [party_invoice_product_id]=@party_invoice_product_id  
END
GO
/****** Object:  StoredProcedure [dbo].[party_invoice_product_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[party_invoice_product_Insert]      (    
     @Pro_id uniqueidentifier  ,       @description varchar(max)  ,   
	    @packprice float  ,     @price float  ,   
		@quantity float  ,       @discount_percentage float  ,   
		@discount_amount float  ,       @tax_percentage int  ,  
		@tax_amount float  ,       @net_amount float  ,     
		@party_invoice_id uniqueidentifier  ,       @Date DateTime ,   
		@status bit  , @adby varchar(50),
		@addate datetime, @flag int)  
		AS    BEGIN    
INSERT INTO [party_invoice_product](  
   [Pro_id],     [description],   [packprice],  [price],    
    [quantity],     [discount_percentage],     [discount_amount],    
	 [tax_percentage],     [tax_amount],     [net_amount],    
	  [party_invoice_id],     [Date], status , Addby, AddDate, Flag   )       
	     Values(     @Pro_id,     @description,  @packprice,  
		 @price,     @quantity,     @discount_percentage,     @discount_amount,  
		 @tax_percentage,     @tax_amount,     @net_amount,     @party_invoice_id, 
		 @Date, @status , @adby, @addate, @flag   )    
		 END
GO
/****** Object:  StoredProcedure [dbo].[party_invoice_product_LOADALL]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[party_invoice_product_LOADALL]  
AS    BEGIN    
SELECT * FROM [party_invoice_product] 
WHERE Flag = 1
END
GO
/****** Object:  StoredProcedure [dbo].[party_invoice_product_LOADByID]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[party_invoice_product_LOADByID]  
(         @party_invoice_product_id uniqueidentifier      )  
AS    BEGIN       
SELECT * FROM [party_invoice_product]   
WHERE   [party_invoice_product_id]=@party_invoice_product_id   
AND Flag = 1
END
GO
/****** Object:  StoredProcedure [dbo].[party_invoice_product_Search]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[party_invoice_product_Search]  
    (  
       @party_invoice_product_id uniqueidentifier  ,
       @Pro_id uniqueidentifier   ,  @packprice float  ,
       @description varchar(max)  ,
       @price float  ,
       @quantity float  ,
       @discount_percentage float  ,
       @discount_amount float  ,
       @tax_percentage int  ,
       @tax_amount float  ,
       @net_amount float  ,
       @party_invoice_id uniqueidentifier  ,
       @Date DateTime  ,
       @status bit  
    ) 
  AS  
  BEGIN  
       SELECT * FROM [party_invoice_product]  
WHERE 
(party_invoice_product_id IS NULL OR party_invoice_product_id = @party_invoice_product_id )
 OR (Pro_id IS NULL OR Pro_id = @Pro_id )
 OR (description IS NULL OR description LIKE '%' + @description + '%')
 OR (price IS NULL OR price LIKE '%' + @price + '%')
 OR (packprice IS NULL OR price LIKE '%' + @packprice + '%')
 OR (quantity IS NULL OR quantity LIKE '%' + @quantity + '%')
 OR (discount_percentage IS NULL OR discount_percentage LIKE '%' + @discount_percentage + '%')
 OR (discount_amount IS NULL OR discount_amount LIKE '%' + @discount_amount + '%')
 OR (tax_percentage IS NULL OR tax_percentage LIKE '%' + @tax_percentage + '%')
 OR (tax_amount IS NULL OR tax_amount LIKE '%' + @tax_amount + '%')
 OR (net_amount IS NULL OR net_amount LIKE '%' + @net_amount + '%')
 OR (party_invoice_id IS NULL OR party_invoice_id = @party_invoice_id )
 OR (Date IS NULL OR Date LIKE '%' + @Date + '%')
     END

GO
/****** Object:  StoredProcedure [dbo].[party_invoice_product_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[party_invoice_product_Update]     
 (         @party_invoice_product_id uniqueidentifier  ,    
    @Pro_id uniqueidentifier  ,   
	    @description varchar(max)  ,   
		@packprice float  ,  @price float  ,    
		@quantity float  ,       @discount_percentage float  , 
		@discount_amount float  ,       @tax_percentage int  ,    
		@tax_amount float  ,       @net_amount float  ,   
		@party_invoice_id uniqueidentifier  ,       @Date DateTime  , 
		@status bit , @editby varchar(50), @editdate datetime   )   
		AS    BEGIN     
		UPDATE [party_invoice_product] 
		SET      [Pro_id]=@Pro_id,     
		[description]=@description,  [packprice]=@packprice,    
		[price]=@price,     [quantity]=@quantity,    
		[discount_percentage]=@discount_percentage,     [discount_amount]=@discount_amount,    
		[tax_percentage]=@tax_percentage,     [tax_amount]=@tax_amount,    
		[net_amount]=@net_amount,     [party_invoice_id]=@party_invoice_id, 
		[Date]=@Date, status=@status , Editby = @editby, EditDate = @editdate     
		WHERE   [party_invoice_product_id]=@party_invoice_product_id   
		END
GO
/****** Object:  StoredProcedure [dbo].[party_invoice_Search]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[party_invoice_Search]  
    (  
       @party_invoice_id uniqueidentifier  ,
       @entry_no int  ,
       @customer_no int  ,
       @p_id uniqueidentifier  ,
       @status bit  
    ) 
  AS  
  BEGIN  
       SELECT * FROM [party_invoice]  
WHERE 
(party_invoice_id IS NULL OR party_invoice_id = @party_invoice_id )
 OR (entry_no IS NULL OR entry_no LIKE '%' + @entry_no + '%')
 OR (customer_no IS NULL OR customer_no LIKE '%' + @customer_no + '%')
 OR (p_id IS NULL OR p_id = @p_id )
     END
GO
/****** Object:  StoredProcedure [dbo].[party_invoice_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[party_invoice_Update]  
(      @date datetime,   @party_invoice_id uniqueidentifier  ,    
@entry_no varchar(50)  ,       @customer_no int  ,   
@p_id uniqueidentifier  ,       @status bit ,
@editby varchar(50), @editdate datetime)  
AS    BEGIN       
UPDATE [party_invoice]
SET      [entry_no]=@entry_no,     [customer_no]=@customer_no,  
[p_id]=@p_id, status=@status  ,date = @date  ,
[Editby] = @editby, [Editdate] = @editdate 
WHERE   [party_invoice_id]=@party_invoice_id    
END
GO
/****** Object:  StoredProcedure [dbo].[Party_LOADALL]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[Party_LOADALL]   
AS    BEGIN        
SELECT * FROM Party      
Where Flag =1
END
GO
/****** Object:  StoredProcedure [dbo].[Party_LOADByID]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[Party_LOADByID]    
(         @p_id uniqueidentifier      )  
AS    BEGIN       
SELECT * FROM Party   
WHERE   [p_id]=@p_id 
AND Flag =1
END
GO
/****** Object:  StoredProcedure [dbo].[Party_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[Party_Update]    
(         @p_id uniqueidentifier  ,       @name varchar(max)  ,       @shortname varchar(max)  ,    
@code varchar(max)  ,       @description varchar(max)  ,       @add varchar(max)  ,  
@National_Tax_Number varchar(max)  ,       @Goods_And_Services_Tax varchar(max)  ,   
@Guarranty varchar(max)  ,       @Standard_Report_Number varchar(max)  ,   
@phone varchar(max)  ,       @address varchar(max)  ,       @email varchar(max)  ,   
@Bank_account_number varchar(max)  ,       @International_Account_Number varchar(max)  ,  
@status bit , @editby varchar(50), @editdate datetime   ) 
AS    BEGIN        
UPDATE Party SET      [name]=@name,     [shortname]=@shortname,    
[code]=@code,     [description]=@description,     [add]=@add,     
[National_Tax_Number]=@National_Tax_Number,     [Goods_And_Services_Tax]=@Goods_And_Services_Tax,  
[Guarranty]=@Guarranty,     [Standard_Report_Number]=@Standard_Report_Number, 
[phone]=@phone,     [address]=@address,     [email]=@email,   
[Bank_account_number]=@Bank_account_number,     [International_Account_Number]=@International_Account_Number,
status=@status , [Editby] = @editby , [EditDate]= @editdate     
WHERE   [p_id]=@p_id     
END
GO
/****** Object:  StoredProcedure [dbo].[patient_basic_Delete]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[patient_basic_Delete]      
(         @patient_id uniqueidentifier      )
AS    BEGIN        
update [patient_basic]   
set Flag =0
WHERE   [patient_id]=@patient_id     
END
GO
/****** Object:  StoredProcedure [dbo].[patient_basic_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[patient_basic_Insert]    
(      @patient_Age_month int,   @patient_name varchar(max)  ,      
@patient_gender varchar(max)  ,       @patient_Age int  ,  
@patient_Date_of_Birth DateTime ,        @patient_record_no varchar(max)  ,    
@adby varchar(max)  ,       @addate DateTime ,  @flag int  ,      
      @status bit    )  
AS    BEGIN       
INSERT INTO [patient_basic](     [patient_name],     [patient_gender], 
[patient_Age],     [patient_Date_of_Birth],     [patient_record_no],   
[Addby],     [AddDate],[Flag]   , 
status ,[patient_Age_month]   )   
Values(     @patient_name,     @patient_gender,     @patient_Age,   
@patient_Date_of_Birth,     @patient_record_no,     @adby,   
@addate,  @flag,  @status   ,@patient_Age_month )     
END
GO
/****** Object:  StoredProcedure [dbo].[patient_basic_LOADALL]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[patient_basic_LOADALL]  
AS    BEGIN      
SELECT * FROM [patient_basic]  
WHERE Flag = 1 
order by patient_record_no  

END



GO
/****** Object:  StoredProcedure [dbo].[patient_basic_LOADByID]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[patient_basic_LOADByID]   
(         @patient_id uniqueidentifier     ) 
AS    BEGIN        
SELECT * FROM [patient_basic]  
WHERE   [patient_id]=@patient_id        
AND Flag =1
END



GO
/****** Object:  StoredProcedure [dbo].[patient_basic_Search]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[patient_basic_Search]  
    (  
      
       @patient_name varchar(max)  ,
       @patient_record_no varchar(max)  
    ) 
  AS  
  BEGIN  
       SELECT *,'(' + patient_basic.patient_record_no +') '+patient_basic.patient_name  as concati FROM [patient_basic]  
WHERE 
  (patient_name IS NULL OR patient_name LIKE '%' + @patient_name + '%')
 
 OR (patient_record_no IS NULL OR patient_record_no LIKE '%' + @patient_record_no + '%')

 order by patient_record_no asc
 
     END
GO
/****** Object:  StoredProcedure [dbo].[patient_basic_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[patient_basic_Update]    
(         @patient_id uniqueidentifier  ,       @patient_name varchar(max)  ,   
@patient_gender varchar(max)  ,       @patient_Age int  ,     
@patient_Date_of_Birth DateTime  ,       @patient_record_no varchar(max)  , 
@editby varchar(max)  ,       @editdate DateTime  ,   
@status bit , @patient_Age_month int  ) 
AS    BEGIN      
UPDATE [patient_basic]
SET      [patient_name]=@patient_name,     [patient_gender]=@patient_gender,  
[patient_Age]=@patient_Age, [patient_Age_month]=@patient_Age_month, 
[patient_Date_of_Birth]=@patient_Date_of_Birth,     [patient_record_no]=@patient_record_no,   
[Editby]=@editby,
[EditDate]=@editdate, status=@status      
WHERE   [patient_id]=@patient_id          
END
GO
/****** Object:  StoredProcedure [dbo].[patient_contact_address_Delete]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[patient_contact_address_Delete]   
(         @patient_contact_address_id  uniqueidentifier     )   
AS    BEGIN      
update  [patient_contact_address]
set Flag =0
WHERE   [patient_contact_address_id]=@patient_contact_address_id    
END
GO
/****** Object:  StoredProcedure [dbo].[patient_contact_address_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[patient_contact_address_Insert]  
(         @patient_id uniqueidentifier  ,       @email varchar(max)  ,  
@home_phone varchar(max)  ,       @personal_phone varchar(max)  , 
@office_phone varchar(max)  ,       @first_address varchar(max)  , 
@second_address varchar(max)  ,       @country_id uniqueidentifier  , 
@state_id uniqueidentifier  ,       @city_id uniqueidentifier  ,       @area_id uniqueidentifier  ,    
@zipcode int  ,       @adby varchar(max)  ,       @addate DateTime ,   
@flag int ,      @status bit    )  
AS    BEGIN    
INSERT INTO [patient_contact_address](     [patient_id],     [email],    
[home_phone],     [personal_phone],     [office_phone],     [first_address],  
[second_address],     [country_id],     [state_id],     [city_id],     [area_id], 
[zipcode],     [Addby],     [AddDate],     
Flag ,status    )        
Values(     @patient_id,     @email,     @home_phone,     @personal_phone,     @office_phone,
@first_address,     @second_address,     @country_id,     @state_id,     @city_id,
@area_id,     @zipcode,     @adby,     @addate,     @flag,  @status    )     
END



GO
/****** Object:  StoredProcedure [dbo].[patient_contact_address_LOADALL]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[patient_contact_address_LOADALL]   
AS    BEGIN
SELECT * FROM [patient_contact_address]     
WHERE Flag = 1
END
GO
/****** Object:  StoredProcedure [dbo].[patient_contact_address_LOADByID]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[patient_contact_address_LOADByID]    
(         @patient_contact_address_id uniqueidentifier      )  
AS    BEGIN        
SELECT * FROM [patient_contact_address]  
WHERE   [patient_contact_address_id]=@patient_contact_address_id   
AND Flag = 1
END
GO
/****** Object:  StoredProcedure [dbo].[patient_contact_address_Search]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[patient_contact_address_Search]  
    (  
       @patient_contact_address_id uniqueidentifier  ,
       @patient_id uniqueidentifier  ,
       @email varchar(max)  ,
       @home_phone varchar(max)  ,
       @personal_phone varchar(max)  ,
       @office_phone varchar(max)  ,
       @first_address varchar(max)  ,
       @second_address varchar(max)  ,
       @country_id uniqueidentifier  ,
       @state_id uniqueidentifier  ,
       @city_id uniqueidentifier  ,
       @area_id uniqueidentifier  ,
       @zipcode int  ,
      
       @status bit  
    ) 
  AS  
  BEGIN  
       SELECT * FROM [patient_contact_address]  
WHERE 
(patient_contact_address_id IS NULL OR patient_contact_address_id = @patient_contact_address_id)
 OR (patient_id IS NULL OR patient_id = @patient_id)
 OR (email IS NULL OR email LIKE '%' + @email + '%')
 OR (home_phone IS NULL OR home_phone LIKE '%' + @home_phone + '%')
 OR (personal_phone IS NULL OR personal_phone LIKE '%' + @personal_phone + '%')
 OR (office_phone IS NULL OR office_phone LIKE '%' + @office_phone + '%')
 OR (first_address IS NULL OR first_address LIKE '%' + @first_address + '%')
 OR (second_address IS NULL OR second_address LIKE '%' + @second_address + '%')
 OR (country_id IS NULL OR country_id = @country_id )
 OR (state_id IS NULL OR state_id = @state_id )
 OR (city_id IS NULL OR city_id = @city_id )
 OR (area_id IS NULL OR area_id = @area_id )
 OR (zipcode IS NULL OR zipcode LIKE '%' + @zipcode + '%')

     END
GO
/****** Object:  StoredProcedure [dbo].[patient_contact_address_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[patient_contact_address_Update]    
(         @patient_contact_address_id uniqueidentifier  ,       @patient_id uniqueidentifier  ,    
@email varchar(max)  ,       @home_phone varchar(max)  ,    
@personal_phone varchar(max)  ,       @office_phone varchar(max)  ,     
@first_address varchar(max)  ,       @second_address varchar(max)  ,    
@country_id uniqueidentifier  ,       @state_id uniqueidentifier  ,      
@city_id uniqueidentifier  ,       @area_id uniqueidentifier  ,      
@zipcode int  ,           @editby varchar(max)  ,       @editdate datetime  ,    
@status bit    )   
AS    BEGIN  
UPDATE [patient_contact_address] 
SET      [patient_id]=@patient_id,     [email]=@email,     
[home_phone]=@home_phone,     [personal_phone]=@personal_phone,   
[office_phone]=@office_phone,     [first_address]=@first_address,    
[second_address]=@second_address,     [country_id]=@country_id,   
[state_id]=@state_id,     [city_id]=@city_id,     [area_id]=@area_id,   
[zipcode]=@zipcode,    [Editby]=@editby,     [EditDate]=@editdate, status=@status      
WHERE   [patient_contact_address_id]=@patient_contact_address_id         
END



GO
/****** Object:  StoredProcedure [dbo].[patient_Next_of_kin_Delete]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[patient_Next_of_kin_Delete]   
(         @patient_Next_of_kin_id uniqueidentifier      )  
AS    BEGIN       
update  [patient_Next_of_kin] 
set Flag =0
WHERE   [patient_Next_of_kin_id]=@patient_Next_of_kin_id     
END



GO
/****** Object:  StoredProcedure [dbo].[patient_Next_of_kin_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[patient_Next_of_kin_Insert]   
(         @patient_id uniqueidentifier  ,       @name varchar(max)  ,     
@relation_to_patient varchar(max)  ,       @phone_no varchar(max)  ,     
@first_address varchar(max)  ,       @second_address varchar(max)  ,       
@country_id uniqueidentifier  ,       @state_id uniqueidentifier  ,       
@city_id uniqueidentifier  ,       @area_id uniqueidentifier  ,      
@zipcode varchar(max)  ,       @addate DateTime ,        @adby varchar(max)  ,     
@editdate DateTime ,        @editby varchar(max)  ,       @status bit    ) 
AS    BEGIN         INSERT INTO [patient_Next_of_kin](     [patient_id],    
[name],     [relation_to_patient],     [phone_no],     [first_address],    
[second_address],     [country_id],     [state_id],     [city_id],    
[area_id],     [zipcode],     [AddDate],     [Addby],     [EditDate],   
[Editby], status    )         
Values(     @patient_id,     @name,   
@relation_to_patient,     @phone_no,     @first_address,     @second_address,  
@country_id,     @state_id,     @city_id,     @area_id,     @zipcode,  
@addate,     @adby,     @editdate,     @editby, @status    )   
END
GO
/****** Object:  StoredProcedure [dbo].[patient_Next_of_kin_LOADALL]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[patient_Next_of_kin_LOADALL]   
AS    BEGIN       
SELECT * FROM [patient_Next_of_kin]  
WHERE Flag = 1
END
GO
/****** Object:  StoredProcedure [dbo].[patient_Next_of_kin_LOADByID]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[patient_Next_of_kin_LOADByID] 
(         @patient_Next_of_kin_id uniqueidentifier     )  
AS    BEGIN         
SELECT * FROM [patient_Next_of_kin]  
WHERE   [patient_Next_of_kin_id]=@patient_Next_of_kin_id 
AND Flag = 1
END



GO
/****** Object:  StoredProcedure [dbo].[patient_Next_of_kin_Search]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[patient_Next_of_kin_Search]  
    (  
       @patient_Next_of_kin_id uniqueidentifier  ,
       @patient_id uniqueidentifier  ,
       @name varchar(max)  ,
       @relation_to_patient varchar(max)  ,
       @phone_no varchar(max)  ,
       @first_address varchar(max)  ,
       @second_address varchar(max)  ,
       @country_id uniqueidentifier  ,
       @state_id uniqueidentifier  ,
       @city_id uniqueidentifier  ,
       @area_id uniqueidentifier  ,
       @zipcode varchar(max)  ,
       @addate DateTime  ,
       @adby varchar(max)  ,
       @editdate DateTime  ,
       @editby varchar(max)  ,
       @status bit  
    ) 
  AS  
  BEGIN  
       SELECT * FROM [patient_Next_of_kin]  
WHERE 
(patient_Next_of_kin_id IS NULL OR patient_Next_of_kin_id = @patient_Next_of_kin_id )
 OR (patient_id IS NULL OR patient_id = @patient_id )
 OR (name IS NULL OR name LIKE '%' + @name + '%')
 OR (relation_to_patient IS NULL OR relation_to_patient LIKE '%' + @relation_to_patient + '%')
 OR (phone_no IS NULL OR phone_no LIKE '%' + @phone_no + '%')
 OR (first_address IS NULL OR first_address LIKE '%' + @first_address + '%')
 OR (second_address IS NULL OR second_address LIKE '%' + @second_address + '%')
 OR (country_id IS NULL OR country_id = @country_id )
 OR (state_id IS NULL OR state_id = @state_id )
 OR (city_id IS NULL OR city_id = @city_id )
 OR (area_id IS NULL OR area_id = @area_id )
 OR (zipcode IS NULL OR zipcode LIKE '%' + @zipcode + '%')
 OR (AddDate IS NULL OR AddDate LIKE '%' + @addate + '%')
 OR (Addby IS NULL OR Addby LIKE '%' + @adby + '%')
 OR (EditDate IS NULL OR EditDate LIKE '%' + @editdate + '%')
 OR (Editby IS NULL OR Editby LIKE '%' + @editby + '%')
     END
GO
/****** Object:  StoredProcedure [dbo].[patient_Next_of_kin_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[patient_Next_of_kin_Update]    
(         @patient_Next_of_kin_id uniqueidentifier  ,       @patient_id uniqueidentifier  ,  
@name varchar(max)  ,       @relation_to_patient varchar(max)  ,     
@phone_no varchar(max)  ,       @first_address varchar(max)  ,       
@second_address varchar(max)  ,       @country_id uniqueidentifier  ,       @state_id uniqueidentifier  , 
@city_id uniqueidentifier  ,       @area_id uniqueidentifier  ,       @zipcode varchar(max)  ,      
@addate DateTime  ,       @adby varchar(max)  ,       @editdate DateTime  ,  
@editby varchar(max)  ,       @status bit    ) 

AS    BEGIN       
UPDATE [patient_Next_of_kin] 
SET      [patient_id]=@patient_id,     [name]=@name,   
[relation_to_patient]=@relation_to_patient,     [phone_no]=@phone_no,   
[first_address]=@first_address,     [second_address]=@second_address,   
[country_id]=@country_id,     [state_id]=@state_id,     [city_id]=@city_id, 
[area_id]=@area_id,     [zipcode]=@zipcode,     [AddDate]=@addate,   
[Addby]=@adby,     [EditDate]=@editdate,     [Editby]=@editby, status=@status      
WHERE   [patient_Next_of_kin_id]=@patient_Next_of_kin_id            END



GO
/****** Object:  StoredProcedure [dbo].[patient_prescription_Delete]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[patient_prescription_Delete]   
(         @patient_prescription_id uniqueidentifier      )  
AS    BEGIN      
update [patient_prescription] 
set Flag = 0
WHERE   [patient_prescription_id]=@patient_prescription_id   
END
GO
/****** Object:  StoredProcedure [dbo].[patient_prescription_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[patient_prescription_Insert]     
(         @patient_id uniqueidentifier  ,       @assigned_Date DateTime ,     
@total_cost int  ,       @status bit  , 
@type varchar(50) , @adby varchar(50), @addate datetime, @flag int )  
AS    BEGIN        
INSERT INTO [patient_prescription](     [patient_id],     [assigned_Date],  
[total_cost], status ,[type]  , Addby, AddDate , Flag )         
Values(     @patient_id,     @assigned_Date,     @total_cost,
@status ,@type  , @adby, @addate, @flag )      
END
GO
/****** Object:  StoredProcedure [dbo].[patient_prescription_LabTest_Delete]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[patient_prescription_LabTest_Delete]     
(         @patient_prescription_LabTest_id uniqueidentifier      )  
AS    BEGIN       
update [patient_prescription_LabTest]   
Set Flag =0
WHERE   [patient_prescription_LabTest_id]=@patient_prescription_LabTest_id          
END
GO
/****** Object:  StoredProcedure [dbo].[patient_prescription_LabTest_LOADALL]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE[dbo].[patient_prescription_LabTest_LOADALL] 
AS    BEGIN 
SELECT * FROM [patient_prescription_LabTest]    
WHERE Flag = 1
END
GO
/****** Object:  StoredProcedure [dbo].[patient_prescription_LabTest_LOADByID]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[patient_prescription_LabTest_LOADByID]    
(         @patient_prescription_LabTest_id uniqueidentifier      )   
AS    BEGIN       
SELECT * FROM [patient_prescription_LabTest]   
WHERE   [patient_prescription_LabTest_id]=@patient_prescription_LabTest_id  
AND Flag = 1
END
GO
/****** Object:  StoredProcedure [dbo].[patient_prescription_LabTest_Search]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[patient_prescription_LabTest_Search]  
    (  
       @patient_prescription_LabTest_id uniqueidentifier  ,
       @patient_prescription_id uniqueidentifier  ,
       @lab_test_id uniqueidentifier  ,
       @price int  ,
       @discount int  ,
       @total_price int  ,
       @status bit  
    ) 
  AS  
  BEGIN  
       SELECT * FROM [patient_prescription_LabTest]  
WHERE 
(patient_prescription_LabTest_id IS NULL OR patient_prescription_LabTest_id = @patient_prescription_LabTest_id )
 OR (patient_prescription_id IS NULL OR patient_prescription_id = @patient_prescription_id )
 OR (lab_test_id IS NULL OR lab_test_id = @lab_test_id )
 OR (price IS NULL OR price LIKE '%' + @price + '%')
 OR (discount IS NULL OR discount LIKE '%' + @discount + '%')
 OR (total_price IS NULL OR total_price LIKE '%' + @total_price + '%')
     END
GO

SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE procedure [dbo].[sp_Tax_Update]
@id uniqueidentifier, @name varchar(50), 
@decrip varchar(50),@shtname varchar(50), 
@code varchar(50),@taxper varchar(50), 
@stats varchar(50),@editby varchar(50), 
@editdate datetime,@flg int
as
begin
Update Tax
set  Name= @name, Descrip=@decrip, ShortName=@shtname, 
Code= @code, TaxPercen= @taxper, Status= @stats, 
EditBy= @editby, EditDate= @editdate, Flag= @flg
where tax.TaxID=@id
end
GO

SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
Create Procedure [dbo].[sp_Tax_SelectAll]
as
begin
Select * from Tax 
where Flag = 1
end
GO

SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE Procedure [dbo].[sp_Tax_Insert] 
@name varchar(50), @decrip varchar(50),
@shtname varchar(50), @code varchar(50),
@taxper varchar(50), @stats varchar(50),
@tms datetime, @adby varchar(50),

@flg int
as
begin
insert into Tax(Name, Descrip, ShortName, Code, TaxPercen, Status, TimeStamp, AddBy,  Flag)
values (@name , @decrip ,
@shtname, @code ,
@taxper, @stats ,
@tms, @adby,
@flg )
end
GO

SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
Create procedure [dbo].[sp_Tax_Delete_by_id]
@id uniqueidentifier
as
begin
update Tax
set 
Flag = 0 where TaxID = @id;
end
GO

/****** Object:  StoredProcedure [dbo].[patient_prescription_LabTest_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[patient_prescription_LabTest_Update]    
(         @patient_prescription_LabTest_id uniqueidentifier  ,   
@patient_prescription_id uniqueidentifier ,       @lab_test_id uniqueidentifier  ,   
@price int  ,       @discount float  ,       @total_price float  ,   
@welfar_discount float  ,       @net_total float  ,      @status bit ,
@editby varchar(50), @editdate datetime)  
AS    BEGIN   
UPDATE [patient_prescription_LabTest] 
SET      [patient_prescription_id]=@patient_prescription_id,    
[lab_test_id]=@lab_test_id,     [price]=@price,     [discount]=@discount,    
[total_price]=@total_price, [welfare_discount]=@welfar_discount,    
[net_total]=@net_total, status=@status ,  
Editby = @editby , EditDate = @editdate
WHERE   [patient_prescription_LabTest_id]=@patient_prescription_LabTest_id    
END
GO
/****** Object:  StoredProcedure [dbo].[patient_prescription_LOADALL]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[patient_prescription_LOADALL]  
AS    BEGIN    
SELECT * FROM [patient_prescription] 
WHERE Flag = 1
END
GO
/****** Object:  StoredProcedure [dbo].[patient_prescription_LOADByID]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[patient_prescription_LOADByID] 
(         @patient_prescription_id uniqueidentifier     )  
AS    BEGIN        
SELECT * FROM [patient_prescription]  
WHERE   [patient_prescription_id]=@patient_prescription_id  
AND Flag =1
END
GO
/****** Object:  StoredProcedure [dbo].[patient_prescription_mdeicine_Delete]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[patient_prescription_mdeicine_Delete] 
(         @patient_prescription_mdeicine_id int      )  
AS    BEGIN       
update [patient_prescription_mdeicine]  
set Flag = 0
WHERE   [patient_prescription_mdeicine_id]=@patient_prescription_mdeicine_id 

END
GO
/****** Object:  StoredProcedure [dbo].[patient_prescription_mdeicine_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[patient_prescription_mdeicine_Insert] 
(  @pricing_id int,       @patient_prescription_id int  ,    
@medicine_id int  ,       @price int  ,       @quantity int  , 
@total_price int  ,       @status bit  , @adby varchar(50),
@addate datetime, @flag int)   
AS    BEGIN        
INSERT INTO [patient_prescription_mdeicine](     [patient_prescription_id],   
[medicine_id],     [price],     [quantity],     
[total_price], status ,pricing_id  , Addby, AddDate, Flag )          
Values(     @patient_prescription_id,     @medicine_id,    
@price,     @quantity,     @total_price, @status ,
@pricing_id , @adby, @addate, @flag  )    
END
GO
/****** Object:  StoredProcedure [dbo].[patient_prescription_mdeicine_LOADALL]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[patient_prescription_mdeicine_LOADALL]  
AS    BEGIN     
SELECT * FROM [patient_prescription_mdeicine] 
Where Flag = 1
END
GO
/****** Object:  StoredProcedure [dbo].[patient_prescription_mdeicine_LOADByID]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[patient_prescription_mdeicine_LOADByID]  
(         @patient_prescription_mdeicine_id uniqueidentifier      )  
AS    BEGIN        
SELECT * FROM [patient_prescription_mdeicine]  
WHERE   [patient_prescription_mdeicine_id]=@patient_prescription_mdeicine_id      
AND Flag = 1
END
GO
/****** Object:  StoredProcedure [dbo].[patient_prescription_mdeicine_Search]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[patient_prescription_mdeicine_Search]  
    (  
       @patient_prescription_mdeicine_id uniqueidentifier  ,
       @patient_prescription_id uniqueidentifier  ,
       @medicine_id uniqueidentifier  ,
       @price int  ,
       @quantity int  ,
       @total_price int  ,
       @status bit  
    ) 
  AS  
  BEGIN  
       SELECT * FROM [patient_prescription_mdeicine]  
WHERE 
(patient_prescription_mdeicine_id IS NULL OR patient_prescription_mdeicine_id LIKE '%' + @patient_prescription_mdeicine_id + '%')
 OR (patient_prescription_id IS NULL OR patient_prescription_id LIKE '%' + @patient_prescription_id + '%')
 OR (medicine_id IS NULL OR medicine_id LIKE '%' + @medicine_id + '%')
 OR (price IS NULL OR price LIKE '%' + @price + '%')
 OR (quantity IS NULL OR quantity LIKE '%' + @quantity + '%')
 OR (total_price IS NULL OR total_price LIKE '%' + @total_price + '%')
     END
GO
/****** Object:  StoredProcedure [dbo].[patient_prescription_mdeicine_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[patient_prescription_mdeicine_Update]     
(         @patient_prescription_mdeicine_id uniqueidentifier  ,   @pricing_id uniqueidentifier ,
@patient_prescription_id uniqueidentifier  ,       @medicine_id uniqueidentifier  ,    
@price int  ,       @quantity int  ,       @total_price int  , 
@status bit , @editby varchar(50) , @editdate datetime   )   
AS    BEGIN        
UPDATE [patient_prescription_mdeicine]
SET      [patient_prescription_id]=@patient_prescription_id,    
[medicine_id]=@medicine_id,     [price]=@price,    
[quantity]=@quantity, pricing_id = @pricing_id,  
[total_price]=@total_price, status=@status ,
Editby = @editby , EditDate = @editdate
WHERE   [patient_prescription_mdeicine_id]=@patient_prescription_mdeicine_id     
END
GO
/****** Object:  StoredProcedure [dbo].[patient_prescription_Search]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[patient_prescription_Search]  
    (  
       @patient_prescription_id uniqueidentifier  ,
       @patient_id uniqueidentifier  ,
       @assigned_Date DateTime  ,
       @total_cost int  ,
       @status bit  
    ) 
  AS  
  BEGIN  
       SELECT * FROM [patient_prescription]  
WHERE 
(patient_prescription_id IS NULL OR patient_prescription_id = @patient_prescription_id )
 OR (patient_id IS NULL OR patient_id = @patient_id )
 OR (assigned_Date IS NULL OR assigned_Date LIKE '%' + @assigned_Date + '%')
 OR (total_cost IS NULL OR total_cost LIKE '%' + @total_cost + '%')
     END
GO
/****** Object:  StoredProcedure [dbo].[patient_prescription_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[patient_prescription_Update]  
(         @patient_prescription_id uniqueidentifier  ,       @patient_id uniqueidentifier  ,   
@assigned_Date DateTime  ,       @total_cost int  ,     
@status bit ,@type varchar(50)  , @editby varchar(50), @editdate datetime ) 
AS    BEGIN       
UPDATE [patient_prescription]
SET      [patient_id]=@patient_id,     [assigned_Date]=@assigned_Date,[type] = @type ,  
[total_cost]=@total_cost, status=@status  ,Editby = @editby, EditDate = @editdate
WHERE   [patient_prescription_id]=@patient_prescription_id            
END
GO
/****** Object:  StoredProcedure [dbo].[Pricing_DeleteByInvoice]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE[dbo].[Pricing_DeleteByInvoice]   
(         @invoice_id uniqueidentifier      ) 
AS    BEGIN        
update [Pricing]
set Flag=0
WHERE   InvoiceID = @invoice_id           
END
GO
/****** Object:  StoredProcedure [dbo].[Pricing_LOADALL]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[Pricing_LOADALL]  
AS    BEGIN         SELECT * FROM [Pricing]  
WHERE Flag = 1
END
GO
/****** Object:  StoredProcedure [dbo].[Product_Category_Delete]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[Product_Category_Delete] 
( @Product_Category_id uniqueidentifier ) 
AS    BEGIN       
update [Product_Category]  
set Flag = 0
WHERE   id=@Product_Category_id   
END
GO
/****** Object:  StoredProcedure [dbo].[Product_Category_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[Product_Category_Insert]   
(         
@name varchar(max)  ,       
@shortname varchar(max)  ,  
@code varchar(max)  ,       
@description varchar(max)  ,     
@addate DateTime ,        
@adby varchar(max)  ,   
@flag int  ,    
@status bit    )  
AS    BEGIN     
INSERT INTO dbo.Product_Category
(
   -- id,
   -- parent_id,
    name,
    shortname,
    code,
    description,
    AddDate,
    Addby,
   -- EditDate,
   -- Editby,
    status,
    Flag
)
VALUES
(   --NULL,      -- id - uniqueidentifier
    --N'',       -- parent_id - nvarchar(max)
    @name,       -- name - nvarchar(max)
    @shortname,       -- shortname - nvarchar(max)
    @code,       -- code - nvarchar(max)
    @description,       -- description - nvarchar(max)
    @addate, -- AddDate - datetime
    @adby,       -- Addby - nvarchar(max)
    --GETDATE(), -- EditDate - datetime
    --N'',       -- Editby - nvarchar(max)
    @status,      -- status - bit
    @flag          -- Flag - int
    )


--INSERT INTO [Product_Category](     [name],     [shortname],     [code],  
--[description],     [AddDate],     [Addby],  Flag,status    )          
--Values(     @name,     @shortname,     @code,     @description,    
--@addate,     @adby, @flag ,  @status    )   
END
GO
/****** Object:  StoredProcedure [dbo].[Product_Category_LOADALL]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[Product_Category_LOADALL] 
AS    BEGIN     
SELECT * FROM [Product_Category] 
WHERE Flag = 1
ORDER BY name
END
GO
/****** Object:  StoredProcedure [dbo].[Product_Category_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[Product_Category_Update]    
( 
@Product_Category_id uniqueidentifier  ,    
@name varchar(max)  ,  
@shortname varchar(max)  ,    
@code varchar(max)  ,      
@description varchar(max)  ,  
@editdate DateTime  ,     
@editby varchar(max)     
) 
AS    BEGIN   
UPDATE [Product_Category]
SET      [name]=@name,     [shortname]=@shortname,     [code]=@code, 
[description]=@description,    
[EditDate]=@editdate,     [Editby]=@editby

WHERE   id=@Product_Category_id 
END
GO
/****** Object:  StoredProcedure [dbo].[Product_Delete]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[Product_Delete]     
(@Pro_id uniqueidentifier)  
AS    BEGIN    
update [Product] 
set Flag = 0
WHERE   [Pro_id]=@Pro_id      
END
GO
/****** Object:  StoredProcedure [dbo].[Product_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[Product_Insert]     
	 (@Pro_id UNIQUEIDENTIFIER,  
	 @Product_Category_id uniqueidentifier  , 
	    @name varchar(max)  ,       @shortname varchar(max)  , 
	    @description varchar(max)  ,       @code varchar(max)  ,    
	    @company_name varchar(max)  ,       @formula_name varchar(max)  ,   
		@rs float  ,       @rm float  ,       @status bit  ,
		@qie float, @opn float,
		@InStock float, @adby varchar(50), @addate datetime, @flag int )   
AS    BEGIN 
INSERT INTO [Product]

(	
	Pro_id,
    [Product_Category_id],
     [name],[shortname],
     [description],[code],     [company_name],    
	 [formula_name],     [rs],     [rm], status , 
	 opened , quantityineach,InStock, Addby, AddDate, Flag )        
	 OUTPUT inserted.Pro_id
Values(    @Pro_id, 
@Product_Category_id,     @name,     @shortname,     @description,     @code,  
@company_name,     @formula_name,     @rs,     @rm, @status  ,@opn,@qie,@InStock, @adby, @addate, @flag  ) 

END
GO
/****** Object:  StoredProcedure [dbo].[Product_LOADALL]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[Product_LOADALL]   
AS    BEGIN      
SELECT [Product].Pro_id AS 'id',
       [Product].Product_Category_id,
       [Product].name AS 'Title',
       [Product].shortname,
       [Product].description,
       --code,
       [Product].company_name AS 'Brand',
       Product_Category.name AS 'Category'
	   --formula_name,
       --rs,
       --rm,
       --status,
       --opened,
       --quantityineach,
       --unit,
       --InStock,
       --Addby,
       --AddDate,
       --Editby,
       --EditDate,
       --Flag
	    FROM [Product] 
INNER JOIN dbo.Product_Category ON Product.Product_Category_id = dbo.Product_Category.id
WHERE [Product].Flag = 1

ORDER BY Product.Product_Category_id ASC , Product.name ASC 
END
GO
/****** Object:  StoredProcedure [dbo].[Product_LOADByID]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[Product_LOADByID]     
(         @Pro_id uniqueidentifier      )  
AS    BEGIN         
SELECT * FROM [Product]  
WHERE   [Pro_id]=@Pro_id 
AND Flag = 1
END
GO
/****** Object:  StoredProcedure [dbo].[Product_Search]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[Product_Search]  
    (  
	@Product_Category_id uniqueidentifier  ,
       @text varchar(max)  
       ) 
  AS  
  BEGIN  


SELECT [Product].Pro_id AS 'id',
       [Product].Product_Category_id,
       [Product].name AS 'Title',
       [Product].shortname,
       [Product].description,
       --code,
       [Product].company_name AS 'Brand',
       Product_Category.name AS 'Category'
	   --formula_name,
       --rs,
       --rm,
       --status,
       --opened,
       --quantityineach,
       --unit,
       --InStock,
       --Addby,
       --AddDate,
       --Editby,
       --EditDate,
       --Flag
	    FROM [Product] 
INNER JOIN dbo.Product_Category ON Product.Product_Category_id = dbo.Product_Category.id
WHERE 
[Product].Flag = 1
AND
(
  (Product_Category_id IS NULL OR Product_Category_id = @Product_Category_id )
 OR ([Product].name IS NULL OR [Product].name LIKE '%' + @text + '%')
 OR ([Product].shortname IS NULL OR [Product].shortname LIKE '%' + @text + '%')
 OR ([Product].description IS NULL OR [Product].description LIKE '%' + @text + '%')
 OR ([Product].code IS NULL OR [Product].code LIKE '%' + @text + '%')
 OR (company_name IS NULL OR company_name LIKE '%' + @text + '%')
 OR (formula_name IS NULL OR formula_name LIKE '%' + @text + '%')
 )
     END
GO
/****** Object:  StoredProcedure [dbo].[Product_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[Product_Update]     
(         @Pro_id uniqueidentifier  ,       @Product_Category_id uniqueidentifier  ,     
@name varchar(max)  ,       @shortname varchar(max)  ,      
@description varchar(max)  ,       @code varchar(max)  ,       
@company_name varchar(max)  ,       @formula_name varchar(max)  ,   
@rs float  ,       @rm float  ,       @status bit  , @opn float,
@qie float ,@InStock bit, @editby varchar(50), @editdate datetime)  
AS    BEGIN      
UPDATE [Product]
SET      [Product_Category_id]=@Product_Category_id,    
[name]=@name,     [shortname]=@shortname,     [description]=@description,   
[code]=@code,     [company_name]=@company_name,     [formula_name]=@formula_name, 
[rs]=@rs,     [rm]=@rm, status=@status 
, quantityineach=@qie, opened=@opn , InStock=@InStock, Editby = @editby, EditDate = @editdate  
WHERE   [Pro_id]=@Pro_id          
END
GO
/****** Object:  StoredProcedure [dbo].[resetPassword]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[resetPassword]
@password nvarchar(4000),
@id uniqueidentifier
as
begin
update  Users
set  password = @password,FirstTimeLogin = 0
where User_id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[SectionEMPDelete]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SectionEMPDelete]	
(
	@section_id UNIQUEIDENTIFIER
)
AS
BEGIN
	Delete From SectionEMP WHERE section_id=@section_id
END
GO
/****** Object:  StoredProcedure [dbo].[SectionEMPInsert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SectionEMPInsert]
(
	@name varchar(50),
	@shortname varchar(50),
	@desc varchar(50),
	@code varchar(50),
	@office_id UNIQUEIDENTIFIER,
    @time_in datetime,
	@time_out datetime,
	@short_leave datetime,
	@grace_time datetime,
	@absent_after datetime,
	@break_start datetime,
	@break_end datetime,
	@local bit,
	@web bit,
	@add_by varchar(50),
	@add_date date
) 
	
AS
BEGIN
	INSERT INTO SectionEMP (name,shortname,[desc],code,office_id,
	time_in,
		time_out ,
		short_leave ,
		grace_time ,
		absent_after ,
		break_start ,
		break_end,
		local ,
		web,
		add_by,
		add_date)
	VALUES(@name,@shortname,@desc,@code,@office_id,@time_in,
		@time_out ,
		@short_leave ,
		@grace_time ,
		@absent_after ,
		@break_start ,
		@break_end,
		@local ,
		@web,
		@add_by,
		@add_date)
END
-- ========================================uPDATE====================================================
GO
/****** Object:  StoredProcedure [dbo].[SectionEMPLoadALL]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SectionEMPLoadALL]	
@id UNIQUEIDENTIFIER
AS
BEGIN
 SELECT * FROM dbo.SectionEMP WHERE office_id = @id;
END
-- ==========================================LoadByID===================================================
GO
/****** Object:  StoredProcedure [dbo].[SectionEMPLoadbyID]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SectionEMPLoadbyID]	
(
	@office_id UNIQUEIDENTIFIER
)
AS
BEGIN
	Select SectionEMP.name as 'Name',SectionEMP.shortname as 'Short Name',SectionEMP.code as'Code', SectionEMP.[desc] as 'Description',
	Office.name as 'Office',SectionEMP.section_id as 'ID'
	From SectionEMP
	JOIN Office ON Office.office_id=SectionEMP.office_id
	WHERE Office.office_id=@office_id
END
-- ===========================================Delete=================================================
GO
/****** Object:  StoredProcedure [dbo].[SectionEMPUpdate]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SectionEMPUpdate]
(
	@name varchar(50),
	@shortname varchar(50),
	@desc varchar(50),
	@code varchar(50),
	
	@office_id UNIQUEIDENTIFIER,
	 @time_in DATETIME,
 @time_out DATETIME,
 @short_leave DATETIME,
 @grace_time DATETIME,
 @absent_after DATETIME,
 @break_start DATETIME,
 @break_end DATETIME,
 @local BIT,
 @Web BIT,
 @edit_by VARCHAR(50),
  @edit_date DATE,
  @section_id  UNIQUEIDENTIFIER
) 
	
AS
BEGIN
	UPDATE SectionEMP 
	SET 
	name=@name,
	shortname=@shortname,
	[desc]=@desc,
	code=@code,
	office_id=@office_id,
	 time_in = @time_in,
 time_out  = @time_out,
 short_leave = @short_leave,
 grace_time = @grace_time,
 absent_after = @absent_after,
 break_start = @break_start,
 break_end = @break_end,
 local = @local,
 web = @web,
 edit_by=@edit_by,
 edit_date = @edit_date
 
  WHERE section_id=@section_id
	
END
-- ==========================================LoadALL==================================================
GO
/****** Object:  StoredProcedure [dbo].[SelectByUserId]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE  [dbo].[SelectByUserId]
@id uniqueidentifier
AS
BEGIN
SELECT * FROM dbo.Users WHERE Users.User_id = @id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Accounts_Delete_by_Id]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_Accounts_Delete_by_Id]
@id uniqueidentifier
as
begin
update Accounts
set Flag = 0
where Account_id = @id;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Accounts_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_Accounts_Insert]
@T varchar(100),  
@D varchar(191),  
@Type varchar(20),
@tm datetime,  
@adby varchar(191),  
@st varchar(20),  
@flag tinyint  
as
begin
insert into Accounts 
(   Title,Type, Description , Timestamp, Add_by, [Status], Flag)
 VALUES (@T,@Type,@D, @tm,@adby,@st,@flag );
 end
GO
/****** Object:  StoredProcedure [dbo].[sp_Accounts_SelectAll]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_Accounts_SelectAll]
as
begin
select * from Accounts where Flag =1 and Type = 'Users';
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Accounts_SelectAll_Getby_Id]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_Accounts_SelectAll_Getby_Id]
 @id uniqueidentifier
 as
 begin
 select * from Accounts where Account_id = @id;
 end
GO
/****** Object:  StoredProcedure [dbo].[sp_Accounts_SelectAll_Getby_Title]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_Accounts_SelectAll_Getby_Title]
 @title varchar(50)
 as
 begin
 select * from Accounts where Title = @title
 end
GO
/****** Object:  StoredProcedure [dbo].[sp_Accounts_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[sp_Accounts_Update]
@T varchar(100),  
@Type varchar(20),
@D varchar(191),  
 @tm datetime,  
@adby varchar(191),  
@st varchar(20),  
@flag tinyint  ,
@id uniqueidentifier
 as
begin
update  Accounts 
set   Title = @T, Type = @Type,Description = @D,  Timestamp = @tm,Add_by = @adby,Status=@st,Flag=@flag
where Account_id = @id;
end 
GO
/****** Object:  StoredProcedure [dbo].[sp_Adress_Delete_by_Id]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_Adress_Delete_by_Id]
@id int
as
begin
Update Adress set Flag = 0 
where Adress_id = @id;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Adress_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_Adress_Insert]
 @User_id int , 
 @Name varchar(20), 
 @Short_name varchar(20), 
 @Description varchar,
  @Calling_Code varchar(5), 
  @Parent_id int, 
 @Timestamp datetime, 
@Add_by varchar(20), 
@Status varchar(20), 
@Flag tinyint 
as
begin
insert into Adress(User_id, Name, Short_name, Description, Calling_Code, Parent_id, Timestamp, Add_by, status, Flag)
values(@User_id,@Name, @Short_name, @Description, @Calling_Code, @Parent_id, @Timestamp,@Add_by,@Status,@Flag)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Adress_SelectAll]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_Adress_SelectAll]
as
begin
select * from Adress;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Adress_SelectAll_Getby_Id]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_Adress_SelectAll_Getby_Id]
@id int
as
begin
select * from Adress
where  Adress_id = @id;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Adress_SelectAll_Getby_Name]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_Adress_SelectAll_Getby_Name]
@Name varchar(100)
as
begin
select * from Adress
where  Name = @Name;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Adress_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_Adress_Update]
 @User_id int , 
 @Name varchar(20), 
 @Short_name varchar(20), 
 @Description varchar,
  @Calling_Code varchar(5), 
  @Parent_id int, 
 @Timestamp datetime, 
@Add_by varchar(20), 
@Status varchar(20), 
@Flag tinyint 
as
begin
Update Adress
set User_id =@User_id, Name =@Name, Short_name = @Short_name, Description = @Description,
 Calling_Code = @Calling_Code, Parent_id =@Parent_id, Timestamp =@Timestamp, Add_by = @Add_by, status = @Status, Flag =@Flag
end
GO
/****** Object:  StoredProcedure [dbo].[sp_AssignExperties_Delete]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_AssignExperties_Delete]
@id UNIQUEIDENTIFIER,
@uid UNIQUEIDENTIFIER
as
begin
Delete Assign_Experties Where AssignId = @id and ExpertiesId = @uid;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_AssignExperties_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_AssignExperties_Insert]
@ExpertiesId UNIQUEIDENTIFIER,
@UserId UNIQUEIDENTIFIER,
@Timestamp datetime,
@Addby varchar(20),
@Status varchar(20),
@Flag tinyint
as
begin
insert into Assign_Experties(ExpertiesId,UserId,Timestamp,Addby,Status,Flag)
values(@ExpertiesId,@UserId,@Timestamp,@Addby,@Status,@Flag);
end
GO
/****** Object:  StoredProcedure [dbo].[sp_AssignExperties_LoadAll]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_AssignExperties_LoadAll]
--yai procedure jo values user k against select ho chuki hain unhee show nhi kry ga yai
@id UNIQUEIDENTIFIER
as
begin
select Account_id ,Title from Accounts where type = 'Experties'
and Account_id not in
 (select  Assign_Experties.ExpertiesId from Assign_Experties where UserId = @id)
  end
GO
/****** Object:  StoredProcedure [dbo].[sp_AssignExperties_LoadByUserID]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_AssignExperties_LoadByUserID]    
@id UNIQUEIDENTIFIER    
as    
begin    
SELECT Assign_Experties.AssignId,Assign_Experties.ExpertiesId, Accounts.Title  
FROM Accounts  
INNER JOIN Assign_Experties ON Assign_Experties.ExpertiesId = Accounts.Account_id  
WHERE Accounts.Type = 'Experties' AND Assign_Experties.UserId = @id  
GROUP BY Accounts.Title ,Assign_Experties.AssignId,Assign_Experties.ExpertiesId
end  
GO
/****** Object:  StoredProcedure [dbo].[sp_AssignExperties_Select_by_Id]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_AssignExperties_Select_by_Id]
 @id uniqueidentifier
as
begin
select * from Assign_Experties where  UserId = @id and flag  = 1;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_AssignExperties_SelectAll]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_AssignExperties_SelectAll]
as
begin
select * from Assign_Experties
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Button_closeIssue]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_Button_closeIssue]
@id uniqueidentifier
as
begin
update Issue_tab
set status = 'Inactive' where Issue_id =@id;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Campaign_Delete_by_Id]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_Campaign_Delete_by_Id]
@id int
as
begin
Update Campaign set Flag = 0 
where Campaign_id = @id;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Campaign_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_Campaign_Insert]
@User_id int , 
@Organization_id int, 
@Organization_branch_id  int, 
@Campaign_title varchar(100), 
@Campaign_type  varchar(15), 
@Summary varchar(200), 
@Amount_goal varchar(20), 
@Adress varchar(100), 
@Start_date date, 
@End_date date,
 @Timestamp datetime, 
@Add_by varchar(20), 
@Status varchar(20), 
@Flag tinyint 
as
begin
insert into Campaign(User_id, Organization_id, Organization_branch_id, Campaign_title, Campaign_type, Summary, Amount_goal, Adress, Start_date, End_date,
 Timestamp, Add_by, status, Flag)
values(@User_id, @Organization_id, @Organization_branch_id, @Campaign_title, @Campaign_type, 
@Summary, @Amount_goal, @Adress, @Start_date, @End_date,@Timestamp,@Add_by,@Status,@Flag)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Campaign_SelectAll]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_Campaign_SelectAll]
as
begin
select * from Campaign;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Campaign_SelectAll_Getby_Id]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_Campaign_SelectAll_Getby_Id]
@id int
as
begin
select * from Campaign
where  Campaign_id = @id;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Campaign_SelectAll_Title]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_Campaign_SelectAll_Title]
@Title varchar(100)
as
begin
select * from Campaign
where Campaign_title = @Title;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Campaign_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_Campaign_Update]
 @User_id int , 
@Organization_id int, 
@Organization_branch_id  int, 
@Campaign_title varchar(100), 
@Campaign_type  varchar(15), 
@Summary varchar(200), 
@Amount_goal varchar(20), 
@Adress varchar(100), 
@Start_date date, 
@End_date date,
 @Timestamp datetime, 
@Add_by varchar(20), 
@Status varchar(20), 
@Flag tinyint 
as
begin
Update  Campaign
set User_id = @User_id, Organization_id = Organization_id, Organization_branch_id = Organization_branch_id, Campaign_title = @Campaign_title,
 Campaign_type = @Campaign_type, Summary = @Summary, Amount_goal = @Amount_goal, Adress = @Adress, 
 Start_date = @Start_date, End_date =@End_date,Timestamp=@Timestamp, Add_by=@Add_by, status=@Status, Flag=@Flag
 end
GO
/****** Object:  StoredProcedure [dbo].[sp_closeCommentpage]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_closeCommentpage] 
@stat varchar(50)
as
begin
select  descript from Issue_tab where status = @stat;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Comment_Add]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_Comment_Add]
(@iss_id uniqueidentifier,@desc varchar(100),@files Varchar(100), 
@tmp datetime, @flg tinyint,@stat varchar(50),@edtby varchar(50)
)
AS
BEGIN
INSERT INTO Comment_tab (Issue_id,descript,attachments,date,flag,status,edit_by)
VALUES(@iss_id,@desc,@files,@tmp,@flg,@stat,@edtby)

END
GO
/****** Object:  StoredProcedure [dbo].[sp_Comment_Delete]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_Comment_Delete]
(@com_id uniqueidentifier
)
AS
BEGIN
Delete from Comment_tab

where Comm_id = @com_id

END

GO
/****** Object:  StoredProcedure [dbo].[sp_Comment_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_Comment_Update]
(@com_id uniqueidentifier,@iss_id uniqueidentifier,@desc varchar(100)
)
AS
BEGIN
UPDATE Comment_tab
SET Issue_id =@iss_id,descript=@desc
where Comm_id = @com_id

END
GO
/****** Object:  StoredProcedure [dbo].[sp_Credential_Table_Delete_by_Id]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_Credential_Table_Delete_by_Id]
@id int
as
begin
Update Campaign set Flag = 0 
where Campaign_id = @id;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Credential_Table_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_Credential_Table_Insert]
@User_id UNIQUEIDENTIFIER , 
@Organization_Id UNIQUEIDENTIFIER, 
@Domain_id  VARCHAR(100) , 
@primary_email varchar(100), 
@Recovery_Email varchar(100), 
@Password varchar(15), 
@Timestamp datetime, 
@Add_by varchar(20), 
@Status varchar(20), 
@Flag tinyint
as
begin
insert into Credential_Table(User_id,Organization_Id, DomainAccType, primary_email, Recovery_Email, Password, Timestamp, Add_by, Status, Flag)
values(@User_id,@Organization_Id, @Domain_id, @primary_email, @Recovery_Email, @Password, @Timestamp,@Add_by,@Status,@Flag)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Credential_Table_SelectAll]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_Credential_Table_SelectAll]
@id UNIQUEIDENTIFIER
as
begin
select * from Credential_Table where Organization_Id = @id and Flag = 1;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Credential_Table_SelectAll_Getby_Id]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_Credential_Table_SelectAll_Getby_Id]
@id uniqueidentifier
as
begin
select * from Credential_Table
where   Id = @id;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Credential_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_Credential_Update]
 @User_id UNIQUEIDENTIFIER , 
@Organization_Id UNIQUEIDENTIFIER, 
@Domain_id  VARCHAR(100) , 
@primary_email varchar(100), 
@Recovery_Email varchar(100), 
@Password varchar(15), 
@Timestamp datetime, 
@Add_by varchar(20), 
@Status varchar(20), 
@Flag TINYINT,
@id UNIQUEIDENTIFIER
as
begin
Update  Credential_Table
set 
User_id= @User_id,Organization_Id =@Organization_Id, DomainAccType =@Domain_id, primary_email =@primary_email, 
Recovery_Email =@Recovery_Email, Password =@Password, Timestamp =@Timestamp, Add_by =@Add_by, Status =@Status, Flag =@Flag
WHERE dbo.Credential_Table.Id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Customer_Delete_by_id]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_Customer_Delete_by_id]
@id uniqueidentifier
as
begin
update Users
set Flag = 0 where User_id = @id and Account_type= 'Customer';
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Customer_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_Customer_Insert]  
          
@First_name varchar(20),@Last_name varchar(20),@User_name varchar(50),@Father_name varchar(50),      
@Cnic varchar(15),         
@Email varchar(50), @password varchar(15),      
@contact varchar(15),@Phone varchar(15) ,            
@country_id uniqueidentifier,@state_id uniqueidentifier,@city_id uniqueidentifier,@Adress varchar(100),@Gender varchar(6),@DOB varchar(20),@Account_type varchar(20),                
@Timestamp  datetime,@Add_by varchar(191),@Status varchar(20),@Flag tinyint                
as                  
begin                 
insert into Users      
(  First_name, Last_name, User_name, Father_name, Cnic,      
 Email, password, contact, Phone, country_id,state_id ,city_id, Adress, Gender, DOB,      
 Account_type, Timestamp, Add_by, Status, Flag)      
      
values      
( @First_name, @Last_name, @User_name, @Father_name, @Cnic,      
 @Email, @password, @contact, @Phone, @country_id,@state_id ,@city_id, @Adress, @Gender, @DOB,      
 @Account_type, @Timestamp, @Add_by, @Status, @Flag )  
 
end 
GO
/****** Object:  StoredProcedure [dbo].[sp_Customer_SelectAll]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  procedure [dbo].[sp_Customer_SelectAll]  
as  
begin  
select * from Users where flag = 1 and Account_type= 'Customer';  
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Customer_SelectAll_Getby_Id]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_Customer_SelectAll_Getby_Id] 
@id uniqueidentifier
as  
begin  
select * from Users where User_id = @id and Account_type='Customer';  
end 
GO
/****** Object:  StoredProcedure [dbo].[sp_Customer_SelectAll_Getby_name]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_Customer_SelectAll_Getby_name] 
@name varchar(50)
as  
begin  
select * from Users where  User_name = @name and Account_type= 'Customer';  
end 
GO
/****** Object:  StoredProcedure [dbo].[sp_Customer_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  procedure [dbo].[sp_Customer_Update]           
@First_name varchar(20),@Last_name varchar(20),@User_name varchar(50),@Father_name varchar(50),        
@Cnic varchar(15),           
@Email varchar(50), @password varchar(15),        
@contact varchar(15),@Phone varchar(15) ,              
@country_id uniqueidentifier,@state_id uniqueidentifier,@city_id uniqueidentifier,@Adress varchar(100),@Gender varchar(6),@DOB varchar(20),@Account_type varchar(20),                  
@Timestamp  datetime,@editby varchar(191),@Status varchar(20),@Flag tinyint    ,
@id uniqueidentifier
as  
begin             
Update Users  
set First_name = @First_name, Last_name = @Last_name, User_name =@User_name,   
Father_name = @Father_name, Cnic = @Cnic,        
 Email =@Email, password = @password, contact =@contact, Phone =@Phone,   
 country_id=@country_id,state_id =@state_id,city_id=@city_id, Adress=@Adress, Gender =@Gender,   
 DOB =@DOB,Account_type =@Account_type, EditDate=@Timestamp, EditBy=@editby,  
  Status=@Status, Flag=@Flag  
  where User_id=@id
 end 
GO
/****** Object:  StoredProcedure [dbo].[sp_CustomerContact_Delete_by_id]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_CustomerContact_Delete_by_id]
@id uniqueidentifier
as
begin
update Contact
set Flag=0 where Contact.ContID= @id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_CustomerContact_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_CustomerContact_Insert]
@userid uniqueidentifier, @num varchar(50), @descrip varchar (50),
@adby varchar(50), @addate datetime, @stats varchar(50), @flg int
as
begin
Insert Into Contact(User_id,Number,Descrip,AddBy,AddDate,Status,Flag)
values (@userid, @num, @descrip, @adby,@addate, @stats, @flg)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_CustomerContact_SelectAll]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[sp_CustomerContact_SelectAll]
as
begin
select * from Contact 
INNER JOIN Users on Contact.User_id = Users.User_id
where Contact.Flag = 1 AND Users.Account_type = 'Customer'
end
GO
/****** Object:  StoredProcedure [dbo].[sp_CustomerContact_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_CustomerContact_Update]
@id uniqueidentifier,
@userid uniqueidentifier, @num varchar(50), @descrip varchar (50),
@stats varchar(50), @flg int, @editby varchar (50), @editdate datetime
as
begin
update Contact
set
User_id= @userid, Number= @num, Descrip= @descrip, Status= @stats,
Flag= @flg, EditBy= @editby, EditDate= @editdate
where Contact.ContID= @id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_CustomerInvoice_Delete_by_id]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_CustomerInvoice_Delete_by_id]
@id uniqueidentifier
as
begin

update CustomerInvoice
set Flag= 0 where CusIvID = @id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_CustomerInvoice_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_CustomerInvoice_Insert]
@proid uniqueidentifier, 

@stats varchar(50), @adby varchar(50),
@addate datetime, @flg int
as
begin
insert into CustomerInvoice(ProID,   Status, AddBy, AddDate, Flag)
Values (@proid,  @stats, @adby, @addate, @flg)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_CustomerInvoice_LoadByProduct]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_CustomerInvoice_LoadByProduct]
@proid uniqueidentifier
as
begin
Select * from CustomerInvoice where CustomerInvoice.ProID = @proid
end
GO
/****** Object:  StoredProcedure [dbo].[sp_CustomerInvoice_SelectAll]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[sp_CustomerInvoice_SelectAll]
as
begin
Select * from CustomerInvoice
where flag = 1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Delete_Issue_Detail_Tab]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[sp_Delete_Issue_Detail_Tab]
@iss_del int
AS
BEGIN
DELETE FROM Issue_detail_tab
WHERE issue_detail_id = @iss_del
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllfromIssue_tab]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_GetAllfromIssue_tab]
AS
BEGIN
SELECT * FROM issue_tab
END


GO
/****** Object:  StoredProcedure [dbo].[sp_InsertdataInIssue_Tab]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_InsertdataInIssue_Tab]
@title varchar(50), @desc varchar(50),@addby varchar(20),@due_dat datetime
,@stat varchar(20), @flag tinyint, @timestamp datetime, @lab_id uniqueidentifier, @dept_id uniqueidentifier
AS
BEGIN
INSERT INTO Issue_tab (Title,descript,Addby,due_date,status,flag,timestampp,label_id,dept_id)

OUTPUT inserted.Issue_id

VALUES(@title,@desc,@addby,@due_dat,@stat,@flag,@timestamp,@lab_id,@dept_id)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertdataLabel_tab]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_InsertdataLabel_tab]
@title varchar(50),@desc varchar(50), @color_c varchar(50),@add_by varchar(50),
@stat varchar(50), @flag tinyint,@timestamp datetime
AS
BEGIN
INSERT INTO label_tab (name,description,color_code,Addby,Status,flag,timestampp)
VALUES (@title,@desc,@color_c,@add_by,@stat,@flag,@timestamp)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertInto_SubOffices]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[sp_InsertInto_SubOffices]
@of_id uniqueidentifier, @dpt_id uniqueidentifier, @titl varchar(100),@desc varchar(100),@addby varchar(100),@stat varchar(50),@flg tinyint,@tmp datetime
AS
BEGIN
INSERT INTO Sub_Office_Table (off_id,dept_id,title,descrp,addby,Status,flag,Date)
VALUES(@of_id,@dpt_id,@titl,@desc,@addby,@stat,@flg,@tmp)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertintoDepts]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_InsertintoDepts]
@title varchar(50),@PID uniqueidentifier,@desc varchar(50),@adby varchar(50),@stat varchar(20), @flag tinyint, @tmp datetime
AS
BEGIN
Insert INTO Department_tab (dept_title,PID,dept_descrip,addby,status,flag,timestampp)
VALUES(@title,@PID,@desc,@adby,@stat,@flag,@tmp)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertintoIss_Detail_Tab]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[sp_InsertintoIss_Detail_Tab]
@fil varchar(50),@iss_id int, @dept_id int, @lab_id int,@addby varchar(20),@stat varchar(20),
@flag tinyint, @tmp datetime
AS
BEGIN
INSERT INTO Issue_detail_tab(files,Issue_id,dept_id,label_id,Addby,status,flag,timestampp)
VALUES(@fil,@iss_id,@dept_id,@lab_id,@addby,@stat,@flag,@tmp)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Invoice_Delete_by_id]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[sp_Invoice_Delete_by_id]
@id uniqueidentifier
as
begin
update Invoice
set 
Flag = 0 where InvoiceID = @id;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Invoice_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[sp_Invoice_Insert] 
@invoiceNo varchar(50), @name varchar(50), @shtname varchar(50),
@code varchar(50), @descrip varchar(50), @serialno varchar(50),
@desigcost varchar(50), @puschorder varchar(50), @userid uniqueidentifier,
@fromdate date, @todate date, @date date, @stats varchar(50),
@adby varchar(50), @addate varchar(50), @flg int, @taxid uniqueidentifier


as
begin
insert into Invoice(InvoiceNo, Name, ShortName,Code, Descrip, SerialNo, 
DesignatedCost,PurchaseOrderNo, User_id, 
FromDate, ToDate, Date, Status,
AddBy,AddDate, Flag, TaxID)

values (@invoiceNo , @name , @shtname,
@code , @descrip , @serialno ,
@desigcost , @puschorder , @userid ,
@fromdate , @todate, @date, @stats ,
@adby , @addate , @flg , @taxid )
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Invoice_SelectAll]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[sp_Invoice_SelectAll]
as
begin
select * from Invoice 
where Flag = 1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Invoice_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_Invoice_Update]
@id uniqueidentifier,
@invoiceNo varchar(50), @name varchar(50), @shtname varchar(50),
@code varchar(50), @descrip varchar(50), @serialno varchar(50),
@desigcost varchar(50), @puschorder varchar(50), @userid uniqueidentifier,
@fromdate date, @todate date, @date date, @stats varchar(50),
 @flg int,
@editby varchar(50), @editdate varchar(50), @taxid uniqueidentifier
as
begin
Update Invoice
set  InvoiceNo= @invoiceNo, Name= @name, ShortName= @shtname,
Code= @code, Descrip= @descrip, SerialNo= @serialno, 
DesignatedCost= @desigcost,PurchaseOrderNo= @puschorder, User_id= @userid, 
FromDate= @fromdate, ToDate= @todate, Date= @date, Status= @stats,
 Flag= @flg, EditBy= @editby, EditDate=@editdate, TaxID= @taxid

where Invoice.InvoiceID= @id;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_InvoiceItem_Delete_by_id]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[sp_InvoiceItem_Delete_by_id]
@id int
as
begin
update Invoice_Items
set 
Flag = 0 where InVoiceItemID = @id;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_InvoiceItem_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[sp_InvoiceItem_Insert] 
@entryno varchar (50), @custno varchar(50),
@invoiceid int, @proid int,
@qty varchar (50), @price varchar(50),
@VETax varchar (50), @RSTax varchar(50), @STPay varchar(50),
@VITax varchar(50), @stats varchar(50),
@addby varchar(50), @addate varchar(50), @flg int,
@remain varchar(50)


as
begin
insert into Invoice_Items(EntryNo,CustomerNo,InvoiceID,ProID,Qty,
Price,ValueExclusiveTax, RatesOFSalesTax,SalesTaxPayable, ValueIncludingTax ,Status,
AddBy,AddDate, Flag, Remain)

values (@entryno , @custno ,
@invoiceid , @proid ,
@qty, @price ,
@VETax , @RSTax ,@STPay,
@VITax, @stats ,
@addby , @addate , @flg, @remain)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_InvoiceItem_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_InvoiceItem_Update]
@id int,
@entryno varchar (50), @custno varchar(50),
@invoiceid int, @proid int,
@qty varchar (50), @price varchar(50),
@VETax varchar (50), @RSTax varchar(50), @STPay varchar(50),
@VITax varchar(50), @stats varchar(50), @flg int,
@editby varchar(50), @editdate varchar(50),
@remain varchar(50)
as
begin
Update Invoice_Items
set  EntryNo= @entryno,CustomerNo= @custno,InvoiceID= @invoiceid,ProID= @proid,Qty= @qty,
Price= @price,ValueExclusiveTax= @VETax, RatesOFSalesTax= @RSTax,SalesTaxPayable = @STPay, ValueIncludingTax= @VITax ,Status= @stats,
Flag= @flg, EditBy= @editby,EditDate= @editdate, Remaining = @remain

where Invoice_Items.InVoiceItemID= @id;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_InvoiceItems_SelectAll]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[sp_InvoiceItems_SelectAll]
as
begin
select * from Invoice_Items 
where Flag = 1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Issuelabels_LoadAll]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_Issuelabels_LoadAll]  
--yai procedure jo values user k against select ho chuki hain unhee show nhi kry ga yai  
@id uniqueidentifier  
as  
begin  
select label_id,name from label_tab    where label_id  not in  
 (select Issue_labels.label_id from Issue_labels where Issue_id= @id)  
  end  

GO
/****** Object:  StoredProcedure [dbo].[sp_JobStatus]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_JobStatus]
as
begin
Select * from Jobstatus
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Login_Delete_by_Id]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_Login_Delete_by_Id]
@id int
as
begin
Update Login set Flag = 0 
where Login_id = @id;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Login_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_Login_Insert]
@User_id int , 
@Email  varchar(100), 
@Password varchar(15), 
@Account_type varchar(50),  
@Timestamp datetime, 
@Add_by varchar(20), 
@Status varchar(20), 
@Flag tinyint 
as
begin
insert into Login( User_id, Email, Password, Account_type, Timestamp, Add_by, Status, Flag)
values(@User_id,@Email,@Password,@Account_type,@Timestamp,@Add_by,@Status,@Flag)
  
 end
GO
/****** Object:  StoredProcedure [dbo].[sp_Login_SelectAll]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_Login_SelectAll]
as
begin
select * from Login where Flag =1;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Login_SelectAll_Getby_Id]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_Login_SelectAll_Getby_Id]
@id int
as
begin
select * from Login
where  Login_id = @id;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Login_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_Login_Update]
@User_id int , 
@Email  varchar(100), 
@Password varchar(15), 
@Account_type varchar(50),  
@Timestamp datetime, 
@Add_by varchar(20), 
@Status varchar(20), 
@Flag tinyint ,
@id int
as
begin
Update  Login
set  User_id = @User_id, Email =@Email, Password =@Password,
 Account_type = @Account_type, Timestamp =@Timestamp, Add_by =@Add_by, Status = @Status, Flag =@Flag
 where Login_id = @id;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Office_Delete]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_Office_Delete]
 @id UNIQUEIDENTIFIER
 AS
 BEGIN
 DELETE FROM dbo.Office  WHERE
office_id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Office_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_Office_Insert]
 @name VARCHAR(50),
 @shortname VARCHAR(50),
 @desc varchar(50),
 @code VARCHAR(50),
 @dept_id UNIQUEIDENTIFIER,
  @time_in DATETIME,
 @time_out DATETIME,
 @short_leave DATETIME,
 @grace_time DATETIME,
 @absent_after DATETIME,
 @break_start DATETIME,
 @break_end DATETIME,
 @local BIT,
 @Web BIT,
 @add_by VARCHAR(50),
  @add_date DATE
  
 AS
 BEGIN
 INSERT INTO Office(name,shortname,[desc],code,dept_id, time_in,time_out,
 short_leave,grace_time,absent_after,break_start,break_end,local,web,add_by,add_date)
 VALUES(@name,@shortname,@desc,@code,@dept_id ,@time_in,@time_out,
 @short_leave,@grace_time,@absent_after,@break_start,@break_end,@local,@Web,@add_by,@add_date)

 end
GO
/****** Object:  StoredProcedure [dbo].[sp_Office_LoadAll]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Office_LoadAll]
@id UNIQUEIDENTIFIER
AS
BEGIN

SELECT * FROM Office
WHERE dept_id =  @id;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Office_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Office_Update]
 @name VARCHAR(50),
 @shortname VARCHAR(50),
 @desc varchar(50),
 @code VARCHAR(50),
 @dept_id UNIQUEIDENTIFIER,
  @time_in DATETIME,
 @time_out DATETIME,
 @short_leave DATETIME,
 @grace_time DATETIME,
 @absent_after DATETIME,
 @break_start DATETIME,
 @break_end DATETIME,
 @local BIT,
 @Web BIT,
 @edit_by VARCHAR(50),
  @edit_date DATE,
  @id UNIQUEIDENTIFIER
  
 AS
 BEGIN
 UPDATE Office
 SET
 name = @name,
 shortname = @shortname,
 [desc] = @desc,
 code =@code,
 dept_id = @dept_id,
 
 time_in = @time_in,
 time_out  = @time_out,
 short_leave = @short_leave,
 grace_time = @grace_time,
 absent_after = @absent_after,
 break_start = @break_start,
 break_end = @break_end,
 local = @local,
 web = @web,
 edit_by=@edit_by,
 edit_date = @edit_date
 WHERE
 office_id = @id
 END
GO
/****** Object:  StoredProcedure [dbo].[sp_Organization_Delete]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_Organization_Delete]
 @id uniqueidentifier
 as
 begin
 update Organization
 set Flag = 0
 where Organization_id=@id;
 end
GO
/****** Object:  StoredProcedure [dbo].[sp_Organization_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_Organization_Insert]
 @User_id UNIQUEIDENTIFIER,
 @Parent_id UNIQUEIDENTIFIER,
 @Title varchar(50),
 @Type varchar(20),
 @Description varchar(200),
 @Timestamp DateTime,
 @Add_by varchar(20),
 @Status varchar(20),
 @Flag tinyint
 as
 begin
 insert into Organization(User_id,Parent_id,Title,Type,Description,Timestamp,Add_by,Status,Flag)
values(@User_id,@Parent_id,@Title,@Type,@Description,@Timestamp,@Add_by,@Status,@Flag)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Organization_LoadAll]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  procedure [dbo].[sp_Organization_LoadAll]  
as  
begin  
select Organization_id,User_id,Parent_id,Title,Description,Timestamp,Add_by,Status,Flag from Organization
 where Type = 'Organization' and Flag = 1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Organization_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_Organization_Update]
 @User_id UNIQUEIDENTIFIER,
 @Parent_id  UNIQUEIDENTIFIER,
 @Title varchar(50),
 @Type varchar(20),
 @Description varchar(200),
 @Timestamp DateTime,
 @Add_by varchar(20),
 @Status varchar(20),
 @Flag tinyint,
 @id UNIQUEIDENTIFIER
 as
 begin
 Update Organization
 set User_id = @User_id,
 Parent_id = @Parent_id,
 Title = @Title,
 Type = @Type,
 Description =@Description,
 Timestamp = @Timestamp,
 Add_by = @Add_by,
 Status = @Status,
 Flag = @Flag
 where Organization_id=@id;
 end
GO
/****** Object:  StoredProcedure [dbo].[sp_OrganizationBranch_LoadAll]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  procedure [dbo].[sp_OrganizationBranch_LoadAll]  
@id UNIQUEIDENTIFIER
as  
begin  
select Organization_id,User_id,Parent_id,Title,Description,Timestamp,Add_by,Status,Flag from Organization
 where Flag = 1 and Parent_id=@id and  Type = 'Branch';
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Pages_Delete]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[sp_Pages_Delete]
@id uniqueidentifier
as
begin
Update Pages 
set Flag = 0
where PgID= @id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Pages_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[sp_Pages_Insert]
@pgurl varchar (50), 
@tms datetime , @adby varchar(50),
@stats varchar(50), @flg int

as
begin
insert into Pages(PgURL,  Timestamp, AddBy, Status, Flag)
values(@pgurl, @tms, @adby, @stats, @flg)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Pages_SelectAll]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_Pages_SelectAll]
as
begin
select * from Pages
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Pages_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[sp_Pages_Update]
@id uniqueidentifier,
@pgurl varchar (50), 

@stats varchar(50), @flg int,
 @editby varchar(50),@editdate datetime 

as
begin
Update Pages 
set PgURL=@pgurl,   Status=@stats, Flag=@flg,EditBy= @editby , EditDate= @editdate
where PgID= @id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Permission_Delete]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[sp_Permission_Delete]
@id UNIQUEIDENTIFIER
as
begin
Update Permission 
set Flag = 0
where PerID= @id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Permission_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_Permission_Insert]
@peruid varchar(50), @pgid UNIQUEIDENTIFIER, @userid UNIQUEIDENTIFIER, @peradd bit, @peredit bit, @perview bit, @perdel bit, 
@tms datetime, @adby varchar(50), @stats varchar(50), @flg int
as
begin

INSERT INTO Permission
           (PerUID
           ,PgID
           ,User_id
           ,PerAdd
           ,PerEdit
           ,PerView
           ,PerDel
           ,Timestamp
           ,AddBy
           ,Status
           ,Flag)
     VALUES
           (@peruid , @pgid , @userid, @peradd , @peredit
		   , @perview , @perdel , 
@tms, @adby , @stats , @flg)
end 
GO
/****** Object:  StoredProcedure [dbo].[sp_Permission_LoadAll]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_Permission_LoadAll]
as
begin
select * from Permission
where Flag= 1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Permission_LoadByUser]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_Permission_LoadByUser]
@userid UNIQUEIDENTIFIER
as
begin
SELECT Permission.*, Pages.PgURL from permission

INNER JOIN Pages on Pages.PgID = Permission.PgID
where User_id = @userid
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Permission_LoadPages]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_Permission_LoadPages]
(@userid uniqueidentifier, @pgURL varchar(50), @PerView bit)
as
begin
select * from Permission 
INNER JOIN Pages on Pages.PgURL = @pgURL
where Permission.User_id = @userid AND Permission.PerView = @PerView
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Permission_LoadPagesPermission]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_Permission_LoadPagesPermission]
(@userid uniqueidentifier, @pgURL varchar(50), @PerView bit)
as
begin



SELECT * FROM 

[Permission]

INNER JOIN Users on users.User_id = permission.User_id
INNER JOIN Pages on pages.PgID = Permission.PgID

WHERE 
Users.User_id = @userid
AND pages.PgURL = @pgURL
--AND permission.PerView = @PerView


end
GO
/****** Object:  StoredProcedure [dbo].[sp_Permission_LoadPermission]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_Permission_LoadPermission]
@id UNIQUEIDENTIFIER
as
begin
select Users.User_id, Pages.PgURL, Permission.PerAdd, Permission.PerView, Permission.PerDel, Permission.PerEdit FROM Permission
INNER JOIN Pages ON   Pages.PgID = Permission.PgID
INNER JOIN  Users ON  Users.User_id = Permission.User_id
where Permission.User_id = @id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Permission_SaveButtonPermission]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_Permission_SaveButtonPermission]
(@userid uniqueidentifier, @pgURL varchar(50), @PerAdd bit)
as
begin



SELECT * FROM 

[Permission]

INNER JOIN Users on users.User_id = permission.User_id
INNER JOIN Pages on pages.PgID = Permission.PgID

WHERE 
Users.User_id = @userid
AND pages.PgURL = @pgURL
--AND permission.PerView = @PerView


end
GO
/****** Object:  StoredProcedure [dbo].[sp_Permission_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_Permission_Update]
@id UNIQUEIDENTIFIER,
@peradd bit, @peredit bit, @perview bit, @perdel bit
as
begin

update Permission
set --PerUID = @peruid
       --    ,PgID= @pgid
       --    ,User_id= @userid
           PerAdd= @peradd
           ,PerEdit=@peredit
           ,PerView=@perview
           ,PerDel=@perdel
         --  ,Timestamp=@tms
         --edit by  ,AddBy=@adby
         --  ,Status=@stats
        --   ,Flag=@flg
where PerID =@id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Pricing_Delete_by_id]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_Pricing_Delete_by_id]
@id uniqueidentifier
as
begin
update Pricing
set 
Flag = 0 where PriceID = @id;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Pricing_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[sp_Pricing_Insert] 
@proid uniqueidentifier, @catid uniqueidentifier,
@price varchar(50), @qty varchar(50),
@total varchar(50), @date date,
@stats varchar(50), @remain varchar(50), @invoiceid uniqueidentifier,
@adby varchar(50),@addate datetime, @flg int


as
begin
insert into Pricing(ProID, CatID, Price, Qty, Total, Date, Status,Remaining,InvoiceID, AddBy,AddDate, Flag)
values (@proid , @catid ,
@price , @qty ,
@total , @date ,
@stats , @remain , @invoiceid ,
@adby ,@addate , @flg   )
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Pricing_SelectAll]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[sp_Pricing_SelectAll]
as
begin
Select * from Pricing 
where Flag = 1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Pricing_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_Pricing_Update]
@id uniqueidentifier,@proid uniqueidentifier, @catid uniqueidentifier,
@price varchar(50), @qty varchar(50),
@total varchar(50), @date date,
@stats varchar(50), @remain varchar(50), @invoiceid uniqueidentifier,
@flg int,
@editby varchar(50), @editdate datetime
as
begin
Update Pricing
set  ProID= @proid, CatID= @catid, Price= @price, Qty= @qty, 
Total= @total, Date= @date, Status= @stats,
Remaining=@remain,InvoiceID= @invoiceid, 
 Flag= @flg, EditBy= @editby, EditDate= @editdate
where Pricing.PriceID= @id;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_ProductCategory_SelectAll]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[sp_ProductCategory_SelectAll]
as
begin
select * from Product_Category
where Flag= 1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Promotion_Delete]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_Promotion_Delete]
@id uniqueidentifier
as
begin
update Promotion
set Flag=0 
where PromID = @id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Promotion_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_Promotion_Insert]
@proid uniqueidentifier, @desc varchar(50), @tms datetime,
@adby varchar(191), @stats nvarchar(191), @flg int
as begin
insert into Promotion (ProID, Descrip, Timestamp, AddBy, Status, Flag)
values(@proid, @desc, @tms, @adby, @stats, @flg)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdatedataLabel_tab]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_UpdatedataLabel_tab]
@id uniqueidentifier,@title varchar(50),@desc varchar(50), @color_c varchar(50),@addby varchar(50), @stat varchar(20),@flg tinyint,@tmp datetime
AS
BEGIN
UPDATE label_tab
SET name =@title, description=@desc, color_code= @color_c, Addby=@addby, Status=@stat, flag=@flg,timestampp=@tmp
where label_id=@id

END
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateDepts]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_UpdateDepts]
@dpt_id uniqueidentifier,@title varchar(50),@PID uniqueidentifier,@desc varchar(50),@adby varchar(50),@stat varchar(20), @flag tinyint, @tmp datetime
AS
BEGIN
Update Department_tab 
set dept_title=@title,PID=@PID, dept_descrip=@desc, addby=@adby,status=@stat,flag=@flag,timestampp=@tmp
Where dept_id= @dpt_id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateIss_Detail_Tab]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[sp_UpdateIss_Detail_Tab]
@iss_det int,@fil varchar(50),@iss_id int, @dept_id int, @lab_id int,@addby varchar(20),@stat varchar(20),
@flag tinyint, @tmp datetime
AS
BEGIN
UPDATE Issue_detail_tab
SET files = @fil, Issue_id=@iss_id, dept_id=@dept_id,label_id=@lab_id, Addby=@addby,status=@stat,flag=@flag, timestampp=@tmp
where issue_detail_id = @iss_det
END
GO
/****** Object:  StoredProcedure [dbo].[sp_UserEducation_Delete_by_id]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_UserEducation_Delete_by_id]
  @id uniqueidentifier
  as
  begin
  update User_Education
  set 
  Flag = 0 where Education_id = @id;
  end
GO
/****** Object:  StoredProcedure [dbo].[sp_UserEducation_Getby_Degree]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_UserEducation_Getby_Degree]
	@deg varchar(50)
	as
	begin
	select * from User_Education where
	Specilization = @deg;
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_UserEducation_Getby_id]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[sp_UserEducation_Getby_id]
	@id UNIQUEIDENTIFIER
	as
	begin
	select * from User_Education where
	User_id = @id and Flag  = 1;
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_UserEducation_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_UserEducation_Insert]
 @uid UNIQUEIDENTIFIER,    @board varchar(50), @Image  image,   @Subject varchar(50),   
  @obt varchar(15),    @Total varchar(15),    @percentage varchar(10),   
   @Tmstmp  datetime,    @addby varchar(191),    @stats varchar(20), 
   @flag tinyint    
   as
   begin
   INSERT INTO User_Education
 ( User_id, Board,Image, Specilization, OBT_CGPA, Totalmarks_Cgpa,
  Percentage, Timestamp, Add_by, status, Flag) 

	VALUES ( @uid  ,    @board,@Image  ,    @Subject  ,    @obt  ,    @Total  ,    @percentage  ,  
	  @Tmstmp  ,    @addby  ,    @stats  ,    @flag );
	end
 
GO
/****** Object:  StoredProcedure [dbo].[sp_UserEducation_SelectAll]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_UserEducation_SelectAll]
as
begin
select * from User_Education where Flag = 1;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UserEducation_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  procedure [dbo].[sp_UserEducation_Update]  
 @uid UNIQUEIDENTIFIER,    @board varchar(50),   @Image  image, @deg varchar(50),     
  @obt varchar(15),    @Total varchar(15),    @percentage varchar(10),     
   @Tmstmp  datetime,    @addby varchar(191),    @stats varchar(20),   
   @flag tinyint   ,  @id UNIQUEIDENTIFIER
   
   as  
   begin  
    Update  User_Education  
 set User_id = @uid, Board = @board, Image = @Image ,Specilization = @deg, OBT_CGPA = @obt,   
 Totalmarks_Cgpa = @Total,Percentage = @percentage    where Education_id = @id;
    
  end 
GO
/****** Object:  StoredProcedure [dbo].[sp_UserExperience_Delete_by_id]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_UserExperience_Delete_by_id]
@id uniqueidentifier
as
begin
Update User_Experience 
set Flag = 0
where Experience_id = @id;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UserExperience_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_UserExperience_Insert]
@uid UNIQUEIDENTIFIER, 
@jobTitle varchar(50),
@Image  image,
 @Cmpn varchar(100),
@Sdt date,
@Edt date,
@Sdes varchar(50),
@Edes varchar(50),
@resign varchar(191),
@Tmstmp datetime,
@Addby  varchar(191),
@stats  varchar(20),
@flag tinyint
as
begin
INSERT INTO  User_Experience
( User_id, Job_title, Image,Company_name, Start_date, End_date, Start_designation, End_designation, 
Resign, Timestamp, Add_by, status, Flag)
 VALUES ( @uid,@jobTitle,@Image,@Cmpn,@Sdt,@Edt,@Sdes,@Edes,@resign ,
 @Tmstmp ,@Addby ,@stats ,@flag )
 end
GO
/****** Object:  StoredProcedure [dbo].[sp_UserExperience_SelectAll]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_UserExperience_SelectAll]
as
begin
select * from User_Experience where Flag = 1;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UserExperience_SelectAll_Getby_id]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_UserExperience_SelectAll_Getby_id]
@id UNIQUEIDENTIFIER
as
begin
select * from  User_Experience where User_id= @id and flag = 1;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UserExperience_SelectAll_Getby_JobTitle]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_UserExperience_SelectAll_Getby_JobTitle]
@jobTitle  varchar(50)
as
begin
select * from  User_Experience where  Job_title = @jobTitle;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UserExperience_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_UserExperience_Update]
@uid UNIQUEIDENTIFIER, 
@jobTitle varchar(50),
@Image image,
@Cmpn varchar(100),
@Sdt date,
@Edt date,
@Sdes varchar(50),
@Edes varchar(50),
@resign varchar(191),
@Tmstmp datetime,
@Addby  varchar(191),
@stats  varchar(20),
@flag tinyint,
 @id UNIQUEIDENTIFIER
as
begin
Update User_Experience
 set User_id = @uid , Job_title = @jobTitle, Image =@Image,Company_name = @Cmpn , Start_date = @Sdt, 
 End_date = @Edt, Start_designation = @Sdes, End_designation = @Edes, Resign  = @resign,
 Timestamp = @Tmstmp, Add_by = @Addby, status = @stats, Flag=@flag
  where Experience_id = @id
 end
 
GO
/****** Object:  StoredProcedure [dbo].[sp_UserExperties_Delete_by_id]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_UserExperties_Delete_by_id]
@id uniqueidentifier
as
begin
Update User_Experties 
set Flag = 0
where Experties_id = @id;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UserExperties_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_UserExperties_Insert]
@uid UNIQUEIDENTIFIER, 
@ImagePath varchar(50),
@Certifcates varchar(191),
@Divison varchar(50),
@Title varchar(50),
@dt date,
@des varchar(50),
@Tmstmp datetime,
@Addby  varchar(191),
@stats  varchar(20),
@flag tinyint
as
begin
insert into User_Experties (  User_id ,ImagePath,Certifcates, Divison, Title, Date, Description, 
	Timestamp, Add_by, Status, Flag) 

VALUES ( @uid,@ImagePath,@Certifcates ,@Divison,@Title,@dt,@des ,@Tmstmp ,@Addby ,@stats ,@flag );
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UserExperties_SelectAll]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_UserExperties_SelectAll]
as
begin
select * from User_Experties where Flag =1;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UserExperties_SelectAll_Getby_Id]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_UserExperties_SelectAll_Getby_Id]
@id uniqueidentifier
as
begin
select * from User_Experties where Experties_id = @id;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UserExperties_SelectAll_Getby_Title]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_UserExperties_SelectAll_Getby_Title]
@title varchar(50)
as
begin
select * from User_Experties where Title = @title;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UserExperties_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_UserExperties_Update]
@uid uniqueidentifier, 
@ImagePath varchar(50),
@Certifcates varchar(191),
@Divison varchar(50),
@Title varchar(50),
@dt date,
@des varchar(50),
@Tmstmp datetime,
@Addby  varchar(191),
@stats  varchar(20),
@flag tinyint,
@id uniqueidentifier
as
begin
 Update User_Experties set  User_id = @uid, ImagePath=@ImagePath,Certifcates = @Certifcates, Divison = @Divison,
  Title = @Title, Date = @dt, Description = @des,Timestamp = @Tmstmp,Add_by=@Addby,Status=@stats,
  Flag=@flag	where Experties_id=@id;
   end 
GO
/****** Object:  StoredProcedure [dbo].[sp_Users_Delete_by_id]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_Users_Delete_by_id]
@id uniqueidentifier
as
begin
update Users
set Flag = 0 where User_id = @id;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Users_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  procedure [dbo].[sp_Users_Insert]  
          
@First_name varchar(20),@Last_name varchar(20),@User_name varchar(50),@Father_name varchar(50),      
@Cnic varchar(15),         
@Email varchar(50), @password nvarchar(4000),      
@contact varchar(15),@Phone varchar(15) ,            
@country_id UNIQUEIDENTIFIER,@state_id UNIQUEIDENTIFIER,@city_id  UNIQUEIDENTIFIER,@Area_id  UNIQUEIDENTIFIER,@Adress varchar(100),@Gender varchar(6),@DOB varchar(20),@Account_type varchar(20),                
@Timestamp  datetime,@Add_by varchar(191),@Status varchar(20),@Flag tinyint,  @FirstTimeLogin tinyint ,@Organization_id UNIQUEIDENTIFIER,@Branch_id UNIQUEIDENTIFIER ,  @Employee_id UNIQUEIDENTIFIER           
as                  
begin                 
insert into Users      
(  First_name, Last_name, User_name, Father_name, Cnic,      
 Email, password, contact, Phone, country_id,state_id ,city_id,Area_id , Adress, Gender, DOB,      
 Account_type, Timestamp, Add_by, Status, Flag,FirstTimeLogin,Organization_id,Branch_id,Employee_id)      
      
values      
( @First_name, @Last_name, @User_name, @Father_name, @Cnic,      
 @Email, @password, @contact, @Phone, @country_id,@state_id ,@city_id, @Area_id ,@Adress, @Gender, @DOB,      
 @Account_type, @Timestamp, @Add_by, @Status, @Flag,@FirstTimeLogin,@Organization_id,@Branch_id,@Employee_id )                
end 
GO
/****** Object:  StoredProcedure [dbo].[sp_Users_SelectAll]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  procedure [dbo].[sp_Users_SelectAll]  
as  
begin  
select * from Users where flag = 1;  
end  
   
GO
/****** Object:  StoredProcedure [dbo].[sp_Users_SelectAll_Getby_Id]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_Users_SelectAll_Getby_Id] 
@id uniqueidentifier
as  
begin  
select * from Users where User_id = @id;  
end  
GO
/****** Object:  StoredProcedure [dbo].[sp_Users_SelectAll_Getby_name]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_Users_SelectAll_Getby_name] 
@name varchar(50)
as  
begin  
select * from Users where  User_name = @name;  
end  
GO
/****** Object:  StoredProcedure [dbo].[sp_Users_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  procedure [dbo].[sp_Users_Update]           
@First_name varchar(20),@Last_name varchar(20),@User_name varchar(50),@Father_name varchar(50),        
@Cnic varchar(15),           
@Email varchar(50), @password nvarchar(4000),        
@contact varchar(15),@Phone varchar(15) ,              
@country_id UNIQUEIDENTIFIER,@state_id UNIQUEIDENTIFIER,@city_id UNIQUEIDENTIFIER,
@Area_id UNIQUEIDENTIFIER ,
@Adress varchar(100),@Gender varchar(6),@DOB varchar(20),@Account_type varchar(20),                  
@Timestamp  datetime,@Add_by varchar(191),@Status varchar(20),@Flag tinyint  ,
@Organization_id UNIQUEIDENTIFIER,@Branch_id UNIQUEIDENTIFIER , 
@Employee_id UNIQUEIDENTIFIER   ,
@id UNIQUEIDENTIFIER
as  
begin             
Update Users  
set First_name = @First_name, Last_name = @Last_name, User_name =@User_name,   
Father_name = @Father_name, Cnic = @Cnic,        
 Email =@Email, password = @password, contact =@contact, Phone =@Phone,   
 country_id=@country_id,state_id =@state_id,city_id=@city_id, Area_id=@Area_id,Adress=@Adress, Gender =@Gender,   
 DOB =@DOB,Account_type =@Account_type, Timestamp=@Timestamp, Add_by=@Add_by,  
  Status=@Status, Flag=@Flag  ,Organization_id = @Organization_id,Branch_id=@Branch_id,Employee_id=@Employee_id
  where User_id=@id
 end  
GO
/****** Object:  StoredProcedure [dbo].[State_Add]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  PROCEDURE [dbo].[State_Add]  
(  
 
@name varchar(50),  
@shortname varchar(50),  
@code varchar(50),  
@description varchar(50),  
@country_id UNIQUEIDENTIFIER ,  
@add_by varchar(50),  
@add_date varchar(50)  
)  
AS  
BEGIN  
  
  
INSERT INTO [dbo].[State]  
         (
		   [name]  
           ,[shortname]  
           ,[desc]  
           ,[code]  
           ,[country_id]  
           ,[add_by]  
           ,[add_date])  
     VALUES  
     (
		   @name  
     ,@shortname  
     ,@description  
     ,@code  
     ,@country_id  
     ,@add_by  
     ,@add_date  
        
     )  
  
  
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE Purchase_Order_FilterByDate
(@date1 datetime , @date2 datetime)
AS
BEGIN
SELECT * From Purchase_Order_Details
WHERE date BETWEEN @date1 AND @date2
END

GO
/****** Object:  StoredProcedure [dbo].[State_Delete]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[State_Delete]  
(  
@id uniqueidentifier  
)  
AS  
BEGIN  
  
DELETE FROM State 
WHERE state_id = @id  
 END 
GO
/****** Object:  StoredProcedure [dbo].[State_LoadAll]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[State_LoadAll]  
 @id UNIQUEIDENTIFIER
  
AS  
BEGIN  
  
SELECT * FROM State   where country_id = @id;
 END  

GO
/****** Object:  StoredProcedure [dbo].[State_LoadByCountry]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[State_LoadByCountry]  
(  
@country_id uniqueidentifier  
)  
  
AS  
BEGIN  
  
SELECT * FROM State WHERE   State.country_id = @country_id  
 END  
GO
/****** Object:  StoredProcedure [dbo].[State_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[State_Update]  
(  
@id UNIQUEIDENTIFIER,  
 @name varchar(50),  
@shortname varchar(50),  
@code varchar(50),  
@description varchar(50),  
@country_id UNIQUEIDENTIFIER,  
@edit_by varchar(50),  
@edit_date varchar(50)  
  
)  
AS  
BEGIN  
  
  
UPDATE [dbo].[State]  
set
[name]       = @name  
      ,[shortname]  = @shortname  
      ,[desc]  = @description  
      ,[code]  = @code  
      ,[country_id] = @country_id  
      ,[edit_by]    = @edit_by  
   ,[edit_date]  = @edit_date  
  
WHERE  State.state_id = @id  
  
  
  
 END  
GO
/****** Object:  StoredProcedure [dbo].[Stock_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[Stock_Insert]   
(
@organization_id UNIQUEIDENTIFIER,
@branch_id UNIQUEIDENTIFIER,
@pos_id UNIQUEIDENTIFIER,
@product_id UNIQUEIDENTIFIER,
@barcode VARCHAR(max),
@quantity FLOAT,
@quantityineach FLOAT,
@purchaseprice FLOAT,
@sellprice FLOAT,
@addby UNIQUEIDENTIFIER,
@addate DATETIME,
@flag int
)
AS    BEGIN

INSERT INTO dbo.Stock
(
    Product_id,
    Branch_id,
	POS_id,
    Organization_id,
    Quantity,
	RemainingQuantity,
    PurchasePrice,
    SellPrice,
    barcode,
    qie,
    AddDate,
    AddBy,
    Flag
)
VALUES
(   @product_id,        -- Product_Category_id - varchar(max)
    @branch_id,        -- Product_id - varchar(max)
    @pos_id,        -- Branch_id - varchar(max)
    @organization_id,        -- Organization_id - varchar(max)
    @quantity,
	@quantity,       -- Quantity - float
    @purchaseprice,       -- PurchasePrice - float
    @sellprice,       -- SellPrice - float
    @barcode,         -- barcode - int
    @quantityineach, -- expiryDate - datetime
    @addate,       -- qie - float
    @addby,      -- instock - bit
    @flag      -- Flag - bit
    )
      
END
GO
/****** Object:  StoredProcedure [dbo].[Stock_LOADALL]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[Stock_LOADALL]   
(
@Pro_id UNIQUEIDENTIFIER
)
AS    BEGIN      
SELECT id,
       --Product_Category_id,
       --Product_id,
       --Branch_id,
       --Organization_id,
       barcode,
       quantity,
		qie AS 'quantityineach',
       PurchasePrice AS 'purchaseprice',
       SellPrice AS 'sellingprice'
       --expiryDate,
       --instock,
       --AddDate,
      -- AddBy,
      -- EditDate,
      -- EditBy,
       --Flag 
	   FROM Stock

WHERE Flag = 1
AND stock.Product_id = @Pro_id
END
GO
/****** Object:  StoredProcedure [dbo].[Stock_LOADByProductID]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[Stock_LOADByProductID]   
(
@Pro_id UNIQUEIDENTIFIER
)
AS    BEGIN      
SELECT ID,
       --Product_Category_id,
       --Product_id,
       --Branch_id,
       --Organization_id,
       barcode,
       quantity,
		qie AS 'quantityineach',
       PurchasePrice AS 'purchaseprice',
       SellPrice AS 'sellingprice'
       --expiryDate,
       --instock,
       --AddDate,
      -- AddBy,
      -- EditDate,
      -- EditBy,
       --Flag 
	   FROM Stock

WHERE Flag = 1
AND stock.Product_id = @Pro_id
END
GO
/****** Object:  StoredProcedure [dbo].[Stock_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[Stock_Update]   
(
@id UNIQUEIDENTIFIER,
@organization_id UNIQUEIDENTIFIER,
@branch_id UNIQUEIDENTIFIER,
@pos_id UNIQUEIDENTIFIER,
@product_id UNIQUEIDENTIFIER,
@barcode VARCHAR(max),
@quantity FLOAT,
@quantityineach FLOAT,
@purchaseprice FLOAT,
@sellprice FLOAT,
@editby UNIQUEIDENTIFIER,
@editdate DATETIME,
@flag int
)
AS    BEGIN

UPDATE dbo.Stock 
SET
barcode = @barcode,
Quantity = @quantity,
qie = @quantityineach,
PurchasePrice = @purchaseprice,
SellPrice = @sellprice,
EditBy = @editby,
EditDate = @editdate

WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[student_Delete]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[student_Delete]
(
@id int


	
)
AS
BEGIN
	Delete from students
where id=@id
END
GO
/****** Object:  StoredProcedure [dbo].[student_geAll]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[student_geAll]

AS
BEGIN
SELECT * FROM students
END
GO
/****** Object:  StoredProcedure [dbo].[student_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[student_Insert]
(

@name varchar(MAX),
@fathername varchar(MAX),
@rollno varchar(MAX),
@address varchar(MAX),
@Add_by	varchar(MAX),
@Add_Date DATETIME,
@country_id INT,
@city_id INT
	
)
AS
BEGIN
	Insert into students (
name,
fathername,
rollno,
address,
Add_by,
Add_date,
country_id,
city_id
) Values(
@name,
@fathername,
@rollno,
@address,
@Add_by,
@Add_date,
@country_id,
@city_id

)
	
END
GO
/****** Object:  StoredProcedure [dbo].[student_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[student_Update]
(
@id INT,
@name varchar(MAX),
@fathername varchar(MAX),
@rollno varchar(MAX),
@address varchar(MAX),
@edit_by	varchar(MAX),
@edit_Date DATETIME,
@country_id INT,
@city_id INT
	
)
AS
BEGIN


UPDATE [dbo].[students]
   SET [name]       = @name
      ,[fathername] = @fathername
      ,[address]    = @address
      ,[rollno]     = @rollno
      ,[Edit_By]    = @edit_by
      ,[Edit_Date]  = @edit_Date
      ,[country_id] = @country_id
      ,[city_id]    = @city_id

 WHERE students.id = @id

	
END
GO
/****** Object:  StoredProcedure [dbo].[TeacherAttendence]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[TeacherAttendence]
@Teacher_ID varchar(50),
@TimeIn varchar(50),
@status varchar(50),
@Type varchar(50)
AS
BEGIN
	
	SET NOCOUNT ON;
	insert into Teacher_Attendance(Teacher_ID,TimeIn,Status,Type,date) Values(@Teacher_ID,@TimeIn,@status,@Type,CONVERT(varchar(11),  GETDATE(),103))
END
GO
/****** Object:  StoredProcedure [dbo].[TeacherEnrollment]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[TeacherEnrollment]
@TeacherID varchar(50)=null
AS
BEGIN
	
	SET NOCOUNT ON;
	update TeacherData set EnrollmentStatus ='Enrolled'
	where Teacher_ID=@TeacherID
END
GO
/****** Object:  StoredProcedure [dbo].[test_Delete]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE ProSales_Insert
(@pro_id uniqueidentifier, @price float,
@qty float, @total float, @date datetime,
@transaction varchar(50), @adby uniqueidentifier,
@addate datetime, @flag bit 
)
AS
BEGIN
INSERT INTO ProductSales(Pro_id,unitprice,qtysold,total,
date,transaction_no,add_by,add_date,flag
)
VALUES(@pro_id, @price, @qty, @total, @date,
@transaction, @adby,@addate,@flag)
END
GO

CREATE PROCEDURE ProSales_Update
(@id uniqueidentifier, @pro_id uniqueidentifier, @price float,
@qty float, @total float, 
@transaction varchar(50), @editby uniqueidentifier,
@editdate datetime)
AS
BEGIN
UPDATE ProductSales
SET Pro_id = @pro_id, unitprice = @price,
qtysold= @qty , total = @total , transaction_no = @transaction, 
edit_by = @editby, edit_date = @editdate

WHERE ProSales_id = @id
END
GO

CREATE PROCEDURE ProSales_Delete
(@id uniqueidentifier)
AS
BEGIN
UPDATE ProductSales
SET flag =0
WHERE ProSales_id = @id
END
GO

CREATE PROCEDURE ProSales_LoadAll
AS
BEGIN 
SELECT * FROM ProductSales
WHERE flag = 1
END
GO

CREATE PROCEDURE[dbo].[test_Delete]   
(         @test_id uniqueidentifier     )  
AS    BEGIN     
UPDATE [test] 
SET Flag =0
WHERE   [test_id]=@test_id     
END
GO
/****** Object:  StoredProcedure [dbo].[test_Insert]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[test_Insert]  
(         @name varchar(max)  ,       @shortname varchar(max)  ,  
@code varchar(max)  ,       @description varchar(max)  ,   
@status bit ,@adby varchar(50), @addate datetime  , @flag int )  
AS    BEGIN        
INSERT INTO [test](     [name],  
[shortname],     [code],     [description], 
status  , [Addby], [AddDate], [Flag]  )         
Values(     @name,     @shortname,     @code,  
@description, @status  , @adby, @addate, @flag  )     
END
GO
/****** Object:  StoredProcedure [dbo].[test_LOADALL]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[test_LOADALL] 
AS    BEGIN        
SELECT * FROM [test] 
WHERE Flag =1
END
GO
/****** Object:  StoredProcedure [dbo].[test_LOADByID]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[test_LOADByID]    
(         @test_id uniqueidentifier      ) 
AS    BEGIN        
SELECT * FROM [test]  
WHERE   [test_id]=@test_id 
AND Flag = 1
END
GO
/****** Object:  StoredProcedure [dbo].[test_Search]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[test_Search]  
    (  
       @test_id uniqueidentifier  ,
       @name varchar(max)  ,
       @shortname varchar(max)  ,
       @code varchar(max)  ,
       @description varchar(max)  ,
       @status bit  
    ) 
  AS  
  BEGIN  
       SELECT * FROM [test]  
WHERE 
(test_id IS NULL OR test_id =@test_id )
 OR (name IS NULL OR name LIKE '%' + @name + '%')
 OR (shortname IS NULL OR shortname LIKE '%' + @shortname + '%')
 OR (code IS NULL OR code LIKE '%' + @code + '%')
 OR (description IS NULL OR description LIKE '%' + @description + '%')
     END
GO
/****** Object:  StoredProcedure [dbo].[test_Update]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[test_Update]     
(         @test_id uniqueidentifier  ,       @name varchar(max)  ,  
@shortname varchar(max)  ,       @code varchar(max)  ,  
@description varchar(max)  ,       @status bit ,
@editby varchar (50), @editdate datetime)  
AS    BEGIN        
UPDATE [test]
SET      [name]=@name,     [shortname]=@shortname,   
[code]=@code,     [description]=@description, status=@status ,
[Editby]=@editby, [EditDate]= @editdate
WHERE   [test_id]=@test_id           
END
GO
/****** Object:  StoredProcedure [dbo].[ts_insertAttendanceEmp]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ts_insertAttendanceEmp]
(
@employ_id int,
--@studentname varchar(50)
--@timein time,
--@timeout time,
@type VARCHAR(max),
@date datetime
--@Attendance int,
--@status int

)
AS
BEGIN

INSERT INTO [Employee_attendance]

(
employ_id,
--student_name,
time_in,
[type],
attendance,
[date],
[status]
)
VALUES
(
@employ_id,
--@studentname,
GETDATE(),
@type,
1,
@date,
0
)


END
GO
/****** Object:  StoredProcedure [dbo].[UpdateIssueTab]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[UpdateIssueTab] 
@title varchar(50),@descrp varchar(50) ,@issue_id uniqueidentifier
AS
BEGIN
Update Issue_tab
SET Title=@title, descript=@descrp
where Issue_id= @issue_id;
End
GO
CREATE PROCEDURE Purchase_Order_LOADALL
AS 
BEGIN
SELECT * FROM Purchase_Order
WHERE flag = 1;
End
GO

CREATE PROCEDURE Purchase_Order_LoadByBranch
(
	@branch_id UNIQUEIDENTIFIER
)
AS
BEGIN
SELECT * FROM Purchase_Order
WHERE Purchase_Order.branch_id=@branch_id
END
GO

CREATE PROCEDURE Purchase_Order_Return_LOADALL
AS 
BEGIN
SELECT * FROM Purchase_Order_Return
WHERE flag = 1;
End
GO

CREATE PROCEDURE Purchase_Order_Return_LoadByBranch
(
	@branch_id UNIQUEIDENTIFIER
)
AS
BEGIN
SELECT * FROM Purchase_Order_Return
WHERE Purchase_Order_Return.branch_id=@branch_id
END
GO

CREATE PROCEDURE [dbo].[Purchase_Order_Return_Insert]
(
@party_id uniqueidentifier, @organization_id uniqueidentifier, @branch_id UNIQUEIDENTIFIER,
@t_am float, @s_t_am float, @dis_am float, @dis_per int, 
@paid_am float, @rem float, @remark varchar(max),
@payment varchar(max), @invoice varchar(100), @status varchar(50), @date datetime,
@adby uniqueidentifier, @addate datetime, @flag bit, @tax_id uniqueidentifier, @tax_am float,
@orderno varchar(100), @nonvendor_am float, @nonvendor_per int,
@return_date datetime,@return_fee float, @refund float, @credit float
)
AS
BEGIN
INSERT INTO Purchase_Order_Return( 
party_id, organization_id, branch_id,
total_amount, sub_total_amount, discount_amount, discount_percentage,
paid_amount, remaning_amount, remarks,
payment_type, Invoice_no, status, date, 
add_by, add_date, flag, tax_id, tax_amount,
Order_no, non_vendor_cost_amount, non_vendor_cost_percentage,
return_date, return_fee, refund, credit
)
VALUES (@party_id, @organization_id, @branch_id,
@t_am, @s_t_am, @dis_am, @dis_per, 
@paid_am, @rem, @remark,
@payment, @invoice, @status, @date,
@adby, @addate, @flag, @tax_id, @tax_am,
@orderno, @nonvendor_am, @nonvendor_per,
@return_date, @return_fee, @refund, @credit
)
END
GO

CREATE PROCEDURE Purchase_Order_Return_Delete
(
@id uniqueidentifier
)
AS
BEGIN
UPDATE Purchase_Order_Return
SET flag=0
WHERE id= @id
END
GO

CREATE PROCEDURE Purchase_Order_Return_Update
(
@id uniqueidentifier, @party_id uniqueidentifier, @organization_id uniqueidentifier, @branch_id UNIQUEIDENTIFIER,
@t_am float, @s_t_am float, @dis_am float, @dis_per int, 
@paid_am float, @rem float, @remark varchar(max),
@payment varchar(max), @invoice varchar(100), @status varchar(50), @date datetime,
@editby uniqueidentifier, @editdate datetime,  @tax_id uniqueidentifier, @tax_am float,
@orderno varchar(100), @nonvendor_am float, @nonvendor_per int,
@return_date datetime,@return_fee float, @refund float, @credit float
)
AS
BEGIN
UPDATE Purchase_Order_Return
SET party_id = @party_id, organization_id = @organization_id, branch_id=@branch_id,
total_amount= @t_am, sub_total_amount = @s_t_am, discount_amount= @dis_am, discount_percentage=@dis_per, 
paid_amount=@paid_am, remaning_amount = @rem, remarks= @remark,
payment_type = @payment, Invoice_no = @invoice, status = @status, date= @date,
edit_by = @editby, edit_date = @editdate, tax_id = @tax_id, tax_amount = @tax_am,
Order_no= @orderno, non_vendor_cost_amount=@nonvendor_am, non_vendor_cost_percentage=@nonvendor_per,
return_date = @return_date, return_fee = @return_fee, refund=@refund, credit= @credit
WHERE id= @id
END
GO

Alter PROCEDURE Purchase_Order_FilterByDate
(@date1 datetime , @date2 datetime)
AS
BEGIN
SELECT * From Purchase_Order
WHERE date BETWEEN @date1 AND @date2
END
GO

CREATE PROCEDURE Purchase_Order_Detail_FilterByDate
(@date1 datetime , @date2 datetime)
AS
BEGIN
SELECT * From Purchase_Order_Details
WHERE date BETWEEN @date1 AND @date2
END
GO

CREATE PROCEDURE Purchase_Order_Return_FilterByDate
(@date1 datetime , @date2 datetime)
AS
BEGIN
SELECT * From Purchase_Order_Return
WHERE date BETWEEN @date1 AND @date2
END
GO

CREATE PROCEDURE Purchase_Order_Detail_LOADALL
AS 
BEGIN
SELECT * FROM Purchase_Order_Details
WHERE flag = 1;
End
GO

CREATE PROCEDURE Payment_type_LoadAll
AS
BEGIN
SELECT * FROM [dbo].[Payment_type]
END
GO

CREATE PROCEDURE [dbo].[Purchase_Order_Detail_Insert]
(@purchase_order_id uniqueidentifier,
@product_id uniqueidentifier, @product_category_id uniqueidentifier, 
@qty int, @pur_am float, @sale_am float,  
@tax_id uniqueidentifier, @tax_am uniqueidentifier,@dis_am float, @dis_per int,
@status varchar(50), @date datetime,
@adby uniqueidentifier, @addate datetime, @flag bit 
)
AS
BEGIN
INSERT INTO Purchase_Order_Details( purchase_order_id, product_id, product_category_id,
quantity,purchase_amount,sale_amount, 
tax_id, tax_amount,discount_amount, discount_percentage,
status, date, 
add_by, add_date, flag
)
VALUES (@purchase_order_id,@product_id, @product_category_id,
@qty, @pur_am, @sale_am,
@tax_id, @tax_am, @dis_am, @dis_per, 
@status, @date,
@adby, @addate, @flag
)
END
GO

CREATE PROCEDURE Purchase_Order_Detail_Delete
(
@id uniqueidentifier
)
AS
BEGIN
UPDATE Purchase_Order_Details
SET flag=0
WHERE id= @id
END
GO

CREATE PROCEDURE Purchase_Order_Detail_Update
(
@id uniqueidentifier, @purchase_order_id uniqueidentifier,
@product_id uniqueidentifier, @product_category_id uniqueidentifier, 
@qty int, @pur_am float, @sale_am float,  
@tax_id uniqueidentifier, @tax_am uniqueidentifier,@dis_am float, @dis_per int,
@status varchar(50), @date datetime,
@edit_by uniqueidentifier, @edit_date datetime
)
AS
BEGIN
UPDATE Purchase_Order_Details
SET 
purchase_order_id = @purchase_order_id, product_id= @product_id, product_category_id=@product_category_id,
quantity=@qty, purchase_amount=@pur_am, sale_amount=@sale_am,
tax_id=@tax_id, tax_amount=@tax_am, discount_amount=@dis_am, discount_percentage=@dis_per,
status = @status, date=@date, edit_by=@edit_by, edit_date= @edit_date
WHERE id= @id
END
GO

CREATE PROCEDURE [dbo].[Purchase_Order_Insert]
(
@party_id uniqueidentifier, @organization_id uniqueidentifier, @branch_id UNIQUEIDENTIFIER,
@t_am float, @s_t_am float, @dis_am float, @dis_per int, 
@paid_am float, @rem float, @remark varchar(max),
@payment varchar(max), @invoice varchar(100), @status varchar(50), @date datetime,
@adby uniqueidentifier, @addate datetime, @flag bit, @tax_id uniqueidentifier, @tax_am float,
@orderno varchar(100), @nonvendor_am float, @nonvendor_per int
)
AS
BEGIN
INSERT INTO Purchase_Order( 
party_id, organization_id, branch_id,
total_amount, sub_total_amount, discount_amount, discount_percentage,
paid_amount, remaning_amount, remarks,
payment_type, Invoice_no, status, date, 
add_by, add_date, flag, tax_id, tax_amount,
Order_no, non_vendor_cost_amount, non_vendor_cost_percentage
)
VALUES (@party_id, @organization_id, @branch_id,
@t_am, @s_t_am, @dis_am, @dis_per, 
@paid_am, @rem, @remark,
@payment, @invoice, @status, @date,
@adby, @addate, @flag, @tax_id, @tax_am,
@orderno, @nonvendor_am, @nonvendor_per
)
END
GO

CREATE PROCEDURE Purchase_Order_Delete
(
@id uniqueidentifier
)
AS
BEGIN
UPDATE Purchase_Order
SET flag=0
WHERE id= @id
END
GO

CREATE PROCEDURE Purchase_Order_Update
(
@id uniqueidentifier, @party_id uniqueidentifier, @organization_id uniqueidentifier, @branch_id UNIQUEIDENTIFIER,
@t_am float, @s_t_am float, @dis_am float, @dis_per int, 
@paid_am float, @rem float, @remark varchar(max),
@payment varchar(max), @invoice varchar(100), @status varchar(50), @date datetime,
@editby uniqueidentifier, @editdate datetime,  @tax_id uniqueidentifier, @tax_am float,
@orderno varchar(100), @nonvendor_am float, @nonvendor_per int
)
AS
BEGIN
UPDATE Purchase_Order
SET party_id = @party_id, organization_id = @organization_id, branch_id=@branch_id,
total_amount= @t_am, sub_total_amount = @s_t_am, discount_amount= @dis_am, discount_percentage=@dis_per, 
paid_amount=@paid_am, remaning_amount = @rem, remarks= @remark,
payment_type = @payment, Invoice_no = @invoice, status = @status, date= @date,
edit_by = @editby, edit_date = @editdate, tax_id = @tax_id, tax_amount = @tax_am,
Order_no= @orderno, non_vendor_cost_amount=@nonvendor_am, non_vendor_cost_percentage=@nonvendor_per
WHERE id= @id
END
GO

CREATE PROCEDURE[dbo].[PurchaseParty_Update]    
(         @p_id uniqueidentifier  ,       @name varchar(max)  ,       @shortname varchar(max)  ,    
@code varchar(max)  ,       @description varchar(max)  ,       @add varchar(max)  ,  
@National_Tax_Number varchar(max)  ,       @Goods_And_Services_Tax varchar(max)  ,   
@Guarranty varchar(max)  ,       @Standard_Report_Number varchar(max)  ,   
@phone varchar(max)  ,       @address varchar(max)  ,       @email varchar(max)  ,   
@Bank_account_number varchar(max)  ,       @International_Account_Number varchar(max)  ,  
@status bit , @editby varchar(50), @editdate datetime , @organization_id uniqueidentifier, @branch_id uniqueidentifier  ) 
AS    BEGIN        
UPDATE PurchaseParty SET      [name]=@name,     [shortname]=@shortname,    
[code]=@code,     [description]=@description,     [add]=@add,     
[National_Tax_Number]=@National_Tax_Number,     [Goods_And_Services_Tax]=@Goods_And_Services_Tax,  
[Guarranty]=@Guarranty,     [Standard_Report_Number]=@Standard_Report_Number, 
[phone]=@phone,     [address]=@address,     [email]=@email,   
[Bank_account_number]=@Bank_account_number,     [International_Account_Number]=@International_Account_Number,
status=@status , [Editby] = @editby , [EditDate]= @editdate     , [organization_id] = @organization_id, [branch_id] = @branch_id

WHERE   [party_id]=@p_id     
END
GO

CREATE PROCEDURE Purchase_Order_Return_Detail_LOADALL
AS 
BEGIN
SELECT * FROM Purchase_Order_Return_Details
WHERE flag = 1;
End
GO

CREATE PROCEDURE [dbo].[Purchase_Order_Return_Detail_Insert]
(@purchase_order_return_id uniqueidentifier,
@product_id uniqueidentifier, @product_category_id uniqueidentifier, 
@qty int, @pur_am float, @sale_am float,  
@tax_id uniqueidentifier, @tax_am uniqueidentifier,@dis_am float, @dis_per int,
@status varchar(50), @date datetime,
@adby uniqueidentifier, @addate datetime, @flag bit ,
@return_date datetime, @refund float
)
AS
BEGIN
INSERT INTO Purchase_Order_Return_Details( purchase_order_Return_id, product_id, product_category_id,
quantity,purchase_amount,sale_amount, 
tax_id, tax_amount,discount_amount, discount_percentage,
status, date, 
add_by, add_date, flag,
return_date,refund
)
VALUES (@purchase_order_return_id,@product_id, @product_category_id,
@qty, @pur_am, @sale_am,
@tax_id, @tax_am, @dis_am, @dis_per, 
@status, @date,
@adby, @addate, @flag,@return_date,@refund
)
END
GO

CREATE PROCEDURE Purchase_Order_Return_Detail_Delete
(
@id uniqueidentifier
)
AS
BEGIN
UPDATE Purchase_Order_Return_Details
SET flag=0
WHERE id= @id
END
GO

CREATE PROCEDURE Purchase_Order_Return_Detail_Update
(
@id uniqueidentifier, @purchase_order_return_id uniqueidentifier,
@product_id uniqueidentifier, @product_category_id uniqueidentifier, 
@qty int, @pur_am float, @sale_am float,  
@tax_id uniqueidentifier, @tax_am uniqueidentifier,@dis_am float, @dis_per int,
@status varchar(50), @date datetime,
@edit_by uniqueidentifier, @edit_date datetime,
@return_date datetime, @refund float
)
AS
BEGIN
UPDATE Purchase_Order_Return_Details
SET 
purchase_order_Return_id = @purchase_order_return_id, product_id= @product_id, product_category_id=@product_category_id,
quantity=@qty, purchase_amount=@pur_am, sale_amount=@sale_am,
tax_id=@tax_id, tax_amount=@tax_am, discount_amount=@dis_am, discount_percentage=@dis_per,
status = @status, date=@date, edit_by=@edit_by, edit_date= @edit_date,
return_date=@return_date,refund=@refund
WHERE id= @id
END
GO

CREATE PROCEDURE Purchase_Order_Return_Detail_FilterByDate
(@date1 datetime , @date2 datetime)
AS
BEGIN
SELECT * From Purchase_Order_Return_Details
WHERE date BETWEEN @date1 AND @date2
END
GO

CREATE PROCEDURE[dbo].[PurchaseParty_Delete]
(         @p_id uniqueidentifier     )  
AS    BEGIN       
update PurchaseParty 
set Flag = 0
WHERE   [party_id]=@p_id          
END
GO

CREATE PROCEDURE[dbo].[PurchaseParty_LOADALL]   
AS    BEGIN        
SELECT * FROM PurchaseParty      
Where Flag =1
END
GO

CREATE PROCEDURE[dbo].[PurchaseParty_Insert]     
(         @name varchar(max)  ,       @shortname varchar(max)  ,      
@code varchar(max)  ,       @description varchar(max)  ,      
@add varchar(max)  ,       @National_Tax_Number varchar(max)  ,  
@Goods_And_Services_Tax varchar(max)  ,       @Guarranty varchar(max)  ,  
@Standard_Report_Number varchar(max)  ,       @phone varchar(max)  ,   
@address varchar(max)  ,       @email varchar(max)  ,      
@Bank_account_number varchar(max)  ,       @International_Account_Number varchar(max)  , 
@status bit  , @adby varchar(50), @addate datetime, @flag int ,
@organization_id uniqueidentifier, @branch_id uniqueidentifier )
AS    BEGIN        
INSERT INTO PurchaseParty(     [name],     [shortname],     [code],   
[description],     [add],     [National_Tax_Number],   
[Goods_And_Services_Tax],     [Guarranty],     [Standard_Report_Number], 
[phone],     [address],     [email],     [Bank_account_number], 
[International_Account_Number], status , [Addby] , [AddDate],[Flag],
[organization_id],[branch_id]   )      
Values(     @name,     @shortname,     @code,     @description,     @add,  
@National_Tax_Number,     @Goods_And_Services_Tax,     @Guarranty,   
@Standard_Report_Number,     @phone,     @address,     @email,   
@Bank_account_number,     @International_Account_Number, @status,@adby, 
@addate,@flag, @organization_id, @branch_id    ) 
END

/****** Object:  StoredProcedure [dbo].[updateWithOldPassword]    Script Date: 16-Sep-19 8:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[updateWithOldPassword]
@oldPassword nvarchar(4000),
@password nvarchar(4000),
@id uniqueidentifier 
as
begin
update Users
set password = @password
where password = @oldPassword and User_id = @id;
end
GO
USE [master]
GO
ALTER DATABASE [SicParvisMagnaProduction] SET  READ_WRITE 
GO
