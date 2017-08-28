CREATE TABLE [dbo].[Pictures] (
    [Id]       BIGINT          IDENTITY (1, 1) NOT NULL,
    [Alt]      NVARCHAR (255)  NULL,
    [EntityId] BIGINT          NOT NULL,
    [Uri]      NVARCHAR (1024) NOT NULL,
    CONSTRAINT [PK_Pictures] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Pictures_Entities] FOREIGN KEY ([EntityId]) REFERENCES [dbo].[Entities] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Pictures_EntityId]
    ON [dbo].[Pictures]([EntityId] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [AK_Pictures_Uri]
    ON [dbo].[Pictures]([Uri] ASC);

