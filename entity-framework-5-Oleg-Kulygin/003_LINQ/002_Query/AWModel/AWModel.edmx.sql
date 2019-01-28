
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 12/12/2012 16:00:05
-- Generated from EDMX file: C:\Users\Oleg\Videos\MSDN\Pluralsight\Querying the Entity Framework\materials\ef-querying-module1-exercise-files\AWModel\AWModel\AWModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [AdventureWorksSuperLT];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[SalesLT].[FK_SalesOrderDetail_SalesOrderHeader_SalesOrderID]', 'F') IS NOT NULL
    ALTER TABLE [SalesLT].[SalesOrderDetail] DROP CONSTRAINT [FK_SalesOrderDetail_SalesOrderHeader_SalesOrderID];
GO
IF OBJECT_ID(N'[SalesLT].[FK_SalesOrderHeader_Customer_CustomerID]', 'F') IS NOT NULL
    ALTER TABLE [SalesLT].[SalesOrderHeader] DROP CONSTRAINT [FK_SalesOrderHeader_Customer_CustomerID];
--GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[SalesLT].[Customer]', 'U') IS NOT NULL
    DROP TABLE [SalesLT].[Customer];
GO
IF OBJECT_ID(N'[SalesLT].[SalesOrderDetail]', 'U') IS NOT NULL
    DROP TABLE [SalesLT].[SalesOrderDetail];
GO
IF OBJECT_ID(N'[SalesLT].[SalesOrderHeader]', 'U') IS NOT NULL
    DROP TABLE [SalesLT].[SalesOrderHeader];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Customers'
CREATE TABLE [dbo].[Customers] (
    [CustomerID] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(8)  NULL,
    [FirstName] nvarchar(50)  NOT NULL,
    [MiddleName] nvarchar(50)  NULL,
    [LastName] nvarchar(50)  NOT NULL,
    [Suffix] nvarchar(10)  NULL,
    [Company] nvarchar(128)  NULL,
    [SalesPerson] nvarchar(256)  NULL,
    [EmailAddress] nvarchar(50)  NULL,
    [Phone] nvarchar(25)  NULL,
    [ModifiedDate] datetime  NOT NULL,
    [TimeStamp] binary(8)  NOT NULL
);
GO

-- Creating table 'LineItems'
CREATE TABLE [dbo].[LineItems] (
    [SalesOrderID] int  NOT NULL,
    [SalesOrderDetailID] int IDENTITY(1,1) NOT NULL,
    [OrderQty] smallint  NOT NULL,
    [ProductID] int  NOT NULL,
    [UnitPrice] decimal(19,4)  NOT NULL,
    [UnitPriceDiscount] decimal(19,4)  NOT NULL,
    [LineTotal] decimal(38,6)  NOT NULL,
    [ModifiedDate] datetime  NOT NULL
);
GO

-- Creating table 'Orders'
CREATE TABLE [dbo].[Orders] (
    [SalesOrderID] int IDENTITY(1,1) NOT NULL,
    [OrderDate] datetime  NOT NULL,
    [DueDate] datetime  NULL,
    [OnlineOrderFlag] bit  NOT NULL,
    [SalesOrderNumber] nvarchar(25)  NOT NULL,
    [PurchaseOrderNumber] nvarchar(25)  NULL,
    [AccountNumber] nvarchar(15)  NULL,
    [CustomerID] int  NOT NULL,
    [BillToAddressID] int  NULL,
    [CreditCardApprovalCode] varchar(15)  NULL,
    [SubTotal] decimal(19,4)  NOT NULL,
    [Comment] nvarchar(max)  NULL,
    [ModifiedDate] datetime  NOT NULL,
    [ShipDate] datetime  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CustomerID] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([CustomerID] ASC);
GO

-- Creating primary key on [SalesOrderDetailID] in table 'LineItems'
ALTER TABLE [dbo].[LineItems]
ADD CONSTRAINT [PK_LineItems]
    PRIMARY KEY CLUSTERED ([SalesOrderDetailID] ASC);
GO

-- Creating primary key on [SalesOrderID] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [PK_Orders]
    PRIMARY KEY CLUSTERED ([SalesOrderID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CustomerID] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [FK_SalesOrderHeader_Customer_CustomerID]
    FOREIGN KEY ([CustomerID])
    REFERENCES [dbo].[Customers]
        ([CustomerID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SalesOrderHeader_Customer_CustomerID'
CREATE INDEX [IX_FK_SalesOrderHeader_Customer_CustomerID]
ON [dbo].[Orders]
    ([CustomerID]);
GO

-- Creating foreign key on [SalesOrderID] in table 'LineItems'
ALTER TABLE [dbo].[LineItems]
ADD CONSTRAINT [FK_SalesOrderDetail_SalesOrderHeader_SalesOrderID]
    FOREIGN KEY ([SalesOrderID])
    REFERENCES [dbo].[Orders]
        ([SalesOrderID])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SalesOrderDetail_SalesOrderHeader_SalesOrderID'
CREATE INDEX [IX_FK_SalesOrderDetail_SalesOrderHeader_SalesOrderID]
ON [dbo].[LineItems]
    ([SalesOrderID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------