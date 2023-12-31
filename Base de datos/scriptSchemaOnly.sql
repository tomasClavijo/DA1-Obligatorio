USE [EventosBD]
GO
/****** Object:  Table [dbo].[AsistenteCuponEventoes]    Script Date: 16/6/2022 19:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AsistenteCuponEventoes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CedulaAsistente] [nvarchar](max) NULL,
	[NombreEvento] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.AsistenteCuponEventoes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Asistentes]    Script Date: 16/6/2022 19:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asistentes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Cedula] [nvarchar](max) NULL,
	[Nombre] [nvarchar](max) NULL,
	[Apellido] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Asistentes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Codigoes]    Script Date: 16/6/2022 19:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Codigoes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CodigoCompra] [nvarchar](max) NULL,
	[Compra_Id] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Codigoes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compras]    Script Date: 16/6/2022 19:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compras](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Monto] [int] NOT NULL,
	[Asistente_Id] [int] NULL,
	[FechaEfectuada] [datetime] NOT NULL,
 CONSTRAINT [PK_dbo.Compras] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cupons]    Script Date: 16/6/2022 19:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cupons](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [int] NOT NULL,
	[Nombre] [nvarchar](max) NULL,
	[CantidadRestante] [int] NOT NULL,
	[Codigo] [nvarchar](max) NULL,
	[PrimerValor] [int] NULL,
	[SegundoValor] [int] NULL,
	[Porcentaje] [int] NULL,
	[ValorFijo] [int] NULL,
	[Discriminator] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.Cupons] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EntradaVendidas]    Script Date: 16/6/2022 19:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EntradaVendidas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Categoria] [int] NOT NULL,
	[Monto] [int] NOT NULL,
 CONSTRAINT [PK_dbo.EntradaVendidas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Eventoes]    Script Date: 16/6/2022 19:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Eventoes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NULL,
	[Categoria] [int] NOT NULL,
	[Formato] [int] NOT NULL,
	[Descripcion] [nvarchar](max) NULL,
	[Direccion] [nvarchar](max) NULL,
	[Imagen] [nvarchar](max) NULL,
	[EsBorrador] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.Eventoes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Funcions]    Script Date: 16/6/2022 19:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funcions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FechaInicio] [datetime] NOT NULL,
	[FechaFin] [datetime] NOT NULL,
	[MostrarDisponibles] [bit] NOT NULL,
	[Evento_Id] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Funcions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ParTicketCantidads]    Script Date: 16/6/2022 19:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ParTicketCantidads](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Ticket_Id] [int] NULL,
	[Funcion_Id] [int] NOT NULL,
 CONSTRAINT [PK_dbo.ParTicketCantidads] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productors]    Script Date: 16/6/2022 19:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[Nombre] [nvarchar](max) NULL,
	[Apellido] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Productors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tickets]    Script Date: 16/6/2022 19:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tickets](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NULL,
	[Precio] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Evento_Id] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Tickets] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Compras] ADD  DEFAULT ('1900-01-01T00:00:00.000') FOR [FechaEfectuada]
GO
ALTER TABLE [dbo].[Eventoes] ADD  DEFAULT ((0)) FOR [EsBorrador]
GO
ALTER TABLE [dbo].[Codigoes]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Codigoes_dbo.Compras_Compra_Id] FOREIGN KEY([Compra_Id])
REFERENCES [dbo].[Compras] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Codigoes] CHECK CONSTRAINT [FK_dbo.Codigoes_dbo.Compras_Compra_Id]
GO
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Compras_dbo.Asistentes_Asistente_Id] FOREIGN KEY([Asistente_Id])
REFERENCES [dbo].[Asistentes] ([Id])
GO
ALTER TABLE [dbo].[Compras] CHECK CONSTRAINT [FK_dbo.Compras_dbo.Asistentes_Asistente_Id]
GO
ALTER TABLE [dbo].[Funcions]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Funcions_dbo.Eventoes_Evento_Id] FOREIGN KEY([Evento_Id])
REFERENCES [dbo].[Eventoes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Funcions] CHECK CONSTRAINT [FK_dbo.Funcions_dbo.Eventoes_Evento_Id]
GO
ALTER TABLE [dbo].[ParTicketCantidads]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ParTicketCantidads_dbo.Funcions_Funcion_Id] FOREIGN KEY([Funcion_Id])
REFERENCES [dbo].[Funcions] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ParTicketCantidads] CHECK CONSTRAINT [FK_dbo.ParTicketCantidads_dbo.Funcions_Funcion_Id]
GO
ALTER TABLE [dbo].[ParTicketCantidads]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ParTicketCantidads_dbo.Tickets_Ticket_Id] FOREIGN KEY([Ticket_Id])
REFERENCES [dbo].[Tickets] ([Id])
GO
ALTER TABLE [dbo].[ParTicketCantidads] CHECK CONSTRAINT [FK_dbo.ParTicketCantidads_dbo.Tickets_Ticket_Id]
GO
ALTER TABLE [dbo].[Tickets]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Tickets_dbo.Eventoes_Evento_Id] FOREIGN KEY([Evento_Id])
REFERENCES [dbo].[Eventoes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tickets] CHECK CONSTRAINT [FK_dbo.Tickets_dbo.Eventoes_Evento_Id]
GO
