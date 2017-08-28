CREATE TABLE [dbo].[MovieDirectors] (
    [DirectorId] BIGINT NOT NULL,
    [MovieId]    BIGINT NOT NULL,
    CONSTRAINT [PK_MovieDirectors] PRIMARY KEY CLUSTERED ([DirectorId] ASC, [MovieId] ASC),
    CONSTRAINT [FK_MovieDirectors_Directors] FOREIGN KEY ([DirectorId]) REFERENCES [dbo].[Directors] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_MovieDirectors_Movies] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movies] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_MovieDirectors_MovieId]
    ON [dbo].[MovieDirectors]([MovieId] ASC);

