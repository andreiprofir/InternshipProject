CREATE TABLE [dbo].[MovieLanguages] (
    [LanguageId] BIGINT NOT NULL,
    [MovieId]    BIGINT NOT NULL,
    CONSTRAINT [FK_MovieLanguages_Languages] FOREIGN KEY ([LanguageId]) REFERENCES [dbo].[Languages] ([Id])
		ON UPDATE CASCADE
		ON DELETE CASCADE,
    CONSTRAINT [FK_MovieLanguages_Movies] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movies] ([Id])
		ON UPDATE CASCADE
		ON DELETE CASCADE, 
    CONSTRAINT [PK_MovieLanguages] PRIMARY KEY CLUSTERED ([LanguageId], [MovieId])
);

