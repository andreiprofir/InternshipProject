CREATE TABLE [dbo].[Actors] (
    [Id]        BIGINT        IDENTITY (1, 1) NOT NULL,
    [FirstName] NVARCHAR (64) NOT NULL,
    [LastName]  NVARCHAR (64) NOT NULL,
    CONSTRAINT [PK_Actors] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [AK_Actors_FirstName_LastName] UNIQUE NONCLUSTERED ([FirstName] ASC, [LastName] ASC)
);

