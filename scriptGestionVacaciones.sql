USE [DB_VACACIONES]
GO
/****** Object:  Table [dbo].[tb_empleado]    Script Date: 9/22/2022 1:25:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_empleado](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombres] [varchar](50) NOT NULL,
	[apellidos] [varchar](50) NOT NULL,
	[id_tipo_identificacion] [int] NOT NULL,
	[numero_identificacion] [nvarchar](50) NOT NULL,
	[fecha_ingreso] [date] NOT NULL,
	[salario_base_mensual] [decimal](18, 2) NOT NULL,
	[direccion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__tb_emple__3213E83FD06C8F21] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_tipo_identificacion]    Script Date: 9/22/2022 1:25:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_tipo_identificacion](
	[id_identificacion] [int] NOT NULL,
	[tipo_identificacion] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_identificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tb_empleado] ON 

INSERT [dbo].[tb_empleado] ([id], [nombres], [apellidos], [id_tipo_identificacion], [numero_identificacion], [fecha_ingreso], [salario_base_mensual], [direccion]) VALUES (1, N'jose martin alvarez', N'cruz roman', 1, N'042-141296-1007M', CAST(N'2022-09-22' AS Date), CAST(15000.00 AS Decimal(18, 2)), N'Jinotepe')
INSERT [dbo].[tb_empleado] ([id], [nombres], [apellidos], [id_tipo_identificacion], [numero_identificacion], [fecha_ingreso], [salario_base_mensual], [direccion]) VALUES (2, N'carlos mauricio', N'hernandez vindel', 1, N'041-01011995-1520M', CAST(N'2021-01-01' AS Date), CAST(10000.00 AS Decimal(18, 2)), N'jinotepe')
SET IDENTITY_INSERT [dbo].[tb_empleado] OFF
INSERT [dbo].[tb_tipo_identificacion] ([id_identificacion], [tipo_identificacion]) VALUES (1, N'cedula')
INSERT [dbo].[tb_tipo_identificacion] ([id_identificacion], [tipo_identificacion]) VALUES (2, N'pasaporte')
/****** Object:  StoredProcedure [dbo].[buscar_empleado]    Script Date: 9/22/2022 1:25:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscar_empleado]
@nombre_empleado nvarchar(50)
as 
select emp.id, emp.nombres, emp.apellidos,emp.fecha_ingreso,tipoI.tipo_identificacion,emp.numero_identificacion,emp.salario_base_mensual,emp.direccion,tipoI.id_identificacion from tb_empleado as emp 
inner join tb_tipo_identificacion as tipoI on tipoI.id_identificacion = emp.id_tipo_identificacion
where nombres like '%' + @nombre_empleado + '%' or apellidos like '%' + @nombre_empleado + '%'
order by nombres asc
GO
/****** Object:  StoredProcedure [dbo].[crear_empleado]    Script Date: 9/22/2022 1:25:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[crear_empleado]
@nombres nvarchar(50),
@apellidos nvarchar(50),
@id_tipo_identificacion int,
@numero_identificiacion nvarchar(50),
@fecha_ingreso date,
@salario_base decimal(18,2),
@direccion nvarchar(50)
as
insert into tb_empleado (nombres, apellidos, id_tipo_identificacion, numero_identificacion, fecha_ingreso, salario_base_mensual, direccion)
values (@nombres,@apellidos,@id_tipo_identificacion,@numero_identificiacion,@fecha_ingreso,@salario_base,@direccion)
GO
/****** Object:  StoredProcedure [dbo].[edit_empleado]    Script Date: 9/22/2022 1:25:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[edit_empleado]
@id int
as 
select emp.id, emp.nombres, emp.apellidos,emp.fecha_ingreso,tipoI.tipo_identificacion,emp.numero_identificacion,emp.salario_base_mensual,emp.direccion,tipoI.id_identificacion from tb_empleado as emp 
inner join tb_tipo_identificacion as tipoI on tipoI.id_identificacion = emp.id_tipo_identificacion
where id = @id
GO
/****** Object:  StoredProcedure [dbo].[editar_empleado]    Script Date: 9/22/2022 1:25:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[editar_empleado]
@id_empleado int,
@nombres nvarchar(50),
@apellidos nvarchar(50),
@id_tipo_identificacion int,
@numero_identificiacion nvarchar(50),
@fecha_ingreso date,
@salario_base decimal(18,2),
@direccion nvarchar(50)
as
UPDATE [dbo].[tb_empleado]
   SET [nombres] = @nombres
      ,[apellidos] = @apellidos
      ,[id_tipo_identificacion] = @id_tipo_identificacion
      ,[numero_identificacion] = @numero_identificiacion
      ,[fecha_ingreso] = @fecha_ingreso
      ,[salario_base_mensual] = @salario_base
      ,[direccion] = @direccion
 WHERE tb_empleado.id = @id_empleado
GO
/****** Object:  StoredProcedure [dbo].[eliminar_empleado]    Script Date: 9/22/2022 1:25:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[eliminar_empleado]
@id_empleado int
as
DELETE FROM [dbo].[tb_empleado]
      WHERE id = @id_empleado
GO
/****** Object:  StoredProcedure [dbo].[lista_empleado]    Script Date: 9/22/2022 1:25:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[lista_empleado] as select emp.id, emp.nombres, emp.apellidos,emp.fecha_ingreso,tipoI.tipo_identificacion,emp.direccion,emp.salario_base_mensual,emp.numero_identificacion,tipoI.id_identificacion from tb_empleado as emp 
inner join tb_tipo_identificacion as tipoI on tipoI.id_identificacion = emp.id_tipo_identificacion
GO
/****** Object:  StoredProcedure [dbo].[visualizar_vacaciones]    Script Date: 9/22/2022 1:25:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[visualizar_vacaciones]
@fechainicio date,
@fechafin date,
@id int,
@diastomados int
as
declare @vacaciones as int
set @vacaciones = (SELECT CAST((DATEDIFF(DAY,@fechainicio,@fechafin)+1)/30.00 AS decimal(18,2)) *2.50)
select nombres AS NOMBRES,apellidos AS APELLIDOS,@vacaciones as DIAS_ACUMULADOS,@diastomados as DIAS_TOMADOS, (@vacaciones - @diastomados) as SALDO from tb_empleado
where id = @id 
GO
