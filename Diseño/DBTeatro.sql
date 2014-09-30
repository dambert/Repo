CREATE DATABASE DBTeatro
go
use DBTeatro
go
CREATE TABLE [ASIENTO]
( 
	[CASiento]           integer  NOT NULL IDENTITY(1,1),
	[Letra]              char  NOT NULL ,
	[Numero]             integer  NOT NULL ,
	[CTipoAsiento]       integer  NULL 
)
go

ALTER TABLE [ASIENTO]
	ADD CONSTRAINT [XPKASIENTO] PRIMARY KEY  CLUSTERED ([CASiento] ASC)
go

CREATE TABLE [ESTADOASIENTO]
( 
	[CEstadoAsiento]     integer  NOT NULL IDENTITY(1,1),
	[NEstadoAsiento]     varchar(100)  NOT NULL 
)
go

ALTER TABLE [ESTADOASIENTO]
	ADD CONSTRAINT [XPKESTADOASIENTO] PRIMARY KEY  CLUSTERED ([CEstadoAsiento] ASC)
go

CREATE TABLE [USUARIO]
( 
	[CUsuario]           integer  NOT NULL IDENTITY(1,1),
	[NNombres]           varchar(100)  NOT NULL ,
	[NAPellidos]         varchar(100)  NULL ,
	[DNI]                varchar(8)  NOT NULL ,
	[Telefono]           integer  NULL ,
	[TDireccion]         varchar(255)  NULL 
)
go

ALTER TABLE [USUARIO]
	ADD CONSTRAINT [XPKUSUARIO] PRIMARY KEY  CLUSTERED ([CUsuario] ASC)
go

CREATE TABLE [CLIENTE]
( 
	[CCliente]           integer  NOT NULL ,
	[RUC]                char(18)  NULL 
)
go

ALTER TABLE [CLIENTE]
	ADD CONSTRAINT [XPKCLIENTE] PRIMARY KEY  CLUSTERED ([CCliente] ASC)
go

CREATE TABLE [EMPLEADO]
( 
	[NUsername]          varchar(100)  NOT NULL,
	[NPassword]          varchar(100)  NOT NULL ,
	[CEmpleado]          integer  NOT NULL ,
	[CTipoEmpleado]      integer  NULL 
)
go

ALTER TABLE [EMPLEADO]
	ADD CONSTRAINT [XPKEMPLEADO] PRIMARY KEY  CLUSTERED ([CEmpleado] ASC)
go

CREATE TABLE [EVENTO]
( 
	[NEvento]            varchar(100)  NOT NULL,
	[CEvento]            integer  NOT NULL ,
	[DFechaEvento]       datetime  NOT NULL ,
	[TDescripcion]       varchar(255)  NULL 
)
go

ALTER TABLE [EVENTO]
	ADD CONSTRAINT [XPKEVENTO] PRIMARY KEY  CLUSTERED ([CEvento] ASC)
go

CREATE TABLE [ASIENTO_EVENTO]
( 
	[CASiento]           integer  NOT NULL IDENTITY(1,1),
	[CEvento]            integer  NOT NULL ,
	[CEstadoAsiento]     integer  NULL 
)
go

ALTER TABLE [ASIENTO_EVENTO]
	ADD CONSTRAINT [XPKASIENTO_EVENTO] PRIMARY KEY  CLUSTERED ([CASiento] ASC,[CEvento] ASC)
go

CREATE TABLE [TIPO_ASIENTO]
( 
	[CTipoAsiento]       integer  NOT NULL IDENTITY(1,1),
	[NTipoAsiento]       varchar(100)  NOT NULL ,
	[Precio]             float  NOT NULL ,
	[NColor]             varchar(100)  NOT NULL ,
	[TDescripcion]       varchar(255)  NULL 
)
go

ALTER TABLE [TIPO_ASIENTO]
	ADD CONSTRAINT [XPKTIPO_ASIENTO] PRIMARY KEY  CLUSTERED ([CTipoAsiento] ASC)
go

CREATE TABLE [TIPOEMPLEADO]
( 
	[CTipoEmpleado]      integer  NOT NULL IDENTITY(1,1),
	[NTipoEmpleado]      varchar(100)  NOT NULL 
)
go

ALTER TABLE [TIPOEMPLEADO]
	ADD CONSTRAINT [XPKTIPOEMPLEADO] PRIMARY KEY  CLUSTERED ([CTipoEmpleado] ASC)
go

CREATE TABLE [VENTA]
( 
	[CVenta]             integer  NOT NULL IDENTITY(1,1),
	[MontoTotal]         float  NOT NULL ,
	[DFechaVenta]        datetime  NOT NULL ,
	[CUsuario]           integer  NULL ,
	[CEmpleado]          integer  NOT NULL ,
	[CCliente]           integer  NULL ,
	[CEvento]            integer  NOT NULL ,
	[FBoleta]            char  NULL ,
	[FFactura]           char  NULL ,
	[RUC]                char(18)  NULL 
)
go

ALTER TABLE [VENTA]
	ADD CONSTRAINT [XPKVENTA] PRIMARY KEY  CLUSTERED ([CVenta] ASC)
go

CREATE TABLE [DETALLE_VENTA]
( 
	[CVenta]             integer  NOT NULL ,
	[CASiento]           integer  NOT NULL ,
	[TDescripcion]		 varchar(255)
)
go

ALTER TABLE [DETALLE_VENTA]
	ADD CONSTRAINT [XPKDETALLE_VENTA] PRIMARY KEY  CLUSTERED ([CVenta] ASC,[CASiento] ASC)
go


ALTER TABLE [ASIENTO]
	ADD CONSTRAINT [R_24] FOREIGN KEY ([CTipoAsiento]) REFERENCES [TIPO_ASIENTO]([CTipoAsiento])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [CLIENTE]
	ADD CONSTRAINT [R_9] FOREIGN KEY ([CCliente]) REFERENCES [USUARIO]([CUsuario])
		ON DELETE CASCADE
		ON UPDATE CASCADE
go


ALTER TABLE [EMPLEADO]
	ADD CONSTRAINT [R_8] FOREIGN KEY ([CEmpleado]) REFERENCES [USUARIO]([CUsuario])
		ON DELETE CASCADE
		ON UPDATE CASCADE
go

ALTER TABLE [EMPLEADO]
	ADD CONSTRAINT [R_27] FOREIGN KEY ([CTipoEmpleado]) REFERENCES [TIPOEMPLEADO]([CTipoEmpleado])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [ASIENTO_EVENTO]
	ADD CONSTRAINT [R_29] FOREIGN KEY ([CASiento]) REFERENCES [ASIENTO]([CASiento])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [ASIENTO_EVENTO]
	ADD CONSTRAINT [R_30] FOREIGN KEY ([CEvento]) REFERENCES [EVENTO]([CEvento])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [ASIENTO_EVENTO]
	ADD CONSTRAINT [R_31] FOREIGN KEY ([CEstadoAsiento]) REFERENCES [ESTADOASIENTO]([CEstadoAsiento])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [VENTA]
	ADD CONSTRAINT [R_20] FOREIGN KEY ([CEvento]) REFERENCES [EVENTO]([CEvento])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [VENTA]
	ADD CONSTRAINT [R_25] FOREIGN KEY ([CCliente]) REFERENCES [CLIENTE]([CCliente])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [VENTA]
	ADD CONSTRAINT [R_26] FOREIGN KEY ([CEmpleado]) REFERENCES [EMPLEADO]([CEmpleado])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [DETALLE_VENTA]
	ADD CONSTRAINT [R_15] FOREIGN KEY ([CVenta]) REFERENCES [VENTA]([CVenta])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [DETALLE_VENTA]
	ADD CONSTRAINT [R_23] FOREIGN KEY ([CASiento]) REFERENCES [ASIENTO]([CASiento])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

