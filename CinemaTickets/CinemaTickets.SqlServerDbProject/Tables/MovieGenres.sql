CREATE TABLE [dbo].[MovieGenres] (
    [GenreId] BIGINT NOT NULL,
    [MovieId] BIGINT NOT NULL,
    CONSTRAINT [FK_MovieGenres_Genres] FOREIGN KEY ([GenreId]) REFERENCES [dbo].[Genres] ([Id])
		ON UPDATE CASCADE
		ON DELETE CASCADE,
    CONSTRAINT [FK_MovieGenres_Movies] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movies] ([Id])
		ON UPDATE CASCADE
		ON DELETE CASCADE, 
    CONSTRAINT [PK_MovieGenres] PRIMARY KEY CLUSTERED ([GenreId], [MovieId])
);

