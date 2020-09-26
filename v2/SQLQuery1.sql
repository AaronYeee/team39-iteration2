CREATE TABLE [dbo].[kinderInfoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [PostCode] nchar(4)  NOT NULL,
    [Suburb] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Rating] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [Location] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'kinderInfoSet'
ALTER TABLE [dbo].[kinderInfoSet]
ADD CONSTRAINT [PK_kinderInfoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO