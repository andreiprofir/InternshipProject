CREATE TABLE [dbo].[Promotion] (
    [Id]                 BIGINT             NOT NULL,
    [Title]              NVARCHAR (255)     NOT NULL,
    [ShortDescription]   NVARCHAR (512)     NULL,
    [DescriptionOfRules] NVARCHAR (MAX)     NULL,
    [ValidFrom]          DATETIMEOFFSET (7) NULL,
    [ValidTo]            DATETIMEOFFSET (7) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CHECK ([ValidFrom]<[ValidTo]),
    CONSTRAINT [FK_PromotionToEntity] FOREIGN KEY ([Id]) REFERENCES [dbo].[Entity] ([Id])
);

