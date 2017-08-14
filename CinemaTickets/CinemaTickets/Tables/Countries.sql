CREATE TABLE [dbo].[Countries]
(
	[Id] BIGINT NOT NULL IDENTITY(1, 1),
	[Name] NVARCHAR(128) NOT NULL, 
    CONSTRAINT [PK_Countries] PRIMARY KEY ([Id]), 
    CONSTRAINT [AK_Countries_Name] UNIQUE ([Name])
)
