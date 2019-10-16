USE [DBSigemat]
GO

/****** Object:  Table [dbo].[tblUsuario]    Script Date: 16/10/2019 15:22:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblUsuario](
	[identificacion] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellidos] [varchar](50) NOT NULL,
	[correoElectronico] [varchar](50) NOT NULL,
	[contacto] [int] NOT NULL,
	[idPerfil] [int] NOT NULL,
	[direccion] [varchar](50) NOT NULL,
	[clave] [varchar](20) NOT NULL,
 CONSTRAINT [PK_tblUsuario] PRIMARY KEY CLUSTERED 
(
	[identificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


