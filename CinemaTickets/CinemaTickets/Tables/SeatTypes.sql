CREATE TABLE [dbo].[SeatTypes] (
    [Id]   BIGINT        NOT NULL IDENTITY(1, 1),
    [Name] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_SeatTypes] PRIMARY KEY CLUSTERED ([Id] ASC)
);

