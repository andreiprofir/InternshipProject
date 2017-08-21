CREATE TABLE [dbo].[HallMovieSessions] (
    [HallId]         BIGINT NOT NULL,
    [MovieSessionId] BIGINT NOT NULL,
    CONSTRAINT [FK_HallMovieSessions_MovieSession] FOREIGN KEY ([MovieSessionId]) REFERENCES [dbo].[MovieSessions] ([Id])
		ON UPDATE CASCADE
		ON DELETE CASCADE,
    CONSTRAINT [FK_HallMovieSessions_Hall] FOREIGN KEY ([HallId]) REFERENCES [dbo].[Halls] ([Id])
		ON UPDATE CASCADE
		ON DELETE CASCADE, 
    CONSTRAINT [PK_HallMovieSessions] PRIMARY KEY CLUSTERED ([HallId], [MovieSessionId])
);

