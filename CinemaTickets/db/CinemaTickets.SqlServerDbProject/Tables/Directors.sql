CREATE TABLE [dbo].[Directors] (
    [Id]        BIGINT        IDENTITY (1, 1) NOT NULL,
    [FirstName] NVARCHAR (64) NOT NULL,
    [LastName]  NVARCHAR (64) NOT NULL,
    CONSTRAINT [PK_Directors] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [AK_Directors_FirstName_LastName]
    ON [dbo].[Directors]([FirstName] ASC, [LastName] ASC);

