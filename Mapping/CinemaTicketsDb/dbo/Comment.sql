CREATE TABLE [dbo].[Comment] (
    [Id]            BIGINT             IDENTITY (1, 1) NOT NULL,
    [Date]          DATETIMEOFFSET (7) NOT NULL,
    [Likes]         INT                DEFAULT ((0)) NOT NULL,
    [Text]          NVARCHAR (1024)    NOT NULL,
    [UserId]        BIGINT             NOT NULL,
    [EntityId]      BIGINT             NOT NULL,
    [AnswerToId]    BIGINT             NULL,
    [CommentTypeId] BIGINT             NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FKE24667037588C7DD] FOREIGN KEY ([EntityId]) REFERENCES [dbo].[Entity] ([Id]),
    CONSTRAINT [FKE24667038FB2FE54] FOREIGN KEY ([CommentTypeId]) REFERENCES [dbo].[CommentType] ([Id]),
    CONSTRAINT [FKE2466703B3F091CE] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id]),
    CONSTRAINT [FKE2466703D2DA038] FOREIGN KEY ([AnswerToId]) REFERENCES [dbo].[Comment] ([Id])
);

