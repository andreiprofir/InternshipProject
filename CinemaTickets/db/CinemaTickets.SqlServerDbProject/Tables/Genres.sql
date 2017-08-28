CREATE TABLE [dbo].[Genres] (
    [Id]   BIGINT         NOT NULL,
    [Name] NVARCHAR (128) NOT NULL,
    CONSTRAINT [PK_Genres] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Genres_Entities] FOREIGN KEY ([Id]) REFERENCES [dbo].[Entities] ([Id])
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [AK_Genres_Name]
    ON [dbo].[Genres]([Name] ASC);

