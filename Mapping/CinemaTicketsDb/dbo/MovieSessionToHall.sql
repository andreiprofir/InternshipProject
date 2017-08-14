CREATE TABLE [dbo].[MovieSessionToHall] (
    [HallId]         BIGINT NOT NULL,
    [MovieSessionId] BIGINT NOT NULL,
    CONSTRAINT [FK743F3C233A468872] FOREIGN KEY ([MovieSessionId]) REFERENCES [dbo].[MovieSession] ([Id]),
    CONSTRAINT [FK743F3C238BD619C6] FOREIGN KEY ([HallId]) REFERENCES [dbo].[Hall] ([Id])
);

