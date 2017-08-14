﻿CREATE TABLE [dbo].[Cities]
(
	[Id] BIGINT NOT NULL IDENTITY(1, 1),
	[Name] NVARCHAR(128) NOT NULL, 
    CONSTRAINT [PK_Cities] PRIMARY KEY ([Id]), 
    CONSTRAINT [AK_Cities_Name] UNIQUE ([Name])
)
