CREATE TABLE [dbo].[Promotions] (
    [Id]                 BIGINT             NOT NULL,
    [Title]              NVARCHAR (255)     NOT NULL,
    [ShortDescription]   NVARCHAR (512)     NULL,
    [DescriptionOfRules] NVARCHAR (MAX)     NULL,
    [ValidFrom]          DATETIMEOFFSET (7) NULL,
    [ValidTo]            DATETIMEOFFSET (7) NULL,
    CONSTRAINT [PK_Promotions] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [CK_Promotions_ValidFrom_ValidTo] CHECK ([ValidFrom]<[ValidTo]),
    CONSTRAINT [FK_Promotions_Entities] FOREIGN KEY ([Id]) REFERENCES [dbo].[Entities] ([Id])
);

