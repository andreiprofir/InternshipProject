CREATE TABLE [dbo].[PromotionMovies] (
    [PromotionId] BIGINT NOT NULL,
    [MovieId]     BIGINT NOT NULL,
    CONSTRAINT [PK_PromotionsMovies] PRIMARY KEY CLUSTERED ([PromotionId] ASC, [MovieId] ASC),
    CONSTRAINT [FK_PromotionsMovies_Movies] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movies] ([Id]),
    CONSTRAINT [FK_PromotionsMovies_Promotions] FOREIGN KEY ([PromotionId]) REFERENCES [dbo].[Promotions] ([Id])
);

