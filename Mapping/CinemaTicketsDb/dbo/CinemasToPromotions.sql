CREATE TABLE [dbo].[CinemasToPromotions] (
    [CinemaId]    BIGINT NOT NULL,
    [PromotionId] BIGINT NOT NULL,
    CONSTRAINT [FK3AA4B8CA93D28C92] FOREIGN KEY ([PromotionId]) REFERENCES [dbo].[Promotion] ([Id]),
    CONSTRAINT [FK3AA4B8CABDA1C6E3] FOREIGN KEY ([CinemaId]) REFERENCES [dbo].[Cinema] ([Id])
);

