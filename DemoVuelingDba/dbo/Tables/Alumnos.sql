CREATE TABLE [dbo].[Alumnos] (
    [Id]              INT           IDENTITY (1, 1) NOT NULL,
    [Nombre]          NVARCHAR (50) NOT NULL,
    [Apellidos]       NVARCHAR (50) NOT NULL,
    [Dni]             NVARCHAR (50) NOT NULL,
    [FechaNacimiento] DATETIME      NOT NULL,
    [Edad]            INT           NOT NULL,
    [FechaCreacion]   DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

