﻿CREATE TABLE [dbo].[SeatTypes] (
    [Id]   BIGINT        IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (64) NOT NULL,
    CONSTRAINT [PK_SeatTypes] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [AK_SeatTypes_Name] UNIQUE NONCLUSTERED ([Name] ASC)
);
