USE [TestGFT]
GO

/****** Object:  Table [dbo].[Trade]    Script Date: 04/04/2021 19:23:47 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE TABLE [dbo].[ClientSector](
	[ID_ClientSector] [int] identity NOT NULL,
	[Enum_ClientSector] [int] NOT NULL,
	[Name_ClientSector] varchar(20) NOT NULL,
 CONSTRAINT [PK_ClientSector] PRIMARY KEY CLUSTERED 
(
	[ID_ClientSector] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TradeCategories](
	[ID_TradeCategories] [int] identity NOT NULL,
	[Enum_TradeCategories] [int] NOT NULL,
	[Name_TradeCategories] varchar(20) NOT NULL,
 CONSTRAINT [PK_TradeCategories] PRIMARY KEY CLUSTERED 
(
	[ID_TradeCategories] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Trade](
	[ID_Trade] [int] identity NOT NULL,
	[Value] [decimal](18, 2) NULL,
	[ID_ClientSector] [int] NULL,
	[ID_TradeCategories] [int] NULL,
 FOREIGN KEY (ID_ClientSector) REFERENCES ClientSector(ID_ClientSector),
 FOREIGN KEY (ID_TradeCategories) REFERENCES TradeCategories(ID_TradeCategories),
 CONSTRAINT [PK_Trade] PRIMARY KEY CLUSTERED 
(
	[ID_Trade] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
	
INSERT INTO [ClientSector]([Enum_ClientSector],[Name_ClientSector]) VALUES ( 1,'Public')
INSERT INTO [ClientSector]([Enum_ClientSector],[Name_ClientSector]) VALUES ( 2,'Private')

GO

INSERT INTO [TradeCategories]([Enum_TradeCategories],[Name_TradeCategories]) VALUES ( 1,'LOWRISK')
INSERT INTO [TradeCategories]([Enum_TradeCategories],[Name_TradeCategories]) VALUES ( 2,'MEDIUMRISK')
INSERT INTO [TradeCategories]([Enum_TradeCategories],[Name_TradeCategories]) VALUES ( 3,'HIGHRISK')
INSERT INTO [TradeCategories]([Enum_TradeCategories],[Name_TradeCategories]) VALUES ( 4,'NOT_APPLICABLE')

GO

SELECT * FROM [ClientSector]
SELECT * FROM [TradeCategories]

GO


--DROP TABLE Trade
--DROP TABLE TradeCategories
--DROP TABLE ClientSector