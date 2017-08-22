CREATE TABLE [dbo].[MovieActors] (
    [ActorId] BIGINT NOT NULL,
    [MovieId] BIGINT NOT NULL,
    CONSTRAINT [FK_MovieActors_Movies] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movies] ([Id])
		ON UPDATE CASCADE
		ON DELETE CASCADE,
    CONSTRAINT [FK_MovieActors_Actors] FOREIGN KEY ([ActorId]) REFERENCES [dbo].[Actors] ([Id])
		ON UPDATE CASCADE
		ON DELETE CASCADE, 
    CONSTRAINT [PK_MovieActors] PRIMARY KEY CLUSTERED ([ActorId], [MovieId])
);

