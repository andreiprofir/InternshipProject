CREATE TABLE [dbo].[Seats] (
    [Id]			BIGINT			NOT NULL IDENTITY(1, 1),
    [Identifier]    NVARCHAR(10)	NOT NULL,
    [RowNumber]		INT				NOT NULL,
	[ColumnNumber]	INT				NOT NULL,
    [IsBusy]		BIT				NOT NULL,
	[SeatTypeId]	BIGINT			NOT NULL,
	[HallId]		BIGINT			NOT NULL,
    CONSTRAINT [PK_Seats]			PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Seats_SeatTypes] FOREIGN KEY ([SeatTypeId])	REFERENCES [SeatTypes] ([Id]),
	CONSTRAINT [FK_Seats_Halls]		FOREIGN KEY ([HallId])		REFERENCES [Halls] ([Id]),
    CONSTRAINT [CK_Seats_RowNumber_ColumnNumber] CHECK ([RowNumber] >= 1 AND [ColumnNumber] >= 1), 
    CONSTRAINT [AK_Seats_RowNumber_ColumnNumber_HallId] UNIQUE ([RowNumber], [ColumnNumber], [HallId])
);

