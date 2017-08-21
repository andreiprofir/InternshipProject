﻿CREATE TABLE [dbo].[Countries] (
    [Id]   BIGINT        IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (64) NOT NULL,
    CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [AK_Countries_Name] UNIQUE NONCLUSTERED ([Name] ASC)
);

