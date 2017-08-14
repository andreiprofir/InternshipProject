CREATE TABLE [dbo].[MovieWriters]
(
	[MovieId] BIGINT NOT NULL,
	[WriterId] BIGINT NOT NULL, 
    CONSTRAINT [FK_MovieWriters_Movies] FOREIGN KEY ([MovieId]) REFERENCES [Movies]([Id]), 
    CONSTRAINT [FK_MovieWriters_Writers] FOREIGN KEY ([WriterId]) REFERENCES [Writers]([Id])
)
