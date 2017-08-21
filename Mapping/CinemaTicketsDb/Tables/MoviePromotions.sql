﻿CREATE TABLE [dbo].[MoviePromotions] (
    [MovieId]     BIGINT NOT NULL,
    [PromotionId] BIGINT NOT NULL,
    CONSTRAINT [FK_MoviePromotions_Promotions] FOREIGN KEY ([PromotionId]) REFERENCES [dbo].[Promotions] ([Id]),
    CONSTRAINT [FK_MoviePromotions_Movies] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movies] ([Id]), 
    CONSTRAINT [PK_MoviePromotions] PRIMARY KEY CLUSTERED ([MovieId], [PromotionId])
);

