CREATE TABLE [dbo].[MovieDirectors] (
    [DirectorId] BIGINT NOT NULL,
    [MovieId]    BIGINT NOT NULL,
    CONSTRAINT [FK_MovieDirectors_Directors] FOREIGN KEY ([DirectorId]) REFERENCES [dbo].[Directors] ([Id])
		ON UPDATE CASCADE
		ON DELETE CASCADE,
    CONSTRAINT [FK_MovieDirectors_Movies] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movies] ([Id])
		ON UPDATE CASCADE
		ON DELETE CASCADE, 
    CONSTRAINT [PK_MovieDirectors] PRIMARY KEY CLUSTERED ([DirectorId], [MovieId])
);

