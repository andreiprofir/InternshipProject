CREATE TABLE [dbo].[MovieGenres] (
    [GenreId] BIGINT NOT NULL,
    [MovieId] BIGINT NOT NULL,
    CONSTRAINT [FK_MovieGenres_Genres] FOREIGN KEY ([GenreId]) REFERENCES [dbo].[Genres] ([Id]),
    CONSTRAINT [FK_MovieGenres_Movies] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movies] ([Id]), 
    CONSTRAINT [PK_MovieGenres] PRIMARY KEY CLUSTERED ([GenreId], [MovieId])
);

