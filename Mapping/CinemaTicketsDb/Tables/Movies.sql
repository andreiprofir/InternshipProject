CREATE TABLE [dbo].[Movies] (
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
    CONSTRAINT [PK_Movies] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [CK_Movies_AgeLimit] CHECK ([AgeLimit]>=(0)),
    CONSTRAINT [CK_Movies_Duration] CHECK ([Duration]>=(1)),
    CONSTRAINT [CK_Movies_Likes_Dislikes] CHECK ([Likes]>=(0) AND [Dislikes]>=(0)),
    CONSTRAINT [FK_Movies_Entities] FOREIGN KEY ([Id]) REFERENCES [dbo].[Entities] ([Id])
);

