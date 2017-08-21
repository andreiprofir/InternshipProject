CREATE TABLE [dbo].[MovieWriters] (
    [MovieId]  BIGINT NOT NULL,
    [WriterId] BIGINT NOT NULL,
    CONSTRAINT [FK_MovieWriters_Writers] FOREIGN KEY ([WriterId]) REFERENCES [dbo].[Writers] ([Id]),
    CONSTRAINT [FK_MovieWriters_Movies] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movies] ([Id]), 
    CONSTRAINT [PK_MovieWriters] PRIMARY KEY CLUSTERED ([MovieId], [WriterId])
);

