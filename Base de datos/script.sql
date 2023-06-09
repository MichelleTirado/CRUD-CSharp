USE [master]
GO
/****** Object:  Database [Music]    Script Date: 28/04/2023 10:47:55 a. m. ******/
CREATE DATABASE [Music]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Music', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Music.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Music_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Music_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Music] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Music].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Music] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Music] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Music] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Music] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Music] SET ARITHABORT OFF 
GO
ALTER DATABASE [Music] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Music] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Music] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Music] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Music] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Music] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Music] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Music] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Music] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Music] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Music] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Music] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Music] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Music] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Music] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Music] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Music] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Music] SET RECOVERY FULL 
GO
ALTER DATABASE [Music] SET  MULTI_USER 
GO
ALTER DATABASE [Music] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Music] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Music] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Music] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Music] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Music] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Music', N'ON'
GO
ALTER DATABASE [Music] SET QUERY_STORE = ON
GO
ALTER DATABASE [Music] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Music]
GO
/****** Object:  Table [dbo].[Album]    Script Date: 28/04/2023 10:47:55 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Album](
	[Id_Album] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Ano_Lanzamiento] [int] NOT NULL,
	[Id_Artista] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Album] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Artist]    Script Date: 28/04/2023 10:47:55 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Artist](
	[Id_Artista] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Genero_Musical] [varchar](50) NOT NULL,
	[Pais_Origen] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Artista] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Song]    Script Date: 28/04/2023 10:47:55 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Song](
	[Id_Cancion] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Duracion] [varchar](5) NOT NULL,
	[Id_Album] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Cancion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Album]  WITH CHECK ADD  CONSTRAINT [FK_IdArtista_Artist] FOREIGN KEY([Id_Artista])
REFERENCES [dbo].[Artist] ([Id_Artista])
GO
ALTER TABLE [dbo].[Album] CHECK CONSTRAINT [FK_IdArtista_Artist]
GO
ALTER TABLE [dbo].[Song]  WITH CHECK ADD  CONSTRAINT [FK_IdAlbum_Album] FOREIGN KEY([Id_Album])
REFERENCES [dbo].[Album] ([Id_Album])
GO
ALTER TABLE [dbo].[Song] CHECK CONSTRAINT [FK_IdAlbum_Album]
GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_Album]    Script Date: 28/04/2023 10:47:55 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_Delete_Album]
@Id_Album INT
AS
DELETE FROM Album WHERE Id_Album = @Id_Album
GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_Artista]    Script Date: 28/04/2023 10:47:55 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_Delete_Artista]
@Id_Artista INT
AS
DELETE FROM Artist WHERE Id_Artista = @Id_Artista;
GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_Cancion]    Script Date: 28/04/2023 10:47:55 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_Delete_Cancion]
@Id_Cancion INT
AS
DELETE FROM Song WHERE Id_Cancion = @Id_Cancion
GO
/****** Object:  StoredProcedure [dbo].[SP_Insertar_Album]    Script Date: 28/04/2023 10:47:55 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_Insertar_Album]
@Nombre VARCHAR(50),
@Ano_Lanzamiento INT,
@Id_Artista INT
AS
INSERT INTO Album VALUES (@Nombre, @Ano_Lanzamiento, @Id_Artista)
GO
/****** Object:  StoredProcedure [dbo].[SP_Insertar_Artista]    Script Date: 28/04/2023 10:47:55 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_Insertar_Artista]
@Nombre VARCHAR(100),
@Genero_Musical VARCHAR(50),
@Pais_Origen VARCHAR(50)
AS
INSERT INTO Artist VALUES (@Nombre, @Genero_Musical, @Pais_Origen)
GO
/****** Object:  StoredProcedure [dbo].[SP_Insertar_Cancion]    Script Date: 28/04/2023 10:47:55 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_Insertar_Cancion]
@Nombre VARCHAR(50),
@Duracion VARCHAR(5),
@Id_Album INT
AS
INSERT INTO Song VALUES(@Nombre,@Duracion,@Id_Album)

GO
/****** Object:  StoredProcedure [dbo].[SP_Mostrar_Albumes]    Script Date: 28/04/2023 10:47:55 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_Mostrar_Albumes]
AS 
SELECT Al.Id_Album, Al.Nombre AS 'Albúm', Al.Ano_Lanzamiento AS 'Año de Lanzamiento', Ar.Nombre AS 'Artista / Agrupación' 
FROM Album Al 
INNER JOIN Artist Ar 
ON Al.Id_Artista = Ar.Id_Artista;
GO
/****** Object:  StoredProcedure [dbo].[SP_Mostrar_Artista]    Script Date: 28/04/2023 10:47:55 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_Mostrar_Artista]
AS
SELECT Id_Artista, Nombre AS 'Artista', Genero_Musical AS 'Genero Musical', Pais_Origen AS 'Pais de Origen' 
FROM Artist
GO
/****** Object:  StoredProcedure [dbo].[SP_Mostrar_Canciones]    Script Date: 28/04/2023 10:47:55 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_Mostrar_Canciones]
AS 
SELECT S.Id_Cancion, S.Nombre AS 'Canción', Duracion AS 'Duración', A.Nombre AS 'Albúm' 
FROM Song S INNER JOIN Album A ON S.Id_Album = A.Id_Album;
GO
/****** Object:  StoredProcedure [dbo].[SP_Mostrar_NombreAlbumes]    Script Date: 28/04/2023 10:47:55 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_Mostrar_NombreAlbumes]
AS
SELECT Id_Album, Nombre AS 'Artista' FROM Album
GO
/****** Object:  StoredProcedure [dbo].[SP_Mostrar_NombreArtistas]    Script Date: 28/04/2023 10:47:55 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Mostrar_NombreArtistas]
AS
SELECT Id_Artista, Nombre AS 'Artista' FROM Artist
GO
/****** Object:  StoredProcedure [dbo].[SP_Update_Album]    Script Date: 28/04/2023 10:47:55 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_Update_Album]
@Id_Album INT,
@Nombre VARCHAR(50),
@Ano_Lanzamiento INT,
@Id_Artista INT
AS
UPDATE Album SET Nombre = @Nombre, Ano_Lanzamiento = @Ano_Lanzamiento, Id_Artista = @Id_Artista WHERE Id_Album = @Id_Album;
GO
/****** Object:  StoredProcedure [dbo].[SP_Update_Artista]    Script Date: 28/04/2023 10:47:55 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_Update_Artista]
@Id_Artista INT,
@Nombre VARCHAR(100),
@Genero_Artista VARCHAR(50),
@Pais_Origen VARCHAR(50)
AS
UPDATE Artist SET Nombre = @Nombre, Genero_Musical = @Genero_Artista, Pais_Origen = @Pais_Origen WHERE Id_Artista = @Id_Artista;
GO
/****** Object:  StoredProcedure [dbo].[SP_Update_Cancion]    Script Date: 28/04/2023 10:47:55 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_Update_Cancion]
@Id_Cancion INT,
@Nombre VARCHAR(50),
@Duracion VARCHAR(5),
@Id_Album INT
AS
UPDATE Song SET Nombre = @Nombre, Duracion = @Duracion, Id_Album = @Id_Album WHERE Id_Cancion = @Id_Cancion;
GO
/****** Object:  Trigger [dbo].[TRIG_Delete_Album_Delete_Cancion]    Script Date: 28/04/2023 10:47:55 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TRIG_Delete_Album_Delete_Cancion]
ON [dbo].[Album]
INSTEAD OF DELETE
AS
DELETE FROM Song WHERE Id_Album IN (SELECT Id_Album FROM deleted)
DELETE FROM Album WHERE Id_Album IN (SELECT Id_Album FROM deleted)
GO
ALTER TABLE [dbo].[Album] ENABLE TRIGGER [TRIG_Delete_Album_Delete_Cancion]
GO
/****** Object:  Trigger [dbo].[TRIG_Delete_Artista_Delete_Album]    Script Date: 28/04/2023 10:47:55 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TRIG_Delete_Artista_Delete_Album]
ON [dbo].[Artist]
INSTEAD OF DELETE
AS
DELETE FROM Album WHERE Id_Artista IN (SELECT Id_Artista FROM deleted)
DELETE FROM Artist WHERE Id_Artista IN (SELECT Id_Artista FROM deleted)
GO
ALTER TABLE [dbo].[Artist] ENABLE TRIGGER [TRIG_Delete_Artista_Delete_Album]
GO
USE [master]
GO
ALTER DATABASE [Music] SET  READ_WRITE 
GO
