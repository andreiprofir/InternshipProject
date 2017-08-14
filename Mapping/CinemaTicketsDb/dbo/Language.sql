﻿CREATE TABLE [dbo].[Language] (
    [Id]   BIGINT         IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (255) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([Name] ASC)
);

