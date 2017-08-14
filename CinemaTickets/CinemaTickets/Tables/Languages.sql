CREATE TABLE [dbo].[Languages]
(
	[Id] BIGINT NOT NULL IDENTITY(1, 1),
	[Name] NVARCHAR(128) NOT NULL, 
    CONSTRAINT [PK_Languages] PRIMARY KEY CLUSTERED ([Id]), 
    CONSTRAINT [AK_Languages_Name] UNIQUE ([Name])
)
