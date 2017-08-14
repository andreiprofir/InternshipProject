USE [CinemaTicketsTest]
GO

ALTER TABLE [MoviesGenres]
	ADD CONSTRAINT [FK_MoviesGenres_Movies] FOREIGN KEY ([MovieId]) REFERENCES [Movies]([Id])
GO

ALTER TABLE [MoviesGenres]
	ADD CONSTRAINT [FK_MoviesGenres_Genres] FOREIGN KEY ([GenreId]) REFERENCES [Genres]([Id])
GO