CREATE TABLE [dbo].[MovieLanguages]
(
	[MovieId] BIGINT NOT NULL,
	[LanguageId] BIGINT NOT NULL, 
    CONSTRAINT [FK_MovieLanguages_Movies] FOREIGN KEY ([MovieId]) REFERENCES [Movies]([Id]), 
    CONSTRAINT [FK_MovieLanguages_Languages] FOREIGN KEY ([LanguageId]) REFERENCES [Languages]([Id])
)
