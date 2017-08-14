CREATE TABLE [dbo].[Users] (
    [Id]          BIGINT        NOT NULL,
    [FirstName]   NVARCHAR (50) NULL,
    [LastName]    NVARCHAR (50) NULL,
    [Email]       NVARCHAR (128) NOT NULL,
    [Password]    NVARCHAR (128) NOT NULL,
	[Salt] NVARCHAR(50) NOT NULL,
    [PhoneNumber] NVARCHAR (50) NULL,
    [RoleId]      BIGINT        NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Users_Roles] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[Roles] ([Id]),
    CONSTRAINT [FK_Users_Entities] FOREIGN KEY ([Id]) REFERENCES [Entities]([Id])
);

