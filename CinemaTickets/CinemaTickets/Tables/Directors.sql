CREATE TABLE [dbo].[Directors]
(
	[Id] BIGINT NOT NULL IDENTITY(1, 1),
	[FirstName] NVARCHAR(128) NOT NULL,
	[LastName] NVARCHAR(128) NOT NULL, 
    CONSTRAINT [PK_Directors] PRIMARY KEY CLUSTERED ([Id]), 
    CONSTRAINT [AK_Directors_FirstName_LastName] UNIQUE ([FirstName], [LastName])
)
