CREATE TABLE [dbo].[MovieCountries]
(
	[MovieId] BIGINT NOT NULL,
	[CountryId] BIGINT NOT NULL, 
    CONSTRAINT [FK_MovieCountries_Movies] FOREIGN KEY ([MovieId]) REFERENCES [Movies]([Id]), 
    CONSTRAINT [FK_MovieCountries_Countries] FOREIGN KEY ([CountryId]) REFERENCES [Countries]([Id])
)
