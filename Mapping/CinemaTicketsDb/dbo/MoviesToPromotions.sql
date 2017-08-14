CREATE TABLE [dbo].[MoviesToPromotions] (
    [MovieId]     BIGINT NOT NULL,
    [PromotionId] BIGINT NOT NULL,
    CONSTRAINT [FKED5378F993D28C92] FOREIGN KEY ([PromotionId]) REFERENCES [dbo].[Promotion] ([Id]),
    CONSTRAINT [FKED5378F9EB6BBFDA] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movie] ([Id])
);

