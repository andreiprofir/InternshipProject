CREATE TABLE [dbo].[MovieLanguages] (
    [LanguageId] BIGINT NOT NULL,
    [MovieId]    BIGINT NOT NULL,
    CONSTRAINT [PK_MovieLanguages] PRIMARY KEY CLUSTERED ([LanguageId] ASC, [MovieId] ASC),
    CONSTRAINT [FK_MovieLanguages_Languages] FOREIGN KEY ([LanguageId]) REFERENCES [dbo].[Languages] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_MovieLanguages_Movies] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movies] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_MovieLanguages_MovieId]
    ON [dbo].[MovieLanguages]([MovieId] ASC);

