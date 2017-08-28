CREATE TABLE [dbo].[MovieGenres] (
    [GenreId] BIGINT NOT NULL,
    [MovieId] BIGINT NOT NULL,
    CONSTRAINT [PK_MovieGenres] PRIMARY KEY CLUSTERED ([GenreId] ASC, [MovieId] ASC),
    CONSTRAINT [FK_MovieGenres_Genres] FOREIGN KEY ([GenreId]) REFERENCES [dbo].[Genres] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_MovieGenres_Movies] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movies] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_MovieGenres_MovieId]
    ON [dbo].[MovieGenres]([MovieId] ASC);

