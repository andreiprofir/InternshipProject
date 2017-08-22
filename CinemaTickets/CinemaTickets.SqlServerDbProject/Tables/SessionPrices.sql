CREATE TABLE [dbo].[SessionPrices] (
    [Id]             BIGINT IDENTITY (1, 1) NOT NULL,
    [Price]          MONEY  DEFAULT ((0.0)) NOT NULL,
    [MovieSessionId] BIGINT NOT NULL,
    [SeatTypeId]     BIGINT NOT NULL,
    CONSTRAINT [PK_SessionPrices] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [CK_SessionPrices_Price] CHECK ([Price]>=(0)),
    CONSTRAINT [FK_SessionPrices_MovieSessions] FOREIGN KEY ([MovieSessionId]) REFERENCES [dbo].[MovieSessions] ([Id]),
    CONSTRAINT [FK_SessionPrices_SeatTypes] FOREIGN KEY ([SeatTypeId]) REFERENCES [dbo].[SeatTypes] ([Id]),
    CONSTRAINT [AK_SessionPrices_MovieSessionId_SeatTypeId] UNIQUE NONCLUSTERED ([MovieSessionId] ASC, [SeatTypeId] ASC)
);

