CREATE TABLE [dbo].[CommentTypes] (
    [Id]   BIGINT        NOT NULL IDENTITY(1, 1),
    [Name] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_CommentTypes] PRIMARY KEY CLUSTERED ([Id] ASC)
);

