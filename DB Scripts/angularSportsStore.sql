USE [SportsStore.Domain.Entities.EFSportsStoreContext]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [Name]) VALUES (1, N'Watersports')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (2, N'Soccer')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (3, N'Chess')
SET IDENTITY_INSERT [dbo].[Categories] OFF
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [Name], [Description], [CategoryId], [Price]) VALUES (1, N'Kayak', N'A boat for one person', 1, CAST(275.00 AS Decimal(18, 2)))
INSERT [dbo].[Products] ([Id], [Name], [Description], [CategoryId], [Price]) VALUES (4, N'Lifejacket', N'Protective and fashionable', 1, CAST(48.95 AS Decimal(18, 2)))
INSERT [dbo].[Products] ([Id], [Name], [Description], [CategoryId], [Price]) VALUES (5, N'Soccer Ball', N'FIFA-approved size and weight', 2, CAST(19.50 AS Decimal(18, 2)))
INSERT [dbo].[Products] ([Id], [Name], [Description], [CategoryId], [Price]) VALUES (6, N'Corner Flags', N'Give your playing field a professional touch', 2, CAST(34.95 AS Decimal(18, 2)))
INSERT [dbo].[Products] ([Id], [Name], [Description], [CategoryId], [Price]) VALUES (7, N'Stadium', N'Flat-packed 35,000-seat stadium', 2, CAST(79500.00 AS Decimal(18, 2)))
INSERT [dbo].[Products] ([Id], [Name], [Description], [CategoryId], [Price]) VALUES (9, N'Thinking Cap', N'Improve your brain efficiency by 75%', 3, CAST(16.00 AS Decimal(18, 2)))
INSERT [dbo].[Products] ([Id], [Name], [Description], [CategoryId], [Price]) VALUES (10, N'Unsteady Chair', N'Secretly give your opponent a disadvantage', 3, CAST(29.95 AS Decimal(18, 2)))
INSERT [dbo].[Products] ([Id], [Name], [Description], [CategoryId], [Price]) VALUES (11, N'Human Chess Board', N'A fun game for the family', 3, CAST(75.00 AS Decimal(18, 2)))
INSERT [dbo].[Products] ([Id], [Name], [Description], [CategoryId], [Price]) VALUES (12, N'Bling-Bling King', N'Gold-plated, diamond-studded King', 3, CAST(1200.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Products] OFF
