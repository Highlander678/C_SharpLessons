
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 12/04/2012 23:05:06
-- Generated from EDMX file: F:\CBS\EF\EF\Lesson2\AddOneToOne\002_OneToMany\OneToManyModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DBOneToMany];
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

-- Creating table 'Cars'
CREATE TABLE [dbo].[Cars] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Factory] nvarchar(max)  NOT NULL,
    [Country] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Models'
CREATE TABLE [dbo].[Models] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Color] nvarchar(max)  NOT NULL,
    [Engine] nvarchar(max)  NOT NULL,
    [Cars_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Cars'
ALTER TABLE [dbo].[Cars]
ADD CONSTRAINT [PK_Cars]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Models'
ALTER TABLE [dbo].[Models]
ADD CONSTRAINT [PK_Models]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Cars_Id] in table 'Models'
ALTER TABLE [dbo].[Models]
ADD CONSTRAINT [FK_CarsModels]
    FOREIGN KEY ([Cars_Id])
    REFERENCES [dbo].[Cars]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CarsModels'
CREATE INDEX [IX_FK_CarsModels]
ON [dbo].[Models]
    ([Cars_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------