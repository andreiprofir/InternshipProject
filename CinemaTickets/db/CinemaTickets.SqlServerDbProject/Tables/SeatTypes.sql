CREATE TABLE [dbo].[SeatTypes] (
    [Id]   BIGINT        IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (64) NOT NULL,
    CONSTRAINT [PK_SeatTypes] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [AK_SeatTypes_Name]
    ON [dbo].[SeatTypes]([Name] ASC);

