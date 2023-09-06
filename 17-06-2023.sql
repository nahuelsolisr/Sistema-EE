drop database EconomiaEmpresarial
create database EconomiaEmpresarial
use EconomiaEmpresarial

create table usuarios(
Id_usuario int not null primary key identity(1,1),
Usuario varchar(20),
Contra varchar(20),
Tipo_usuario varchar(20)
)

insert into usuarios values('Admin','123','Administrador')

create table productos(
id_producto INT IDENTITY(1,1) PRIMARY KEY,
cuit_prov float,
nombre varchar(20),
categoria varchar(20),
marca varchar(20),
cantidad varchar(20) NULL,
precio varchar(20) NULL,
porcentajeg varchar (20) NULL,
stock_min varchar (20) NULL
FOREIGN KEY (cuit_prov) REFERENCES proveedor(cuit_prov),
)


select * from productos
drop table productos

create table proveedor(
cuit_prov float primary key,
nombre_prov varchar (40),
domicilio_prov varchar (60),
mail_prov varchar (40),
condicion varchar(30)
)


create table clientes(
cuit_cliente float primary key,
cliente_nombre varchar (40),
direccion varchar (60),
mail_cliente varchar (40),
condicion_cliente varchar(30)
)

INSERT INTO clientes (cuit_cliente, cliente_nombre, direccion, mail_cliente, condicion_cliente)
VALUES 
  (20111111112, 'Juan Pérez', 'Calle Falsa 123', 'juanperez@gmail.com', 'Responsable Inscripto'),
  (20333333334, 'María Rodríguez', 'Avenida Siempre Viva 742', 'mariarodriguez@gmail.com', 'Monotributista')


CREATE TABLE fichastock(
    fecha varchar(20)null,
	nombreProducto varchar(20)null,
    IdProducto varchar(20),
    Concepto varchar(10) NULL,
    UnidadesE varchar(20) NULL,
    PrecioUE varchar(20) NULL,
    TotalE varchar(20) NULL,
    UnidadesS varchar(20) NULL,
    PrecioUS varchar(20) NULL,
    TotalS varchar(20) NULL,
    UnidadesEx varchar(20),
    PrecioUEx varchar(20),
    TotalEx varchar(20),  
)


CREATE TABLE datosEmpresa (
    cuitEmpresa float PRIMARY KEY,
    nombreEmpresa VARCHAR(100),
    direccionEmpresa VARCHAR(100)
);

INSERT INTO datosEmpresa (cuitEmpresa, nombreEmpresa, direccionEmpresa)
VALUES (123456789, 'Pantera Shop', 'Laprida 567');

select * from datosEmpresa
drop table datosEmpresa

CREATE TABLE factura (
  numeroFactura INT
);

select * From factura
insert into factura (numeroFactura) values (0000);