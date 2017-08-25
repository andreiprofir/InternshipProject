CREATE TABLE [dbo].[Languages] (
    [Id]   BIGINT         IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (255) NOT NULL,
    CONSTRAINT [PK_Languages] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [AK_Languages_Name] UNIQUE NONCLUSTERED ([Name] ASC)
);

