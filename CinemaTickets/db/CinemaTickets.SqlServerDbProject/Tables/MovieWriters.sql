CREATE TABLE [dbo].[MovieWriters] (
    [MovieId]  BIGINT NOT NULL,
    [WriterId] BIGINT NOT NULL,
    CONSTRAINT [PK_MovieWriters] PRIMARY KEY CLUSTERED ([MovieId] ASC, [WriterId] ASC),
    CONSTRAINT [FK_MovieWriters_Movies] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movies] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_MovieWriters_Writers] FOREIGN KEY ([WriterId]) REFERENCES [dbo].[Writers] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_MovieWriters_WriterId]
    ON [dbo].[MovieWriters]([WriterId] ASC);

