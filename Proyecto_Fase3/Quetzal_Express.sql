USE [master]
GO
/****** Object:  Database [Quetzal_Express]    Script Date: 23/06/2015 5:22:03 a. m. ******/
CREATE DATABASE [Quetzal_Express]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Quetzal_Express', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Quetzal_Express.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Quetzal_Express_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Quetzal_Express_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Quetzal_Express] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Quetzal_Express].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Quetzal_Express] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Quetzal_Express] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Quetzal_Express] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Quetzal_Express] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Quetzal_Express] SET ARITHABORT OFF 
GO
ALTER DATABASE [Quetzal_Express] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Quetzal_Express] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Quetzal_Express] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Quetzal_Express] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Quetzal_Express] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Quetzal_Express] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Quetzal_Express] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Quetzal_Express] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Quetzal_Express] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Quetzal_Express] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Quetzal_Express] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Quetzal_Express] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Quetzal_Express] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Quetzal_Express] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Quetzal_Express] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Quetzal_Express] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Quetzal_Express] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Quetzal_Express] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Quetzal_Express] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Quetzal_Express] SET  MULTI_USER 
GO
ALTER DATABASE [Quetzal_Express] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Quetzal_Express] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Quetzal_Express] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Quetzal_Express] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Quetzal_Express]
GO
/****** Object:  StoredProcedure [dbo].[emp_suc]    Script Date: 23/06/2015 5:22:04 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[emp_suc]
@sucs int
as
BEGIN
SELECT p.ID_empleado, e.Nombre,e.Apellido,p.Cargo,s.Pais,s.Direccion,d.Nombre
FROM Empleado e, Planilla p, Registro r, Sucursal s , Departamento d
WHERE e.ID_Empleado = p.ID_empleado AND p.Departamento = r.no_registro AND s.Serie_Suc = r.sede_id AND d.Serie_dept = r.depto_id AND s.Serie_Suc = @sucs
END
GO
/****** Object:  StoredProcedure [dbo].[emp_suc_depto]    Script Date: 23/06/2015 5:22:04 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[emp_suc_depto]
@depto int,
@sucu int
AS
BEGIN
SELECT p.ID_empleado, e.Nombre,e.Apellido,p.Cargo,s.Pais,s.Direccion,d.Nombre
FROM Empleado e, Planilla p, Registro r, Sucursal s , Departamento d
WHERE e.ID_Empleado = p.ID_empleado AND p.Departamento = r.no_registro AND s.Serie_Suc = r.sede_id AND d.Serie_dept = r.depto_id AND r.depto_id = @depto AND s.Serie_Suc = @sucu
END
GO
/****** Object:  StoredProcedure [dbo].[Listado]    Script Date: 23/06/2015 5:22:04 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Listado]
	@depto int

AS
	

	SELECT p.ID_empleado, e.Nombre, e.Apellido, p.Sueldo
	FROM Planilla AS p , Empleado AS e
	WHERE P.ID_empleado = E.ID_Empleado AND p.Departamento = @depto


GO
/****** Object:  StoredProcedure [dbo].[Listados]    Script Date: 23/06/2015 5:22:04 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Listados]
@depto int
AS
SELECT	e.ID_Empleado,e.Nombre , e.Apellido , p.Sueldo
FROM Empleado e , Planilla p , Registro r , Departamento d, Sucursal s 
WHERE	 e.ID_Empleado = p.ID_empleado AND p.Departamento = r.no_registro AND r.depto_id = d.Serie_dept AND r.sede_id = s.Serie_Suc AND p.Departamento = @depto

GO
/****** Object:  StoredProcedure [dbo].[pac]    Script Date: 23/06/2015 5:22:04 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pac]
@casint as int	
AS
SELECT p.ID_paquete,i.Nombre,p.Peso_lb,p.Precio
FROM Paquete p, Impuesto i
WHERE p.Estado ='En stock' AND p.Cliente = @casint AND p.Categoria = i.Serie_imp
GO
/****** Object:  StoredProcedure [dbo].[pacc]    Script Date: 23/06/2015 5:22:04 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pacc]
@dpi as int	
as
BEGIN	
SELECT p.ID_paquete,p.Categoria,p.Peso_lb,p.Precio,p.Estado
FROM Paquete p
WHERE	 p.Cliente =@dpi
END	
GO
/****** Object:  StoredProcedure [dbo].[pacs]    Script Date: 23/06/2015 5:22:04 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pacs]
@casint as int	
AS
SELECT p.ID_paquete,p.Categoria,p.Peso_lb,p.Precio
FROM Paquete p 
WHERE p.Estado ='En stock' AND p.Cliente = @casint
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 23/06/2015 5:22:04 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente](
	[DPI] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[NIT] [int] NOT NULL,
	[Telefono] [int] NOT NULL,
	[Direccion_domiciliar] [varchar](50) NOT NULL,
	[Cas_Int] [int] NULL,
	[Tarjeta_asociada] [int] NOT NULL,
	[Nombre_usuario] [varchar](50) NOT NULL,
	[Contraseña] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[DPI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Departamento]    Script Date: 23/06/2015 5:22:05 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Departamento](
	[Serie_dept] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Director] [int] NULL,
 CONSTRAINT [PK_Departamento] PRIMARY KEY CLUSTERED 
(
	[Serie_dept] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 23/06/2015 5:22:05 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleado](
	[ID_Empleado] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[DPI] [int] NOT NULL,
	[Telefono] [int] NOT NULL,
	[Domicilio] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[ID_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 23/06/2015 5:22:05 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Factura](
	[Serie] [int] IDENTITY(100101,1) NOT NULL,
	[Orden] [varchar](50) NOT NULL,
	[Sucursal] [int] NOT NULL,
	[Cliente] [int] NOT NULL,
	[Direccion] [varchar](50) NOT NULL,
	[Total] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Historial]    Script Date: 23/06/2015 5:22:05 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Historial](
	[Paquete] [int] NOT NULL,
	[Fecha_Recibido] [varchar](50) NOT NULL,
	[Fecha_Enviado] [varchar](50) NOT NULL,
	[Fecha_Stock] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Impuesto]    Script Date: 23/06/2015 5:22:05 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Impuesto](
	[Serie_imp] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Porcentaje] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Impuesto] PRIMARY KEY CLUSTERED 
(
	[Serie_imp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Lote]    Script Date: 23/06/2015 5:22:05 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Lote](
	[id_lote] [int] IDENTITY(1,1) NOT NULL,
	[fecha_salida] [varchar](50) NOT NULL,
	[estado] [varchar](50) NOT NULL,
	[destino] [int] NOT NULL,
 CONSTRAINT [PK_Lote] PRIMARY KEY CLUSTERED 
(
	[id_lote] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Paquete]    Script Date: 23/06/2015 5:22:05 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Paquete](
	[ID_paquete] [int] IDENTITY(1,1) NOT NULL,
	[Cliente] [int] NOT NULL,
	[Categoria] [int] NOT NULL,
	[Peso_lb] [int] NOT NULL,
	[Precio] [int] NOT NULL,
	[Estado] [varchar](50) NOT NULL,
	[Lote] [int] NULL,
	[Destino] [int] NOT NULL,
 CONSTRAINT [PK_Paquete] PRIMARY KEY CLUSTERED 
(
	[ID_paquete] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Planilla]    Script Date: 23/06/2015 5:22:05 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Planilla](
	[Num_planilla] [int] IDENTITY(10,1) NOT NULL,
	[ID_empleado] [int] NOT NULL,
	[Departamento] [int] NOT NULL,
	[Cargo] [varchar](50) NOT NULL,
	[Sueldo] [varchar](50) NOT NULL,
	[Nombre_usuario] [varchar](50) NOT NULL,
	[Contraseña] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Planilla] PRIMARY KEY CLUSTERED 
(
	[Num_planilla] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Registro]    Script Date: 23/06/2015 5:22:05 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registro](
	[sede_id] [int] NOT NULL,
	[depto_id] [int] NOT NULL,
	[no_registro] [int] NOT NULL,
 CONSTRAINT [PK_Registro] PRIMARY KEY CLUSTERED 
(
	[no_registro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sucursal]    Script Date: 23/06/2015 5:22:05 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sucursal](
	[Serie_Suc] [int] IDENTITY(100,1) NOT NULL,
	[Pais] [varchar](50) NOT NULL,
	[Direccion] [varchar](50) NOT NULL,
	[Capacidad] [int] NOT NULL,
	[Telefono] [int] NOT NULL,
 CONSTRAINT [PK_Sucursal] PRIMARY KEY CLUSTERED 
(
	[Serie_Suc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Historial]  WITH CHECK ADD  CONSTRAINT [FK_Historial_Paquete] FOREIGN KEY([Paquete])
REFERENCES [dbo].[Paquete] ([ID_paquete])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Historial] CHECK CONSTRAINT [FK_Historial_Paquete]
GO
ALTER TABLE [dbo].[Lote]  WITH CHECK ADD  CONSTRAINT [FK_Lote_Sucursal] FOREIGN KEY([destino])
REFERENCES [dbo].[Sucursal] ([Serie_Suc])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Lote] CHECK CONSTRAINT [FK_Lote_Sucursal]
GO
ALTER TABLE [dbo].[Paquete]  WITH CHECK ADD  CONSTRAINT [FK_Paquete_Cliente] FOREIGN KEY([Cliente])
REFERENCES [dbo].[Cliente] ([DPI])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Paquete] CHECK CONSTRAINT [FK_Paquete_Cliente]
GO
ALTER TABLE [dbo].[Paquete]  WITH CHECK ADD  CONSTRAINT [FK_Paquete_Impuesto] FOREIGN KEY([Categoria])
REFERENCES [dbo].[Impuesto] ([Serie_imp])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Paquete] CHECK CONSTRAINT [FK_Paquete_Impuesto]
GO
ALTER TABLE [dbo].[Paquete]  WITH CHECK ADD  CONSTRAINT [FK_Paquete_Lote] FOREIGN KEY([Lote])
REFERENCES [dbo].[Lote] ([id_lote])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Paquete] CHECK CONSTRAINT [FK_Paquete_Lote]
GO
ALTER TABLE [dbo].[Planilla]  WITH CHECK ADD  CONSTRAINT [FK_Planilla_Empleado] FOREIGN KEY([ID_empleado])
REFERENCES [dbo].[Empleado] ([ID_Empleado])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Planilla] CHECK CONSTRAINT [FK_Planilla_Empleado]
GO
ALTER TABLE [dbo].[Planilla]  WITH CHECK ADD  CONSTRAINT [FK_Planilla_Registro] FOREIGN KEY([Departamento])
REFERENCES [dbo].[Registro] ([no_registro])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Planilla] CHECK CONSTRAINT [FK_Planilla_Registro]
GO
ALTER TABLE [dbo].[Registro]  WITH CHECK ADD  CONSTRAINT [FK_Registro_Departamento] FOREIGN KEY([depto_id])
REFERENCES [dbo].[Departamento] ([Serie_dept])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Registro] CHECK CONSTRAINT [FK_Registro_Departamento]
GO
ALTER TABLE [dbo].[Registro]  WITH CHECK ADD  CONSTRAINT [FK_Registro_Sucursal] FOREIGN KEY([sede_id])
REFERENCES [dbo].[Sucursal] ([Serie_Suc])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Registro] CHECK CONSTRAINT [FK_Registro_Sucursal]
GO
USE [master]
GO
ALTER DATABASE [Quetzal_Express] SET  READ_WRITE 
GO
