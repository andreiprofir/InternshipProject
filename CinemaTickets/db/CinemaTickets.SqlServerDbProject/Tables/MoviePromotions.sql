CREATE TABLE [dbo].[MoviePromotions] (
    [MovieId]     BIGINT NOT NULL,
    [PromotionId] BIGINT NOT NULL,
    CONSTRAINT [PK_MoviePromotions] PRIMARY KEY CLUSTERED ([MovieId] ASC, [PromotionId] ASC),
    CONSTRAINT [FK_MoviePromotions_Movies] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movies] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_MoviePromotions_Promotions] FOREIGN KEY ([PromotionId]) REFERENCES [dbo].[Promotions] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_MoviePromotions_PromotionId]
    ON [dbo].[MoviePromotions]([PromotionId] ASC);

