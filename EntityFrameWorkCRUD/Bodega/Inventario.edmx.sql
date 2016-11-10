
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/30/2016 22:48:01
-- Generated from EDMX file: D:\Datos DevSoft Group\Proyectos C#\EntityFrameWorkCRUD\Bodega\Inventario.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Bodega];
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

-- Creating table 'Proveedor'
CREATE TABLE [dbo].[Proveedor] (
    [ProveedorID] int  NOT NULL,
    [ProveedorNombre] nvarchar(50)  NOT NULL,
    [ProveedorDireccion] nvarchar(100)  NOT NULL,
    [ProveedorTelefono] nvarchar(20)  NOT NULL,
    [ProveedorCorreoE] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Producto'
CREATE TABLE [dbo].[Producto] (
    [ProductoID] int  NOT NULL,
    [ProductoNombre] nvarchar(50)  NOT NULL,
    [ProductoPrecio] decimal(5,0)  NOT NULL,
    [ProductoDescripcion] nvarchar(max)  NOT NULL,
    [ProductoProveedor] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ProveedorID] in table 'Proveedor'
ALTER TABLE [dbo].[Proveedor]
ADD CONSTRAINT [PK_Proveedor]
    PRIMARY KEY CLUSTERED ([ProveedorID] ASC);
GO

-- Creating primary key on [ProductoID] in table 'Producto'
ALTER TABLE [dbo].[Producto]
ADD CONSTRAINT [PK_Producto]
    PRIMARY KEY CLUSTERED ([ProductoID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ProductoProveedor] in table 'Producto'
ALTER TABLE [dbo].[Producto]
ADD CONSTRAINT [FK_ProveedorProducto]
    FOREIGN KEY ([ProductoProveedor])
    REFERENCES [dbo].[Proveedor]
        ([ProveedorID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProveedorProducto'
CREATE INDEX [IX_FK_ProveedorProducto]
ON [dbo].[Producto]
    ([ProductoProveedor]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------