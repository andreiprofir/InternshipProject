CREATE TABLE [dbo].[SessionPrices] (
    [Id]             BIGINT IDENTITY (1, 1) NOT NULL,
    [MovieSessionId] BIGINT NOT NULL,
    [Price]          MONEY  DEFAULT ((0)) NOT NULL,
    [SeatTypeId]     BIGINT NOT NULL,
    CONSTRAINT [PK_SessionPrices] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_SessionPrices_MovieSessions] FOREIGN KEY ([MovieSessionId]) REFERENCES [dbo].[MovieSessions] ([Id]),
    CONSTRAINT [FK_SessionPrices_SeatTypes] FOREIGN KEY ([SeatTypeId]) REFERENCES [dbo].[SeatTypes] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_SessionPrices_SeatTypeId]
    ON [dbo].[SessionPrices]([SeatTypeId] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [AK_SessionPrices_MovieSessionId_SeatTypeId]
    ON [dbo].[SessionPrices]([MovieSessionId] ASC, [SeatTypeId] ASC);

