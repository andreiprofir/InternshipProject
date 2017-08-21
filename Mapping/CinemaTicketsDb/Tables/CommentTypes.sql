CREATE TABLE [dbo].[CommentTypes] (
    [Id]   BIGINT        IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (32) NOT NULL,
    CONSTRAINT [PK_CommentTypes] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [AK_CommentTypes_Name] UNIQUE NONCLUSTERED ([Name] ASC)
);

