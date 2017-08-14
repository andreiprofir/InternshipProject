CREATE TABLE [dbo].[Halls] (
    [Id]       BIGINT        NOT NULL IDENTITY(1, 1),
    [Name]     NVARCHAR (50) NOT NULL,
    [Format]   NVARCHAR (50) NOT NULL,
    [CinemaId] BIGINT        NOT NULL,
    CONSTRAINT [PK_Halls] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Halls_Cinemas] FOREIGN KEY ([CinemaId]) REFERENCES [dbo].[Cinemas] ([Id])
);

