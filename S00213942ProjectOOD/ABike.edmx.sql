
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/24/2022 17:34:50
-- Generated from EDMX file: C:\Users\Emmet\Desktop\College\Year 2\OOD\S00213942ProjectOOD\S00213942ProjectOOD\ABike.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ABike];
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

-- Creating table 'Frames'
CREATE TABLE [dbo].[Frames] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Brand] nvarchar(max)  NOT NULL,
    [Discipline] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Price] nvarchar(max)  NOT NULL,
    [FrameImage] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Forks'
CREATE TABLE [dbo].[Forks] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Brand] nvarchar(max)  NOT NULL,
    [Size] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Price] nvarchar(max)  NOT NULL,
    [ForkImage] nvarchar(max)  NOT NULL,
    [FrameId] int  NOT NULL
);
GO

-- Creating table 'Drivetrains'
CREATE TABLE [dbo].[Drivetrains] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Brand] nvarchar(max)  NOT NULL,
    [Gears] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Price] nvarchar(max)  NOT NULL,
    [DriveImage] nvarchar(max)  NOT NULL,
    [FrameId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Frames'
ALTER TABLE [dbo].[Frames]
ADD CONSTRAINT [PK_Frames]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Forks'
ALTER TABLE [dbo].[Forks]
ADD CONSTRAINT [PK_Forks]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Drivetrains'
ALTER TABLE [dbo].[Drivetrains]
ADD CONSTRAINT [PK_Drivetrains]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [FrameId] in table 'Forks'
ALTER TABLE [dbo].[Forks]
ADD CONSTRAINT [FK_FrameFork]
    FOREIGN KEY ([FrameId])
    REFERENCES [dbo].[Frames]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FrameFork'
CREATE INDEX [IX_FK_FrameFork]
ON [dbo].[Forks]
    ([FrameId]);
GO

-- Creating foreign key on [FrameId] in table 'Drivetrains'
ALTER TABLE [dbo].[Drivetrains]
ADD CONSTRAINT [FK_FrameDrivetrain]
    FOREIGN KEY ([FrameId])
    REFERENCES [dbo].[Frames]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FrameDrivetrain'
CREATE INDEX [IX_FK_FrameDrivetrain]
ON [dbo].[Drivetrains]
    ([FrameId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------