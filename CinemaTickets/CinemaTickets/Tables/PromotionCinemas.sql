CREATE TABLE [dbo].[PromotionCinemas] (
    [PromotionId] BIGINT NOT NULL,
    [CinemaId]      BIGINT NOT NULL,
    CONSTRAINT [PK_PromotionCinemas] PRIMARY KEY CLUSTERED ([PromotionId] ASC, [CinemaId] ASC),
    CONSTRAINT [FK_PromotionCinemas_Cinemas] FOREIGN KEY ([CinemaId]) REFERENCES [dbo].[Cinemas] ([Id]),
    CONSTRAINT [FK_PromotionCinemas_Promotions] FOREIGN KEY ([PromotionId]) REFERENCES [dbo].[Promotions] ([Id])
);

