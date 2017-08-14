CREATE TABLE [dbo].[Actor] (
    [Id]        BIGINT        IDENTITY (1, 1) NOT NULL,
    [FirstName] NVARCHAR (64) NOT NULL,
    [LastName]  NVARCHAR (64) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([FirstName] ASC, [LastName] ASC)
);

