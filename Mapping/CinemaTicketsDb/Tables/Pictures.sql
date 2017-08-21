CREATE TABLE [dbo].[Pictures] (
    [Id]       BIGINT          IDENTITY (1, 1) NOT NULL,
    [Uri]      NVARCHAR (1024) NOT NULL,
    [Alt]      NVARCHAR (255)  NULL,
    [EntityId] BIGINT          NOT NULL,
    CONSTRAINT [PK_Pictures] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Pictures_Entities] FOREIGN KEY ([EntityId]) REFERENCES [dbo].[Entities] ([Id]),
    CONSTRAINT [AK_Pictures_Uri] UNIQUE NONCLUSTERED ([Uri] ASC)
);

