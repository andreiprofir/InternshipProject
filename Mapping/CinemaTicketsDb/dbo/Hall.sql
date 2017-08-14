CREATE TABLE [dbo].[Hall] (
    [Id]       BIGINT         IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (128) NOT NULL,
    [Format]   NVARCHAR (32)  NOT NULL,
    [CinemaId] BIGINT         NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK47A2A806BDA1C6E3] FOREIGN KEY ([CinemaId]) REFERENCES [dbo].[Cinema] ([Id])
);

