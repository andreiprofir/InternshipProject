CREATE TABLE [dbo].[Orders] (
    [Id]             BIGINT IDENTITY (1, 1) NOT NULL,
    [MovieSessionId] BIGINT NOT NULL,
    [SeatId]         BIGINT NOT NULL,
    [UserId]         BIGINT NOT NULL,
    CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Orders_MovieSessions] FOREIGN KEY ([MovieSessionId]) REFERENCES [dbo].[MovieSessions] ([Id]),
    CONSTRAINT [FK_Orders_Seats] FOREIGN KEY ([SeatId]) REFERENCES [dbo].[Seats] ([Id]),
    CONSTRAINT [FK_Orders_Users] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id]),
    CONSTRAINT [AK_Orders_MovieSessionId_SeatId_UserId] UNIQUE NONCLUSTERED ([MovieSessionId] ASC, [SeatId] ASC, [UserId] ASC)
);

