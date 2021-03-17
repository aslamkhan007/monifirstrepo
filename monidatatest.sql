USE [test]
GO
/****** Object:  Table [dbo].[cc]    Script Date: 03/17/2021 07:40:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cc](
	[id] [int] NULL,
	[NAME] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[abctest]    Script Date: 03/17/2021 07:40:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[abctest](
	[id] [int] NULL,
	[NAME] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[abctest] ([id], [NAME]) VALUES (1, N'salim')
INSERT [dbo].[abctest] ([id], [NAME]) VALUES (2, N'monu')
INSERT [dbo].[abctest] ([id], [NAME]) VALUES (2, N'hello')
INSERT [dbo].[abctest] ([id], [NAME]) VALUES (22, N'TEST1')
INSERT [dbo].[abctest] ([id], [NAME]) VALUES (23, N'salim')
INSERT [dbo].[abctest] ([id], [NAME]) VALUES (23, N'salim')
/****** Object:  Table [dbo].[productdiscription]    Script Date: 03/17/2021 07:40:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[productdiscription](
	[productiD] [int] NULL,
	[productdiscription] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[productdiscription] ([productiD], [productdiscription]) VALUES (680, N'replacement')
INSERT [dbo].[productdiscription] ([productiD], [productdiscription]) VALUES (405, N'deliver')
/****** Object:  Table [dbo].[product]    Script Date: 03/17/2021 07:40:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[product](
	[productiD] [int] NULL,
	[productName] [varchar](30) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[product] ([productiD], [productName]) VALUES (680, N'frame and black ')
INSERT [dbo].[product] ([productiD], [productName]) VALUES (703, N'dcold')
/****** Object:  StoredProcedure [dbo].[NAMEupd]    Script Date: 03/17/2021 07:40:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[NAMEupd] 
@id INT ,
@name VARCHAR (50)
AS

BEGIN 


UPDATE dbo.abctest 
SET NAME = @name
WHERE id = @id

END
GO
/****** Object:  StoredProcedure [dbo].[NAME]    Script Date: 03/17/2021 07:40:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--EXEC NAME 22,'TEST1'  
CREATE PROC [dbo].[NAME]     
@id INT ,    
@name VARCHAR (50)    
AS    
    
BEGIN     
INSERT INTO dbo.abctest     
        ( id, NAME )    
VALUES  ( @id ,@name     
              
          )    
          --DELETE  dbo.abctest WHERE id = @id    
--SELECT * FROM  dbo.abctest     
END
GO
/****** Object:  StoredProcedure [dbo].[idtest]    Script Date: 03/17/2021 07:40:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[idtest]
@id int ,@name varchar (50)
AS

BEGIN 
INSERT INTO dbo.abctest
        ( id, NAME )
VALUES  ( @id,@name
          )
 
END
GO
/****** Object:  StoredProcedure [dbo].[Fetchabc]    Script Date: 03/17/2021 07:40:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC	 [dbo].[Fetchabc]
@id INT,
@name varchar (50)
AS
BEGIN
	 
	--SELECT * FROM  abctest WHERE NAME= @name
--UPDATE dbo.abctest 
--SET id=@id
--WHERE id =4

DELETE dbo.abctest WHERE id =@id

--INSERT INTO dbo.abctest
--        ( id,name )
--VALUES  ( @id,@name
--          )
END
GO
