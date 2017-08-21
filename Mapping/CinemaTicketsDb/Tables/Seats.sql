CREATE TABLE [dbo].[Seats] (
    [Id]           BIGINT        IDENTITY (1, 1) NOT NULL,
    [Identifier]   NVARCHAR (32) NOT NULL,
    [RowNumber]    INT           DEFAULT ((0)) NOT NULL,
    [ColumnNumber] INT           DEFAULT ((0)) NOT NULL,
    [IsBusy]       BIT           DEFAULT ((0)) NOT NULL,
    [HallId]       BIGINT        NOT NULL,
    [SeatTypeId]   BIGINT        NOT NULL,
    CONSTRAINT [PK_Seats] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [CK_Seats_RowNumber_ColumnNumber] CHECK ([RowNumber]>=(0) AND [ColumnNumber]>=(0)),
    CONSTRAINT [FK_Seats_Halls] FOREIGN KEY ([HallId]) REFERENCES [dbo].[Halls] ([Id]),
    CONSTRAINT [FK_Seats_SeatTypes] FOREIGN KEY ([SeatTypeId]) REFERENCES [dbo].[SeatTypes] ([Id]),
    CONSTRAINT [AK_Seats_RowNumber_ColumnNumber_HallId] UNIQUE NONCLUSTERED ([RowNumber] ASC, [ColumnNumber] ASC, [HallId] ASC)
);

