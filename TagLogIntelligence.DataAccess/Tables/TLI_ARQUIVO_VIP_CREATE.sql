USE [TagLogIntelligence]
GO

/****** Object:  Table [dbo].[TLI_ARQUIVO_VIP]    Script Date: 04/09/18 5:28:52 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TLI_ARQUIVO_VIP](
	[ARQ_VIP_ID] [uniqueidentifier] NOT NULL,
	[ARQ_VIP_PARAMETRO_EVENTO] [varchar](50) NULL,
	[ARQ_VIP_EMPRESA] [varchar](100) NULL,
	[ARQ_VIP_NOME] [varchar](100) NULL,
	[ARQ_VIP_ENDERECO] [varchar](300) NULL,
	[ARQ_VIP_NR] [varchar](10) NULL,
	[ARQ_VIP_BAIRRO] [varchar](50) NULL,
	[ARQ_VIP_COMPLEMENTO] [varchar](100) NULL,
	[ARQ_VIP_UF] [varchar](2) NULL,
	[ARQ_VIP_CIDADE] [varchar](20) NULL,
	[ARQ_VIP_CEP] [varchar](8) NULL,
	[ARQ_DATA_IMPORTACAO] [datetime] NULL
) ON [PRIMARY]
GO
