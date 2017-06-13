﻿USE [master]
GO
/****** Object:  Database [hair_salon_test]    Script Date: 6/11/2017 4:43:13 PM ******/
CREATE DATABASE [hair_salon_test]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'hair_salon', FILENAME = N'C:\Users\pdlaz\hair_salon_test.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'hair_salon_log', FILENAME = N'C:\Users\pdlaz\hair_salon_test_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [hair_salon_test] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [hair_salon_test].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [hair_salon_test] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [hair_salon_test] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [hair_salon_test] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [hair_salon_test] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [hair_salon_test] SET ARITHABORT OFF 
GO
ALTER DATABASE [hair_salon_test] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [hair_salon_test] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [hair_salon_test] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [hair_salon_test] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [hair_salon_test] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [hair_salon_test] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [hair_salon_test] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [hair_salon_test] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [hair_salon_test] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [hair_salon_test] SET  DISABLE_BROKER 
GO
ALTER DATABASE [hair_salon_test] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [hair_salon_test] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [hair_salon_test] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [hair_salon_test] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [hair_salon_test] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [hair_salon_test] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [hair_salon_test] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [hair_salon_test] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [hair_salon_test] SET  MULTI_USER 
GO
ALTER DATABASE [hair_salon_test] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [hair_salon_test] SET DB_CHAINING OFF 
GO
ALTER DATABASE [hair_salon_test] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [hair_salon_test] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [hair_salon_test] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [hair_salon_test] SET QUERY_STORE = OFF
GO
USE [hair_salon_test]
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
USE [hair_salon_test]
GO
/****** Object:  Table [dbo].[clients]    Script Date: 6/11/2017 4:43:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clients](
	[name] [varchar](255) NULL,
	[stylist_id] [int] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stylists]    Script Date: 6/11/2017 4:43:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stylists](
	[name] [varchar](255) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [hair_salon_test] SET  READ_WRITE 
GO
