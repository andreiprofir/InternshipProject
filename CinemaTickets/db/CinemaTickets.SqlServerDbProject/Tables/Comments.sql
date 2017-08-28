CREATE TABLE [dbo].[Comments] (
    [Id]            BIGINT             IDENTITY (1, 1) NOT NULL,
    [AnswerToId]    BIGINT             NULL,
    [CommentTypeId] BIGINT             NULL,
    [CustomerId]    BIGINT             NOT NULL,
    [Date]          DATETIMEOFFSET (7) NOT NULL,
    [EntityId]      BIGINT             NOT NULL,
    [Likes]         INT                DEFAULT ((0)) NOT NULL,
    [Text]          NVARCHAR (1024)    NOT NULL,
    CONSTRAINT [PK_Comments] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Comments_Comments] FOREIGN KEY ([AnswerToId]) REFERENCES [dbo].[Comments] ([Id]),
    CONSTRAINT [FK_Comments_CommentTypes] FOREIGN KEY ([CommentTypeId]) REFERENCES [dbo].[CommentTypes] ([Id]),
    CONSTRAINT [FK_Comments_Customers] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Users] ([Id]),
    CONSTRAINT [FK_Comments_Entities] FOREIGN KEY ([EntityId]) REFERENCES [dbo].[Entities] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Comments_AnswerToId]
    ON [dbo].[Comments]([AnswerToId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Comments_CommentTypeId]
    ON [dbo].[Comments]([CommentTypeId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Comments_CustomerId]
    ON [dbo].[Comments]([CustomerId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Comments_EntityId]
    ON [dbo].[Comments]([EntityId] ASC);

