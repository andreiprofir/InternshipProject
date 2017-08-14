CREATE TABLE [dbo].[Picture] (
    [Id]       BIGINT          IDENTITY (1, 1) NOT NULL,
    [Uri]      NVARCHAR (1024) NOT NULL,
    [Alt]      NVARCHAR (255)  NULL,
    [EntityId] BIGINT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK9ACA95337588C7DD] FOREIGN KEY ([EntityId]) REFERENCES [dbo].[Entity] ([Id]),
    UNIQUE NONCLUSTERED ([Uri] ASC)
);

