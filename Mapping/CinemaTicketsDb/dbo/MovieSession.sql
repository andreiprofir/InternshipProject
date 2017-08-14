CREATE TABLE [dbo].[MovieSession] (
    [Id]      BIGINT             IDENTITY (1, 1) NOT NULL,
    [Time]    DATETIMEOFFSET (7) NOT NULL,
    [HallId]  BIGINT             NOT NULL,
    [MovieId] BIGINT             NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK433775A18BD619C6] FOREIGN KEY ([HallId]) REFERENCES [dbo].[Hall] ([Id]),
    CONSTRAINT [FK433775A1EB6BBFDA] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movie] ([Id])
);

