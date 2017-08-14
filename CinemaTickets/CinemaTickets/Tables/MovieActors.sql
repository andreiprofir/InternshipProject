CREATE TABLE [dbo].[MovieActors]
(
	[MovieId] BIGINT NOT NULL,
	[ActorId] BIGINT NOT NULL, 
    CONSTRAINT [FK_MovieActors_Movies] FOREIGN KEY ([MovieId]) REFERENCES [Movies]([Id]), 
    CONSTRAINT [FK_MovieActors_Actors] FOREIGN KEY ([ActorId]) REFERENCES [Actors]([Id])
)
