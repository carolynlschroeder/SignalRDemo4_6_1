USE [SignalRDemo]
GO
/****** Object:  Table [dbo].[Image]    Script Date: 6/10/2016 2:14:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Image](
	[ImageId] [uniqueidentifier] NOT NULL,
	[ImageName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Image] PRIMARY KEY CLUSTERED 
(
	[ImageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserLikes]    Script Date: 6/10/2016 2:14:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserLikes](
	[UserLikesId] [uniqueidentifier] NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ImageId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_UserLikes] PRIMARY KEY CLUSTERED 
(
	[UserLikesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Image] ([ImageId], [ImageName]) VALUES (N'6598bc8a-aa28-4954-90c2-017d34ffb04a', N'460.jpg')
INSERT [dbo].[Image] ([ImageId], [ImageName]) VALUES (N'164a907b-eb87-483e-9b42-16f78cdb545a', N'462.jpg')
INSERT [dbo].[Image] ([ImageId], [ImageName]) VALUES (N'3bd30e18-5097-4f52-a1ad-5c25de7461c2', N'458.jpg')
INSERT [dbo].[Image] ([ImageId], [ImageName]) VALUES (N'82080192-6506-40b5-b22e-73313f2fff69', N'457.jpg')
INSERT [dbo].[Image] ([ImageId], [ImageName]) VALUES (N'5cda1543-34ef-413c-bd73-ada8ff98c800', N'461.jpg')
INSERT [dbo].[Image] ([ImageId], [ImageName]) VALUES (N'b50dde0e-6e6b-4f2b-95c1-c04ed523c24e', N'463.jpg')
INSERT [dbo].[Image] ([ImageId], [ImageName]) VALUES (N'69997f4a-a8f9-4167-91ed-c862f36b0b0f', N'459.jpg')
INSERT [dbo].[Image] ([ImageId], [ImageName]) VALUES (N'97fa3eb5-2545-4618-9462-ed40e9209ab0', N'464.jpg')
INSERT [dbo].[UserLikes] ([UserLikesId], [UserId], [ImageId]) VALUES (N'6904ab0d-ab46-4233-8597-3e1a36cc1ff8', N'4c9290d9-1488-4255-a71d-59df196145e9', N'164a907b-eb87-483e-9b42-16f78cdb545a')
INSERT [dbo].[UserLikes] ([UserLikesId], [UserId], [ImageId]) VALUES (N'01094295-a7e8-4244-8e78-8647c7dc2505', N'4c9290d9-1488-4255-a71d-59df196145e9', N'6598bc8a-aa28-4954-90c2-017d34ffb04a')
INSERT [dbo].[UserLikes] ([UserLikesId], [UserId], [ImageId]) VALUES (N'fa3750e8-6c8a-46ea-9278-e4f01eb76fdd', N'37cec18e-2c9a-4e53-8058-dd9d43b43b28', N'6598bc8a-aa28-4954-90c2-017d34ffb04a')
ALTER TABLE [dbo].[UserLikes]  WITH CHECK ADD  CONSTRAINT [FK_UserLikes_Image] FOREIGN KEY([ImageId])
REFERENCES [dbo].[Image] ([ImageId])
GO
ALTER TABLE [dbo].[UserLikes] CHECK CONSTRAINT [FK_UserLikes_Image]
GO
