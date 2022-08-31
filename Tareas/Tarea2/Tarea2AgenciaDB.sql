CREATE DATABASE [agencia] 
GO

USE [agencia]
GO
CREATE TABLE [dbo].[Automovil] (
    [AutomovilId] [int] IDENTITY(1,1) NOT NULL,
    [Marca] [varchar](100) NOT NULL,
    [Modelo] [varchar](100) NOT NULL,
    [Anio] [int] NOT NULL,
    [Precio] [int] NOT NULL,
    PRIMARY KEY CLUSTERED (
        [Automovilid] ASC
    )
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
    ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) 
ON [PRIMARY]
GO

/****** Object: Table [dbo].[Cliente] Script Date: 27/8/2022 08:22:07 ******/
CREATE TABLE [dbo].[Cliente] (
    [ClienteId] [int] IDENTITY(1,1) NOT NULL,
    [Nombre] [varchar](100) NOT NULL,
    [Direccion] [varchar](100) NOT NULL,
    [Telefono] [varchar](100) NOT NULL,
    [Correo Electronico] [varchar](100) NULL,
    PRIMARY KEY CLUSTERED (
        [ClienteId] ASC 
    ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
    ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) 
ON [PRIMARY] 
GO



/****** Object: Table [dbo].[Renta] Script Date: 27/8/2022 08:22:07 ******/
CREATE TABLE [dbo].[Renta](
    [RentaId] [int] IDENTITY(1,1) NOT NULL,
    [Fecha] [datetime] NULL,
    [Automovilid] [int] NOT NULL,
    [VendedorId] [int] NOT NULL,
    [ClienteId] [int] NOT NULL,
    [Dias] [int] NOT NULL,
    [Precio] [int] NOT NULL,
    PRIMARY KEY CLUSTERED
    (
        [RentaId] ASC
    )
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
    ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[Vendedor](
    [VendedorId] [int] IDENTITY(1,1) NOT NULL,
    [Nombre] [varchar](100) NOT NULL,
    [Direccion] [varchar](100) NOT NULL,
    [Telefono] [varchar](100) NOT NULL,
    [Correo_Electronico] [varchar](100) NULL,
    PRIMARY KEY CLUSTERED
    (
        [VendedorId] ASC
    )
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
    ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object: StoredProcedure [dbo].[AutomovilActualiza] Script Date: 
27/8/2022 08:22:07 ******/
CREATE PROCEDURE [dbo].[AutomovilActualiza]
@AutomovilId int, @Marca VARCHAR(100), @Modelo Varchar(100), @Anio int, @Precio int
AS
BEGIN
UPDATE [dbo].[Automovil]
    SET [Marca] = @Marca
    ,[Modelo] = @Modelo
    ,[Anio] = @Anio
    ,[Precio] = @Precio
    WHERE AutomovilId = @AutomovilId
END
GO

/****** Object: StoredProcedure [dbo].[AutomovilConsulta] Script Date: 27/8/2022 
08:22:07 ******/
CREATE PROCEDURE [dbo].[AutomovilConsulta]
AS
BEGIN
 SELECT [AutomovilId],
        [Marca],
        [Modelo],
        [Anio],
        [Precio]
FROM [dbo].[Automovil]
END
GO


/****** Object: StoredProcedure [dbo].[AutomovilConsultaXId] Script Date: 
27/8/2022 08:22:07 ******/
CREATE PROCEDURE [dbo].[AutomovilConsultaXId]
@AutomovilId int
AS
BEGIN
 SELECT [AutomovilId],
       [Marca],
       [Modelo],
       [Anio],
       [Precio]
 FROM [dbo].[Automovil]
 WHERE AutomovilId = @AutomovilId
END
GO

/****** Object: StoredProcedure [dbo].[AutomovilElimina] Script Date: 27/8/2022 
08:22:07 ******/
CREATE PROCEDURE [dbo].[AutomovilElimina]
@AutomovilId INT
AS
BEGIN
    DELETE FROM [dbo].[Automovil]
    WHERE AutomovilId = @AutomovilId
END
GO

/****** Object: StoredProcedure [dbo].[AutomovilInserta] Script Date: 27/8/2022 
08:22:07 ******/
CREATE PROCEDURE [dbo].[AutomovilInserta]
@Marca VARCHAR(100), @Modelo VARCHAR(100), @Anio INT, @Precio INT
AS
BEGIN
    INSERT INTO [dbo].[Automovil]
        ([Marca],
        [Modelo],
        [Anio],
        [Precio])
        VALUES
        (@Marca,
        @Modelo,
        @Anio,
        @Precio)
END