CREATE TABLE [dbo].[SessionPrice] (
    [Id]             BIGINT IDENTITY (1, 1) NOT NULL,
    [Price]          MONEY  DEFAULT ((0.0)) NOT NULL,
    [MovieSessionId] BIGINT NOT NULL,
    [SeatTypeId]     BIGINT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CHECK ([Price]>=(0)),
    CONSTRAINT [FK991D85773A468872] FOREIGN KEY ([MovieSessionId]) REFERENCES [dbo].[MovieSession] ([Id]),
    CONSTRAINT [FK991D8577B7395BF7] FOREIGN KEY ([SeatTypeId]) REFERENCES [dbo].[SeatType] ([Id]),
    UNIQUE NONCLUSTERED ([MovieSessionId] ASC, [SeatTypeId] ASC)
);

