CREATE TABLE [dbo].[Seat] (
    [Id]           BIGINT        IDENTITY (1, 1) NOT NULL,
    [Identifier]   NVARCHAR (32) NOT NULL,
    [RowNumber]    INT           DEFAULT ((0)) NOT NULL,
    [ColumnNumber] INT           DEFAULT ((0)) NOT NULL,
    [IsBusy]       BIT           DEFAULT ((0)) NOT NULL,
    [HallId]       BIGINT        NOT NULL,
    [SeatTypeId]   BIGINT        NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CHECK ([RowNumber]>=(0) AND [ColumnNumber]>=(0)),
    CONSTRAINT [FKD00BEF128BD619C6] FOREIGN KEY ([HallId]) REFERENCES [dbo].[Hall] ([Id]),
    CONSTRAINT [FKD00BEF12B7395BF7] FOREIGN KEY ([SeatTypeId]) REFERENCES [dbo].[SeatType] ([Id]),
    UNIQUE NONCLUSTERED ([RowNumber] ASC, [ColumnNumber] ASC, [HallId] ASC)
);

