CREATE TABLE [dbo].[Comments] (
    [Id]            BIGINT             NOT NULL IDENTITY(1, 1),
    [UserId]        BIGINT             NOT NULL,
    [Date]          DATETIMEOFFSET (7) NOT NULL,
    [Likes]         INT                NOT NULL,
    [Link]          BIGINT             NULL,
    [Text]          NVARCHAR (512)     NOT NULL,
    [CommentTypeId] BIGINT             NULL,
    [EntityId] BIGINT NOT NULL, 
    CONSTRAINT [PK_Comments] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Comments_Comments] FOREIGN KEY ([Link]) REFERENCES [dbo].[Comments] ([Id]),
    CONSTRAINT [FK_Comments_CommentTypes] FOREIGN KEY ([CommentTypeId]) REFERENCES [dbo].[CommentTypes] ([Id]), 
    CONSTRAINT [FK_Comments_Entities] FOREIGN KEY ([EntityId]) REFERENCES [Entities]([Id])
);

