CREATE TABLE [dbo].[Cinemas] (
    [Id]           BIGINT         NOT NULL,
    [CityId]       BIGINT         NOT NULL,
    [ContactPhone] NVARCHAR (128) NOT NULL,
    [Dislikes]     INT            DEFAULT ((0)) NOT NULL,
    [FullName]     NVARCHAR (255) NOT NULL,
    [Info]         NVARCHAR (MAX) NULL,
    [Likes]        INT            DEFAULT ((0)) NOT NULL,
    [ShortName]    NVARCHAR (128) NOT NULL,
    [Street]       NVARCHAR (255) NOT NULL,
    CONSTRAINT [PK_Cinemas] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Cinemas_Cities] FOREIGN KEY ([CityId]) REFERENCES [dbo].[Cities] ([Id]),
    CONSTRAINT [FK_Cinemas_Entities] FOREIGN KEY ([Id]) REFERENCES [dbo].[Entities] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Cinemas_CityId]
    ON [dbo].[Cinemas]([CityId] ASC);

