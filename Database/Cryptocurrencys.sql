/****** Object:  Table [dbo].[Cryptocurrencys]    Script Date: 3/19/2021 9:56:07 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cryptocurrencys](
	[CurrencyID] [nvarchar](450) NOT NULL,
	[Code] [nvarchar](max) NULL,
 CONSTRAINT [PK_Cryptocurrencys] PRIMARY KEY CLUSTERED 
(
	[CurrencyID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

