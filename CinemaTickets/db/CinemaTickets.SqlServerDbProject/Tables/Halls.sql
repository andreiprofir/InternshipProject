CREATE TABLE [dbo].[Halls] (
    [Id]       BIGINT         IDENTITY (1, 1) NOT NULL,
    [CinemaId] BIGINT         NOT NULL,
    [Format]   NVARCHAR (32)  NOT NULL,
    [Name]     NVARCHAR (128) NOT NULL,
    CONSTRAINT [PK_Halls] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Halls_Cinemas] FOREIGN KEY ([CinemaId]) REFERENCES [dbo].[Cinemas] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Halls_CinemaId]
    ON [dbo].[Halls]([CinemaId] ASC);

