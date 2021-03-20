/****** Object:  Table [dbo].[PostingLicensees]    Script Date: 3/19/2021 9:56:27 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PostingLicensees](
	[LicenseeID] [nvarchar](450) NOT NULL,
	[LicenseeName] [nvarchar](max) NULL,
 CONSTRAINT [PK_PostingLicensees] PRIMARY KEY CLUSTERED 
(
	[LicenseeID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

