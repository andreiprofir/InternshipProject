CREATE TABLE [dbo].[Halls] (
    [Id]       BIGINT         IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (128) NOT NULL,
    [Format]   NVARCHAR (32)  NOT NULL,
    [CinemaId] BIGINT         NOT NULL,
    CONSTRAINT [PK_Halls] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Halls_Cinemas] FOREIGN KEY ([CinemaId]) REFERENCES [dbo].[Cinemas] ([Id])
);

