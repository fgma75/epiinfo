﻿USE [OSELS_EIWS]
GO

/****** Object:  Table [dbo].[lk_Status]    Script Date: 02/07/2012 15:39:59 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[lk_Status]') AND type in (N'U'))
DROP TABLE [dbo].[lk_Status]
GO

USE [OSELS_EIWS]
GO

/****** Object:  Table [dbo].[lk_Status]    Script Date: 02/07/2012 15:39:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[lk_Status](
      [StatusId] [int] NOT NULL,
      [Status] [nvarchar](20) NOT NULL,
CONSTRAINT [PK_lk_Status] PRIMARY KEY CLUSTERED 
(
      [StatusId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [OSELS_EIWS]
GO

/****** Object:  Table [dbo].[lk_SurveyType]    Script Date: 02/07/2012 15:40:30 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[lk_SurveyType]') AND type in (N'U'))
DROP TABLE [dbo].[lk_SurveyType]
GO

USE [OSELS_EIWS]
GO

/****** Object:  Table [dbo].[lk_SurveyType]    Script Date: 02/07/2012 15:40:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[lk_SurveyType](
      [SurveyTypeId] [int] NOT NULL,
      [SurveyType] [varchar](50) NULL,
CONSTRAINT [PK_lk_SurveyType] PRIMARY KEY CLUSTERED 
(
      [SurveyTypeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


USE [OSELS_EIWS]
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SurveyMetaData_lk_SurveyType]') AND parent_object_id = OBJECT_ID(N'[dbo].[SurveyMetaData]'))
ALTER TABLE [dbo].[SurveyMetaData] DROP CONSTRAINT [FK_SurveyMetaData_lk_SurveyType]
GO

USE [OSELS_EIWS]
GO

/************************************************************SurveyMetaData*********************************************/

USE [OSELS_EIWS]
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SurveyMetaData_lk_SurveyType]') AND parent_object_id = OBJECT_ID(N'[dbo].[SurveyMetaData]'))
ALTER TABLE [dbo].[SurveyMetaData] DROP CONSTRAINT [FK_SurveyMetaData_lk_SurveyType]
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SurveyMetaData_SurveySecurityKey]') AND parent_object_id = OBJECT_ID(N'[dbo].[SurveyMetaData]'))
ALTER TABLE [dbo].[SurveyMetaData] DROP CONSTRAINT [FK_SurveyMetaData_SurveySecurityKey]
GO

USE [OSELS_EIWS]
GO

/****** Object:  Table [dbo].[SurveyMetaData]    Script Date: 04/20/2012 11:26:33 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SurveyMetaData]') AND type in (N'U'))
DROP TABLE [dbo].[SurveyMetaData]
GO

USE [OSELS_EIWS]
GO

/****** Object:  Table [dbo].[SurveyMetaData]    Script Date: 04/20/2012 11:26:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SurveyMetaData](
	[SurveyId] [uniqueidentifier] NOT NULL,
	[SurveyNumber] [nvarchar](20) NULL,
	[SurveyTypeId] [int] NOT NULL,
	[ClosingDate] [datetime2](7) NOT NULL,
	[SurveyName] [nvarchar](255) NOT NULL,
	[OrganizationName] [nvarchar](100) NULL,
	[DepartmentName] [nvarchar](100) NULL,
	[IntroductionText] [nvarchar](max) NOT NULL,
	[TemplateXML] [xml] NOT NULL,
	[ExitText] [nvarchar](max) NULL,
	[UserPublishKey] [uniqueidentifier] NULL,
	[TemplateXMLSize] [bigint] NULL,
	[SecurityKey] [uniqueidentifier] NULL,
 CONSTRAINT [PK_SurveyMetaData] PRIMARY KEY CLUSTERED 
(
	[SurveyId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[SurveyMetaData]  WITH CHECK ADD  CONSTRAINT [FK_SurveyMetaData_lk_SurveyType] FOREIGN KEY([SurveyTypeId])
REFERENCES [dbo].[lk_SurveyType] ([SurveyTypeId])
GO

ALTER TABLE [dbo].[SurveyMetaData] CHECK CONSTRAINT [FK_SurveyMetaData_lk_SurveyType]
GO

ALTER TABLE [dbo].[SurveyMetaData]  WITH CHECK ADD  CONSTRAINT [FK_SurveyMetaData_SurveySecurityKey] FOREIGN KEY([SecurityKey])
REFERENCES [dbo].[SurveySecurityKey] ([SecurityKey])
GO

ALTER TABLE [dbo].[SurveyMetaData] CHECK CONSTRAINT [FK_SurveyMetaData_SurveySecurityKey]
GO


/*********************************************************SurveyResponse*************************************************/

USE [OSELS_EIWS]
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SurveyResponse_lk_Status]') AND parent_object_id = OBJECT_ID(N'[dbo].[SurveyResponse]'))
ALTER TABLE [dbo].[SurveyResponse] DROP CONSTRAINT [FK_SurveyResponse_lk_Status]
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SurveyResponse_SurveyMetaData]') AND parent_object_id = OBJECT_ID(N'[dbo].[SurveyResponse]'))
ALTER TABLE [dbo].[SurveyResponse] DROP CONSTRAINT [FK_SurveyResponse_SurveyMetaData]
GO

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_SurveyResponse_DateLastUpdated]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[SurveyResponse] DROP CONSTRAINT [DF_SurveyResponse_DateLastUpdated]
END

GO

USE [OSELS_EIWS]
GO

/****** Object:  Table [dbo].[SurveyResponse]    Script Date: 04/20/2012 11:28:21 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SurveyResponse]') AND type in (N'U'))
DROP TABLE [dbo].[SurveyResponse]
GO

USE [OSELS_EIWS]
GO

/****** Object:  Table [dbo].[SurveyResponse]    Script Date: 04/20/2012 11:28:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SurveyResponse](
	[ResponseId] [uniqueidentifier] NOT NULL,
	[SurveyId] [uniqueidentifier] NOT NULL,
	[DateLastUpdated] [datetime2](7) NOT NULL,
	[DateCompleted] [datetime2](7) NULL,
	[StatusId] [int] NOT NULL,
	[ResponseXML] [xml] NOT NULL,
	[ResponsePasscode] [nvarchar](30) NULL,
	[ResponseXMLSize] [uniqueidentifier] NULL,
	[SortNumber] [bigint] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_SurveyResponse] PRIMARY KEY CLUSTERED 
(
	[ResponseId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[SurveyResponse]  WITH CHECK ADD  CONSTRAINT [FK_SurveyResponse_lk_Status] FOREIGN KEY([StatusId])
REFERENCES [dbo].[lk_Status] ([StatusId])
GO

ALTER TABLE [dbo].[SurveyResponse] CHECK CONSTRAINT [FK_SurveyResponse_lk_Status]
GO

ALTER TABLE [dbo].[SurveyResponse]  WITH CHECK ADD  CONSTRAINT [FK_SurveyResponse_SurveyMetaData] FOREIGN KEY([SurveyId])
REFERENCES [dbo].[SurveyMetaData] ([SurveyId])
GO

ALTER TABLE [dbo].[SurveyResponse] CHECK CONSTRAINT [FK_SurveyResponse_SurveyMetaData]
GO

ALTER TABLE [dbo].[SurveyResponse] ADD  CONSTRAINT [DF_SurveyResponse_DateLastUpdated]  DEFAULT (getdate()) FOR [DateLastUpdated]
GO

/************************************************SurveySecurityKey*********************************************************************/

USE [OSELS_EIWS]
GO

/****** Object:  Table [dbo].[SurveySecurityKey]    Script Date: 04/20/2012 11:29:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SurveySecurityKey]') AND type in (N'U'))
DROP TABLE [dbo].[SurveySecurityKey]
GO

USE [OSELS_EIWS]
GO

/****** Object:  Table [dbo].[SurveySecurityKey]    Script Date: 04/20/2012 11:29:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[SurveySecurityKey](
	[SecurityKey] [uniqueidentifier] NOT NULL,
	[UserName] [nvarchar](30) NOT NULL,
	[Department] [nvarchar](50) NULL,
	[UserType] [char](10) NULL,
 CONSTRAINT [PK_SurveySecurityKey] PRIMARY KEY CLUSTERED 
(
	[SecurityKey] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO



-- INFORMATION: The below section was NOT autogenerated by SQL Server


INSERT INTO [OSELS_EIWS].[dbo].[lk_Status]
           ([StatusId]
           ,[Status])
     VALUES
           (1
           ,'In Progress')
GO

INSERT INTO [OSELS_EIWS].[dbo].[lk_Status]
           ([StatusId]
           ,[Status])
     VALUES
           (2
           ,'In Progress (URL)')
GO

INSERT INTO [OSELS_EIWS].[dbo].[lk_Status]
           ([StatusId]
           ,[Status])
     VALUES
           (3
           ,'Complete')
GO
INSERT INTO [OSELS_EIWS].[dbo].[lk_SurveyType]
           ([SurveyTypeId]
           ,[SurveyType])
     VALUES
           (1
           ,'Single Response')
GO

INSERT INTO [OSELS_EIWS].[dbo].[lk_SurveyType]
           ([SurveyTypeId]
           ,[SurveyType])
     VALUES
           (2
           ,'Multiple Response')
GO