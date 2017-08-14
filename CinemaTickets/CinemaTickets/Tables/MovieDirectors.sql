CREATE TABLE [dbo].[MovieDirectors]
(
	[MovieId] BIGINT NOT NULL,
	[DirectorId] BIGINT NOT NULL, 
	CONSTRAINT [PK_MovieDirectors] PRIMARY KEY ([MovieId], [DirectorId]),
    CONSTRAINT [FK_MovieDirectors_Movies] FOREIGN KEY ([MovieId]) REFERENCES [Movies]([Id]), 
    CONSTRAINT [FK_MovieDirectors_Directors] FOREIGN KEY ([DirectorId]) REFERENCES [Directors]([Id])
)
