CREATE TABLE [dbo].[CommentTypes] (
    [Id]   BIGINT        IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (32) NOT NULL,
    CONSTRAINT [PK_CommentTypes] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [AK_CommentTypes_Name]
    ON [dbo].[CommentTypes]([Name] ASC);

