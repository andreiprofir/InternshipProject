CREATE TABLE [dbo].[LanguagesToMovies] (
    [LanguageId] BIGINT NOT NULL,
    [MovieId]    BIGINT NOT NULL,
    CONSTRAINT [FKDFF026AD710F4518] FOREIGN KEY ([LanguageId]) REFERENCES [dbo].[Language] ([Id]),
    CONSTRAINT [FKDFF026ADEB6BBFDA] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movie] ([Id])
);

