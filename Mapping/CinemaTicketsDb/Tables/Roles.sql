﻿CREATE TABLE [dbo].[Roles] (
    [Id]   BIGINT         IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (255) NOT NULL,
    CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [AK_Roles_Name] UNIQUE NONCLUSTERED ([Name] ASC)
);

