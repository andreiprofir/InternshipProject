CREATE TABLE [dbo].[Order] (
    [Id]             BIGINT IDENTITY (1, 1) NOT NULL,
    [MovieSessionId] BIGINT NOT NULL,
    [SeatId]         BIGINT NOT NULL,
    [UserId]         BIGINT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK3117099B3A468872] FOREIGN KEY ([MovieSessionId]) REFERENCES [dbo].[MovieSession] ([Id]),
    CONSTRAINT [FK3117099B45437A40] FOREIGN KEY ([SeatId]) REFERENCES [dbo].[Seat] ([Id]),
    CONSTRAINT [FK3117099BB3F091CE] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id]),
    UNIQUE NONCLUSTERED ([MovieSessionId] ASC, [SeatId] ASC, [UserId] ASC)
);

