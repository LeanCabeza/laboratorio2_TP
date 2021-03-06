USE [master]
GO
/****** Object:  Database [Concesionario]    Script Date: 29/11/2020 2:56:07 ******/
CREATE DATABASE [Concesionario]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Concesionario', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Concesionario.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Concesionario_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Concesionario_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Concesionario] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Concesionario].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Concesionario] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Concesionario] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Concesionario] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Concesionario] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Concesionario] SET ARITHABORT OFF 
GO
ALTER DATABASE [Concesionario] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Concesionario] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Concesionario] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Concesionario] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Concesionario] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Concesionario] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Concesionario] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Concesionario] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Concesionario] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Concesionario] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Concesionario] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Concesionario] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Concesionario] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Concesionario] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Concesionario] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Concesionario] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Concesionario] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Concesionario] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Concesionario] SET  MULTI_USER 
GO
ALTER DATABASE [Concesionario] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Concesionario] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Concesionario] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Concesionario] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Concesionario] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Concesionario] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Concesionario] SET QUERY_STORE = OFF
GO
USE [Concesionario]
GO
/****** Object:  Table [dbo].[Autos]    Script Date: 29/11/2020 2:56:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Autos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NombreVehiculo] [nvarchar](50) NOT NULL,
	[Precio] [int] NOT NULL,
	[Anio] [int] NOT NULL,
	[Kilometraje] [int] NOT NULL,
	[Marca] [nvarchar](50) NOT NULL,
	[Tipo Motor] [nvarchar](50) NOT NULL,
	[Caballos de fuerza] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Motos]    Script Date: 29/11/2020 2:56:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Motos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Modelo] [nvarchar](50) NULL,
	[Precio] [int] NULL,
	[Anio] [int] NULL,
	[Kilometraje] [int] NULL,
	[Marca] [nvarchar](50) NULL,
	[Encendido] [nvarchar](50) NULL,
	[Cilindrada] [int] NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [Concesionario] SET  READ_WRITE 
GO
