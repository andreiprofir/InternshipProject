CREATE TABLE [dbo].[Cinemas] (
    [Id]           BIGINT         NOT NULL,
    [ShortName]    NVARCHAR (128) NOT NULL,
    [FullName]     NVARCHAR (255) NOT NULL,
    [CityId]     BIGINT NOT NULL,
    [Street]       NVARCHAR (150) NOT NULL,
    [ContactPhone] NVARCHAR (50)  NOT NULL,
    [Info]         NVARCHAR (800) NULL,
    [Likes]        INT            NOT NULL DEFAULT (0),
    [Dislikes]     INT            NOT NULL DEFAULT (0),
    CONSTRAINT [PK_Cinemas] PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Cinemas_Entities] FOREIGN KEY ([Id]) REFERENCES [Entities]([Id]),
    CONSTRAINT [FK_Cinemas_Cities] FOREIGN KEY ([CityId]) REFERENCES [Cities]([Id]),
    CONSTRAINT [CK_Cinemas_Likes] CHECK ([Likes] >= 0), 
    CONSTRAINT [CK_Cinemas_Dislikes] CHECK ([Dislikes] >= 0), 
);

