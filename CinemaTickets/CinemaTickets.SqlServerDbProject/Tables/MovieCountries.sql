CREATE TABLE [dbo].[MovieCountries] (
    [CountryId] BIGINT NOT NULL,
    [MovieId]   BIGINT NOT NULL,
    CONSTRAINT [FK_MovieCountries_Countries] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Countries] ([Id])
		ON UPDATE CASCADE
		ON DELETE CASCADE,
    CONSTRAINT [FK_MovieCountries_Movies] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movies] ([Id])
		ON UPDATE CASCADE
		ON DELETE CASCADE, 
    CONSTRAINT [PK_MovieCountries] PRIMARY KEY CLUSTERED ([CountryId], [MovieId])
);

