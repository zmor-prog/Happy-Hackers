/****** Object:  Table [dbo].[BadReport]    Script Date: 3/19/2021 9:55:21 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BadReport](
	[uid] [nvarchar](450) NOT NULL,
	[CoinAddress] [nvarchar](max) NOT NULL,
	[Hash] [nvarchar](max) NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[DOB] [nvarchar](max) NULL,
	[IPAddress] [nvarchar](max) NULL,
	[CryptocurrencyCurrencyID] [nvarchar](450) NULL,
	[CurrencyID] [nvarchar](max) NULL,
	[CategoryID] [nvarchar](450) NULL,
	[LicenseeID] [nvarchar](max) NOT NULL,
	[PostingLicenseeLicenseeID] [nvarchar](450) NULL,
 CONSTRAINT [PK_BadReport] PRIMARY KEY CLUSTERED 
(
	[uid] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[BadReport] ADD  DEFAULT (N'') FOR [CoinAddress]
GO

ALTER TABLE [dbo].[BadReport] ADD  DEFAULT (N'') FOR [LicenseeID]
GO

ALTER TABLE [dbo].[BadReport]  WITH CHECK ADD  CONSTRAINT [FK_BadReport_Categorys_CategoryID] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categorys] ([CategoryID])
GO

ALTER TABLE [dbo].[BadReport] CHECK CONSTRAINT [FK_BadReport_Categorys_CategoryID]
GO

ALTER TABLE [dbo].[BadReport]  WITH CHECK ADD  CONSTRAINT [FK_BadReport_Cryptocurrencys_CryptocurrencyCurrencyID] FOREIGN KEY([CryptocurrencyCurrencyID])
REFERENCES [dbo].[Cryptocurrencys] ([CurrencyID])
GO

ALTER TABLE [dbo].[BadReport] CHECK CONSTRAINT [FK_BadReport_Cryptocurrencys_CryptocurrencyCurrencyID]
GO

ALTER TABLE [dbo].[BadReport]  WITH CHECK ADD  CONSTRAINT [FK_BadReport_PostingLicensees_PostingLicenseeLicenseeID] FOREIGN KEY([PostingLicenseeLicenseeID])
REFERENCES [dbo].[PostingLicensees] ([LicenseeID])
GO

ALTER TABLE [dbo].[BadReport] CHECK CONSTRAINT [FK_BadReport_PostingLicensees_PostingLicenseeLicenseeID]
GO

