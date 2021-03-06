USE [master]
GO
/****** Object:  Database [CINETOP]    Script Date: 3/11/2020 13:24:31 ******/
CREATE DATABASE [CINETOP]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CINETOP', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CINETOP.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CINETOP_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CINETOP_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CINETOP] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CINETOP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CINETOP] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CINETOP] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CINETOP] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CINETOP] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CINETOP] SET ARITHABORT OFF 
GO
ALTER DATABASE [CINETOP] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CINETOP] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CINETOP] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CINETOP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CINETOP] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CINETOP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CINETOP] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CINETOP] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CINETOP] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CINETOP] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CINETOP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CINETOP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CINETOP] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CINETOP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CINETOP] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CINETOP] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CINETOP] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CINETOP] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CINETOP] SET  MULTI_USER 
GO
ALTER DATABASE [CINETOP] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CINETOP] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CINETOP] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CINETOP] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CINETOP] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CINETOP] SET QUERY_STORE = OFF
GO
USE [CINETOP]
GO
/****** Object:  Table [dbo].[Actor]    Script Date: 3/11/2020 13:24:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Actor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NULL,
 CONSTRAINT [actor_id_pk] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ActoresXPelicula]    Script Date: 3/11/2020 13:24:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ActoresXPelicula](
	[id_pelicula] [int] NOT NULL,
	[id_actor] [int] NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [actoresxpelicula_pelicula_actor_pk] PRIMARY KEY CLUSTERED 
(
	[id_pelicula] ASC,
	[id_actor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CategoriaPremio]    Script Date: 3/11/2020 13:24:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoriaPremio](
	[id_premio] [int] NOT NULL,
	[id] [int] NOT NULL,
	[categoria] [varchar](100) NULL,
 CONSTRAINT [categoriapremio_id_pk] PRIMARY KEY CLUSTERED 
(
	[id_premio] ASC,
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Director]    Script Date: 3/11/2020 13:24:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Director](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [director_id_pk] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 3/11/2020 13:24:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[legajo] [int] NOT NULL,
	[id_tipoDoc] [int] NULL,
	[nroDoc] [bigint] NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[fechaIngreso] [date] NULL,
	[nombreUsuario] [varchar](30) NULL,
	[borrado] [bit] NOT NULL,
	[salario] [float] NULL,
 CONSTRAINT [empleado_legajo_pk] PRIMARY KEY CLUSTERED 
(
	[legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Epoca]    Script Date: 3/11/2020 13:24:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Epoca](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](100) NULL,
 CONSTRAINT [epoca_id_pk] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genero]    Script Date: 3/11/2020 13:24:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genero](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](100) NULL,
 CONSTRAINT [genero_id_pk] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GenerosXPelicula]    Script Date: 3/11/2020 13:24:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GenerosXPelicula](
	[id_pelicula] [int] NOT NULL,
	[id_genero] [int] NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [generosxpelicula_pelicula_genero_pk] PRIMARY KEY CLUSTERED 
(
	[id_pelicula] ASC,
	[id_genero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pais]    Script Date: 3/11/2020 13:24:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pais](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](100) NULL,
 CONSTRAINT [pais_id_pk] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pelicula]    Script Date: 3/11/2020 13:24:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pelicula](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[titulo] [varchar](100) NOT NULL,
	[id_director] [int] NULL,
	[duracion] [int] NOT NULL,
	[fechaEstreno] [date] NULL,
	[argumento] [varchar](400) NULL,
	[fechaFinProyeccion] [date] NULL,
	[id_pais] [int] NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [pelicula_id_pk] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Premio]    Script Date: 3/11/2020 13:24:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Premio](
	[id] [int] NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[descripcion] [varchar](100) NULL,
 CONSTRAINT [premio_id_pk] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PremiosXPelicula]    Script Date: 3/11/2020 13:24:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PremiosXPelicula](
	[id_pelicula] [int] NOT NULL,
	[id_premio] [int] NOT NULL,
	[id_categoria] [int] NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [premiosxpelicula_pelicula_premios_pk] PRIMARY KEY CLUSTERED 
(
	[id_pelicula] ASC,
	[id_premio] ASC,
	[id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Promo]    Script Date: 3/11/2020 13:24:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Promo](
	[id] [int] NOT NULL,
	[id_epoca] [int] NULL,
	[precio_menores] [float] NULL,
	[precio_mayores] [float] NULL,
	[vigencia_desde] [date] NULL,
	[vigencia_hasta] [date] NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [promo_id_pk] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sala]    Script Date: 3/11/2020 13:24:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sala](
	[nombre] [varchar](10) NOT NULL,
	[id_ubicacion] [int] NULL,
	[tiene3d] [bit] NOT NULL,
	[capacidad] [int] NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [sala_nombre_pk] PRIMARY KEY CLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoDocumento]    Script Date: 3/11/2020 13:24:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDocumento](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](100) NULL,
 CONSTRAINT [tipodocumento_id_pk] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ubicacion]    Script Date: 3/11/2020 13:24:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ubicacion](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](100) NULL,
 CONSTRAINT [ubicacion_id_pk] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 3/11/2020 13:24:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[nombre] [varchar](30) NOT NULL,
	[contraseña] [varchar](30) NULL,
 CONSTRAINT [usuario_nombre_pk] PRIMARY KEY CLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Actor] ON 

INSERT [dbo].[Actor] ([id], [nombre], [apellido]) VALUES (1, N'Austin', N'Powers')
INSERT [dbo].[Actor] ([id], [nombre], [apellido]) VALUES (2, N'Austin', N'Timberlake')
INSERT [dbo].[Actor] ([id], [nombre], [apellido]) VALUES (3, N'Adrian', N'Timberlake')
INSERT [dbo].[Actor] ([id], [nombre], [apellido]) VALUES (4, N'Adrian', N'Torres')
INSERT [dbo].[Actor] ([id], [nombre], [apellido]) VALUES (5, N'Adrian', N'Perez')
INSERT [dbo].[Actor] ([id], [nombre], [apellido]) VALUES (6, N'Antonio', N'Rivadero')
INSERT [dbo].[Actor] ([id], [nombre], [apellido]) VALUES (8, N'Lorena', N'Torres')
INSERT [dbo].[Actor] ([id], [nombre], [apellido]) VALUES (9, N'Kiryuu', N'Coco')
INSERT [dbo].[Actor] ([id], [nombre], [apellido]) VALUES (10, N'Antonio', N'Banderas')
INSERT [dbo].[Actor] ([id], [nombre], [apellido]) VALUES (11, N'Roberto', N'Gomez')
INSERT [dbo].[Actor] ([id], [nombre], [apellido]) VALUES (12, N'Roberto', N'Perez')
INSERT [dbo].[Actor] ([id], [nombre], [apellido]) VALUES (13, N'Leonardo', N'DiCaprio')
INSERT [dbo].[Actor] ([id], [nombre], [apellido]) VALUES (14, N'Mike', N'Towers')
INSERT [dbo].[Actor] ([id], [nombre], [apellido]) VALUES (15, N'Fernando', N'Caminos')
INSERT [dbo].[Actor] ([id], [nombre], [apellido]) VALUES (16, N'Agustin', N'Torres')
SET IDENTITY_INSERT [dbo].[Actor] OFF
GO
INSERT [dbo].[ActoresXPelicula] ([id_pelicula], [id_actor], [borrado]) VALUES (1, 1, 1)
INSERT [dbo].[ActoresXPelicula] ([id_pelicula], [id_actor], [borrado]) VALUES (1, 3, 1)
INSERT [dbo].[ActoresXPelicula] ([id_pelicula], [id_actor], [borrado]) VALUES (2, 1, 1)
INSERT [dbo].[ActoresXPelicula] ([id_pelicula], [id_actor], [borrado]) VALUES (2, 2, 1)
INSERT [dbo].[ActoresXPelicula] ([id_pelicula], [id_actor], [borrado]) VALUES (2, 3, 1)
INSERT [dbo].[ActoresXPelicula] ([id_pelicula], [id_actor], [borrado]) VALUES (2, 5, 1)
INSERT [dbo].[ActoresXPelicula] ([id_pelicula], [id_actor], [borrado]) VALUES (2, 6, 0)
INSERT [dbo].[ActoresXPelicula] ([id_pelicula], [id_actor], [borrado]) VALUES (2, 8, 0)
INSERT [dbo].[ActoresXPelicula] ([id_pelicula], [id_actor], [borrado]) VALUES (2, 12, 0)
INSERT [dbo].[ActoresXPelicula] ([id_pelicula], [id_actor], [borrado]) VALUES (4, 8, 1)
INSERT [dbo].[ActoresXPelicula] ([id_pelicula], [id_actor], [borrado]) VALUES (4, 9, 1)
INSERT [dbo].[ActoresXPelicula] ([id_pelicula], [id_actor], [borrado]) VALUES (5, 6, 0)
INSERT [dbo].[ActoresXPelicula] ([id_pelicula], [id_actor], [borrado]) VALUES (5, 9, 0)
INSERT [dbo].[ActoresXPelicula] ([id_pelicula], [id_actor], [borrado]) VALUES (6, 3, 0)
INSERT [dbo].[ActoresXPelicula] ([id_pelicula], [id_actor], [borrado]) VALUES (6, 10, 0)
INSERT [dbo].[ActoresXPelicula] ([id_pelicula], [id_actor], [borrado]) VALUES (8, 9, 0)
INSERT [dbo].[ActoresXPelicula] ([id_pelicula], [id_actor], [borrado]) VALUES (8, 10, 0)
INSERT [dbo].[ActoresXPelicula] ([id_pelicula], [id_actor], [borrado]) VALUES (9, 2, 0)
INSERT [dbo].[ActoresXPelicula] ([id_pelicula], [id_actor], [borrado]) VALUES (9, 8, 0)
INSERT [dbo].[ActoresXPelicula] ([id_pelicula], [id_actor], [borrado]) VALUES (9, 13, 0)
INSERT [dbo].[ActoresXPelicula] ([id_pelicula], [id_actor], [borrado]) VALUES (9, 14, 0)
INSERT [dbo].[ActoresXPelicula] ([id_pelicula], [id_actor], [borrado]) VALUES (10, 9, 0)
INSERT [dbo].[ActoresXPelicula] ([id_pelicula], [id_actor], [borrado]) VALUES (10, 13, 0)
INSERT [dbo].[ActoresXPelicula] ([id_pelicula], [id_actor], [borrado]) VALUES (10, 15, 0)
INSERT [dbo].[ActoresXPelicula] ([id_pelicula], [id_actor], [borrado]) VALUES (10, 16, 0)
INSERT [dbo].[ActoresXPelicula] ([id_pelicula], [id_actor], [borrado]) VALUES (11, 1, 0)
INSERT [dbo].[ActoresXPelicula] ([id_pelicula], [id_actor], [borrado]) VALUES (11, 9, 0)
INSERT [dbo].[ActoresXPelicula] ([id_pelicula], [id_actor], [borrado]) VALUES (11, 13, 0)
INSERT [dbo].[ActoresXPelicula] ([id_pelicula], [id_actor], [borrado]) VALUES (11, 14, 0)
INSERT [dbo].[ActoresXPelicula] ([id_pelicula], [id_actor], [borrado]) VALUES (11, 15, 0)
GO
INSERT [dbo].[CategoriaPremio] ([id_premio], [id], [categoria]) VALUES (1, 1, N'Mejor película')
INSERT [dbo].[CategoriaPremio] ([id_premio], [id], [categoria]) VALUES (1, 2, N'Mejor guión original')
INSERT [dbo].[CategoriaPremio] ([id_premio], [id], [categoria]) VALUES (1, 3, N'Mejor banda sonora')
INSERT [dbo].[CategoriaPremio] ([id_premio], [id], [categoria]) VALUES (2, 1, N'Palma de oro')
INSERT [dbo].[CategoriaPremio] ([id_premio], [id], [categoria]) VALUES (2, 2, N'Gran premio')
INSERT [dbo].[CategoriaPremio] ([id_premio], [id], [categoria]) VALUES (2, 3, N'Mejor guión')
INSERT [dbo].[CategoriaPremio] ([id_premio], [id], [categoria]) VALUES (3, 1, N'Mejor película de comedia')
INSERT [dbo].[CategoriaPremio] ([id_premio], [id], [categoria]) VALUES (3, 2, N'Mejor película de lengua no inglesa')
INSERT [dbo].[CategoriaPremio] ([id_premio], [id], [categoria]) VALUES (3, 3, N'Mejor banda sonora')
GO
SET IDENTITY_INSERT [dbo].[Director] ON 

INSERT [dbo].[Director] ([id], [nombre]) VALUES (1, N'James Cameron')
INSERT [dbo].[Director] ([id], [nombre]) VALUES (2, N'Jose paz')
INSERT [dbo].[Director] ([id], [nombre]) VALUES (3, N'Mauro Rivas')
INSERT [dbo].[Director] ([id], [nombre]) VALUES (5, N'Omaru Polka')
SET IDENTITY_INSERT [dbo].[Director] OFF
GO
INSERT [dbo].[Empleado] ([legajo], [id_tipoDoc], [nroDoc], [nombre], [apellido], [fechaIngreso], [nombreUsuario], [borrado], [salario]) VALUES (1, 1, 33707891, N'José Raul', N'Paz', CAST(N'2013-02-10' AS Date), N'JoseRaul', 0, 26000)
INSERT [dbo].[Empleado] ([legajo], [id_tipoDoc], [nroDoc], [nombre], [apellido], [fechaIngreso], [nombreUsuario], [borrado], [salario]) VALUES (2, 1, 29012015, N'Mariano', N'Lopez Ortega', CAST(N'2012-05-20' AS Date), N'Mariano', 0, 35500)
INSERT [dbo].[Empleado] ([legajo], [id_tipoDoc], [nroDoc], [nombre], [apellido], [fechaIngreso], [nombreUsuario], [borrado], [salario]) VALUES (6, 1, 34444901, N'Alberto', N'Martinez', CAST(N'2016-07-14' AS Date), N'albert', 0, 33450)
INSERT [dbo].[Empleado] ([legajo], [id_tipoDoc], [nroDoc], [nombre], [apellido], [fechaIngreso], [nombreUsuario], [borrado], [salario]) VALUES (7, 3, 100239204, N'Carlos Luis', N'Ochoa', CAST(N'2015-11-19' AS Date), N'carlitos', 0, 39000)
INSERT [dbo].[Empleado] ([legajo], [id_tipoDoc], [nroDoc], [nombre], [apellido], [fechaIngreso], [nombreUsuario], [borrado], [salario]) VALUES (11, 2, 20334041022, N'Ricardo', N'Rico', CAST(N'2020-10-01' AS Date), N'admin', 0, 50250)
INSERT [dbo].[Empleado] ([legajo], [id_tipoDoc], [nroDoc], [nombre], [apellido], [fechaIngreso], [nombreUsuario], [borrado], [salario]) VALUES (22322, 1, 20303021, N'Juan', N'Perez', CAST(N'2012-06-20' AS Date), N'JkMart', 0, 43000)
INSERT [dbo].[Empleado] ([legajo], [id_tipoDoc], [nroDoc], [nombre], [apellido], [fechaIngreso], [nombreUsuario], [borrado], [salario]) VALUES (22323, 1, 20303022, N'Eduardo', N'Gomez', CAST(N'2012-01-30' AS Date), N'EdGomez', 0, 22000)
INSERT [dbo].[Empleado] ([legajo], [id_tipoDoc], [nroDoc], [nombre], [apellido], [fechaIngreso], [nombreUsuario], [borrado], [salario]) VALUES (22324, 1, 20303023, N'Roberto', N'Benitez', CAST(N'2012-09-20' AS Date), N'AM7Trent', 0, 32440)
INSERT [dbo].[Empleado] ([legajo], [id_tipoDoc], [nroDoc], [nombre], [apellido], [fechaIngreso], [nombreUsuario], [borrado], [salario]) VALUES (22325, 1, 20303024, N'Ernesto', N'Dominguez', CAST(N'2017-01-12' AS Date), N'User07', 0, 44500)
INSERT [dbo].[Empleado] ([legajo], [id_tipoDoc], [nroDoc], [nombre], [apellido], [fechaIngreso], [nombreUsuario], [borrado], [salario]) VALUES (22326, 1, 20303019, N'Pablo', N'Ramirez', CAST(N'2012-05-20' AS Date), N'PabloR', 0, 32300)
INSERT [dbo].[Empleado] ([legajo], [id_tipoDoc], [nroDoc], [nombre], [apellido], [fechaIngreso], [nombreUsuario], [borrado], [salario]) VALUES (22327, 1, 20303025, N'Emilia', N'Fernandez', CAST(N'2017-01-13' AS Date), N'User12', 0, 26000)
INSERT [dbo].[Empleado] ([legajo], [id_tipoDoc], [nroDoc], [nombre], [apellido], [fechaIngreso], [nombreUsuario], [borrado], [salario]) VALUES (22328, 1, 20303026, N'Tiburcio', N'Nieto', CAST(N'2018-07-21' AS Date), N'TibNieto', 0, 28200)
GO
INSERT [dbo].[Epoca] ([id], [nombre], [descripcion]) VALUES (1, N'Verano', N'Vacaciones de verano, comprendida entre Diciembre-Febrero')
INSERT [dbo].[Epoca] ([id], [nombre], [descripcion]) VALUES (2, N'Vacaciones Invierno', N'Vacaciones de invierno, mes de Julio')
INSERT [dbo].[Epoca] ([id], [nombre], [descripcion]) VALUES (3, N'Primavera', N'Mes de la primavera, mes de Septiembre')
INSERT [dbo].[Epoca] ([id], [nombre], [descripcion]) VALUES (4, N'Dia del niño', N'Semana de dia del niño, tercera semana de agosto')
GO
INSERT [dbo].[Genero] ([id], [nombre], [descripcion]) VALUES (1, N'Comedia', N'Peliculas con situaciones humoristicas')
INSERT [dbo].[Genero] ([id], [nombre], [descripcion]) VALUES (2, N'Terror', N'Peliculas que buscan generar miedo al espectador')
INSERT [dbo].[Genero] ([id], [nombre], [descripcion]) VALUES (3, N'Accion', N'Peliculas que muestran situaciones de accion')
INSERT [dbo].[Genero] ([id], [nombre], [descripcion]) VALUES (4, N'Documental', N'Peliculas de no ficción que buscan informar sobre un tema')
INSERT [dbo].[Genero] ([id], [nombre], [descripcion]) VALUES (5, N'Aventura', N'Peliculas que presentan personajes enfrentandose a situaciones trepidantes')
INSERT [dbo].[Genero] ([id], [nombre], [descripcion]) VALUES (6, N'Ciencia ficcion', N'Peliculas con elementos fantásticos futuristas')
INSERT [dbo].[Genero] ([id], [nombre], [descripcion]) VALUES (7, N'Policial', N'Peliculas que presentan un acto criminal cuyos detalles van a ir descubriendose')
GO
INSERT [dbo].[GenerosXPelicula] ([id_pelicula], [id_genero], [borrado]) VALUES (1, 1, 1)
INSERT [dbo].[GenerosXPelicula] ([id_pelicula], [id_genero], [borrado]) VALUES (1, 2, 1)
INSERT [dbo].[GenerosXPelicula] ([id_pelicula], [id_genero], [borrado]) VALUES (2, 1, 0)
INSERT [dbo].[GenerosXPelicula] ([id_pelicula], [id_genero], [borrado]) VALUES (2, 2, 0)
INSERT [dbo].[GenerosXPelicula] ([id_pelicula], [id_genero], [borrado]) VALUES (2, 3, 0)
INSERT [dbo].[GenerosXPelicula] ([id_pelicula], [id_genero], [borrado]) VALUES (4, 1, 1)
INSERT [dbo].[GenerosXPelicula] ([id_pelicula], [id_genero], [borrado]) VALUES (5, 1, 0)
INSERT [dbo].[GenerosXPelicula] ([id_pelicula], [id_genero], [borrado]) VALUES (6, 3, 0)
INSERT [dbo].[GenerosXPelicula] ([id_pelicula], [id_genero], [borrado]) VALUES (8, 4, 0)
INSERT [dbo].[GenerosXPelicula] ([id_pelicula], [id_genero], [borrado]) VALUES (8, 7, 0)
INSERT [dbo].[GenerosXPelicula] ([id_pelicula], [id_genero], [borrado]) VALUES (9, 1, 0)
INSERT [dbo].[GenerosXPelicula] ([id_pelicula], [id_genero], [borrado]) VALUES (9, 3, 0)
INSERT [dbo].[GenerosXPelicula] ([id_pelicula], [id_genero], [borrado]) VALUES (9, 5, 0)
INSERT [dbo].[GenerosXPelicula] ([id_pelicula], [id_genero], [borrado]) VALUES (10, 2, 0)
INSERT [dbo].[GenerosXPelicula] ([id_pelicula], [id_genero], [borrado]) VALUES (10, 6, 0)
INSERT [dbo].[GenerosXPelicula] ([id_pelicula], [id_genero], [borrado]) VALUES (11, 1, 0)
GO
INSERT [dbo].[Pais] ([id], [nombre], [descripcion]) VALUES (1, N'Argentina', N'Pais latinoamericano de habla hispana')
INSERT [dbo].[Pais] ([id], [nombre], [descripcion]) VALUES (2, N'EEUU', N'Estados unidos, país norteamericano')
INSERT [dbo].[Pais] ([id], [nombre], [descripcion]) VALUES (3, N'España', N'País europeo')
INSERT [dbo].[Pais] ([id], [nombre], [descripcion]) VALUES (4, N'Brasil', N'Pais latinoamericano de habla portuguesa')
GO
SET IDENTITY_INSERT [dbo].[Pelicula] ON 

INSERT [dbo].[Pelicula] ([id], [titulo], [id_director], [duracion], [fechaEstreno], [argumento], [fechaFinProyeccion], [id_pais], [borrado]) VALUES (1, N'La cosa', 1, 100, CAST(N'2020-08-31' AS Date), NULL, CAST(N'2020-10-11' AS Date), 1, 1)
INSERT [dbo].[Pelicula] ([id], [titulo], [id_director], [duracion], [fechaEstreno], [argumento], [fechaFinProyeccion], [id_pais], [borrado]) VALUES (2, N'Titanic', 3, 219, CAST(N'2020-10-11' AS Date), N'Un barco se hunde', CAST(N'2020-10-20' AS Date), 2, 0)
INSERT [dbo].[Pelicula] ([id], [titulo], [id_director], [duracion], [fechaEstreno], [argumento], [fechaFinProyeccion], [id_pais], [borrado]) VALUES (4, N'Lorem Ipsum', 5, 20, CAST(N'2020-10-01' AS Date), N'Funny fennec', CAST(N'2020-10-31' AS Date), 4, 1)
INSERT [dbo].[Pelicula] ([id], [titulo], [id_director], [duracion], [fechaEstreno], [argumento], [fechaFinProyeccion], [id_pais], [borrado]) VALUES (5, N'Ejemplo', 5, 100, CAST(N'2020-10-12' AS Date), N'Not a clown but the whole circus', CAST(N'2020-10-12' AS Date), 3, 0)
INSERT [dbo].[Pelicula] ([id], [titulo], [id_director], [duracion], [fechaEstreno], [argumento], [fechaFinProyeccion], [id_pais], [borrado]) VALUES (6, N'Avatar', 1, 200, CAST(N'2020-10-01' AS Date), N'Lorem ipsum', CAST(N'2020-10-29' AS Date), 3, 0)
INSERT [dbo].[Pelicula] ([id], [titulo], [id_director], [duracion], [fechaEstreno], [argumento], [fechaFinProyeccion], [id_pais], [borrado]) VALUES (8, N'La muerte del doctor', 5, 100, CAST(N'2020-02-12' AS Date), N'Un doctor neozelandes muere por causas desconocidas en una situación peculiar', CAST(N'2020-03-01' AS Date), 2, 0)
INSERT [dbo].[Pelicula] ([id], [titulo], [id_director], [duracion], [fechaEstreno], [argumento], [fechaFinProyeccion], [id_pais], [borrado]) VALUES (9, N'Zatura', 2, 132, CAST(N'2019-11-19' AS Date), N'Un juego de mesa con temática espacial resulta ser más de lo que aparenta ser', CAST(N'2019-12-11' AS Date), 3, 0)
INSERT [dbo].[Pelicula] ([id], [titulo], [id_director], [duracion], [fechaEstreno], [argumento], [fechaFinProyeccion], [id_pais], [borrado]) VALUES (10, N'Alien, el octavo pasajero', 1, 157, CAST(N'2020-09-16' AS Date), N'Un grupo de astronautas es enviado a una estación espacial luego de sufrir un extraño accidente, lo que encuentran no es de este mundo', CAST(N'2020-11-02' AS Date), 2, 0)
INSERT [dbo].[Pelicula] ([id], [titulo], [id_director], [duracion], [fechaEstreno], [argumento], [fechaFinProyeccion], [id_pais], [borrado]) VALUES (11, N'American pie', 5, 111, CAST(N'2020-10-06' AS Date), N'Luego de varios años, un grupo de personas que eran amigos en la secundaria se reunen para festejar', CAST(N'2020-10-31' AS Date), 4, 0)
SET IDENTITY_INSERT [dbo].[Pelicula] OFF
GO
INSERT [dbo].[Premio] ([id], [nombre], [descripcion]) VALUES (1, N'Premio Oscar', N'Premio otorgado por la academia')
INSERT [dbo].[Premio] ([id], [nombre], [descripcion]) VALUES (2, N'Festival de cannes', N'Premio otorgado en el festival de cannes')
INSERT [dbo].[Premio] ([id], [nombre], [descripcion]) VALUES (3, N'Globo de oro', N'Premio otorgado por la prensa de hollywood')
GO
INSERT [dbo].[PremiosXPelicula] ([id_pelicula], [id_premio], [id_categoria], [borrado]) VALUES (1, 1, 1, 1)
INSERT [dbo].[PremiosXPelicula] ([id_pelicula], [id_premio], [id_categoria], [borrado]) VALUES (1, 2, 2, 1)
INSERT [dbo].[PremiosXPelicula] ([id_pelicula], [id_premio], [id_categoria], [borrado]) VALUES (2, 1, 1, 0)
INSERT [dbo].[PremiosXPelicula] ([id_pelicula], [id_premio], [id_categoria], [borrado]) VALUES (2, 1, 2, 1)
INSERT [dbo].[PremiosXPelicula] ([id_pelicula], [id_premio], [id_categoria], [borrado]) VALUES (2, 1, 3, 0)
INSERT [dbo].[PremiosXPelicula] ([id_pelicula], [id_premio], [id_categoria], [borrado]) VALUES (2, 2, 3, 1)
INSERT [dbo].[PremiosXPelicula] ([id_pelicula], [id_premio], [id_categoria], [borrado]) VALUES (2, 3, 3, 0)
INSERT [dbo].[PremiosXPelicula] ([id_pelicula], [id_premio], [id_categoria], [borrado]) VALUES (5, 3, 1, 0)
INSERT [dbo].[PremiosXPelicula] ([id_pelicula], [id_premio], [id_categoria], [borrado]) VALUES (9, 2, 3, 0)
INSERT [dbo].[PremiosXPelicula] ([id_pelicula], [id_premio], [id_categoria], [borrado]) VALUES (10, 1, 1, 0)
INSERT [dbo].[PremiosXPelicula] ([id_pelicula], [id_premio], [id_categoria], [borrado]) VALUES (10, 1, 3, 0)
GO
INSERT [dbo].[Promo] ([id], [id_epoca], [precio_menores], [precio_mayores], [vigencia_desde], [vigencia_hasta], [borrado]) VALUES (1, 4, 120, 0, CAST(N'2020-08-14' AS Date), CAST(N'2020-08-17' AS Date), 0)
INSERT [dbo].[Promo] ([id], [id_epoca], [precio_menores], [precio_mayores], [vigencia_desde], [vigencia_hasta], [borrado]) VALUES (2, 1, 140, 180, CAST(N'2021-01-01' AS Date), CAST(N'2021-01-20' AS Date), 0)
INSERT [dbo].[Promo] ([id], [id_epoca], [precio_menores], [precio_mayores], [vigencia_desde], [vigencia_hasta], [borrado]) VALUES (3, 3, 100, 100, CAST(N'2020-09-21' AS Date), CAST(N'2020-09-30' AS Date), 1)
INSERT [dbo].[Promo] ([id], [id_epoca], [precio_menores], [precio_mayores], [vigencia_desde], [vigencia_hasta], [borrado]) VALUES (4, 3, 110, 145.5, CAST(N'2020-09-21' AS Date), CAST(N'2020-09-30' AS Date), 0)
GO
INSERT [dbo].[Sala] ([nombre], [id_ubicacion], [tiene3d], [capacidad], [borrado]) VALUES (N'A1', 1, 1, 50, 0)
INSERT [dbo].[Sala] ([nombre], [id_ubicacion], [tiene3d], [capacidad], [borrado]) VALUES (N'A2', 2, 0, 1, 1)
INSERT [dbo].[Sala] ([nombre], [id_ubicacion], [tiene3d], [capacidad], [borrado]) VALUES (N'A3', 1, 0, 65, 0)
INSERT [dbo].[Sala] ([nombre], [id_ubicacion], [tiene3d], [capacidad], [borrado]) VALUES (N'A4', 1, 0, 54, 0)
INSERT [dbo].[Sala] ([nombre], [id_ubicacion], [tiene3d], [capacidad], [borrado]) VALUES (N'B1', 2, 1, 40, 0)
INSERT [dbo].[Sala] ([nombre], [id_ubicacion], [tiene3d], [capacidad], [borrado]) VALUES (N'B2', 3, 1, 60, 0)
INSERT [dbo].[Sala] ([nombre], [id_ubicacion], [tiene3d], [capacidad], [borrado]) VALUES (N'B3', 3, 1, 64, 0)
INSERT [dbo].[Sala] ([nombre], [id_ubicacion], [tiene3d], [capacidad], [borrado]) VALUES (N'B4', 4, 0, 50, 0)
INSERT [dbo].[Sala] ([nombre], [id_ubicacion], [tiene3d], [capacidad], [borrado]) VALUES (N'BA', 5, 0, 2, 1)
INSERT [dbo].[Sala] ([nombre], [id_ubicacion], [tiene3d], [capacidad], [borrado]) VALUES (N'S1', 5, 0, 48, 0)
INSERT [dbo].[Sala] ([nombre], [id_ubicacion], [tiene3d], [capacidad], [borrado]) VALUES (N'S2', 5, 1, 70, 0)
GO
INSERT [dbo].[TipoDocumento] ([id], [nombre], [descripcion]) VALUES (1, N'DNI', N'Documento nacional de identidad de la republica Argentina')
INSERT [dbo].[TipoDocumento] ([id], [nombre], [descripcion]) VALUES (2, N'CUIT', N'Clave unica de identificacion tributaria')
INSERT [dbo].[TipoDocumento] ([id], [nombre], [descripcion]) VALUES (3, N'Pasaporte', N'Numero de pasaporte (para extranjeros sin nacionalidad tramitada)')
GO
INSERT [dbo].[Ubicacion] ([id], [nombre], [descripcion]) VALUES (1, N'Planta baja - Ala este', N'Sector este de la planta baja')
INSERT [dbo].[Ubicacion] ([id], [nombre], [descripcion]) VALUES (2, N'Planta baja - Ala oeste', N'Sector oeste de la planta baja')
INSERT [dbo].[Ubicacion] ([id], [nombre], [descripcion]) VALUES (3, N'Primer piso - Ala este', N'Sector este del primer piso')
INSERT [dbo].[Ubicacion] ([id], [nombre], [descripcion]) VALUES (4, N'Primer piso - Ala oeste', N'Sector oeste del primer piso')
INSERT [dbo].[Ubicacion] ([id], [nombre], [descripcion]) VALUES (5, N'Subsuelo', N'Único sector del subsuelo')
GO
INSERT [dbo].[Usuario] ([nombre], [contraseña]) VALUES (N'admin', N'admin')
INSERT [dbo].[Usuario] ([nombre], [contraseña]) VALUES (N'albert', N'4lb3rt0')
INSERT [dbo].[Usuario] ([nombre], [contraseña]) VALUES (N'AM7Trent', N'102Morning')
INSERT [dbo].[Usuario] ([nombre], [contraseña]) VALUES (N'carlitos', N'C4RL0S22')
INSERT [dbo].[Usuario] ([nombre], [contraseña]) VALUES (N'EdGomez', N'contraseña')
INSERT [dbo].[Usuario] ([nombre], [contraseña]) VALUES (N'Horacio', N'32guarani32')
INSERT [dbo].[Usuario] ([nombre], [contraseña]) VALUES (N'JkMart', N'KJ33U')
INSERT [dbo].[Usuario] ([nombre], [contraseña]) VALUES (N'JoseRaul', N'pepito123')
INSERT [dbo].[Usuario] ([nombre], [contraseña]) VALUES (N'Mariano', N'9B@11')
INSERT [dbo].[Usuario] ([nombre], [contraseña]) VALUES (N'PabloR', N'incorrecta')
INSERT [dbo].[Usuario] ([nombre], [contraseña]) VALUES (N'TibNieto', N'nieto123')
INSERT [dbo].[Usuario] ([nombre], [contraseña]) VALUES (N'User07', N'abcd1234')
INSERT [dbo].[Usuario] ([nombre], [contraseña]) VALUES (N'User12', N'25122012')
GO
ALTER TABLE [dbo].[ActoresXPelicula]  WITH CHECK ADD  CONSTRAINT [actoresxpelicula_actor_fk] FOREIGN KEY([id_actor])
REFERENCES [dbo].[Actor] ([id])
GO
ALTER TABLE [dbo].[ActoresXPelicula] CHECK CONSTRAINT [actoresxpelicula_actor_fk]
GO
ALTER TABLE [dbo].[ActoresXPelicula]  WITH CHECK ADD  CONSTRAINT [actoresxpelicula_pelicula_fk] FOREIGN KEY([id_pelicula])
REFERENCES [dbo].[Pelicula] ([id])
GO
ALTER TABLE [dbo].[ActoresXPelicula] CHECK CONSTRAINT [actoresxpelicula_pelicula_fk]
GO
ALTER TABLE [dbo].[CategoriaPremio]  WITH CHECK ADD  CONSTRAINT [categoriapremio_premio_fk] FOREIGN KEY([id_premio])
REFERENCES [dbo].[Premio] ([id])
GO
ALTER TABLE [dbo].[CategoriaPremio] CHECK CONSTRAINT [categoriapremio_premio_fk]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [empleado_tipodoc_fk] FOREIGN KEY([id_tipoDoc])
REFERENCES [dbo].[TipoDocumento] ([id])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [empleado_tipodoc_fk]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [empleado_usuario_fk] FOREIGN KEY([nombreUsuario])
REFERENCES [dbo].[Usuario] ([nombre])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [empleado_usuario_fk]
GO
ALTER TABLE [dbo].[GenerosXPelicula]  WITH CHECK ADD  CONSTRAINT [generosxpelicula_genero_fk] FOREIGN KEY([id_genero])
REFERENCES [dbo].[Genero] ([id])
GO
ALTER TABLE [dbo].[GenerosXPelicula] CHECK CONSTRAINT [generosxpelicula_genero_fk]
GO
ALTER TABLE [dbo].[GenerosXPelicula]  WITH CHECK ADD  CONSTRAINT [generosxpelicula_pelicula_fk] FOREIGN KEY([id_pelicula])
REFERENCES [dbo].[Pelicula] ([id])
GO
ALTER TABLE [dbo].[GenerosXPelicula] CHECK CONSTRAINT [generosxpelicula_pelicula_fk]
GO
ALTER TABLE [dbo].[Pelicula]  WITH CHECK ADD  CONSTRAINT [pelicula_director_fk] FOREIGN KEY([id_director])
REFERENCES [dbo].[Director] ([id])
GO
ALTER TABLE [dbo].[Pelicula] CHECK CONSTRAINT [pelicula_director_fk]
GO
ALTER TABLE [dbo].[Pelicula]  WITH CHECK ADD  CONSTRAINT [pelicula_pais_fk] FOREIGN KEY([id_pais])
REFERENCES [dbo].[Pais] ([id])
GO
ALTER TABLE [dbo].[Pelicula] CHECK CONSTRAINT [pelicula_pais_fk]
GO
ALTER TABLE [dbo].[PremiosXPelicula]  WITH CHECK ADD  CONSTRAINT [premiosxpelicula_pelicula_fk] FOREIGN KEY([id_pelicula])
REFERENCES [dbo].[Pelicula] ([id])
GO
ALTER TABLE [dbo].[PremiosXPelicula] CHECK CONSTRAINT [premiosxpelicula_pelicula_fk]
GO
ALTER TABLE [dbo].[PremiosXPelicula]  WITH CHECK ADD  CONSTRAINT [premiosxpelicula_premio_categoria_fk] FOREIGN KEY([id_premio], [id_categoria])
REFERENCES [dbo].[CategoriaPremio] ([id_premio], [id])
GO
ALTER TABLE [dbo].[PremiosXPelicula] CHECK CONSTRAINT [premiosxpelicula_premio_categoria_fk]
GO
ALTER TABLE [dbo].[Promo]  WITH CHECK ADD  CONSTRAINT [promo_epoca_fk] FOREIGN KEY([id_epoca])
REFERENCES [dbo].[Epoca] ([id])
GO
ALTER TABLE [dbo].[Promo] CHECK CONSTRAINT [promo_epoca_fk]
GO
ALTER TABLE [dbo].[Sala]  WITH CHECK ADD  CONSTRAINT [sala_ubicacion_fk] FOREIGN KEY([id_ubicacion])
REFERENCES [dbo].[Ubicacion] ([id])
GO
ALTER TABLE [dbo].[Sala] CHECK CONSTRAINT [sala_ubicacion_fk]
GO
USE [master]
GO
ALTER DATABASE [CINETOP] SET  READ_WRITE 
GO
