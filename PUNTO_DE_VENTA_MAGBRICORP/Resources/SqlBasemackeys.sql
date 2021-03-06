USE [RRRR]

GO
CREATE TABLE [dbo].[ASISTENCIAS](
	[Id_asistencia] [int] IDENTITY(1,1) NOT NULL,
	[Id_personal] [int] NULL,
	[Fecha_entrada] [datetime] NULL,
	[Fecha_salida] [datetime] NULL,
	[Estado] [varchar](50) NULL,
	[Horas] [numeric](18, 2) NULL,
 CONSTRAINT [PK_ASISTENCIAS] PRIMARY KEY CLUSTERED 
(
	[Id_asistencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Caja]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Caja](
	[Id_Caja] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[Saldo] [numeric](18, 2) NULL,
	[Serial_PC] [varchar](50) NULL,
 CONSTRAINT [PK_Caja_1] PRIMARY KEY CLUSTERED 
(
	[Id_Caja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[categoria]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[categoria](
	[idcategoria] [int] IDENTITY(1,1) NOT NULL,
	[nombrecategoria] [varchar](50) NULL,
 CONSTRAINT [PK_categoria] PRIMARY KEY CLUSTERED 
(
	[idcategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[clientes](
	[idclientev] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](max) NULL,
	[Direccion_para_factura] [varchar](max) NULL,
	[Ruc] [varchar](max) NULL,
	[movil] [varchar](50) NULL,
	[Cliente] [varchar](50) NULL,
	[Proveedor] [varchar](50) NULL,
	[Estado] [varchar](50) NULL,
	[Saldo] [numeric](18, 2) NULL,
 CONSTRAINT [PK_clientes] PRIMARY KEY CLUSTERED 
(
	[idclientev] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CONCEPTOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CONCEPTOS](
	[Id_concepto] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](max) NULL,
 CONSTRAINT [PK_CONCEPTOS] PRIMARY KEY CLUSTERED 
(
	[Id_concepto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CONEXION]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CONEXION](
	[Id_conexion] [int] IDENTITY(1,1) NOT NULL,
	[Data_source_REMOTO] [varchar](max) NULL,
 CONSTRAINT [PK_CONEXION] PRIMARY KEY CLUSTERED 
(
	[Id_conexion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CONTROL_DE_COBROS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CONTROL_DE_COBROS](
	[Id_control_de_cobros] [int] IDENTITY(1,1) NOT NULL,
	[Monto] [numeric](18, 2) NULL,
	[Concepto] [varchar](max) NULL,
	[Id_venta] [int] NULL,
 CONSTRAINT [PK_CONTROL_DE_COBROS] PRIMARY KEY CLUSTERED 
(
	[Id_control_de_cobros] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DETALLE_CONTROL_DE_COBROS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DETALLE_CONTROL_DE_COBROS](
	[Id_detalle_de_control_de_cobros] [int] IDENTITY(1,1) NOT NULL,
	[Pago_realizado] [numeric](18, 2) NULL,
	[Fecha_que_pago] [datetime] NULL,
	[Tipo_de_cobro] [varchar](50) NULL,
	[Detalle] [varchar](max) NULL,
	[Id_cliente] [int] NULL,
	[Id_usuario] [int] NULL,
	[Id_caja] [int] NULL,
 CONSTRAINT [PK_DETALLE_CONTROL_DE_COBROS] PRIMARY KEY CLUSTERED 
(
	[Id_detalle_de_control_de_cobros] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[detalle_venta]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[detalle_venta](
	[iddetalle_venta] [int] IDENTITY(1,1) NOT NULL,
	[idventa] [int] NOT NULL,
	[Id_producto] [int] NOT NULL,
	[cantidad] [numeric](18, 2) NULL,
	[preciounitario] [numeric](18, 2) NULL,
	[Modena] [varchar](50) NULL,
	[Total_a_pagar]  AS ([preciounitario]*[cantidad]),
	[Unidad_de_medida] [varchar](50) NULL,
	[Cantidad_mostrada] [numeric](18, 2) NULL,
	[Estado] [varchar](50) NULL,
	[Descripcion] [varchar](50) NULL,
	[Codigo] [varchar](50) NULL,
	[Stock] [varchar](50) NULL,
	[Se_vende_a] [varchar](50) NULL,
	[Usa_inventarios] [varchar](50) NULL,
	[Costo] [numeric](18, 2) NULL,
	[Ganancia]  AS ([cantidad]*[preciounitario]-[cantidad]*[Costo]),
 CONSTRAINT [PK_detalle_venta] PRIMARY KEY CLUSTERED 
(
	[iddetalle_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EMPRESA]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EMPRESA](
	[Id_empresa] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Empresa] [varchar](50) NULL,
	[Logo] [image] NULL,
	[Impuesto] [varchar](50) NULL,
	[Porcentaje_impuesto] [numeric](18, 0) NULL,
	[Moneda] [varchar](50) NULL,
	[Trabajas_con_impuestos] [varchar](50) NULL,
	[Modo_de_busqueda] [varchar](50) NULL,
	[Carpeta_para_copias_de_seguridad] [varchar](max) NULL,
	[Correo_para_envio_de_reportes] [varchar](50) NULL,
	[Ultima_fecha_de_copia_de_seguridad] [varchar](50) NULL,
 CONSTRAINT [PK_EMPRESA] PRIMARY KEY CLUSTERED 
(
	[Id_empresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GASTOSVARIOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GASTOSVARIOS](
	[Idgasto] [int] IDENTITY(1,1) NOT NULL,
	[Fecha_del_Gasto] [datetime] NULL,
	[Nro_Comprobante] [varchar](50) NULL,
	[Tipo_de_Comprobante] [varchar](50) NULL,
	[Importe] [numeric](18, 2) NULL,
	[Descripcion] [varchar](500) NULL,
	[Id_concepto] [int] NULL,
	[Id_usuario] [int] NULL,
	[TIPO] [varchar](50) NULL,
	[Id_caja] [int] NULL,
 CONSTRAINT [PK_GASTOSVARIOS] PRIMARY KEY CLUSTERED 
(
	[Idgasto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HORARIOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HORARIOS](
	[Id_horarios] [int] IDENTITY(1,1) NOT NULL,
	[Cargo] [varchar](50) NULL,
	[Horas_laborales_diarias] [numeric](18, 1) NULL,
	[Costo_hora_normal] [numeric](18, 2) NULL,
	[Costo_hora_extra] [numeric](18, 2) NULL,
	[Horas_libres_diarias] [numeric](18, 1) NULL,
	[lunes] [int] NULL,
	[martes] [int] NULL,
	[miercoles] [int] NULL,
	[jueves] [int] NULL,
	[viernes] [int] NULL,
	[sabado] [int] NULL,
	[domingo] [int] NULL,
 CONSTRAINT [PK_HORARIOS] PRIMARY KEY CLUSTERED 
(
	[Id_horarios] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[INGRESOSVARIOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[INGRESOSVARIOS](
	[Idgasto] [int] IDENTITY(1,1) NOT NULL,
	[Fecha_del_Gasto] [datetime] NULL,
	[Nro_Comprobante] [varchar](50) NULL,
	[Tipo_de_Comprobante] [varchar](50) NULL,
	[Importe] [decimal](18, 2) NULL,
	[Observacion] [varchar](500) NULL,
	[Estado] [varchar](50) NULL,
	[Id_concepto] [int] NULL,
 CONSTRAINT [PK_INGRESOSVARIOS] PRIMARY KEY CLUSTERED 
(
	[Idgasto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KARDEX]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KARDEX](
	[Id_kardex] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NULL,
	[Motivo] [varchar](200) NULL,
	[Cantidad] [numeric](18, 0) NULL,
	[Id_producto] [int] NULL,
	[Id_usuario] [int] NULL,
	[Tipo] [varchar](50) NULL,
	[Estado] [varchar](50) NULL,
	[Total]  AS ([Cantidad]*[Costo_unt]),
	[Costo_unt] [numeric](18, 2) NULL,
	[Habia] [numeric](18, 2) NULL,
	[Hay] [numeric](18, 2) NULL,
 CONSTRAINT [PK_KARDEX] PRIMARY KEY CLUSTERED 
(
	[Id_kardex] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[linea]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[linea](
	[Idline] [int] IDENTITY(1,1) NOT NULL,
	[Linea] [varchar](50) NULL,
 CONSTRAINT [PK_linea] PRIMARY KEY CLUSTERED 
(
	[Idline] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Marcan]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Marcan](
	[Id_marca] [int] IDENTITY(1,1) NOT NULL,
	[S] [varchar](50) NULL,
	[F] [varchar](max) NULL,
 CONSTRAINT [PK_Licencias] PRIMARY KEY CLUSTERED 
(
	[Id_marca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MOVIMIENTOCAJA]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MOVIMIENTOCAJA](
	[idmovcaja] [varchar](12) NOT NULL,
	[fechamov] [datetime] NULL,
	[tipomov] [varchar](20) NULL,
	[nombretipomov] [varchar](20) NULL,
	[descripciontipomov] [varchar](120) NULL,
	[totalmov] [real] NULL,
	[movcerrado] [char](2) NULL,
	[estado] [char](1) NULL,
	[mediodepago] [varchar](20) NULL,
	[idcompraventa] [varchar](12) NULL,
	[idusuario] [numeric](18, 0) NULL,
	[idcierrecaja] [varchar](12) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MOVIMIENTOCAJACIERRE]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MOVIMIENTOCAJACIERRE](
	[idcierrecaja] [int] IDENTITY(1,1) NOT NULL,
	[fechainicio] [datetime] NULL,
	[fechafin] [datetime] NULL,
	[fechacierre] [datetime] NULL,
	[ingresos] [numeric](18, 2) NULL,
	[egresos] [numeric](18, 2) NULL,
	[Saldo_queda_en_caja] [numeric](18, 2) NULL,
	[Id_usuario] [int] NULL,
	[Total_calculado] [numeric](18, 2) NULL,
	[Total_real] [numeric](18, 2) NULL,
	[Estado] [varchar](50) NULL,
	[Diferencia] [numeric](18, 2) NULL,
	[Id_caja] [int] NULL,
 CONSTRAINT [PK_MOVIMIENTOCAJACIERRE] PRIMARY KEY CLUSTERED 
(
	[idcierrecaja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OFERTAS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OFERTAS](
	[Id_oferta] [int] IDENTITY(1,1) NOT NULL,
	[Id_presentacion_fraccionada] [int] NULL,
	[Cantidad_condicional] [numeric](18, 2) NULL,
	[Id_unidad_condicional] [int] NULL,
	[Descuento] [numeric](18, 2) NULL,
 CONSTRAINT [PK_OFERTAS] PRIMARY KEY CLUSTERED 
(
	[Id_oferta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[permisos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permisos](
	[Id_Permiso] [int] IDENTITY(1,1) NOT NULL,
	[Id_Usuario] [int] NULL,
	[ventas] [int] NULL,
	[aplicar_descuentos] [int] NULL,
	[Devoluciones] [int] NULL,
	[cobros] [int] NULL,
	[Pagar] [int] NULL,
	[clientes_proveedores] [int] NULL,
	[productos] [int] NULL,
	[invetarios_kardex] [int] NULL,
	[configuraciones] [int] NULL,
	[usuarios] [int] NULL,
	[reportes] [int] NULL,
 CONSTRAINT [PK_p] PRIMARY KEY CLUSTERED 
(
	[Id_Permiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Producto1]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Producto1](
	[Id_Producto1] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[Imagen] [varchar](50) NULL,
	[Linea] [varchar](50) NULL,
	[Usa_inventarios] [varchar](50) NULL,
	[Stock] [varchar](50) NULL,
	[Precio_de_compra] [numeric](18, 2) NULL,
	[Fecha_de_vencimiento] [varchar](50) NULL,
	[Precio_de_venta] [numeric](18, 2) NULL,
	[Codigo] [varchar](50) NULL,
	[Se_vende_a] [varchar](50) NULL,
	[Impuesto] [varchar](50) NULL,
	[Stock_minimo] [numeric](18, 2) NULL,
	[Precio_mayoreo] [numeric](18, 2) NULL,
	[Sub_total_pv]  AS ([Precio_de_venta]-([Precio_de_venta]*[Impuesto])/(100)),
	[Sub_total_pm]  AS ([Precio_mayoreo]-([Precio_mayoreo]*[Impuesto])/(100)),
 CONSTRAINT [PK_Producto1] PRIMARY KEY CLUSTERED 
(
	[Id_Producto1] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[programacion_de_cuotas]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[programacion_de_cuotas](
	[Id_Programacion_cuota] [int] IDENTITY(1,1) NOT NULL,
	[Monto_cuota] [decimal](18, 2) NULL,
	[Cuotas] [nchar](10) NULL,
	[Estado] [varchar](50) NULL,
	[Fechas_Programadas] [varchar](50) NULL,
	[Saldo] [decimal](18, 2) NULL,
	[Id_programacion_de_cuota_padre] [int] NULL,
 CONSTRAINT [PK_programacion_de_cuotas] PRIMARY KEY CLUSTERED 
(
	[Id_Programacion_cuota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PROGRAMACION_DE_CUOTAS_PADRE]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PROGRAMACION_DE_CUOTAS_PADRE](
	[Id_programacion_de_cuota_padre] [int] IDENTITY(1,1) NOT NULL,
	[Monto_total] [numeric](18, 2) NULL,
	[Porcentaje_de_inicial] [varchar](50) NULL,
	[Monto_inicial] [numeric](18, 2) NULL,
	[Total_a_financiar] [numeric](18, 2) NULL,
	[Modalidad_de_cuotas] [varchar](50) NULL,
	[Tasa_de_interes_anual] [varchar](50) NULL,
	[Cuotas_totales] [int] NULL,
	[Id_venta] [int] NULL,
	[Valor_final] [numeric](18, 2) NULL,
	[Banco_financiero] [varchar](50) NULL,
	[Bono_de_buen_pagador] [numeric](18, 2) NULL,
	[Estado_de_cobro_de_bono] [varchar](50) NULL,
 CONSTRAINT [PK_PROGRAMACION_DE_CUOTAS_PADRE] PRIMARY KEY CLUSTERED 
(
	[Id_programacion_de_cuota_padre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PROMOCIONES]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROMOCIONES](
	[Id_promocion] [int] IDENTITY(1,1) NOT NULL,
	[Id_Producto] [int] NULL,
	[A_partir_de] [numeric](18, 2) NULL,
	[Precio_de_promocion] [numeric](18, 2) NULL,
 CONSTRAINT [PK_PROMOCIONES] PRIMARY KEY CLUSTERED 
(
	[Id_promocion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Serializacion]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Serializacion](
	[Id_serializacion] [int] IDENTITY(1,1) NOT NULL,
	[Serie] [varchar](50) NULL,
	[numeroinicio] [varchar](50) NULL,
	[numerofin] [varchar](50) NULL,
	[Destino] [varchar](50) NULL,
	[Id_tipodoc] [varchar](50) NULL,
 CONSTRAINT [PK_Serializacion] PRIMARY KEY CLUSTERED 
(
	[Id_serializacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ticket]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ticket](
	[Id_ticket] [int] IDENTITY(1,1) NOT NULL,
	[Id_empresa] [int] NULL,
	[Empresa_Ruc] [varchar](max) NULL,
	[Direccion] [varchar](max) NULL,
	[Provincia] [varchar](max) NULL,
	[Moneda_string] [varchar](max) NULL,
	[Agradecimiento] [varchar](max) NULL,
	[pagina_Web_Facebook] [varchar](max) NULL,
	[Extra] [varchar](max) NULL,
 CONSTRAINT [PK_Ticket] PRIMARY KEY CLUSTERED 
(
	[Id_ticket] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[USUARIO2]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[USUARIO2](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_y_Apelllidos] [varchar](50) NULL,
	[Login] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
 CONSTRAINT [PK_USUARIO2] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ventas]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ventas](
	[idventa] [int] IDENTITY(1,1) NOT NULL,
	[idclientev] [int] NULL,
	[fecha_venta] [datetime] NULL,
	[Numero_de_doc] [varchar](50) NULL,
	[Monto_total] [numeric](18, 1) NULL,
	[Tipo_de_pago] [varchar](50) NULL,
	[Estado] [varchar](50) NULL,
	[IGV] [numeric](18, 1) NULL,
	[Comprobante] [varchar](50) NULL,
	[Id_usuario] [int] NULL,
	[Fecha_de_pago] [varchar](50) NULL,
	[ACCION] [varchar](50) NULL,
	[Saldo] [numeric](18, 2) NULL,
	[Pago_con] [numeric](18, 2) NULL,
	[Porcentaje_IGV] [numeric](18, 2) NULL,
	[Id_caja] [int] NULL,
 CONSTRAINT [PK_ventas] PRIMARY KEY CLUSTERED 
(
	[idventa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[VISTA_A_MODIFICAR]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



GO
ALTER TABLE [dbo].[ASISTENCIAS]  WITH CHECK ADD  CONSTRAINT [FK_ASISTENCIAS_USUARIO2] FOREIGN KEY([Id_personal])
REFERENCES [dbo].[USUARIO2] ([idUsuario])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ASISTENCIAS] CHECK CONSTRAINT [FK_ASISTENCIAS_USUARIO2]
GO
ALTER TABLE [dbo].[CONTROL_DE_COBROS]  WITH CHECK ADD  CONSTRAINT [FK_CONTROL_DE_COBROS_ventas] FOREIGN KEY([Id_venta])
REFERENCES [dbo].[ventas] ([idventa])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CONTROL_DE_COBROS] CHECK CONSTRAINT [FK_CONTROL_DE_COBROS_ventas]
GO
ALTER TABLE [dbo].[DETALLE_CONTROL_DE_COBROS]  WITH CHECK ADD  CONSTRAINT [FK_DETALLE_CONTROL_DE_COBROS_clientes] FOREIGN KEY([Id_cliente])
REFERENCES [dbo].[clientes] ([idclientev])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DETALLE_CONTROL_DE_COBROS] CHECK CONSTRAINT [FK_DETALLE_CONTROL_DE_COBROS_clientes]
GO
ALTER TABLE [dbo].[DETALLE_CONTROL_DE_COBROS]  WITH CHECK ADD  CONSTRAINT [FK_DETALLE_CONTROL_DE_COBROS_USUARIO2] FOREIGN KEY([Id_usuario])
REFERENCES [dbo].[USUARIO2] ([idUsuario])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DETALLE_CONTROL_DE_COBROS] CHECK CONSTRAINT [FK_DETALLE_CONTROL_DE_COBROS_USUARIO2]
GO
ALTER TABLE [dbo].[detalle_venta]  WITH CHECK ADD  CONSTRAINT [FK_detalle_venta_ventas1] FOREIGN KEY([idventa])
REFERENCES [dbo].[ventas] ([idventa])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[detalle_venta] CHECK CONSTRAINT [FK_detalle_venta_ventas1]
GO
ALTER TABLE [dbo].[INGRESOSVARIOS]  WITH CHECK ADD  CONSTRAINT [FK_INGRESOSVARIOS_CONCEPTOS] FOREIGN KEY([Id_concepto])
REFERENCES [dbo].[CONCEPTOS] ([Id_concepto])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[INGRESOSVARIOS] CHECK CONSTRAINT [FK_INGRESOSVARIOS_CONCEPTOS]
GO
ALTER TABLE [dbo].[KARDEX]  WITH CHECK ADD  CONSTRAINT [FK_KARDEX_USUARIO2] FOREIGN KEY([Id_usuario])
REFERENCES [dbo].[USUARIO2] ([idUsuario])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[KARDEX] CHECK CONSTRAINT [FK_KARDEX_USUARIO2]
GO
ALTER TABLE [dbo].[MOVIMIENTOCAJACIERRE]  WITH CHECK ADD  CONSTRAINT [FK_MOVIMIENTOCAJACIERRE_USUARIO2] FOREIGN KEY([Id_usuario])
REFERENCES [dbo].[USUARIO2] ([idUsuario])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[MOVIMIENTOCAJACIERRE] CHECK CONSTRAINT [FK_MOVIMIENTOCAJACIERRE_USUARIO2]
GO
ALTER TABLE [dbo].[permisos]  WITH CHECK ADD  CONSTRAINT [FK_permisos_USUARIO2] FOREIGN KEY([Id_Usuario])
REFERENCES [dbo].[USUARIO2] ([idUsuario])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[permisos] CHECK CONSTRAINT [FK_permisos_USUARIO2]
GO
ALTER TABLE [dbo].[programacion_de_cuotas]  WITH CHECK ADD  CONSTRAINT [FK_programacion_de_cuotas_PROGRAMACION_DE_CUOTAS_PADRE] FOREIGN KEY([Id_programacion_de_cuota_padre])
REFERENCES [dbo].[PROGRAMACION_DE_CUOTAS_PADRE] ([Id_programacion_de_cuota_padre])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[programacion_de_cuotas] CHECK CONSTRAINT [FK_programacion_de_cuotas_PROGRAMACION_DE_CUOTAS_PADRE]
GO
ALTER TABLE [dbo].[PROGRAMACION_DE_CUOTAS_PADRE]  WITH CHECK ADD  CONSTRAINT [FK_PROGRAMACION_DE_CUOTAS_PADRE_ventas] FOREIGN KEY([Id_venta])
REFERENCES [dbo].[ventas] ([idventa])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PROGRAMACION_DE_CUOTAS_PADRE] CHECK CONSTRAINT [FK_PROGRAMACION_DE_CUOTAS_PADRE_ventas]
GO
ALTER TABLE [dbo].[ventas]  WITH CHECK ADD  CONSTRAINT [FK_ventas_USUARIO2] FOREIGN KEY([Id_usuario])
REFERENCES [dbo].[USUARIO2] ([idUsuario])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ventas] CHECK CONSTRAINT [FK_ventas_USUARIO2]
GO
/****** Object:  StoredProcedure [dbo].[_buscar_productos_agregados_A_PEDIDO_DE_VENTA]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[_buscar_productos_agregados_A_PEDIDO_DE_VENTA]
@letra VARCHAR(50)
AS BEGIN
SELECT       CONVERT(date, ventas.Fecha_de_pago ) as F_de_Entrega  ,(Serializacion.Id_tipodoc +'-'+ ventas.Numero_de_doc) AS Comprobante ,(dbo.Producto1.Descripcion + '- ' + dbo.Presentaciones.Presentacion+' x'+ Presentaciones.Cantidad_por_presentacion  +Presentaciones .Unidad_de_medida  ) as Producto, (convert (varchar (50),dbo.detalle_venta.Cantidad_mostrada)+ '-'+ dbo.detalle_venta.Unidad_de_medida ) as Cant, 
                         dbo.detalle_venta.preciounitario as Precio_Unit ,dbo.detalle_venta.Total_a_pagar, dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada,DBO.detalle_venta.iddetalle_venta ,dbo.ventas.Estado 
						 ,dbo.Presentaciones_fraccionadas.Stock ,dbo.detalle_venta.cantidad 

FROM            dbo.detalle_venta INNER JOIN
                         dbo.ventas ON dbo.detalle_venta.idventa = dbo.ventas.idventa INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.detalle_venta.Id_presentacionfraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1 INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion     
						 INNER JOIN Serializacion ON Serializacion.Id_serializacion =ventas.Id_series 
						 INNER JOIN clientes ON clientes.idclientev=ventas.idclientev 
where clientes.Nombre + clientes.Ruc+Serializacion.Id_tipodoc +'-'+ ventas.Numero_de_doc   LIKE  '%' + @letra+'%' and dbo.ventas.ACCION ='PEDIDO DE VENTA'
end
GO
/****** Object:  StoredProcedure [dbo].[activar_la_escritura_de_mdf]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[activar_la_escritura_de_mdf]
as
ALTER DATABASE   BASEMAGBRI Set Read_write
GO
/****** Object:  StoredProcedure [dbo].[ACTIVAR_PRESENTACIONES_FRACCIONADAS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ACTIVAR_PRESENTACIONES_FRACCIONADAS]
@idPresentaciones_fraccionadas integer

as 
update Presentaciones_fraccionadas set Activo = 'SI'
where Id_presentacionfraccionada  = @idPresentaciones_fraccionadas AND Presentaciones_fraccionadas.Activo ='NO'


GO
/****** Object:  StoredProcedure [dbo].[actualizar_cantidad_utilizada_de_materiales_en_fraccionamiento_de_productos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[actualizar_cantidad_utilizada_de_materiales_en_fraccionamiento_de_productos]
@Id_presentacionfraccionada as varchar(50),
@cantidad as decimal (18,2)

as
update Formulaciones_de_fraccionamiento_de_productos  set Cantidad =@cantidad where Id_presentacionfraccionada =@Id_presentacionfraccionada

GO
/****** Object:  StoredProcedure [dbo].[actualizar_en_base_a_cantidad]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[actualizar_en_base_a_cantidad]
@Id_materiales int,
 @En_base_a numeric(18, 0)
           
as 
update Formulaciones set  Cantidad=(@En_base_a * Cantidad)/  En_base_a
         
where Id_materiales=@Id_materiales



GO
/****** Object:  StoredProcedure [dbo].[actualizar_estado_de_cuota]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[actualizar_estado_de_cuota]
@idprogramacioncuota as integer

as 
update  programacion_de_cuotas  set Estado='PAGADO'
where Id_Programacion_cuota=@idprogramacioncuota AND Saldo  = 0 AND Estado='DEUDA'

GO
/****** Object:  StoredProcedure [dbo].[actualizar_estado_de_DETALLE__de_compra_despachado]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizar_estado_de_DETALLE__de_compra_despachado]
@iddetallecompra int

as

update Detalle_Compra set Estado='RECEPCION CONFIRMADA'
where iddetallecompra    =@iddetallecompra  AND Estado='RECEPCION PENDIENTE'

GO
/****** Object:  StoredProcedure [dbo].[actualizar_estado_de_DETALLE_a_emision_de_guia_confirmada]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizar_estado_de_DETALLE_a_emision_de_guia_confirmada]
@iddetalleventa int

as

update detalle_venta set Estado='GUIA EMITIDA/PENDIENTE DE CONFORMIDAD'
where iddetalle_venta   =@iddetalleventa  


GO
/****** Object:  StoredProcedure [dbo].[actualizar_estado_de_DETALLE_a_emision_de_guia_pendiente]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizar_estado_de_DETALLE_a_emision_de_guia_pendiente]
@iddetalleventa int

as

update detalle_venta set Estado='EMISION DE GUIA PENDIENTE'
where iddetalle_venta   =@iddetalleventa  


GO
/****** Object:  StoredProcedure [dbo].[actualizar_estado_de_DETALLE_despachado]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizar_estado_de_DETALLE_despachado]
@iddetalleventa int

as

update detalle_venta set Estado='DESPACHADO'
where iddetalle_venta   =@iddetalleventa  AND Estado='DESPACHO PENDIENTE'

GO
/****** Object:  StoredProcedure [dbo].[actualizar_estado_de_DETALLE_ventas_a_programado]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizar_estado_de_DETALLE_ventas_a_programado]
@iddetalleventa int

as

update detalle_venta set Estado='PROGRAMADO'
where iddetalle_venta   =@iddetalleventa  


GO
/****** Object:  StoredProcedure [dbo].[actualizar_estado_de_DETALLE_ventas_para_finalizar_la_programacion]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizar_estado_de_DETALLE_ventas_para_finalizar_la_programacion]
@iddetalleventa int

as

update detalle_venta set Estado='PRODUCCION CONCLUIDA'
where iddetalle_venta   =@iddetalleventa  


GO
/****** Object:  StoredProcedure [dbo].[actualizar_estado_de_DETALLE_ventas_para_iniciar_la_programacion]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizar_estado_de_DETALLE_ventas_para_iniciar_la_programacion]
@iddetalleventa int

as

update detalle_venta set Estado='PROGRAMACION PENDIENTE'
where iddetalle_venta   =@iddetalleventa  



GO
/****** Object:  StoredProcedure [dbo].[actualizar_estado_para_finalizar_Orden_de_Produccion]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[actualizar_estado_para_finalizar_Orden_de_Produccion]
@IdOrden int
as 
update Ordendeproduccion  set 
Estado='ENTREGA PENDIENTE'
where IdOrden=@IdOrden and Estado='Ejecutandose la producción'


GO
/****** Object:  StoredProcedure [dbo].[actualizar_estado_para_iniciar_Orden_de_Produccion]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[actualizar_estado_para_iniciar_Orden_de_Produccion]
@IdOrden int
as 
update Ordendeproduccion  set 
Estado='Ejecutandose la producción'
where IdOrden=@IdOrden and Estado='Esperando confirmar'


GO
/****** Object:  StoredProcedure [dbo].[actualizar_estado_venta_por_deposito_a_banco]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizar_estado_venta_por_deposito_a_banco]
@idventa as int
as

update ventas  set Estado='DEUDA',Tipo_de_pago='DEPOSITO BANCARIO'
where Estado='APROBACION PENDIENTE' and idventa  =@idventa 

GO
/****** Object:  StoredProcedure [dbo].[actualizar_lotizaciones_durante_la_finalizar_produccion]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[actualizar_lotizaciones_durante_la_finalizar_produccion]
@Id_orden_de_produccion int,
@Fecha_de_vencimiento as date,
@Precio_Venta_Al_Publico as numeric(18,2),
@Precio_Venta_AlPormayor as numeric(18,2)


as 
update Lotizacion set 
Estado='Pendiente de entrega'
where Id_orden_de_produccion =@Id_orden_de_produccion and Estado='NO CONFIRMADO'


GO
/****** Object:  StoredProcedure [dbo].[actualizar_precio_de_compra_de_productos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[actualizar_precio_de_compra_de_productos]
@Id_presentacionfraccionada int,
@precio_de_compra as decimal (18,6),
@Precio_de_compra_mostrado as decimal (18,2)
as
update Presentaciones_fraccionadas   set Precio_de_compra=@precio_de_compra ,Precio_de_compra_mostrado=@Precio_de_compra_mostrado 
where Id_presentacionfraccionada =@Id_presentacionfraccionada


GO
/****** Object:  StoredProcedure [dbo].[actualizar_serializacion_mas_uno]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[actualizar_serializacion_mas_uno]

@idserie as int  ,

@numero varchar(50),
@numerofin as numeric(18,0)  
as 
if EXISTS (SELECT Comprobante ,Numero_de_doc FROM ventas  where  Comprobante +' '+Numero_de_doc =@numero  )
RAISERROR ('YA EXISTE ESTE NUMERO DE COMPROBANTE INGRESE UNO NUEVO', 16,1)
else
update Serializacion set  numerofin=@numerofin            
where Id_serializacion=@idserie 


GO
/****** Object:  StoredProcedure [dbo].[actualizar_stock_de_materiales_luego_de_confirmar_produccion]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[actualizar_stock_de_materiales_luego_de_confirmar_produccion]
@Id_materiales int,
 @cantidad as numeric(18,1)
           
as 
update materiales  set  Stock =Stock-@cantidad 
        
where dbo.materiales.Id_materiales  =@Id_materiales 



GO
/****** Object:  StoredProcedure [dbo].[actualizar_stock_de_materiales_por_inicio_de_produccion]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[actualizar_stock_de_materiales_por_inicio_de_produccion]
@IdOrden int         
as 
update materiales set  Stock =Stock-dbo.Formulaciones.Cantidad    
       
FROM            dbo.Formulaciones INNER JOIN
                   
                         dbo.materiales ON dbo.Formulaciones.Id_materiales = dbo.materiales.Id_materiales INNER JOIN
                         
						 dbo.Producto1 ON dbo.Formulaciones.Id_producto  = dbo.Producto1.Id_Producto1 inner join
						 dbo.Ordendeproduccion on dbo.Ordendeproduccion.IdProducto =dbo.Producto1.Id_Producto1 
where dbo.Ordendeproduccion.IdOrden =@IdOrden   


GO
/****** Object:  StoredProcedure [dbo].[actualizar_totalalquiler]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[actualizar_totalalquiler]
@idalquiler as int,
@totalapagar as decimal(18,2)
as
if @totalapagar <> 0
update Alquilerdehabitacion set Total_a_pagar=@totalapagar 
where IdAlquiler=@idalquiler 
else 
begin
delete
from Alquilerdehabitacion 
where IdAlquiler=@idalquiler 
end






GO
/****** Object:  StoredProcedure [dbo].[actualizar_totalcompra]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[actualizar_totalcompra]
@Cod_compra int,
@Total_a_pagar decimal(18,2),
@IGV as numeric(18,1)
,@Tipo_de_pago AS VARCHAR(50)
as
if @Total_a_pagar <> 0
update Compra set Total_a_pagar = @Total_a_pagar,IGV=@IGV ,Tipo_de_pago =@Tipo_de_pago 
where Cod_compra = @Cod_compra
else 
begin
delete 
from Compra
where Cod_compra = @Cod_compra
end





GO
/****** Object:  StoredProcedure [dbo].[actualizarestado_compras]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizarestado_compras]

@resto as decimal(18,2),
@idcompra as int
as
if @resto <>0.00
update Compra   set Estado='DEUDA'
where Estado='DEUDA' and Cod_compra   =@idcompra
else
update Compra  set Estado='CREDITO PAGADO'
where  Estado='DEUDA' and Cod_compra   =@idcompra

GO
/****** Object:  StoredProcedure [dbo].[actualizarestado_DETALLEventa_FRACCIONAMIENTO]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizarestado_DETALLEventa_FRACCIONAMIENTO]

@resto as decimal(18,2),
@iddetalleventa as int
as
if @resto <>0.00
update detalle_venta   set Estado='DEUDA-ETAPA I'
where Estado='ETAPA-1' and idventa  =@iddetalleventa
else
update detalle_venta set Estado='PAGADO-ETAPA I'
where  Estado='ETAPA-1' and idventa  =@iddetalleventa

GO
/****** Object:  StoredProcedure [dbo].[actualizarestado_venta]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizarestado_venta]

@resto as decimal(18,2),
@idventa as int
as
if @resto <>0.00
update ventas  set Estado='DEUDA'
where Estado='DEUDA' and idventa  =@idventa
else
update ventas set Estado='CREDITO PAGADO'
where  Estado='DEUDA' and idventa  =@idventa

GO
/****** Object:  StoredProcedure [dbo].[actualizarestado_venta_FRACCIONAMIENTO]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizarestado_venta_FRACCIONAMIENTO]

@resto as decimal(18,2),
@idventa as int
as
if @resto <>0.00
update ventas  set Estado='DEUDA'
where Estado='APROBACION PENDIENTE' and idventa  =@idventa
else
update ventas set Estado='CREDITO PAGADO'
where  Estado='APROBACION PENDIENTE' and idventa  =@idventa

GO
/****** Object:  StoredProcedure [dbo].[actualizartotal_Canje_de_comprobantes_de_ventas]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[actualizartotal_compra]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizartotal_compra]
@idcompra int,
@montototal as numeric(18,1),
@IGV as numeric(18,1),

@Tipo_de_pago as varchar(50)

as
if @montototal <>0
update Compra  set Total_a_pagar   =@montototal, IGV=@IGV ,Tipo_de_pago =@Tipo_de_pago
where Cod_compra  =@idcompra 
else
begin 
delete
from Compra 
where Cod_compra =@idcompra  
end




GO
/****** Object:  StoredProcedure [dbo].[actualizartotal_venta]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizartotal_venta]
@idventa int,
@montototal as numeric(18,1),
@IGV as numeric(18,1)

,@Saldo numeric(18,2),
@Tipo_de_pago varchar(50),
@Estado varchar(50),
@Id_series varchar(50),
@Numero_de_doc varchar(50),
@fecha_venta datetime,
@ACCION varchar(50),
@Fecha_de_pago varchar(50),
@idcliente int,
@Pago_con numeric(18,2)
as
if @montototal <>0
update ventas set Monto_total  =@montototal, IGV=@IGV ,Saldo=@Saldo,
Tipo_de_pago=@Tipo_de_pago 
,Estado=@Estado ,
Comprobante =@Id_series ,
Numero_de_doc=@Numero_de_doc ,
fecha_venta=@fecha_venta ,
ACCION=@ACCION ,Fecha_de_pago =@Fecha_de_pago ,idclientev=@idcliente ,
Pago_con=@Pago_con
where idventa =@idventa 
else
begin 
delete
from ventas
where idventa=@idventa 
end




GO
/****** Object:  StoredProcedure [dbo].[actualizarventasfacturaspagadas]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizarventasfacturaspagadas]
@idcliente as integer

as
update ventas set Estado = 'PAGADO'  
where idclientev=@idcliente 




GO
/****** Object:  StoredProcedure [dbo].[AgregarProducto]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- ALTER date: <ALTER Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AgregarProducto]
	-- Add the parameters for the stored procedure here
	@Nombre varchar(50), @Detalle varchar(200),
	@Precio decimal(18,5), @Stock decimal(18,5), @idCategoria int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Producto
	VALUES((SELECT ISNULL(MAX(IdProducto)+1,1) FROM Producto),@Nombre,@Detalle,@Precio,@Stock,@idCategoria,1)
END







GO
/****** Object:  StoredProcedure [dbo].[anuncioSERVICIOSMULTIPLES_HOY]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[anuncioSERVICIOSMULTIPLES_HOY]
AS
declare @fecha_sistema date
 set @fecha_sistema = (SELECT GETDATE())

SELECT        dbo.nombredeservicio.Servicio, (DateDiff(DD, @fecha_sistema,Fecha_de_Pago)) as Fecha_de_anuncio
FROM            dbo.SERVICIOS INNER JOIN
                         dbo.nombredeservicio ON dbo.SERVICIOS.Id_servicio = dbo.nombredeservicio.Id_nombreServicio
						 WHERE Estado ='DEUDA' AND (DateDiff(DD, @fecha_sistema,Fecha_de_Pago))=0
						 GROUP BY   dbo.nombredeservicio.Servicio,Fecha_de_Pago




GO
/****** Object:  StoredProcedure [dbo].[anuncioSERVICIOSMULTIPLES_NORMALES]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[anuncioSERVICIOSMULTIPLES_NORMALES]
AS
declare @fecha_sistema date
 set @fecha_sistema = (SELECT GETDATE())

SELECT        dbo.nombredeservicio.Servicio, (DateDiff(DD, @fecha_sistema,Fecha_de_Pago)) as Fecha_de_anuncio
FROM            dbo.SERVICIOS INNER JOIN
                         dbo.nombredeservicio ON dbo.SERVICIOS.Id_servicio = dbo.nombredeservicio.Id_nombreServicio
						 WHERE Estado ='DEUDA' AND (DateDiff(DD, @fecha_sistema,Fecha_de_Pago))<Avisar_antes_de AND (DateDiff(DD, @fecha_sistema,Fecha_de_Pago))>0
						 GROUP BY   dbo.nombredeservicio.Servicio,Fecha_de_Pago




GO
/****** Object:  StoredProcedure [dbo].[anuncioSERVICIOSMULTIPLES_RETRASADOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[anuncioSERVICIOSMULTIPLES_RETRASADOS]
AS
declare @fecha_sistema date
 set @fecha_sistema = (SELECT GETDATE())

SELECT        dbo.nombredeservicio.Servicio, (DateDiff(DD, @fecha_sistema,Fecha_de_Pago)) as Fecha_de_anuncio
FROM            dbo.SERVICIOS INNER JOIN
                         dbo.nombredeservicio ON dbo.SERVICIOS.Id_servicio = dbo.nombredeservicio.Id_nombreServicio
						 WHERE Estado ='DEUDA' AND (DateDiff(DD, @fecha_sistema,Fecha_de_Pago))<0
						 GROUP BY   dbo.nombredeservicio.Servicio,Fecha_de_Pago




GO
/****** Object:  StoredProcedure [dbo].[APERTURA_DE_CAJA_PADRE]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[APERTURA_DE_CAJA_PADRE]

@Id_caja int,
@Fecha_de_cierre AS DATEtime,
@Estado varchar(50),
@id_usuario as int,
@fechainicio as datetime,
 @ingresos numeric(18,2), 
    @egresos numeric(18,2),
	
	@saldo numeric(18,2),
	 @totalcaluclado numeric(18,2),
	  @totalreal real, 	
	 @diferencia numeric(18,2)
  AS BEGIN
if EXISTS (SELECT Id_cierre_de_caja FROM CIERRE_DE_CAJA_PADRE  where Id_caja=@Id_caja    AND Estado='CAJA APERTURADA'  )
RAISERROR ('LA PRESENTE CAJA YA HA SIDO APERTURADA; PERO AUN NO HA SIDO CERRADA - CONTINUE-', 16,1)
else
BEGIN
insert into CIERRE_DE_CAJA_PADRE 
values (@Id_caja ,
@Fecha_de_cierre ,
@Estado,
@id_usuario ,
@fechainicio  ,
@ingresos , 
    @egresos ,
	
	@saldo ,
	 @totalcaluclado ,
	  @totalreal , 
	
	 @diferencia )
end
end




GO
/****** Object:  StoredProcedure [dbo].[aumentar_monto_saldo]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[aumentar_monto_saldo]
@idcliente as integer,

@montototal  as decimal(18,2)




as

update Saldo set  Monto_Total=@montototal+Monto_Total
where Id_Cliente=@idcliente 




GO
/****** Object:  StoredProcedure [dbo].[aumentar_monto_saldo_de_proveedor]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[aumentar_monto_saldo_de_proveedor]
@idproveedor as integer,
@resta as decimal(18,2),
@montototal  as decimal(18,2)

as 
update proveedores  set Resta=@resta,Monto_Total=@montototal
where Idproveedor  =@idproveedor 




GO
/****** Object:  StoredProcedure [dbo].[aumentar_resto]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[aumentar_resto]
@idcliente as integer,
@resta as decimal(18,2),
@monto_total as decimal(18,2)



as

update Saldo set  Resta=Resta+@monto_total 
where Id_Cliente=@idcliente 




GO
/****** Object:  StoredProcedure [dbo].[aumentar_saldo_a_cliente]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[aumentar_saldo_a_cliente]
@idcliente as integer,
@Saldo numeric(18,2)
          
as 
update clientes set 

          
			Saldo =Saldo+@Saldo 
where idclientev =@idcliente 




GO
/****** Object:  StoredProcedure [dbo].[aumentar_saldo_de_cuentas_bancarias]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[aumentar_saldo_de_cuentas_bancarias]
@Id_cuenta_bancaria as integer,
@monto as numeric(18,2),
@tipodemovimiento as varchar(50)
as

update Cuentas_corrientes_bancos_datos_generales set  Saldo =Saldo+@monto 
where Id_cuenta_bancaria =@Id_cuenta_bancaria AND @tipodemovimiento ='REGISTRO DE INGRESO'

GO
/****** Object:  StoredProcedure [dbo].[aumentar_saldo_de_cuentas_bancarias_POR_ELIMINACION]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[aumentar_saldo_de_cuentas_bancarias_POR_ELIMINACION]
@Id_cuenta_bancaria as integer,
@monto as numeric(18,2)
as

update Cuentas_corrientes_bancos_datos_generales set  Saldo =Saldo+@monto 
where Id_cuenta_bancaria =@Id_cuenta_bancaria 

GO
/****** Object:  StoredProcedure [dbo].[aumentar_stock]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[aumentar_stock]
@Id_presentacionfraccionada as INT,
@cantidad as decimal (18,2)

as
update Producto1   set Stock=Stock+@cantidad where Id_Producto1  =@Id_presentacionfraccionada AND Usa_inventarios ='SI'


GO
/****** Object:  StoredProcedure [dbo].[aumentar_stock_DE_MATERIALES]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[aumentar_stock_DE_MATERIALES]
@idMATERIALES as INT,
@cantidad as decimal (18,2)
as
update materiales   set Stock=Stock+@cantidad where Id_materiales  =@idMATERIALES


GO
/****** Object:  StoredProcedure [dbo].[aumentar_stock_en_detalle_de_venta]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[aumentar_stock_en_detalle_de_venta]
@Id_presentacionfraccionada as varchar(50),
@cantidad as decimal (18,2)

as
update detalle_venta   set Stock=Stock+@cantidad where Id_producto   =@Id_presentacionfraccionada AND Stock  <>'Ilimitado' AND Estado ='EN ESPERA'
GO
/****** Object:  StoredProcedure [dbo].[AUTORIZAR_A_USUARIOS_PARA_QUE_PROPIETARIO_DE_BASE_DE_DATOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AUTORIZAR_A_USUARIOS_PARA_QUE_PROPIETARIO_DE_BASE_DE_DATOS]
AS
Alter authorization on database::INM to sa
GO
/****** Object:  StoredProcedure [dbo].[backup_base]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[backup_base]
@ruta as varchar(max)
as
BACKUP DATABASE [BASEUP]
TO DISK =@ruta
WITH DESCRIPTION =N'respaldo de la base de datos de BASEUP',
NOFORMAT,
INIT,
NAME=N'BASEUP',
SKIP,
NOREWIND,
NOUNLOAD,
STATS=10,
CHECKSUM


GO
/****** Object:  StoredProcedure [dbo].[BOLETA_DE_VENTA]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[BOLETA_DE_VENTA]
@idventa as int
AS
SELECT        dbo.ventas.idventa, dbo.clientes.Nombre, dbo.clientes.Direccion_para_factura, dbo.detalle_venta.Cantidad_mostrada, dbo.detalle_venta.Unidad_de_medida, 
                         (dbo.Producto1.Descripcion+'-'+ dbo.Presentaciones.Presentacion)AS DETALLE, dbo.detalle_venta.Total_a_pagar,Cast( dbo.ventas.fecha_venta as date) as Fecha, dbo.ventas.Numero_de_doc, 
                         dbo.ventas.IGV, dbo.detalle_venta.preciounitario,dbo.detalle_venta .Cantidad_mostrada,dbo.ventas.Tipo_de_pago ,dbo.USUARIO2.Nombre_y_Apelllidos  
FROM            dbo.ventas INNER JOIN
                         dbo.detalle_venta ON dbo.ventas.idventa = dbo.detalle_venta.idventa INNER JOIN
                         dbo.detalle_venta AS detalle_venta_1 ON dbo.ventas.idventa = detalle_venta_1.idventa INNER JOIN
                         dbo.clientes ON dbo.ventas.idclientev = dbo.clientes.idclientev INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.detalle_venta.Id_presentacionfraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada AND 
                         detalle_venta_1.Id_presentacionfraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1 INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion inner join
						 dbo.USUARIO2 on dbo.USUARIO2.idUsuario =dbo.ventas.Id_usuario
						 where dbo.ventas.idventa=@idventa


GO
/****** Object:  StoredProcedure [dbo].[BORRAR_CAJA]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[borrar_proforma]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[borrar_proforma]
@idproforma as int
as
delete from PROFORMA where idproforma =@idproforma 





GO
/****** Object:  StoredProcedure [dbo].[buscar_ASISTENCIAS_por_id]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[buscar_ASISTENCIAS_por_id]
--declare @fecha_sistema date set @fecha_sistema = (SELECT GETDATE())
@letra int
AS 

SELECT        *
FROM            dbo.ASISTENCIAS 						 
WHEre Id_personal=@letra AND Estado='ENTRADA'


GO
/****** Object:  StoredProcedure [dbo].[buscar_ASISTENCIAS_por_id_para_horas]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[buscar_ASISTENCIAS_por_id_para_horas]
@letra int
AS 
declare @fecha_sistema date set @fecha_sistema = (SELECT GETDATE())
SELECT        *
FROM            dbo.ASISTENCIAS 						 
WHEre Id_personal=@letra and convert(date,Fecha_entrada)=@fecha_sistema 


GO
/****** Object:  StoredProcedure [dbo].[buscar_cliente]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_cliente]


@CLIENTE as varchar(50)

as begin
select * from NSERVICIOS   Where Cliente  LIKE @CLIENTE   +'%' 
end





GO
/****** Object:  StoredProcedure [dbo].[buscar_cliente_POR_nombre]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[buscar_cliente_POR_nombre_PARA_COBROS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_cliente_POR_nombre_PARA_COBROS]

@letra VARCHAR(50)
AS BEGIN
SELECT       dbo.clientes .Nombre ,dbo.clientes.idclientev ,Saldo 
FROM            clientes 
WHEre Nombre  LIKE  '%' + @letra+'%' and Cliente  ='SI' 
END

GO
/****** Object:  StoredProcedure [dbo].[buscar_cliente_POR_nombre_PARA_COMPRAS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_cliente_POR_nombre_PARA_COMPRAS]

@letra VARCHAR(50)
AS BEGIN
SELECT       dbo.clientes .Nombre ,dbo.clientes.idclientev 
FROM            clientes 
WHEre Nombre  LIKE  '%' + @letra+'%' and Proveedor ='SI' 
END

GO
/****** Object:  StoredProcedure [dbo].[buscar_cliente_POR_nombre_PARA_COMPRAS_buscador]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[buscar_cliente_POR_nombre_PARA_PAGOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_cliente_POR_nombre_PARA_PAGOS]

@letra VARCHAR(50)
AS BEGIN
SELECT       dbo.clientes .Nombre ,dbo.clientes.idclientev ,Saldo 
FROM            clientes 
WHEre Nombre  LIKE  '%' + @letra+'%' and Proveedor   ='SI' 
END

GO
/****** Object:  StoredProcedure [dbo].[buscar_cliente_POR_nombre_PARA_VENTAS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_cliente_POR_nombre_PARA_VENTAS]

@letra VARCHAR(50)
AS BEGIN
SELECT        DBO.clientes.Nombre ,DBO.clientes.idclientev  
FROM            clientes 

WHEre Nombre  LIKE  '%' + @letra+'%' and Cliente='SI'  
END
GO
/****** Object:  StoredProcedure [dbo].[buscar_cliente_POR_nombre_PARA_VENTAS_buscador]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_cliente_POR_nombre_PARA_VENTAS_buscador]

@letra VARCHAR(50)
AS BEGIN
SELECT        DBO.clientes.Nombre  ,clientes.idclientev,clientes.Saldo 
 
FROM         clientes 
WHEre Nombre  LIKE  '%' + @letra+'%' and Cliente='SI' 
group by	DBO.clientes.Nombre ,clientes.idclientev,clientes.Saldo 
END


GO
/****** Object:  StoredProcedure [dbo].[buscar_cliente_POR_nombre_PARA_VENTAS_por_contacto]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[buscar_cliente_POR_nombre_PARA_VENTAS_todos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_cliente_POR_nombre_PARA_VENTAS_todos]

@letra VARCHAR(50)
AS BEGIN
SELECT        DBO.clientes.Nombre ,DBO.clientes.idclientev ,Direccion_para_factura  ,movil  ,Ruc
FROM         clientes
WHEre Nombre+movil +Direccion_para_factura   LIKE  '%' + @letra+'%' and Cliente='SI'  ORDER BY idclientev desc
END
GO
/****** Object:  StoredProcedure [dbo].[buscar_cobros_x_vendedor_y_fecha]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[buscar_cobros_x_vendedor_y_fecha]
@idvendedor as int,
@fecha as date

as
SELECT       sum(DETALLE_CONTROL_DE_COBROS.Pago_realizado ) as TOTAL
						
FROM            DETALLE_CONTROL_DE_COBROS  
where Id_usuario =@idvendedor AND CONVERT(DATE,Fecha_que_pago )=@fecha 
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_CONCEPTOS_EN_GASTOS_VARIOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[BUSCAR_CONCEPTOS_EN_GASTOS_VARIOS]
@letra VARCHAR(50)
AS BEGIN
SELECT        dbo.CONCEPTOS.Id_concepto, dbo.CONCEPTOS.Descripcion AS Concepto 
                      
FROM            dbo.CONCEPTOS 
						 WHERE CONCEPTOS.Descripcion   LIKE  '%' + @letra+'%' 
						 END

GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_CONCEPTOS_EN_INGRESOS_VARIOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[BUSCAR_CONCEPTOS_EN_INGRESOS_VARIOS]
@letra VARCHAR(50)
AS BEGIN
SELECT        dbo.CONCEPTOS.Id_concepto, dbo.CONCEPTOS.Descripcion AS Concepto, dbo.GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS.Descripcion AS Grupo, 
                         dbo.GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS.Gasto,GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS.Id_grupo_concepto_gasto
FROM            dbo.CONCEPTOS INNER JOIN
                         dbo.GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS ON 
                         dbo.CONCEPTOS.Id_grupo = dbo.GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS.Id_grupo_concepto_gasto
						 WHERE CONCEPTOS.Descripcion   LIKE  '%' + @letra+'%' and Gasto='NO'
						 END
GO
/****** Object:  StoredProcedure [dbo].[buscar_creditos_x_vendedor_y_fecha]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_creditos_x_vendedor_y_fecha]
@idvendedor as int,
@fecha as date

as
SELECT       sum(ventas.Saldo ) as TOTAL
	FROM           
                         dbo.ventas 
						

     
where Id_usuario =@idvendedor AND CONVERT(DATE,ventas.fecha_venta   )=@fecha and
ventas.Estado='DEUDA' AND  ventas.Tipo_de_pago='CREDITO'
GO
/****** Object:  StoredProcedure [dbo].[buscar_dnin]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_dnin]


@dni as varchar(50)

as begin
select * from NSERVICIOS   Where DNI  LIKE @dni  +'%' 
end





GO
/****** Object:  StoredProcedure [dbo].[buscar_Empresa]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_Empresa]
@letra varchar(50)
as
select LOGO, Nombre_Empresa as Empresa ,(Impuesto + ' ('+  CONVERT(VARCHAR(50),Porcentaje_impuesto) + ')') Impuesto ,Moneda , Id_empresa AS OKA ,Id_empresa  
,Porcentaje_impuesto  ,Impuesto ,Trabajas_con_impuestos,Modo_de_busqueda 
from Empresa
where EMPRESA.Nombre_Empresa =@letra

GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_gastos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[buscar_GRUPOS_DE_GASTOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[buscar_GRUPOS_DE_INGRESOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_INGRESOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[buscar_linea]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_linea]
@linea as varchar(50)
as begin
select * from linea Where Linea LIKE @linea+'%'
end





GO
/****** Object:  StoredProcedure [dbo].[buscar_material_por_descripcion_para_compras]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


GO
/****** Object:  StoredProcedure [dbo].[buscar_mostrar_ventas_realizadas_pendientes_de_despacho_x_cliente]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[buscar_mostrar_ventas_realizadas_pendientes_de_despacho_x_numerodedoc]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[buscar_MOVIMIENTOS_DE_KARDEX]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[buscar_MOVIMIENTOS_DE_KARDEX]
@letra VARCHAR(50)
AS BEGIN
SELECT       KARDEX.Fecha ,Producto1.Descripcion ,KARDEX.Motivo as Movimiento, KARDEX.Habia ,KARDEX.Tipo ,KARDEX.Cantidad ,KARDEX.Hay ,USUARIO2.Nombre_y_Apelllidos as Cajero ,Producto1.Linea as Categoria
FROM            dbo.KARDEX INNER JOIN Producto1 on Producto1.Id_Producto1=KARDEX.Id_producto inner join USUARIO2 on USUARIO2.idUsuario =KARDEX.Id_usuario 
             
						 
WHEre Producto1.Descripcion +KARDEX.Motivo + convert(varchar(50),KARDEX.Habia) +KARDEX.Tipo +convert(varchar(50),KARDEX.Cantidad)+convert(varchar(50),KARDEX.Hay) +USUARIO2.Nombre_y_Apelllidos  +Producto1.Linea LIKE  '%' + @letra +'%'     order by KARDEX.Fecha Desc

END
GO
/****** Object:  StoredProcedure [dbo].[buscar_pedido_de_venta]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[buscar_pedido_de_venta]
@letra VARCHAR(50)
AS BEGIN
SELECT       CONVERT(date, ventas.Fecha_de_pago ) as F_de_Entrega ,USUARIO2.Nombre_y_Apelllidos as Usuario ,clientes.Nombre AS Cliente,(ventas .Id_series  +'-'+ ventas.Numero_de_doc) AS Comprobante ,(dbo.Producto1.Descripcion + '- ' + dbo.Presentaciones.Presentacion+' x'+ Presentaciones.Cantidad_por_presentacion  +Presentaciones .Unidad_de_medida  ) as Producto,(convert (varchar (50),dbo.detalle_venta.Cantidad_mostrada)+ '-'+ dbo.detalle_venta.Unidad_de_medida ) as Cant,  
                         dbo.detalle_venta.Total_a_pagar, dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada,DBO.detalle_venta.iddetalle_venta ,dbo.ventas.Estado 
						 ,dbo.detalle_venta.cantidad ,Presentaciones_fraccionadas.Stock ,Producto1.Servicio
						 
FROM            dbo.detalle_venta INNER JOIN
                         dbo.ventas ON dbo.detalle_venta.idventa = dbo.ventas.idventa INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.detalle_venta.Id_presentacionfraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1 INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion     
						
						 INNER JOIN clientes ON clientes.idclientev=ventas.idclientev 
						 inner join USUARIO2 on USUARIO2.idUsuario=ventas.Id_usuario 
where USUARIO2.Nombre_y_Apelllidos+ clientes.Nombre+clientes.DNI + (ventas .Id_series  +'-'+ ventas.Numero_de_doc) LIKE  '%' + @letra+'%' and dbo.ventas.ACCION ='PEDIDO DE VENTA' 
and  dbo.detalle_venta.Estado ='DESPACHO PENDIENTE'  order by convert(date,ventas.Fecha_de_pago) asc 
--WHEre (dbo.Producto1.Descripcion + '- ' + dbo.Presentaciones.Presentacion+' x'+ Presentaciones.Cantidad_por_presentacion  +Presentaciones .Unidad_de_medida  )  LIKE  '%' + @letra+'%' ORDER BY DBO.Producto1.Descripcion  asc
 
END



GO
/****** Object:  StoredProcedure [dbo].[buscar_personal_por_nombre]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[buscar_personal_por_nombre]
@letra VARCHAR(50)
AS BEGIN
SELECT        Id_personal, Nombres, Cargo, Sueldo
FROM            dbo.Personal
						 
WHEre Nombres  LIKE  '%' + @letra+'%' ORDER BY Id_personal DESC
END
GO
/****** Object:  StoredProcedure [dbo].[buscar_pro2]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_pro2]


@descripcion as varchar(550)


as begin
select * from productos2 Where Descripcion   LIKE @descripcion +'%' 
end





GO
/****** Object:  StoredProcedure [dbo].[buscar_pro3]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_pro3]


@marca as varchar(50)


as begin
select * from productos2 Where Marca    LIKE @marca  +'%' 
end





GO
/****** Object:  StoredProcedure [dbo].[buscar_producto]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_producto]


@idproducto as varchar(50)
--@descripcion as varchar(550),
--@marca as varchar(50)

as begin
select * from productos2 Where idproducto  LIKE @idproducto +'%' 
end





GO
/****** Object:  StoredProcedure [dbo].[buscar_producto_por_descripcion]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[buscar_producto_por_descripcion]
@letra VARCHAR(50)
AS BEGIN
select Id_Producto1,Codigo ,Linea as Categoria,Descripcion ,Impuesto,Usa_inventarios ,Precio_de_compra AS P_Compra,Precio_mayoreo as P_mayoreo,Se_vende_a as Se_vende_por,Stock_minimo ,Fecha_de_vencimiento as F_vencimiento ,Stock,Precio_de_venta as P_venta 


FROM            dbo.Producto1 
              
WHEre (dbo.Producto1.Descripcion)+Codigo +Linea   LIKE  '%' + @letra+'%' ORDER BY DBO.Producto1.Descripcion  asc
 
END



GO
/****** Object:  StoredProcedure [dbo].[buscar_producto_por_descripcion_DIBUJADO]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_producto_por_descripcion_DIBUJADO]
@letra VARCHAR(50)
AS BEGIN
SELECT        (dbo.Producto1.Descripcion +' '+dbo.Presentaciones.Presentacion+ ' x'+dbo.Presentaciones.Cantidad_por_presentacion+ dbo.Presentaciones.Unidad_de_medida) as Descripcion,dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada  ,
                       
                        dbo.Producto1.Id_Producto1  
                  
FROM            
                         dbo.Producto1 inner join 
						 
					
                         dbo.Presentaciones_fraccionadas ON dbo.Producto1.Id_Producto1 = dbo.Presentaciones_fraccionadas.Id_producto INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion

WHEre  (dbo.Producto1.Descripcion +' '+dbo.Presentaciones.Presentacion+ ' x'+dbo.Presentaciones.Cantidad_por_presentacion+ dbo.Presentaciones.Unidad_de_medida)  LIKE  '%' + @letra+'%' ORDER BY DBO.Producto1.Descripcion  asc
 
END


				



GO
/****** Object:  StoredProcedure [dbo].[buscar_producto_por_descripcion_para_compras]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[buscar_producto_por_descripcion_para_compras]
@letra VARCHAR(50)
AS BEGIN
SELECT        dbo.Producto1.Id_Producto1, dbo.Producto1.Descripcion,
                          dbo.Presentaciones.Presentacion ,dbo.Presentaciones_fraccionadas.Stock ,
                        dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada ,dbo.Presentaciones_fraccionadas .Precio_de_compra,dbo.Presentaciones_fraccionadas .Precio_de_compra_mostrado,dbo.Producto1.Marca 
FROM          
                         dbo.Producto1 INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.Producto1.Id_Producto1 = dbo.Presentaciones_fraccionadas.Id_producto 
                         INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion 

WHEre dbo.Producto1.Descripcion  LIKE  '%' + @letra+'%'
END



GO
/****** Object:  StoredProcedure [dbo].[buscar_producto_por_descripcion_para_formular_en_fraccionamiento_de_productos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[buscar_producto_por_descripcion_para_formular_en_fraccionamiento_de_productos]
@letra VARCHAR(50)
AS BEGIN
SELECT        dbo.Producto1.Id_Producto1, (dbo.Producto1.Descripcion + '- ' + dbo.Presentaciones.Presentacion ) as Descripcion,dbo.Presentaciones_fraccionadas.Stock ,
                        dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada ,dbo.Producto1.Marca, dbo.Tipos_De_productos.Descripcion as Tipo_de_producto  
FROM          
                         dbo.Producto1 INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.Producto1.Id_Producto1 = dbo.Presentaciones_fraccionadas.Id_producto 
                         INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion 
						 inner join dbo.Tipos_De_productos on dbo.Producto1.Id_tipo =dbo.Tipos_De_productos .Id_tipo_de_producto

WHEre dbo.Producto1.Descripcion  LIKE  '%' + @letra+'%' 
END

GO
/****** Object:  StoredProcedure [dbo].[buscar_producto_por_descripcion_para_ventas]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[buscar_producto_por_descripcion_para_ventas]
@letra VARCHAR(50)
AS BEGIN
SELECT        dbo.Producto1.Id_Producto1, dbo.Producto1.Descripcion,
                          dbo.Presentaciones.Presentacion ,dbo.Presentaciones_fraccionadas.Stock ,
                        dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada ,dbo.Producto1.Marca  
						,dbo.Producto1.Imagen 
FROM          
                         dbo.Producto1 INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.Producto1.Id_Producto1 = dbo.Presentaciones_fraccionadas.Id_producto 
                         INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion 

WHEre dbo.Producto1.Descripcion  LIKE  '%' + @letra+'%'
END


GO
/****** Object:  StoredProcedure [dbo].[buscar_producto_por_descripcion_para_ventas_de_servicios]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[buscar_producto_por_descripcion_para_ventas_de_servicios]
@letra VARCHAR(50)
AS BEGIN
SELECT        dbo.Servicio_de_fraccionamiento.Id_detalle_fraccionamiento_lote, dbo.Servicio_de_fraccionamiento.Descripcion, dbo.Presentaciones.Presentacion, 
                         dbo.Presentaciones_fraccionadas_fraccionamiento.Activo, dbo.Presentaciones_fraccionadas_fraccionamiento.Id_presentacion_fraccionamiento
FROM            dbo.Servicio_de_fraccionamiento INNER JOIN
                         dbo.Presentaciones_fraccionadas_fraccionamiento ON 
                         dbo.Servicio_de_fraccionamiento.Id_detalle_fraccionamiento_lote = dbo.Presentaciones_fraccionadas_fraccionamiento.Id_servicio INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas_fraccionamiento.Id_presentacion = dbo.Presentaciones.Id_Presentacion

WHEre dbo.Servicio_de_fraccionamiento.Descripcion  LIKE  '%' + @letra+'%'
END

GO
/****** Object:  StoredProcedure [dbo].[buscar_productos_agregados_A_PEDIDO_DE_VENTA]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_productos_agregados_A_PEDIDO_DE_VENTA]
@letra VARCHAR(50),
@idcliente int
AS BEGIN
SELECT       CONVERT(date, ventas.Fecha_de_pago ) as F_de_Entrega  ,(Serializacion.Id_tipodoc +'-'+ ventas.Numero_de_doc) AS Comprobante ,(dbo.Producto1.Descripcion + '- ' + dbo.Presentaciones.Presentacion+' x'+ Presentaciones.Cantidad_por_presentacion  +Presentaciones .Unidad_de_medida  ) as Producto, (convert (varchar (50),dbo.detalle_venta.Cantidad_mostrada)+ '-'+ dbo.detalle_venta.Unidad_de_medida ) as Cant, 
                         dbo.detalle_venta.preciounitario as Precio_Unit ,dbo.detalle_venta.Total_a_pagar, dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada,DBO.detalle_venta.iddetalle_venta ,dbo.ventas.Estado 
						 ,dbo.Presentaciones_fraccionadas.Stock ,dbo.detalle_venta.cantidad 

FROM            dbo.detalle_venta INNER JOIN
                         dbo.ventas ON dbo.detalle_venta.idventa = dbo.ventas.idventa INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.detalle_venta.Id_presentacionfraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1 INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion     
						 INNER JOIN Serializacion ON Serializacion.Id_serializacion =ventas.Id_series 
						 INNER JOIN clientes ON clientes.idclientev=ventas.idclientev 
where clientes.Nombre + clientes.Ruc+Serializacion.Id_tipodoc +'-'+ ventas.Numero_de_doc   LIKE  '%' + @letra+'%' and dbo.ventas.ACCION ='PEDIDO DE VENTA'and ventas.idclientev=@idcliente
end
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_PRODUCTOS_KARDEX]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[BUSCAR_PRODUCTOS_KARDEX]

@letrab VARCHAR(50)
AS BEGIN
SELECT        Id_Producto1, (Descripcion) AS Descripcion, Imagen, Linea, Usa_inventarios, Stock, Precio_de_compra, Fecha_de_vencimiento, Precio_de_venta, Codigo, Se_vende_a, Impuesto, Stock_minimo, Precio_mayoreo, Sub_total_pv, 
                         Sub_total_pm,Descripcion as Descripcion2
FROM            dbo.Producto1 
                      
  
						 where  (Descripcion+' /Grupo: '+linea +' /Codigo: '+ Codigo) LIKE  '%' + @letrab+'%' and Usa_inventarios ='SI'
end  
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_PRODUCTOS_oka]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[BUSCAR_PRODUCTOS_oka]

@letrab VARCHAR(50)
AS BEGIN
SELECT        Id_Producto1, (Descripcion+' /Grupo: '+linea +' /Codigo: '+ Codigo  ) AS Descripcion, Imagen, Linea, Usa_inventarios, Stock, Precio_de_compra, Fecha_de_vencimiento, Precio_de_venta, Codigo, Se_vende_a, Impuesto, Stock_minimo, Precio_mayoreo, Sub_total_pv, 
                         Sub_total_pm,Descripcion as Descripcion2
FROM            dbo.Producto1 
                      
  
						 where  (Descripcion+' /Grupo: '+linea +' /Codigo: '+ Codigo) LIKE  '%' + @letrab+'%' 
end  
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_PRODUCTOS_oka_por_teclado]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[BUSCAR_PRODUCTOS_oka_por_teclado]

@letrab VARCHAR(50)
AS BEGIN
SELECT        Id_Producto1, (Descripcion+ Codigo  ) AS Descripcion, Imagen, Linea, Usa_inventarios, Stock, Precio_de_compra, Fecha_de_vencimiento, Precio_de_venta, Codigo, Se_vende_a, Impuesto, Stock_minimo, Precio_mayoreo, Sub_total_pv, 
                         Sub_total_pm
FROM            dbo.Producto1 
                      
  
						 where  (Descripcion+Codigo ) LIKE  '%' + @letrab+'%' 
end  
GO
/****** Object:  StoredProcedure [dbo].[buscar_proveedor_POR_nombre]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_proveedor_POR_nombre]

@letra VARCHAR(50)
AS BEGIN
SELECT   Nombre as Cliente , idclientev 
    
FROM   clientes        
                        
WHEre Nombre  LIKE  '%' + @letra+'%' and Proveedor ='SI'
END


GO
/****** Object:  StoredProcedure [dbo].[buscar_PROVEEDOR_POR_nombre_PARA_VENTAS_todos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_PROVEEDOR_POR_nombre_PARA_VENTAS_todos]

@letra VARCHAR(50)
AS BEGIN
SELECT        DBO.clientes.Nombre ,DBO.clientes.idclientev  ,movil  
FROM         clientes
WHEre Nombre+movil   LIKE  '%' + @letra+'%' and Proveedor ='SI'  ORDER BY idclientev desc
END
GO
/****** Object:  StoredProcedure [dbo].[buscar_rechazo_x_vendedor_y_fecha]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_rechazo_x_vendedor_y_fecha]
@idvendedor as int,
@fecha as date

as
SELECT       sum((Presentaciones_fraccionadas.Precio_de_venta_por_presentacion/Cantidad_por_unidad_de_medida )*KARDEX.Cantidad   ) as TOTAL
						
FROM            KARDEX
inner join Presentaciones_fraccionadas on Presentaciones_fraccionadas.Id_presentacionfraccionada=
KARDEX.Id_presentacion_fraccionada
inner join Unidad_de_medida  on Unidad_de_medida.Id_unidad_de_medida=Presentaciones_fraccionadas.Id_unidad     
where Id_usuario =@idvendedor AND CONVERT(DATE,Fecha  )=@fecha and KARDEX.Motivo ='RECHAZO DIARIO' 
GO
/****** Object:  StoredProcedure [dbo].[buscar_Tipo_de_documentos_para_insertar_en_ventas]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_Tipo_de_documentos_para_insertar_en_ventas]
@letra VARCHAR(50)
AS BEGIN

SELECT        Serializacion.Id_tipodoc  AS COMPROBANTE , Serializacion.Id_tipodoc  ,dbo.Serializacion.Serie ,dbo.Serializacion.numeroinicio , dbo.Serializacion.numerofin+1 ,dbo.Serializacion.Id_serializacion ,(dbo.Serializacion.Serie  +' - '+ dbo.Serializacion.numeroinicio + dbo.Serializacion.numerofin) as serie_completa,Serializacion.Id_tipodoc,Serializacion.Id_tipodoc 
FROM            dbo.Serializacion 
 
 WHEre Serializacion.Id_tipodoc LIKE  '%' + @letra+'%' and dbo.Serializacion .Destino  ='VENTAS'
 end
GO
/****** Object:  StoredProcedure [dbo].[buscar_und]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_und]

@letra VARCHAR(50)
AS BEGIN
SELECT  Cantidad_por_unidad_de_medida AS CANT ,(Unidad_de_medida + ' ('+Cantidad_por_unidad_de_medida+ 'UND'+')') AS Unidad_de_medida,Cantidad_por_unidad_de_medida 
 ,Unidad_de_medida AS Unidad, Unidad_de_medida.Id_unidad_de_medida 
FROM           Unidad_de_medida  
WHEre (Unidad_de_medida + ' ('+Cantidad_por_unidad_de_medida+ 'UND'+')') LIKE  '%' + @letra+'%' 
END

GO
/****** Object:  StoredProcedure [dbo].[buscar_USUARIO_por_DNI]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[buscar_USUARIO_por_nombre]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[buscar_USUARIO_por_nombre]
@letra VARCHAR(50),
@pas varchar(50)
AS BEGIN
SELECT        idUsuario, Nombre_y_Apelllidos,Password 
FROM            dbo.USUARIO2						 
WHEre Nombre_y_Apelllidos  LIKE  '%' + @letra+'%' AND Password=@pas
END

GO
/****** Object:  StoredProcedure [dbo].[buscar_ventas_a_credito_con_productos_x_vendedor_y_fecha]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_ventas_a_credito_con_productos_x_vendedor_y_fecha]
@idvendedor as int,
@fecha as date

as
SELECT       sum(ventas.Monto_total) as TOTAL
						
FROM            ventas
where Id_usuario =@idvendedor AND CONVERT(DATE,fecha_venta)=@fecha AND Estado='DEUDA' AND ACCION='VENTA'
GO
/****** Object:  StoredProcedure [dbo].[buscar_ventas_por_fecha]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_ventas_por_fecha]


@fi  date,
@ff date,
@usuario varchar(50)
AS BEGIN
SELECT        idventa , fecha_venta ,Comprobante +Numero_de_doc  ,Monto_total ,USUARIO2.Nombre_y_Apelllidos ,ventas.Pago_con
FROM            dbo.ventas 	inner join USUARIO2  on USUARIO2 .idUsuario  =ventas.Id_usuario  					 
WHEre  convert(date,ventas.fecha_venta) >=@fi and convert(date,ventas.fecha_venta)  <=@ff and USUARIO2.Nombre_y_Apelllidos =@usuario
END
GO
/****** Object:  StoredProcedure [dbo].[buscar_ventas_por_numero_de_comprobante]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_ventas_por_numero_de_comprobante]


@letra VARCHAR(50)
AS BEGIN
SELECT        idventa , fecha_venta ,Comprobante +' '+Numero_de_doc  ,Monto_total ,USUARIO2.Nombre_y_Apelllidos ,ventas.Pago_con
FROM            dbo.ventas 	inner join USUARIO2  on USUARIO2 .idUsuario  =ventas.Id_usuario  					 
WHEre Comprobante +Numero_de_doc    LIKE  '%' + @letra+'%' and ventas.Monto_total >0
END
GO
/****** Object:  StoredProcedure [dbo].[buscar_ventas_por_numero_usuario]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_ventas_por_numero_usuario]


@letra VARCHAR(50)
AS BEGIN
SELECT        idventa , fecha_venta ,Comprobante +Numero_de_doc  ,Monto_total ,USUARIO2.Nombre_y_Apelllidos ,ventas.Pago_con
FROM            dbo.ventas 	inner join USUARIO2  on USUARIO2 .idUsuario  =ventas.Id_usuario  					 
WHEre USUARIO2.Nombre_y_Apelllidos    LIKE  '%' + @letra+'%'
END
GO
/****** Object:  StoredProcedure [dbo].[buscar_ventas_por_numero_usuario_FILTRADO]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_ventas_por_numero_usuario_FILTRADO]


@letra VARCHAR(50)
AS 
SELECT        idventa , fecha_venta ,Comprobante +Numero_de_doc  ,Monto_total ,USUARIO2.Nombre_y_Apelllidos ,ventas.Pago_con
FROM            dbo.ventas 	inner join USUARIO2  on USUARIO2 .idUsuario  =ventas.Id_usuario  					 
WHEre USUARIO2.Nombre_y_Apelllidos =@letra   

GO
/****** Object:  StoredProcedure [dbo].[buscar_ventas_por_usuario_sin_repeticion]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[buscar_ventas_por_usuario_sin_repeticion]

AS
SELECT USUARIO2.idUsuario ,USUARIO2.Nombre_y_Apelllidos,VENTAS.Tipo_de_pago ,ventas.Fecha_de_pago 
FROM            dbo.ventas 	inner join USUARIO2  on USUARIO2 .idUsuario  =ventas.Id_usuario  					 




GO
/****** Object:  StoredProcedure [dbo].[BuscarProducto]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- ALTER date: <ALTER Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BuscarProducto] 
	-- Add the parameters for the stored procedure here
	@IdProducto int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM Producto
	WHERE IdProducto=@IdProducto
END







GO
/****** Object:  StoredProcedure [dbo].[Cambiar_Contraseña]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Cambiar_Contraseña]
@login varchar(50),
@Password varchar(50),
@NuevoPassword varchar(50)
as
update USUARIO2 set Password = @NuevoPassword
where Login = @login and Password = @Password





GO
/****** Object:  StoredProcedure [dbo].[canjear_comprobantes_COMPRAS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[canjear_comprobantes_COMPRAS]
@idventa as integer,
@fecha_venta as varchar(50),
@num_documento as varchar (50),
@idserie as int






as
update Compra  set Fecha_compra=@fecha_venta,N_Documento =@num_documento ,Id_series =@idserie 

where Cod_compra =@idventa



GO
/****** Object:  StoredProcedure [dbo].[canjear_comprobantes_ventas]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[CERRAR_CAJA]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[CERRAR_CAJA]
@idcaja as integer,
@fechafin datetime,
@fechacierre datetime


		
as 
update MOVIMIENTOCAJACIERRE set 
Estado ='CAJA CERRADA'
where Id_caja =@idcaja AND Estado='CAJA APERTURADA'




GO
/****** Object:  StoredProcedure [dbo].[cerrar_caja_diaria]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[cerrar_caja_diaria]

	 @fechafin datetime,
	 @fechacierre datetime, 
	  @ingresos numeric(18,2), 
    @egresos numeric(18,2),
	
	@saldo numeric(18,2),
	 @totalcaluclado numeric(18,2),
	  @totalreal real, 
	 @estado as varchar(50),
	 @diferencia numeric(18,2)
as BEGIN
if EXISTS (SELECT idcierrecaja   FROM MOVIMIENTOCAJACIERRE   where idcierrecaja   = idcierrecaja  and Estado='CAJA CERRADA' )
RAISERROR ('YA SE CERRO CAJA DIARIA; COORDINE CON EL ADMINISTRADOR A CARGO', 16,1)
else
BEGIN 

update MOVIMIENTOCAJACIERRE  set 
fechafin=@fechafin ,
fechacierre=@fechacierre,
ingresos=@ingresos,
egresos=@egresos  ,
Saldo_queda_en_caja =@saldo  ,
Total_calculado =@totalcaluclado  ,
Total_real =@totalreal  ,
Estado=@estado, 
Diferencia=@diferencia 
where idcierrecaja  =idcierrecaja


select*from MOVIMIENTOCAJACIERRE 
END
END



GO
/****** Object:  StoredProcedure [dbo].[cerrar_caja_PADRE]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[cerrar_caja_PADRE]
	 @Id_cierre_de_caja INT,
	@Fecha_de_cierre AS DATEtime ,
	@idusuario as int,

	@ingresos numeric(18,2), 
    @egresos numeric(18,2),
	
	@saldo numeric(18,2),
	 @totalcaluclado numeric(18,2),
	  @totalreal real, 	
	 @diferencia numeric(18,2)
	
as 
update CIERRE_DE_CAJA_PADRE  set 

Fecha_de_cierre=@Fecha_de_cierre ,
Estado='DIA CERRADO',
Id_usuario=@idusuario ,
Ingresos=@ingresos,
Egresos=@egresos  ,
Saldo_que_queda_en_caja =@saldo  ,
Total_calculado =@totalcaluclado  ,
Total_real =@totalreal  ,

Diferencia=@diferencia 

where Id_cierre_de_caja  =@Id_cierre_de_caja




GO
/****** Object:  StoredProcedure [dbo].[cerrar_caja_por_turno]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[cerrar_caja_por_turno]
@idcierrecaja as int,
	 @fechafin datetime,
	 @fechacierre datetime, 
	  @ingresos numeric(18,2), 
    @egresos numeric(18,2),	
	@saldo numeric(18,2),
	 @totalcaluclado numeric,
	  @totalreal real, 
	 @estado as varchar(50),
	 @diferencia numeric(18,2),
	 @idusuario as int
as 
update MOVIMIENTOCAJACIERRE  set 
fechafin=@fechafin ,
fechacierre=@fechacierre,
ingresos=@ingresos,
egresos=@egresos  ,
Saldo_queda_en_caja =@saldo  ,
Total_calculado =@totalcaluclado  ,
Total_real =@totalreal  ,
Estado=@estado, 
Diferencia=@diferencia 
where idcierrecaja  =@idcierrecaja






GO
/****** Object:  StoredProcedure [dbo].[cerrar_caja_todos_los_turno_pordia]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[cobrar_CONTROL_DE_COBROS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[cobrar_CONTROL_DE_COBROS]
@Id_venta as int,

@Monto numeric(18,2)

as 
update CONTROL_DE_COBROS  set Monto=Monto - @Monto 
where Id_venta    =@Id_venta  

GO
/****** Object:  StoredProcedure [dbo].[cobrar_CONTROL_DE_COBROSX]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[cobrar_CONTROL_DE_COBROSX]
@Id_venta as int,

@Monto numeric(18,2)

as 
update CONTROL_DE_COBROSX  set Saldo=Saldo - @Monto 
where Id_control_de_cobros    =@Id_venta  

GO
/****** Object:  StoredProcedure [dbo].[cobrar_CONTROL_DE_pagos_a_proveedores]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[cobrar_CONTROL_DE_pagos_a_proveedores]
@Id_compra as int,

@Monto numeric(18,2)

as 
update CONTROL_DE_PAGOS_A_PROVEEDORES  set Monto=Monto - @Monto 
where Id_compra     =@Id_compra  

GO
/****** Object:  StoredProcedure [dbo].[contar_detalles_de_venta_en_espera]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[contar_detalles_de_venta_en_espera]
@id_producto int
as
BEGIN
SET NOCOUNT ON;
SELECT DISTINCT      detalle_venta .Stock 
FROM            dbo.detalle_venta INNER JOIN
                         dbo.ventas ON dbo.detalle_venta.idventa = dbo.ventas.idventa 
where  ventas.Monto_total  =0 and detalle_venta.Id_producto =@id_producto
end
GO
/****** Object:  StoredProcedure [dbo].[contar_productos_en_espera]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[contar_productos_en_espera]
 as
 SELECT      count(detalle_venta.Id_producto  ) as id_producto
FROM            dbo.ventas inner join detalle_venta on detalle_venta.idventa =detalle_venta.idventa  
             
where  
 ventas.Estado='EN ESPERA'or  ventas.Estado='SIN CONFIRMAR'
GO
/****** Object:  StoredProcedure [dbo].[contar_ventas_en_espera]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[contar_ventas_en_espera]

AS 

 SELECT      ventas.idventa , count(detalle_venta.Id_producto  ) as id_producto,Comprobante ,ventas.fecha_venta 
FROM            dbo.ventas inner join detalle_venta on detalle_venta.idventa =detalle_venta.idventa  
     
where  
 ventas.Estado='EN ESPERA'or  ventas.Estado='SIN CONFIRMAR'

 group by ventas.idventa,Comprobante ,ventas.fecha_venta

GO
/****** Object:  StoredProcedure [dbo].[DESACTIVAR_PRESENTACIONES_FRACCIONADAS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DESACTIVAR_PRESENTACIONES_FRACCIONADAS]
@idPresentaciones_fraccionadas integer

as 
update Presentaciones_fraccionadas set Activo = 'NO'
where Id_presentacionfraccionada  = @idPresentaciones_fraccionadas AND Presentaciones_fraccionadas.Activo ='SI'


GO
/****** Object:  StoredProcedure [dbo].[disminuir_saldo_de_caja]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[disminuir_saldo_de_caja]
@Id_cierre_de_caja as integer,
@Saldo_que_queda_en_caja as numeric(18,2)


as

update CIERRE_DE_CAJA_PADRE set  
Saldo_que_queda_en_caja=Saldo_que_queda_en_caja-@Saldo_que_queda_en_caja
where Id_cierre_de_caja=@Id_cierre_de_caja 





GO
/****** Object:  StoredProcedure [dbo].[DISMINUIR_saldo_de_cuentas_bancarias]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DISMINUIR_saldo_de_cuentas_bancarias]
@Id_cuenta_bancaria as integer,
@monto as numeric(18,2),
@tipodemovimiento as varchar(50)
as

update Cuentas_corrientes_bancos_datos_generales set  Saldo =Saldo-@monto 
where Id_cuenta_bancaria =@Id_cuenta_bancaria AND @tipodemovimiento ='REGISTRO DE EGRESO'

GO
/****** Object:  StoredProcedure [dbo].[DISMINUIR_saldo_de_cuentas_bancarias_POR_ELIMINACION]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DISMINUIR_saldo_de_cuentas_bancarias_POR_ELIMINACION]
@Id_cuenta_bancaria as integer,
@monto as numeric(18,2)
as

update Cuentas_corrientes_bancos_datos_generales set  Saldo =Saldo-@monto 
where Id_cuenta_bancaria =@Id_cuenta_bancaria 

GO
/****** Object:  StoredProcedure [dbo].[disminuir_stock]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[disminuir_stock]
@Id_presentacionfraccionada as varchar(50),
@cantidad as decimal (18,2)

as
update Producto1  set Stock=Stock-@cantidad where Id_Producto1  =@Id_presentacionfraccionada AND Usa_inventarios ='SI'
and Stock >= @cantidad 


GO
/****** Object:  StoredProcedure [dbo].[disminuir_stock_en_detalle_de_venta]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[disminuir_stock_en_detalle_de_venta]
@Id_presentacionfraccionada as varchar(50),
@cantidad as decimal (18,2)

as
update detalle_venta   set Stock=Stock-@cantidad where Id_producto   =@Id_presentacionfraccionada AND Stock  <>'Ilimitado'



GO
/****** Object:  StoredProcedure [dbo].[disminuirmontocuota]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[disminuirmontocuota]
@Id_control_de_cobros as integer,
@montopagado as decimal(18,2)

as 
update  CONTROL_DE_COBROS   set Monto  =Monto -@montopagado 
where Id_control_de_cobros =@Id_control_de_cobros 

GO
/****** Object:  StoredProcedure [dbo].[disminuirSaldocliente]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[disminuirSaldocliente]
@Id_cliente as integer,
@montopagado as numeric(18,2)

as 
update  clientes    set Saldo   =Saldo  -@montopagado 
where idclientev  =@Id_cliente 

GO
/****** Object:  StoredProcedure [dbo].[editar_alimentacion_de_stock_completo_de_presentaciones_fraccionadas]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_alimentacion_de_stock_completo_de_presentaciones_fraccionadas]

 @Id_presentacionfraccionada int ,       
 @Fecha_de_produccion AS DATE,
@Fecha_de_vencimiento AS DATE,
@Numero_de_lote as varchar(50),
@Observacion as varchar(50),
@Fecha_de_observacion as datetime

as

update Almacen_producto_terminados set 
Fecha_de_produccion =@Fecha_de_produccion,
Fecha_de_vencimiento =@Fecha_de_vencimiento ,
Numero_de_lote=@Numero_de_lote ,
Observacion=@Observacion,
Fecha_de_observacion=@Fecha_de_observacion

where Id_presentacionfraccionada  =@Id_presentacionfraccionada   




GO
/****** Object:  StoredProcedure [dbo].[editar_almacen]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[editar_almacen]
@idalmacen as integer,
@Destino_Almacen varchar(50),
           @Direccion varchar(50)
           		
as 
update Almacen_padre_prod_terminado set 
Descripcion=@Destino_Almacen
,Direccion=@Direccion 
where Id_almacen_padre_prod_terminado   =@idalmacen 



GO
/****** Object:  StoredProcedure [dbo].[editar_almacenes]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_almacenes]
@idalmacen as int,
@Destino_Almacen varchar(50),
@Direccion varchar(50)

as 
update Almacen_padre_prod_terminado  set Descripcion  =@Destino_Almacen ,Direccion =@Direccion 
where Id_almacen_padre_prod_terminado   =@idalmacen    





GO
/****** Object:  StoredProcedure [dbo].[editar_AREAS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_AREAS]
@Id_Areas int,
@Area varchar(50),
@Encargado varchar(50)
as 
update AREAS set Area=@Area,
Encargado=@Encargado
where Id_Areas=@Id_Areas





GO
/****** Object:  StoredProcedure [dbo].[editar_ASISTENCIAS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_ASISTENCIAS]
@Id_personal as int,
@Fecha_salida DATETIME,
@Horas NUMERIC(18,2)
as 
update ASISTENCIAS set 
Fecha_salida =@Fecha_salida ,
Horas =@Horas ,
Estado='SALIDA'
where Id_personal   =@Id_personal  AND Estado='ENTRADA' 




GO
/****** Object:  StoredProcedure [dbo].[editar_BANCOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_BANCOS]
@Id_nombre_de_bancos as integer,
@Descripcion varchar(MAX)	
       
           		
as 
update BANCOS set 
Descripcion=@Descripcion

where Id_nombre_de_bancos  =@Id_nombre_de_bancos


GO
/****** Object:  StoredProcedure [dbo].[editar_caja]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_caja]
@idcaja integer,
@descripcion varchar(50)

        
           		
as 
update Caja set 
Descripcion  =@descripcion 

where Id_Caja    =@idcaja    


GO
/****** Object:  StoredProcedure [dbo].[editar_caja_asignada_a_pc]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[editar_categoria]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_categoria]
@idcategoria integer,
@nombrecategoria varchar(50)
as 
update categoria set nombrecategoria = @nombrecategoria 
where idcategoria = @idcategoria 






GO
/****** Object:  StoredProcedure [dbo].[editar_centro]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[editar_centro]
@idcentro as integer,
@Centro_de_produccion varchar(50),
           @Direccion varchar(50)
           		
as 
update Centros_de_produccion set 
Centro_de_produccion=@Centro_de_produccion 
,Direccion=@Direccion 
where Id_Centro_de_produccion  =@idcentro  



GO
/****** Object:  StoredProcedure [dbo].[editar_cliente]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_cliente]
@idcliente as integer,
@Nombre varchar(MAX),
           @Direccion_para_factura varchar(MAX),
            @Ruc varchar(MAX),                      
            @movil varchar(50)
		
as 
update clientes set 
Nombre =@Nombre ,
          Direccion_para_factura = @Direccion_para_factura ,
           Ruc = @Ruc ,
          
          movil  = @movil 
where idclientev =@idcliente 




GO
/****** Object:  StoredProcedure [dbo].[editar_COBERTURA]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_COBERTURA]
@Id_covertura as integer,
@Nombre as VARCHAR(MAX)

as

update COBERTURA set  Nombre=@Nombre
where Id_covertura=@Id_covertura


GO
/****** Object:  StoredProcedure [dbo].[editar_CONCEPTO]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_CONCEPTO]
@Id_concepto as int,
@Descripcion varchar(50)
as 
update CONCEPTOS set 

Descripcion=@Descripcion 

where Id_concepto    =@Id_concepto


GO
/****** Object:  StoredProcedure [dbo].[editar_CONDICIONES_DE_VENTA_FRACCIONAMIENTO]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_CONDICIONES_DE_VENTA_FRACCIONAMIENTO]

           @Descripcion varchar(50),
		   @idcondicion as int
as

update CONDICIONES_DE_VENTA_FRACCIONAMIENTO set  Descripcion=@Descripcion  
where Id_condiciones =@idcondicion   




GO
/****** Object:  StoredProcedure [dbo].[editar_Control_de_asistencia_ordende_de_produccion]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_Control_de_asistencia_ordende_de_produccion]
@IdControl_de_OrdenesProd int,
@Id_Orden_Produccion int,
@Id_Personal int,
@Fecha_de_Entrada datetime,
@Fecha_de_Salida datetime



as 
update Control_de_asistencia_ordende_de_produccion set Id_Orden_Produccion=@IdControl_de_OrdenesProd,Id_Personal=@Id_Personal,
Fecha_de_Entrada=@Fecha_de_Entrada,Fecha_de_Salida=@Fecha_de_Salida

where IdControl_de_OrdenesProduccion=@IdControl_de_OrdenesProd




GO
/****** Object:  StoredProcedure [dbo].[editar_CONTROL_DE_COBROS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_CONTROL_DE_COBROS]
@Id_cliente as int,

@Monto numeric(18,2),
@Concepto as varchar(max)
as 
update CONTROL_DE_COBROSX  set Monto=Monto + @Monto ,Concepto=@Concepto
where Id_cliente    =@Id_cliente  


GO
/****** Object:  StoredProcedure [dbo].[editar_CONTROL_DE_COBROS_POR_ELIMINACION_DE_VENTA]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[editar_CONTROL_DE_pagos_a_proveedores]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_CONTROL_DE_pagos_a_proveedores]
@Id_cliente as int,

@Monto numeric(18,2),
@Concepto as varchar(max)
as 
update CONTROL_DE_PAGOS_A_PROVEEDORESX  set Monto=Monto + @Monto ,Concepto =@Concepto
where Id_proveedor     =@Id_cliente  

GO
/****** Object:  StoredProcedure [dbo].[editar_Designacion_Personal_Para_ordenesdeproduccion]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_Designacion_Personal_Para_ordenesdeproduccion]
@Id_Personal_para_ordenesProduccion int,
@Id_Orden_de_Produccion int,
@Id_Personal int
as 
update Designacion_Personal_Para_ordenesdeproduccion set Id_Orden_de_Produccion=@Id_Orden_de_Produccion,Id_Personal=@Id_Personal
where Id_Personal_para_ordenesProduccion=@Id_Personal_para_ordenesProduccion





GO
/****** Object:  StoredProcedure [dbo].[editar_detalle_venta_restar]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_detalle_venta_restar]
@Descripcion  varchar(50),
@cantidad as numeric(18, 2),
@Cantidad_mostrada  numeric(18, 2) 
        
           		
as 


 		   BEGIN
if EXISTS (SELECT cantidad ,Id_producto    FROM detalle_venta  where detalle_venta .Descripcion   = @Descripcion  AND cantidad <=0 )

delete from detalle_venta where detalle_venta .Descripcion  =@Descripcion 
else
BEGIN
update detalle_venta set 
cantidad    =cantidad -@cantidad,   
Cantidad_mostrada=Cantidad_mostrada-@Cantidad_mostrada
where detalle_venta .Descripcion      =@Descripcion 
end
end  
GO
/****** Object:  StoredProcedure [dbo].[editar_detalle_venta_restar_en_Historial]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[editar_detalle_venta_restar_en_Historial]
@Descripcion  varchar(50),
@cantidad as numeric(18, 2),
@Cantidad_mostrada  numeric(18, 2) 
      ,  @idventa int
           		
as 


 		   BEGIN
if EXISTS (SELECT cantidad ,Id_producto    FROM detalle_venta  where detalle_venta .Descripcion   = @Descripcion  AND cantidad <=0 )

delete from detalle_venta where detalle_venta .Descripcion  =@Descripcion 
else
BEGIN
update detalle_venta set 
cantidad    =cantidad -@cantidad,   
Cantidad_mostrada=Cantidad_mostrada-@Cantidad_mostrada
where detalle_venta .Descripcion      =@Descripcion and detalle_venta.idventa=@idventa 
end
end  
GO
/****** Object:  StoredProcedure [dbo].[editar_detalle_venta_sumar]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_detalle_venta_sumar]
@Descripcion  varchar(50),
@cantidad as numeric(18, 2),
@Cantidad_mostrada  numeric(18, 2)       
           		
as 



update detalle_venta set 
cantidad    =cantidad +@cantidad  , 
Cantidad_mostrada=Cantidad_mostrada+@Cantidad_mostrada
where  detalle_venta .Descripcion   =@Descripcion 
 
GO
/****** Object:  StoredProcedure [dbo].[editar_dinero_caja_inicial]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_dinero_caja_inicial]
@Id_caja as integer,
@saldo numeric(18,2)


as
update MOVIMIENTOCAJACIERRE  set  Saldo_queda_en_caja =@saldo
where Id_caja =@Id_caja AND Estado ='CAJA APERTURADA'




GO
/****** Object:  StoredProcedure [dbo].[editar_DOCUMENTOS_QUE_SE_ENTREGAN_FRACCIONAMIENTO_COTIZACION]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_DOCUMENTOS_QUE_SE_ENTREGAN_FRACCIONAMIENTO_COTIZACION]
@Id_documentos_que_se_entregan_fraccionamiento as integer,
@DESCRIPCION AS VARCHAR(MAX)

           		
as 
update DOCUMENTOS_QUE_SE_ENTREGAN_FRACCIONAMIENTO_COTIZACION set 
Descripcion=@DESCRIPCION 

where Id_documentos_que_se_entregan_fraccionamiento  =@Id_documentos_que_se_entregan_fraccionamiento  




GO
/****** Object:  StoredProcedure [dbo].[editar_Empresa]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[editar_Empresa]
 @Id_empresa int,
@Nombre_Empresa  varchar(50),

@logo as image,
@Impuesto varchar(50),
@Porcentaje_impuesto numeric(18,2),
@Moneda varchar(50),
@Trabajas_con_impuestos VARCHAR(50),
@Modo_de_busqueda VARCHAR(50),

@Carpeta_para_copias_de_seguridad varchar(max),
@Correo_para_envio_de_reportes varchar(50)

as

update  EMPRESA set Nombre_Empresa=@Nombre_Empresa,Logo=@logo ,Impuesto=@Impuesto ,
Porcentaje_impuesto=@Porcentaje_impuesto,Moneda=@Moneda,Trabajas_con_impuestos=@Trabajas_con_impuestos
,Modo_de_busqueda=@Modo_de_busqueda 
,Carpeta_para_copias_de_seguridad =@Carpeta_para_copias_de_seguridad ,Correo_para_envio_de_reportes =@Correo_para_envio_de_reportes 
where Id_empresa=@Id_empresa 

GO
/****** Object:  StoredProcedure [dbo].[editar_Empresa_copia_de_seguridad]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[editar_Empresa_copia_de_seguridad]
 @Ultima_fecha_de_copia_de_seguridad varchar(50),
 @Carpeta_para_copias_de_seguridad varchar(max)
as

update  EMPRESA set Ultima_fecha_de_copia_de_seguridad =@Ultima_fecha_de_copia_de_seguridad ,
Carpeta_para_copias_de_seguridad =@Carpeta_para_copias_de_seguridad 

GO
/****** Object:  StoredProcedure [dbo].[editar_Equipos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_Equipos]
@Id_Equipo int,
@Id_Proceso int,
@Equipo varchar(50),
@Monto_de_Devaluacion decimal(18, 2)

as 
update Equipos set Id_Proceso=@Id_Proceso, Equipo=@Equipo,Monto_de_Devaluacion=@Monto_de_Devaluacion


where @Id_Equipo=@Id_Equipo




GO
/****** Object:  StoredProcedure [dbo].[editar_FORMATO_TICKET]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_FORMATO_TICKET]
      @Empresa_Ruc varchar(max),
           @Direccion varchar(max),
           @Provincia varchar(max),
           @Moneda_string varchar(max),
           @Agradecimiento varchar(max),
           @pagina_Web_Facebook varchar(max),
           @Extra varchar(max)   
    as
    update Ticket set  
	Empresa_Ruc=@Empresa_Ruc ,
          Direccion =@Direccion ,    
           Provincia=@Provincia ,
           Moneda_string=@Moneda_string ,
          Agradecimiento  =@Agradecimiento ,
          pagina_Web_Facebook = @pagina_Web_Facebook ,
         Extra =  @Extra  
GO
/****** Object:  StoredProcedure [dbo].[editar_gasto]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[editar_GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS]
@Id_grupo_concepto_gasto as int,
@Descripcion varchar(MAX),        
            @Gasto as VARCHAR(50) 
       
           		
as 
update GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS set 
Descripcion=@Descripcion ,        
          Gasto  = @Gasto 

where Id_grupo_concepto_gasto  =@Id_grupo_concepto_gasto


GO
/****** Object:  StoredProcedure [dbo].[editar_IGV_Empresa]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[editar_IGV_Empresa]

@Impuesto varchar(50),
@Porcentaje_impuesto numeric(18,0),

@Trabajas_con_impuestos VARCHAR(50)
as

update  EMPRESA set Impuesto=@Impuesto ,
Porcentaje_impuesto=@Porcentaje_impuesto,Trabajas_con_impuestos=@Trabajas_con_impuestos



GO
/****** Object:  StoredProcedure [dbo].[editar_ingreso]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_ingreso]
@idgasto as int,
@fecha datetime,

@observacion varchar(500),
@Nro_Comprobante varchar(50),

@Tipo_de_Comprobante varchar(50),
@importe decimal(18,2),
@estado as varchar(50),
@Id_concepto INT
as 
update INGRESOSVARIOS  set Estado=@estado ,Nro_Comprobante=@Nro_Comprobante,Tipo_de_Comprobante=@Tipo_de_Comprobante,Fecha_del_Gasto=@fecha  ,Id_concepto =@Id_concepto  ,Importe =@importe  ,Observacion =@observacion  
where Idgasto  =@idgasto  




GO
/****** Object:  StoredProcedure [dbo].[editar_lineas]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_lineas]
@Idline as integer,
@Linea varchar(50)
        
           		
as 
update linea set 
Linea =@Linea  

where Idline   =@Idline   


GO
/****** Object:  StoredProcedure [dbo].[editar_logo_de_EMPRESA]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_logo_de_EMPRESA]
@logo image
as 

update EMPRESA  set  Logo   =@logo            




GO
/****** Object:  StoredProcedure [dbo].[editar_materiales]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_materiales]
@idmateriales as int,
  @Descripcion varchar(50),
           @id_Presentacion int,
       @id_unidad_de_medida int,
           @Precio_Venta_Al_Publico numeric(18, 0),
           @Precio_Venta_AlPormayor numeric(18, 0),      
           @Stock numeric(18,2),  
           @Fecha_de_vencimiento date,       
           @Id_destino_almacen int,
		   @produccion as varchar(50),
		   @vender varchar(50),
		   @comprar varchar(50),
		   @Precio_de_compra as numeric(18, 0),
		   @Insumo as varchar(50),
		   @Materia_prima as varchar(50),
		   @Id_proveedor AS INT,
		@suministro as varchar(50),
		@estado as varchar(50)
		  
		  
as 
update materiales  set   Descripcion =@Descripcion ,
           Id_presentacion =@id_Presentacion ,
       Id_Unidad_de_medida =@id_unidad_de_medida ,
           Precio_Venta_Al_Publico =@Precio_Venta_Al_Publico ,
           Precio_Venta_AlPormayor =@Precio_Venta_AlPormayor ,
    
  
        
          Stock  =@Stock ,
  
           Fecha_de_vencimiento =@Fecha_de_vencimiento ,
        
           Id_destino_almacen =@Id_destino_almacen ,
		   Produccion =@produccion ,
		  Vender = @vender ,
		   Comprar =@comprar ,
		  Precio_de_compra = @Precio_de_compra,
		  Insumo = @Insumo ,
		   Materia_prima =@Materia_prima ,
		 Id_proveedor = @Id_proveedor,
		Suministro =@suministro ,
		Estado=Estado 
where Id_materiales =@idmateriales 






GO
/****** Object:  StoredProcedure [dbo].[editar_nombre_de_EMPRESA]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_nombre_de_EMPRESA]
@nombre varchar(50),
@moneda varchar(50)
as 

update EMPRESA   set  Nombre_Empresa  =@nombre  ,Moneda=@moneda  
GO
/****** Object:  StoredProcedure [dbo].[editar_nombre_de_EMPRESA_con_imagen]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editar_nombre_de_EMPRESA_con_imagen]
@nombre varchar(50),

@Imagen image
as 

update EMPRESA   set  Nombre_Empresa  =@nombre  ,Logo =@Imagen 
GO
/****** Object:  StoredProcedure [dbo].[editar_nombreservicio]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  procedure [dbo].[editar_nombreservicio]
@Id_nombreServicio integer,
@Servicio varchar(50),
@Avisar_antes_de varchar(50)
as 
update nombredeservicio set Servicio=@Servicio , Avisar_antes_de=@Avisar_antes_de 
where Id_nombreServicio=@Id_nombreServicio




GO
/****** Object:  StoredProcedure [dbo].[editar_Orden_de_Produccion]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_Orden_de_Produccion]
@IdOrden int,
@IdProducto1 int,
@Fecha_Planificada datetime,
@Cantidad numeric(18, 2),
@Estado varchar(50)

as 
update Orden_de_Produccion set IdProducto1=@IdProducto1,
Fecha_Planificada=@Fecha_Planificada,Cantidad=@Cantidad,Estado=@Estado


where IdOrden=@IdOrden




GO
/****** Object:  StoredProcedure [dbo].[editar_permisos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_permisos]
   	@Id_Usuario  int ,
	@ventas int ,
	@aplicar_descuentos int ,
	@Devoluciones int ,
	@cobros int ,
	@Pagar int ,
	@clientes_proveedores int,
	@productos int,
	@invetarios_kardex int,
	@configuraciones int,
	@usuarios int,
	@reportes int
AS
update permisos  set 
ventas=@ventas,
	aplicar_descuentos =@aplicar_descuentos  ,
	Devoluciones =@Devoluciones  ,
	cobros =@cobros  ,
	Pagar =@Pagar  ,
	clientes_proveedores =@clientes_proveedores ,
	productos =@productos ,
	invetarios_kardex =@invetarios_kardex ,
	configuraciones = @configuraciones ,
	usuarios=@usuarios ,
	reportes=@reportes 


where Id_Usuario   =@Id_Usuario 

GO
/****** Object:  StoredProcedure [dbo].[editar_personal]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_personal]
@idpersonal as int,
@Nombres varchar(50),
@Celular varchar(50),
@Email varchar(50),
@Direccion varchar(50),
@Area varchar(50),
@Cargo varchar(50)
as 
update Personal set 
Nombres =@Nombres ,
Celular =@Celular ,
Email =@Email ,
Direccion =@Direccion ,
Area =@Area ,
Cargo =@Cargo 
where Id_personal   =@idpersonal   




GO
/****** Object:  StoredProcedure [dbo].[editar_PRECIODE_COMPRA_de_presentaciones_fraccionadas]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_PRECIODE_COMPRA_de_presentaciones_fraccionadas]

 @Id_presentacionfraccionada int,
 @precio_de_compra as numeric(18,6),
 @precio_de_compra_mostrado as numeric(18,2)        


as

update Presentaciones_fraccionadas set Precio_de_compra =@precio_de_compra ,Precio_de_compra_mostrado=@precio_de_compra_mostrado 
where Id_presentacionfraccionada  =@Id_presentacionfraccionada   


GO
/****** Object:  StoredProcedure [dbo].[editar_precios]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_precios]
 @Zona varchar(50),
           @Precio numeric(18,1),
		   @Id_precio as int
		   , @Id_unidades as int
as

update Precios set  Zona=@Zona ,Precio=@Precio ,Id_unidades  =@Id_unidades 
where Id_precios =@Id_precio  




GO
/****** Object:  StoredProcedure [dbo].[editar_presentacion]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_presentacion]
@id_presentacion as int,
@presentacion varchar(50),
   @Unidad_de_medida varchar(50),
		  @Cantidad_por_presentacion varchar(50)
 
as 
update Presentaciones set  Presentacion=@presentacion, Unidad_de_medida=@Unidad_de_medida,Cantidad_por_presentacion=@Cantidad_por_presentacion
         
where Id_Presentacion=@id_presentacion
















GO
/****** Object:  StoredProcedure [dbo].[editar_presentacion_fraccionada_agregada]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_presentacion_fraccionada_agregada]

@idpresentacion as int,
@Stock as numeric(18,2)	,
@Precio_de_compra as numeric(18,2),
@Fecha_de_vencimiento varchar(50),
@Precio_de_venta_unitario numeric(18,2),
@Id_unidad int,
@Precio_de_venta_por_presentacion numeric(18,2),
@Ubicacion varchar(max),
@Se_vende_a varchar(50)
as 
update Presentaciones_fraccionadas  set 			
Stock =	@Stock ,			
Precio_de_compra =@Precio_de_compra,			
Fecha_de_vencimiento =@Fecha_de_vencimiento,
Precio_de_venta_unitario =@Precio_de_venta_unitario ,
Id_unidad =@Id_unidad ,
Precio_de_venta_por_presentacion =@Precio_de_venta_por_presentacion ,
Ubicacion =@Ubicacion        ,Se_vende_a=@Se_vende_a     
where Id_presentacionfraccionada    =@idpresentacion   



GO
/****** Object:  StoredProcedure [dbo].[editar_proceso]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_proceso]
@idproceso as int,
@proceso varchar (50)

as 
update Proceso  set Proceso =@proceso   
where IdProceso  =@idproceso   






GO
/****** Object:  StoredProcedure [dbo].[editar_Producto1]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_Producto1]
@Id_Producto1 int,
 @Descripcion varchar(50),
		    @Imagen varchar(50),			         
         
          @Linea as varchar(50)	,
		  @Usa_inventarios varchar(50),
	  @Stock varchar(50),
           @Precio_de_compra numeric(18,2),
           @Fecha_de_vencimiento varchar(50),
           @Precio_de_venta numeric(18,2),
           @Codigo varchar(50),
           @Se_vende_a varchar(50),
           @Impuesto varchar(50),
           @Stock_minimo numeric(18,2),
           @Precio_mayoreo numeric(18,2)
		 
as 
update Producto1 set  

      Descripcion =@Descripcion ,
		  Imagen =  @Imagen ,			         
         
         Linea = @Linea 	,
		  Usa_inventarios =@Usa_inventarios ,
		  Stock = @Stock ,
           Precio_de_compra =@Precio_de_compra ,
        Fecha_de_vencimiento =   @Fecha_de_vencimiento ,
          Precio_de_venta = @Precio_de_venta ,
         Codigo =  @Codigo ,
         Se_vende_a =  @Se_vende_a ,
           Impuesto =@Impuesto,
           Stock_minimo =@Stock_minimo ,
         Precio_mayoreo =  @Precio_mayoreo 
where id_Producto1=@Id_Producto1






GO
/****** Object:  StoredProcedure [dbo].[editar_proforma]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_proforma]
@idproforma as integer,
@fecha as date,
@documento as varchar (50),
@estado as varchar(50),
@tototal  as decimal(18,2),
@fechavenc as date,
@usuario as varchar(50),
@cliente as varchar(150),
@numero_documento as nchar(20),
@idcliente as int
as
update PROFORMA set fecha_Registro=@fecha ,documento=@documento ,Numero_Documento=@numero_documento ,estado=@estado ,total=@tototal ,fechavencimiento=@fechavenc ,usuario=@usuario ,idclientev=@idcliente ,cliente =@cliente 
where idproforma=@idproforma 





GO
/****** Object:  StoredProcedure [dbo].[editar_proveedor]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_proveedor]
@idproveedor as integer,
@razon_social varchar (100),

@direccion varchar(150),
@telefono int,
@porcentaje nchar(10),
@resta as decimal(18,2),
@montototal  as decimal(18,2),
@pagoenpartes as decimal(18,2),
@fechapagoenpartes as datetime
as 
update proveedores set Resta=@resta,Monto_Total=@montototal,Pago_en_partes=@pagoenpartes,Fecha_que_Pago_en_partes=@fechapagoenpartes , Razón_social=@razon_social ,Dirección=@direccion ,Telefono=@telefono ,Porcentaje_de_IGB_que_Aplica=@porcentaje
where Idproveedor =@idproveedor 





GO
/****** Object:  StoredProcedure [dbo].[editar_saldo]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_saldo]
@idcliente as integer,
@resta as decimal(18,2),
@montototal  as decimal(18,2),
@pagoenpartes as decimal(18,2),
@fechapagoenpartes as date


as

update Saldo set  Monto_Total=@montototal,Resta=@resta,Fecha_que_Pago_en_partes=@fechapagoenpartes,Pago_en_partes=@pagoenpartes   
where Id_Cliente=@idcliente 




GO
/****** Object:  StoredProcedure [dbo].[editar_saldo_total]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editar_saldo_total]
@idcliente as integer,
@saldo as numeric(18,2)


as

update clientes  set  Saldo=@saldo
where idclientev=@idcliente 




GO
/****** Object:  StoredProcedure [dbo].[editar_serializacion]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_serializacion]
@serie VARCHAR(50)  ,
@numeroinicio AS VARCHAR(50)    ,
@numerofin as varchar(50) ,
@Id_tipodoc as varchar(50), 
@Destino varchar(50) ,
   @Id_serie as int
as 
update Serializacion set  Serie =@serie   ,numeroinicio=@numeroinicio ,numerofin=@numerofin   
         ,Destino=@Destino,Id_tipodoc=@Id_tipodoc 
where Id_serializacion=@Id_serie 


GO
/****** Object:  StoredProcedure [dbo].[editar_serializacion_TICKET]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_serializacion_TICKET]

@numeroinicio AS VARCHAR(50)    ,
@numerofin as varchar(50) 


as 
update Serializacion set  numeroinicio=@numeroinicio ,numerofin=@numerofin   

where Id_tipodoc ='TICKET'
GO
/****** Object:  StoredProcedure [dbo].[editar_SERVICIOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_SERVICIOS]

@idservicio int,
@Fecha_de_Pago datetime,
@Total_a_Pagar decimal(18, 2),
@Resta decimal(18, 2),
@Pago_en_Partes nchar(10),
@Fecha_de_Pago_enPartes datetime,
@Estado varchar(50),
@Acumulado_Pagopartes as decimal(18,2)

as

update SERVICIOS set Id_servicio = @idservicio , Fecha_de_Pago = @Fecha_de_Pago, Total_a_Pagar = @Total_a_Pagar,
Resta = @Resta, Pago_en_Partes = @Pago_en_Partes, Fecha_de_Pago_enPartes=@Fecha_de_Pago_enPartes, Estado=@Estado,Acumulado_Pagopartes=@Acumulado_Pagopartes




GO
/****** Object:  StoredProcedure [dbo].[editar_stock_de_presentaciones_fraccionadas]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_stock_de_presentaciones_fraccionadas]
 @Stock as numeric(18,1),
  @Id_presentacionfraccionada int        


as

update Presentaciones_fraccionadas set Stock=@Stock 
where Id_presentacionfraccionada  =@Id_presentacionfraccionada   




GO
/****** Object:  StoredProcedure [dbo].[editar_stock_Y_PRECIODE_COMPRA_de_presentaciones_fraccionadas]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[editar_stock_Y_PRECIODE_COMPRA_de_presentaciones_fraccionadas]
 @Stock as numeric(18,1),
 @Id_presentacionfraccionada int,
 @precio_de_compra as numeric(18,6),
 @precio_de_compra_mostrado as numeric(18,2)    ,    
 @Almacen as varchar(50),
 @Fecha_de_produccion as varchar(50),
@Fecha_de_vencimiento varchar(50),
@Lote varchar(50),
@Peso numeric(18,2)

as

update Presentaciones_fraccionadas set Stock=@Stock ,Precio_de_compra =@precio_de_compra ,Precio_de_compra_mostrado=@precio_de_compra_mostrado , Almacen=@Almacen 

,Fecha_de_produccion=@Fecha_de_produccion,Fecha_de_vencimiento=@Fecha_de_vencimiento,Lote=@Lote
,Peso=@Peso
where Id_presentacionfraccionada  =@Id_presentacionfraccionada   

GO
/****** Object:  StoredProcedure [dbo].[editar_tipo_de_documento]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_tipo_de_documento]
@idtipo as integer,
@tipodoc varchar (50),
@descripcion as varchar (50),
@Ventas as varchar (50),
@Compras as varchar (50),
@Accion_en_stock as varchar (50)        		
as 
update Tipo_de_documento set 
Tipo_de_documento=@tipodoc ,
Descripcion=@descripcion ,
Ventas=@Ventas ,
Compras=@Compras,
Accion_en_stock=@Accion_en_stock

where Id_tipodoc    =@idtipo 


GO
/****** Object:  StoredProcedure [dbo].[editar_tipo_de_producto]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_tipo_de_producto]
@idtipo as integer,
@descripcion varchar(50),
@Ventas varchar(50),
@Compras varchar(50),
@Almacen varchar(50),
@Puede_tener_formulaciones varchar(50)          		
as 
update Tipos_De_productos set 
Descripcion=@descripcion,
Ventas=@Ventas ,
Compras=@Compras ,
Almacen=@Almacen,
Puede_tener_formulaciones=@Puede_tener_formulaciones

where Id_tipo_de_producto   =@idtipo 




GO
/****** Object:  StoredProcedure [dbo].[editar_Titular_de_la_cuenta]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_Titular_de_la_cuenta]
@Id_cuenta_bancaria as int,
@Titular_de_la_cuenta varchar(50),        
        
			@Numero_Cuenta_corriente varchar(max),        
            @Saldo as numeric(18,2) ,
			@Moneda as varchar(50)
       
           		
as 
update Cuentas_corrientes_bancos_datos_generales set 
Titular_de_la_cuenta=@Titular_de_la_cuenta,        
          
			Numero_Cuenta_corriente=@Numero_Cuenta_corriente ,        
            Saldo=@Saldo  ,
			Moneda=@Moneda 

where Id_cuenta_bancaria   =@Id_cuenta_bancaria

GO
/****** Object:  StoredProcedure [dbo].[editar_unidades_de_medida]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  proc [dbo].[editar_unidades_de_medida]
@id_Unidad_de_medida as int,
 @Unidad_de_medida varchar(50),
 @Cantidad_por_unidad_de_medida varchar(50)
 
		
 
as 
update Unidad_de_medida set  
        
Unidad_de_medida =@Unidad_de_medida ,Cantidad_por_unidad_de_medida =@Cantidad_por_unidad_de_medida 
where Id_unidad_de_medida =@id_Unidad_de_medida
















GO
/****** Object:  StoredProcedure [dbo].[editar_usuario]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_usuario]
@idusuario int,
@nombres varchar(50),

@paswor varchar(50)



as


update USUARIO2 set Nombre_y_Apelllidos= @nombres,Password =@paswor 
 where idUsuario = @idusuario

GO
/****** Object:  StoredProcedure [dbo].[editar_usuario_solo_nombre]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editar_usuario_solo_nombre]
@idusuario int,
@nombres varchar(50)
as
update USUARIO2 set Nombre_y_Apelllidos= @nombres
 where idUsuario = @idusuario

GO
/****** Object:  StoredProcedure [dbo].[editar_venta]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_venta]
@idventa int,
@montototal as numeric(18,1),
@IGV as numeric(18,1)

as
if @montototal <>0
update ventas set Monto_total  =@montototal, IGV=@IGV 

where idventa =@idventa 
else
begin 
delete
from ventas 
where idventa=@idventa 
end




GO
/****** Object:  StoredProcedure [dbo].[eliminar_almacen]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_almacen]
@idalmacen as int
as
delete from Destinos_almacen  where Id_destino_almacen  =@idalmacen  





GO
/****** Object:  StoredProcedure [dbo].[eliminar_AREAS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_AREAS]
@Id_Areas int
as
delete from AREAS
where Id_Areas=Id_Areas





GO
/****** Object:  StoredProcedure [dbo].[eliminar_BANCOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_BANCOS]
@Id_nombre_de_bancos as integer
as
delete from BANCOS
where Id_nombre_de_bancos=@Id_nombre_de_bancos


GO
/****** Object:  StoredProcedure [dbo].[eliminar_caja]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_caja]
@id integer
as
delete from Caja   where Id_Caja  =@id 


GO
/****** Object:  StoredProcedure [dbo].[eliminar_categoria]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[eliminar_categoria]
@idcategoria integer
as 
delete from categoria where idcategoria=@idcategoria






GO
/****** Object:  StoredProcedure [dbo].[eliminar_centros_De_produccion]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_centros_De_produccion]
@Id_Centro_de_produccion as int


as

delete from Centros_de_produccion 
where Id_Centro_de_produccion =@Id_Centro_de_produccion





GO
/****** Object:  StoredProcedure [dbo].[eliminar_cliente]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_cliente]
@idcliente integer
as
delete from clientes where idclientev=@idcliente


GO
/****** Object:  StoredProcedure [dbo].[eliminar_COBERTURA]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_COBERTURA]
@Id_covertura integer
as
delete from COBERTURA  where Id_covertura =@Id_covertura


GO
/****** Object:  StoredProcedure [dbo].[eliminar_cOBROX]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_cOBROX]
@Id_control_de_cobros as int
as
delete from CONTROL_DE_COBROSX where Id_control_de_cobros =@Id_control_de_cobros

GO
/****** Object:  StoredProcedure [dbo].[eliminar_compra]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_compra]
@cod_compra as int
as
delete from Compra where Cod_compra=@cod_compra 






GO
/****** Object:  StoredProcedure [dbo].[eliminar_COMPRA__en_cero]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_COMPRA__en_cero]

as
delete from Compra  where Total_a_pagar =0

GO
/****** Object:  StoredProcedure [dbo].[eliminar_concepto]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_concepto]
@idconcepto integer
as
delete from CONCEPTOS  where Id_concepto =@idconcepto 


GO
/****** Object:  StoredProcedure [dbo].[eliminar_Control_de_asistencia_ordende_de_produccion]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_Control_de_asistencia_ordende_de_produccion]
@IdControl_de_OrdenesProduccion int
as
delete from Control_de_asistencia_ordende_de_produccion
where IdControl_de_OrdenesProduccion=@IdControl_de_OrdenesProduccion




GO
/****** Object:  StoredProcedure [dbo].[eliminar_Cuenta_corriente_para_operaciones]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_Cuenta_corriente_para_operaciones]
@Id_cuenta_corriente_para_operaciones as integer
as
delete from Cuenta_corriente_para_operaciones
where Id_cuenta_corriente_para_operaciones=@Id_cuenta_corriente_para_operaciones

GO
/****** Object:  StoredProcedure [dbo].[eliminar_Cuentas_corrientes_bancos_datos_generales]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_Cuentas_corrientes_bancos_datos_generales]
@Id_cuenta_bancaria as integer
as
delete from Cuentas_corrientes_bancos_datos_generales
where Id_cuenta_bancaria=@Id_cuenta_bancaria

GO
/****** Object:  StoredProcedure [dbo].[eliminar_Designacion_Personal_Para_ordenesdeproduccion]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_Designacion_Personal_Para_ordenesdeproduccion]
@Id_Personal_para_ordenesProduccion int
as
delete from Designacion_Personal_Para_ordenesdeproduccion
where Id_Personal_para_ordenesProduccion=@Id_Personal_para_ordenesProduccion





GO
/****** Object:  StoredProcedure [dbo].[eliminar_detalle_COMPRA]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_detalle_COMPRA]
@iddetallecompra as int
as
delete from Detalle_Compra  where iddetallecompra=@iddetallecompra




GO
/****** Object:  StoredProcedure [dbo].[eliminar_DETALLE_CONTROL_DE_COBROS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_DETALLE_CONTROL_DE_COBROS]
@id as int
as
delete from DETALLE_CONTROL_DE_COBROS where Id_detalle_de_control_de_cobros =@id 






GO
/****** Object:  StoredProcedure [dbo].[eliminar_detalle_venta]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_detalle_venta]
@iddetalleventa as int
as
delete from detalle_venta where iddetalle_venta=@iddetalleventa 


GO
/****** Object:  StoredProcedure [dbo].[eliminar_detalle_venta_servicios]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_detalle_venta_servicios]
@iddetalleventa as int
as
delete from Detalle_venta_de_servicios where Id_detalle_venta_servicio=@iddetalleventa 

GO
/****** Object:  StoredProcedure [dbo].[eliminar_DOCUMENTOS_QUE_SE_ENTREGAN_FRACCIONAMIENTO_COTIZACION]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_DOCUMENTOS_QUE_SE_ENTREGAN_FRACCIONAMIENTO_COTIZACION]
@Id_documentos_que_se_entregan_fraccionamiento as int
as
delete from DOCUMENTOS_QUE_SE_ENTREGAN_FRACCIONAMIENTO_COTIZACION where Id_documentos_que_se_entregan_fraccionamiento=@Id_documentos_que_se_entregan_fraccionamiento 






GO
/****** Object:  StoredProcedure [dbo].[eliminar_Empresa]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_Empresa]
@id_Empresa as int


as

delete from EMPRESA 
where id_Empresa=@id_Empresa





GO
/****** Object:  StoredProcedure [dbo].[eliminar_Equipos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_Equipos]
@Id_Equipo int
as
delete from Equipos
where Id_Equipo=Id_Equipo





GO
/****** Object:  StoredProcedure [dbo].[eliminar_FORMULACION_DE_PERSONAL_PARA_FRACCIONAMIENTO_DE_PRODUCTOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[eliminar_FORMULACION_DE_PERSONAL_PARA_FRACCIONAMIENTO_DE_PRODUCTOS]
@Id_formulacion_de_personal integer
as 
delete from FORMULACION_DE_PERSONAL_PARA_FRACCIONAMIENTO_DE_PRODUCTOS where Id_formulacion_de_personal=@Id_formulacion_de_personal

GO
/****** Object:  StoredProcedure [dbo].[eliminar_Formulaciones_de_fraccionamiento_de_productos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_Formulaciones_de_fraccionamiento_de_productos]
@Id_formulacion integer
as 
delete from Formulaciones_de_fraccionamiento_de_productos where Id_formulacion=@Id_formulacion

GO
/****** Object:  StoredProcedure [dbo].[eliminar_gasto]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_gasto]
@idgasto integer
as
delete from GASTOSVARIOS  where Idgasto =@idgasto 





GO
/****** Object:  StoredProcedure [dbo].[eliminar_GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS]
@Id_grupo_concepto_gasto as integer
as
delete from GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS
where Id_grupo_concepto_gasto=@Id_grupo_concepto_gasto


GO
/****** Object:  StoredProcedure [dbo].[eliminar_ingreso]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_ingreso]
@idgasto integer
as
delete from INGRESOSVARIOS  where Idgasto =@idgasto 





GO
/****** Object:  StoredProcedure [dbo].[eliminar_materiales]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_materiales]
@idmateriales integer
as
delete from materiales where Id_materiales  =@idmateriales 



GO
/****** Object:  StoredProcedure [dbo].[eliminar_nombreservicio]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_nombreservicio]
@idnombreservicio as int

as
delete from nombredeservicio   where Id_nombreServicio  =@idnombreservicio  




GO
/****** Object:  StoredProcedure [dbo].[eliminar_Orden_de_Produccion]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_Orden_de_Produccion]
as
delete from Orden_de_Produccion
where IdOrden=IdOrden





GO
/****** Object:  StoredProcedure [dbo].[eliminar_PAGOSX]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_PAGOSX]
@Id_control_de_cobros as int
as
delete from CONTROL_DE_PAGOS_A_PROVEEDORESX where Id_control_de_pagos =@Id_control_de_cobros

GO
/****** Object:  StoredProcedure [dbo].[eliminar_personal]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_personal]
@idpersonal integer
as
delete from Personal where Id_personal =@idpersonal



GO
/****** Object:  StoredProcedure [dbo].[eliminar_presentaciones]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_presentaciones]
@id_presentacion as int
as
delete from Presentaciones where Id_Presentacion=@id_presentacion





GO
/****** Object:  StoredProcedure [dbo].[eliminar_presentaciones_FRACCIONADAS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_presentaciones_FRACCIONADAS]
@id_presentacion_fraccionada as int
as
delete from Presentaciones_fraccionadas where Id_presentacionfraccionada =@id_presentacion_fraccionada 

GO
/****** Object:  StoredProcedure [dbo].[eliminar_Procesos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_Procesos]
@IdProceso int
as
delete from Procesos
where IdProceso=IdProceso





GO
/****** Object:  StoredProcedure [dbo].[eliminar_producto]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_producto]
@idproducto  int
as
delete from Producto1  where Id_Producto1 =@idproducto 





GO
/****** Object:  StoredProcedure [dbo].[eliminar_PRODUCTO_DE_KARDEX]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_PRODUCTO_DE_KARDEX]
@id as int
as
delete from KARDEX  where Id_kardex  =@id


GO
/****** Object:  StoredProcedure [dbo].[eliminar_Producto1]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_Producto1]
@id int
as
delete  
from Producto1 

where 
Id_Producto1  =@id



--DELETE TablaConRegistrosAEliminar
       --FROM TablaConRegistrosAEliminar TDel INNER JOIN TablaParaCriterioDeEliminacion TFiltro
       --     ON TDel.idCampo_fk=TFiltro.idCampo_pk
       --WHERE TFiltro.criterio='Valor para filtrar'




GO
/****** Object:  StoredProcedure [dbo].[eliminar_productos2]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_productos2]
@idproducto int
as
delete from productos2
where idproducto=idproducto





GO
/****** Object:  StoredProcedure [dbo].[eliminar_proveedor]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_proveedor]
@idproveedor integer
as
delete from proveedores  where Idproveedor =@idproveedor 





GO
/****** Object:  StoredProcedure [dbo].[eliminar_SERVICIOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_SERVICIOS]
@Idpago_Servicio as int

as
delete from SERVICIOS  where Idpago_Servicio =@Idpago_Servicio




GO
/****** Object:  StoredProcedure [dbo].[eliminar_unidades]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_unidades]
@id_unidad as int
as
delete from Unidad_de_medida where Id_unidad_de_medida =@id_unidad 





GO
/****** Object:  StoredProcedure [dbo].[eliminar_usuario]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_usuario]
@idusuario as int,
@login varchar(50)

as
	   BEGIN
if EXISTS (SELECT Login   FROM USUARIO2  where @login ='admin'  )
RAISERROR ('El Usuario *Admin* es Inborrable, si se borraria Eliminarias el Acceso al Sistema de porvida, Accion Denegada', 16,1)
else
BEGIN
delete from USUARIO2  where idUsuario =@idusuario and Login <>'admin' 
end
end



GO
/****** Object:  StoredProcedure [dbo].[eliminar_venta]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_venta]
@idventa as integer 
as
delete from ventas where idventa=@idventa 


GO
/****** Object:  StoredProcedure [dbo].[eliminar_venta__en_cero]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_venta__en_cero]

as
delete from ventas where Monto_total=0

GO
/****** Object:  StoredProcedure [dbo].[eliminar_venta_en_historial]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_venta_en_historial]

as
delete from ventas where  Estado <>'EN ESPERA' AND Monto_total =0


GO
/****** Object:  StoredProcedure [dbo].[eliminar_venta_incompletas]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_venta_incompletas]

@idusuario int
as
delete from ventas where  Id_usuario =@idusuario and  Estado ='EN ESPERA'


GO
/****** Object:  StoredProcedure [dbo].[EMISION_DE_GUIAS_DE_REMISION_SIN_DATOS_TECNICOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[EMISION_DE_GUIAS_DE_REMISION_SIN_DATOS_TECNICOS]
@nguia as varchar(50)
as 
SELECT        dbo.GUIAS_DE_REMISION_OK.Punto_de_partida, dbo.GUIAS_DE_REMISION_OK.Punto_de_llegada, dbo.GUIAS_DE_REMISION_OK.Fecha_de_inicio_del_traslado, 
                         dbo.GUIAS_DE_REMISION_OK.Numero_de_guia, dbo.clientes.Nombre, dbo.clientes.Ruc, (dbo.Producto1.Descripcion +'-'+ dbo.Presentaciones.Presentacion) As Producto, 
                         dbo.detalle_venta.Unidad_de_medida, dbo.detalle_venta.Cantidad_mostrada, ( CONVERT(varchar(12), DBO.GUIAS_DE_REMISION_OK.Peso_total, 101) +' ' + DBO.GUIAS_DE_REMISION_OK.Unidad_de_medida_fisica) as Peso_total 
                         
FROM            dbo.GUIAS_DE_REMISION_OK INNER JOIN
                         dbo.detalle_venta ON dbo.GUIAS_DE_REMISION_OK.Id_detalle_venta = dbo.detalle_venta.iddetalle_venta INNER JOIN
                         dbo.ventas ON dbo.detalle_venta.idventa = dbo.ventas.idventa INNER JOIN
                         dbo.clientes ON dbo.ventas.idclientev = dbo.clientes.idclientev INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.detalle_venta.Id_presentacionfraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1
						 where dbo.ventas .Guia_de_remision =@nguia  

GO
/****** Object:  StoredProcedure [dbo].[FACTURA]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[FACTURA]
@idventa as int,
@numeroletra as varchar(max)
AS
						 SELECT        dbo.ventas.idventa, dbo.clientes.Nombre, dbo.clientes.Direccion_para_factura, dbo.detalle_venta.Cantidad_mostrada, (dbo.detalle_venta.Unidad_de_medida + ' ' +
                         dbo.Producto1.Descripcion + '-'+ dbo.Presentaciones.Presentacion) AS PRODUCTO, dbo.detalle_venta.Total_a_pagar, Cast(dbo.ventas.fecha_venta As Date) AS FECHA, dbo.ventas.Numero_de_doc, 
                         dbo.ventas.IGV, dbo.detalle_venta.preciounitario, dbo.clientes.Ruc,dbo.ventas.Guia_de_remision ,@numeroletra as numeroletra
FROM            dbo.ventas INNER JOIN
                         dbo.detalle_venta ON dbo.ventas.idventa = dbo.detalle_venta.idventa INNER JOIN
                         dbo.clientes ON dbo.ventas.idclientev = dbo.clientes.idclientev INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.detalle_venta.Id_presentacionfraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1 INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion
						 where dbo.ventas.idventa=@idventa 

GO
/****** Object:  StoredProcedure [dbo].[IMPRIMIR_COTIZACION_ETAPA_INICIAL]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[IMPRIMIR_COTIZACION_ETAPA_INICIAL]
@idventa as integer
as
SELECT        dbo.clientes.Nombre, dbo.Tipo_de_documento.Descripcion, dbo.ventas.Numero_de_doc, dbo.ventas.Tipo_de_pago, dbo.ventas.fecha_venta, dbo.ventas.Estado, 
                         dbo.clientes.Nombre_de_contacto, dbo.clientes.direccion_de_envio, dbo.clientes.movil, dbo.CONDICIONES_DE_VENTA_FRACCIONAMIENTO.Descripcion AS Expr1, 
                         dbo.DOCUMENTOS_QUE_SE_ENTREGAN_FRACCIONAMIENTO_COTIZACION.Descripcion AS Expr2, dbo.BANCOS .Descripcion , 
                         dbo.Cuentas_corrientes_bancos_datos_generales.Numero_Cuenta_corriente, dbo.Cuentas_corrientes_bancos_datos_generales.Titular_de_la_cuenta, 
                         dbo.Servicio_de_fraccionamiento.Descripcion AS Expr3, dbo.Servicio_de_fraccionamiento.Producto, dbo.Servicio_de_fraccionamiento.Marca, 
                         dbo.Presentaciones.Presentacion, dbo.PRECIOS_SERVICIOS_DE_FRACCIONAMIENTO.Precio, dbo.Detalle_venta_de_servicios.cantidad, 
                         dbo.Detalle_venta_de_servicios.Total_a_pagar
FROM            dbo.Presentaciones INNER JOIN
                         dbo.Presentaciones_fraccionadas_fraccionamiento ON 
                         dbo.Presentaciones.Id_Presentacion = dbo.Presentaciones_fraccionadas_fraccionamiento.Id_presentacion INNER JOIN
                         dbo.Servicio_de_fraccionamiento ON 
                         dbo.Presentaciones_fraccionadas_fraccionamiento.Id_servicio = dbo.Servicio_de_fraccionamiento.Id_detalle_fraccionamiento_lote INNER JOIN
                         dbo.Detalle_venta_de_servicios ON 
                         dbo.Presentaciones_fraccionadas_fraccionamiento.Id_presentacion_fraccionamiento = dbo.Detalle_venta_de_servicios.Id_presentacion_fraccionamiento INNER JOIN
                         dbo.clientes INNER JOIN
                         dbo.ventas ON dbo.clientes.idclientev = dbo.ventas.idclientev INNER JOIN
                         dbo.Serializacion ON dbo.ventas.Id_series = dbo.Serializacion.Id_serializacion INNER JOIN
                         dbo.Tipo_de_documento ON dbo.Serializacion.Id_tipodoc = dbo.Tipo_de_documento.Id_tipodoc INNER JOIN
                         dbo.CONTROL_DE_DOCUMENTOS_QUE_SE_ENTREGAN_FRACCIONAMIENTO_COTIZACION ON 
                         dbo.ventas.idventa = dbo.CONTROL_DE_DOCUMENTOS_QUE_SE_ENTREGAN_FRACCIONAMIENTO_COTIZACION.Id_venta INNER JOIN
                         dbo.DOCUMENTOS_QUE_SE_ENTREGAN_FRACCIONAMIENTO_COTIZACION ON 
                         dbo.CONTROL_DE_DOCUMENTOS_QUE_SE_ENTREGAN_FRACCIONAMIENTO_COTIZACION.Id_documentos_que_se_entregan = dbo.DOCUMENTOS_QUE_SE_ENTREGAN_FRACCIONAMIENTO_COTIZACION.Id_documentos_que_se_entregan_fraccionamiento
                          INNER JOIN
                         dbo.CONDICIONES_DE_VENTA_FRACCIONAMIENTO ON dbo.ventas.idventa = dbo.CONDICIONES_DE_VENTA_FRACCIONAMIENTO.Id_venta INNER JOIN
                         dbo.CUENTAS_A_ABONAR_PARA_COTIZACIONES ON dbo.ventas.idventa = dbo.CUENTAS_A_ABONAR_PARA_COTIZACIONES.Id_venta INNER JOIN
                         dbo.Cuentas_corrientes_bancos_datos_generales ON 
                         dbo.CUENTAS_A_ABONAR_PARA_COTIZACIONES.Id_cuenta_bancaria = dbo.Cuentas_corrientes_bancos_datos_generales.Id_cuenta_bancaria ON 
                         dbo.Detalle_venta_de_servicios.idventa = dbo.ventas.idventa INNER JOIN
                         dbo.PRECIOS_SERVICIOS_DE_FRACCIONAMIENTO ON 
                         dbo.Presentaciones_fraccionadas_fraccionamiento.Id_presentacion_fraccionamiento = dbo.PRECIOS_SERVICIOS_DE_FRACCIONAMIENTO.Id_presentaciones_fraccionadas_servicio_fraccionamiento
						 INNER JOIN dbo.BANCOS on dbo.BANCOS.Id_nombre_de_bancos =dbo.Cuentas_corrientes_bancos_datos_generales.Id_Banco 
						 where dbo.ventas.idventa=@idventa 
GROUP BY dbo.clientes.Nombre, dbo.Tipo_de_documento.Descripcion, dbo.ventas.Numero_de_doc, dbo.ventas.Tipo_de_pago, dbo.ventas.fecha_venta, dbo.ventas.Estado, 
                         dbo.clientes.Nombre_de_contacto, dbo.clientes.direccion_de_envio, dbo.clientes.movil, dbo.CONDICIONES_DE_VENTA_FRACCIONAMIENTO.Descripcion, 
                         dbo.DOCUMENTOS_QUE_SE_ENTREGAN_FRACCIONAMIENTO_COTIZACION.Descripcion, dbo.Cuentas_corrientes_bancos_datos_generales.Id_Banco , 
                         dbo.Cuentas_corrientes_bancos_datos_generales.Numero_Cuenta_corriente, dbo.Cuentas_corrientes_bancos_datos_generales.Titular_de_la_cuenta, 
                         dbo.Servicio_de_fraccionamiento.Descripcion, dbo.Servicio_de_fraccionamiento.Producto, dbo.Servicio_de_fraccionamiento.Marca, 
                         dbo.Presentaciones.Presentacion, dbo.PRECIOS_SERVICIOS_DE_FRACCIONAMIENTO.Precio, dbo.Detalle_venta_de_servicios.cantidad, 
                         dbo.Detalle_venta_de_servicios.Total_a_pagar, dbo.BANCOS .Descripcion
						 

GO
/****** Object:  StoredProcedure [dbo].[IMPRIMIR_COTIZACION_ETAPA_INICIAL_SOLO_DETALLE_DE_PRODUCTO]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[IMPRIMIR_COTIZACION_ETAPA_INICIAL_SOLO_DETALLE_DE_PRODUCTO]
@idventa as integer
as
SELECT        dbo.clientes.Nombre, dbo.Tipo_de_documento.Descripcion, dbo.ventas.Numero_de_doc, dbo.ventas.Tipo_de_pago, dbo.ventas.fecha_venta, dbo.ventas.Estado, 
                         dbo.clientes.Nombre_de_contacto, dbo.clientes.direccion_de_envio, dbo.clientes.movil, dbo.Servicio_de_fraccionamiento.Descripcion AS Expr3, 
                         dbo.Servicio_de_fraccionamiento.Producto, dbo.Servicio_de_fraccionamiento.Marca, dbo.Presentaciones.Presentacion, 
                         dbo.PRECIOS_SERVICIOS_DE_FRACCIONAMIENTO.Precio, dbo.Detalle_venta_de_servicios.cantidad, dbo.Detalle_venta_de_servicios.Total_a_pagar
FROM            dbo.Presentaciones INNER JOIN
                         dbo.Presentaciones_fraccionadas_fraccionamiento ON 
                         dbo.Presentaciones.Id_Presentacion = dbo.Presentaciones_fraccionadas_fraccionamiento.Id_presentacion INNER JOIN
                         dbo.Servicio_de_fraccionamiento ON 
                         dbo.Presentaciones_fraccionadas_fraccionamiento.Id_servicio = dbo.Servicio_de_fraccionamiento.Id_detalle_fraccionamiento_lote INNER JOIN
                         dbo.Detalle_venta_de_servicios ON 
                         dbo.Presentaciones_fraccionadas_fraccionamiento.Id_presentacion_fraccionamiento = dbo.Detalle_venta_de_servicios.Id_presentacion_fraccionamiento INNER JOIN
                         dbo.clientes INNER JOIN
                         dbo.ventas ON dbo.clientes.idclientev = dbo.ventas.idclientev INNER JOIN
                         dbo.Serializacion ON dbo.ventas.Id_series = dbo.Serializacion.Id_serializacion INNER JOIN
                         dbo.Tipo_de_documento ON dbo.Serializacion.Id_tipodoc = dbo.Tipo_de_documento.Id_tipodoc INNER JOIN
                         dbo.CONTROL_DE_DOCUMENTOS_QUE_SE_ENTREGAN_FRACCIONAMIENTO_COTIZACION ON 
                         dbo.ventas.idventa = dbo.CONTROL_DE_DOCUMENTOS_QUE_SE_ENTREGAN_FRACCIONAMIENTO_COTIZACION.Id_venta ON 
                         dbo.Detalle_venta_de_servicios.idventa = dbo.ventas.idventa INNER JOIN
                         dbo.PRECIOS_SERVICIOS_DE_FRACCIONAMIENTO ON 
                         dbo.Presentaciones_fraccionadas_fraccionamiento.Id_presentacion_fraccionamiento = dbo.PRECIOS_SERVICIOS_DE_FRACCIONAMIENTO.Id_presentaciones_fraccionadas_servicio_fraccionamiento
	 where dbo.ventas.idventa=@idventa
GROUP BY dbo.clientes.Nombre, dbo.Tipo_de_documento.Descripcion, dbo.ventas.Numero_de_doc, dbo.ventas.Tipo_de_pago, dbo.ventas.fecha_venta, dbo.ventas.Estado, 
                         dbo.clientes.Nombre_de_contacto, dbo.clientes.direccion_de_envio, dbo.clientes.movil, dbo.Servicio_de_fraccionamiento.Descripcion, 
                         dbo.Servicio_de_fraccionamiento.Producto, dbo.Servicio_de_fraccionamiento.Marca, dbo.Presentaciones.Presentacion, 
                         dbo.PRECIOS_SERVICIOS_DE_FRACCIONAMIENTO.Precio, dbo.Detalle_venta_de_servicios.cantidad, dbo.Detalle_venta_de_servicios.Total_a_pagar

					 

GO
/****** Object:  StoredProcedure [dbo].[IMPRIMIR_ORDEN_DE_FRACCIONAMIENTO_DATOS_GENERALES]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[IMPRIMIR_ORDEN_DE_FRACCIONAMIENTO_DATOS_GENERALES]
@fecha_a_fraccionar as date
as
SELECT        dbo.detalle_venta.iddetalle_venta, dbo.detalle_venta.idventa, dbo.detalle_venta.Id_presentacionfraccionada, 
                         dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Actividad, dbo.Producto1.Descripcion, dbo.Presentaciones.Presentacion, dbo.detalle_venta.cantidad, 
                         dbo.detalle_venta.Unidad_de_medida,
                         ORDEN_DE_FRACCIONAMINETO_DE_PRODUCTOS.Numero_de_produccion 
						 ,ORDEN_DE_FRACCIONAMINETO_DE_PRODUCTOS.Fecha_de_produccion ,dbo.Centros_de_produccion.Centro_de_produccion 
						,dbo.Personal.Nombres , dbo.Personal.Cargo,dbo.Turno.Descripcion as Turno
						
FROM            dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES


						INNER JOIN
						dbo.Turno on dbo.Turno.Id_turno =PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Id_turno_programado 
 INNER JOIn
                         dbo.detalle_venta ON dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Id_detalle_venta = dbo.detalle_venta.iddetalle_venta INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.detalle_venta.Id_presentacionfraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1 
                        
						inner join  dbo.ORDEN_DE_FRACCIONAMINETO_DE_PRODUCTOS on detalle_venta.iddetalle_venta =dbo.ORDEN_DE_FRACCIONAMINETO_DE_PRODUCTOS.Id_detalleventa 
						INNER JOIN dbo.Personal on dbo.ORDEN_DE_FRACCIONAMINETO_DE_PRODUCTOS .Id_responsable_personal  = dbo.Personal.Id_personal
						INNER JOIN dbo.Centros_de_produccion on dbo.ORDEN_DE_FRACCIONAMINETO_DE_PRODUCTOS.Id_centro_de_produccion =dbo.Centros_de_produccion.Id_Centro_de_produccion 
						 where dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES .Fecha_programada = @fecha_a_fraccionar 

						  GROUP BY  dbo.detalle_venta.iddetalle_venta, dbo.detalle_venta.idventa, dbo.detalle_venta.Id_presentacionfraccionada, 
                         dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Actividad, dbo.Producto1.Descripcion, dbo.Presentaciones.Presentacion, dbo.detalle_venta.cantidad, 
                         dbo.detalle_venta.Unidad_de_medida,  
                          ORDEN_DE_FRACCIONAMINETO_DE_PRODUCTOS.Numero_de_produccion 
						 ,ORDEN_DE_FRACCIONAMINETO_DE_PRODUCTOS.Fecha_de_produccion ,dbo.Centros_de_produccion.Centro_de_produccion 
						,dbo.Personal.Nombres , dbo.Personal.Cargo ,dbo.Turno.Descripcion 

GO
/****** Object:  StoredProcedure [dbo].[imprimir_ticketservicio]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[imprimir_ticketservicio]
@idservicio as int
as
SELECT        idservicio, Cliente, DNI, Nombre_del_Servicio, Total_a_Pagar, Fecha_de_Registro, Hora_de_Registro, Pagando, Resto, Estado, Fecha_de_Entrega, 
                         Hora_de_Entrega
FROM            dbo.NSERVICIOS
    where idservicio =@idservicio 





GO
/****** Object:  StoredProcedure [dbo].[INFORME_DETALLADA_DE_GASTOS_GARFIL]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[INFORME_DETALLADA_DE_GASTOS_GARFIL_tipo_comprobante]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[INFORME_DETALLADA_DE_GASTOS_GARFIL_tipo_comprobante]

 as
select 
  sum(dbo.GASTOSVARIOS.Importe  ) as Egresos_Gastos_varios, Tipo_de_Comprobante,
   count( (dbo.GASTOSVARIOS.Tipo_de_Comprobante  )) as Cantidad
 from dbo.GASTOSVARIOS 

GROUP BY  Tipo_de_Comprobante

GO
/****** Object:  StoredProcedure [dbo].[INFORME_DETALLADA_DE_GASTOS_GARFIL_tipo_comprobante_extra]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[insertar__precios_a_presentaciones_fraccionadas_fraccionamiento]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar__precios_a_presentaciones_fraccionadas_fraccionamiento]                
           @Precio numeric(18,2),
		   @Id_presentaciones_fraccionadas_servicio_fraccionamiento int,
		   @Id_unidades int
	as	   
		   INSERT INTO PRECIOS_SERVICIOS_DE_FRACCIONAMIENTO
     VALUES
		    (

          @Precio ,
		   @Id_presentaciones_fraccionadas_servicio_fraccionamiento ,
		   @Id_unidades 
  
         
         )


GO
/****** Object:  StoredProcedure [dbo].[insertar_alquiler]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_alquiler]
--@IdAlquiler as int,
@Cliente as varchar(50),
@idcliente as int,
@DNI as varchar(50),
@Total_a_pagar as decimal(18,2),
@tipodepago as varchar(50),
@Pagando as decimal(18,2),
@Fecha_que_pago as date,
@Fechadepago as date,

@fechadeentrada as date,
@fechadesalida as date,
@tiempoaalojarse as varchar(50),
@Moneda as varchar(50),
@Estado as varchar(50),
@garantia as decimal(18,2),
@estadogarantia as varchar(50)
as
insert into Alquilerdehabitacion (Cliente,DNI,Total_a_pagar,Tipo_de_Pago,Pagando,Fecha_que_Pago,Fecha_de_entrada,Fecha_de_Salida,Tipo_Documento,Moneda,Estado,Fecha_de_pago,Idcliente,Garantia,Estado_Garantia )
 values (@Cliente,@DNI,@Total_a_pagar,@tipodepago,@Pagando,@Fecha_que_pago,@fechadeentrada,@fechadesalida,@tiempoaalojarse,@Moneda,@Estado,@Fechadepago,@idcliente,@garantia,@estadogarantia   )





GO
/****** Object:  StoredProcedure [dbo].[insertar_AREAS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_AREAS]
@Id_Areas int output ,
@Area varchar(50),
@Encargado varchar (50)
as
insert into AREAS (Area,Encargado)
values (@Area,@Encargado)





GO
/****** Object:  StoredProcedure [dbo].[insertar_ASIGNACION_DE_CLIENTES_A_RUTAS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertar_ASIGNACION_DE_CLIENTES_A_RUTAS]

@Id_ruta INT,
@Id_cliente AS INT,
@Estado as varchar(50),
@OBSERVACIONES as varchar(max)


as 
INSERt into ASIGNACION_DE_CLIENTES_A_RUTAS 
values (@Id_ruta ,
@Id_cliente  ,
@Estado ,
@OBSERVACIONES )

GO
/****** Object:  StoredProcedure [dbo].[insertar_asignacion_de_TURNO]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertar_asignacion_de_TURNO]
@Id_turno int,
@Id_personal int
 AS
insert into Asignacion_de_turnos_a_personal  values (
@Id_turno ,
@Id_personal  )


GO
/****** Object:  StoredProcedure [dbo].[Insertar_ASISTENCIAS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Insertar_ASISTENCIAS]
   @Id_personal INT,
          @Fecha_entrada DATETIME,
         @Fecha_salida DATETIME,
           @Estado VARCHAR(50),
          
          @Horas VARCHAR(50)

as

insert into ASISTENCIAS values (   @Id_personal ,
          @Fecha_entrada ,
         @Fecha_salida ,
           @Estado ,
          
          @Horas)



GO
/****** Object:  StoredProcedure [dbo].[Insertar_caja]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Insertar_caja]

	
	@descripcion varchar(50),
	@saldo numeric(18,2),

	 @Serial_PC varchar(50)
	   
    as
	BEGIN
if EXISTS (SELECT  Descripcion     FROM Caja    where  Descripcion=@descripcion   )
RAISERROR ('YA EXISTE UNA CAJA REGISTRADA CON ESE NOMBRE, Ingrese un nombre diferente', 16,1)
else
BEGIN
    INSERT INTO Caja values 
	(@descripcion,@saldo,@Serial_PC )

	end
	end
GO
/****** Object:  StoredProcedure [dbo].[insertar_categoria]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_categoria]
@nombrecategoria varchar(50)
as
insert into categoria (nombrecategoria) values (@nombrecategoria)






GO
/****** Object:  StoredProcedure [dbo].[insertar_Centros_de_produccion]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_Centros_de_produccion]

@Centro_de_produccion varchar(50),
@Direccion varchar(50)


as
insert into Centros_de_produccion

values (@Centro_de_produccion ,
@Direccion  )
--RAISERROR ('Registrado correctamente', 16,1)



GO
/****** Object:  StoredProcedure [dbo].[insertar_cliente]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  procedure [dbo].[insertar_cliente]
@Nombre varchar(MAX),
           @Direccion_para_factura varchar(MAX),
            @Ruc varchar(MAX),                      
            @movil varchar(50),               
            @Cliente varchar(50),
            @Proveedor varchar(50),
			@Estado as varchar(50)
		,@Saldo numeric(18,2)
as

insert into clientes  values 
            (@Nombre
           ,@Direccion_para_factura
           ,@Ruc
           ,@movil     
          
           ,@Cliente
           ,@Proveedor
		   ,@Estado,
		   @Saldo
            )





GO
/****** Object:  StoredProcedure [dbo].[insertar_COBERTURA]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertar_COBERTURA]

@Nombre varchar(max)


as 
if exists (SELECT Nombre from COBERTURA where Nombre = @Nombre  )



begin
RAISERROR ('YA EXISTE REGISTRO, POR FAVOR INGRESE DE NUEVO', 16,1)
end
else 
begin

insert into COBERTURA 
values (@Nombre)

end



GO
/****** Object:  StoredProcedure [dbo].[insertar_compra]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_compra]
@idproveedor int,
@fecha_compra dateTIME,
@Total_a_pagar numeric(18,2),
@moneda as varchar(50),

@estado as varchar(50),
@Id_series as int,
@ndocumento as varchar(50),

@igv  as numeric(18,2)
,@Tipo_de_pago as varchar(50)
as begin
if exists (SELECT N_Documento from Compra where N_Documento = @ndocumento  )
RAISERROR ('YA EXISTE UN COMPROBANTE DE COMPRA CON ESE NUMERO, POR FAVOR INGRESE DE NUEVO', 16,1)

ELSE
BEGIN
insert into Compra values 
(@idproveedor ,
@fecha_compra ,
@Total_a_pagar ,
@moneda ,

@estado ,
@Id_series ,
@ndocumento,

@igv  
,@Tipo_de_pago )
end
END



GO
/****** Object:  StoredProcedure [dbo].[insertar_COMPRAOKA]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[insertar_Conceptos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertar_Conceptos]
@Descripcion varchar(50)
as 


insert into CONCEPTOS 
values ( 

@Descripcion 
)


GO
/****** Object:  StoredProcedure [dbo].[insertar_CONDICIONES_DE_VENTA_FRACCIONAMIENTO]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  procedure [dbo].[insertar_CONDICIONES_DE_VENTA_FRACCIONAMIENTO]
@ideventa int,
           @Descripcion varchar(50)
		  
           		
 AS BEGIN
if EXISTS (SELECT Descripcion FROM CONDICIONES_DE_VENTA_FRACCIONAMIENTO  where Descripcion = @Descripcion AND Id_venta=@ideventa  )
RAISERROR ('YA EXISTE ESTA CONDICION, POR FAVOR INGRESE DE NUEVO', 16,1)
else
BEGIN

insert into CONDICIONES_DE_VENTA_FRACCIONAMIENTO  values 
            (@ideventa ,
           @Descripcion        )

END
END



GO
/****** Object:  StoredProcedure [dbo].[insertar_CONEXION]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_CONEXION]

@Data_source_remoto varchar(max)
as
insert into CONEXION  values (@Data_source_remoto)






GO
/****** Object:  StoredProcedure [dbo].[insertar_Control_de_asistencia_ordende_de_produccion]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_Control_de_asistencia_ordende_de_produccion]
@IdControl_de_OrdenesProduccion int output ,
@Id_Orden_Produccion int,
@Id_Personal int,
@Fecha_de_Entrada datetime,
@Fecha_de_Salida datetime

as
insert into  Control_de_asistencia_ordende_de_produccion (Id_Orden_Produccion,Id_Personal,
Fecha_de_Entrada,Fecha_de_Salida)
values (@Id_Orden_Produccion,@Id_Personal,@Fecha_de_Entrada,@Fecha_de_Salida)




GO
/****** Object:  StoredProcedure [dbo].[insertar_control_de_cobros]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  procedure [dbo].[insertar_control_de_cobros]

         
            @monto as numeric(18,2) ,
			@Concepto varchar(MAX) ,
			 @Id_venta int    	
as

insert into CONTROL_DE_COBROS  values 
            (
        
            @monto,
			@Concepto ,
           
		    @Id_venta )

GO
/****** Object:  StoredProcedure [dbo].[insertar_control_de_cobrosx]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  procedure [dbo].[insertar_control_de_cobrosx]

         
            @monto as numeric(18,2)      ,
			@Concepto as varchar(max)  ,  	
@idcliente int,
@Fecha_de_pago date,
@Saldo  as numeric(18,2)
as
insert into CONTROL_DE_COBROSX   values 
            ( 
        
            @monto,
			@Concepto,
@idcliente,
        @Fecha_de_pago  ,@Saldo )

GO
/****** Object:  StoredProcedure [dbo].[insertar_CONTROL_DE_DOCUMENTOS_QUE_SE_ENTREGAN_FRACCIONAMIENTO_COTIZACION]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  procedure [dbo].[insertar_CONTROL_DE_DOCUMENTOS_QUE_SE_ENTREGAN_FRACCIONAMIENTO_COTIZACION]

     @Id_documentos_que_se_entregan_fraccionamiento INT,
	 @ideventa int

		           		
 AS 
insert into CONTROL_DE_DOCUMENTOS_QUE_SE_ENTREGAN_FRACCIONAMIENTO_COTIZACION  values 
            ( 
     @Id_documentos_que_se_entregan_fraccionamiento,@ideventa)



GO
/****** Object:  StoredProcedure [dbo].[insertar_control_de_pagos_a_proveedores]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  procedure [dbo].[insertar_control_de_pagos_a_proveedores]
 @monto as numeric(18,2) ,
 @Id_compra int  ,
			@Concepto varchar(50) 
			  
as

insert into CONTROL_DE_PAGOS_A_PROVEEDORES  values 
            ( @monto ,
 @Id_compra ,

			@Concepto  
			  
            )


GO
/****** Object:  StoredProcedure [dbo].[insertar_control_de_pagos_a_proveedoresx]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  procedure [dbo].[insertar_control_de_pagos_a_proveedoresx]

         
            @monto as numeric(18,2)  ,
			@Concepto as varchar(max)  ,   
			   @idproveedor int   	
as

insert into CONTROL_DE_PAGOS_A_PROVEEDORES  values 
            (
        
            @monto,
			@Concepto ,
@idproveedor 
            )

GO
/****** Object:  StoredProcedure [dbo].[insertar_Cuenta_corriente_para_operaciones]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertar_Cuenta_corriente_para_operaciones]
@Id_cuenta_bancaria INT,

@Numero_documento varchar(50),
@Id_grupo_concepto_gasto int,
@Ingreso numeric(18,2),
@Egreso numeric(18,2),
@Id_usuario int,
@fecha as date

as 


insert into Cuenta_corriente_para_operaciones 
values (@Id_cuenta_bancaria ,

@Numero_documento ,
@Id_grupo_concepto_gasto,
@Ingreso ,
@Egreso ,
@Id_usuario ,
@fecha   )





GO
/****** Object:  StoredProcedure [dbo].[insertar_CUENTAS_A_ABONAR_PARA_COTIZACIONES]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_CUENTAS_A_ABONAR_PARA_COTIZACIONES]
                      @Id_venta INT,
           @Id_cuenta_bancaria INT
AS

	INSERT INTO CUENTAS_A_ABONAR_PARA_COTIZACIONES
     VALUES
		    (  @Id_venta ,
           @Id_cuenta_bancaria 
		 )



GO
/****** Object:  StoredProcedure [dbo].[insertar_Cuentas_corrientes_bancos_datos_generales]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  procedure [dbo].[insertar_Cuentas_corrientes_bancos_datos_generales]
@Titular_de_la_cuenta varchar(50),        
            @Id_Banco as INT , 
			@Numero_Cuenta_corriente varchar(max),        
            @Saldo as numeric(18,2) ,
			@Moneda as varchar(50)
			        	
AS BEGIN
if EXISTS (SELECT Numero_Cuenta_corriente FROM Cuentas_corrientes_bancos_datos_generales  where Numero_Cuenta_corriente = @Numero_Cuenta_corriente )
RAISERROR ('YA EXISTE ESTE NUMERO DE CUENTA, POR FAVOR INGRESE DE NUEVO', 16,1)
else
BEGIN

insert into Cuentas_corrientes_bancos_datos_generales  values 
            (@Titular_de_la_cuenta ,        
            @Id_Banco  , 
			@Numero_Cuenta_corriente ,        
            @Saldo,
			@Moneda 
            )


			END
			END

GO
/****** Object:  StoredProcedure [dbo].[insertar_DESCRIPCION_DE_BANCO]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  procedure [dbo].[insertar_DESCRIPCION_DE_BANCO]
@Descripcion varchar(MAX)			        	
AS BEGIN
if EXISTS (SELECT Descripcion FROM BANCOS  where Descripcion = @Descripcion )
RAISERROR ('YA EXISTE ESTE NUMERO DE CUENTA, POR FAVOR INGRESE DE NUEVO', 16,1)
else
BEGIN

insert into BANCOS  values 
            (@Descripcion
            )


			END
			END
			

GO
/****** Object:  StoredProcedure [dbo].[insertar_Designacion_de_rutas_A_VENDEDORES]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertar_Designacion_de_rutas_A_VENDEDORES]

@Id_ruta INT,
@Id_usuario AS INT,
@Fecha as date


as 
INSERt into Designacion_de_rutas 
values (@Id_ruta ,
@Id_usuario,
 @Fecha )

GO
/****** Object:  StoredProcedure [dbo].[insertar_Designacion_Personal_Para_ordenesdeproduccion]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_Designacion_Personal_Para_ordenesdeproduccion]
@Id_Personal_para_ordenesProduccion int output ,
@Id_Orden_de_Produccion int,
@Id_Personal int
as
insert into Designacion_Personal_Para_ordenesdeproduccion (Id_Orden_de_Produccion,Id_Personal)
values (@Id_Orden_de_Produccion,@Id_Personal)





GO
/****** Object:  StoredProcedure [dbo].[insertar_DESPACHO_DE_PEDIDO]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  procedure [dbo].[insertar_DESPACHO_DE_PEDIDO]
           @Id_cliente INT,
           @Id_lotea INT,
            @Monto_total numeric(18, 2),
            @Descuento numeric(18, 2),
            @Total_Impuestos numeric(18, 2),
            @Estado_de_pedido varchar(50),
            @Facturado varchar(50),
            @Numero_de_factura varchar(50),      
            @Pagado varchar(50)
          
		
as

insert into DESPACHO_DE_PEDIDOS
  values 
            (  @Id_cliente ,
           @Id_lotea ,
            @Monto_total ,
            @Descuento ,
            @Total_Impuestos ,
            @Estado_de_pedido ,
            @Facturado ,
            @Numero_de_factura ,      
            @Pagado 
            )





GO
/****** Object:  StoredProcedure [dbo].[insertar_destinos_almacen]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_destinos_almacen]

@Destino_Almacen varchar(50),
@Direccion varchar(50)


as

insert into Almacen_padre_prod_terminado

values (@Destino_Almacen ,
@Direccion  )


GO
/****** Object:  StoredProcedure [dbo].[insertar_detalle_almacen_product_terminado]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertar_detalle_almacen_product_terminado]
@Id_almacen_padre_prod_terminado int,
@Id_presentacionfraccionada as int,

@Estado as  varchar(50),

@Fecha_de_produccion AS DATE,
@Fecha_de_vencimiento AS DATE,
@Numero_de_lote as varchar(50),
@Observacion as varchar(50),
@Fecha_de_observacion as datetime
as

insert into Almacen_producto_terminados  values 
(@Id_almacen_padre_prod_terminado ,
@Id_presentacionfraccionada ,

@Estado ,

@Fecha_de_produccion ,
@Fecha_de_vencimiento ,
@Numero_de_lote ,
@Observacion ,
@Fecha_de_observacion )


GO
/****** Object:  StoredProcedure [dbo].[insertar_DETALLE_cierre_de_caja]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertar_DETALLE_cierre_de_caja]	
	@fechaini datetime,
	 @fechafin datetime,
	 @fechacierre datetime, 
	  @ingresos numeric(18,2), 
    @egresos numeric(18,2),
	@saldo numeric(18,2),
	@idusuario int,
	 @totalcaluclado numeric(18,2),
	  @totalreal numeric(18,2), 
	 
	 @estado as varchar(50),
	 @diferencia as numeric(18,2)	,
	 @idcierrepadre as int   
  AS BEGIN

if EXISTS (SELECT Estado FROM MOVIMIENTOCAJACIERRE 
 where  MOVIMIENTOCAJACIERRE.Estado='CAJA APERTURADA')
RAISERROR ('Ya Fue Iniciado el Turno de esta Caja', 16,1)
else
BEGIN
    INSERT INTO MOVIMIENTOCAJACIERRE values 
	(@fechaini ,
	 @fechafin ,
	 @fechacierre , 
	  @ingresos , 
    @egresos ,
	@saldo ,
	@idusuario ,
	 @totalcaluclado ,
	  @totalreal , 
	
	 @estado ,
	 @diferencia ,
	 @idcierrepadre )


	 end
	 end

GO
/****** Object:  StoredProcedure [dbo].[insertar_DETALLE_CONTROL_DE_COBROS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  procedure [dbo].[insertar_DETALLE_CONTROL_DE_COBROS]

@Pago_realizado as numeric(18,2),
@Fecha_que_pago as datetime,
@Tipo_de_cobro    as varchar(50) ,
@Detalle as varchar(max)  ,
@idcliente int   
  ,@Id_usuario int  ,
  @Id_caja int        	
as

insert into DETALLE_CONTROL_DE_COBROS  values 
            (
@Pago_realizado ,
@Fecha_que_pago ,
           @Tipo_de_cobro,
		   @Detalle ,@idcliente,@Id_usuario ,@Id_caja  )

GO
/****** Object:  StoredProcedure [dbo].[insertar_DETALLE_CONTROL_DE_COBROSX]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  procedure [dbo].[insertar_DETALLE_CONTROL_DE_COBROSX]
@Id_control_de_cobros int,
@Pago_realizado as numeric(18,2),
@Fecha_que_pago as datetime,
@Tipo_de_cobro    as varchar(50)      
            	
as

insert into DETALLE_CONTROL_DE_COBROSX  values 
            (@Id_control_de_cobros ,
@Pago_realizado ,
@Fecha_que_pago ,
           @Tipo_de_cobro )

GO
/****** Object:  StoredProcedure [dbo].[insertar_DETALLE_CONTROL_DE_pagos_de_proveedores]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  procedure [dbo].[insertar_DETALLE_CONTROL_DE_pagos_de_proveedores]
@Id_control_de_cobros int,
@Pago_realizado as numeric(18,2),
@Fecha_que_pago as datetime
,
@Tipo_de_cobro    as varchar(50)              
            	
as

insert into DETALLE_DE_PAGO_A_PROVEEDORES  values 
            (@Id_control_de_cobros ,
@Pago_realizado ,
@Fecha_que_pago ,
@Tipo_de_cobro
            )


GO
/****** Object:  StoredProcedure [dbo].[insertar_DETALLE_CONTROL_DE_pagos_de_proveedoresX]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  procedure [dbo].[insertar_DETALLE_CONTROL_DE_pagos_de_proveedoresX]
@Id_control_de_cobros int,
@Pago_realizado as numeric(18,2),
@Fecha_que_pago as datetime
,
@Tipo_de_cobro    as varchar(50)              
            	
as

insert into DETALLE_DE_PAGO_A_PROVEEDORESX  values 
            (@Id_control_de_cobros ,
@Pago_realizado ,
@Fecha_que_pago ,
@Tipo_de_cobro
            )


GO
/****** Object:  StoredProcedure [dbo].[insertar_detalle_venta]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_detalle_venta]
@idventa as integer,
@Id_presentacionfraccionada as int,
@cantidad as numeric(18, 2),
@preciounitario as numeric(18, 2),
@moneda as varchar(50),

@unidades as varchar(50),
@Cantidad_mostrada as numeric(18,2),
@Estado as varchar(50),
@Descripcion varchar(50),
@Codigo varchar(50),
@Stock varchar(50),
@Se_vende_a VARCHAR(50),
@Usa_inventarios VARCHAR(50),
@Costo numeric(18,2)
as

 		   BEGIN
if EXISTS (SELECT Id_producto,idventa   FROM detalle_venta inner join Producto1 on Producto1.Id_Producto1=detalle_venta.Id_producto 
  where Producto1. Id_Producto1  = @Id_presentacionfraccionada AND idventa=@idventa  )

  
update detalle_venta set 
cantidad    =cantidad +@cantidad  , 
Cantidad_mostrada=Cantidad_mostrada+@Cantidad_mostrada
where Id_producto =@Id_presentacionfraccionada 


else
BEGIN

insert into detalle_venta 

 values (@idventa,@Id_presentacionfraccionada ,@cantidad,@preciounitario,@moneda,@unidades,@Cantidad_mostrada
,@Estado,@Descripcion,@Codigo,@Stock ,@Se_vende_a ,@Usa_inventarios,@Costo)


END
END

GO
/****** Object:  StoredProcedure [dbo].[insertar_detalle_venta_servicio]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_detalle_venta_servicio]
@idventa as integer,
@Id_presentacionfraccionada as int,
@cantidad as numeric(18,2),
@preciounitario as numeric(18,2),
@moneda as varchar(50),
@totalapagar as numeric(18, 2),
@unidades as varchar(50),
@Cantidad_mostrada as numeric(18,2)

as
if exists (SELECT Id_presentacion_fraccionamiento from Detalle_venta_de_servicios where idventa =@idventa and Id_presentacion_fraccionamiento=@Id_presentacionfraccionada )
begin
RAISERROR ('YA EXISTE UN PRODUCTO CON ESE CODIGO, POR FAVOR INGRESE DE NUEVO', 16,1)
end
else 

insert into Detalle_venta_de_servicios 
 values (@idventa,@Id_presentacionfraccionada ,@cantidad,@preciounitario,@moneda,@totalapagar,@unidades,@Cantidad_mostrada
)








GO
/****** Object:  StoredProcedure [dbo].[insertar_detallecompra]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_detallecompra]
@idcompra int,
@Id_presentacionfraccionada int,
@Precio_compra numeric(18,2),
@moneda as varchar(50),
@Cantidad numeric(18, 2),
@totalcompra as decimal(18,2),
@Unidad_de_medida as varchar(50),
@Cantidad_mostrada as numeric(18,2),
@Estado as varchar(50)
as


insert into Detalle_Compra 
Values (@idcompra ,
@Id_presentacionfraccionada ,
@Precio_compra ,
@moneda,
@Cantidad ,
@totalcompra,
@Unidad_de_medida,
@Cantidad_mostrada  ,@Estado)

GO
/****** Object:  StoredProcedure [dbo].[insertar_DOCUMENTOS_QUE_SE_ENTREGAN_FRACCIONAMIENTO_COTIZACION]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  procedure [dbo].[insertar_DOCUMENTOS_QUE_SE_ENTREGAN_FRACCIONAMIENTO_COTIZACION]

@DESCRIPCION AS VARCHAR(MAX)

		           		
 AS 
insert into DOCUMENTOS_QUE_SE_ENTREGAN_FRACCIONAMIENTO_COTIZACION  values 
            ( 
     @DESCRIPCION )



GO
/****** Object:  StoredProcedure [dbo].[insertar_Empresa]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertar_Empresa]

@Nombre_Empresa  varchar(50),

@logo as image,
@Impuesto varchar(50),
@Porcentaje_impuesto numeric(18,0),
@Moneda varchar(50),

@Trabajas_con_impuestos VARCHAR(50),
@Modo_de_busqueda VARCHAR(50),
@Carpeta_para_copias_de_seguridad varchar(max),
@Correo_para_envio_de_reportes varchar(50),
@Ultima_fecha_de_copia_de_seguridad varchar(50)
as 
 BEGIN
if EXISTS (SELECT Nombre_Empresa   FROM EMPRESA   where Nombre_Empresa  = @Nombre_Empresa   )
RAISERROR ('YA EXISTE UNA EMPRESA CON ESE NOMBRE, Ingrese un nombre diferente', 16,1)
else
BEGIN
insert into EMPRESA  
values (@Nombre_Empresa,@logo,@Impuesto,@Porcentaje_impuesto,@Moneda ,@Trabajas_con_impuestos,@Modo_de_busqueda,
@Carpeta_para_copias_de_seguridad,@Correo_para_envio_de_reportes,@Ultima_fecha_de_copia_de_seguridad)

END
END

GO
/****** Object:  StoredProcedure [dbo].[insertar_Equipos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_Equipos]

@Id_Equipo int,
@Id_Proceso int,
@Equipo varchar(50),
@Monto_de_Devaluacion decimal(18, 2)

as
insert into Equipos (Id_Proceso,Equipo,Monto_de_Devaluacion)
values (@Id_Proceso,@Equipo,@Monto_de_Devaluacion)




GO
/****** Object:  StoredProcedure [dbo].[Insertar_FORMATO_TICKET]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Insertar_FORMATO_TICKET]
@Id_empresa int,
      @Empresa_Ruc varchar(max),
           @Direccion varchar(max),
         
           @Provincia varchar(max),
           @Moneda_string varchar(max),
           @Agradecimiento varchar(max),
           @pagina_Web_Facebook varchar(max),
           @Extra varchar(max)
	   
    as

    INSERT INTO Ticket values 
	(  @Id_empresa,
	@Empresa_Ruc ,
           @Direccion ,
          
           @Provincia ,
           @Moneda_string ,
           @Agradecimiento ,
           @pagina_Web_Facebook ,
           @Extra  )
GO
/****** Object:  StoredProcedure [dbo].[insertar_FORMULACION_DE_PERSONAL_PARA_FRACCIONAMIENTO_DE_PRODUCTOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  procedure [dbo].[insertar_FORMULACION_DE_PERSONAL_PARA_FRACCIONAMIENTO_DE_PRODUCTOS]
@Id_personal int,
           @Cantidad numeric(18,0),
            @Costo numeric(18,2)
			
		
as

insert into FORMULACION_DE_PERSONAL_PARA_FRACCIONAMIENTO_DE_PRODUCTOS  values 
            (@Id_personal ,
           @Cantidad ,
            @Costo 
			
            )





GO
/****** Object:  StoredProcedure [dbo].[insertar_FORMULACION_padre_de_formulacion_de_personal_para_fraccionar_productos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  procedure [dbo].[insertar_FORMULACION_padre_de_formulacion_de_personal_para_fraccionar_productos]
@iddetalle_venta int,
           @Id_formulacion_de_personal int
as
insert into FORMULACION_padre_de_formulacion_de_personal_para_fraccionar_productos  values 
            (@iddetalle_venta,
           @Id_formulacion_de_personal
            )



GO
/****** Object:  StoredProcedure [dbo].[insertar_Formulacion_padre_de_formulaciones_fraccionamiento_de_productos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_Formulacion_padre_de_formulaciones_fraccionamiento_de_productos]
@iddetalle_venta as integer,
@Id_formulacion_Formulaciones_de_fraccionamiento_de_productos as int
as


insert into Formulacion_padre_de_formulaciones_fraccionamiento_de_productos 
 values (@iddetalle_venta,
 @Id_formulacion_Formulaciones_de_fraccionamiento_de_productos

)


GO
/****** Object:  StoredProcedure [dbo].[insertar_formulaciones_para_fraccionar_productos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertar_formulaciones_para_fraccionar_productos]
@Id_presentacionfraccionada int,

@Cantidad as numeric(18,2),

@Unidad as varchar(50),
@Costo as numeric (18,2)
as

insert into Formulaciones_de_fraccionamiento_de_productos  values (@Id_presentacionfraccionada,@Cantidad, @Unidad,@Costo)




GO
/****** Object:  StoredProcedure [dbo].[insertar_gasto]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[insertar_gasto_sin_comprobante]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertar_gasto_sin_comprobante]

@fecha datetime,
@Nro_Comprobante varchar(50),
@Tipo_de_Comprobante varchar(50),
@importe decimal(18,2),
@Descripcion varchar(500),
@Id_concepto int,
@Id_usuario int,
@TIPO VARCHAR(50),
@Id_caja int
as 

insert into GASTOSVARIOS 
values (@fecha,@Nro_Comprobante,@Tipo_de_Comprobante   , @importe,@Descripcion ,@Id_concepto,@Id_usuario,@TIPO,@Id_caja )





GO
/****** Object:  StoredProcedure [dbo].[insertar_GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  procedure [dbo].[insertar_GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS]
@Descripcion varchar(MAX),        
            @Gasto as VARCHAR(50) 
			        	
AS BEGIN
if EXISTS (SELECT Descripcion FROM GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS  where Descripcion = @Descripcion)
RAISERROR ('YA EXISTE ESTE CONCEPTO, POR FAVOR INGRESE DE NUEVO', 16,1)
else
BEGIN

insert into GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS  values 
            (@Descripcion ,        
            @Gasto 
			        	
            )


			END
			END
			

GO
/****** Object:  StoredProcedure [dbo].[insertar_guias_de_remision]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_guias_de_remision]
@Id_detalle_venta as integer,
@Punto_de_partida as varchar(max),
@Punto_de_llegada  as varchar(max),
@Fecha_de_inicio_del_traslado as date,
@Numero_de_guia as varchar(max),

@Estado as varchar(50),
@Peso_total as numeric(18,2)
,@Unidad_de_medida_fisica as varchar(50)
as

insert into GUIAS_DE_REMISION_OK 
values (@Id_detalle_venta ,
@Punto_de_partida ,
@Punto_de_llegada  ,
@Fecha_de_inicio_del_traslado ,
@Numero_de_guia,
@Estado ,
@Peso_total,
@Unidad_de_medida_fisica
)



GO
/****** Object:  StoredProcedure [dbo].[insertar_HORARIOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[insertar_HORARIOS]

           @Cargo varchar(50),
     @Horas_laborales_diarias numeric(18,1)
           ,@Costo_hora_normal numeric(18,2)
           ,@Costo_hora_extra numeric(18,2)
           ,@Horas_libres_diarias numeric(18,1)
           ,@lunes int
           ,@martes int
           ,@miercoles int
           ,@jueves int
           ,@viernes int
           ,@sabado int
           ,@domingo int
		   as
insert into HORARIOS  VALUES(@Cargo ,
           @Horas_laborales_diarias
           , @Costo_hora_normal
           , @Costo_hora_extra
           , @Horas_libres_diarias
           , @lunes
           , @martes
           , @miercoles
           , @jueves
           , @viernes
           , @sabado
           , @domingo)    

GO
/****** Object:  StoredProcedure [dbo].[insertar_ingreso]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[insertar_ingreso_sin_comprobante]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertar_ingreso_sin_comprobante]

@fecha datetime,

@observacion varchar(500),
@Nro_Comprobante varchar(50),

@Tipo_de_Comprobante varchar(50),

@importe decimal(18,2),
@estado as varchar(50),
@Id_concepto int
as 

insert into INGRESOSVARIOS (Estado,Fecha_del_Gasto ,Id_concepto,Importe, Observacion,Nro_Comprobante,Tipo_de_Comprobante)
values (@estado,@fecha,@Id_concepto   , @importe,@observacion ,@Nro_Comprobante,@Tipo_de_Comprobante)





GO
/****** Object:  StoredProcedure [dbo].[insertar_KARDEX_SALIDA]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_KARDEX_SALIDA]                
           @Fecha datetime,
		    @Motivo varchar(200),			         
         
          @Cantidad as numeric(18,0)	,
	
	  @Id_producto int	,
	   @Id_usuario as int,	
	   @Tipo as varchar(50),
	   @Estado varchar(50)	,
	   
	    @Costo_unt numeric(18,2),
		@Habia numeric(18,2),
		@Hay numeric(18,2)
		  AS 
		   INSERT INTO KARDEX
     VALUES
		    (

        @Fecha ,
		    @Motivo ,			         
         
          @Cantidad 	,

	  @Id_producto 	,
	   @Id_usuario ,	
	   @Tipo,
			
		@Estado ,@Costo_unt, @Habia,@Hay )


GO
/****** Object:  StoredProcedure [dbo].[insertar_linea]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertar_linea]
@Linea varchar(50)

as

insert into linea  values (@Linea)



GO
/****** Object:  StoredProcedure [dbo].[insertar_Lotizacion]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertar_Lotizacion]
@Id_orden_de_produccion int,
@Numero_de_lote as int,
@Stock as numeric(18, 1),

@Fecha_de_produccion AS DATE,
@Fecha_de_vencimiento AS DATE,


@Estado as varchar(50)
as

insert into Lotizacion_en_almacen  values (@Id_orden_de_produccion ,
@Numero_de_lote ,
@Stock ,
 @Fecha_de_produccion ,
@Fecha_de_vencimiento 

,@Estado)



GO
/****** Object:  StoredProcedure [dbo].[Insertar_marcan]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Insertar_marcan]

	
	@s varchar(50),
	@f varchar(MAX)
    as
	
    INSERT INTO Marcan values 
	(@s,@f )

GO
/****** Object:  StoredProcedure [dbo].[insertar_materiales]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_materiales]                
           @Descripcion varchar(50),
           @id_Presentacion int,
       @id_unidad_de_medida int,         
           @Fecha_de_vencimiento date,       
		   @produccion as varchar(50),
		   @comprar varchar(50),	   
		   @Precio_de_compra as numeric(18, 0),
		   @Insumo as varchar(50),
		   @Materia_prima as varchar(50),
		   @Id_proveedor AS INT,
		@suministro as varchar(50)	,
		@estado as varchar(50)	 
		   AS BEGIN
if EXISTS (SELECT Descripcion  FROM materiales  where Descripcion  = @Descripcion and Id_Presentacion =@id_Presentacion  )
RAISERROR ('YA EXISTE UN PRODUCTO  CON ESTE NUMERO DE CODIGO INTERNO, POR FAVOR INGRESE DE NUEVO', 16,1)
else
BEGIN
		   INSERT INTO materiales
     VALUES
		    (   
           @Descripcion
           ,@id_Presentacion ,
		   @id_unidad_de_medida ,
         
         
         
           @Fecha_de_vencimiento
        
  
		      ,@produccion 
			  ,@comprar
		  
		    , @Precio_de_compra,@Insumo,@Materia_prima,@Id_proveedor,@suministro,@estado ) 

		    RAISERROR ('Registrado correctamente', 16,1)
END
END



GO
/****** Object:  StoredProcedure [dbo].[insertar_nombreservicio]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertar_nombreservicio]

@Servicio varchar(50),
@Avisar_antes_de varchar(50)




as 


insert into nombredeservicio (Servicio ,Avisar_antes_de)
values (@Servicio,@Avisar_antes_de    )





GO
/****** Object:  StoredProcedure [dbo].[insertar_orden_de_fraccionamiento]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_orden_de_fraccionamiento]

@Id_detalleventa int,
@Id_centro_de_produccion int,
@Numero_de_produccion varchar(50),
@Fecha_de_produccion date,
@Observaciones varchar(max),
@Fecha_de_observaciones date,
@Id_responsable_personal int
 AS BEGIN
if EXISTS (SELECT Id_detalleventa  FROM ORDEN_DE_FRACCIONAMINETO_DE_PRODUCTOS  where Id_detalleventa  = @Id_detalleventa   )
RAISERROR ('YA EXISTE UNA ORDEN DE PRODUCCION GUARDADA CON ESTOS DATOS; PUEDE REIIMPRIMIR EL DOCUMENTO', 16,1)
else
BEGIN

insert into ORDEN_DE_FRACCIONAMINETO_DE_PRODUCTOS

values (@Id_detalleventa ,
@Id_centro_de_produccion ,
@Numero_de_produccion ,
@Fecha_de_produccion ,
@Observaciones ,
@Fecha_de_observaciones ,
@Id_responsable_personal )

end
end


GO
/****** Object:  StoredProcedure [dbo].[insertar_permisos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  procedure [dbo].[insertar_permisos]
	@Id_Usuario  int ,
	@ventas int ,
	@aplicar_descuentos int ,
	@Devoluciones int ,
	@cobros int ,
	@Pagar int ,
	@clientes_proveedores int,
	@productos int,
	@invetarios_kardex int,
	@configuraciones int,
	@usuarios int,
	@reportes int
as
insert into permisos 
 values (	@Id_Usuario  ,
	@ventas,
	@aplicar_descuentos ,
	@Devoluciones  ,
	@cobros  ,
	@Pagar  ,
	@clientes_proveedores ,
	@productos,
	@invetarios_kardex ,
	@configuraciones ,
	@usuarios ,
	@reportes 

)


GO
/****** Object:  StoredProcedure [dbo].[insertar_personal]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_personal]

@Nombres varchar(50),
@Celular varchar(50),
@Email varchar(50),
@Direccion varchar(50),
@Area varchar(50),
@Cargo varchar(50),

@Modalidad varchar(50),
@Fecha_de_inicio_de_actividades date,
@Fecha_final_de_actividades date,
@Sueldo numeric(18,2),
@Nro_Carnet_de_salud varchar(50),
@Usuario_sunat AS VARCHAR(50),
@Clave_sunat as varchar(50),
@RUC AS VARCHAR(50)

as
insert into Personal 

values (@Nombres ,
@Celular ,
@Email ,
@Direccion ,
@Area ,
@Cargo ,
@Modalidad ,
@Fecha_de_inicio_de_actividades ,
@Fecha_final_de_actividades,
@Sueldo ,
@Nro_Carnet_de_salud,
@Usuario_sunat ,
@Clave_sunat ,
@RUC  )


GO
/****** Object:  StoredProcedure [dbo].[insertar_Precio_padre]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_Precio_padre]
                    
         
		   @Id_producto as int



as
	INSERT INTO Precio_padre
     VALUES
		    ( 
          
        @Id_producto
		 )



GO
/****** Object:  StoredProcedure [dbo].[insertar_Precios]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_Precios]
                      @Zona varchar(50),
           @Precio numeric(18,1),
		   @Id_presentacionfraccionada as int,
		   @Id_unidades as int

AS

	INSERT INTO Precios
     VALUES
		    ( @Zona ,
           @Precio,
		   @Id_presentacionfraccionada,
		   @Id_unidades 
		 )



GO
/****** Object:  StoredProcedure [dbo].[insertar_Presentacion]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_Presentacion]



                      @presentacion varchar(50),
          @Unidad_de_medida varchar(50),
		  @Cantidad_por_presentacion varchar(50)
		   AS BEGIN
--@SITUACION AS VARCHAR(500)

if EXISTS (SELECT Presentacion,Unidad_de_medida ,Cantidad_por_presentacion FROM Presentaciones   where Presentacion = @presentacion and Cantidad_por_presentacion=@Cantidad_por_presentacion and Unidad_de_medida=@Unidad_de_medida )
RAISERROR ('YA EXISTE UNA PRESENTACION COMO LA DESCRITA, POR FAVOR INGRESE DE NUEVO', 16,1)
else
BEGIN
		   INSERT INTO Presentaciones
     VALUES

		    (@presentacion,@Unidad_de_medida,@Cantidad_por_presentacion 
           )
		    RAISERROR ('Registrado correctamente', 16,1)
END
END




GO
/****** Object:  StoredProcedure [dbo].[insertar_presentaciones_fraccionadas]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertar_presentaciones_fraccionadas]
@id_presentaciones as int,
@id_producto as int,

@Stock as numeric(18,2)	,

@Precio_de_compra as numeric(18,2),

@Fecha_de_vencimiento VARCHAR(50),
@Precio_de_venta_unitario numeric(18,2),
@Id_unidad int,
@Precio_de_venta_por_presentacion numeric(18,2),
@Ubicacion varchar(max),
@Se_vende_a varchar(50)
AS BEGIN
if EXISTS (SELECT Id_producto ,Id_presentacionfraccionada  FROM Presentaciones_fraccionadas  where Id_producto  = @id_producto and
Id_presentacion =@id_presentaciones   )
RAISERROR ('YA EXISTE UN PRODUCTO  CON ESTE NOMBRE, POR FAVOR INGRESE UNO NUEVO', 16,1)
else
BEGIN
insert into Presentaciones_fraccionadas  values 
            (@id_presentaciones,
			@id_producto
			
			
			,@Stock ,
			
			@Precio_de_compra,
			
@Fecha_de_vencimiento,
@Precio_de_venta_unitario ,
@Id_unidad ,
@Precio_de_venta_por_presentacion ,
@Ubicacion
          ,@Se_vende_a  )


			end
			end
GO
/****** Object:  StoredProcedure [dbo].[insertar_presentaciones_fraccionadas_fraccionamiento]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_presentaciones_fraccionadas_fraccionamiento]                
           @Id_servicio int,
		   @Id_presentacion int,
		   @Activo varchar(50)
	as	   
		   INSERT INTO Presentaciones_fraccionadas_fraccionamiento
     VALUES
		    (

             @Id_servicio ,
		   @Id_presentacion ,
		   @Activo 
  
         
         )


GO
/****** Object:  StoredProcedure [dbo].[insertar_procesos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertar_procesos]
@proceso varchar (50),
@Nro_horas as numeric(18,2),
@Nro_ciclos as INT,
@Id_Producto1 as int
as
begin
insert into Procesos  values (@proceso,@Nro_horas,@Nro_ciclos,@Id_Producto1  )
RAISERROR ('Registrado correctamente', 16,1)
END





GO
/****** Object:  StoredProcedure [dbo].[insertar_Producto]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_Producto]                
           @Descripcion varchar(50),
		    @Imagen varchar(50),			         
         
          @Linea as varchar(50)	,
		  @Usa_inventarios varchar(50),
		   @Stock varchar(50),
           @Precio_de_compra numeric(18,2),
           @Fecha_de_vencimiento varchar(50),
           @Precio_de_venta numeric(18,2),
           @Codigo varchar(50),
           @Se_vende_a varchar(50),
           @Impuesto varchar(50),
           @Stock_minimo numeric(18,2),
           @Precio_mayoreo numeric(18,2)
	
		   AS 
		   BEGIN
if EXISTS (SELECT Descripcion,Codigo  FROM Producto1  where Descripcion = @Descripcion OR Codigo=@Codigo  )
RAISERROR ('YA EXISTE UN PRODUCTO  CON ESTE NOMBRE/CODIGO, POR FAVOR INGRESE DE NUEVO/ SE GENERARA CODIGO AUTOMATICO', 16,1)
else
BEGIN
		   INSERT INTO Producto1
     VALUES
		    (

           @Descripcion
  
         
          
           ,@Imagen
           
          
		    
	
		  
		    ,@Linea 
		,@Usa_inventarios	,


		@Stock ,
           @Precio_de_compra ,
           @Fecha_de_vencimiento ,
           @Precio_de_venta ,
           @Codigo ,
           @Se_vende_a ,
           @Impuesto ,
           @Stock_minimo ,
           @Precio_mayoreo
		 )
		    --RAISERROR ('Registrado correctamente', 16,1)
END
END


GO
/****** Object:  StoredProcedure [dbo].[insertar_produsctos_a_almacen]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertar_produsctos_a_almacen]

@Id_almacen_padre_prod_terminado int,
@Id_presentacionfraccionada int,
@Estado varchar(50),
@Fecha_de_produccion date,
@Fecha_de_vencimiento date,
@Numero_de_lote varchar(50),
@Observacion as varchar(50),
@Fecha_de_observacion as datetime,
@Stock_minimo as numeric(18,2)

as 

insert into Almacen_producto_terminados 

values (@Id_almacen_padre_prod_terminado ,
@Id_presentacionfraccionada ,
@Estado ,
@Fecha_de_produccion ,
@Fecha_de_vencimiento ,
@Numero_de_lote ,
@Observacion ,
@Fecha_de_observacion ,
@Stock_minimo 
)



GO
/****** Object:  StoredProcedure [dbo].[insertar_proforma]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_proforma]
--@idproforma as integer,
@fecha as date,
@documento as varchar (50),
@estado as varchar(50),
@tototal  as decimal(18,2),
@fechavenc as date,
@usuario as varchar(50),
@cliente as varchar(150),
@numero_documento as nchar(20),
@idcliente as int

as
IF exists (SELECT Numero_Documento from PROFORMA where Numero_Documento=@numero_documento )
begin 
RAISERROR ('YA EXISTE UNA PROFORMA DE VENTA CON ESE CODIGO, POR FAVOR INGRESE DE NUEVO', 16,1)
END
ELSE

insert into PROFORMA(fecha_Registro,documento,estado ,total ,fechavencimiento ,usuario ,cliente,idclientev,Numero_Documento )
values (@fecha,@documento,@estado  ,@tototal,@fecha  ,@usuario   ,@cliente,@idcliente  ,@numero_documento   )





GO
/****** Object:  StoredProcedure [dbo].[insertar_Programacion_de_fraccionamiento_de_productos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_Programacion_de_fraccionamiento_de_productos]
                      @Actividad varchar(max),
    @Id_detalle_venta as int,
@Id_turno_programado int,
   @Fecha_programada as date ,
   @Fecha_de_fin as date,
   @Hora_inicio as varchar(50),
   @Hora_fin as varchar(50)
	
		 
	
		   

AS

	INSERT INTO PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES
     VALUES
		    (   @Actividad ,
    @Id_detalle_venta,
@Id_turno_programado ,
   @Fecha_programada ,
   @Fecha_de_fin,
   @Hora_inicio ,
   @Hora_fin 
	
		 
		 )


GO
/****** Object:  StoredProcedure [dbo].[insertar_proveedor]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  procedure [dbo].[insertar_proveedor]
@razon_social varchar (100),

@direccion varchar(150),
@telefono int,
@porcentaje nchar(10),
@resta as decimal(18,2),
@montototal  as decimal(18,2),
@pagoenpartes as decimal(18,2),
@fechapagoenpartes as datetime

as
insert into proveedores(Razón_social ,Dirección ,Telefono,Porcentaje_de_IGB_que_Aplica,Monto_Total,Resta,Fecha_que_Pago_en_partes,Pago_en_partes  ) 
values (@razon_social,@direccion,@telefono ,@porcentaje,@montototal ,@resta,@fechapagoenpartes,@pagoenpartes )




GO
/****** Object:  StoredProcedure [dbo].[insertar_RESULTADO_DE_FRACCIONAMIENTO_DE_PRODUCTOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertar_RESULTADO_DE_FRACCIONAMIENTO_DE_PRODUCTOS]
@Id_detalle_de_venta int,
@Cantidad numeric(18,2),
@Unidad_de_medida as varchar(50),
@Fecha_de_produccion date,
@Fecha_de_vencimiento date,
@Numero_de_lote as varchar (50),

@Id_almacen int,
@Doc_referencia as varchar (50)


 AS
insert into RESULTADO_DE_FRACCIONAMIENTO_DE_PRODUCTOS  values (
@Id_detalle_de_venta ,
@Cantidad ,
@Unidad_de_medida ,
@Fecha_de_produccion ,
@Fecha_de_vencimiento,
@Numero_de_lote ,

@Id_almacen,
@Doc_referencia  )



GO
/****** Object:  StoredProcedure [dbo].[insertar_RUTAS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertar_RUTAS]

@Codigo varchar(max),
@Nombre varchar(max),
@Norte varchar(max),
@Sur varchar(max),
@Este varchar(max),
@Oeste varchar(max),
@Total_point varchar(max),
@Id_covertura INT

as 
INSERt into RUTAS 
values (@Codigo ,
@Nombre ,
@Norte ,
@Sur ,
@Este ,
@Oeste,
@Total_point ,
@Id_covertura )




GO
/****** Object:  StoredProcedure [dbo].[insertar_saldo]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_saldo]
@idcliente as integer,
@resta as decimal(18,2),
@montototal  as decimal(18,2),
@pagoenpartes as decimal(18,2),
@fechapagoenpartes as datetime


as

insert into Saldo (Monto_Total,Resta,Fecha_que_Pago_en_partes,Pago_en_partes)
values (@montototal ,@resta,@fechapagoenpartes,@pagoenpartes    )




GO
/****** Object:  StoredProcedure [dbo].[insertar_Serializacion]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertar_Serializacion]

@Serie varchar (50),
@numeroinicio as varchar (50),
@numerofin as varchar (50),
@Destino as varchar(50),
@Id_tipodoc varchar(50)
as BEGIN
if EXISTS (SELECT Id_tipodoc  FROM Serializacion  where  Id_tipodoc= @Id_tipodoc )
RAISERROR ('YA EXISTE ESTE COMPROBANTE INGRESE UNO NUEVO', 16,1)
else
BEGIN
insert into Serializacion  values (@Serie ,
@numeroinicio ,
@numerofin,@Destino ,@Id_tipodoc )

END
END
GO
/****** Object:  StoredProcedure [dbo].[insertar_servicios_de_fraccionamiento]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_servicios_de_fraccionamiento]                
           @Descripcion varchar(50)
		   
		   AS BEGIN
if EXISTS (SELECT Descripcion FROM Servicio_de_fraccionamiento  where Descripcion = @Descripcion  )
RAISERROR ('YA EXISTE UN SERVICIO CON ESTE NUMERO DE CODIGO INTERNO, POR FAVOR INGRESE DE NUEVO', 16,1)
else
BEGIN
		   INSERT INTO Servicio_de_fraccionamiento
     VALUES
		    (

           @Descripcion
  
         
         )
		    --RAISERROR ('Registrado correctamente', 16,1)
END
END

GO
/****** Object:  StoredProcedure [dbo].[insertar_tipo_de_producto]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_tipo_de_producto]


@descripcion varchar(50),
@Ventas varchar(50),
@Compras varchar(50),
@Almacen varchar(50),
@Puede_tener_formulaciones varchar(50)  


as

insert into Tipos_De_productos

values (
@descripcion ,
@Ventas,
@Compras ,
@Almacen ,
@Puede_tener_formulaciones     )



GO
/****** Object:  StoredProcedure [dbo].[insertar_tipodoc]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertar_tipodoc]
@tipodoc varchar (50),
@descripcion as varchar (50),
@Ventas as varchar (50),
@Compras as varchar (50),
@Accion_en_stock as varchar (50)
 AS BEGIN
if EXISTS (SELECT Tipo_de_documento  FROM Tipo_de_documento   where Tipo_de_documento  = @tipodoc)
RAISERROR ('YA EXISTE UN DOCUMENTO  CON ESTE NOMBRE , POR FAVOR INGRESE DE NUEVO', 16,1)
else
BEGIN
insert into Tipo_de_documento  values (@tipodoc ,
@descripcion,
@Ventas ,
@Compras ,
@Accion_en_stock )
END
END


GO
/****** Object:  StoredProcedure [dbo].[insertar_TURNO]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertar_TURNO]
@Desde time(7),
@Hasta time(7),
@Descripcion as varchar (50),
@Duracion_en_horas as varchar(50)
 AS
insert into Turno  values (
@Desde ,
@Hasta ,
@Descripcion ,
@Duracion_en_horas)



GO
/****** Object:  StoredProcedure [dbo].[INSERTAR_TURNOS_PLANIFICADOS_fecha_inicial]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[INSERTAR_TURNOS_PLANIFICADOS_fecha_inicial]	
	@Id_turno_inicial INT,
	@Fecha_planificada_inicial DATE,

	@Id_detalle_venta AS INT	,
	@idpersonal as int	 	,
	@Nro_horas_x_persona  varchar(50),
	@Hora_inicio as varchar(50),
	@Hora_fin as varchar(50)
    as
    INSERT INTO TURNOS_PLANIFICADOS_fecha_inicial values 
	(	@Id_turno_inicial ,
	@Fecha_planificada_inicial ,
	
	@Id_detalle_venta,
	@idpersonal,
	@Nro_horas_x_persona  ,
	@Hora_inicio ,
	@Hora_fin )


GO
/****** Object:  StoredProcedure [dbo].[INSERTAR_TURNOS_PLANIFICADOS_FINAL]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE procedure [dbo].[INSERTAR_TURNOS_PLANIFICADOS_FINAL]	
	@Id_turno_inicial INT,
	@Fecha_planificada_inicial DATE,

	@Id_detalle_venta AS INT,
	@idpersonal as int	,
	@Nro_horas_x_persona  varchar(50),
	@Hora_inicio as varchar(50),
	@Hora_fin as varchar(50)
	 		 	  
    as
    INSERT INTO TURNOS_PLANIFICADOS_FINAL values 
	(	@Id_turno_inicial ,
	@Fecha_planificada_inicial ,

	@Id_detalle_venta,
	@idpersonal,
	@Nro_horas_x_persona  ,
	@Hora_inicio ,
	@Hora_fin )


GO
/****** Object:  StoredProcedure [dbo].[insertar_unidades_de_medida]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_unidades_de_medida]



          @Unidad_de_medida varchar(50),
		  @Cantidad_por_unidad_de_medida varchar(50)
		   AS BEGIN
--@SITUACION AS VARCHAR(500) 

if EXISTS (SELECT Unidad_de_medida FROM Unidad_de_medida  where Unidad_de_medida = @Unidad_de_medida and Cantidad_por_unidad_de_medida=@Cantidad_por_unidad_de_medida)
RAISERROR ('YA EXISTE UNA PRESENTACION COMO LA DESCRITA, POR FAVOR INGRESE DE NUEVO', 16,1)
else
BEGIN
		   INSERT INTO Unidad_de_medida
     VALUES

		    (@Unidad_de_medida,@Cantidad_por_unidad_de_medida
           )
		    --RAISERROR ('Registrado correctamente', 16,1)
END
END




GO
/****** Object:  StoredProcedure [dbo].[insertar_usuario]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertar_usuario]
@nombres varchar(50),


@Login varchar(50),
@Password varchar(50)



as 
if EXISTS (SELECT Login FROM USUARIO2 where Login = @login )
RAISERROR ('YA EXISTE UN USUARIO CON ESE LOGIN, POR FAVOR INGRESE DE NUEVO', 16,1)
else
insert into USUARIO2 (Nombre_y_Apelllidos,  Login, Password ) 
values (@nombres, @Login, @Password )


GO
/****** Object:  StoredProcedure [dbo].[insertar_venta]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_venta]
@idcliente as integer,
@fecha_venta as datetime,

@nume_documento as varchar(50),
@montototal  as numeric(18,1),
@Tipo_de_pago as varchar(50),
@estado as varchar(50),
@IGV as numeric(18, 1),

@Comprobante as VARCHAR(50),
@id_usuario as int,
@Fecha_de_pago as varchar(50),
@ACCION VARCHAR(50),
@Saldo numeric(18,2),
@Pago_con numeric(18,2),
@Porcentaje_IGV numeric(18,2),
@Id_caja int
as 
insert into ventas 
values (@idcliente,@fecha_venta,@nume_documento ,@montototal ,@Tipo_de_pago,@estado ,@IGV 
,@Comprobante,@id_usuario,@Fecha_de_pago,@ACCION ,@Saldo,@Pago_con,@Porcentaje_IGV,@Id_caja)




GO
/****** Object:  StoredProcedure [dbo].[INVENTARIOS_GENERALES]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[INVENTARIOS_GENERALES]
as
SELECT        (dbo.Producto1.Descripcion+'-'+ dbo.Presentaciones.Presentacion + ' ('+DBO.Producto1.Marca +')') as Producto, 
                        DBO.Presentaciones_fraccionadas.Stock ,Presentaciones_fraccionadas.Almacen
FROM            dbo.Producto1 INNER JOIN
                        
                         dbo.Tipos_De_productos ON dbo.Producto1.Id_tipo = dbo.Tipos_De_productos.Id_tipo_de_producto INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.Producto1.Id_Producto1 = dbo.Presentaciones_fraccionadas.Id_producto INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion 

GO
/****** Object:  StoredProcedure [dbo].[KARDEX_DE_PRODUCTOS_egresos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[KARDEX_DE_PRODUCTOS_egresos]
as
SELECT        dbo.clientes.Nombre, ( dbo.Producto1.Descripcion + '-'+ dbo.Presentaciones.Presentacion) AS PRODUCTO, dbo.Compra.N_Documento, dbo.Detalle_Compra.Cantidad, 
                         dbo.Detalle_Compra.Cantidad_mostrada, dbo.Detalle_Compra.Unidad_de_medida,clientes.idclientev ,Presentaciones_fraccionadas.Id_presentacionfraccionada ,Producto1.Unidad_de_medida_para_inventarios  
						 ,dbo.Compra.Fecha_compra 

FROM            dbo.Compra INNER JOIN
                         dbo.clientes ON dbo.Compra.idproveedor = dbo.clientes.idclientev INNER JOIN
                         dbo.Detalle_Compra ON dbo.Compra.Cod_compra = dbo.Detalle_Compra.idcompra INNER JOIN
                         dbo.Presentaciones INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.Presentaciones.Id_Presentacion = dbo.Presentaciones_fraccionadas.Id_presentacion INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1 ON 
                         dbo.Detalle_Compra.Id_presentacionfraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada

GO
/****** Object:  StoredProcedure [dbo].[KARDEX_DE_PRODUCTOS_ingresos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[KARDEX_DE_PRODUCTOS_ingresos]
as
SELECT        dbo.ventas.fecha_venta, dbo.ventas.Numero_de_doc, dbo.clientes.Nombre, dbo.detalle_venta.Cantidad, dbo.detalle_venta.Unidad_de_medida, 
                        ( dbo.Producto1.Descripcion + '-'+ dbo.Presentaciones.Presentacion) AS PRODUCTO,clientes.idclientev ,Presentaciones_fraccionadas.Id_presentacionfraccionada,Producto1.Unidad_de_medida_para_inventarios  
FROM            dbo.ventas INNER JOIN
                         dbo.detalle_venta ON dbo.ventas.idventa = dbo.detalle_venta.idventa INNER JOIN
                         dbo.Presentaciones INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.Presentaciones.Id_Presentacion = dbo.Presentaciones_fraccionadas.Id_presentacion INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1 ON 
                         dbo.detalle_venta.Id_presentacionfraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada INNER JOIN
                         dbo.clientes ON dbo.ventas.idclientev = dbo.clientes.idclientev

GO
/****** Object:  StoredProcedure [dbo].[ListarCategorias]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarCategorias]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM Categoria
	ORDER BY nombrecategoria
END





GO
/****** Object:  StoredProcedure [dbo].[maxproductos_todo]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[maxproductos_todo]

as

declare @correcto int
 
 select @correcto=count(*) 
 FROM   dbo.Ordendeproduccion 



RETURN @correcto


GO
/****** Object:  StoredProcedure [dbo].[ModificarProducto]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- ALTER date: <ALTER Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ModificarProducto] 
	-- Add the parameters for the stored procedure here
	@IdProducto int, @Nombre varchar(50), @Detalle varchar(200),
	@Precio decimal(18,5), @Stock decimal(18,5), @idCategoria int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Producto
	SET Nombre=@Nombre, Detalle=@Detalle, Precio=@Precio, Stock=@Stock, idCategoria=@idCategoria
	WHERE IdProducto=@IdProducto
END







GO
/****** Object:  StoredProcedure [dbo].[mostrar_almacen]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_almacen]
as
Select * from Almacen_padre_prod_terminado 

GO
/****** Object:  StoredProcedure [dbo].[mostrar_almacen_producto_terminado_alimentado_de_stock_manual]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_almacen_producto_terminado_alimentado_de_stock_manual]
as
SELECT        dbo.Producto1.Id_Producto1, dbo.Producto1.Descripcion,
                         dbo.Almacen_padre_prod_terminado.Descripcion AS Almacen, dbo.Almacen_producto_terminados.Numero_de_lote, dbo.Almacen_producto_terminados.Fecha_de_produccion,
                         dbo.Almacen_producto_terminados.Fecha_de_vencimiento, dbo.Almacen_producto_terminados.Id_almacen_produc_terminado,dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada ,dbo.Presentaciones.Presentacion ,dbo.Presentaciones_fraccionadas.Stock
FROM          
                         dbo.Producto1 INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.Producto1.Id_Producto1 = dbo.Presentaciones_fraccionadas.Id_producto INNER JOIN
                         dbo.Almacen_padre_prod_terminado INNER JOIN
                         dbo.Almacen_producto_terminados ON 
                         dbo.Almacen_padre_prod_terminado.Id_almacen_padre_prod_terminado = dbo.Almacen_producto_terminados.Id_almacen_padre_prod_terminado ON 
                         dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada = dbo.Almacen_producto_terminados.Id_presentacionfraccionada INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion



GO
/****** Object:  StoredProcedure [dbo].[mostrar_alquiler]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_alquiler]
as
SELECT        Alquilerdehabitacion.IdAlquiler,Alquilerdehabitacion.Idcliente, Alquilerdehabitacion.Cliente, Alquilerdehabitacion.DNI, 
                         Alquilerdehabitacion.Total_a_pagar,Alquilerdehabitacion.Tipo_de_Pago,Alquilerdehabitacion.Pagando,Alquilerdehabitacion.Fecha_que_Pago, 
                        Alquilerdehabitacion.Resto,Alquilerdehabitacion.Fecha_de_entrada, Alquilerdehabitacion.Fecha_de_Salida, Alquilerdehabitacion.Fecha_de_pago, 
                       Alquilerdehabitacion.Tipo_Documento, Alquilerdehabitacion.Moneda,Alquilerdehabitacion.Estado,Alquilerdehabitacion.Garantia,Alquilerdehabitacion.Estado_Garantia
FROM           clientehotel INNER JOIN   Alquilerdehabitacion ON clientehotel.Idcliente = Alquilerdehabitacion.Idcliente order by Alquilerdehabitacion.IdAlquiler desc





GO
/****** Object:  StoredProcedure [dbo].[mostrar_APERTURAS_DE_CAJA_PADRE]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_APERTURAS_DE_CAJA_PADRE]
@Id_usuario int,
@Id_CAJA AS INT
as
SELECT       *
FROM        CIERRE_DE_CAJA_PADRE
                      inner join USUARIO2 on USUARIO2 .idUsuario=CIERRE_DE_CAJA_PADRE.Id_usuario 
	where  Estado='CAJA APERTURADA' AND CIERRE_DE_CAJA_PADRE .Id_caja=@Id_CAJA

GO
/****** Object:  StoredProcedure [dbo].[mostrar_APERTURAs_de_caja_para_cerrar_turno]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_APERTURAs_de_caja_para_cerrar_turno]

@idcierre AS INT
as
SELECT        dbo.MOVIMIENTOCAJACIERRE.*, dbo.USUARIO2.Nombre_y_Apelllidos
FROM            dbo.MOVIMIENTOCAJACIERRE INNER JOIN
                         dbo.USUARIO2 ON dbo.MOVIMIENTOCAJACIERRE.Id_usuario = dbo.USUARIO2.idUsuario
						  where Estado='CAJA APERTURADA' AND dbo.MOVIMIENTOCAJACIERRE.idcierrecaja =@idcierre 

GO
/****** Object:  StoredProcedure [dbo].[mostrar_APERTURAS_DE_CAJA_SEGUN_PARA_CONTROL_DE_ACCESO]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_APERTURAS_DE_CAJA_SEGUN_PARA_CONTROL_DE_ACCESO]
@Id_usuario int,
@IDCAJA AS INT
as
SELECT        dbo.MOVIMIENTOCAJACIERRE.*, dbo.USUARIO2.Nombre_y_Apelllidos
FROM            dbo.MOVIMIENTOCAJACIERRE INNER JOIN
                         dbo.USUARIO2 ON dbo.MOVIMIENTOCAJACIERRE.Id_usuario = dbo.USUARIO2.idUsuario
						  where Id_usuario =@Id_usuario and Estado='CAJA APERTURADA' AND Id_caja=@IDCAJA 
GO
/****** Object:  StoredProcedure [dbo].[mostrar_AREAS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_AREAS]
as
select * from AREAS






GO
/****** Object:  StoredProcedure [dbo].[mostrar_banco_a_abonar_para_cotizar_productos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_banco_a_abonar_para_cotizar_productos]

@idventa as int
as
SELECT        dbo.CUENTAS_A_ABONAR_PARA_COTIZACIONES.Id_venta, dbo.Cuentas_corrientes_bancos_datos_generales.Titular_de_la_cuenta, 
                         dbo.BANCOS .Descripcion , dbo.Cuentas_corrientes_bancos_datos_generales.Numero_Cuenta_corriente
FROM            dbo.CUENTAS_A_ABONAR_PARA_COTIZACIONES INNER JOIN
                         dbo.Cuentas_corrientes_bancos_datos_generales ON 
                         dbo.CUENTAS_A_ABONAR_PARA_COTIZACIONES.Id_cuenta_bancaria = dbo.Cuentas_corrientes_bancos_datos_generales.Id_cuenta_bancaria
						 inner join dbo.BANCOS on dbo.BANCOS.Id_nombre_de_bancos =Cuentas_corrientes_bancos_datos_generales.Id_Banco 
where dbo.CUENTAS_A_ABONAR_PARA_COTIZACIONES.Id_venta =@idventa 

GO
/****** Object:  StoredProcedure [dbo].[mostrar_bancos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_bancos]
as
select * from Cuentas_banco  order by Id_Letra desc





GO
/****** Object:  StoredProcedure [dbo].[Mostrar_Caja]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[mostrar_cajas]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_cajas]
as
select * from Caja order by Id_Caja desc

GO
/****** Object:  StoredProcedure [dbo].[mostrar_cajas_por_empresa]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_cajas_por_empresa]
@empresa varchar(50),
@ip varchar(50)
as
select Caja.Id_Caja ,Caja.Descripcion
from Caja 
GO
/****** Object:  StoredProcedure [dbo].[mostrar_cajas_por_empresa_por_serial]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrar_cajas_por_empresa_por_serial]



@serial varchar(50)

AS
SELECT Caja.Id_Caja ,Caja.Descripcion ,
Serial_PC from Caja
 where Caja.Serial_PC = @serial 

GO
/****** Object:  StoredProcedure [dbo].[mostrar_cajas_por_empresa_sin_ip]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_cajas_por_empresa_sin_ip]

as
select Caja.Id_Caja ,Caja.Descripcion from Caja 
GO
/****** Object:  StoredProcedure [dbo].[MOSTRAR_cajas_por_serial]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[MOSTRAR_cajas_por_serial]

@serial varchar(50)

AS
SELECT Descripcion from Caja
 where Caja.Serial_PC = @serial 
GO
/****** Object:  StoredProcedure [dbo].[mostrar_cajas_por_Serial_de_DiscoDuro]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_cajas_por_Serial_de_DiscoDuro]
@Serial as varchar(50)
as
select Caja.Id_Caja  ,Descripcion 
from Caja 
where caja.Serial_PC =@Serial
GO
/****** Object:  StoredProcedure [dbo].[MOSTRAR_CANTIDAD_REAL_PRODUCIDA]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MOSTRAR_CANTIDAD_REAL_PRODUCIDA]
@iddetalle_venta as int
AS
select Cantidad  ,Id_detalle_de_venta 
 from RESULTADO_DE_FRACCIONAMIENTO_DE_PRODUCTOS  
 where Id_detalle_de_venta=@iddetalle_venta 

GO
/****** Object:  StoredProcedure [dbo].[mostrar_cargos_sin_repetir]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[mostrar_cargos_sin_repetir]

AS BEGIN
SET NOCOUNT ON;
SELECT DISTINCT  
      Cargo,Id_horarios
FROM           HORARIOS 
                       
end


GO
/****** Object:  StoredProcedure [dbo].[mostrar_categoria]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_categoria]
as
select * from categoria order by idcategoria desc






GO
/****** Object:  StoredProcedure [dbo].[MOSTRAR_CIERRE_DE_CAJA_PENDIENTE]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MOSTRAR_CIERRE_DE_CAJA_PENDIENTE]

@serial varchar(50)

AS
SELECT MOVIMIENTOCAJACIERRE.fechainicio,MOVIMIENTOCAJACIERRE.fechafin,caja.Id_Caja  FROM MOVIMIENTOCAJACIERRE inner join USUARIO2 on USUARIO2.idUsuario=MOVIMIENTOCAJACIERRE.Id_usuario
 inner join Caja on Caja.Id_Caja =MOVIMIENTOCAJACIERRE.Id_caja 
 where Caja.Serial_PC = @serial    AND MOVIMIENTOCAJACIERRE.Estado='CAJA APERTURADA' 
GO
/****** Object:  StoredProcedure [dbo].[mostrar_cliente]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_cliente]
as
SELECT        idclientev, Nombre, Direccion_para_factura as Direccion, Ruc,  movil as Celular, Cliente, Proveedor, 
                    clientes.Saldo ,     Estado as Activo
FROM            dbo.clientes 
WHERE clientes.Cliente='SI' order by Nombre  asc 


GO
/****** Object:  StoredProcedure [dbo].[mostrar_clientes_con_deuda]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[mostrar_COBROS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_COBROS]

as 
SELECT       * from ventas 
WHERE Estado ='DEUDA'

GO
/****** Object:  StoredProcedure [dbo].[mostrar_compra]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_compra]
as
select Compra.Cod_compra ,Compra.idproveedor , Compra.Fecha_compra ,Compra.Total_a_pagar ,Compra.Fecha_a_Pagar ,Compra .Moneda,Compra.Estado,Compra.N_Documento ,Compra.Tipo_Documento 

from proveedores INNER JOIN Compra ON proveedores.idproveedor=Compra.idproveedor order by Compra.Cod_compra desc





GO
/****** Object:  StoredProcedure [dbo].[mostrar_COMPRAS_realizadas_pendientes_de_RECEPCION]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_COMPRAS_realizadas_pendientes_de_RECEPCION]
as
SELECT        dbo.Compra.Cod_compra , dbo.clientes.Nombre as Cliente, dbo.Tipo_de_documento.Tipo_de_documento, dbo.Compra.N_Documento , dbo.Compra.Estado, dbo.Compra.Fecha_compra , 
                         dbo.Compra.Total_a_pagar ,dbo.Serializacion.Id_serializacion ,dbo.Compra.IGV ,dbo.Compra.Tipo_de_pago ,DBO.clientes.idclientev 
FROM            dbo.Compra INNER JOIN
                         dbo.clientes ON dbo.Compra.idproveedor  = dbo.clientes.idclientev INNER JOIN
                         dbo.Serializacion ON dbo.Compra.Id_series  = dbo.Serializacion.Id_serializacion INNER JOIN
                         dbo.Tipo_de_documento ON dbo.Serializacion.Id_tipodoc = dbo.Tipo_de_documento.Id_tipodoc
						INNER JOIN DBO.Detalle_Compra on dbo.Detalle_Compra.idcompra  =dbo.Compra.Cod_compra  
						 where dbo.Detalle_Compra.Estado='RECEPCION PENDIENTE'

GO
/****** Object:  StoredProcedure [dbo].[MOSTRAR_CONCEPTOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MOSTRAR_CONCEPTOS]
AS
SELECT        dbo.CONCEPTOS.Id_concepto, dbo.CONCEPTOS.Descripcion AS Concepto, dbo.GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS.Descripcion AS Grupo, 
                         dbo.GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS.Gasto,GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS.Id_grupo_concepto_gasto
FROM            dbo.CONCEPTOS INNER JOIN
                         dbo.GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS ON 
                         dbo.CONCEPTOS.Id_grupo = dbo.GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS.Id_grupo_concepto_gasto

GO
/****** Object:  StoredProcedure [dbo].[MOSTRAR_CONCEPTOS_EN_GASTOS_VARIOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MOSTRAR_CONCEPTOS_EN_GASTOS_VARIOS]
AS
SELECT        dbo.CONCEPTOS.Id_concepto, dbo.CONCEPTOS.Descripcion AS Concepto 
                      
FROM            dbo.CONCEPTOS 
						
						
GO
/****** Object:  StoredProcedure [dbo].[MOSTRAR_CONCEPTOS_EN_INGRESOS_VARIOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MOSTRAR_CONCEPTOS_EN_INGRESOS_VARIOS]
AS
SELECT        dbo.CONCEPTOS.Id_concepto, dbo.CONCEPTOS.Descripcion, dbo.GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS.Descripcion AS Grupo, 
                         dbo.GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS.Gasto,GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS.Id_grupo_concepto_gasto
FROM            dbo.CONCEPTOS INNER JOIN
                         dbo.GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS ON 
                         dbo.CONCEPTOS.Id_grupo = dbo.GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS.Id_grupo_concepto_gasto
						 WHERE Gasto='NO'
GO
/****** Object:  StoredProcedure [dbo].[MOSTRAR_CONCEPTOS_GASTOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MOSTRAR_CONCEPTOS_GASTOS]
AS
SELECT        dbo.CONCEPTOS.Id_concepto, dbo.CONCEPTOS.Descripcion AS Concepto, dbo.GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS.Descripcion AS Grupo, 
                         dbo.GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS.Gasto,GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS.Id_grupo_concepto_gasto
FROM            dbo.CONCEPTOS INNER JOIN
                         dbo.GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS ON 
                         dbo.CONCEPTOS.Id_grupo = dbo.GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS.Id_grupo_concepto_gasto
						 where Gasto='SI'
GO
/****** Object:  StoredProcedure [dbo].[MOSTRAR_CONCEPTOS_INGRESOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MOSTRAR_CONCEPTOS_INGRESOS]
AS
SELECT        dbo.CONCEPTOS.Id_concepto, dbo.CONCEPTOS.Descripcion AS Concepto, dbo.GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS.Descripcion AS Grupo, 
                         dbo.GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS.Gasto,GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS.Id_grupo_concepto_gasto
FROM            dbo.CONCEPTOS INNER JOIN
                         dbo.GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS ON 
                         dbo.CONCEPTOS.Id_grupo = dbo.GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS.Id_grupo_concepto_gasto
						 where Gasto='NO'
GO
/****** Object:  StoredProcedure [dbo].[mostrar_condiciones_de_venta_para_cotizar_productos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_condiciones_de_venta_para_cotizar_productos]

@idventa as int
as
SELECT   * from    CONDICIONES_DE_VENTA_FRACCIONAMIENTO 
where dbo.CONDICIONES_DE_VENTA_FRACCIONAMIENTO .Id_venta =@idventa 

GO
/****** Object:  StoredProcedure [dbo].[mostrar_condiciones_de_venta_para_cotizar_servicios]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_condiciones_de_venta_para_cotizar_servicios]
@idventa as int
as
SELECT   * from    CONDICIONES_DE_VENTA_FRACCIONAMIENTO 
where dbo.CONDICIONES_DE_VENTA_FRACCIONAMIENTO .Id_venta =@idventa 

GO
/****** Object:  StoredProcedure [dbo].[mostrar_Control_de_asistencia_ordende_de_produccion]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_Control_de_asistencia_ordende_de_produccion]
as
select * from Control_de_asistencia_ordende_de_produccion




GO
/****** Object:  StoredProcedure [dbo].[mostrar_control_de_cobros_a_clientes_por_xmotivos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  procedure [dbo].[mostrar_control_de_cobros_a_clientes_por_xmotivos]
as
SELECT        dbo.CONTROL_DE_COBROSX.Id_control_de_cobros, dbo.clientes.Nombre, dbo.CONTROL_DE_COBROSX.Monto, dbo.CONTROL_DE_COBROSX.Concepto
FROM            dbo.CONTROL_DE_COBROSX INNER JOIN
                         dbo.clientes ON dbo.CONTROL_DE_COBROSX.Id_cliente = dbo.clientes.idclientev
						 WHERE DBO.clientes.Cliente='SI'
GO
/****** Object:  StoredProcedure [dbo].[mostrar_control_de_cobros_a_clientes_por_xmotivos_X_CLIENTE]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  procedure [dbo].[mostrar_control_de_cobros_a_clientes_por_xmotivos_X_CLIENTE]
@Id_cliente as int
as
SELECT        dbo.CONTROL_DE_COBROSX.Id_control_de_cobros, dbo.clientes.Nombre, dbo.CONTROL_DE_COBROSX.Monto, dbo.CONCEPTOS.Descripcion ,dbo.CONTROL_DE_COBROSX.Fecha_de_pago
,dbo.CONTROL_DE_COBROSX.Saldo
FROM            dbo.CONTROL_DE_COBROSX INNER JOIN
                         dbo.clientes ON dbo.CONTROL_DE_COBROSX.Id_cliente = dbo.clientes.idclientev
						 inner join dbo.CONCEPTOS on dbo.CONCEPTOS.Id_concepto  =dbo.CONTROL_DE_COBROSX.Id_concepto
						
						 WHERE DBO.clientes.Cliente='SI' AND dbo.clientes.idclientev=@Id_cliente  AND Saldo>0

GO
/****** Object:  StoredProcedure [dbo].[mostrar_control_de_cobros_a_PROVEEDORES_por_xmotivos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  procedure [dbo].[mostrar_control_de_cobros_a_PROVEEDORES_por_xmotivos]
as
SELECT        dbo.CONTROL_DE_PAGOS_A_PROVEEDORESX.Id_control_de_pagos , dbo.clientes.Nombre, dbo.CONTROL_DE_PAGOS_A_PROVEEDORESX.Monto, dbo.CONTROL_DE_PAGOS_A_PROVEEDORESX.Concepto
FROM            dbo.CONTROL_DE_PAGOS_A_PROVEEDORESX INNER JOIN
                         dbo.clientes ON dbo.CONTROL_DE_PAGOS_A_PROVEEDORESX.Id_proveedor  = dbo.clientes.idclientev
						 WHERE DBO.clientes.Proveedor='SI'
GO
/****** Object:  StoredProcedure [dbo].[mostrar_COTIZACIONES_CON_APROBACION_PENDIENTE]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[mostrar_COTIZACIONES_DE_PRODUCTOS_A_FRACCIONAR_APROBADAS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_COTIZACIONES_DE_PRODUCTOS_A_FRACCIONAR_APROBADAS]

as
SELECT        dbo.ventas.idventa,dbo.detalle_venta.iddetalle_venta , DBO.ventas.Numero_de_doc ,dbo.clientes.Nombre as Cliente, (dbo.Producto1.Descripcion +'-'+ dbo.Presentaciones.Presentacion) as Producto, (convert (varchar (50),dbo.detalle_venta.Cantidad_mostrada)+ '-'+ dbo.detalle_venta.Unidad_de_medida ) as Cant,dbo.detalle_venta.preciounitario AS Precio_UNIT, 
                         dbo.detalle_venta.Total_a_pagar, dbo.ventas.fecha_venta as Fecha_de_cotizacion, dbo.detalle_venta .Estado,dbo.detalle_venta.Id_presentacionfraccionada ,dbo.detalle_venta.cantidad
FROM            dbo.ventas INNER JOIN
                         dbo.detalle_venta ON dbo.ventas.idventa = dbo.detalle_venta.idventa INNER JOIN
                         dbo.clientes ON dbo.ventas.idclientev = dbo.clientes.idclientev INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.detalle_venta.Id_presentacionfraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1 INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion
				
					where detalle_venta .Estado ='DEUDA-ETAPA I' or detalle_venta .Estado ='PAGADO-ETAPA I'

GO
/****** Object:  StoredProcedure [dbo].[mostrar_COTIZACIONES_DE_PRODUCTOS_A_FRACCIONAR_APROBADAS_POR_CLIENTE]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_COTIZACIONES_DE_PRODUCTOS_A_FRACCIONAR_APROBADAS_POR_CLIENTE]
@letra VARCHAR(50)
as
SELECT        dbo.ventas.idventa,dbo.detalle_venta.iddetalle_venta , DBO.ventas.Numero_de_doc ,dbo.clientes.Nombre as Cliente, (dbo.Producto1.Descripcion +'-'+ dbo.Presentaciones.Presentacion) as Producto, (convert (varchar (50),dbo.detalle_venta.Cantidad_mostrada)+ '-'+ dbo.detalle_venta.Unidad_de_medida ) as Cant,dbo.detalle_venta.preciounitario AS Precio_UNIT, 
                         dbo.detalle_venta.Total_a_pagar, dbo.ventas.fecha_venta as Fecha_de_cotizacion, dbo.detalle_venta .Estado,dbo.detalle_venta.Id_presentacionfraccionada ,dbo.detalle_venta.cantidad
FROM            dbo.ventas INNER JOIN
                         dbo.detalle_venta ON dbo.ventas.idventa = dbo.detalle_venta.idventa INNER JOIN
                         dbo.clientes ON dbo.ventas.idclientev = dbo.clientes.idclientev INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.detalle_venta.Id_presentacionfraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1 INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion
				
					where dbo.clientes .Nombre    LIKE  '%' + @letra+'%' and detalle_venta .Estado ='DEUDA-ETAPA I' or detalle_venta .Estado ='PAGADO-ETAPA I'

GO
/****** Object:  StoredProcedure [dbo].[mostrar_COTIZACIONES_DE_PRODUCTOS_A_FRACCIONAR_APROBADAS_POR_NUMERO_DOC]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_COTIZACIONES_DE_PRODUCTOS_A_FRACCIONAR_APROBADAS_POR_NUMERO_DOC]
@letra VARCHAR(50)
as
SELECT        dbo.ventas.idventa,dbo.detalle_venta.iddetalle_venta , DBO.ventas.Numero_de_doc ,dbo.clientes.Nombre as Cliente, (dbo.Producto1.Descripcion +'-'+ dbo.Presentaciones.Presentacion) as Producto, (convert (varchar (50),dbo.detalle_venta.Cantidad_mostrada)+ '-'+ dbo.detalle_venta.Unidad_de_medida ) as Cant,dbo.detalle_venta.preciounitario AS Precio_UNIT, 
                         dbo.detalle_venta.Total_a_pagar, dbo.ventas.fecha_venta as Fecha_de_cotizacion, dbo.detalle_venta .Estado,dbo.detalle_venta.Id_presentacionfraccionada 
						 ,dbo.detalle_venta.cantidad
FROM            dbo.ventas INNER JOIN
                         dbo.detalle_venta ON dbo.ventas.idventa = dbo.detalle_venta.idventa INNER JOIN
                         dbo.clientes ON dbo.ventas.idclientev = dbo.clientes.idclientev INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.detalle_venta.Id_presentacionfraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1 INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion
				
					where dbo.ventas  .Numero_de_doc     LIKE  '%' + @letra+'%' and detalle_venta .Estado ='DEUDA-ETAPA I' or detalle_venta .Estado ='PAGADO-ETAPA I'

GO
/****** Object:  StoredProcedure [dbo].[mostrar_COTIZACIONES_DE_PRODUCTOS_A_FRACCIONAR_CON_APROBACION_PENDIENTE]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[mostrar_COTIZACIONES_DE_PRODUCTOS_A_FRACCIONAR_CON_APROBACION_PENDIENTE_x_cliente]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[mostrar_COTIZACIONES_DE_PRODUCTOS_A_FRACCIONAR_CON_APROBACION_PENDIENTE_x_numerode_doc]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[mostrar_COTIZACIONES_DE_PRODUCTOS_PRODUCCION_CONCLUIDA]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_COTIZACIONES_DE_PRODUCTOS_PRODUCCION_CONCLUIDA]
as
SELECT        dbo.ventas.idventa,dbo.detalle_venta.iddetalle_venta , dbo.clientes.Nombre as Cliente, dbo.Producto1.Descripcion as Producto_a_fraccionar, dbo.Presentaciones.Presentacion, dbo.detalle_venta.preciounitario, 
                         dbo.detalle_venta.cantidad, dbo.detalle_venta.Total_a_pagar, dbo.ventas.fecha_venta as Fecha_de_cotizacion, dbo.ventas.Estado,dbo.detalle_venta.Id_presentacionfraccionada ,detalle_venta.Estado 
FROM            dbo.ventas INNER JOIN
                         dbo.detalle_venta ON dbo.ventas.idventa = dbo.detalle_venta.idventa INNER JOIN
                         dbo.clientes ON dbo.ventas.idclientev = dbo.clientes.idclientev INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.detalle_venta.Id_presentacionfraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1 INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion
					where detalle_venta  .Estado ='PRODUCCION CONCLUIDA'

GO
/****** Object:  StoredProcedure [dbo].[MOSTRAR_Cuenta_corriente_para_operaciones]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MOSTRAR_Cuenta_corriente_para_operaciones]
AS
SELECT        dbo.Cuenta_corriente_para_operaciones.Id_cuenta_corriente_para_operaciones, dbo.Cuentas_corrientes_bancos_datos_generales.Numero_Cuenta_corriente, 
                         dbo.BANCOS.Descripcion, dbo.CONCEPTOS.Descripcion AS Concepto,DBO.Cuenta_corriente_para_operaciones.Numero_documento as Comprobante , dbo.Cuenta_corriente_para_operaciones.Fecha, 
                         dbo.Cuenta_corriente_para_operaciones.Ingreso, dbo.Cuenta_corriente_para_operaciones.Egreso,dbo.Cuentas_corrientes_bancos_datos_generales.Saldo 
						 ,DBO.Cuentas_corrientes_bancos_datos_generales.Id_cuenta_bancaria 
FROM            dbo.Cuenta_corriente_para_operaciones INNER JOIN
                         dbo.CONCEPTOS ON 
                         dbo.Cuenta_corriente_para_operaciones.Id_grupo_concepto_gasto = dbo.CONCEPTOS.Id_concepto INNER JOIN
                         dbo.Cuentas_corrientes_bancos_datos_generales ON 
                         dbo.Cuenta_corriente_para_operaciones.Id_cuenta_bancaria = dbo.Cuentas_corrientes_bancos_datos_generales.Id_cuenta_bancaria INNER JOIN
                         dbo.BANCOS ON dbo.Cuentas_corrientes_bancos_datos_generales.Id_Banco = dbo.BANCOS.Id_nombre_de_bancos

GO
/****** Object:  StoredProcedure [dbo].[mostrar_Cuentas_corrientes_bancos_datos_generales]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_Cuentas_corrientes_bancos_datos_generales]
as
SELECT        dbo.Cuentas_corrientes_bancos_datos_generales.Id_cuenta_bancaria, dbo.BANCOS.Descripcion, 
                         dbo.Cuentas_corrientes_bancos_datos_generales.Titular_de_la_cuenta, dbo.Cuentas_corrientes_bancos_datos_generales.Numero_Cuenta_corriente, 
                         dbo.Cuentas_corrientes_bancos_datos_generales.Saldo, dbo.Cuentas_corrientes_bancos_datos_generales.Moneda
FROM            dbo.Cuentas_corrientes_bancos_datos_generales INNER JOIN
                         dbo.BANCOS ON dbo.Cuentas_corrientes_bancos_datos_generales.Id_Banco = dbo.BANCOS.Id_nombre_de_bancos

GO
/****** Object:  StoredProcedure [dbo].[mostrar_descripcion_produco_sin_repetir]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[mostrar_descripcion_produco_sin_repetir]

@buscar varchar(50)
as begin
select Descripcion  from Producto1  Where Descripcion  LIKE  '%' + @buscar +'%'
end




GO
/****** Object:  StoredProcedure [dbo].[mostrar_Designacion_de_rutas_A_VENDEDORES]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_Designacion_de_rutas_A_VENDEDORES]
AS
SELECT      DBO.RUTAS.Id_ruta , DBO.RUTAS.Codigo , dbo.COBERTURA.Nombre AS COBERTURA , dbo.RUTAS.Nombre AS RUTA,COUNT(dbo.RUTAS.Codigo) AS CANTIDAD_DE_CLIENTES
FROM            dbo.RUTAS INNER JOIN
                         dbo.COBERTURA ON dbo.RUTAS.Id_covertura = dbo.COBERTURA.Id_covertura INNER JOIN
                         dbo.ASIGNACION_DE_CLIENTES_A_RUTAS ON dbo.RUTAS.Id_ruta = dbo.ASIGNACION_DE_CLIENTES_A_RUTAS.Id_ruta
GROUP BY dbo.COBERTURA.Nombre, dbo.RUTAS.Codigo, dbo.RUTAS.Nombre,DBO.RUTAS.Id_ruta 

GO
/****** Object:  StoredProcedure [dbo].[mostrar_Designacion_de_rutas_A_VENDEDORES_agregadas]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_Designacion_de_rutas_A_VENDEDORES_agregadas]
AS
SELECT      DBO.RUTAS.Id_ruta ,dbo.USUARIO2.Nombre_y_Apelllidos as Vendedor,dbo.COBERTURA.Nombre AS COBERTURA , dbo.RUTAS.Nombre AS RUTA, DBO.RUTAS.Codigo , COUNT(dbo.RUTAS.Codigo) AS CANTIDAD_DE_CLIENTES,dbo.Designacion_de_rutas.Fecha as Fecha_de_inicio_del_recorrido
FROM            dbo.RUTAS INNER JOIN
                         dbo.COBERTURA ON dbo.RUTAS.Id_covertura = dbo.COBERTURA.Id_covertura INNER JOIN
                         dbo.ASIGNACION_DE_CLIENTES_A_RUTAS ON dbo.RUTAS.Id_ruta = dbo.ASIGNACION_DE_CLIENTES_A_RUTAS.Id_ruta
						inner join dbo.Designacion_de_rutas ON dbo.Designacion_de_rutas.Id_ruta = dbo.RUTAS.Id_ruta
						INNER JOIN
                         dbo.USUARIO2 ON dbo.Designacion_de_rutas.Id_usuario = dbo.USUARIO2.idUsuario
GROUP BY dbo.COBERTURA.Nombre, dbo.RUTAS.Codigo, dbo.RUTAS.Nombre,DBO.RUTAS.Id_ruta ,dbo.USUARIO2.Nombre_y_Apelllidos,dbo.Designacion_de_rutas.Fecha

GO
/****** Object:  StoredProcedure [dbo].[mostrar_Designacion_Personal_Para_ordenesdeproduccion]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_Designacion_Personal_Para_ordenesdeproduccion]
as
select * from Designacion_Personal_Para_ordenesdeproduccion




GO
/****** Object:  StoredProcedure [dbo].[MOSTRAR_DESPACHOS_DE_MERCADERIAS_PENDIENTES]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MOSTRAR_DESPACHOS_DE_MERCADERIAS_PENDIENTES]
AS
select * from detalle_venta where Estado='DESPACHO PENDIENTE'

GO
/****** Object:  StoredProcedure [dbo].[mostrar_DETALLE_CONTROL_DE_COBROS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_DETALLE_CONTROL_DE_COBROS]
@id int
as
SELECT  Id_detalle_de_control_de_cobros ,Pago_realizado as [Importe],Tipo_de_cobro as [Tipo], Fecha_que_pago as Fecha  from DETALLE_CONTROL_DE_COBROS 

where Id_cliente=@id
GO
/****** Object:  StoredProcedure [dbo].[mostrar_DETALLE_CONTROL_DE_PAGOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_DETALLE_CONTROL_DE_PAGOS]
@id int
as
SELECT  Id_detalle_de_control_de_cobros ,Pago_realizado as [Importe],Tipo_de_cobro as [Tipo], Fecha_que_pago as Fecha  from DETALLE_CONTROL_DE_COBROS 

where Id_cliente=@id and DETALLE_CONTROL_DE_COBROS.Detalle ='PAGO'
GO
/****** Object:  StoredProcedure [dbo].[mostrar_detalle_de_venta_para_cotizar_productos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_detalle_de_venta_para_cotizar_productos]

@idventa as int
as
SELECT        dbo.clientes.Nombre, dbo.clientes.Nombre_de_contacto, dbo.clientes.direccion_de_envio, dbo.clientes.movil, dbo.ventas.fecha_venta, dbo.Producto1.Descripcion, 
                         dbo.Producto1.Marca, dbo.Presentaciones.Presentacion, dbo.detalle_venta.preciounitario, dbo.detalle_venta.cantidad, dbo.detalle_venta.Total_a_pagar, 
                         dbo.ventas.idventa, dbo.Tipo_de_documento.Tipo_de_documento, dbo.ventas.Numero_de_doc
FROM            dbo.ventas INNER JOIN
                         dbo.clientes ON dbo.ventas.idclientev = dbo.clientes.idclientev INNER JOIN
                         dbo.detalle_venta ON dbo.ventas.idventa = dbo.detalle_venta.idventa INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.detalle_venta.Id_presentacionfraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1 INNER JOIN
                         dbo.Serializacion ON dbo.ventas.Id_series = dbo.Serializacion.Id_serializacion INNER JOIN
                         dbo.Tipo_de_documento ON dbo.Serializacion.Id_tipodoc = dbo.Tipo_de_documento.Id_tipodoc

where dbo.ventas.idventa =@idventa 

GO
/****** Object:  StoredProcedure [dbo].[mostrar_detalle_de_ventas_AGREGADAS_A_guias_de_remision]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_detalle_de_ventas_AGREGADAS_A_guias_de_remision]
@nguia as varchar(50)
as 
SELECT        dbo.detalle_venta.Cantidad_mostrada,dbo.detalle_venta.Unidad_de_medida,   (dbo.Producto1.Descripcion +'-'+ dbo.Presentaciones.Presentacion) As Producto,dbo.Producto1.Marca , 
                     ( CONVERT(varchar(12), DBO.GUIAS_DE_REMISION_OK.Peso_total, 101) +' ' + DBO.GUIAS_DE_REMISION_OK.Unidad_de_medida_fisica) as Peso_total
FROM            dbo.Presentaciones_fraccionadas INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1 INNER JOIN
                         dbo.detalle_venta ON dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada = dbo.detalle_venta.Id_presentacionfraccionada INNER JOIN
                         dbo.ventas INNER JOIN
                         dbo.clientes ON dbo.ventas.idclientev = dbo.clientes.idclientev ON dbo.detalle_venta.idventa = dbo.ventas.idventa INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion
						 INNER JOIN DBO.GUIAS_DE_REMISION_OK ON DBO.GUIAS_DE_REMISION_OK.Id_detalle_venta=DBO.detalle_venta.iddetalle_venta 
						 where dbo.ventas .Guia_de_remision =@nguia  

GO
/****** Object:  StoredProcedure [dbo].[mostrar_detalle_de_ventas_para_guias_de_remision]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_detalle_de_ventas_para_guias_de_remision]
@nguia as varchar(50)
as 
SELECT        dbo.clientes.idclientev, (dbo.Producto1.Descripcion +'-'+ dbo.Presentaciones.Presentacion) As Producto,dbo.Producto1.Marca , dbo.detalle_venta.Unidad_de_medida, dbo.detalle_venta.Cantidad_mostrada, 
                         dbo.detalle_venta.Total_a_pagar, dbo.ventas.IGV, dbo.ventas.fecha_venta,DBO.ventas.idventa ,dbo.ventas.Estado,DBO.clientes.Nombre AS Cliente, dbo.clientes.Ruc ,dbo.detalle_venta.iddetalle_venta 
FROM            dbo.Presentaciones_fraccionadas INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1 INNER JOIN
                         dbo.detalle_venta ON dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada = dbo.detalle_venta.Id_presentacionfraccionada INNER JOIN
                         dbo.ventas INNER JOIN
                         dbo.clientes ON dbo.ventas.idclientev = dbo.clientes.idclientev ON dbo.detalle_venta.idventa = dbo.ventas.idventa INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion
						 where dbo.ventas .Guia_de_remision =@nguia  

GO
/****** Object:  StoredProcedure [dbo].[mostrar_detallealquiler]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_detallealquiler]
as
SELECT        dbo.DETALLE_ALQUILER.Iddetalle_alquiler, dbo.DETALLE_ALQUILER.IdAlquiler, dbo.DETALLE_ALQUILER.Idhabitacion, dbo.DETALLE_ALQUILER.NHabitacion, 
                         dbo.DETALLE_ALQUILER.Piso, dbo.DETALLE_ALQUILER.Costo,
                        dbo.DETALLE_ALQUILER.Recepcionista, dbo.DETALLE_ALQUILER.Total_a_pagar
FROM            dbo.DETALLE_ALQUILER INNER JOIN
                         dbo.REGISTROHOTEL ON dbo.DETALLE_ALQUILER.Idhabitacion = dbo.REGISTROHOTEL.Idhabitacion INNER JOIN
                         dbo.Alquilerdehabitacion ON dbo.DETALLE_ALQUILER.IdAlquiler = dbo.Alquilerdehabitacion.IdAlquiler order by dbo.DETALLE_ALQUILER.Iddetalle_alquiler desc





GO
/****** Object:  StoredProcedure [dbo].[mostrar_DETALLES_DE_VENTAS_A_PROGRAMAR]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_DETALLES_DE_VENTAS_A_PROGRAMAR]
as
SELECT        dbo.ventas.idventa,dbo.detalle_venta.iddetalle_venta , dbo.clientes.Nombre as Cliente, dbo.Producto1.Descripcion as Producto_a_fraccionar, dbo.Presentaciones.Presentacion, dbo.detalle_venta.preciounitario, 
                         dbo.detalle_venta.cantidad, dbo.detalle_venta.Total_a_pagar, dbo.ventas.fecha_venta as Fecha_de_cotizacion, dbo.detalle_venta .Estado,dbo.detalle_venta.Id_presentacionfraccionada 
FROM            dbo.ventas INNER JOIN
                         dbo.detalle_venta ON dbo.ventas.idventa = dbo.detalle_venta.idventa INNER JOIN
                         dbo.clientes ON dbo.ventas.idclientev = dbo.clientes.idclientev INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.detalle_venta.Id_presentacionfraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1 INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion
					where detalle_venta .Estado ='PROGRAMACION PENDIENTE' OR detalle_venta .Estado='PROGRAMADO'

GO
/****** Object:  StoredProcedure [dbo].[mostrar_documentos_que_se_entregan_para_cotizar_productos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_documentos_que_se_entregan_para_cotizar_productos]

@idventa as int
as
SELECT        dbo.CONTROL_DE_DOCUMENTOS_QUE_SE_ENTREGAN_FRACCIONAMIENTO_COTIZACION.Id_venta, 
                         dbo.DOCUMENTOS_QUE_SE_ENTREGAN_FRACCIONAMIENTO_COTIZACION.Descripcion
FROM            dbo.CONTROL_DE_DOCUMENTOS_QUE_SE_ENTREGAN_FRACCIONAMIENTO_COTIZACION INNER JOIN
                         dbo.DOCUMENTOS_QUE_SE_ENTREGAN_FRACCIONAMIENTO_COTIZACION ON 
                         dbo.CONTROL_DE_DOCUMENTOS_QUE_SE_ENTREGAN_FRACCIONAMIENTO_COTIZACION.Id_documentos_que_se_entregan = dbo.DOCUMENTOS_QUE_SE_ENTREGAN_FRACCIONAMIENTO_COTIZACION.Id_documentos_que_se_entregan_fraccionamiento
where dbo.CONTROL_DE_DOCUMENTOS_QUE_SE_ENTREGAN_FRACCIONAMIENTO_COTIZACION .Id_venta =@idventa 

GO
/****** Object:  StoredProcedure [dbo].[mostrar_Empresa]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_Empresa]
as
select LOGO, Nombre_Empresa as Empresa ,(Impuesto + ' ('+  CONVERT(VARCHAR(50),Porcentaje_impuesto) + ')') Impuesto ,Moneda  ,Id_empresa  
,Porcentaje_impuesto  ,Impuesto ,Modo_de_busqueda ,Trabajas_con_impuestos 
from Empresa

GO
/****** Object:  StoredProcedure [dbo].[mostrar_Empresa_con_cajas]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[mostrar_Empresa_igv]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_Empresa_igv]
@empresa as varchar(50)
as
select Porcentaje_impuesto , 'IGV'+' ('+CONVERT(VARCHAR(50),Porcentaje_impuesto)+'%)' as IGV FROM EMPRESA

WHERE Nombre_Empresa=@empresa 




GO
/****** Object:  StoredProcedure [dbo].[mostrar_Equipos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_Equipos]
as
select * from Equipos




GO
/****** Object:  StoredProcedure [dbo].[mostrar_estado_de_cuenta_de_cliente]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_estado_de_cuenta_de_cliente]
@Id_cliente as int
as 
SELECT      ( detalle_venta .Descripcion ) as Descripcion, dbo.detalle_venta.Cantidad_mostrada as Cant, 
                         dbo.detalle_venta.preciounitario as [Precio Unit] ,dbo.detalle_venta.Total_a_pagar as Total
FROM            dbo.detalle_venta INNER JOIN
                         dbo.ventas ON dbo.detalle_venta.idventa = dbo.ventas.idventa 
                       INNER JOIN
                         dbo.clientes ON dbo.ventas.idclientev = dbo.clientes.idclientev 
                       
						 where dbo.clientes.idclientev=@Id_cliente and dbo.ventas.Tipo_de_pago ='CREDITO' AND ((ventas.ACCION='VENTA') or (ventas.ACCION='POR COBRAR OTROS'))

GO
/****** Object:  StoredProcedure [dbo].[mostrar_estado_de_cuenta_de_proveedores]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_estado_de_cuenta_de_proveedores]
@Id_proveedor as int
as 
SELECT      ( detalle_venta .Descripcion ) as Descripcion, dbo.detalle_venta.Cantidad_mostrada as Cant, 
                         dbo.detalle_venta.preciounitario as [Precio Unit] ,dbo.detalle_venta.Total_a_pagar as Total
FROM            dbo.detalle_venta INNER JOIN
                         dbo.ventas ON dbo.detalle_venta.idventa = dbo.ventas.idventa 
                       INNER JOIN
                         dbo.clientes ON dbo.ventas.idclientev = dbo.clientes.idclientev 
                       
						 where dbo.clientes.idclientev=@Id_proveedor and dbo.ventas.Tipo_de_pago ='CREDITO' AND ventas.ACCION='POR PAGAR OTROS'

GO
/****** Object:  StoredProcedure [dbo].[MOSTRAR_fechas_trabajadas_POR_USUARIO]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[MOSTRAR_FONDO_DE_CAJA_INICIAL]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MOSTRAR_FONDO_DE_CAJA_INICIAL]
@id_caja int,
@fi as DATE,
@ff as DATEtime
AS
SELECT MOVIMIENTOCAJACIERRE.Saldo_queda_en_caja  FROM MOVIMIENTOCAJACIERRE inner join USUARIO2 on USUARIO2.idUsuario=MOVIMIENTOCAJACIERRE.Id_usuario
  inner join Caja on Caja.Id_Caja =MOVIMIENTOCAJACIERRE.Id_caja 
 where Caja.Id_Caja  = @id_caja    AND MOVIMIENTOCAJACIERRE.Estado='CAJA APERTURADA'  
GO
/****** Object:  StoredProcedure [dbo].[Mostrar_formato_ticket]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Mostrar_formato_ticket]
as
select*from Ticket 
GO
/****** Object:  StoredProcedure [dbo].[mostrar_Formato_ticket_con_datos_de_detalleventa]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[mostrar_Formato_ticket_con_datos_de_detalleventa]
@Subtotal as varchar(50),
@Total varchar (50),
@Descuento varchar(50),
@Son varchar(50),
@Impuesto varchar(50),
@Monto_impuesto varchar(50),
@Numero_comprobante as varchar(50),
@Cliente varchar(50),
@Cajero varchar(50)
as
Select *,@Subtotal as Subtotal,@Total as total,@Descuento as descuento,@Son as son , @Impuesto as impuesto
,@Monto_impuesto as monto_impuesto,@Numero_comprobante as numero_comprobante,@Cliente as cliente,@Cajero as cajero  from Ticket 

GO
/****** Object:  StoredProcedure [dbo].[mostrar_formulaciones_para_emitir_ordenes_de_fraccionamiento]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_formulaciones_para_emitir_ordenes_de_fraccionamiento]
@fecha_a_fraccionar as date
as
SELECT        dbo.Formulacion_padre_de_formulaciones_fraccionamiento_de_productos.iddetalle_venta, dbo.Producto1.Descripcion, dbo.Presentaciones.Presentacion, 
                         dbo.Formulaciones_de_fraccionamiento_de_productos.Cantidad, dbo.Formulaciones_de_fraccionamiento_de_productos.Unidad_de_medida
FROM            dbo.Formulacion_padre_de_formulaciones_fraccionamiento_de_productos INNER JOIN
                         dbo.Formulaciones_de_fraccionamiento_de_productos ON 
                         dbo.Formulacion_padre_de_formulaciones_fraccionamiento_de_productos.Id_formulacion_Formulaciones_de_fraccionamiento_de_productos = dbo.Formulaciones_de_fraccionamiento_de_productos.Id_formulacion
                          INNER JOIN
                         dbo.Presentaciones_fraccionadas ON 
                         dbo.Formulaciones_de_fraccionamiento_de_productos.Id_presentacionfraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1 INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion INNER JOIN
                         dbo.detalle_venta ON dbo.Formulacion_padre_de_formulaciones_fraccionamiento_de_productos.iddetalle_venta = dbo.detalle_venta.iddetalle_venta AND 
                         dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada = dbo.detalle_venta.Id_presentacionfraccionada INNER JOIN
                         dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES ON 
                         dbo.detalle_venta.iddetalle_venta = dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Id_detalle_venta

						  where dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Fecha_programada = @fecha_a_fraccionar 

GROUP BY dbo.Formulacion_padre_de_formulaciones_fraccionamiento_de_productos.iddetalle_venta, dbo.Producto1.Descripcion, dbo.Presentaciones.Presentacion, 
                         dbo.Formulaciones_de_fraccionamiento_de_productos.Cantidad, dbo.Formulaciones_de_fraccionamiento_de_productos.Unidad_de_medida

						 

GO
/****** Object:  StoredProcedure [dbo].[mostrar_gastos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_gastos]
as
SELECT        dbo.CONCEPTOS.Descripcion AS Concepto, dbo.GASTOSVARIOS.Idgasto, dbo.GASTOSVARIOS.Fecha_del_Gasto, 
                         dbo.GASTOSVARIOS.Tipo_de_Comprobante + ' '+dbo.GASTOSVARIOS.Nro_Comprobante AS Comprobante, dbo.GASTOSVARIOS.Importe, 
						 dbo.GASTOSVARIOS.Descripcion  as Detalle, 
                         dbo.GASTOSVARIOS.Id_concepto,USUARIO2.Nombre_y_Apelllidos as Usuario
,GASTOSVARIOS.Nro_Comprobante ,GASTOSVARIOS.Tipo_de_Comprobante 
FROM            dbo.CONCEPTOS INNER JOIN
                         dbo.GASTOSVARIOS ON dbo.CONCEPTOS.Id_concepto = dbo.GASTOSVARIOS.Id_concepto inner join USUARIO2 
						 on USUARIO2.idUsuario=GASTOSVARIOS.Id_usuario 
 where GASTOSVARIOS.TIPO='SALIDA'
 order by Fecha_del_Gasto   desc
GO
/****** Object:  StoredProcedure [dbo].[mostrar_gastos_POR_FECHAS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_gastos_POR_FECHAS]
@FI as date,
@FF as date
as
SELECT        dbo.CONCEPTOS.Descripcion AS Concepto,SUM(GASTOSVARIOS.Importe ) AS Monto

FROM            dbo.CONCEPTOS INNER JOIN
                         dbo.GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS ON 
                         dbo.CONCEPTOS.Id_grupo = dbo.GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS.Id_grupo_concepto_gasto INNER JOIN
                         dbo.GASTOSVARIOS ON dbo.CONCEPTOS.Id_concepto = dbo.GASTOSVARIOS.Id_concepto inner join USUARIO2 
						 on USUARIO2.idUsuario=GASTOSVARIOS.Id_usuario 
						
 where GASTOSVARIOS .TIPO    ='SALIDA'  AND CONVERT(DATE,GASTOSVARIOS.Fecha_del_Gasto )  >= @FI and CONVERT(DATE,GASTOSVARIOS.Fecha_del_Gasto)  <= @FF
  group by CONCEPTOS.Descripcion 
 order by SUM(GASTOSVARIOS.Importe )   desc
GO
/****** Object:  StoredProcedure [dbo].[mostrar_gastos_por_usuario]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_gastos_por_usuario]
@idusuario int,
@fecha date
as
select*from GASTOSVARIOS 
where Id_usuario=@idusuario and convert(date,Fecha_del_Gasto) =@fecha 

GO
/****** Object:  StoredProcedure [dbo].[mostrar_HORARIOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_HORARIOS]
as
SELECT        *FROM HORARIOS
GO
/****** Object:  StoredProcedure [dbo].[MOSTRAR_HORArios_por_usuario]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[MOSTRAR_HORAS_ACUMULADAS_POR_USUARIO]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[mostrar_horas_dia]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[mostrar_horas_dia]
@idpersonal int,
@fecha_sistema date
AS 

SELECT       sum(Horas ) as  Horas
FROM            dbo.ASISTENCIAS 						 
WHEre Id_personal=@idpersonal and (convert(date,Fecha_salida )=@fecha_sistema or convert(date,Fecha_entrada  )=@fecha_sistema)


GO
/****** Object:  StoredProcedure [dbo].[mostrar_ingreso]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_ingreso]
as
SELECT        dbo.INGRESOSVARIOS.Idgasto, dbo.INGRESOSVARIOS.Fecha_del_Gasto, dbo.INGRESOSVARIOS.Nro_Comprobante, dbo.INGRESOSVARIOS.Tipo_de_Comprobante, 
                         dbo.INGRESOSVARIOS.Importe, dbo.INGRESOSVARIOS.Observacion, dbo.INGRESOSVARIOS.Estado, dbo.INGRESOSVARIOS.Id_concepto, 
                         dbo.CONCEPTOS.Descripcion
FROM            dbo.INGRESOSVARIOS INNER JOIN
                         dbo.CONCEPTOS ON dbo.INGRESOSVARIOS.Id_concepto = dbo.CONCEPTOS.Id_concepto INNER JOIN
                         dbo.GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS ON 
                         dbo.CONCEPTOS.Id_grupo = dbo.GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS.Id_grupo_concepto_gasto
 order by Idgasto  desc


GO
/****** Object:  StoredProcedure [dbo].[mostrar_ingresos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_ingresos]
as
SELECT        dbo.CONCEPTOS.Descripcion AS Concepto, dbo.GASTOSVARIOS.Idgasto, dbo.GASTOSVARIOS.Fecha_del_Gasto, 
                         dbo.GASTOSVARIOS.Tipo_de_Comprobante + ' '+dbo.GASTOSVARIOS.Nro_Comprobante AS Comprobante, dbo.GASTOSVARIOS.Importe, 
						 dbo.GASTOSVARIOS.Observacion as Detalle, dbo.GASTOSVARIOS.Estado, 
                         dbo.GASTOSVARIOS.Id_concepto,USUARIO2.Nombre_y_Apelllidos as Usuario
FROM            dbo.CONCEPTOS INNER JOIN
                         dbo.GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS ON 
                         dbo.CONCEPTOS.Id_grupo = dbo.GRUPO_DE_CONCEPTOS_DE_GASTOS_INGRESOS.Id_grupo_concepto_gasto INNER JOIN
                         dbo.GASTOSVARIOS ON dbo.CONCEPTOS.Id_concepto = dbo.GASTOSVARIOS.Id_concepto inner join USUARIO2 
						 on USUARIO2.idUsuario=GASTOSVARIOS.Id_usuario
					WHERE	 GASTOSVARIOS.TIPO='INGRESO'
 order by Fecha_del_Gasto   desc
GO
/****** Object:  StoredProcedure [dbo].[MOSTRAR_Inventarios_bajo_minimo]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[MOSTRAR_Inventarios_bajo_minimo]
AS
select  Codigo,Descripcion,Precio_de_venta as [Precio Venta],Linea as Categoria, Stock ,Stock_minimo as [Stock Minimo] from Producto1 
				where Stock < Stock_minimo 	and Usa_inventarios ='SI'
GO
/****** Object:  StoredProcedure [dbo].[mostrar_inventarios_de_lotes_pendientes_de_entrega]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[mostrar_inventarios_de_lotes_pendientes_de_entrega]


AS 
SELECT        dbo.Lotizacion.Id_lote, dbo.Lotizacion.Numero_de_lote, dbo.Producto1.Descripcion AS Producto, dbo.Producto1.Unidad_de_medida, dbo.Producto1.Presentacion, 
                         dbo.Lotizacion.Stock, dbo.Lotizacion.Fecha_de_produccion, dbo.Lotizacion.Fecha_de_vencimiento, dbo.Lotizacion.Precio_Venta_Al_Publico, 
                         dbo.Lotizacion.Precio_Venta_AlPormayor, dbo.Destinos_almacen.Destino_Almacen AS Ubicacion, dbo.clientes.Nombre AS Propietario, 
                         dbo.Ordendeproduccion.Prioridad, dbo.Lotizacion.Estado
FROM            dbo.Lotizacion INNER JOIN
                         dbo.Destinos_almacen ON dbo.Lotizacion.Id_Ubicacion = dbo.Destinos_almacen.Id_destino_almacen INNER JOIN
                         dbo.Ordendeproduccion ON dbo.Lotizacion.Id_orden_de_produccion = dbo.Ordendeproduccion.IdOrden AND 
                         dbo.Destinos_almacen.Id_destino_almacen = dbo.Ordendeproduccion.Id_Destino INNER JOIN
                         dbo.Producto1 ON dbo.Ordendeproduccion.IdProducto = dbo.Producto1.Id_Producto1 INNER JOIN
                         dbo.clientes ON dbo.Ordendeproduccion.Id_cliente = dbo.clientes.idclientev
						  where dbo.Lotizacion .Estado ='Pendiente de entrega'
 order by dbo.Lotizacion.Fecha_de_vencimiento  asc


GO
/****** Object:  StoredProcedure [dbo].[mostrar_inventarios_todos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[mostrar_inventarios_todos]


AS 
SELECT    Codigo ,Descripcion,Precio_de_compra as Costo,Precio_de_venta as [Precio Venta], Stock, Stock_minimo as [Stock Minimo]  
FROM         
						 dbo.Producto1 



GO
/****** Object:  StoredProcedure [dbo].[MOSTRAR_KARDEX_ENTRADA]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MOSTRAR_KARDEX_ENTRADA]
AS
SELECT        dbo.KARDEX.Id_kardex, dbo.Presentaciones_fraccionadas .Id_presentacionfraccionada ,CONVERT(VARCHAR(50),dbo.KARDEX.Cantidad) + ' UND' as Canti, (dbo.Producto1.Descripcion+' '+dbo.Presentaciones.Presentacion+
                        ' x'+ dbo.Presentaciones.Cantidad_por_presentacion+dbo.Presentaciones.Unidad_de_medida) as Producto, 
						KARDEX.Fecha , dbo.KARDEX.Cantidad as Cant,
						USUARIO2.Nombre_y_Apelllidos AS Usuario, KARDEX.Motivo 
FROM            dbo.KARDEX INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.KARDEX.Id_presentacion_fraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1
					inner join Unidad_de_medida on Unidad_de_medida.Id_unidad_de_medida=Presentaciones_fraccionadas.Id_unidad 
						INNER JOIN USUARIO2 ON USUARIO2.idUsuario=KARDEX.Id_usuario 
					
						WHERE KARDEX.Tipo='ENTRADA'
GO
/****** Object:  StoredProcedure [dbo].[MOSTRAR_KARDEX_SALIDA]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MOSTRAR_KARDEX_SALIDA]
AS
SELECT        dbo.KARDEX.Id_kardex, dbo.Presentaciones_fraccionadas .Id_presentacionfraccionada ,CONVERT(VARCHAR(50),dbo.KARDEX.Cantidad) + ' UND' as Canti, (dbo.Producto1.Descripcion+' '+dbo.Presentaciones.Presentacion+
                        ' x'+ dbo.Presentaciones.Cantidad_por_presentacion+dbo.Presentaciones.Unidad_de_medida) as Producto, 
						KARDEX.Fecha , dbo.KARDEX.Cantidad as Cant,
						USUARIO2.Nombre_y_Apelllidos AS Usuario, KARDEX.Motivo 
FROM            dbo.KARDEX INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.KARDEX.Id_presentacion_fraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1
					inner join Unidad_de_medida on Unidad_de_medida.Id_unidad_de_medida=Presentaciones_fraccionadas.Id_unidad 
						INNER JOIN USUARIO2 ON USUARIO2.idUsuario=KARDEX.Id_usuario 
					
						WHERE KARDEX.Tipo='SALIDA'
GO
/****** Object:  StoredProcedure [dbo].[mostrar_lineas]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_lineas]
as
select * from linea order by Idline desc 


GO
/****** Object:  StoredProcedure [dbo].[mostrar_lineas_sin_repetir]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[mostrar_lineas_sin_repetir]

AS BEGIN
SET NOCOUNT ON;
SELECT DISTINCT  
      Linea
FROM           Producto1 
end


GO
/****** Object:  StoredProcedure [dbo].[mostrar_lista_calculada_de_materiales_de_formulaciones]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[mostrar_lista_calculada_de_materiales_de_formulaciones]
@letra VARCHAR(50),
@En_base_a numeric(18, 0)

AS BEGIN
SELECT          
                         dbo.materiales.Id_materiales ,dbo.materiales.Descripcion AS Material, 
                            dbo.materiales.Stock, 
                         dbo.Formulaciones.Id_materiales ,((@En_base_a * Cantidad)/  En_base_a) as Cantidad_necesaria,dbo.materiales.Precio_de_compra  ,((@En_base_a * Cantidad)/  En_base_a)*dbo.materiales.Precio_de_compra   as Total_parcial
FROM            dbo.Formulaciones INNER JOIN
                   
                         dbo.materiales ON dbo.Formulaciones.Id_materiales = dbo.materiales.Id_materiales INNER JOIN
                         dbo.Producto1 ON dbo.Formulaciones.Id_producto  = dbo.Producto1.Id_Producto1 
						 

 WHEre dbo.Producto1.Descripcion   LIKE  '%' + @letra+'%' order by dbo.materiales.Stock  desc
END


GO
/****** Object:  StoredProcedure [dbo].[mostrar_lista_de_materiales_de_formulaciones]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[mostrar_lista_de_materiales_de_formulaciones]
@idproducto as int

AS BEGIN
SELECT        dbo.Producto1.Id_Producto1, dbo.Presentaciones.Presentacion
FROM            dbo.Producto1 INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.Producto1.Id_Producto1 = dbo.Presentaciones_fraccionadas.Id_producto INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion

 WHEre dbo.Producto1.Id_Producto1    =Id_producto 
END



GO
/****** Object:  StoredProcedure [dbo].[mostrar_lista_de_materiales_de_formulaciones_SIN_BUSQUEDA]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[mostrar_lista_de_materiales_de_formulaciones_SIN_BUSQUEDA]

AS
SELECT        dbo.Producto1.Codigo_interno, dbo.Producto1.Codigo_de_barras, dbo.Producto1.Descripcion, dbo.Producto1.Presentacion_para_lotes,
                         dbo.Producto1.Stock, dbo.Producto1.Stock_unidades_de_medida, dbo.materiales.Descripcion AS Material, 
                         dbo.materiales.Presentacion AS Presentacion_del_material, dbo.Formulaciones.Cantidad,dbo.Formulaciones.En_base_a, dbo.materiales.Stock AS Stock_del_material_como_presentacion, dbo.materiales.Stock_unidades_de_medida AS Stock_del_material_en_Unidades_de_medida, 
                         dbo.materiales.Ubicacion as Ubicacion_del_material
FROM            dbo.Formulaciones INNER JOIN
                   
                         dbo.materiales ON dbo.Formulaciones.Id_materiales = dbo.materiales.Id_materiales INNER JOIN
                         dbo.Producto1 ON dbo.Formulaciones.Id_producto  = dbo.Producto1.Id_Producto1


GO
/****** Object:  StoredProcedure [dbo].[mostrar_marca_sinrepeticion]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  proc [dbo].[mostrar_marca_sinrepeticion]

AS
	SET NOCOUNT ON;
SELECT DISTINCT Marca
FROM           productos2 





GO
/****** Object:  StoredProcedure [dbo].[mostrar_materiales]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_materiales]
as
SELECT        dbo.materiales.Id_materiales, dbo.materiales.Descripcion, dbo.Presentaciones.Presentacion, dbo.Unidad_de_medida.Unidad_de_medida, 
                         dbo.Destinos_almacen.Destino_Almacen, dbo.materiales.Precio_Venta_Al_Publico, dbo.materiales.Precio_Venta_AlPormayor, dbo.materiales.Stock, 
                         dbo.materiales.Fecha_de_vencimiento, dbo.materiales.Precio_de_compra, dbo.materiales.Produccion, dbo.materiales.Comprar, dbo.materiales.Vender, 
                         dbo.materiales.Insumo, dbo.materiales.Materia_prima, dbo.materiales.Suministro,dbo.Unidad_de_medida.Id_unidad_de_medida ,dbo.Presentaciones.Id_Presentacion 
FROM            dbo.materiales INNER JOIN
                         dbo.Presentaciones ON dbo.materiales.Id_presentacion = dbo.Presentaciones.Id_Presentacion INNER JOIN
                         dbo.Unidad_de_medida ON dbo.materiales.Id_Unidad_de_medida = dbo.Unidad_de_medida.Id_unidad_de_medida INNER JOIN
                         dbo.Destinos_almacen ON dbo.materiales.Id_destino_almacen = dbo.Destinos_almacen.Id_destino_almacen


GO
/****** Object:  StoredProcedure [dbo].[mostrar_materiales_para_emitir_orden_de_fraccionamiento]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_materiales_para_emitir_orden_de_fraccionamiento]
@Idfecha as date
as
SELECT       dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Actividad ,dbo.Formulaciones_de_fraccionamiento_de_productos.Id_formulacion, dbo.Producto1.Descripcion, dbo.Presentaciones.Presentacion, 
                         dbo.Tipos_De_productos.Descripcion AS Tipo_de_producto, dbo.Formulaciones_de_fraccionamiento_de_productos.Cantidad 
                        , dbo.Formulaciones_de_fraccionamiento_de_productos.Unidad_de_medida, dbo.Formulaciones_de_fraccionamiento_de_productos.Costo,dbo.Formulaciones_de_fraccionamiento_de_productos.Total_parcial,dbo.ventas.idventa 
						,dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Id_Programacion_basica_general ,DBO.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Id_detalle_venta 
				
FROM            dbo.Formulaciones_de_fraccionamiento_de_productos 
                         inner join
                         dbo.Presentaciones_fraccionadas ON 
                         dbo.Formulaciones_de_fraccionamiento_de_productos.Id_presentacionfraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1 INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion INNER JOIN
                         dbo.Tipos_De_productos ON dbo.Producto1.Id_tipo = dbo.Tipos_De_productos.Id_tipo_de_producto
						 inner join dbo.Formulacion_padre_de_formulaciones_fraccionamiento_de_productos on
						 dbo.Formulacion_padre_de_formulaciones_fraccionamiento_de_productos.Id_formulacion_Formulaciones_de_fraccionamiento_de_productos=dbo.Formulaciones_de_fraccionamiento_de_productos.Id_formulacion
						 inner join dbo.detalle_venta on dbo.Formulacion_padre_de_formulaciones_fraccionamiento_de_productos.iddetalle_venta=dbo.detalle_venta.iddetalle_venta 
						 inner join dbo.ventas on dbo.detalle_venta.idventa =dbo.ventas.idventa 
						 inner join dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES on dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Id_detalle_venta =detalle_venta.iddetalle_venta 
						INNER JOIN
  dbo.Turno ON dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Id_turno_programado = dbo.Turno.Id_turno 
  where dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Fecha_programada =@Idfecha
 

GO
/****** Object:  StoredProcedure [dbo].[mostrar_monto_acumulado_de_credito_de_cliente]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[mostrar_monto_acumulado_de_credito_de_proveedor]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[mostrar_monto_acumulado_de_credito_de_proveedor]
@Id_cliente as int
as 
SELECT       * from CONTROL_DE_PAGOS_A_PROVEEDORES
where Id_proveedor=@Id_cliente 
GO
/****** Object:  StoredProcedure [dbo].[MOSTRAR_MOVIMIENTOS_DE_CAJA_POR_SERIAL]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MOSTRAR_MOVIMIENTOS_DE_CAJA_POR_SERIAL]

@serial varchar(50)

AS
SELECT USUARIO2.Login,USUARIO2.Nombre_y_Apelllidos    FROM MOVIMIENTOCAJACIERRE inner join USUARIO2 on USUARIO2.idUsuario=MOVIMIENTOCAJACIERRE.Id_usuario
 inner join Caja on Caja.Id_Caja =MOVIMIENTOCAJACIERRE.Id_caja 
 where Caja.Serial_PC = @serial    AND MOVIMIENTOCAJACIERRE.Estado='CAJA APERTURADA' 


GO
/****** Object:  StoredProcedure [dbo].[MOSTRAR_MOVIMIENTOS_DE_CAJA_POR_SERIAL_nombre_de_usuario]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MOSTRAR_MOVIMIENTOS_DE_CAJA_POR_SERIAL_nombre_de_usuario]

@serial varchar(50)

AS
SELECT USUARIO2.Nombre_y_Apelllidos    FROM MOVIMIENTOCAJACIERRE inner join USUARIO2 on USUARIO2.idUsuario=MOVIMIENTOCAJACIERRE.Id_usuario
 inner join CIERRE_DE_CAJA_PADRE on CIERRE_DE_CAJA_PADRE.Id_cierre_de_caja  =MOVIMIENTOCAJACIERRE .Id_cierre_padre inner join Caja on Caja.Id_Caja =CIERRE_DE_CAJA_PADRE.Id_caja 
 where Caja.Serial_PC = @serial    AND MOVIMIENTOCAJACIERRE.Estado='CAJA APERTURADA' 
GO
/****** Object:  StoredProcedure [dbo].[MOSTRAR_MOVIMIENTOS_DE_CAJA_POR_SERIAL_y_usuario]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MOSTRAR_MOVIMIENTOS_DE_CAJA_POR_SERIAL_y_usuario]

@serial varchar(50),
@idusuario int

AS
SELECT USUARIO2.Login,USUARIO2.Nombre_y_Apelllidos    FROM MOVIMIENTOCAJACIERRE inner join USUARIO2 on USUARIO2.idUsuario=MOVIMIENTOCAJACIERRE.Id_usuario
 inner join Caja on Caja.Id_Caja =MOVIMIENTOCAJACIERRE.Id_caja 
 where Caja.Serial_PC = @serial    AND MOVIMIENTOCAJACIERRE.Estado='CAJA APERTURADA' and MOVIMIENTOCAJACIERRE.Id_usuario =@idusuario 
GO
/****** Object:  StoredProcedure [dbo].[MOSTRAR_MOVIMIENTOS_DE_KARDEX]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MOSTRAR_MOVIMIENTOS_DE_KARDEX]
AS
SELECT       KARDEX.Fecha ,Producto1.Descripcion ,KARDEX.Motivo as Movimiento, KARDEX.Habia ,KARDEX.Tipo ,KARDEX.Cantidad ,KARDEX.Hay ,USUARIO2.Nombre_y_Apelllidos as Cajero ,Producto1.Linea as Categoria, KARDEX.Costo_unt , KARDEX.Total 
FROM            dbo.KARDEX INNER JOIN Producto1 on Producto1.Id_Producto1=KARDEX.Id_producto inner join USUARIO2 on USUARIO2.idUsuario =KARDEX.Id_usuario 
             order by KARDEX.Fecha Desc
					
GO
/****** Object:  StoredProcedure [dbo].[mostrar_nombreservicio]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_nombreservicio]
as
select *from nombredeservicio 




GO
/****** Object:  StoredProcedure [dbo].[mostrar_Orden_de_Produccion_en_combobox_id]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_Orden_de_Produccion_en_combobox_id]
as
SELECT       max(IdOrden ) from Ordendeproduccion 


GO
/****** Object:  StoredProcedure [dbo].[mostrar_ordenes_PARA_DESPACHAR]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[mostrar_ordenes_PARA_DESPACHAR]


AS 
SELECT        dbo.DESPACHO_DE_PEDIDOS.Id_despacho_de_pedidos, dbo.DESPACHO_DE_PEDIDOS.Id_cliente, dbo.DESPACHO_DE_PEDIDOS.Id_lote, 
                         dbo.Lotizacion.Numero_de_lote, dbo.Lotizacion.Stock, dbo.Producto1.Descripcion, dbo.Presentaciones.Presentacion, dbo.Unidad_de_medida.Unidad_de_medida, 
                         dbo.clientes.Nombre, dbo.DESPACHO_DE_PEDIDOS.Monto_total, dbo.DESPACHO_DE_PEDIDOS.Descuento, dbo.DESPACHO_DE_PEDIDOS.Total_Impuestos, 
                         dbo.DESPACHO_DE_PEDIDOS.Estado_de_pedido, dbo.DESPACHO_DE_PEDIDOS.Facturado, dbo.DESPACHO_DE_PEDIDOS.Numero_de_factura, 
                         dbo.DESPACHO_DE_PEDIDOS.Pagado, dbo.Lotizacion.Fecha_de_produccion, dbo.Lotizacion.Fecha_de_vencimiento
FROM            dbo.DESPACHO_DE_PEDIDOS INNER JOIN
                         dbo.clientes ON dbo.DESPACHO_DE_PEDIDOS.Id_cliente = dbo.clientes.idclientev INNER JOIN
                         dbo.Lotizacion ON dbo.DESPACHO_DE_PEDIDOS.Id_lote = dbo.Lotizacion.Id_lote INNER JOIN
                         dbo.Ordendeproduccion ON dbo.clientes.idclientev = dbo.Ordendeproduccion.Id_cliente AND 
                         dbo.Lotizacion.Id_orden_de_produccion = dbo.Ordendeproduccion.IdOrden INNER JOIN
                         dbo.Producto1 ON dbo.Ordendeproduccion.IdProducto = dbo.Producto1.Id_Producto1 INNER JOIN
                         dbo.Presentaciones ON dbo.Producto1.Id_Presentacion = dbo.Presentaciones.Id_Presentacion INNER JOIN
                         dbo.Unidad_de_medida on dbo.Producto1.Id_Unidad_de_medida = dbo.Unidad_de_medida.Id_unidad_de_medida 
 order by dbo.Lotizacion.Fecha_de_vencimiento  asc


GO
/****** Object:  StoredProcedure [dbo].[MOSTRAR_PARA_GENERAR_RESULTADOS_DE_FRACCIONAMIENTO_DE_PRODUCTOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[MOSTRAR_PARA_GENERAR_RESULTADOS_DE_FRACCIONAMIENTO_DE_PRODUCTOS]
@Numero_de_doc as varchar(50)
as
SELECT        dbo.detalle_venta.iddetalle_venta, dbo.detalle_venta.idventa, dbo.detalle_venta.Id_presentacionfraccionada, 
                         dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Actividad, dbo.Producto1.Descripcion, dbo.Presentaciones.Presentacion, dbo.detalle_venta.cantidad, 
                         dbo.detalle_venta.Unidad_de_medida, 
                          ORDEN_DE_FRACCIONAMINETO_DE_PRODUCTOS.Numero_de_produccion 
						 ,ORDEN_DE_FRACCIONAMINETO_DE_PRODUCTOS.Fecha_de_produccion ,dbo.Centros_de_produccion.Centro_de_produccion 
						,dbo.Personal.Nombres , dbo.Personal.Cargo ,dbo.detalle_venta.Estado 
FROM            dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES INNER JOIN
   dbo.Turno on dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Id_turno_programado=Turno.Id_turno inner join 
                         dbo.detalle_venta ON dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Id_detalle_venta = dbo.detalle_venta.iddetalle_venta INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.detalle_venta.Id_presentacionfraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1 INNER JOIN
                         
						  dbo.ORDEN_DE_FRACCIONAMINETO_DE_PRODUCTOS on detalle_venta.iddetalle_venta =dbo.ORDEN_DE_FRACCIONAMINETO_DE_PRODUCTOS.Id_detalleventa 
						INNER JOIN dbo.Personal on dbo.ORDEN_DE_FRACCIONAMINETO_DE_PRODUCTOS .Id_responsable_personal  = dbo.Personal.Id_personal
						INNER JOIN dbo.Centros_de_produccion on dbo.ORDEN_DE_FRACCIONAMINETO_DE_PRODUCTOS.Id_centro_de_produccion =dbo.Centros_de_produccion.Id_Centro_de_produccion 
						 where ORDEN_DE_FRACCIONAMINETO_DE_PRODUCTOS.Numero_de_produccion  = @Numero_de_doc 
						group by 
		     dbo.detalle_venta.iddetalle_venta, dbo.detalle_venta.idventa, dbo.detalle_venta.Id_presentacionfraccionada, 
                         dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Actividad, dbo.Producto1.Descripcion, dbo.Presentaciones.Presentacion, dbo.detalle_venta.cantidad, 
                         dbo.detalle_venta.Unidad_de_medida, 
                          ORDEN_DE_FRACCIONAMINETO_DE_PRODUCTOS.Numero_de_produccion 
						 ,ORDEN_DE_FRACCIONAMINETO_DE_PRODUCTOS.Fecha_de_produccion ,dbo.Centros_de_produccion.Centro_de_produccion 
						,dbo.Personal.Nombres , dbo.Personal.Cargo ,dbo.detalle_venta.Estado 

GO
/****** Object:  StoredProcedure [dbo].[mostrar_permisos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_permisos]
@idusuario int
as
SELECT        dbo.permisos.*
FROM            dbo.USUARIO2 INNER JOIN
                         dbo.permisos ON dbo.USUARIO2.idUsuario = dbo.permisos.Id_Usuario
						 where dbo.USUARIO2.idUsuario =@idusuario 

GO
/****** Object:  StoredProcedure [dbo].[mostrar_permisos_por_usuario]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrar_permisos_por_usuario]
@id int
as 
select USUARIO2 .idUsuario,USUARIO2.Nombre_y_Apelllidos as [Nombres] ,USUARIO2 .Login as Usuario,USUARIO2.Password as Contraseña,permisos.*
from USUARIO2 inner join permisos on permisos.Id_Usuario =USUARIO2.idUsuario 
where USUARIO2.idUsuario =@id 

GO
/****** Object:  StoredProcedure [dbo].[mostrar_personal_agregados_a_formulaciones_de_fraCCIONAMIENTO_de_productos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_personal_agregados_a_formulaciones_de_fraCCIONAMIENTO_de_productos]
@Id_detalle_venta as int
as
SELECT        dbo.FORMULACION_DE_PERSONAL_PARA_FRACCIONAMIENTO_DE_PRODUCTOS.Id_formulacion_de_personal, dbo.Personal.Nombres, dbo.Personal.Cargo, 
                         dbo.FORMULACION_DE_PERSONAL_PARA_FRACCIONAMIENTO_DE_PRODUCTOS.Costo, 
                         dbo.FORMULACION_DE_PERSONAL_PARA_FRACCIONAMIENTO_DE_PRODUCTOS.Total_parcial
FROM            dbo.FORMULACION_DE_PERSONAL_PARA_FRACCIONAMIENTO_DE_PRODUCTOS INNER JOIN
                         dbo.FORMULACION_padre_de_formulacion_de_personal_para_fraccionar_productos ON 
                         dbo.FORMULACION_DE_PERSONAL_PARA_FRACCIONAMIENTO_DE_PRODUCTOS.Id_formulacion_de_personal = dbo.FORMULACION_padre_de_formulacion_de_personal_para_fraccionar_productos.Id_formulacion_de_personal
                          INNER JOIN
                         dbo.Personal ON dbo.FORMULACION_DE_PERSONAL_PARA_FRACCIONAMIENTO_DE_PRODUCTOS.Id_personal = dbo.Personal.Id_personal INNER JOIN
                         dbo.detalle_venta ON dbo.FORMULACION_padre_de_formulacion_de_personal_para_fraccionar_productos.iddetalle_venta = dbo.detalle_venta.iddetalle_venta
where dbo.FORMULACION_padre_de_formulacion_de_personal_para_fraccionar_productos.iddetalle_venta =@Id_detalle_venta

GO
/****** Object:  StoredProcedure [dbo].[mostrar_planificacion_basica_general_por_fecha]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[mostrar_planificacion_basica_general_por_fecha]

@ff as datetime,
@fi as datetime

AS 
SELECT        dbo.clientes.Nombre, dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Actividad, dbo.detalle_venta.iddetalle_venta ,
                         dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Fecha_programada, dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Fecha_de_fin, 
                         dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Hora_inicio, dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Hora_fin, 
                         dbo.Turno.Descripcion, dbo.Turno.Desde, dbo.Turno.Hasta, dbo.Turno.Duracion_en_horas
FROM            dbo.ventas INNER JOIN
                         dbo.clientes ON dbo.ventas.idclientev = dbo.clientes.idclientev INNER JOIN
                         dbo.detalle_venta ON dbo.ventas.idventa = dbo.detalle_venta.idventa INNER JOIN
                         dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES INNER JOIN
                         dbo.Turno ON dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Id_turno_programado = dbo.Turno.Id_turno ON 
                         dbo.detalle_venta.iddetalle_venta = dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Id_detalle_venta
						 
 WHERE  PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Fecha_programada  >= @fi and  PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Fecha_programada<=@ff  order by PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Fecha_programada asc

GO
/****** Object:  StoredProcedure [dbo].[mostrar_planificacion_basica_general_por_id_detalle_venta]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[mostrar_planificacion_basica_general_por_id_detalle_venta]

@iddetalleventa as int

AS 
SELECT        dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Actividad, dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Fecha_programada, 
                        ( dbo.Turno.Desde + '-' + dbo.Turno.Hasta )AS Desde_Hasta, dbo.Turno.Descripcion as Turno
FROM            dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES INNER JOIN
                         dbo.Turno ON dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Id_turno_programado = dbo.Turno.Id_turno
				   inner join dbo.detalle_venta on dbo.detalle_venta.iddetalle_venta=PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Id_detalle_venta 
				   inner join dbo.ventas  on dbo.ventas.idventa=dbo.detalle_venta.idventa 
				   inner join dbo. clientes on dbo.ventas.idclientev =dbo.clientes.idclientev 
 WHERE  dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Id_detalle_venta  = @iddetalleventa  order by dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Fecha_programada asc

GO
/****** Object:  StoredProcedure [dbo].[mostrar_planificadas_basica_general_por_id_detalle_venta]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[mostrar_planificadas_basica_general_por_id_detalle_venta]

@iddetalleventa as int

AS 
SELECT        dbo.clientes.Nombre, dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Actividad, 
                         dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Fecha_programada, dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Fecha_de_fin, 
                         dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Hora_inicio, dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Hora_fin, 
                         dbo.Turno.Descripcion, dbo.Turno.Desde, dbo.Turno.Hasta, dbo.Turno.Duracion_en_horas
FROM            dbo.ventas INNER JOIN
                         dbo.clientes ON dbo.ventas.idclientev = dbo.clientes.idclientev INNER JOIN
                         dbo.detalle_venta ON dbo.ventas.idventa = dbo.detalle_venta.idventa INNER JOIN
                         dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES INNER JOIN
                         dbo.Turno ON dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Id_turno_programado = dbo.Turno.Id_turno ON 
                         dbo.detalle_venta.iddetalle_venta = dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Id_detalle_venta
 WHERE  dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Id_detalle_venta  = @iddetalleventa  order by dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Fecha_programada asc

GO
/****** Object:  StoredProcedure [dbo].[mostrar_precios_por_idproducto]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[mostrar_precios_por_idproducto]
@idproducto int

AS BEGIN

   select * from Precio_padre   
                   
where dbo.Precio_padre.Id_producto  =@idproducto 
END



GO
/****** Object:  StoredProcedure [dbo].[mostrar_presentaciones_agregadas_por_producto]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[mostrar_presentaciones_agregadas_por_producto]
@idproducto int

AS 
select

    dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada, dbo.Presentaciones.Presentacion+' x'+Presentaciones.Cantidad_por_presentacion +Presentaciones.Unidad_de_medida as Presentacion,
                       Presentaciones_fraccionadas.Stock ,'S/.'+convert(varchar (50),Presentaciones_fraccionadas.Precio_de_compra  ) + ' x '+ Unidad_de_medida.Unidad_de_medida + ' ('+Unidad_de_medida. Cantidad_por_unidad_de_medida+ 'UND'+')'   as Costo,
	'S/.'+convert(varchar (50),Presentaciones_fraccionadas.Precio_de_venta_por_presentacion ) + ' x '+ Unidad_de_medida.Unidad_de_medida + ' ('+Unidad_de_medida. Cantidad_por_unidad_de_medida+ 'UND'+')' as P_venta ,CONVERT(NUMERIC(18,1),Presentaciones_fraccionadas.Precio_de_venta_unitario*Presentaciones_fraccionadas.Stock) as TOTAL 
	,Precio_de_venta_unitario/Unidad_de_medida.Cantidad_por_unidad_de_medida as P_venta_unt,Precio_de_compra/Unidad_de_medida.Cantidad_por_unidad_de_medida as P_costo_unt  
	,Unidad_de_medida.Id_unidad_de_medida ,Unidad_de_medida.Unidad_de_medida ,Producto1.Descripcion 
	 ,Producto1.Linea AS oK,Producto1 .Linea,Presentaciones_fraccionadas.Precio_de_venta_por_presentacion 
	 ,Unidad_de_medida.Cantidad_por_unidad_de_medida  
	 ,Fecha_de_vencimiento
	 ,Ubicacion ,
	 Precio_de_compra  ,Presentaciones_fraccionadas.Se_vende_a 
FROM            dbo.Producto1 INNER JOIN
                      
                     
					 dbo.Presentaciones_fraccionadas on Presentaciones_fraccionadas.Id_producto=dbo.Producto1.Id_Producto1 
						 inner join dbo.Presentaciones on dbo.Presentaciones.Id_Presentacion =dbo.Presentaciones_fraccionadas.Id_presentacion 
						inner join Unidad_de_medida on Unidad_de_medida.Id_unidad_de_medida=Presentaciones_fraccionadas.Id_unidad 
						
					
						 --WHERE DBO.Producto1.Produccion='SI' 
						 where dbo.Presentaciones_fraccionadas.Id_producto  =@idproducto 

	
	
	
						 	 ORDER BY DBO.Producto1.Descripcion  asc

GO
/****** Object:  StoredProcedure [dbo].[mostrar_presentaciones_agregadas_por_producto_para_agregar_stock_y_precio_de_compra]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[mostrar_presentaciones_agregadas_por_producto_para_agregar_stock_y_precio_de_compra]
@idproducto int

AS BEGIN
SET NOCOUNT ON;
SELECT DISTINCT  
     dbo.Presentaciones.Presentacion, dbo.Presentaciones_fraccionadas.Activo as Estado, dbo.Presentaciones_fraccionadas.Stock,dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada,dbo.Presentaciones_fraccionadas.Precio_de_compra_mostrado  
	 ,dbo.Presentaciones_fraccionadas.Almacen,dbo.Presentaciones_fraccionadas.Fecha_de_produccion,
	 dbo.Presentaciones_fraccionadas.Fecha_de_vencimiento,
	 dbo.Presentaciones_fraccionadas.Lote,dbo.Presentaciones_fraccionadas.Peso,dbo.Presentaciones_fraccionadas.Und_med
FROM           dbo.Presentaciones_fraccionadas inner join
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion
						
where dbo.Presentaciones_fraccionadas.Id_producto  =@idproducto 
END

GO
/****** Object:  StoredProcedure [dbo].[mostrar_presentaciones_de_fraccionamiento]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[mostrar_presentaciones_de_fraccionamiento]
@idproducto int

AS BEGIN
SET NOCOUNT ON;
SELECT DISTINCT  
       dbo.Presentaciones.Presentacion, dbo.Precios.Zona, dbo.Precios.Precio, dbo.Precios.Id_precios,dbo.Unidad_de_medida.Unidad_de_medida 
FROM            dbo.Presentaciones_fraccionadas INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion INNER JOIN
                         dbo.Precios ON dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada = dbo.Precios.Id_presentacionfraccionada		
						 inner join dbo.Unidad_de_medida on dbo.Unidad_de_medida.Id_unidad_de_medida=dbo.Precios.Id_unidades	
where dbo.Presentaciones_fraccionadas.Id_producto =@idproducto 
END


GO
/****** Object:  StoredProcedure [dbo].[mostrar_presentaciones_de_fraccionamiento_con_precios]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[mostrar_presentaciones_de_fraccionamiento_con_precios]
@idproducto int

AS BEGIN
SET NOCOUNT ON;
SELECT DISTINCT  
       dbo.Presentaciones.Presentacion, dbo.Precios.Zona, dbo.Precios.Precio, dbo.Precios.Id_precios,dbo.Unidad_de_medida.Unidad_de_medida 
FROM            dbo.Presentaciones_fraccionadas INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion INNER JOIN
                         dbo.Precios ON dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada = dbo.Precios.Id_presentacionfraccionada			
						 inner join dbo.Unidad_de_medida on dbo.Unidad_de_medida.Id_unidad_de_medida=dbo.Precios.Id_unidades
where dbo.Presentaciones_fraccionadas.Id_producto =@idproducto 
END



GO
/****** Object:  StoredProcedure [dbo].[mostrar_presentaciones_de_fraccionamiento_con_precios_por_presentacion_en_especifico]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[mostrar_presentaciones_de_fraccionamiento_con_precios_por_presentacion_en_especifico]
@Id_presentacionfraccionada int

AS BEGIN
SET NOCOUNT ON;
SELECT DISTINCT  
       dbo.Precios.Zona,dbo.Unidad_de_medida.Unidad_de_medida ,dbo.Precios.Precio,DBO.Unidad_de_medida.Cantidad_por_unidad_de_medida  
FROM            dbo.Presentaciones_fraccionadas INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion INNER JOIN
                         dbo.Precios ON dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada = dbo.Precios.Id_presentacionfraccionada		
						 inner join dbo.Unidad_de_medida on dbo.Unidad_de_medida.Id_unidad_de_medida=dbo.Precios.Id_unidades		
where dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada =@Id_presentacionfraccionada
END


GO
/****** Object:  StoredProcedure [dbo].[mostrar_presentaciones_de_fraccionamiento_con_precios_por_presentacion_en_especifico_para_servicios]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[mostrar_presentaciones_de_fraccionamiento_con_precios_por_presentacion_en_especifico_para_servicios]
@Id_presentacionfraccionada int

AS BEGIN
SET NOCOUNT ON;
SELECT DISTINCT  
     dbo.Presentaciones.Presentacion, dbo.PRECIOS_SERVICIOS_DE_FRACCIONAMIENTO.Id_presentaciones_fraccionadas_servicio_fraccionamiento, 
                         dbo.PRECIOS_SERVICIOS_DE_FRACCIONAMIENTO.Precio, dbo.PRECIOS_SERVICIOS_DE_FRACCIONAMIENTO.Id_precios, 
                         dbo.Unidad_de_medida.Unidad_de_medida
FROM            dbo.Presentaciones INNER JOIN
                         dbo.Presentaciones_fraccionadas_fraccionamiento ON 
                         dbo.Presentaciones.Id_Presentacion = dbo.Presentaciones_fraccionadas_fraccionamiento.Id_presentacion INNER JOIN
                         dbo.PRECIOS_SERVICIOS_DE_FRACCIONAMIENTO ON 
                         dbo.Presentaciones_fraccionadas_fraccionamiento.Id_presentacion_fraccionamiento = dbo.PRECIOS_SERVICIOS_DE_FRACCIONAMIENTO.Id_presentaciones_fraccionadas_servicio_fraccionamiento
                         INNER JOIN 
                         dbo.Unidad_de_medida	ON dbo.PRECIOS_SERVICIOS_DE_FRACCIONAMIENTO.Id_unidades=dbo.Unidad_de_medida.Id_unidad_de_medida 
where dbo.Presentaciones_fraccionadas_fraccionamiento .Id_presentacion_fraccionamiento  =@Id_presentacionfraccionada
END


GO
/****** Object:  StoredProcedure [dbo].[mostrar_presentaciones_de_fraccionamiento_EN_VENTAS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[mostrar_presentaciones_de_fraccionamiento_EN_VENTAS]
@idproducto int

AS BEGIN
SET NOCOUNT ON;
SELECT DISTINCT  
     dbo.Precios.Zona, dbo.Unidad_de_medida.Unidad_de_medida ,dbo.Precios.Precio 
FROM            dbo.Presentaciones_fraccionadas INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion INNER JOIN
                         dbo.Precios ON dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada = dbo.Precios.Id_presentacionfraccionada		
						 inner join dbo.Unidad_de_medida on dbo.Unidad_de_medida.Id_unidad_de_medida=dbo.Precios.Id_unidades	
where dbo.Presentaciones_fraccionadas.Id_producto =@idproducto 
END


GO
/****** Object:  StoredProcedure [dbo].[mostrar_presentaciones_de_fraccionamiento_fraccionamiento_con_precios]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[mostrar_presentaciones_de_fraccionamiento_fraccionamiento_con_precios]
@idproducto int

AS BEGIN
SET NOCOUNT ON;
SELECT DISTINCT  
     dbo.Presentaciones.Presentacion, dbo.Presentaciones.Id_Presentacion, dbo.PRECIOS_SERVICIOS_DE_FRACCIONAMIENTO.Precio, 
                         dbo.PRECIOS_SERVICIOS_DE_FRACCIONAMIENTO.Id_precios, dbo.Unidad_de_medida.Unidad_de_medida
FROM            dbo.Presentaciones_fraccionadas_fraccionamiento INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas_fraccionamiento.Id_presentacion = dbo.Presentaciones.Id_Presentacion INNER JOIN
                         dbo.PRECIOS_SERVICIOS_DE_FRACCIONAMIENTO ON 
                         dbo.Presentaciones_fraccionadas_fraccionamiento.Id_presentacion_fraccionamiento = dbo.PRECIOS_SERVICIOS_DE_FRACCIONAMIENTO.Id_presentaciones_fraccionadas_servicio_fraccionamiento
                         INNER JOIN
                         dbo.Unidad_de_medida ON dbo.Unidad_de_medida.Id_unidad_de_medida=dbo.PRECIOS_SERVICIOS_DE_FRACCIONAMIENTO.Id_unidades 
where dbo.Presentaciones_fraccionadas_fraccionamiento.Id_servicio  =@idproducto 
END



GO
/****** Object:  StoredProcedure [dbo].[mostrar_presentaciones_fraccionamiento_agregadas_por_producto]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[mostrar_presentaciones_fraccionamiento_agregadas_por_producto]
@idproducto int

AS 
SELECT        dbo.Presentaciones.Presentacion, dbo.Presentaciones_fraccionadas_fraccionamiento.Activo as Estado, dbo.Presentaciones_fraccionadas_fraccionamiento.Id_servicio, 
                         dbo.Presentaciones_fraccionadas_fraccionamiento.Id_presentacion_fraccionamiento
FROM            dbo.Presentaciones_fraccionadas_fraccionamiento INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas_fraccionamiento.Id_presentacion = dbo.Presentaciones.Id_Presentacion
						
where dbo.Presentaciones_fraccionadas_fraccionamiento.Id_servicio   =@idproducto 




GO
/****** Object:  StoredProcedure [dbo].[mostrar_PRESENTACIONES_UNIDO]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_PRESENTACIONES_UNIDO]
as
select Id_Presentacion ,(Presentacion+ ' x '+Cantidad_por_presentacion + Unidad_de_medida) as Presentacion
FROM Presentaciones 
GO
/****** Object:  StoredProcedure [dbo].[mostrar_Producto1]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_Producto1]
as

select Id_Producto1,Codigo ,Linea as Categoria,Descripcion ,Impuesto,Usa_inventarios ,Precio_de_compra AS P_Compra,Precio_mayoreo as P_mayoreo,Se_vende_a as Se_vende_por,Stock_minimo ,Fecha_de_vencimiento as F_vencimiento ,Stock,Precio_de_venta as P_venta  from Producto1 


GO
/****** Object:  StoredProcedure [dbo].[mostrar_Producto1_STOCK_CERO]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[mostrar_productos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_productos]
as
select * from productos2 order by idproducto desc





GO
/****** Object:  StoredProcedure [dbo].[mostrar_productos_agregados_a_COMPRA]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_productos_agregados_a_COMPRA]
@Cod_compra as int
as
SELECT  * from Detalle_Compra       
where dbo.Detalle_Compra  .idcompra  =@Cod_compra  

GO
/****** Object:  StoredProcedure [dbo].[mostrar_productos_agregados_a_COMPRA_PENDIENTES_dE_RECEPCION]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_productos_agregados_a_COMPRA_PENDIENTES_dE_RECEPCION]
@idcompra as int
as
SELECT        (dbo.Producto1.Descripcion +'-'+ dbo.Presentaciones.Presentacion) as Producto, (convert (varchar (50),dbo.Detalle_Compra.Cantidad_mostrada)+ '-'+ dbo.Detalle_Compra.Unidad_de_medida ) as Cant, 
                         dbo.Detalle_Compra.Precio_compra  as Precio_Unit ,dbo.Detalle_Compra.Total_a_pagar, dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada,DBO.Detalle_Compra.iddetallecompra  ,dbo.Detalle_Compra.Estado 
						 ,dbo.Presentaciones_fraccionadas.Stock ,dbo.Detalle_Compra.cantidad 
FROM            dbo.Detalle_Compra INNER JOIN
                         dbo.Compra  ON dbo.Detalle_Compra .idcompra  = dbo.Compra .Cod_compra  INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.Detalle_Compra.Id_presentacionfraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1 INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion     
where dbo.Detalle_Compra .idcompra  =@idcompra  AND DBO.Detalle_Compra .Estado='RECEPCION PENDIENTE'

GO
/****** Object:  StoredProcedure [dbo].[mostrar_productos_agregados_a_formulaciones__de_fraCCIONAMIENTO_de_productos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_productos_agregados_a_formulaciones__de_fraCCIONAMIENTO_de_productos]
@Id_detalle_venta as int
as
SELECT        dbo.Formulaciones_de_fraccionamiento_de_productos.Id_formulacion, dbo.Producto1.Descripcion, dbo.Presentaciones.Presentacion, 
                         dbo.Tipos_De_productos.Descripcion AS Tipo_de_producto, dbo.Formulaciones_de_fraccionamiento_de_productos.Cantidad 
                        , dbo.Formulaciones_de_fraccionamiento_de_productos.Unidad_de_medida, dbo.Formulaciones_de_fraccionamiento_de_productos.Costo,dbo.Formulaciones_de_fraccionamiento_de_productos.Total_parcial
FROM            dbo.Formulaciones_de_fraccionamiento_de_productos INNER JOIN
                         dbo.Presentaciones_fraccionadas ON 
                         dbo.Formulaciones_de_fraccionamiento_de_productos.Id_presentacionfraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1 INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion INNER JOIN
                         dbo.Tipos_De_productos ON dbo.Producto1.Id_tipo = dbo.Tipos_De_productos.Id_tipo_de_producto
						 inner join dbo.Formulacion_padre_de_formulaciones_fraccionamiento_de_productos on
						 dbo.Formulacion_padre_de_formulaciones_fraccionamiento_de_productos.Id_formulacion_Formulaciones_de_fraccionamiento_de_productos=dbo.Formulaciones_de_fraccionamiento_de_productos.Id_formulacion
						 inner join dbo.detalle_venta on dbo.Formulacion_padre_de_formulaciones_fraccionamiento_de_productos.iddetalle_venta=dbo.detalle_venta.iddetalle_venta 
where dbo.Formulacion_padre_de_formulaciones_fraccionamiento_de_productos.iddetalle_venta=@Id_detalle_venta

GO
/****** Object:  StoredProcedure [dbo].[mostrar_productos_agregados_a_kardex_por_vendedor_ENTRADAS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_productos_agregados_a_kardex_por_vendedor_ENTRADAS]
@letra as int,
@fecha date
AS
SELECT        dbo.KARDEX.Id_kardex, dbo.Presentaciones_fraccionadas .Id_presentacionfraccionada ,CONVERT(VARCHAR(50),dbo.KARDEX.Cantidad) + ' UND' as Canti, (dbo.Producto1.Descripcion+' '+dbo.Presentaciones.Presentacion+
                        ' x'+ dbo.Presentaciones.Cantidad_por_presentacion+dbo.Presentaciones.Unidad_de_medida) as Producto, KARDEX.Total/KARDEX .Cantidad   as Precio_unt, KARDEX.Total  as Total,
						KARDEX.Estado, dbo.KARDEX.Cantidad as Cant
FROM            dbo.KARDEX INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.KARDEX.Id_presentacion_fraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1
					inner join Unidad_de_medida on Unidad_de_medida.Id_unidad_de_medida=Presentaciones_fraccionadas.Id_unidad 
						
						 where dbo.KARDEX .Id_usuario  =@letra and convert(date,dbo.KARDEX.Fecha) =@fecha AND DBO.KARDEX .Tipo='ENTRADA'
						 AND KARDEX.Motivo ='RECHAZO DIARIO'

GO
/****** Object:  StoredProcedure [dbo].[mostrar_productos_agregados_a_kardex_por_vendedor_id]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_productos_agregados_a_kardex_por_vendedor_id]
@letra as int,
@fecha date
AS
SELECT        dbo.KARDEX.Id_kardex, dbo.Presentaciones_fraccionadas .Id_presentacionfraccionada ,CONVERT(VARCHAR(50),dbo.KARDEX.Cantidad) + ' UND' as Canti, (dbo.Producto1.Descripcion+' '+dbo.Presentaciones.Presentacion+
                        ' x'+ dbo.Presentaciones.Cantidad_por_presentacion+dbo.Presentaciones.Unidad_de_medida) as Producto, KARDEX.Total/KARDEX .Cantidad  as Precio_unt, KARDEX. Total as Total,
						KARDEX.Estado, dbo.KARDEX.Cantidad as Cant
FROM            dbo.KARDEX INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.KARDEX.Id_presentacion_fraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1
					inner join Unidad_de_medida on Unidad_de_medida.Id_unidad_de_medida=Presentaciones_fraccionadas.Id_unidad 
						
						 where dbo.KARDEX .Id_usuario  =@letra and convert(date,dbo.KARDEX.Fecha) =@fecha AND DBO.KARDEX .Tipo='SALIDA'
						 AND (KARDEX.Motivo ='DESPACHO DIARIO DE VENDEDORES...' OR KARDEX.Motivo ='DESPACHO DE PEDIDOS')

GO
/****** Object:  StoredProcedure [dbo].[mostrar_productos_agregados_a_kardex_por_vendedor_id_buscador_para_despachos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[mostrar_productos_agregados_a_kardex_por_vendedor_id_buscador_para_despachos]
@letra as int,
@fecha date,
@letrab VARCHAR(50)
AS BEGIN
SELECT        Producto1.Id_Producto1 ,Producto1.Descripcion 
FROM            dbo.KARDEX INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.KARDEX.Id_presentacion_fraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1
					
						 where  dbo.Producto1.Descripcion  LIKE  '%' + @letrab+'%' and  dbo.KARDEX .Id_usuario  =@letra and convert(date,dbo.KARDEX.Fecha) =@fecha 
end
GO
/****** Object:  StoredProcedure [dbo].[mostrar_productos_agregados_a_kardex_por_vendedor_id_buscador_para_RECHASO]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_productos_agregados_a_kardex_por_vendedor_id_buscador_para_RECHASO]
@letra as int,
@fecha date,
@letrab VARCHAR(50)
AS BEGIN
SELECT        KARDEX.Id_presentacion_fraccionada , (dbo.Producto1.Descripcion+' '+dbo.Presentaciones.Presentacion+
                        ' x'+ dbo.Presentaciones.Cantidad_por_presentacion+dbo.Presentaciones.Unidad_de_medida) as Producto,KARDEX.Total/Cantidad    as Precio_unt
FROM            dbo.KARDEX INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.KARDEX.Id_presentacion_fraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1
					inner join Unidad_de_medida on Unidad_de_medida.Id_unidad_de_medida=Presentaciones_fraccionadas.Id_unidad 
						
						 where  (dbo.Producto1.Descripcion+' '+dbo.Presentaciones.Presentacion+
                        ' x'+ dbo.Presentaciones.Cantidad_por_presentacion+dbo.Presentaciones.Unidad_de_medida)  LIKE  '%' + @letrab+'%' and  dbo.KARDEX .Id_usuario  =@letra and convert(date,dbo.KARDEX.Fecha) =@fecha AND DBO.KARDEX.Tipo='SALIDA'
end
GO
/****** Object:  StoredProcedure [dbo].[mostrar_productos_agregados_A_PEDIDO_DE_VENTA]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_productos_agregados_A_PEDIDO_DE_VENTA]

as
SELECT       CONVERT(date, ventas.Fecha_de_pago ) as F_de_Entrega ,USUARIO2.Nombre_y_Apelllidos as Usuario ,clientes.Nombre AS Cliente,(Serializacion.Id_tipodoc +'-'+ ventas.Numero_de_doc) AS Comprobante ,(dbo.Producto1.Descripcion + '- ' + dbo.Presentaciones.Presentacion+' x'+ Presentaciones.Cantidad_por_presentacion  +Presentaciones .Unidad_de_medida  ) as Producto,(convert (varchar (50),dbo.detalle_venta.Cantidad_mostrada)+ '-'+ dbo.detalle_venta.Unidad_de_medida ) as Cant,  
                         dbo.detalle_venta.Total_a_pagar, dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada,DBO.detalle_venta.iddetalle_venta ,dbo.ventas.Estado 
						 ,dbo.detalle_venta.cantidad 
						 
FROM            dbo.detalle_venta INNER JOIN
                         dbo.ventas ON dbo.detalle_venta.idventa = dbo.ventas.idventa INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.detalle_venta.Id_presentacionfraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1 INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion     
						 INNER JOIN Serializacion ON Serializacion.Id_serializacion =ventas.Id_series 
						 INNER JOIN clientes ON clientes.idclientev=ventas.idclientev 
						 inner join USUARIO2 on USUARIO2.idUsuario=ventas.Id_usuario 
where dbo.ventas.ACCION ='PEDIDO DE VENTA' 
and  dbo.detalle_venta.Estado ='DESPACHO PENDIENTE'  order by convert(date,ventas.Fecha_de_pago) asc 

GO
/****** Object:  StoredProcedure [dbo].[mostrar_productos_agregados_a_venta]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_productos_agregados_a_venta]
@idventa as int
as
SELECT      detalle_venta . Codigo ,( detalle_venta .Descripcion ) as Producto, dbo.detalle_venta.Cantidad_mostrada as Cant, 
                         dbo.detalle_venta.preciounitario as P_Unit ,convert(numeric(18,2),dbo.detalle_venta.Total_a_pagar) as Importe, detalle_venta .Id_producto  ,DBO.detalle_venta.iddetalle_venta ,dbo.ventas.Estado 
						 , detalle_venta .Stock ,dbo.detalle_venta.cantidad ,ventas.idclientev 
						 , detalle_venta .Stock ,detalle_venta .Stock ,Usa_inventarios ,Se_vende_a 
FROM            dbo.detalle_venta INNER JOIN
                         dbo.ventas ON dbo.detalle_venta.idventa = dbo.ventas.idventa 
where dbo.detalle_venta .idventa =@idventa AND detalle_venta.cantidad >0 order by detalle_venta.iddetalle_venta desc

GO
/****** Object:  StoredProcedure [dbo].[mostrar_productos_agregados_a_venta_en_espera]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrar_productos_agregados_a_venta_en_espera]
@idventa as int
as
SELECT      ( detalle_venta .Descripcion ) as Producto, dbo.detalle_venta.Cantidad_mostrada as Cant, 
                         dbo.detalle_venta.preciounitario as P_Unit ,dbo.detalle_venta.Total_a_pagar as Importe
FROM            dbo.detalle_venta INNER JOIN
                         dbo.ventas ON dbo.detalle_venta.idventa = dbo.ventas.idventa 
where dbo.detalle_venta .idventa =@idventa AND detalle_venta.cantidad >0

GO
/****** Object:  StoredProcedure [dbo].[mostrar_productos_agregados_a_venta_historial]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_productos_agregados_a_venta_historial]
@idventa as int
as
SELECT      detalle_venta . Codigo ,( detalle_venta .Descripcion ) as Producto, dbo.detalle_venta.Cantidad_mostrada as Cant, 
                         dbo.detalle_venta.preciounitario as P_Unit ,dbo.detalle_venta.Total_a_pagar as Importe, detalle_venta .Id_producto  ,DBO.detalle_venta.iddetalle_venta ,dbo.ventas.Estado 
						 , detalle_venta .Stock ,dbo.detalle_venta.cantidad ,ventas.idclientev
						  ,Usa_inventarios ,Se_vende_a ,ventas.Porcentaje_IGV
FROM            dbo.detalle_venta INNER JOIN
                         dbo.ventas ON dbo.detalle_venta.idventa = dbo.ventas.idventa  
where dbo.detalle_venta .idventa =@idventa AND detalle_venta.cantidad >0 and ventas.Estado <>'SIN CONFIRMAR'

GO
/****** Object:  StoredProcedure [dbo].[mostrar_productos_agregados_a_venta_PENDIENTES_dE_DESPACHO]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_productos_agregados_a_venta_PENDIENTES_dE_DESPACHO]
@idventa as int
as
SELECT        (dbo.Producto1.Descripcion +'-'+ dbo.Presentaciones.Presentacion) as Producto, (convert (varchar (50),dbo.detalle_venta.Cantidad_mostrada)+ '-'+ dbo.detalle_venta.Unidad_de_medida ) as Cant, 
                         dbo.detalle_venta.preciounitario as Precio_Unit ,dbo.detalle_venta.Total_a_pagar, dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada,DBO.detalle_venta.iddetalle_venta ,dbo.detalle_venta.Estado 
						 ,dbo.Presentaciones_fraccionadas.Stock ,dbo.detalle_venta.cantidad ,dbo.ventas.idventa 
FROM            dbo.detalle_venta INNER JOIN
                         dbo.ventas ON dbo.detalle_venta.idventa = dbo.ventas.idventa INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.detalle_venta.Id_presentacionfraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1 INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion     
where dbo.detalle_venta .idventa =@idventa AND DBO.detalle_venta .Estado='DESPACHO PENDIENTE'

GO
/****** Object:  StoredProcedure [dbo].[mostrar_productos_agregados_a_venta_servicios]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_productos_agregados_a_venta_servicios]
@idventa as int
as
SELECT        dbo.Servicio_de_fraccionamiento.Descripcion, dbo.Presentaciones.Presentacion, dbo.Detalle_venta_de_servicios.cantidad, 
                         dbo.Detalle_venta_de_servicios.Total_a_pagar, dbo.Presentaciones_fraccionadas_fraccionamiento.Id_presentacion_fraccionamiento, 
                         dbo.Detalle_venta_de_servicios.Id_detalle_venta_servicio
FROM            dbo.Detalle_venta_de_servicios INNER JOIN
                         dbo.ventas ON dbo.Detalle_venta_de_servicios.idventa = dbo.ventas.idventa INNER JOIN
                         dbo.Presentaciones_fraccionadas_fraccionamiento ON 
                         dbo.Detalle_venta_de_servicios.Id_presentacion_fraccionamiento = dbo.Presentaciones_fraccionadas_fraccionamiento.Id_presentacion_fraccionamiento INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas_fraccionamiento.Id_presentacion = dbo.Presentaciones.Id_Presentacion INNER JOIN
                         dbo.Servicio_de_fraccionamiento ON 
                         dbo.Presentaciones_fraccionadas_fraccionamiento.Id_servicio = dbo.Servicio_de_fraccionamiento.Id_detalle_fraccionamiento_lote
where dbo.Detalle_venta_de_servicios .idventa =@idventa 

GO
/****** Object:  StoredProcedure [dbo].[mostrar_productos_para_ventas]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_productos_para_ventas]
as
SELECT        (dbo.Producto1.Descripcion +' '+dbo.Presentaciones.Presentacion+ ' x'+dbo.Presentaciones.Cantidad_por_presentacion+ dbo.Presentaciones.Unidad_de_medida) as Descripcion,dbo.Producto1.Id_Producto1 ,
                       
                        dbo.Producto1.Imagen ,Presentaciones_fraccionadas.Id_presentacionfraccionada 
                  
FROM            
                         dbo.Producto1 INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.Producto1.Id_Producto1 = dbo.Presentaciones_fraccionadas.Id_producto INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion


GO
/****** Object:  StoredProcedure [dbo].[mostrar_productos_para_ventas_por_linea]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_productos_para_ventas_por_linea]
@idlinea as varchar(50)
as
SELECT        (dbo.Producto1.Descripcion +' '+dbo.Presentaciones.Presentacion+ ' x'+dbo.Presentaciones.Cantidad_por_presentacion+ dbo.Presentaciones.Unidad_de_medida) as Descripcion,dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada  ,
                       
                        dbo.Producto1.Id_Producto1  
                  
FROM            
                         dbo.Producto1 inner join 
						 
					
                         dbo.Presentaciones_fraccionadas ON dbo.Producto1.Id_Producto1 = dbo.Presentaciones_fraccionadas.Id_producto INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion


						 where Producto1.Linea=@idlinea  



GO
/****** Object:  StoredProcedure [dbo].[mostrar_productos2]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_productos2]
as
select * from productos2







GO
/****** Object:  StoredProcedure [dbo].[mostrar_produtos_para_kardex_por_id]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_produtos_para_kardex_por_id]
@letra as int
AS
SELECT       dbo.Producto1.Id_Producto1, (dbo.Producto1.Descripcion +' '+dbo.Presentaciones.Presentacion+ ' x'+dbo.Presentaciones.Cantidad_por_presentacion+ dbo.Presentaciones.Unidad_de_medida) as Descripcion 
                ,Presentaciones_fraccionadas.Precio_de_venta_por_presentacion /Unidad_de_medida.Cantidad_por_unidad_de_medida as Precio_unit     ,Presentaciones_fraccionadas.Stock   
                  ,Producto1.Servicio 
FROM            
                         dbo.Producto1 INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.Producto1.Id_Producto1 = dbo.Presentaciones_fraccionadas.Id_producto INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion

						 inner join Unidad_de_medida on Unidad_de_medida.Id_unidad_de_medida=Presentaciones_fraccionadas.Id_unidad 
						 
						 where dbo.Producto1 .Id_Producto1 =@letra

GO
/****** Object:  StoredProcedure [dbo].[mostrar_programaciones_de_fraccionamiento_de_productos_para_emitir_ordenes_de_fraccionamiento_de_productos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_programaciones_de_fraccionamiento_de_productos_para_emitir_ordenes_de_fraccionamiento_de_productos]
@fecha_a_fraccionar as date
as
SELECT        dbo.detalle_venta.iddetalle_venta, dbo.detalle_venta.idventa, dbo.detalle_venta.Id_presentacionfraccionada, 
                         dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Actividad, dbo.Producto1.Descripcion, dbo.Presentaciones.Presentacion, dbo.detalle_venta.cantidad, 
                         dbo.detalle_venta.Unidad_de_medida
                         
FROM            dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES INNER JOIN
  dbo.Turno ON dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Id_turno_programado = dbo.Turno.Id_turno inner join 
						 dbo.detalle_venta ON dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Id_detalle_venta = dbo.detalle_venta.iddetalle_venta INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.detalle_venta.Id_presentacionfraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1 
						
						 where dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES . Fecha_programada = @fecha_a_fraccionar 

						 group by   dbo.detalle_venta.iddetalle_venta, dbo.detalle_venta.idventa, dbo.detalle_venta.Id_presentacionfraccionada, 
                         dbo.PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES.Actividad, dbo.Producto1.Descripcion, dbo.Presentaciones.Presentacion, dbo.detalle_venta.cantidad, 
                         dbo.detalle_venta.Unidad_de_medida

GO
/****** Object:  StoredProcedure [dbo].[mostrar_proveedor_con_deuda]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_proveedor_con_deuda]
as
select * from proveedores  where Resta>0




GO
/****** Object:  StoredProcedure [dbo].[mostrar_PROVEEEDOR]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_PROVEEEDOR]
as
SELECT        idclientev, Nombre, Direccion_para_factura as Direccion, Ruc, movil as Celular, Cliente, Proveedor, 
                    clientes.Saldo ,     Estado as Activo
FROM            dbo.clientes 
WHERE clientes.Proveedor ='SI' order by Nombre  asc 


GO
/****** Object:  StoredProcedure [dbo].[mostrar_requerimiento_diario]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_requerimiento_diario]

as
SELECT        dbo.clientes.Nombre,  dbo.ventas.fecha_venta, (dbo.Producto1.Descripcion + '-'+  DBO.Presentaciones.Presentacion ) AS PRODUCTO, 
                         dbo.Presentaciones.Presentacion, dbo.detalle_venta.cantidad, 
                       dbo.Tipo_de_documento.Tipo_de_documento, dbo.ventas.Numero_de_doc,DBO.detalle_venta.Estado ,DBO.detalle_venta.Unidad_de_medida ,DBO.detalle_venta.Cantidad_mostrada 
FROM            dbo.ventas INNER JOIN
                         dbo.clientes ON dbo.ventas.idclientev = dbo.clientes.idclientev INNER JOIN
                         dbo.detalle_venta ON dbo.ventas.idventa = dbo.detalle_venta.idventa INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.detalle_venta.Id_presentacionfraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1 INNER JOIN
                         dbo.Serializacion ON dbo.ventas.Id_series = dbo.Serializacion.Id_serializacion INNER JOIN
                         dbo.Tipo_de_documento ON dbo.Serializacion.Id_tipodoc = dbo.Tipo_de_documento.Id_tipodoc
						 where dbo.detalle_venta.Estado='DESPACHO PENDIENTE'

GO
/****** Object:  StoredProcedure [dbo].[mostrar_resultado_de_utilizacion_de_materiales_en_fraccionamiento_De_productos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_resultado_de_utilizacion_de_materiales_en_fraccionamiento_De_productos]
@iddetalleventa as int
as
SELECT        dbo.Formulaciones_de_fraccionamiento_de_productos.Id_formulacion, dbo.Producto1.Descripcion, dbo.Presentaciones.Presentacion, 
                         dbo.Tipos_De_productos.Descripcion AS Tipo_de_producto, dbo.Formulaciones_de_fraccionamiento_de_productos.Cantidad 
                        , dbo.Formulaciones_de_fraccionamiento_de_productos.Unidad_de_medida, dbo.Formulaciones_de_fraccionamiento_de_productos.Costo,dbo.Formulaciones_de_fraccionamiento_de_productos.Total_parcial,dbo.ventas.idventa 
						,
						dbo.ORDEN_DE_FRACCIONAMINETO_DE_PRODUCTOS.Numero_de_produccion ,dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada 
FROM            dbo.Formulaciones_de_fraccionamiento_de_productos INNER JOIN
                         dbo.Presentaciones_fraccionadas ON 
                         dbo.Formulaciones_de_fraccionamiento_de_productos.Id_presentacionfraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1 INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion INNER JOIN
                         dbo.Tipos_De_productos ON dbo.Producto1.Id_tipo = dbo.Tipos_De_productos.Id_tipo_de_producto
						 inner join dbo.Formulacion_padre_de_formulaciones_fraccionamiento_de_productos on
						 dbo.Formulacion_padre_de_formulaciones_fraccionamiento_de_productos.Id_formulacion_Formulaciones_de_fraccionamiento_de_productos=dbo.Formulaciones_de_fraccionamiento_de_productos.Id_formulacion
						 inner join dbo.detalle_venta on dbo.Formulacion_padre_de_formulaciones_fraccionamiento_de_productos.iddetalle_venta=dbo.detalle_venta.iddetalle_venta 
						 inner join dbo.ventas on dbo.detalle_venta.idventa =dbo.ventas.idventa 
						
						
						 INNER JOIN dbo.ORDEN_DE_FRACCIONAMINETO_DE_PRODUCTOS on dbo.ORDEN_DE_FRACCIONAMINETO_DE_PRODUCTOS.Id_detalleventa=dbo.detalle_venta.iddetalle_venta 


where dbo.ORDEN_DE_FRACCIONAMINETO_DE_PRODUCTOS.Id_detalleventa  =@iddetalleventa and dbo.detalle_venta.Estado<>'PRODUCCION CONCLUIDA'


GO
/****** Object:  StoredProcedure [dbo].[MOSTRAR_RESULTADOS_DE_FRACCIONAMIENTO_DE_PRODUCTOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[MOSTRAR_RESULTADOS_DE_FRACCIONAMIENTO_DE_PRODUCTOS]
@iddetalle_venta as int
as
SELECT        dbo.RESULTADO_DE_FRACCIONAMIENTO_DE_PRODUCTOS.Id_detalle_de_venta, dbo.RESULTADO_DE_FRACCIONAMIENTO_DE_PRODUCTOS.Cantidad, 
                         dbo.RESULTADO_DE_FRACCIONAMIENTO_DE_PRODUCTOS.Unidad_de_medida, 
                         dbo.RESULTADO_DE_FRACCIONAMIENTO_DE_PRODUCTOS.Fecha_de_produccion, 
                         dbo.RESULTADO_DE_FRACCIONAMIENTO_DE_PRODUCTOS.Fecha_de_vencimiento, dbo.RESULTADO_DE_FRACCIONAMIENTO_DE_PRODUCTOS.Numero_de_lote, 
                         dbo.Almacen_padre_prod_terminado.Descripcion, dbo.RESULTADO_DE_FRACCIONAMIENTO_DE_PRODUCTOS.Doc_referencia, dbo.Producto1.Descripcion AS Producto,
                          dbo.Presentaciones.Presentacion, dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada
FROM            dbo.RESULTADO_DE_FRACCIONAMIENTO_DE_PRODUCTOS INNER JOIN
                         dbo.detalle_venta ON dbo.RESULTADO_DE_FRACCIONAMIENTO_DE_PRODUCTOS.Id_detalle_de_venta = dbo.detalle_venta.iddetalle_venta INNER JOIN
                         dbo.Almacen_padre_prod_terminado ON 
                         dbo.RESULTADO_DE_FRACCIONAMIENTO_DE_PRODUCTOS.Id_almacen = dbo.Almacen_padre_prod_terminado.Id_almacen_padre_prod_terminado INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.detalle_venta.Id_presentacionfraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1
						 where dbo.RESULTADO_DE_FRACCIONAMIENTO_DE_PRODUCTOS.Id_detalle_de_venta   = @iddetalle_venta and dbo.detalle_venta.Estado<>'PRODUCCION CONCLUIDA'

GO
/****** Object:  StoredProcedure [dbo].[mostrar_RUTAS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_RUTAS]
@Id_ruta as int
as
SELECT        dbo.ASIGNACION_DE_CLIENTES_A_RUTAS.Id_ruta, dbo.RUTAS.Nombre AS RUTA, dbo.clientes.Nombre AS CLIENTE, dbo.clientes.Direccion_para_factura
FROM            dbo.ASIGNACION_DE_CLIENTES_A_RUTAS INNER JOIN
                         dbo.clientes ON dbo.ASIGNACION_DE_CLIENTES_A_RUTAS.Id_cliente = dbo.clientes.idclientev INNER JOIN
                         dbo.RUTAS ON dbo.ASIGNACION_DE_CLIENTES_A_RUTAS.Id_ruta = dbo.RUTAS.Id_ruta
						 WHERE dbo.ASIGNACION_DE_CLIENTES_A_RUTAS.Id_ruta=@Id_ruta 

GO
/****** Object:  StoredProcedure [dbo].[MOSTRAR_RUTAS_POR_VENDEDOR]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[MOSTRAR_RUTAS_POR_VENDEDOR]
@idusuario as int
as
SELECT        dbo.USUARIO2.Nombre_y_Apelllidos, dbo.COBERTURA.Nombre, dbo.RUTAS.Codigo, dbo.RUTAS.Nombre AS RUTA, dbo.clientes.Nombre AS CLINTE, 
                         dbo.clientes.Direccion_para_factura,DBO.clientes.movil ,DBO.clientes.telefono , dbo.Designacion_de_rutas.Fecha, dbo.RUTAS.Norte, dbo.RUTAS.Sur, dbo.RUTAS.Este, dbo.RUTAS.Oeste
						, DBO.ASIGNACION_DE_CLIENTES_A_RUTAS.Estado , dbo.ASIGNACION_DE_CLIENTES_A_RUTAS.OBSERVACIONES
FROM            dbo.RUTAS INNER JOIN
                         dbo.COBERTURA ON dbo.RUTAS.Id_covertura = dbo.COBERTURA.Id_covertura INNER JOIN
                         dbo.Designacion_de_rutas ON dbo.RUTAS.Id_ruta = dbo.Designacion_de_rutas.Id_ruta INNER JOIN
                         dbo.ASIGNACION_DE_CLIENTES_A_RUTAS ON dbo.RUTAS.Id_ruta = dbo.ASIGNACION_DE_CLIENTES_A_RUTAS.Id_ruta INNER JOIN
                         dbo.USUARIO2 ON dbo.Designacion_de_rutas.Id_usuario = dbo.USUARIO2.idUsuario INNER JOIN
                         dbo.clientes ON dbo.ASIGNACION_DE_CLIENTES_A_RUTAS.Id_cliente = dbo.clientes.idclientev
						 WHERE dbo.USUARIO2.idUsuario=@idusuario 

GO
/****** Object:  StoredProcedure [dbo].[mostrar_saldo]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_saldo]
as
SELECT        dbo.Saldo.Id_Saldo, dbo.Saldo.Id_Cliente, dbo.clientes.Nombres_y_Apellidos, dbo.clientes.dni, dbo.Saldo.Monto_Total, dbo.Saldo.Resta, 
                         dbo.Saldo.Pago_en_partes, dbo.Saldo.Fecha_que_Pago_en_partes
FROM            dbo.Saldo INNER JOIN
                         dbo.clientes ON dbo.Saldo.Id_Cliente = dbo.clientes.idclientev




GO
/****** Object:  StoredProcedure [dbo].[MOSTRAR_SALDO_DE_CAJA_RESUMEN]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[MOSTRAR_SALDO_DE_CAJA_RESUMEN]
as
SELECT        dbo.CIERRE_DE_CAJA_PADRE.Id_cierre_de_caja, dbo.Caja.Descripcion, dbo.CIERRE_DE_CAJA_PADRE.Saldo_que_queda_en_caja
,Fecha_de_cierre 
FROM            dbo.CIERRE_DE_CAJA_PADRE INNER JOIN
                         dbo.Caja ON dbo.CIERRE_DE_CAJA_PADRE.Id_caja = dbo.Caja.Id_Caja
						 WHERE Saldo_que_queda_en_caja>0
GROUP BY dbo.CIERRE_DE_CAJA_PADRE.Id_cierre_de_caja, dbo.Caja.Descripcion, dbo.CIERRE_DE_CAJA_PADRE.Saldo_que_queda_en_caja,Fecha_de_cierre 

GO
/****** Object:  StoredProcedure [dbo].[mostrar_SERVICIOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_SERVICIOS]
as 
SELECT     dbo.SERVICIOS.Idpago_Servicio, dbo.SERVICIOS.Id_servicio,   dbo.nombredeservicio.Servicio, dbo.SERVICIOS.Fecha_de_Pago, dbo.SERVICIOS.Total_a_Pagar, dbo.SERVICIOS.Resta, 
                         dbo.SERVICIOS.Pago_en_Partes, dbo.SERVICIOS.Fecha_de_Pago_enPartes, dbo.SERVICIOS.Estado,
                         dbo.SERVICIOS.Acumulado_Pagopartes
FROM            dbo.SERVICIOS INNER JOIN
                         dbo.nombredeservicio ON dbo.SERVICIOS.Id_servicio = dbo.nombredeservicio.Id_nombreServicio
WHERE Resta >0




GO
/****** Object:  StoredProcedure [dbo].[mostrar_servicios_de_fraccionamiento]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_servicios_de_fraccionamiento]
as
SELECT     * from Servicio_de_fraccionamiento  
                  
						 ORDER BY DBO.Servicio_de_fraccionamiento.Id_detalle_fraccionamiento_lote  DESC
						 --WHERE DBO.Producto1.Produccion='SI' 

GO
/****** Object:  StoredProcedure [dbo].[mostrar_solo_saldo_cliente_proveedor]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[mostrar_solo_saldo_cliente_proveedor]
@id int
as
SELECT  Saldo  from clientes  
where idclientev =@id
GO
/****** Object:  StoredProcedure [dbo].[mostrar_tipo_de_documento]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_tipo_de_documento]
as
select*from Tipo_de_documento 


GO
/****** Object:  StoredProcedure [dbo].[mostrar_Tipo_de_documentos_para_CANJEAR_EN_VENTAS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_Tipo_de_documentos_para_CANJEAR_EN_VENTAS]
as

SELECT        dbo.Tipo_de_documento.Tipo_de_documento, dbo.Tipo_de_documento.Descripcion  ,dbo.Serializacion.Serie ,dbo.Serializacion.numeroinicio , dbo.Serializacion.numerofin ,dbo.Serializacion.Id_serializacion ,(dbo.Serializacion.Serie  +' - '+ dbo.Serializacion.numeroinicio + dbo.Serializacion.numerofin) as serie_completa,Serializacion.Id_tipodoc,dbo.Tipo_de_documento.Ventas,
dbo.Tipo_de_documento.Compras ,dbo.Tipo_de_documento.Accion_en_stock 
FROM            dbo.Serializacion INNER JOIN
                         dbo.Tipo_de_documento ON dbo.Serializacion.Id_tipodoc = dbo.Tipo_de_documento.Id_tipodoc
						 where dbo.Tipo_de_documento.Ventas ='SI' AND dbo.Tipo_de_documento.Accion_en_stock <> 'NULO'


GO
/****** Object:  StoredProcedure [dbo].[mostrar_Tipo_de_documentos_para_insertar_en_COMPRAS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_Tipo_de_documentos_para_insertar_en_COMPRAS]
as

SELECT        dbo.Tipo_de_documento.Tipo_de_documento, dbo.Tipo_de_documento.Descripcion  ,dbo.Serializacion.Serie ,dbo.Serializacion.numeroinicio , dbo.Serializacion.numerofin ,dbo.Serializacion.Id_serializacion ,(dbo.Serializacion.Serie  +' - '+ dbo.Serializacion.numeroinicio + dbo.Serializacion.numerofin) as serie_completa,Serializacion.Id_tipodoc,dbo.Tipo_de_documento.Ventas,
dbo.Tipo_de_documento.Compras ,dbo.Tipo_de_documento.Accion_en_stock 
FROM            dbo.Serializacion INNER JOIN
                         dbo.Tipo_de_documento ON dbo.Serializacion.Id_tipodoc = dbo.Tipo_de_documento.Id_tipodoc
						 where dbo.Tipo_de_documento.Compras  ='SI'


GO
/****** Object:  StoredProcedure [dbo].[mostrar_Tipo_de_documentos_para_insertar_en_COMPRAS_OKA]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_Tipo_de_documentos_para_insertar_en_COMPRAS_OKA]
as

SELECT        Serializacion.Id_tipodoc+' '+Serie  AS COMPROBANTE , Serializacion.Id_tipodoc  ,dbo.Serializacion.Serie ,dbo.Serializacion.numeroinicio , dbo.Serializacion.numerofin ,dbo.Serializacion.Id_serializacion ,(dbo.Serializacion.Serie  +' - '+ dbo.Serializacion.numeroinicio + dbo.Serializacion.numerofin) as serie_completa,Serializacion.Id_tipodoc,Serializacion.Id_tipodoc 
FROM            dbo.Serializacion 
 where dbo.Serializacion .Destino  ='COMPRAS'
GO
/****** Object:  StoredProcedure [dbo].[mostrar_Tipo_de_documentos_para_insertar_en_ventas]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_Tipo_de_documentos_para_insertar_en_ventas]
as

SELECT        Serializacion.Id_tipodoc AS COMPROBANTE , Serializacion.Id_tipodoc  ,dbo.Serializacion.Serie ,dbo.Serializacion.numeroinicio , dbo.Serializacion.numerofin+1 ,dbo.Serializacion.Id_serializacion ,(dbo.Serializacion.Serie  +' - '+ dbo.Serializacion.numeroinicio + dbo.Serializacion.numerofin) as serie_completa,Serializacion.Id_tipodoc,Serializacion.Id_tipodoc 
FROM            dbo.Serializacion 
 where dbo.Serializacion .Destino  ='VENTAS'

GO
/****** Object:  StoredProcedure [dbo].[mostrar_Tipo_de_documentos_para_insertar_estos_mismos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_Tipo_de_documentos_para_insertar_estos_mismos]
as

SELECT       dbo.Serializacion.Serie ,dbo.Serializacion.numeroinicio , dbo.Serializacion.numerofin ,dbo.Serializacion.Id_serializacion ,(dbo.Serializacion.Serie  +' - '+ dbo.Serializacion.numeroinicio + dbo.Serializacion.numerofin) as serie_completa,Serializacion.Id_tipodoc AS COMPROBANTE

FROM            dbo.Serializacion 
GO
/****** Object:  StoredProcedure [dbo].[mostrar_Tipo_de_documentos_serializados]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_Tipo_de_documentos_serializados]
as

SELECT        dbo.Tipo_de_documento.Tipo_de_documento  ,( dbo.Serializacion.Serie + ' - '+ dbo.Serializacion.numeroinicio + dbo.Serializacion.numerofin) as Serie_completa,dbo.Serializacion.Id_serializacion 
FROM            dbo.Serializacion INNER JOIN
                         dbo.Tipo_de_documento ON dbo.Serializacion.Id_tipodoc = dbo.Tipo_de_documento.Id_tipodoc
						 
						


GO
/****** Object:  StoredProcedure [dbo].[mostrar_Tipo_de_documentos_serializados_para_canjerar_comprobantes_de_venta]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_Tipo_de_documentos_serializados_para_canjerar_comprobantes_de_venta]
as

SELECT        dbo.Tipo_de_documento.Tipo_de_documento  ,( dbo.Serializacion.Serie + ' - '+ dbo.Serializacion.numeroinicio + dbo.Serializacion.numerofin) as Serie_completa,dbo.Serializacion.Id_serializacion 
FROM            dbo.Serializacion INNER JOIN
                         dbo.Tipo_de_documento ON dbo.Serializacion.Id_tipodoc = dbo.Tipo_de_documento.Id_tipodoc
						 where dbo.Serializacion.Id_serializacion < '4' 
						 
						


GO
/****** Object:  StoredProcedure [dbo].[mostrar_turnos_agregados]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_turnos_agregados]
@Id_personal int
as
SELECT        dbo.Turno.Desde, dbo.Turno.Hasta, dbo.Turno.Descripcion
FROM            dbo.Personal INNER JOIN
                         dbo.Asignacion_de_turnos_a_personal ON dbo.Personal.Id_personal = dbo.Asignacion_de_turnos_a_personal.Id_personal INNER JOIN
                         dbo.Turno ON dbo.Asignacion_de_turnos_a_personal.Id_turno = dbo.Turno.Id_turno
where dbo.Personal.Id_personal=@Id_personal 

GO
/****** Object:  StoredProcedure [dbo].[mostrar_TURNOS_PLANIFICADOS_fecha_inicial]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_TURNOS_PLANIFICADOS_fecha_inicial]
@FECHAINICIAL AS DATE
as
select * from TURNOS_PLANIFICADOS_fecha_inicial 
WHERE Fecha_planificada_inicial=@FECHAINICIAL 

GO
/****** Object:  StoredProcedure [dbo].[mostrar_TURNOS_PLANIFICADOS_FINAL]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_TURNOS_PLANIFICADOS_FINAL]
@FECHAFINAL AS DATE
as
select * from TURNOS_PLANIFICADOS_FINAL 
WHERE Fecha_planificada_final =@FECHAFINAL 

GO
/****** Object:  StoredProcedure [dbo].[mostrar_UBICACIONES_sin_repetir]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[mostrar_UBICACIONES_sin_repetir]

AS BEGIN
SET NOCOUNT ON;
SELECT DISTINCT  
      Ubicacion 
FROM           Presentaciones_fraccionadas  
                       
end


GO
/****** Object:  StoredProcedure [dbo].[mostrar_unidades]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  proc [dbo].[mostrar_unidades]

AS BEGIN
SET NOCOUNT ON;
SELECT DISTINCT Id_unidad_de_medida ,(Unidad_de_medida + ' ('+Cantidad_por_unidad_de_medida+ 'UND'+')') AS Unidad_de_medida,Cantidad_por_unidad_de_medida 
 ,Unidad_de_medida AS Unidad
FROM           Unidad_de_medida  


END


GO
/****** Object:  StoredProcedure [dbo].[mostrar_usuario]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_usuario]
as 
select USUARIO2 .idUsuario,USUARIO2.Nombre_y_Apelllidos as [Nombres] ,USUARIO2 .Login as Usuario,USUARIO2.Password as Contraseña,permisos.*
from USUARIO2 inner join permisos on permisos.Id_Usuario =USUARIO2.idUsuario 

GO
/****** Object:  StoredProcedure [dbo].[mostrar_usuario_POR_ID]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_usuario_POR_ID]
@ID INT
as 
select *
from USUARIO2 inner join Permisos on Permisos. Id_Usuario=USUARIO2.idUsuario

WHERE USUARIO2.idUsuario=@ID 
order by USUARIO2.idUsuario desc



GO
/****** Object:  StoredProcedure [dbo].[mostrar_USUARIO_por_nombre_contrasenia]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[mostrar_USUARIO_por_nombre_contrasenia]
@letra VARCHAR(50),
@pas varchar(50)
AS BEGIN
SELECT        idUsuario, Login ,Password ,Nombre_y_Apelllidos 
FROM            dbo.USUARIO2						 
WHEre Login =@letra  AND Password=@pas
END

GO
/****** Object:  StoredProcedure [dbo].[mostrar_vales_para_canjear_comprobantes]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[mostrar_vendedores]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_vendedores]
as 
select * from USUARIO2






GO
/****** Object:  StoredProcedure [dbo].[mostrar_ventas_en_espera]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_ventas_en_espera]

as
SELECT      count(ventas.idventa ) as id_ventas, count(ventas.idventa ) as id_producto
FROM            dbo.ventas
             
where  
 ventas.Estado='EN ESPERA'or  ventas.Estado='SIN CONFIRMAR'

 union 
 SELECT      count(ventas.idventa  ) as id_ventas,count(ventas.idventa ) as id_producto
FROM            dbo.ventas inner join detalle_venta on detalle_venta.idventa =detalle_venta.idventa  
             
where  
 ventas.Estado='EN ESPERA'or  ventas.Estado='SIN CONFIRMAR'
GO
/****** Object:  StoredProcedure [dbo].[mostrar_ventas_en_espera_con_fecha_y_monto]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_ventas_en_espera_con_fecha_y_monto]

		AS   

SELECT      idventa,Comprobante,convert(varchar,datepart(hour,fecha_venta))+':'+convert(varchar,datepart(MINUTE ,fecha_venta))
FROM            dbo.ventas       	        
where  (ventas.Estado='EN ESPERA' or  ventas.Estado='SIN CONFIRMAR') and convert(date,ventas.fecha_venta) =convert(date,GETDATE())

union

SELECT      idventa,Comprobante,convert(varchar(50),convert(date,ventas.fecha_venta)) as dia
FROM            dbo.ventas       	        
where ( ventas.Estado='EN ESPERA' or  ventas.Estado='SIN CONFIRMAR') and convert(date,ventas.fecha_venta) < convert(date,GETDATE()) 







GO
/****** Object:  StoredProcedure [dbo].[mostrar_ventas_para_canjeo]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[mostrar_ventas_realizadas]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[mostrar_ventas_realizadas_pendientes_de_despacho]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[mostrar_ventas_realizadas_por_idventa]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[mostrar_zonas_sinrepeticion]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   proc [dbo].[mostrar_zonas_sinrepeticion]

AS
	SET NOCOUNT ON;
SELECT DISTINCT Zona
FROM           Precios




GO
/****** Object:  StoredProcedure [dbo].[mostras_ventaspormeses]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostras_ventaspormeses]

as
select month(dbo.ventas.fecha_venta )as mes , sum(dbo.ventas.Monto_total) as importe
from dbo.ventas 
where month(dbo.ventas.fecha_venta)  BETWEEN 0 AND 12 GROUP BY MONTH(dbo.ventas.fecha_venta ) 





GO
/****** Object:  StoredProcedure [dbo].[NOTIFICADOR_COBROS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[NOTIFICADOR_COBROS]

as 
SELECT       Saldo ,Nombre 
FROM          
                         dbo.clientes 
						 WHERE Saldo >0 AND Cliente ='SI'
GO
/****** Object:  StoredProcedure [dbo].[NOTIFICADOR_PAGOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[pagar_CONTROL_DE_pagos_a_proveedores]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pagar_CONTROL_DE_pagos_a_proveedores]
@Id_cliente as int,
@Monto numeric(18,2)
as 
update CONTROL_DE_PAGOS_A_PROVEEDORES  set Monto=Monto - @Monto 
where Id_proveedor     =@Id_cliente  
GO
/****** Object:  StoredProcedure [dbo].[Poner_nombre_a_venta_en_espera]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Poner_nombre_a_venta_en_espera]
@id_venta int,
@nombre as varchar(50)
as
update ventas   set Comprobante=@nombre, Estado = 'EN ESPERA' where idventa   =@id_venta 
GO
/****** Object:  StoredProcedure [dbo].[PRUEBA_DE_NOTIFIC]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[PRUEBA_DE_NOTIFIC]
 AS
 select COUNT (iddetalle_venta  )as idprod from detalle_venta 
GO
/****** Object:  StoredProcedure [dbo].[REPORT_CIERRE_DE_CAJA_diaria_por_fechadiaria]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[REPORT_CIERRE_DE_CAJA_diaria_por_fechadiaria]
@IDCAJA AS INT,
@fecha_a_consultar as date
as

SELECT        dbo.Caja.Id_Caja, dbo.Caja.Descripcion, dbo.CIERRE_DE_CAJA_PADRE.Fecha_de_inicio, dbo.CIERRE_DE_CAJA_PADRE.Fecha_de_cierre, 
                         dbo.CIERRE_DE_CAJA_PADRE.Ingresos, dbo.CIERRE_DE_CAJA_PADRE.Egresos, dbo.CIERRE_DE_CAJA_PADRE.Saldo_que_queda_en_caja, 
                         dbo.CIERRE_DE_CAJA_PADRE.Total_calculado, dbo.CIERRE_DE_CAJA_PADRE.Total_real, dbo.CIERRE_DE_CAJA_PADRE.Diferencia, dbo.CIERRE_DE_CAJA_PADRE.Estado 
                       ,  dbo.USUARIO2.Nombre_y_Apelllidos,DBO.CIERRE_DE_CAJA_PADRE.Saldo_que_queda_en_caja 
FROM            dbo.Caja INNER JOIN
                         dbo.CIERRE_DE_CAJA_PADRE ON dbo.Caja.Id_Caja = dbo.CIERRE_DE_CAJA_PADRE.Id_caja INNER JOIN
                         dbo.USUARIO2 ON dbo.CIERRE_DE_CAJA_PADRE.Id_usuario = dbo.USUARIO2.idUsuario
						  where dbo.CIERRE_DE_CAJA_PADRE.Id_caja  =@IDCAJA  and Cast(dbo.CIERRE_DE_CAJA_PADRE .Fecha_de_cierre  As Date) =@fecha_a_consultar and Cast(dbo.CIERRE_DE_CAJA_PADRE .Fecha_de_cierre  As Date) =@fecha_a_consultar 
GO
/****** Object:  StoredProcedure [dbo].[REPORT_CIERRE_DE_CAJA_diaria_por_TURNOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[REPORT_CIERRE_DE_CAJA_diaria_por_TURNOS]
@id_caja AS INT,
@fi as DATE,
@ff as DATEtime
as

select SUM(Monto_total)  from ventas 
where Tipo_de_pago ='EFECTIVO' AND 
(fecha_venta >=@fi and fecha_venta<=@ff )AND Id_caja=@id_caja
GO
/****** Object:  StoredProcedure [dbo].[REPORT_COBROS_A_CLIENTES_POR_PERIODOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[REPORT_COBROS_EN_EFECTIVO_por_turnos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[REPORT_COBROS_EN_EFECTIVO_por_turnos]
@id_caja AS INT,
@fi as DATE,
@ff as DATETIME
as

select SUM(Pago_realizado )  from DETALLE_CONTROL_DE_COBROS     where  
(Fecha_que_pago >=@fi AND Fecha_que_pago<=@ff )AND Id_caja=@id_caja AND Tipo_de_cobro ='EFECTIVO' and DETALLE_CONTROL_DE_COBROS.Detalle ='COBRO'


GO
/****** Object:  StoredProcedure [dbo].[REPORT_COMPRAS_DETALLADO_POR_PERIODOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[REPORT_COMPRAS_DETALLADO_POR_PERIODOS]
@fecha_inicial as date,
@fecha_final as date
as
SELECT        dbo.Compra.Fecha_compra, dbo.Tipo_de_documento.Tipo_de_documento, dbo.Compra.N_Documento, dbo.Compra.IGV, dbo.Producto1.Descripcion, 
                         dbo.Presentaciones.Presentacion, dbo.Detalle_Compra.Unidad_de_medida, dbo.Detalle_Compra.Cantidad_mostrada, dbo.Detalle_Compra.Precio_compra, 
                         dbo.Compra.Tipo_de_pago,DBO.clientes.Cliente ,DBO.Detalle_Compra.Total_a_pagar 
						 ,@fecha_inicial AS DESDE ,@fecha_final AS HASTA
FROM            dbo.Compra INNER JOIN
                         dbo.Detalle_Compra ON dbo.Compra.Cod_compra = dbo.Detalle_Compra.idcompra INNER JOIN
                         dbo.clientes ON dbo.Compra.idproveedor = dbo.clientes.idclientev INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.Detalle_Compra.Id_presentacionfraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1 INNER JOIN
                         dbo.Serializacion ON dbo.Compra.Id_series = dbo.Serializacion.Id_serializacion INNER JOIN
                         dbo.Tipo_de_documento ON dbo.Serializacion.Id_tipodoc = dbo.Tipo_de_documento.Id_tipodoc
						WHERE Cast(dbo.Compra .Fecha_compra  As Date) >=@fecha_inicial AND Cast(dbo.Compra .Fecha_compra  As Date) <= @fecha_final 

GO
/****** Object:  StoredProcedure [dbo].[REPORT_COMPRAS_POR_PERIODOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[REPORT_COMPRAS_POR_PERIODOS]
@fecha_inicial as date,
@fecha_final as date
as
SELECT        dbo.Compra.Fecha_compra, dbo.Tipo_de_documento.Descripcion AS tIPO_DOC, dbo.Compra.N_Documento, (dbo.Producto1.Descripcion+ '-' 
                        + dbo.Presentaciones.Presentacion) AS pRODUCTO, dbo.Detalle_Compra.Cantidad_mostrada, dbo.Detalle_Compra.Unidad_de_medida, dbo.Detalle_Compra.Total_a_pagar
						,@fecha_final AS DESDE,@fecha_final AS HASTA
FROM            dbo.Compra INNER JOIN
                         dbo.Detalle_Compra ON dbo.Compra.Cod_compra = dbo.Detalle_Compra.idcompra INNER JOIN
                         dbo.clientes ON dbo.Compra.idproveedor = dbo.clientes.idclientev INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.Detalle_Compra.Id_presentacionfraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1 INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion INNER JOIN
                         dbo.Serializacion ON dbo.Compra.Id_series = dbo.Serializacion.Id_serializacion INNER JOIN
                         dbo.Tipo_de_documento ON dbo.Serializacion.Id_tipodoc = dbo.Tipo_de_documento.Id_tipodoc
						WHERE  dbo.Compra.Estado='PAGADO' AND Cast(dbo.Compra .Fecha_compra  As Date) >=@fecha_inicial AND Cast(dbo.Compra .Fecha_compra  As Date) <= @fecha_final 

GO
/****** Object:  StoredProcedure [dbo].[REPORT_CONTROL_DE_COBROS_A_CLIENTES]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[REPORT_CONTROL_DE_COBROS_A_CLIENTES_cobrados]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[REPORT_CUENTAS_POR_COBRAR]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[REPORT_DETALLE_DE_VENTAS_POR_PERIODOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[REPORT_DETALLE_DE_VENTAS_POR_PERIODOS]
@fecha_inicial as date,
@fecha_final as date
as
SELECT        dbo.Producto1.Descripcion, dbo.Presentaciones.Presentacion, dbo.detalle_venta.Unidad_de_medida, dbo.detalle_venta.cantidad, 
                         dbo.detalle_venta.Total_a_pagar,ventas.fecha_venta 
FROM            dbo.detalle_venta INNER JOIN
                         dbo.ventas ON dbo.detalle_venta.idventa = dbo.ventas.idventa INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.detalle_venta.Id_presentacionfraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1 INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion
						  where dbo.ventas  .Estado ='PAGADO'  and Cast(dbo.ventas  .fecha_venta   As Date) >=@fecha_inicial AND Cast(dbo.ventas  .fecha_venta   As Date) <= @fecha_final 

GO
/****** Object:  StoredProcedure [dbo].[REPORT_DETALLE_DE_VENTAS_POR_PERIODOS_A_CREDITOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[REPORT_DETALLE_DE_VENTAS_POR_PERIODOS_A_CREDITOS]
@fecha_inicial as date,
@fecha_final as date
as
SELECT        dbo.Producto1.Descripcion, dbo.Presentaciones.Presentacion, dbo.detalle_venta.Unidad_de_medida, dbo.detalle_venta.Cantidad_mostrada , 
                         dbo.detalle_venta.Total_a_pagar,ventas.fecha_venta ,DBO.ventas.Estado 
FROM            dbo.detalle_venta INNER JOIN
                         dbo.ventas ON dbo.detalle_venta.idventa = dbo.ventas.idventa INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.detalle_venta.Id_presentacionfraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1 INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion
						  where dbo.ventas  .Estado ='DEUDA'  and Cast(dbo.ventas  .fecha_venta   As Date) >=@fecha_inicial AND Cast(dbo.ventas  .fecha_venta   As Date) <= @fecha_final 

GO
/****** Object:  StoredProcedure [dbo].[REPORT_DETALLE_DE_VENTAS_POR_PERIODOS_AL_CONTADO]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[REPORT_DETALLE_DE_VENTAS_POR_PERIODOS_AL_CONTADO]
@fecha_inicial as date,
@fecha_final as date
as
SELECT        dbo.Producto1.Descripcion, dbo.Presentaciones.Presentacion, dbo.detalle_venta.Unidad_de_medida, dbo.detalle_venta.cantidad, 
                         dbo.detalle_venta.Total_a_pagar,ventas.fecha_venta ,DBO.ventas.Estado 
FROM            dbo.detalle_venta INNER JOIN
                         dbo.ventas ON dbo.detalle_venta.idventa = dbo.ventas.idventa INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.detalle_venta.Id_presentacionfraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1 INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion
						  where dbo.ventas  .Estado ='PAGADO'  and Cast(dbo.ventas  .fecha_venta   As Date) >=@fecha_inicial AND Cast(dbo.ventas  .fecha_venta   As Date) <= @fecha_final 

GO
/****** Object:  StoredProcedure [dbo].[REPORT_DETALLE_DE_VENTAS_POR_PERIODOS_EN_GENERAL]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[REPORT_GANANCIAS_DE_VENTAS_por_TURNOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[REPORT_GANANCIAS_DE_VENTAS_por_TURNOS]
@id_caja AS INT,
@fi as DATE,
@ff as DATEtime
as

select SUM(Ganancia )  from detalle_venta  INNER JOIN VENTAS ON detalle_venta.idventa =ventas.idventa 
where
(ventas.fecha_venta  >=@fi and ventas.fecha_venta<=@ff )AND VENTAS.Id_caja=@id_caja

GO
/****** Object:  StoredProcedure [dbo].[REPORT_GASTOS_VARIOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[REPORT_GASTOS_VARIOS]
@id_caja AS INT,
@fi as DATE,
@ff as DATE
as

select SUM(Importe)  from GASTOSVARIOS INNER JOIN CONCEPTOS ON CONCEPTOS.Id_concepto =GASTOSVARIOS.Id_concepto   where  
(Fecha_del_Gasto >=@fi OR Fecha_del_Gasto<=@ff )AND Id_caja=@id_caja AND TIPO='SALIDA'


GO
/****** Object:  StoredProcedure [dbo].[REPORT_GASTOS_VARIOS_POR_PERIODOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[REPORT_GASTOS_VARIOS_por_turnos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[REPORT_GASTOS_VARIOS_por_turnos]
@id_caja AS INT,
@fi as DATE,
@ff as DATEtime
as

select SUM(Importe)  from GASTOSVARIOS INNER JOIN CONCEPTOS ON CONCEPTOS.Id_concepto =GASTOSVARIOS.Id_concepto   where  
(Fecha_del_Gasto >=@fi AND Fecha_del_Gasto<=@ff )AND Id_caja=@id_caja AND TIPO='SALIDA'


GO
/****** Object:  StoredProcedure [dbo].[REPORT_INGRESOS_VARIOS_POR_PERIODOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[REPORT_INGRESOS_VARIOS_por_turnos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[REPORT_INGRESOS_VARIOS_por_turnos]
@id_caja AS INT,
@fi as DATE,
@ff as DATEtime
as

select SUM(Importe)  from GASTOSVARIOS   where  
(Fecha_del_Gasto >=@fi AND Fecha_del_Gasto<=@ff )AND Id_caja=@id_caja AND GASTOSVARIOS . TIPO='INGRESO'


GO
/****** Object:  StoredProcedure [dbo].[REPORT_PAGOS_EN_EFECTIVO_por_turnos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[REPORT_PAGOS_EN_EFECTIVO_por_turnos]
@id_caja AS INT,
@fi as DATE,
@ff as DATETIME
as
select SUM(Pago_realizado )  from DETALLE_CONTROL_DE_COBROS     where  
(Fecha_que_pago >=@fi AND Fecha_que_pago<=@ff )AND Id_caja=@id_caja AND Tipo_de_cobro ='EFECTIVO' and Detalle ='PAGO'


GO
/****** Object:  StoredProcedure [dbo].[REPORT_VENTAS_POR_PERIODOS_EN_GENERAL]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[REPORT_VENTAS_POR_PERIODOS_EN_GENERAL_DE_KARDEX]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[REPORT_VENTAS_POR_PERIODOS_EN_GENERAL_DE_KARDEX]
@fecha_inicial as date,
@fecha_final as date
as

SELECT       convert(date,KARDEX.Fecha) ,KARDEX.Total ,KARDEX.Motivo 
					,@fecha_inicial,@fecha_final
FROM            dbo.KARDEX 

						 where 
						Cast(dbo.KARDEX   .Fecha    As Date) >=@fecha_inicial 
				AND Cast(dbo.KARDEX   .Fecha   As Date) <= @fecha_final 
						 
						 AND (KARDEX.Motivo ='DESPACHO DIARIO DE VENDEDORES...'
						 or KARDEX.Motivo ='RECHAZO DIARIO')and (KARDEX.Total >0 or KARDEX.Total  <0)







GO
/****** Object:  StoredProcedure [dbo].[REPORT_VENTAS_por_TURNOS_en_EFECTIVO]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[REPORT_VENTAS_por_TURNOS_en_EFECTIVO]
@id_caja AS INT,
@fi as DATE,
@ff as DATEtime
as

select SUM(Monto_total)  from ventas 
where Tipo_de_pago ='EFECTIVO' AND 
(fecha_venta >=@fi and fecha_venta<=@ff )AND Id_caja=@id_caja
GO
/****** Object:  StoredProcedure [dbo].[REPORT_VENTAS_por_TURNOS_Por_Credito]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[REPORT_VENTAS_por_TURNOS_Por_Credito]
@id_caja AS INT,
@fi as DATE,
@ff as DATEtime
as

select SUM(Monto_total)  from ventas 
where Tipo_de_pago ='CREDITO' AND 
(fecha_venta >=@fi and fecha_venta<=@ff )AND Id_caja=@id_caja
GO
/****** Object:  StoredProcedure [dbo].[REPORT_VENTAS_por_TURNOS_Por_tarjeta]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[REPORT_VENTAS_por_TURNOS_Por_tarjeta]
@id_caja AS INT,
@fi as DATE,
@ff as DATEtime
as

select SUM(Monto_total)  from ventas 
where Tipo_de_pago ='TARJETA' AND 
(fecha_venta >=@fi and fecha_venta<=@ff )AND Id_caja=@id_caja
GO
/****** Object:  StoredProcedure [dbo].[REPORT_VENTAS_POR_VENDEDOR]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[REPORT_VENTAS_POR_VENDEDOR_EN_GENERAL]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[REPORT_VENTAS_POR_VENDEDOR_VENTAS_AL_CONTADO]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[REPORT_VENTAS_POR_VENDEDOR_VENTAS_AL_CONTADO]
@fecha_inicial as date,
@fecha_final as date,
@Id_usuario int
as
SELECT      sum(dbo.ventas.Monto_total)AS VENTAS_TOTAL_CONTADO 
                         					 
FROM            dbo.ventas INNER JOIN
                         
                         dbo.USUARIO2 ON dbo.ventas.Id_usuario = dbo.USUARIO2.idUsuario
					
						  where dbo.USUARIO2.idUsuario =@Id_usuario  and Cast(dbo.ventas .fecha_venta   As Date) >=@fecha_inicial AND Cast(dbo.ventas .fecha_venta   As Date) <= @fecha_final AND Tipo_de_pago  ='CONTADO'

						  group by dbo.ventas.Monto_total

GO
/****** Object:  StoredProcedure [dbo].[REPORT_VENTAS_POR_VENDEDOR_VENTAS_AL_CONTADO_general]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[reporte_comprasfecha]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[reporte_comprasfecha]
as
select Compra.Cod_compra, Compra.Fecha_compra ,Compra.idproveedor ,Compra.Moneda ,Compra.Proveedor, Compra.Fecha_a_Pagar,Compra.Total_a_pagar,Compra.Estado 
from Compra  INNER JOIN
                   proveedores on proveedores.Idproveedor = Compra.idproveedor 
				   where Estado='DEUDA'





GO
/****** Object:  StoredProcedure [dbo].[REPORTE_GASTOS_VARIOS_DETALLADOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[reporte_inventario]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[reporte_inventario]
as
select idproducto,Descripcion,Stock,Fecharegistro,
'ESTADO'=(CASE
WHEN Stock > 10 THEN 'EN STOCK'
WHEN Stock=10 THEN 'STOCK EN LIMITE'
WHEN Stock <10 THEN 'HAGA UNA SOLICITUD'
END) 
 from productos2 





GO
/****** Object:  StoredProcedure [dbo].[REPORTE_INVENTARIO_FISICO_VALORADO]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[REPORTE_INVENTARIO_FISICO_VALORADO]
as
SELECT        dbo.Producto1.Id_Producto1, (dbo.Producto1.Descripcion + '- ' + dbo.Presentaciones.Presentacion+' x'+ Presentaciones.Cantidad_por_presentacion  +Presentaciones .Unidad_de_medida   ) as Producto,
                       Presentaciones_fraccionadas.Stock ,convert(numeric(18,2),Presentaciones_fraccionadas.Precio_de_compra/Unidad_de_medida.Cantidad_por_unidad_de_medida ) 	as Costo_Unt,
	convert(numeric(18,2),Presentaciones_fraccionadas.Precio_de_venta_por_presentacion /Unidad_de_medida.Cantidad_por_unidad_de_medida) as P_venta_Unt,'S/.'+convert(varchar (50),Presentaciones_fraccionadas.Precio_de_venta_por_presentacion ) + ' x '+ Unidad_de_medida.Unidad_de_medida +'('+Unidad_de_medida.Cantidad_por_unidad_de_medida +'UND'+')' as P_venta ,CONVERT(NUMERIC(18,1),Presentaciones_fraccionadas.Precio_de_venta_por_presentacion/Unidad_de_medida.Cantidad_por_unidad_de_medida  *Presentaciones_fraccionadas.Stock) as TOTAL_VENTA
	,convert(numeric(18,2),Presentaciones_fraccionadas.Precio_de_compra/Unidad_de_medida.Cantidad_por_unidad_de_medida )*Presentaciones_fraccionadas.Stock AS TOTAL_COSTO
FROM            dbo.Producto1 INNER JOIN
                      
                     
					 dbo.Presentaciones_fraccionadas on Presentaciones_fraccionadas.Id_producto=dbo.Producto1.Id_Producto1 
						 inner join dbo.Presentaciones on dbo.Presentaciones.Id_Presentacion =dbo.Presentaciones_fraccionadas.Id_presentacion 
						inner join Unidad_de_medida on Unidad_de_medida.Id_unidad_de_medida=Presentaciones_fraccionadas.Id_unidad 
						
						 ORDER BY DBO.Producto1.Descripcion  asc
						 --WHERE DBO.Producto1.Produccion='SI' 

GO
/****** Object:  StoredProcedure [dbo].[REPORTE_PAGOSERVICIOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[REPORTE_PLAZA_RESUMEN_DE_DEUDAS_POR_CLIENTE]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[REPORTE_PLAZA_RESUMEN_DE_PAGOS_A_PROVEEDORES]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[REPORTE_PLAZA_RESUMEN_DE_PAGOS_A_PROVEEDORES]
AS
SELECT        dbo.clientes.Nombre, dbo.clientes.Direccion_para_factura, dbo.CONTROL_DE_PAGOS_A_PROVEEDORES.Monto
FROM            dbo.clientes INNER JOIN
                         dbo.CONTROL_DE_PAGOS_A_PROVEEDORES ON dbo.clientes.idclientev = dbo.CONTROL_DE_PAGOS_A_PROVEEDORES.Id_proveedor

						 where dbo.CONTROL_DE_PAGOS_A_PROVEEDORES .Monto > 0

GO
/****** Object:  StoredProcedure [dbo].[REPORTEcierredecajaCOMPRAS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[REPORTEcierredecajaCOMPRAS]
 @fechaini DATE,
 @fechafin DATE
 as
  select month(dbo.Compra.Fecha_compra ) as Mes, year(dbo.Compra.Fecha_compra) as año,
  sum(dbo.Compra.Total_a_pagar ) as Egresos_compras

 from dbo.Compra 
 where      Fecha_compra >= @fechaini AND    Fecha_compra <= @fechafin and Estado='PAGADO' GROUP BY MONTH(dbo.Compra.Fecha_compra ), YEAR(dbo.Compra.Fecha_compra) ORDER BY YEAR(dbo.Compra.Fecha_compra) asc




GO
/****** Object:  StoredProcedure [dbo].[REPORTEcierredecajaCUENTASBANCOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[REPORTEcierredecajaCUENTASBANCOS]
 @fechaini DATE,
 @fechafin DATE
 as
 select month(dbo.Cuentas_banco.Fecha_de_pago  ) as Mes, year(dbo.Cuentas_banco.Fecha_de_pago) as año,
  sum(dbo.Cuentas_banco.Monto  ) as Egresos_Bancos

 from dbo.Cuentas_banco 
 where      Fecha_de_pago >= @fechaini AND    Fecha_de_pago <= @fechafin and Estado ='PAGADO' GROUP BY MONTH(dbo.Cuentas_banco.Fecha_de_pago  ), YEAR(dbo.Cuentas_banco.Fecha_de_pago ) ORDER BY YEAR(dbo.Cuentas_banco.Fecha_de_pago ) asc






GO
/****** Object:  StoredProcedure [dbo].[REPORTEcierredecajaGASTOSVARIOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[REPORTEcierredecajaGASTOSVARIOS]
 @fechaini DATE,
 @fechafin DATE
 as
select month(dbo.GASTOSVARIOS.Fecha_del_Gasto ) as Mes, year(dbo.GASTOSVARIOS.Fecha_del_Gasto) as año,
  sum(dbo.GASTOSVARIOS.Importe  ) as Egresos_Gastos_varios

 from dbo.GASTOSVARIOS 
 where     Fecha_del_Gasto >= @fechaini AND   Fecha_del_Gasto <= @fechafin  GROUP BY MONTH(dbo.GASTOSVARIOS.Fecha_del_Gasto  ), YEAR(dbo.GASTOSVARIOS.Fecha_del_Gasto ) ORDER BY YEAR(dbo.GASTOSVARIOS.Fecha_del_Gasto ) asc





GO
/****** Object:  StoredProcedure [dbo].[REPORTEcierredecajaGASTOSVARIOS_diario]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[REPORTEcierredecajaGASTOSVARIOS_diario]
 @fechaini DATE
 as
select month(dbo.GASTOSVARIOS.Fecha_del_Gasto ) as Mes, year(dbo.GASTOSVARIOS.Fecha_del_Gasto) as año,
  sum(dbo.GASTOSVARIOS.Importe  ) as Egresos_Gastos_varios, day(dbo.GASTOSVARIOS.Fecha_del_Gasto) as dia

 from dbo.GASTOSVARIOS 
 where     Fecha_del_Gasto = @fechaini   GROUP BY MONTH(dbo.GASTOSVARIOS.Fecha_del_Gasto  ), day(dbo.GASTOSVARIOS.Fecha_del_Gasto),YEAR(dbo.GASTOSVARIOS.Fecha_del_Gasto ) ORDER BY YEAR(dbo.GASTOSVARIOS.Fecha_del_Gasto ) asc





GO
/****** Object:  StoredProcedure [dbo].[REPORTEcierredecajaINFRESOSVARIOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[REPORTEcierredecajaPERSONALPAGOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[REPORTEcierredecajaPERSONALPAGOS]
 @fechaini DATE,
 @fechafin DATE
 as
 select   sum(dbo.PERSONALPAGOS.Resto) as Egresos_Pago_Personal
		 
 from dbo.PERSONALPAGOS 
 --, dbo.GASTOSVARIOS, dbo.INGRESOSVARIOS,dbo.Cuentas_banco,dbo.PAGOPORSERVICIOS 
  --    ,dbo.PERSONALPAGOS  

 where    
          
		 
		   (Fecha_de_Pago_Personal  >= @fechaini and Fecha_de_Pago_Personal  <= @fechafin)
		 
		 


		 AND Estado_del_Personal='PAGADO'






GO
/****** Object:  StoredProcedure [dbo].[REPORTEcierredecajaVENTAS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[REPORTEcierredecajaVENTAS]
 @fechaini DATE,
 @fechafin DATE
 as
 --LEFT( CONVERT( VARCHAR, d.fecha, 112 ),6)+'01' as fechaVenta
 select month(dbo.ventas.fecha_venta) as Mes, year(dbo.ventas.fecha_venta) as año,
  sum(dbo.ventas.Monto_total) as Ingreso_de_Ventas

 from dbo.ventas
 where      fecha_venta >= @fechaini AND    fecha_venta <= @fechafin and Estado='PAGADO' GROUP BY MONTH(dbo.ventas.fecha_venta ), YEAR(dbo.ventas.fecha_venta ) ORDER BY YEAR(dbo.ventas.fecha_venta ) asc




GO
/****** Object:  StoredProcedure [dbo].[REPORTEcierredecajaxfecha]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[REPORTEcierredecajaxfecha]
 @fechaini DATETIME,
 @fechafin DATETIME
 as
 select sum(dbo.Compra.Total_a_pagar) as Egresos_de_Compra,sum(dbo.ventas.Monto_total) as Ingreso_de_Ventas,sum(dbo.GASTOSVARIOS.Importe  ) as Egreso_GastosVarios
         ,sum(dbo.INGRESOSVARIOS.Importe ) as Ingreso_IngresosVarios,sum(dbo.Cuentas_banco.Monto  ) as Egresos_Bancos
		 ,sum(dbo.PAGOPORSERVICIOS.Total_a_Pagar )as Egreso_ServiciosM,sum(dbo.PERSONALPAGOS.Resto) as Egresos_Pago_Personal
		 
 from dbo.Compra, dbo.ventas, dbo.GASTOSVARIOS, dbo.INGRESOSVARIOS,dbo.Cuentas_banco,dbo.PAGOPORSERVICIOS 
      ,dbo.PERSONALPAGOS  

 where  (fecha_venta   >= @fechaini and fecha_venta  <= @fechafin) OR (Fecha_compra >= @fechaini and Fecha_compra   <= @fechafin)
         OR (Fecha_del_Gasto   >= @fechaini and Fecha_del_Gasto   <= @fechafin) OR (Fecha_de_Ingreso >= @fechaini and Fecha_de_Ingreso  <= @fechafin)
		  OR (Fecha_de_Pago_Personal  >= @fechaini and Fecha_de_Pago_Personal  <= @fechafin) OR (Fecha_de_Pago_Servicios >= @fechaini and Fecha_de_Pago_Servicios  <= @fechafin)
		  OR (Fecha_de_Pago  >= @fechaini and Fecha_de_Pago  <= @fechafin)
		  and (Estado_de_Compra='PAGADO' or Estado_de_Venta='PAGADO'  or Condición='PAGADO'  or Estado_del_Servicio='PAGADO'
		   or Estado_del_Personal='PAGADO'or Estado_de_Compra='DEUDA' or Estado_de_Venta='DEUDA'  or Condición='DEUDA'  or Estado_del_Servicio='DEUDA'
		   or Estado_del_Personal='DEUDA')






GO
/****** Object:  StoredProcedure [dbo].[REPROGRAMAR_Programacion_de_fraccionamiento_de_productos]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[REPROGRAMAR_Programacion_de_fraccionamiento_de_productos]
                      @Actividad varchar(50),
           @Fecha_programada date,
		   @Id_turno_programado as int,
		   @Id_detalle_venta as int

AS

	update PROGRAMACION_DE_ACTIVIDADES_BASICA_GENERALES
  SET
		      Actividad  =@Actividad ,
         Fecha_programada =  @Fecha_programada ,
		   Id_turno_programado =@Id_turno_programado 
		
		 WHERE Id_detalle_venta=@Id_detalle_venta 


GO
/****** Object:  StoredProcedure [dbo].[restar_saldo_a_cliente_por_eliminacion]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[restar_saldo_a_cliente_por_eliminacion]
@idventa int,
@montototal as numeric(18,1)


as

update CONTROL_DE_COBROS set Monto  =Monto - @montototal
where Id_venta =@idventa 


GO
/****** Object:  StoredProcedure [dbo].[restar_saldo_a_PROVEEDOR_por_eliminacion]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[restar_saldo_a_PROVEEDOR_por_eliminacion]
@idCOMPRA int,
@montototal as numeric(18,1)


as

update CONTROL_DE_PAGOS_A_PROVEEDORES  set Monto  =Monto - @montototal
where Id_compra  =@idCOMPRA 

GO
/****** Object:  StoredProcedure [dbo].[restar_total_COMPRA_por_eliminacion]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[restar_total_COMPRA_por_eliminacion]
@idcompra int,
@montototal as numeric(18,2)


as

update Compra  set Total_a_pagar   =Total_a_pagar  - @montototal
where Cod_compra  =@idcompra  


GO
/****** Object:  StoredProcedure [dbo].[restar_total_venta_por_eliminacion]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[restar_total_venta_por_eliminacion]
@idventa int,
@montototal as numeric(18,2)


as

update ventas set Monto_total  =Monto_total - @montototal
where idventa =@idventa 


GO
/****** Object:  StoredProcedure [dbo].[saldar_a_proveedor]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[saldar_a_proveedor]
@idproveedor as integer

as
update Compra  set Estado = 'PAGADO'  
where idproveedor =@idproveedor  




GO
/****** Object:  StoredProcedure [dbo].[SERVICIOSMULTIPLES]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SERVICIOSMULTIPLES]

 as
 SELECT        Nombre_de_Servicio, Fecha_de_Registro, Fecha_de_Pago_Servicios
FROM            dbo.PAGOPORSERVICIOS


 where   Estado_del_Servicio='DEUDA'  





GO
/****** Object:  StoredProcedure [dbo].[sumar_COBROS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sumar_COBROS]
@FI as date,
@FF as date
as
select sum(dbo.DETALLE_CONTROL_DE_COBROS  .Pago_realizado   )
from dbo.DETALLE_CONTROL_DE_COBROS 
 where DETALLE_CONTROL_DE_COBROS.Detalle='COBRO'  AND CONVERT(DATE,Fecha_que_pago)  >= @FI and CONVERT(DATE,Fecha_que_pago)  <= @FF


GO
/****** Object:  StoredProcedure [dbo].[sumar_cobros_POR_TURNO]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sumar_cobros_POR_TURNO]
@fechainicio as datetime,
@fechafin as datetime
as
select sum(dbo.DETALLE_CONTROL_DE_COBROS.Pago_realizado)
from dbo.DETALLE_CONTROL_DE_COBROS  
 where  Fecha_que_pago  >= @fechainicio and Fecha_que_pago  <=@fechafin

GO
/****** Object:  StoredProcedure [dbo].[sumar_compras_POR_TURNO]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sumar_compras_POR_TURNO]
@FI as date,
@FF as date
as
select sum(dbo.ventas  .Monto_total  )
from dbo.ventas 
 where (ventas.ACCION='COMPRA' OR ventas.ACCION='PEDIDO DE COMPRA' ) AND ventas.Tipo_de_pago  ='CONTADO' AND CONVERT(DATE,fecha_venta)  >= @FI and CONVERT(DATE,fecha_venta)  <= @FF


GO
/****** Object:  StoredProcedure [dbo].[sumar_gastos_POR_TURNO]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sumar_gastos_POR_TURNO]
@FI as date,
@FF as date
as
select sum(dbo.GASTOSVARIOS    .Importe    )
from dbo.GASTOSVARIOS   
 where GASTOSVARIOS .TIPO    ='SALIDA'  AND CONVERT(DATE,Fecha_del_Gasto )  >= @FI and CONVERT(DATE,Fecha_del_Gasto)  <= @FF


GO
/****** Object:  StoredProcedure [dbo].[sumar_INGRESOS_gastos_POR_TURNO]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[sumar_INGRESOS_VARIOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sumar_INGRESOS_VARIOS]
@FI as date,
@FF as date
as
select sum(dbo.GASTOSVARIOS    .Importe    )
from dbo.GASTOSVARIOS   
 where GASTOSVARIOS .TIPO    ='INGRESO'  AND CONVERT(DATE,Fecha_del_Gasto )  >= @FI and CONVERT(DATE,Fecha_del_Gasto)  <= @FF


GO
/****** Object:  StoredProcedure [dbo].[sumar_INGRESOS_VARIOS_POR_TURNO]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sumar_INGRESOS_VARIOS_POR_TURNO]
@fechainicio as datetime,
@fechafin as datetime
as
select sum(dbo.INGRESOSVARIOS .Importe )
from dbo.INGRESOSVARIOS
 where Estado='PAGADO' AND Fecha_del_Gasto >= @fechainicio and Fecha_del_Gasto <=@fechafin 

GO
/****** Object:  StoredProcedure [dbo].[sumar_INGRESOS-VARIOS_POR_TURNO]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sumar_INGRESOS-VARIOS_POR_TURNO]
@fechainicio as datetime,
@fechafin as datetime
as
select sum(dbo.INGRESOSVARIOS .Importe + 0) 
from dbo.INGRESOSVARIOS
 where Estado='PAGADO' AND Fecha_del_Gasto >= @fechainicio and Fecha_del_Gasto <=@fechafin 

GO
/****** Object:  StoredProcedure [dbo].[sumar_KARDEX_RECHASOS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sumar_KARDEX_RECHASOS]
@FI as date,
@FF as date
as
select sum(dbo.KARDEX   .Total   )
from dbo.KARDEX  
 where KARDEX .Motivo   ='RECHAZO DIARIO' AND CONVERT(DATE,Fecha)  >= @FI and CONVERT(DATE,Fecha)  <= @FF


GO
/****** Object:  StoredProcedure [dbo].[SUMAR_KARDEX_SALIDA]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SUMAR_KARDEX_SALIDA]
@FI as date,
@FF as date
AS
SELECT         (dbo.Producto1.Descripcion+' '+dbo.Presentaciones.Presentacion+
                        ' x'+ dbo.Presentaciones.Cantidad_por_presentacion+dbo.Presentaciones.Unidad_de_medida) as Producto 
						,SUM(KARDEX.Total ) TOTALOK
FROM            dbo.KARDEX INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.KARDEX.Id_presentacion_fraccionada = dbo.Presentaciones_fraccionadas.Id_presentacionfraccionada INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion INNER JOIN
                         dbo.Producto1 ON dbo.Presentaciones_fraccionadas.Id_producto = dbo.Producto1.Id_Producto1
					inner join Unidad_de_medida on Unidad_de_medida.Id_unidad_de_medida=Presentaciones_fraccionadas.Id_unidad 
						INNER JOIN USUARIO2 ON USUARIO2.idUsuario=KARDEX.Id_usuario 					
					
						WHERE KARDEX.Tipo='SALIDA' AND  CONVERT(DATE,KARDEX .Fecha )  >= @FI and CONVERT(DATE,KARDEX.Fecha)  <= @FF
						  group by  dbo.Producto1.Descripcion,dbo.Presentaciones.Presentacion,
                         dbo.Presentaciones.Cantidad_por_presentacion,dbo.Presentaciones.Unidad_de_medida
 order by SUM(KARDEX .Total  )   desc
GO
/****** Object:  StoredProcedure [dbo].[SUMAR_KARDEX_SALIDA_CON_PRESENTACION_IGUAL]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[sumar_KARDEX_VENTAS]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sumar_KARDEX_VENTAS]
@FI as date,
@FF as date
as
select sum(dbo.KARDEX   .Total   )
from dbo.KARDEX  
 where (KARDEX .Motivo   ='DESPACHO DIARIO DE VENDEDORES...'  OR   KARDEX .Motivo   ='DESPACHO DE PEDIDOS...' )AND CONVERT(DATE,Fecha)  >= @FI and CONVERT(DATE,Fecha)  <= @FF


GO
/****** Object:  StoredProcedure [dbo].[sumar_pagos_POR_TURNO]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sumar_pagos_POR_TURNO]
@FI as date,
@FF as date
as
select sum(dbo.DETALLE_CONTROL_DE_COBROS  .Pago_realizado   )
from dbo.DETALLE_CONTROL_DE_COBROS 
 where DETALLE_CONTROL_DE_COBROS.Detalle='PAGO'  AND CONVERT(DATE,Fecha_que_pago)  >= @FI and CONVERT(DATE,Fecha_que_pago)  <= @FF


GO
/****** Object:  StoredProcedure [dbo].[SUMAR_POR_COBRAR]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SUMAR_POR_COBRAR]
@FI as date,
@FF as date
as
SELECT    SUM(   clientes.Saldo )

FROM           clientes  
						
 where clientes .Cliente='SI' 
GO
/****** Object:  StoredProcedure [dbo].[SUMAR_POR_COBRAR_OK]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SUMAR_POR_COBRAR_OK]
@FI as date,
@FF as date
as
SELECT    SUM(   clientes.Saldo )

FROM           clientes  
						
 where clientes .Cliente='SI' 
GO
/****** Object:  StoredProcedure [dbo].[SUMAR_POR_PAGAR_OK]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SUMAR_POR_PAGAR_OK]
@FI as date,
@FF as date
as
SELECT    SUM(   clientes.Saldo )

FROM           clientes  
						
 where clientes .Proveedor ='SI' 
GO
/****** Object:  StoredProcedure [dbo].[sumar_ventas_POR_TURNO]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sumar_ventas_POR_TURNO]
@FI as date,
@FF as date
as
select sum(dbo.ventas  .Monto_total  )
from dbo.ventas 
 where (ventas.ACCION='VENTA' OR ventas.ACCION='PEDIDO DE VENTA' )AND ventas.Tipo_de_pago  ='CONTADO' AND CONVERT(DATE,fecha_venta)  >= @FI and CONVERT(DATE,fecha_venta)  <= @FF


GO
/****** Object:  StoredProcedure [dbo].[transferencia_de_caja_chica_a_cuentabacaria]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[transferencia_de_caja_chica_a_cuentabacaria]
@Id_cuenta_bancaria int,

@Saldo as varchar(50)

as

update Cuentas_corrientes_bancos_datos_generales set Saldo  =Saldo + @Saldo




where Id_cuenta_bancaria=@Id_cuenta_bancaria


GO
/****** Object:  StoredProcedure [dbo].[Validar_caja]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

GO
/****** Object:  StoredProcedure [dbo].[validar_usuario]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[validar_usuario]
@login varchar(50),
@password varchar(50)
as
select * from USUARIO2
where Login=@login and Password   = @password 





GO
/****** Object:  StoredProcedure [dbo].[VerificarUsuario]    Script Date: 05/01/2019 17:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[VerificarUsuario]
	@Usuario varchar(20), @Password varchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM Usuario
	WHERE Usuario=@Usuario AND Password=@Password
END



GO

GO

GO

