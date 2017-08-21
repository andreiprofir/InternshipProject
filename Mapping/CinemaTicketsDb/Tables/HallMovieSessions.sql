CREATE TABLE [dbo].[HallMovieSessions] (
    [HallId]         BIGINT NOT NULL,
    [MovieSessionId] BIGINT NOT NULL,
    CONSTRAINT [FK_HallMovieSessions_MovieSession] FOREIGN KEY ([MovieSessionId]) REFERENCES [dbo].[MovieSessions] ([Id]),
    CONSTRAINT [FK_HallMovieSessions_Hall] FOREIGN KEY ([HallId]) REFERENCES [dbo].[Halls] ([Id]), 
    CONSTRAINT [PK_HallMovieSessions] PRIMARY KEY CLUSTERED ([HallId], [MovieSessionId])
);

