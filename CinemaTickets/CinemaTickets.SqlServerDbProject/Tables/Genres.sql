CREATE TABLE [dbo].[Genres] (
    [Id]   BIGINT         NOT NULL,
    [Name] NVARCHAR (128) NOT NULL,
    CONSTRAINT [PK_Genres] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Genres_Entities] FOREIGN KEY ([Id]) REFERENCES [dbo].[Entities] ([Id]),
    CONSTRAINT [AK_Genres_Name] UNIQUE NONCLUSTERED ([Name] ASC)
);

