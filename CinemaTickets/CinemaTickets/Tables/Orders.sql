CREATE TABLE [dbo].[Orders] (
    [Id]        BIGINT NOT NULL IDENTITY(1, 1),
    [UserId]    BIGINT NULL,
    [MovieSessionId] BIGINT NOT NULL,
    [SeatId]    BIGINT NOT NULL,
    CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Orders_Seats] FOREIGN KEY ([SeatId]) REFERENCES [dbo].[Seats] ([Id]),
    CONSTRAINT [FK_Orders_Sessions] FOREIGN KEY ([MovieSessionId]) REFERENCES [dbo].[MovieSessions] ([Id]),
    CONSTRAINT [FK_Orders_Users] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id])
);

