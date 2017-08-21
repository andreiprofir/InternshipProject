CREATE TABLE [dbo].[MovieDirectors] (
    [DirectorId] BIGINT NOT NULL,
    [MovieId]    BIGINT NOT NULL,
    CONSTRAINT [FK_MovieDirectors_Directors] FOREIGN KEY ([DirectorId]) REFERENCES [dbo].[Directors] ([Id]),
    CONSTRAINT [FK_MovieDirectors_Movies] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movies] ([Id]), 
    CONSTRAINT [PK_MovieDirectors] PRIMARY KEY CLUSTERED ([DirectorId], [MovieId])
);

