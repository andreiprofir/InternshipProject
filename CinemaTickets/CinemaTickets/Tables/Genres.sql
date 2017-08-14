CREATE TABLE [dbo].[Genres] (
    [Id]   BIGINT     NOT NULL,
    [Name] NVARCHAR(100) NOT NULL,
    CONSTRAINT [PK_Genres] PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Genres_Entities] FOREIGN KEY ([Id]) REFERENCES [Entities]([Id])
);

