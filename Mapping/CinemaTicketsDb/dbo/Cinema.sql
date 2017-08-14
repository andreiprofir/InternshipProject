CREATE TABLE [dbo].[Cinema] (
    [Id]           BIGINT         NOT NULL,
    [ShortName]    NVARCHAR (128) NOT NULL,
    [FullName]     NVARCHAR (255) NOT NULL,
    [Street]       NVARCHAR (255) NOT NULL,
    [ContactPhone] NVARCHAR (128) NOT NULL,
    [Info]         NVARCHAR (MAX) NULL,
    [Likes]        INT            DEFAULT ((0)) NOT NULL,
    [Dislikes]     INT            DEFAULT ((0)) NOT NULL,
    [CityId]       BIGINT         NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CHECK ([Likes]>=(0) AND [Dislikes]>=(0)),
    CONSTRAINT [FK_CinemaToEntity] FOREIGN KEY ([Id]) REFERENCES [dbo].[Entity] ([Id]),
    CONSTRAINT [FK60624D844FA75CF6] FOREIGN KEY ([CityId]) REFERENCES [dbo].[City] ([Id])
);

