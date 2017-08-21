CREATE TABLE [dbo].[Users] (
    [Id]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [FirstName]   NVARCHAR (64)  NULL,
    [LastName]    NVARCHAR (64)  NULL,
    [Email]       NVARCHAR (255) NOT NULL,
    [Password]    NVARCHAR (128) NOT NULL,
    [Salt]        NVARCHAR (255) NOT NULL,
    [PhoneNumber] NVARCHAR (255) NULL,
    [AvatarId]    BIGINT         NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Users_Pictures] FOREIGN KEY ([AvatarId]) REFERENCES [dbo].[Pictures] ([Id]),
    CONSTRAINT [AK_Users_Email] UNIQUE NONCLUSTERED ([Email] ASC),
    CONSTRAINT [AK_PhoneNumber] UNIQUE NONCLUSTERED ([PhoneNumber] ASC)
);

