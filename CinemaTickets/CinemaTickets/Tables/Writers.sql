CREATE TABLE [dbo].[Writers]
(
	[Id] BIGINT NOT NULL IDENTITY(1, 1),
	[FirstName] NVARCHAR(128) NOT NULL,
	[LastName] NVARCHAR(128) NOT NULL, 
    CONSTRAINT [PK_Writers] PRIMARY KEY ([Id]), 
    CONSTRAINT [AK_Writers_FirstName_LastName] UNIQUE ([FirstName], [LastName])
)
