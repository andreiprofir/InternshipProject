CREATE TABLE [dbo].[User] (
    [Id]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [FirstName]   NVARCHAR (64)  NULL,
    [LastName]    NVARCHAR (64)  NULL,
    [Email]       NVARCHAR (255) NOT NULL,
    [Password]    NVARCHAR (128) NOT NULL,
    [Salt]        NVARCHAR (255) NOT NULL,
    [PhoneNumber] NVARCHAR (255) NULL,
    [AvatarId]    BIGINT         NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK7185C17C4FEA1082] FOREIGN KEY ([AvatarId]) REFERENCES [dbo].[Picture] ([Id]),
    UNIQUE NONCLUSTERED ([Email] ASC),
    UNIQUE NONCLUSTERED ([PhoneNumber] ASC)
);

