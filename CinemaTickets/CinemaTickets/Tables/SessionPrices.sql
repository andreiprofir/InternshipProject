CREATE TABLE [dbo].[SessionPrices]
(
	[Id] BIGINT NOT NULL IDENTITY(1, 1),
	[MovieSessionId] BIGINT NOT NULL,
	[SeatTypeId] BIGINT NOT NULL,
	[Price] MONEY NOT NULL


	CONSTRAINT [PK_SessionPrices] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [FK_SessionPrices_MovieSessions] FOREIGN KEY ([MovieSessionId]) REFERENCES [MovieSessions] ([Id]),
	CONSTRAINT [FK_SessionPrices_SeatTypes] FOREIGN KEY ([SeatTypeId]) REFERENCES [SeatTypes] ([Id]),
    CONSTRAINT [CK_SessionPrices_Price] CHECK ([Price] > 0)
)
