
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 01/29/2013 17:41:27
-- Generated from EDMX file: C:\Cources\EF\Lesson2\002_EDM\008_Insert\DBModel.edmx
-- --------------------------------------------------
exec sp_help
CREATE TABLE [dbo].[Table] (
    [Id]        INT      NOT NULL,
    [BirthDate] DATETIME NOT NULL,
    CONSTRAINT [PK_Table] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TablePerson] FOREIGN KEY ([Id]) REFERENCES [dbo].[PersonSet] ([Id])
);

SET QUOTED_IDENTIFIER OFF;
GO
USE [C:\Cources\EF\Lesson2\002_EDM\008_Insert\DB.mdf];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_TablePerson]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Table] DROP CONSTRAINT [FK_TablePerson];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[PersonSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonSet];
GO
IF OBJECT_ID(N'[dbo].[Table]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Table];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'PersonSet'
CREATE TABLE [dbo].[PersonSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [PersonDetail_Id] int  NOT NULL
);
GO

-- Creating table 'Table'
CREATE TABLE [dbo].[Table] (
    [Id] int  NOT NULL,
    [BirthDate] datetime  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'PersonSet'
ALTER TABLE [dbo].[PersonSet]
ADD CONSTRAINT [PK_PersonSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Table'
ALTER TABLE [dbo].[Table]
ADD CONSTRAINT [PK_Table]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PersonDetail_Id] in table 'PersonSet'
ALTER TABLE [dbo].[PersonSet]
ADD CONSTRAINT [FK_TablePerson]
    FOREIGN KEY ([PersonDetail_Id])
    REFERENCES [dbo].[Table]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TablePerson'
CREATE INDEX [IX_FK_TablePerson]
ON [dbo].[PersonSet]
    ([PersonDetail_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------