CREATE TABLE [dbo].[MovieGenres] (
    [MovieId] BIGINT NOT NULL,
    [GenreId] BIGINT NOT NULL,
    CONSTRAINT [PK_MovieGenres] PRIMARY KEY CLUSTERED ([MovieId] ASC, [GenreId] ASC),
    CONSTRAINT [FK_MovieGenres_Genres] FOREIGN KEY ([GenreId]) REFERENCES [dbo].[Genres] ([Id]),
    CONSTRAINT [FK_MovieGenres_Movies] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movies] ([Id])
);

