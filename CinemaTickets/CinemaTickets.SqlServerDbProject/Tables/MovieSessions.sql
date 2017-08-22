CREATE TABLE [dbo].[MovieSessions] (
    [Id]      BIGINT             IDENTITY (1, 1) NOT NULL,
    [Time]    DATETIMEOFFSET (7) NOT NULL,
    [HallId]  BIGINT             NOT NULL,
    [MovieId] BIGINT             NOT NULL,
    CONSTRAINT [PK_MovieSessions] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_MovieSessions_Halls] FOREIGN KEY ([HallId]) REFERENCES [dbo].[Halls] ([Id]),
    CONSTRAINT [FK_MovieSessions_Movies] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movies] ([Id])
);

