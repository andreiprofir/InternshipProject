CREATE TABLE [dbo].[CinemaPromotions] (
    [CinemaId]    BIGINT NOT NULL,
    [PromotionId] BIGINT NOT NULL,
    CONSTRAINT [PK_CinemaPromotions] PRIMARY KEY CLUSTERED ([CinemaId] ASC, [PromotionId] ASC),
    CONSTRAINT [FK_CinemaPromotions_Cinemas] FOREIGN KEY ([CinemaId]) REFERENCES [dbo].[Cinemas] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_CinemaPromotions_Promotions] FOREIGN KEY ([PromotionId]) REFERENCES [dbo].[Promotions] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_CinemaPromotions_PromotionId]
    ON [dbo].[CinemaPromotions]([PromotionId] ASC);

