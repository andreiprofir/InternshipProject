CREATE TABLE [dbo].[MovieLanguages] (
    [LanguageId] BIGINT NOT NULL,
    [MovieId]    BIGINT NOT NULL,
    CONSTRAINT [FK_MovieLanguages_Languages] FOREIGN KEY ([LanguageId]) REFERENCES [dbo].[Languages] ([Id]),
    CONSTRAINT [FK_MovieLanguages_Movies] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movies] ([Id]), 
    CONSTRAINT [PK_MovieLanguages] PRIMARY KEY CLUSTERED ([LanguageId], [MovieId])
);

