
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 12/04/2012 13:32:03
-- Generated from EDMX file: F:\CBS\EF\EF\Lesson2\AddOneToOne\001_AddOneToOne\OneToOneModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DBOneToOne];
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

-- Creating table 'Employee'
CREATE TABLE [dbo].[Employee] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [EmployeeInf_Id] int  NOT NULL
);
GO

-- Creating table 'EmployeeInf'
CREATE TABLE [dbo].[EmployeeInf] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Age] nvarchar(max)  NOT NULL,
    [Gender] nvarchar(max)  NOT NULL,
    [Phone] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Employee'
ALTER TABLE [dbo].[Employee]
ADD CONSTRAINT [PK_Employee]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EmployeeInf'
ALTER TABLE [dbo].[EmployeeInf]
ADD CONSTRAINT [PK_EmployeeInf]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [EmployeeInf_Id] in table 'Employee'
ALTER TABLE [dbo].[Employee]
ADD CONSTRAINT [FK_EmployeeEmployeeInf]
    FOREIGN KEY ([EmployeeInf_Id])
    REFERENCES [dbo].[EmployeeInf]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeEmployeeInf'
CREATE INDEX [IX_FK_EmployeeEmployeeInf]
ON [dbo].[Employee]
    ([EmployeeInf_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------