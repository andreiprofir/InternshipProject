CREATE TABLE [dbo].[CommentType] (
    [Id]   BIGINT        IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (32) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([Name] ASC)
);

