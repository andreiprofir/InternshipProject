CREATE TABLE [dbo].[Writers] (
    [Id]        BIGINT        IDENTITY (1, 1) NOT NULL,
    [FirstName] NVARCHAR (64) NOT NULL,
    [LastName]  NVARCHAR (64) NOT NULL,
    CONSTRAINT [PK_Writers] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [AK_Writers_FirstName_LastName]
    ON [dbo].[Writers]([FirstName] ASC, [LastName] ASC);

