CREATE TABLE [dbo].[Actors]
(
	[Id] BIGINT NOT NULL IDENTITY(1, 1),
	[FirstName] NVARCHAR(128) NOT NULL,
	[LastName] NVARCHAR(128) NOT NULL, 
    CONSTRAINT [PK_Actors] PRIMARY KEY CLUSTERED ([Id]), 
    CONSTRAINT [AK_Actors_FirstName_LastName] UNIQUE ([FirstName], [LastName])
)
