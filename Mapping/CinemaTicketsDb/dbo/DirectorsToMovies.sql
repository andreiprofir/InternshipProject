CREATE TABLE [dbo].[DirectorsToMovies] (
    [DirectorId] BIGINT NOT NULL,
    [MovieId]    BIGINT NOT NULL,
    CONSTRAINT [FK5EEDF18E69FB437E] FOREIGN KEY ([DirectorId]) REFERENCES [dbo].[Director] ([Id]),
    CONSTRAINT [FK5EEDF18EEB6BBFDA] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movie] ([Id])
);

