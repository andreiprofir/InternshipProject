CREATE TABLE [dbo].[Orders] (
    [Id]             BIGINT IDENTITY (1, 1) NOT NULL,
    [CustomerId]     BIGINT NOT NULL,
    [MovieSessionId] BIGINT NOT NULL,
    [SeatId]         BIGINT NOT NULL,
    CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Orders_Customers] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Users] ([Id]),
    CONSTRAINT [FK_Orders_MovieSessions] FOREIGN KEY ([MovieSessionId]) REFERENCES [dbo].[MovieSessions] ([Id]),
    CONSTRAINT [FK_Orders_Seats] FOREIGN KEY ([SeatId]) REFERENCES [dbo].[Seats] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Orders_CustomerId]
    ON [dbo].[Orders]([CustomerId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Orders_SeatId]
    ON [dbo].[Orders]([SeatId] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [AK_Orders_MovieSessionId_SeatId_CustomerId]
    ON [dbo].[Orders]([MovieSessionId] ASC, [SeatId] ASC, [CustomerId] ASC);

