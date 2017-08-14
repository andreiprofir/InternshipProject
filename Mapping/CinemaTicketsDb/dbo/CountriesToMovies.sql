CREATE TABLE [dbo].[CountriesToMovies] (
    [CountryId] BIGINT NOT NULL,
    [MovieId]   BIGINT NOT NULL,
    CONSTRAINT [FK6CA8A47DA341194] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Country] ([Id]),
    CONSTRAINT [FK6CA8A47DEB6BBFDA] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movie] ([Id])
);

