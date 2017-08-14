CREATE TABLE [dbo].[MovieSessions] (
    [Id]      BIGINT             NOT NULL IDENTITY(1, 1),
    [MovieId] BIGINT             NOT NULL,
    [HallId]  BIGINT             NOT NULL,
    [Time]    DATETIMEOFFSET (7) NULL,
    CONSTRAINT [PK_Sessions] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Sessions_Halls] FOREIGN KEY ([HallId]) REFERENCES [dbo].[Halls] ([Id]),
    CONSTRAINT [FK_Sessions_Movies] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movies] ([Id]),
    CONSTRAINT [AK_MovieSessions_MovieId_HallId_Time] UNIQUE ([MovieId], [HallId], [Time])
);

