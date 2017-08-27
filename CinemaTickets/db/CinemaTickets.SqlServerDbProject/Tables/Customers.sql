CREATE TABLE [dbo].[Customers] (
    [Id]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [FirstName]   NVARCHAR (64)  NULL,
    [LastName]    NVARCHAR (64)  NULL,
    [Email]       NVARCHAR (255) NOT NULL,
    [Password]    NVARCHAR (128) NOT NULL,
    [Salt]        NVARCHAR (255) NOT NULL,
    [PhoneNumber] NVARCHAR (255) NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [AK_Customers_Email] UNIQUE NONCLUSTERED ([Email] ASC),
    CONSTRAINT [AK_PhoneNumber] UNIQUE NONCLUSTERED ([PhoneNumber] ASC)
);

