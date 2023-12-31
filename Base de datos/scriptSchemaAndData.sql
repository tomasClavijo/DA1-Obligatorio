USE [EventosBD]
GO
/****** Object:  Table [dbo].[AsistenteCuponEventoes]    Script Date: 16/6/2022 19:11:02 ******/
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
/****** Object:  Table [dbo].[Asistentes]    Script Date: 16/6/2022 19:11:02 ******/
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
/****** Object:  Table [dbo].[Codigoes]    Script Date: 16/6/2022 19:11:02 ******/
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
/****** Object:  Table [dbo].[Compras]    Script Date: 16/6/2022 19:11:02 ******/
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
/****** Object:  Table [dbo].[Cupons]    Script Date: 16/6/2022 19:11:02 ******/
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
/****** Object:  Table [dbo].[EntradaVendidas]    Script Date: 16/6/2022 19:11:02 ******/
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
/****** Object:  Table [dbo].[Eventoes]    Script Date: 16/6/2022 19:11:02 ******/
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
/****** Object:  Table [dbo].[Funcions]    Script Date: 16/6/2022 19:11:02 ******/
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
/****** Object:  Table [dbo].[ParTicketCantidads]    Script Date: 16/6/2022 19:11:02 ******/
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
/****** Object:  Table [dbo].[Productors]    Script Date: 16/6/2022 19:11:02 ******/
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
/****** Object:  Table [dbo].[Tickets]    Script Date: 16/6/2022 19:11:02 ******/
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
SET IDENTITY_INSERT [dbo].[AsistenteCuponEventoes] ON 

INSERT [dbo].[AsistenteCuponEventoes] ([Id], [CedulaAsistente], [NombreEvento]) VALUES (1, N'52638174', N'La Beriso')
INSERT [dbo].[AsistenteCuponEventoes] ([Id], [CedulaAsistente], [NombreEvento]) VALUES (2, N'41112223', N'PICHU-LEANDO')
INSERT [dbo].[AsistenteCuponEventoes] ([Id], [CedulaAsistente], [NombreEvento]) VALUES (3, N'5293852', N'Nick Jr. Live!')
INSERT [dbo].[AsistenteCuponEventoes] ([Id], [CedulaAsistente], [NombreEvento]) VALUES (4, N'4239572', N'Nick Jr. Live!')
INSERT [dbo].[AsistenteCuponEventoes] ([Id], [CedulaAsistente], [NombreEvento]) VALUES (5, N'5826384', N'PICHU-LEANDO')
INSERT [dbo].[AsistenteCuponEventoes] ([Id], [CedulaAsistente], [NombreEvento]) VALUES (6, N'55656723', N'Torneo Clasificatorio Mundial FIBA 2023')
INSERT [dbo].[AsistenteCuponEventoes] ([Id], [CedulaAsistente], [NombreEvento]) VALUES (7, N'234562435', N'PICHU-LEANDO')
INSERT [dbo].[AsistenteCuponEventoes] ([Id], [CedulaAsistente], [NombreEvento]) VALUES (8, N'4439887', N'Guns N Roses en Montevideo - Estadio Centenario')
INSERT [dbo].[AsistenteCuponEventoes] ([Id], [CedulaAsistente], [NombreEvento]) VALUES (9, N'87263547', N'Guns N Roses en Montevideo - Estadio Centenario')
INSERT [dbo].[AsistenteCuponEventoes] ([Id], [CedulaAsistente], [NombreEvento]) VALUES (10, N'32234554', N'La Beriso')
SET IDENTITY_INSERT [dbo].[AsistenteCuponEventoes] OFF
GO
SET IDENTITY_INSERT [dbo].[Asistentes] ON 

INSERT [dbo].[Asistentes] ([Id], [Cedula], [Nombre], [Apellido]) VALUES (1, N'52638174', N'Franco', N'Daneri')
INSERT [dbo].[Asistentes] ([Id], [Cedula], [Nombre], [Apellido]) VALUES (2, N'41112223', N'Juan', N'Perez')
INSERT [dbo].[Asistentes] ([Id], [Cedula], [Nombre], [Apellido]) VALUES (3, N'5293852', N'Jarrad', N'Greir')
INSERT [dbo].[Asistentes] ([Id], [Cedula], [Nombre], [Apellido]) VALUES (4, N'4239572', N'Cosetta', N'Haistwell')
INSERT [dbo].[Asistentes] ([Id], [Cedula], [Nombre], [Apellido]) VALUES (5, N'5826384', N'Linoel', N'Kennard')
INSERT [dbo].[Asistentes] ([Id], [Cedula], [Nombre], [Apellido]) VALUES (6, N'55656723', N'Leon', N'Quakley')
INSERT [dbo].[Asistentes] ([Id], [Cedula], [Nombre], [Apellido]) VALUES (7, N'234562435', N'Mirilla', N'Bastick')
INSERT [dbo].[Asistentes] ([Id], [Cedula], [Nombre], [Apellido]) VALUES (8, N'4439887', N'Linoel', N'Kennard')
INSERT [dbo].[Asistentes] ([Id], [Cedula], [Nombre], [Apellido]) VALUES (9, N'87263547', N'Jarrad', N'Greir')
INSERT [dbo].[Asistentes] ([Id], [Cedula], [Nombre], [Apellido]) VALUES (10, N'32234554', N'Alex', N'Drescher')
SET IDENTITY_INSERT [dbo].[Asistentes] OFF
GO
SET IDENTITY_INSERT [dbo].[Codigoes] ON 

INSERT [dbo].[Codigoes] ([Id], [CodigoCompra], [Compra_Id]) VALUES (1, N'5375547D2E', 1)
INSERT [dbo].[Codigoes] ([Id], [CodigoCompra], [Compra_Id]) VALUES (2, N'E3638A07D6', 1)
INSERT [dbo].[Codigoes] ([Id], [CodigoCompra], [Compra_Id]) VALUES (3, N'D8BC3121B2', 2)
INSERT [dbo].[Codigoes] ([Id], [CodigoCompra], [Compra_Id]) VALUES (4, N'24479D1A1D', 2)
INSERT [dbo].[Codigoes] ([Id], [CodigoCompra], [Compra_Id]) VALUES (5, N'257507978A', 3)
INSERT [dbo].[Codigoes] ([Id], [CodigoCompra], [Compra_Id]) VALUES (6, N'939C14A6DF', 3)
INSERT [dbo].[Codigoes] ([Id], [CodigoCompra], [Compra_Id]) VALUES (7, N'E187C09CD5', 3)
INSERT [dbo].[Codigoes] ([Id], [CodigoCompra], [Compra_Id]) VALUES (8, N'1A8896B278', 3)
INSERT [dbo].[Codigoes] ([Id], [CodigoCompra], [Compra_Id]) VALUES (9, N'A6947B7D33', 4)
INSERT [dbo].[Codigoes] ([Id], [CodigoCompra], [Compra_Id]) VALUES (10, N'F6C27C7AE1', 4)
INSERT [dbo].[Codigoes] ([Id], [CodigoCompra], [Compra_Id]) VALUES (11, N'5C93248009', 5)
INSERT [dbo].[Codigoes] ([Id], [CodigoCompra], [Compra_Id]) VALUES (12, N'BDDF1CB4AC', 5)
INSERT [dbo].[Codigoes] ([Id], [CodigoCompra], [Compra_Id]) VALUES (13, N'C91A94AF50', 6)
INSERT [dbo].[Codigoes] ([Id], [CodigoCompra], [Compra_Id]) VALUES (14, N'8CAEFE843F', 6)
INSERT [dbo].[Codigoes] ([Id], [CodigoCompra], [Compra_Id]) VALUES (15, N'A77CA5743A', 6)
INSERT [dbo].[Codigoes] ([Id], [CodigoCompra], [Compra_Id]) VALUES (16, N'6892FEE8F4', 6)
INSERT [dbo].[Codigoes] ([Id], [CodigoCompra], [Compra_Id]) VALUES (17, N'2DDB85D9EF', 6)
INSERT [dbo].[Codigoes] ([Id], [CodigoCompra], [Compra_Id]) VALUES (18, N'C15F523D8D', 7)
INSERT [dbo].[Codigoes] ([Id], [CodigoCompra], [Compra_Id]) VALUES (19, N'85FDFD4239', 7)
INSERT [dbo].[Codigoes] ([Id], [CodigoCompra], [Compra_Id]) VALUES (20, N'F4ED54C853', 8)
INSERT [dbo].[Codigoes] ([Id], [CodigoCompra], [Compra_Id]) VALUES (21, N'110999ABE1', 8)
INSERT [dbo].[Codigoes] ([Id], [CodigoCompra], [Compra_Id]) VALUES (22, N'24FAA4CB38', 8)
INSERT [dbo].[Codigoes] ([Id], [CodigoCompra], [Compra_Id]) VALUES (23, N'F85CD83759', 9)
INSERT [dbo].[Codigoes] ([Id], [CodigoCompra], [Compra_Id]) VALUES (24, N'42030353E2', 9)
INSERT [dbo].[Codigoes] ([Id], [CodigoCompra], [Compra_Id]) VALUES (25, N'1AD0B9AFF7', 9)
INSERT [dbo].[Codigoes] ([Id], [CodigoCompra], [Compra_Id]) VALUES (26, N'46DF111E43', 10)
INSERT [dbo].[Codigoes] ([Id], [CodigoCompra], [Compra_Id]) VALUES (27, N'E26796A1AD', 10)
SET IDENTITY_INSERT [dbo].[Codigoes] OFF
GO
SET IDENTITY_INSERT [dbo].[Compras] ON 

INSERT [dbo].[Compras] ([Id], [Monto], [Asistente_Id], [FechaEfectuada]) VALUES (1, 3430, 1, CAST(N'2022-06-16T16:06:02.403' AS DateTime))
INSERT [dbo].[Compras] ([Id], [Monto], [Asistente_Id], [FechaEfectuada]) VALUES (2, 1064, 2, CAST(N'2022-06-16T16:07:39.857' AS DateTime))
INSERT [dbo].[Compras] ([Id], [Monto], [Asistente_Id], [FechaEfectuada]) VALUES (3, 3600, 3, CAST(N'2022-06-16T16:08:30.827' AS DateTime))
INSERT [dbo].[Compras] ([Id], [Monto], [Asistente_Id], [FechaEfectuada]) VALUES (4, 1200, 4, CAST(N'2022-06-16T16:09:06.660' AS DateTime))
INSERT [dbo].[Compras] ([Id], [Monto], [Asistente_Id], [FechaEfectuada]) VALUES (5, 1544, 5, CAST(N'2022-06-16T16:11:04.610' AS DateTime))
INSERT [dbo].[Compras] ([Id], [Monto], [Asistente_Id], [FechaEfectuada]) VALUES (6, 5000, 6, CAST(N'2022-06-16T16:11:28.897' AS DateTime))
INSERT [dbo].[Compras] ([Id], [Monto], [Asistente_Id], [FechaEfectuada]) VALUES (7, 1556, 7, CAST(N'2022-06-16T16:12:53.450' AS DateTime))
INSERT [dbo].[Compras] ([Id], [Monto], [Asistente_Id], [FechaEfectuada]) VALUES (8, 10500, 8, CAST(N'2022-06-16T16:13:31.750' AS DateTime))
INSERT [dbo].[Compras] ([Id], [Monto], [Asistente_Id], [FechaEfectuada]) VALUES (9, 6750, 9, CAST(N'2022-06-16T16:14:04.250' AS DateTime))
INSERT [dbo].[Compras] ([Id], [Monto], [Asistente_Id], [FechaEfectuada]) VALUES (10, 5040, 10, CAST(N'2022-06-16T16:14:41.713' AS DateTime))
SET IDENTITY_INSERT [dbo].[Compras] OFF
GO
SET IDENTITY_INSERT [dbo].[Cupons] ON 

INSERT [dbo].[Cupons] ([Id], [Tipo], [Nombre], [CantidadRestante], [Codigo], [PrimerValor], [SegundoValor], [Porcentaje], [ValorFijo], [Discriminator]) VALUES (1, 0, N'Cupon 1', 9, N'A5ABC8B01B', NULL, NULL, 20, NULL, N'CuponPorcentaje')
INSERT [dbo].[Cupons] ([Id], [Tipo], [Nombre], [CantidadRestante], [Codigo], [PrimerValor], [SegundoValor], [Porcentaje], [ValorFijo], [Discriminator]) VALUES (2, 1, N'Cupon 2', 19, N'4F43F0B36A', NULL, NULL, NULL, 300, N'CuponValorFijo')
INSERT [dbo].[Cupons] ([Id], [Tipo], [Nombre], [CantidadRestante], [Codigo], [PrimerValor], [SegundoValor], [Porcentaje], [ValorFijo], [Discriminator]) VALUES (3, 0, N'Cupon 3', 25, N'9EC9A03780', NULL, NULL, 15, NULL, N'CuponPorcentaje')
INSERT [dbo].[Cupons] ([Id], [Tipo], [Nombre], [CantidadRestante], [Codigo], [PrimerValor], [SegundoValor], [Porcentaje], [ValorFijo], [Discriminator]) VALUES (4, 2, N'Cupon 4', 99, N'EB5E2F25A0', 2, 1, NULL, NULL, N'CuponACantidad')
INSERT [dbo].[Cupons] ([Id], [Tipo], [Nombre], [CantidadRestante], [Codigo], [PrimerValor], [SegundoValor], [Porcentaje], [ValorFijo], [Discriminator]) VALUES (5, 2, N'Cupon 5', 200, N'357D173D24', 2, 1, NULL, NULL, N'CuponACantidad')
INSERT [dbo].[Cupons] ([Id], [Tipo], [Nombre], [CantidadRestante], [Codigo], [PrimerValor], [SegundoValor], [Porcentaje], [ValorFijo], [Discriminator]) VALUES (6, 0, N'Cupon 6', 498, N'EA43B8AA55', NULL, NULL, 10, NULL, N'CuponPorcentaje')
SET IDENTITY_INSERT [dbo].[Cupons] OFF
GO
SET IDENTITY_INSERT [dbo].[EntradaVendidas] ON 

INSERT [dbo].[EntradaVendidas] ([Id], [Categoria], [Monto]) VALUES (1, 4, 1715)
INSERT [dbo].[EntradaVendidas] ([Id], [Categoria], [Monto]) VALUES (2, 4, 1715)
INSERT [dbo].[EntradaVendidas] ([Id], [Categoria], [Monto]) VALUES (3, 6, 532)
INSERT [dbo].[EntradaVendidas] ([Id], [Categoria], [Monto]) VALUES (4, 6, 532)
INSERT [dbo].[EntradaVendidas] ([Id], [Categoria], [Monto]) VALUES (5, 5, 900)
INSERT [dbo].[EntradaVendidas] ([Id], [Categoria], [Monto]) VALUES (6, 5, 900)
INSERT [dbo].[EntradaVendidas] ([Id], [Categoria], [Monto]) VALUES (7, 5, 900)
INSERT [dbo].[EntradaVendidas] ([Id], [Categoria], [Monto]) VALUES (8, 5, 900)
INSERT [dbo].[EntradaVendidas] ([Id], [Categoria], [Monto]) VALUES (9, 5, 600)
INSERT [dbo].[EntradaVendidas] ([Id], [Categoria], [Monto]) VALUES (10, 5, 600)
INSERT [dbo].[EntradaVendidas] ([Id], [Categoria], [Monto]) VALUES (11, 6, 772)
INSERT [dbo].[EntradaVendidas] ([Id], [Categoria], [Monto]) VALUES (12, 6, 772)
INSERT [dbo].[EntradaVendidas] ([Id], [Categoria], [Monto]) VALUES (13, 3, 1000)
INSERT [dbo].[EntradaVendidas] ([Id], [Categoria], [Monto]) VALUES (14, 3, 1000)
INSERT [dbo].[EntradaVendidas] ([Id], [Categoria], [Monto]) VALUES (15, 3, 1000)
INSERT [dbo].[EntradaVendidas] ([Id], [Categoria], [Monto]) VALUES (16, 3, 1000)
INSERT [dbo].[EntradaVendidas] ([Id], [Categoria], [Monto]) VALUES (17, 3, 1000)
INSERT [dbo].[EntradaVendidas] ([Id], [Categoria], [Monto]) VALUES (18, 6, 778)
INSERT [dbo].[EntradaVendidas] ([Id], [Categoria], [Monto]) VALUES (19, 6, 778)
INSERT [dbo].[EntradaVendidas] ([Id], [Categoria], [Monto]) VALUES (20, 4, 3500)
INSERT [dbo].[EntradaVendidas] ([Id], [Categoria], [Monto]) VALUES (21, 4, 3500)
INSERT [dbo].[EntradaVendidas] ([Id], [Categoria], [Monto]) VALUES (22, 4, 3500)
INSERT [dbo].[EntradaVendidas] ([Id], [Categoria], [Monto]) VALUES (23, 4, 2250)
INSERT [dbo].[EntradaVendidas] ([Id], [Categoria], [Monto]) VALUES (24, 4, 2250)
INSERT [dbo].[EntradaVendidas] ([Id], [Categoria], [Monto]) VALUES (25, 4, 2250)
INSERT [dbo].[EntradaVendidas] ([Id], [Categoria], [Monto]) VALUES (26, 4, 2520)
INSERT [dbo].[EntradaVendidas] ([Id], [Categoria], [Monto]) VALUES (27, 4, 2520)
SET IDENTITY_INSERT [dbo].[EntradaVendidas] OFF
GO
SET IDENTITY_INSERT [dbo].[Eventoes] ON 

INSERT [dbo].[Eventoes] ([Id], [Nombre], [Categoria], [Formato], [Descripcion], [Direccion], [Imagen], [EsBorrador]) VALUES (1, N'Guns N Roses en Montevideo - Estadio Centenario', 4, 0, N'¡Guns N Roses vuelve a Montevideo pero con su formación original!', N'Estadio Centenario', N'C:\Users\Usuario\Pictures\Back\GNR_London_Stadium_2017_3_(cropped).jpg', 0)
INSERT [dbo].[Eventoes] ([Id], [Nombre], [Categoria], [Formato], [Descripcion], [Direccion], [Imagen], [EsBorrador]) VALUES (2, N'La Beriso', 4, 0, N'Vuelve La Beriso a Montevideo, vuelve La Beriso al Antel Arena.', N'Antel Arena', N'C:\Users\Usuario\Pictures\Back\Web-Antel-Arena-1600X540-f8ee0410d4.jpg', 0)
INSERT [dbo].[Eventoes] ([Id], [Nombre], [Categoria], [Formato], [Descripcion], [Direccion], [Imagen], [EsBorrador]) VALUES (4, N'Nick Jr. Live!', 5, 0, N'Baila con Ritmo', N'Antel Arena', N'C:\Users\Usuario\Pictures\Back\700_X_390.jpg', 0)
INSERT [dbo].[Eventoes] ([Id], [Nombre], [Categoria], [Formato], [Descripcion], [Direccion], [Imagen], [EsBorrador]) VALUES (5, N'PICHU-LEANDO', 6, 0, N'PICHU-LEANDO', N'Montevideo Music Box', N'C:\Users\Usuario\Pictures\Back\pichu-mmbox-abitab-web.jpg', 0)
INSERT [dbo].[Eventoes] ([Id], [Nombre], [Categoria], [Formato], [Descripcion], [Direccion], [Imagen], [EsBorrador]) VALUES (6, N'Torneo Clasificatorio Mundial FIBA 2023', 3, 0, N'Uruguay – Brasil', N'Antel Arena', N'C:\Users\Usuario\Pictures\Back\Clasificatorio-FIBA-2023_Web-Antel-Arena-Destaque-1600-x-540-px-UY-BR-d871e70e81.jpg', 0)
SET IDENTITY_INSERT [dbo].[Eventoes] OFF
GO
SET IDENTITY_INSERT [dbo].[Funcions] ON 

INSERT [dbo].[Funcions] ([Id], [FechaInicio], [FechaFin], [MostrarDisponibles], [Evento_Id]) VALUES (1, CAST(N'2022-08-20T22:00:31.000' AS DateTime), CAST(N'2022-08-21T02:00:31.000' AS DateTime), 1, 1)
INSERT [dbo].[Funcions] ([Id], [FechaInicio], [FechaFin], [MostrarDisponibles], [Evento_Id]) VALUES (2, CAST(N'2022-08-18T21:00:31.000' AS DateTime), CAST(N'2022-08-19T01:00:31.000' AS DateTime), 1, 2)
INSERT [dbo].[Funcions] ([Id], [FechaInicio], [FechaFin], [MostrarDisponibles], [Evento_Id]) VALUES (4, CAST(N'2022-09-02T14:00:31.000' AS DateTime), CAST(N'2022-09-03T15:30:31.000' AS DateTime), 1, 4)
INSERT [dbo].[Funcions] ([Id], [FechaInicio], [FechaFin], [MostrarDisponibles], [Evento_Id]) VALUES (5, CAST(N'2022-10-22T21:00:31.000' AS DateTime), CAST(N'2022-10-22T23:50:31.000' AS DateTime), 1, 5)
INSERT [dbo].[Funcions] ([Id], [FechaInicio], [FechaFin], [MostrarDisponibles], [Evento_Id]) VALUES (6, CAST(N'2022-09-02T20:00:31.000' AS DateTime), CAST(N'2022-09-03T23:00:31.000' AS DateTime), 1, 6)
SET IDENTITY_INSERT [dbo].[Funcions] OFF
GO
SET IDENTITY_INSERT [dbo].[ParTicketCantidads] ON 

INSERT [dbo].[ParTicketCantidads] ([Id], [Cantidad], [Ticket_Id], [Funcion_Id]) VALUES (1, 19997, 1, 1)
INSERT [dbo].[ParTicketCantidads] ([Id], [Cantidad], [Ticket_Id], [Funcion_Id]) VALUES (2, 4997, 2, 1)
INSERT [dbo].[ParTicketCantidads] ([Id], [Cantidad], [Ticket_Id], [Funcion_Id]) VALUES (3, 498, 3, 2)
INSERT [dbo].[ParTicketCantidads] ([Id], [Cantidad], [Ticket_Id], [Funcion_Id]) VALUES (4, 500, 4, 2)
INSERT [dbo].[ParTicketCantidads] ([Id], [Cantidad], [Ticket_Id], [Funcion_Id]) VALUES (5, 248, 5, 2)
INSERT [dbo].[ParTicketCantidads] ([Id], [Cantidad], [Ticket_Id], [Funcion_Id]) VALUES (9, 996, 9, 4)
INSERT [dbo].[ParTicketCantidads] ([Id], [Cantidad], [Ticket_Id], [Funcion_Id]) VALUES (10, 1498, 10, 4)
INSERT [dbo].[ParTicketCantidads] ([Id], [Cantidad], [Ticket_Id], [Funcion_Id]) VALUES (11, 1500, 11, 4)
INSERT [dbo].[ParTicketCantidads] ([Id], [Cantidad], [Ticket_Id], [Funcion_Id]) VALUES (12, 98, 12, 5)
INSERT [dbo].[ParTicketCantidads] ([Id], [Cantidad], [Ticket_Id], [Funcion_Id]) VALUES (13, 198, 13, 5)
INSERT [dbo].[ParTicketCantidads] ([Id], [Cantidad], [Ticket_Id], [Funcion_Id]) VALUES (14, 98, 14, 5)
INSERT [dbo].[ParTicketCantidads] ([Id], [Cantidad], [Ticket_Id], [Funcion_Id]) VALUES (15, 195, 15, 6)
INSERT [dbo].[ParTicketCantidads] ([Id], [Cantidad], [Ticket_Id], [Funcion_Id]) VALUES (16, 200, 16, 6)
INSERT [dbo].[ParTicketCantidads] ([Id], [Cantidad], [Ticket_Id], [Funcion_Id]) VALUES (17, 1000, 17, 6)
SET IDENTITY_INSERT [dbo].[ParTicketCantidads] OFF
GO
SET IDENTITY_INSERT [dbo].[Productors] ON 

INSERT [dbo].[Productors] ([Id], [Email], [Password], [Nombre], [Apellido]) VALUES (1, N'franco', N'franco', N'Franco', N'Daneri')
INSERT [dbo].[Productors] ([Id], [Email], [Password], [Nombre], [Apellido]) VALUES (2, N'tomas', N'tomas', N'Tomas', N'Clavijo')
INSERT [dbo].[Productors] ([Id], [Email], [Password], [Nombre], [Apellido]) VALUES (3, N'luca', N'luca', N'Luca', N'Bessonart')
INSERT [dbo].[Productors] ([Id], [Email], [Password], [Nombre], [Apellido]) VALUES (4, N'travers', N'travers', N'Travers', N'Celier')
INSERT [dbo].[Productors] ([Id], [Email], [Password], [Nombre], [Apellido]) VALUES (5, N'alvie', N'alvie', N'Alvie', N'Glassman')
INSERT [dbo].[Productors] ([Id], [Email], [Password], [Nombre], [Apellido]) VALUES (6, N'sula', N'sula', N'Sula', N'Lote')
SET IDENTITY_INSERT [dbo].[Productors] OFF
GO
SET IDENTITY_INSERT [dbo].[Tickets] ON 

INSERT [dbo].[Tickets] ([Id], [Nombre], [Precio], [Cantidad], [Evento_Id]) VALUES (1, N'Tribuna Olímpica', 2500, 20000, 1)
INSERT [dbo].[Tickets] ([Id], [Nombre], [Precio], [Cantidad], [Evento_Id]) VALUES (2, N'Platea Olímpica', 3500, 5000, 1)
INSERT [dbo].[Tickets] ([Id], [Nombre], [Precio], [Cantidad], [Evento_Id]) VALUES (3, N'Sector 303', 1715, 500, 2)
INSERT [dbo].[Tickets] ([Id], [Nombre], [Precio], [Cantidad], [Evento_Id]) VALUES (4, N'Sector 103', 2520, 500, 2)
INSERT [dbo].[Tickets] ([Id], [Nombre], [Precio], [Cantidad], [Evento_Id]) VALUES (5, N'Sector 114', 2520, 250, 2)
INSERT [dbo].[Tickets] ([Id], [Nombre], [Precio], [Cantidad], [Evento_Id]) VALUES (9, N'Sector 301 - Nivel 3', 900, 1000, 4)
INSERT [dbo].[Tickets] ([Id], [Nombre], [Precio], [Cantidad], [Evento_Id]) VALUES (10, N'Sector 302 - Nivel 3', 900, 1500, 4)
INSERT [dbo].[Tickets] ([Id], [Nombre], [Precio], [Cantidad], [Evento_Id]) VALUES (11, N'Sector 115 - Nivel 1', 1200, 1500, 4)
INSERT [dbo].[Tickets] ([Id], [Nombre], [Precio], [Cantidad], [Evento_Id]) VALUES (12, N'Planta Baja Zona A (VIP)', 965, 100, 5)
INSERT [dbo].[Tickets] ([Id], [Nombre], [Precio], [Cantidad], [Evento_Id]) VALUES (13, N'Planta Baja Zona B', 1065, 200, 5)
INSERT [dbo].[Tickets] ([Id], [Nombre], [Precio], [Cantidad], [Evento_Id]) VALUES (14, N'Planta Baja Zona C', 865, 100, 5)
INSERT [dbo].[Tickets] ([Id], [Nombre], [Precio], [Cantidad], [Evento_Id]) VALUES (15, N'109A - Nivel 1', 1000, 200, 6)
INSERT [dbo].[Tickets] ([Id], [Nombre], [Precio], [Cantidad], [Evento_Id]) VALUES (16, N'101A - Nivel 1', 3000, 200, 6)
INSERT [dbo].[Tickets] ([Id], [Nombre], [Precio], [Cantidad], [Evento_Id]) VALUES (17, N'112A - Nivel 1', 500, 1000, 6)
SET IDENTITY_INSERT [dbo].[Tickets] OFF
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
