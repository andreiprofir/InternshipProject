CREATE TABLE [dbo].[Movie] (
    [Id]           BIGINT             NOT NULL,
    [Name]         NVARCHAR (255)     NOT NULL,
    [OriginalName] NVARCHAR (255)     NOT NULL,
    [Trailer]      NVARCHAR (1024)    NULL,
    [Duration]     INT                DEFAULT ((1)) NOT NULL,
    [ReleaseDate]  DATETIMEOFFSET (7) NOT NULL,
    [AgeLimit]     INT                DEFAULT ((0)) NOT NULL,
    [ImdbRaiting]  NVARCHAR (255)     NULL,
    [Description]  NVARCHAR (MAX)     NULL,
    [Likes]        INT                DEFAULT ((0)) NOT NULL,
    [Dislikes]     INT                DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CHECK ([AgeLimit]>=(0)),
    CHECK ([Duration]>=(1)),
    CHECK ([Likes]>=(0) AND [Dislikes]>=(0)),
    CONSTRAINT [FK_MovieToEntity] FOREIGN KEY ([Id]) REFERENCES [dbo].[Entity] ([Id])
);

