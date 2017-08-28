CREATE TABLE [dbo].[MovieActors] (
    [ActorId] BIGINT NOT NULL,
    [MovieId] BIGINT NOT NULL,
    CONSTRAINT [PK_MovieActors] PRIMARY KEY CLUSTERED ([ActorId] ASC, [MovieId] ASC),
    CONSTRAINT [FK_MovieActors_Actors] FOREIGN KEY ([ActorId]) REFERENCES [dbo].[Actors] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_MovieActors_Movies] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movies] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_MovieActors_MovieId]
    ON [dbo].[MovieActors]([MovieId] ASC);

