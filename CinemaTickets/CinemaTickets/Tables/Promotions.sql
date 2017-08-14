CREATE TABLE [dbo].[Promotions] (
    [Id]                 BIGINT             NOT NULL IDENTITY(1, 1),
    [Title]              NVARCHAR (128)     NOT NULL,
    [ShortDescription]   NVARCHAR (255)     NOT NULL,
    [DescriptionOfRules] NVARCHAR (800)     NULL,
    [ValidFrom]          DATETIMEOFFSET (7) NOT NULL,
    [ValidTo]            DATETIMEOFFSET (7) NOT NULL,
    CONSTRAINT [PK_Promotions] PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Promotions_Entities] FOREIGN KEY ([Id]) REFERENCES [Entities]([Id]),
    CONSTRAINT [CK_Promotions_ValidFrom] CHECK ([ValidFrom] < [ValidTo])
);

