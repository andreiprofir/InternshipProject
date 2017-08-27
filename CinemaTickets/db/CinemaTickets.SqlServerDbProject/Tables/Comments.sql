CREATE TABLE [dbo].[Comments] (
    [Id]            BIGINT             IDENTITY (1, 1) NOT NULL,
    [Date]          DATETIMEOFFSET (7) NOT NULL,
    [Likes]         INT                DEFAULT ((0)) NOT NULL,
    [Text]          NVARCHAR (1024)    NOT NULL,
    [CustomerId]        BIGINT             NOT NULL,
    [EntityId]      BIGINT             NOT NULL,
    [AnswerToId]    BIGINT             NULL,
    [CommentTypeId] BIGINT             NULL,
    CONSTRAINT [PK_Comments] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Comments_Entities] FOREIGN KEY ([EntityId]) REFERENCES [dbo].[Entities] ([Id]),
    CONSTRAINT [FK_Comments_CommentTypes] FOREIGN KEY ([CommentTypeId]) REFERENCES [dbo].[CommentTypes] ([Id]),
    CONSTRAINT [FK_Comments_Customers] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customers] ([Id]),
    CONSTRAINT [FK_Comments_Comments] FOREIGN KEY ([AnswerToId]) REFERENCES [dbo].[Comments] ([Id])
);

