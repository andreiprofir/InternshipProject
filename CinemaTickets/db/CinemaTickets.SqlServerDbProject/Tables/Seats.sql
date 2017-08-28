CREATE TABLE [dbo].[Seats] (
    [Id]           BIGINT        IDENTITY (1, 1) NOT NULL,
    [ColumnNumber] INT           DEFAULT ((0)) NOT NULL,
    [HallId]       BIGINT        NOT NULL,
    [Identifier]   NVARCHAR (32) NOT NULL,
    [IsBusy]       BIT           DEFAULT ((0)) NULL,
    [RowNumber]    INT           DEFAULT ((0)) NOT NULL,
    [SeatTypeId]   BIGINT        NOT NULL,
    CONSTRAINT [PK_Seats] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Seats_Halls] FOREIGN KEY ([HallId]) REFERENCES [dbo].[Halls] ([Id]),
    CONSTRAINT [FK_Seats_SeatTypes] FOREIGN KEY ([SeatTypeId]) REFERENCES [dbo].[SeatTypes] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Seats_HallId]
    ON [dbo].[Seats]([HallId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Seats_SeatTypeId]
    ON [dbo].[Seats]([SeatTypeId] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [AK_Seats_RowNumber_ColumnNumber_HallId]
    ON [dbo].[Seats]([RowNumber] ASC, [ColumnNumber] ASC, [HallId] ASC);

