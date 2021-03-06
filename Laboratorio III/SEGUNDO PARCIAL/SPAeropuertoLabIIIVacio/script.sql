USE [master]
GO
CREATE DATABASE [AeropuertoDB] ON  PRIMARY 
( NAME = N'AeropuertoDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\AeropuertoDB.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'AeropuertoDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\AeropuertoDB_log.LDF' , SIZE = 576KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [AeropuertoDB] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AeropuertoDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AeropuertoDB] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [AeropuertoDB] SET ANSI_NULLS OFF
GO
ALTER DATABASE [AeropuertoDB] SET ANSI_PADDING OFF
GO
ALTER DATABASE [AeropuertoDB] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [AeropuertoDB] SET ARITHABORT OFF
GO
ALTER DATABASE [AeropuertoDB] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [AeropuertoDB] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [AeropuertoDB] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [AeropuertoDB] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [AeropuertoDB] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [AeropuertoDB] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [AeropuertoDB] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [AeropuertoDB] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [AeropuertoDB] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [AeropuertoDB] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [AeropuertoDB] SET  ENABLE_BROKER
GO
ALTER DATABASE [AeropuertoDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [AeropuertoDB] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [AeropuertoDB] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [AeropuertoDB] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [AeropuertoDB] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [AeropuertoDB] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [AeropuertoDB] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [AeropuertoDB] SET  READ_WRITE
GO
ALTER DATABASE [AeropuertoDB] SET RECOVERY FULL
GO
ALTER DATABASE [AeropuertoDB] SET  MULTI_USER
GO
ALTER DATABASE [AeropuertoDB] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [AeropuertoDB] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'AeropuertoDB', N'ON'
GO
USE [AeropuertoDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[Aviones](
	[Matricula_Avion] [int] NOT NULL,
	[Marca_Avion] [varchar](50) NOT NULL,
	[Modelo_Avion] [varchar](50) NOT NULL,
	[Capacidad_Avion] [int] NOT NULL,
	[codigoVuelo] [int] NOT NULL,
 CONSTRAINT [PK_Aviones] PRIMARY KEY CLUSTERED 
(
	[Matricula_Avion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Aviones] ([Matricula_Avion], [Marca_Avion], [Modelo_Avion], [Capacidad_Avion], [codigoVuelo]) VALUES (1236, N'Boeing', N'747', 555, 1005)
INSERT [dbo].[Aviones] ([Matricula_Avion], [Marca_Avion], [Modelo_Avion], [Capacidad_Avion], [codigoVuelo]) VALUES (1254, N'Boeing', N'737', 162, 1000)
INSERT [dbo].[Aviones] ([Matricula_Avion], [Marca_Avion], [Modelo_Avion], [Capacidad_Avion], [codigoVuelo]) VALUES (1255, N'Learjet', N'35', 7, 1020)
INSERT [dbo].[Aviones] ([Matricula_Avion], [Marca_Avion], [Modelo_Avion], [Capacidad_Avion], [codigoVuelo]) VALUES (1487, N'Airbus', N'A380', 853, 1015)
INSERT [dbo].[Aviones] ([Matricula_Avion], [Marca_Avion], [Modelo_Avion], [Capacidad_Avion], [codigoVuelo]) VALUES (1548, N'Airbus', N'A320', 220, 1010)
INSERT [dbo].[Aviones] ([Matricula_Avion], [Marca_Avion], [Modelo_Avion], [Capacidad_Avion], [codigoVuelo]) VALUES (4521, N'Airbus', N'A320', 220, 1000)
