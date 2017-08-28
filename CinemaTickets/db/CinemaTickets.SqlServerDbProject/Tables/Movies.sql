CREATE TABLE [dbo].[Movies] (
    [Id]           BIGINT             NOT NULL,
    [AgeLimit]     INT                DEFAULT ((0)) NOT NULL,
    [Description]  NVARCHAR (MAX)     NULL,
    [Dislikes]     INT                DEFAULT ((0)) NOT NULL,
    [Duration]     INT                DEFAULT ((1)) NOT NULL,
    [ImdbRaiting]  NVARCHAR (255)     NULL,
    [Likes]        INT                DEFAULT ((0)) NOT NULL,
    [Name]         NVARCHAR (255)     NOT NULL,
    [OriginalName] NVARCHAR (255)     NOT NULL,
    [ReleaseDate]  DATETIMEOFFSET (7) NOT NULL,
    [Trailer]      NVARCHAR (1024)    NULL,
    CONSTRAINT [PK_Movies] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Movies_Entities] FOREIGN KEY ([Id]) REFERENCES [dbo].[Entities] ([Id])
);

