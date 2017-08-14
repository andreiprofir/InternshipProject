CREATE TABLE [dbo].[Movies] (
    [Id]           BIGINT         NOT NULL,
    [Name]         NVARCHAR (128) NOT NULL,
    [OriginalName] NVARCHAR (128) NOT NULL,
    [Trailer]      NVARCHAR (255) NULL,
    [Duration]     INT       NOT NULL,
    [ReleaseDate]  DATE           NULL,
    [AgeLimit]     INT   NOT NULL DEFAULT(0),
    [ImdbRaiting]  NVARCHAR (128) NULL,
    [Description]  NVARCHAR (800) NOT NULL,
    [Likes]        INT            NOT NULL DEFAULT(0),
    [Dislikes]     INT            NOT NULL DEFAULT(0),
    CONSTRAINT [PK_Movies] PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Movies_Entities] FOREIGN KEY ([Id]) REFERENCES [Entities]([Id]), 
    CONSTRAINT [CK_Movies_Likes] CHECK ([Likes] >= 0), 
    CONSTRAINT [CK_Movies_Dislikes] CHECK ([Dislikes] >= 0), 
    CONSTRAINT [CK_Movies_Duration] CHECK ([Duration] > 0)
);

