CREATE TABLE [dbo].[MovieCountries] (
    [CountryId] BIGINT NOT NULL,
    [MovieId]   BIGINT NOT NULL,
    CONSTRAINT [PK_MovieCountries] PRIMARY KEY CLUSTERED ([CountryId] ASC, [MovieId] ASC),
    CONSTRAINT [FK_MovieCountries_Countries] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Countries] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_MovieCountries_Movies] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movies] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_MovieCountries_MovieId]
    ON [dbo].[MovieCountries]([MovieId] ASC);

