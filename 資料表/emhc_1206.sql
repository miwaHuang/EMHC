USE [EMHC1]
GO
/****** Object:  Table [dbo].[EMHC_ACS_DOCTOR]    Script Date: 2024/12/6 下午 03:01:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMHC_ACS_DOCTOR](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[MAIN_ID] [bigint] NOT NULL,
	[CATEGORY] [int] NOT NULL,
	[NAME] [nvarchar](15) NULL,
	[SPECIALIST_CERT] [nvarchar](15) NULL,
	[LICENSE] [nvarchar](15) NULL,
	[SUPPORT_TIME] [nvarchar](50) NULL,
	[REMARKS] [nvarchar](50) NULL,
	[CT_UID] [nvarchar](15) NULL,
	[CT_DATE] [datetime] NOT NULL,
	[UP_UID] [nvarchar](15) NULL,
	[UP_DATE] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMHC_ACS_PCI_TIME]    Script Date: 2024/12/6 下午 03:01:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMHC_ACS_PCI_TIME](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[MAIN_ID] [bigint] NOT NULL,
	[CATEGORY] [int] NOT NULL,
	[ITEM] [int] NOT NULL,
	[WEEKDAY] [decimal](18, 2) NULL,
	[ALL_TIME] [decimal](18, 2) NULL,
	[CT_UID] [nvarchar](15) NULL,
	[CT_DATE] [datetime] NOT NULL,
	[UP_UID] [nvarchar](15) NULL,
	[UP_DATE] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMHC_ACS_TEAM]    Script Date: 2024/12/6 下午 03:01:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMHC_ACS_TEAM](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[MAIN_ID] [bigint] NOT NULL,
	[CATEGORY] [int] NOT NULL,
	[NUMBER] [int] NULL,
	[FULL_TIME_DOCS] [int] NULL,
	[SUPPORT_DOCS] [int] NULL,
	[SUPPORT_HOURS] [nvarchar](15) NULL,
	[CT_UID] [nvarchar](15) NULL,
	[CT_DATE] [datetime] NOT NULL,
	[UP_UID] [nvarchar](15) NULL,
	[UP_DATE] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMHC_CONSULTANT]    Script Date: 2024/12/6 下午 03:01:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMHC_CONSULTANT](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[MAIN_ID] [bigint] NOT NULL,
	[LEVEL] [int] NOT NULL,
	[CATEGORY] [int] NOT NULL,
	[NUMBER] [int] NULL,
	[CT_UID] [nvarchar](15) NULL,
	[CT_DATE] [datetime] NOT NULL,
	[UP_UID] [nvarchar](15) NULL,
	[UP_DATE] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMHC_ICU]    Script Date: 2024/12/6 下午 03:01:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMHC_ICU](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[MAIN_ID] [bigint] NOT NULL,
	[NAME] [nvarchar](50) NOT NULL,
	[SORT] [int] NOT NULL,
	[CT_UID] [nvarchar](15) NULL,
	[CT_DATE] [datetime] NOT NULL,
	[UP_UID] [nvarchar](15) NULL,
	[UP_DATE] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMHC_MAIN]    Script Date: 2024/12/6 下午 03:01:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMHC_MAIN](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[YEAR] [int] NOT NULL,
	[MONTH] [int] NOT NULL,
	[HOSPITAL_CODE] [nvarchar](10) NOT NULL,
	[CT_UID] [nvarchar](max) NULL,
	[CT_DATE] [datetime2](7) NOT NULL,
	[UP_UID] [nvarchar](max) NULL,
	[UP_DATE] [datetime2](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMHC_REQUIRE_SERVICE]    Script Date: 2024/12/6 下午 03:01:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMHC_REQUIRE_SERVICE](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[MAIN_ID] [bigint] NOT NULL,
	[ICU_BEDS] [int] NULL,
	[ICU_DOCS] [int] NULL,
	[YEARLY_VISITS] [decimal](18, 2) NULL,
	[MONTHLY_REQ] [nvarchar](15) NULL,
	[MONTHLY_REG] [nvarchar](15) NULL,
	[HAS_24H_EMERGENCY] [bit] NULL,
	[REQ_DOCS] [nvarchar](15) NULL,
	[REG_DOCS] [nvarchar](15) NULL,
	[CT_UID] [nvarchar](15) NULL,
	[CT_DATE] [datetime] NOT NULL,
	[UP_UID] [nvarchar](15) NULL,
	[UP_DATE] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMHC_REQUIRE_SERVICE_NUMBER]    Script Date: 2024/12/6 下午 03:01:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMHC_REQUIRE_SERVICE_NUMBER](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[MAIN_ID] [bigint] NOT NULL,
	[LEVEL] [int] NOT NULL,
	[CATEGORY] [int] NOT NULL,
	[REQUIRED] [decimal](18, 2) NULL,
	[REGISTERED] [decimal](18, 2) NULL,
	[CT_UID] [nvarchar](15) NULL,
	[CT_DATE] [datetime] NOT NULL,
	[UP_UID] [nvarchar](15) NULL,
	[UP_DATE] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMHC_SERVICE]    Script Date: 2024/12/6 下午 03:01:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMHC_SERVICE](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[MAIN_ID] [bigint] NOT NULL,
	[CATEGORY] [int] NOT NULL,
	[NUMBER] [int] NOT NULL,
	[YEAR_AVE] [decimal](18, 2) NOT NULL,
	[MONTH_AVE] [decimal](18, 2) NOT NULL,
	[DAY_AVE] [decimal](18, 2) NOT NULL,
	[CT_UID] [nvarchar](15) NULL,
	[CT_DATE] [datetime] NOT NULL,
	[UP_UID] [nvarchar](15) NULL,
	[UP_DATE] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMHC_STAFF]    Script Date: 2024/12/6 下午 03:01:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMHC_STAFF](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[MAIN_ID] [bigint] NOT NULL,
	[HOSPITAL_TYPE] [int] NOT NULL,
	[CATEGORY] [int] NOT NULL,
	[NUMBER] [int] NULL,
	[CT_UID] [nvarchar](15) NULL,
	[CT_DATE] [datetime] NOT NULL,
	[UP_UID] [nvarchar](15) NULL,
	[UP_DATE] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMHC_STROKE_DOCTOR]    Script Date: 2024/12/6 下午 03:01:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMHC_STROKE_DOCTOR](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[MAIN_ID] [bigint] NOT NULL,
	[NAME] [nvarchar](15) NULL,
	[SPECIALIST_CERT] [nvarchar](15) NULL,
	[LICENSE] [nvarchar](15) NULL,
	[SUPPORT_TIME] [nvarchar](50) NULL,
	[REMARKS] [nvarchar](50) NULL,
	[CT_UID] [nvarchar](15) NULL,
	[CT_DATE] [datetime] NOT NULL,
	[UP_UID] [nvarchar](15) NULL,
	[UP_DATE] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMHC_STROKE_PATIENT]    Script Date: 2024/12/6 下午 03:01:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMHC_STROKE_PATIENT](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[MAIN_ID] [bigint] NOT NULL,
	[CATEGORY] [int] NOT NULL,
	[ITEM] [int] NOT NULL,
	[VALUE] [decimal](18, 2) NULL,
	[CT_UID] [nvarchar](15) NULL,
	[CT_DATE] [datetime] NOT NULL,
	[UP_UID] [nvarchar](15) NULL,
	[UP_DATE] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMHC_STROKE_TEAM]    Script Date: 2024/12/6 下午 03:01:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMHC_STROKE_TEAM](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[MAIN_ID] [bigint] NOT NULL,
	[CATEGORY] [int] NOT NULL,
	[NUMBER] [int] NULL,
	[FULL_TIME_DOCS] [int] NULL,
	[SUPPORT_DOCS] [int] NULL,
	[SUPPORT_HOURS] [nvarchar](15) NULL,
	[CT_UID] [nvarchar](15) NULL,
	[CT_DATE] [datetime] NOT NULL,
	[UP_UID] [nvarchar](15) NULL,
	[UP_DATE] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMHC_UNIT]    Script Date: 2024/12/6 下午 03:01:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMHC_UNIT](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[MAIN_ID] [bigint] NOT NULL,
	[DEPT_NO] [nvarchar](2) NULL,
	[HOSPITAL_AREA] [nvarchar](4) NULL,
	[LEVEL] [int] NOT NULL,
	[PERIOD] [datetime] NULL,
	[CHAPTER1] [int] NOT NULL,
	[CHAPTER2] [int] NOT NULL,
	[CHAPTER3] [int] NOT NULL,
	[CHAPTER4] [int] NOT NULL,
	[CHAPTER5] [int] NOT NULL,
	[CHAPTER6] [int] NOT NULL,
	[CT_UID] [nvarchar](15) NULL,
	[CT_DATE] [datetime] NOT NULL,
	[UP_UID] [nvarchar](15) NULL,
	[UP_DATE] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[EMHC_ACS_DOCTOR]  WITH CHECK ADD FOREIGN KEY([MAIN_ID])
REFERENCES [dbo].[EMHC_MAIN] ([ID])
GO
ALTER TABLE [dbo].[EMHC_ACS_PCI_TIME]  WITH CHECK ADD FOREIGN KEY([MAIN_ID])
REFERENCES [dbo].[EMHC_MAIN] ([ID])
GO
ALTER TABLE [dbo].[EMHC_ACS_TEAM]  WITH CHECK ADD FOREIGN KEY([MAIN_ID])
REFERENCES [dbo].[EMHC_MAIN] ([ID])
GO
ALTER TABLE [dbo].[EMHC_CONSULTANT]  WITH CHECK ADD FOREIGN KEY([MAIN_ID])
REFERENCES [dbo].[EMHC_MAIN] ([ID])
GO
ALTER TABLE [dbo].[EMHC_ICU]  WITH CHECK ADD FOREIGN KEY([MAIN_ID])
REFERENCES [dbo].[EMHC_MAIN] ([ID])
GO
ALTER TABLE [dbo].[EMHC_REQUIRE_SERVICE]  WITH CHECK ADD FOREIGN KEY([MAIN_ID])
REFERENCES [dbo].[EMHC_MAIN] ([ID])
GO
ALTER TABLE [dbo].[EMHC_REQUIRE_SERVICE_NUMBER]  WITH CHECK ADD FOREIGN KEY([MAIN_ID])
REFERENCES [dbo].[EMHC_MAIN] ([ID])
GO
ALTER TABLE [dbo].[EMHC_SERVICE]  WITH CHECK ADD FOREIGN KEY([MAIN_ID])
REFERENCES [dbo].[EMHC_MAIN] ([ID])
GO
ALTER TABLE [dbo].[EMHC_STAFF]  WITH CHECK ADD FOREIGN KEY([MAIN_ID])
REFERENCES [dbo].[EMHC_MAIN] ([ID])
GO
ALTER TABLE [dbo].[EMHC_STROKE_DOCTOR]  WITH CHECK ADD FOREIGN KEY([MAIN_ID])
REFERENCES [dbo].[EMHC_MAIN] ([ID])
GO
ALTER TABLE [dbo].[EMHC_STROKE_PATIENT]  WITH CHECK ADD FOREIGN KEY([MAIN_ID])
REFERENCES [dbo].[EMHC_MAIN] ([ID])
GO
ALTER TABLE [dbo].[EMHC_STROKE_TEAM]  WITH CHECK ADD FOREIGN KEY([MAIN_ID])
REFERENCES [dbo].[EMHC_MAIN] ([ID])
GO
ALTER TABLE [dbo].[EMHC_UNIT]  WITH CHECK ADD FOREIGN KEY([MAIN_ID])
REFERENCES [dbo].[EMHC_MAIN] ([ID])
GO
