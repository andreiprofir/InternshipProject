CREATE TABLE [dbo].[Genre] (
    [Id]   BIGINT         NOT NULL,
    [Name] NVARCHAR (128) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_GenreToEntity] FOREIGN KEY ([Id]) REFERENCES [dbo].[Entity] ([Id]),
    UNIQUE NONCLUSTERED ([Name] ASC)
);

