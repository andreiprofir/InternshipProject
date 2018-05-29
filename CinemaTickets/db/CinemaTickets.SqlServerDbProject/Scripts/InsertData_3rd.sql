USE [CinemaTickets]
GO

INSERT INTO [dbo].[Roles] ([ConcurrencyStamp], [Name], [NormalizedName]) VALUES (N'a90ac7f8-db94-4dc9-a1e0-a8c44ec27209', N'admin', N'ADMIN')
INSERT INTO [dbo].[Roles] ([ConcurrencyStamp], [Name], [NormalizedName]) VALUES (N'860a13ac-027f-42e7-b490-57ff01db0b9f', N'user', N'USER')
INSERT INTO [dbo].[Roles] ([ConcurrencyStamp], [Name], [NormalizedName]) VALUES (N'b3dd0fea-f950-48f1-8cd4-de303ef60ae7', N'moderator', N'MODERATOR')


SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName]) 
VALUES (2, 0, N'4e2130ac-d858-4536-9044-aee49c7b9448', N'admin@admin.com', 0, 1, NULL, N'ADMIN@ADMIN.COM', N'ADMIN@ADMIN.COM', N'AQAAAAEAACcQAAAAEDZhY2rqP9M02MZP6ifJw7gBGWxNGmZHtafCY+vqQXuDjQNVcchTcnyHZCchngMeSg==', NULL, 0, N'fafdfb61-424c-4479-be38-7448e6140b5e', 0, N'admin@admin.com')

INSERT [dbo].[Users] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName]) 
VALUES (3, 0, N'97e03a76-3e01-4730-959a-918ed38ab79d', N'user@gmail.com', 0, 1, NULL, N'USER@GMAIL.COM', N'USER@GMAIL.COM', N'AQAAAAEAACcQAAAAEAW6BFCHYQE4hnjyLKL9iaU/8eWUGv+WrQ3SAUsO25PxdoAHDMiCQwNQFV3cEyBBLQ==', NULL, 0, N'07565356-2436-42a0-b1e2-a61a19ae132d', 0, N'user@gmail.com')

SET IDENTITY_INSERT [dbo].[Users] OFF

INSERT [dbo].[UserRoles] ([UserId], [RoleId]) VALUES (2, 1)
INSERT [dbo].[UserRoles] ([UserId], [RoleId]) VALUES (2, 2)
INSERT [dbo].[UserRoles] ([UserId], [RoleId]) VALUES (3, 2)
INSERT [dbo].[UserRoles] ([UserId], [RoleId]) VALUES (2, 3)