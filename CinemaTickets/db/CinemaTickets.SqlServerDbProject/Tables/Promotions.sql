CREATE TABLE [dbo].[Promotions] (
    [Id]                 BIGINT             NOT NULL,
    [DescriptionOfRules] NVARCHAR (MAX)     NULL,
    [ShortDescription]   NVARCHAR (512)     NULL,
    [Title]              NVARCHAR (255)     NOT NULL,
    [ValidFrom]          DATETIMEOFFSET (7) NULL,
    [ValidTo]            DATETIMEOFFSET (7) NULL,
    CONSTRAINT [PK_Promotions] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Promotions_Entities] FOREIGN KEY ([Id]) REFERENCES [dbo].[Entities] ([Id])
);

