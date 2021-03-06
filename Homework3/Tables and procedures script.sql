USE [LogoDb]
GO
/****** Object:  Table [dbo].[companies]    Script Date: 29.03.2022 04:41:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[companies](
	[id] [int] NOT NULL,
	[companyname] [nvarchar](50) NOT NULL,
	[email] [nvarchar](20) NOT NULL,
	[adress] [nvarchar](100) NOT NULL,
	[userid] [int] NOT NULL,
 CONSTRAINT [PK_companies] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 29.03.2022 04:41:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](20) NOT NULL,
	[surname] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([id], [name], [surname]) VALUES (1, N'Jack', N'London')
SET IDENTITY_INSERT [dbo].[users] OFF
GO
ALTER TABLE [dbo].[companies]  WITH CHECK ADD  CONSTRAINT [FK_companies_companies] FOREIGN KEY([id])
REFERENCES [dbo].[companies] ([id])
GO
ALTER TABLE [dbo].[companies] CHECK CONSTRAINT [FK_companies_companies]
GO
/****** Object:  StoredProcedure [dbo].[InsertCompany]    Script Date: 29.03.2022 04:41:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertCompany]
@companyname NVARCHAR(50),      
@email NVARCHAR(20),
@adress NVARCHAR(100),
@userid  INT
AS
BEGIN
INSERT INTO companies
(companies.companyname,email,adress,userid)
VALUES
(@companyname,@email,@adress,@userid)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertUser]    Script Date: 29.03.2022 04:41:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertUser]

@name NVARCHAR(20),
@surname NVARCHAR(30)

AS
BEGIN
INSERT INTO users
(users.name,surname)
VALUES
(@name,@surname)
END
GO
