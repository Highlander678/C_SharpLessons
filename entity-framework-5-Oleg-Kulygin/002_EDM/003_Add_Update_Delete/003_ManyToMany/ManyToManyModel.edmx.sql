
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 12/05/2012 13:20:42
-- Generated from EDMX file: F:\CBS\EF\EF\Lesson2\AddOneToOne\003_ManyToMany\ManyToManyModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DBManyToMany];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Person]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Person];
GO
IF OBJECT_ID(N'[dbo].[Location]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Location];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Students'
CREATE TABLE [dbo].[Students] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Courses'
CREATE TABLE [dbo].[Courses] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'StudentsCourses'
CREATE TABLE [dbo].[StudentsCourses] (
    [Students_Id] int  NOT NULL,
    [Courses_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [PK_Students]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [PK_Courses]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Students_Id], [Courses_Id] in table 'StudentsCourses'
ALTER TABLE [dbo].[StudentsCourses]
ADD CONSTRAINT [PK_StudentsCourses]
    PRIMARY KEY NONCLUSTERED ([Students_Id], [Courses_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Students_Id] in table 'StudentsCourses'
ALTER TABLE [dbo].[StudentsCourses]
ADD CONSTRAINT [FK_StudentsCourses_Students]
    FOREIGN KEY ([Students_Id])
    REFERENCES [dbo].[Students]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Courses_Id] in table 'StudentsCourses'
ALTER TABLE [dbo].[StudentsCourses]
ADD CONSTRAINT [FK_StudentsCourses_Courses]
    FOREIGN KEY ([Courses_Id])
    REFERENCES [dbo].[Courses]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_StudentsCourses_Courses'
CREATE INDEX [IX_FK_StudentsCourses_Courses]
ON [dbo].[StudentsCourses]
    ([Courses_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------