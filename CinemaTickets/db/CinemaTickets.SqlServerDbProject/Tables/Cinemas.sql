CREATE TABLE [dbo].[Cinemas] (
    [Id]           BIGINT         NOT NULL,
    [ShortName]    NVARCHAR (128) NOT NULL,
    [FullName]     NVARCHAR (255) NOT NULL,
    [Street]       NVARCHAR (255) NOT NULL,
    [ContactPhone] NVARCHAR (128) NOT NULL,
    [Info]         NVARCHAR (MAX) NULL,
    [Likes]        INT            DEFAULT ((0)) NOT NULL,
    [Dislikes]     INT            DEFAULT ((0)) NOT NULL,
    [CityId]       BIGINT         NOT NULL,
    CONSTRAINT [PK_Cinemas] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [CK_Cinemas_Likes_Dislikes] CHECK ([Likes]>=(0) AND [Dislikes]>=(0)),
    CONSTRAINT [FK_Cinemas_Entities] FOREIGN KEY ([Id]) REFERENCES [dbo].[Entities] ([Id]),
    CONSTRAINT [FK_Cinemas_Cities] FOREIGN KEY ([CityId]) REFERENCES [dbo].[Cities] ([Id])
);

