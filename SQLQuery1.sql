SET QUOTED_IDENTIFIER OFF;
GO
USE [Kindergarten];
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

-- Creating table 'KindergartenSet'
CREATE TABLE [dbo].[KindergartenSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ServiceName] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [Suburb] nvarchar(max)  NOT NULL,
    [Postcode] nchar(4)  NOT NULL,
    [Phone] nvarchar(max)  NOT NULL,
    [Email_Address] nvarchar(max)  NOT NULL,
    [location] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'KindergartenSet'
ALTER TABLE [dbo].[KindergartenSet]
ADD CONSTRAINT [PK_KindergartenSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------