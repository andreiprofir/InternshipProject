CREATE TABLE [dbo].[CinemaPromotions] (
    [CinemaId]    BIGINT NOT NULL,
    [PromotionId] BIGINT NOT NULL,
    CONSTRAINT [FK_CinemaPromotions_Promotions] FOREIGN KEY ([PromotionId]) REFERENCES [dbo].[Promotions] ([Id]),
    CONSTRAINT [FK_CinemaPromotions_Cinemas] FOREIGN KEY ([CinemaId]) REFERENCES [dbo].[Cinemas] ([Id]), 
    CONSTRAINT [PK_CinemaPromotions] PRIMARY KEY CLUSTERED ([CinemaId], [PromotionId])
);

