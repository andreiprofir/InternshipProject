CREATE TABLE [dbo].[UserRoles] (
    [RoleId] BIGINT NOT NULL,
    [UserId] BIGINT NOT NULL,
    CONSTRAINT [FK_UserRoles_Roles] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[Roles] ([Id]),
    CONSTRAINT [FK_UserRoles_Users] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id]), 
    CONSTRAINT [PK_UserRoles] PRIMARY KEY CLUSTERED ([RoleId], [UserId])
);

