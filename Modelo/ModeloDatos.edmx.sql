
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/27/2020 13:36:20
-- Generated from EDMX file: C:\Users\limac\Documents\FACULTAD\Eliseo - Campo y Diploma\Autocred0603\Modelo\ModeloDatos.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Autocredito];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'EmpleadoSet'
CREATE TABLE [dbo].[EmpleadoSet] (
    [Id_Emp] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Apellido] nvarchar(max)  NOT NULL,
    [Direc_calle] nvarchar(max)  NOT NULL,
    [Direc_Nro] int  NOT NULL,
    [Direc_Ciudad] nvarchar(max)  NOT NULL,
    [Telefono] int  NOT NULL,
    [Email] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'RequerimientoSet'
CREATE TABLE [dbo].[RequerimientoSet] (
    [Id_Req] int IDENTITY(1,1) NOT NULL,
    [Estado] bit  NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Empleado_Id_Emp] int  NOT NULL,
    [Articulo_Id] int  NOT NULL
);
GO

-- Creating table 'ArticuloSet'
CREATE TABLE [dbo].[ArticuloSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Stock] int  NOT NULL,
    [Pendientes] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id_Emp] in table 'EmpleadoSet'
ALTER TABLE [dbo].[EmpleadoSet]
ADD CONSTRAINT [PK_EmpleadoSet]
    PRIMARY KEY CLUSTERED ([Id_Emp] ASC);
GO

-- Creating primary key on [Id_Req] in table 'RequerimientoSet'
ALTER TABLE [dbo].[RequerimientoSet]
ADD CONSTRAINT [PK_RequerimientoSet]
    PRIMARY KEY CLUSTERED ([Id_Req] ASC);
GO

-- Creating primary key on [Id] in table 'ArticuloSet'
ALTER TABLE [dbo].[ArticuloSet]
ADD CONSTRAINT [PK_ArticuloSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Empleado_Id_Emp] in table 'RequerimientoSet'
ALTER TABLE [dbo].[RequerimientoSet]
ADD CONSTRAINT [FK_EmpleadoRequerimiento]
    FOREIGN KEY ([Empleado_Id_Emp])
    REFERENCES [dbo].[EmpleadoSet]
        ([Id_Emp])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmpleadoRequerimiento'
CREATE INDEX [IX_FK_EmpleadoRequerimiento]
ON [dbo].[RequerimientoSet]
    ([Empleado_Id_Emp]);
GO

-- Creating foreign key on [Articulo_Id] in table 'RequerimientoSet'
ALTER TABLE [dbo].[RequerimientoSet]
ADD CONSTRAINT [FK_RequerimientoArticulo]
    FOREIGN KEY ([Articulo_Id])
    REFERENCES [dbo].[ArticuloSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RequerimientoArticulo'
CREATE INDEX [IX_FK_RequerimientoArticulo]
ON [dbo].[RequerimientoSet]
    ([Articulo_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------