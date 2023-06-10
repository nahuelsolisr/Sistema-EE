create database EconomiaEmpresarial
use EconomiaEmpresarial

create table usuarios(
Id_usuario int not null primary key identity(1,1),
Usuario varchar(20),
Contra varchar(20),
Tipo_usuario varchar(20)
)

insert into usuarios values('Admin','123','Administrador')
insert into usuarios values('Usuario','123','Cliente')

select * from usuarios

drop table productos

create table productos(
id_producto INT IDENTITY(1,1) PRIMARY KEY,
cuit_prov float,
nombre varchar(20),
categoria varchar(20),
marca varchar(20),
cantidad decimal NULL,
precio float NULL,
porcentajeg float NULL
FOREIGN KEY (cuit_prov) REFERENCES proveedor(cuit_prov),
)

TRUNCATE TABLE productos;
select * from productos
INSERT INTO productos (cuit_prov, nombre, categoria, marca) VALUES (20111111112, 'Laptop Acer', 'Electrónica', 'Acer');



drop table productos

create table proveedor(
cuit_prov float primary key,
nombre_prov varchar (40),
domicilio_prov varchar (60),
mail_prov varchar (40),
condicion varchar(30)
)

ALTER TABLE productos
DROP CONSTRAINT cuit_prov;

INSERT INTO proveedor (cuit_prov, nombre_prov, domicilio_prov, mail_prov, condicion)
VALUES 

select * from proveedor;


create table clientes(
cuit_cliente float primary key,
cliente_nombre varchar (40),
direccion varchar (60),
mail_cliente varchar (40),
condicion_cliente varchar(30)
)
select * from clientes;
truncate table clientes;

INSERT INTO clientes (cuit_cliente, cliente_nombre, direccion, mail_cliente, condicion_cliente)
VALUES 
  (20111111112, 'Juan Pérez', 'Calle Falsa 123', 'juanperez@gmail.com', 'Responsable Inscripto'),
  (20333333334, 'María Rodríguez', 'Avenida Siempre Viva 742', 'mariarodriguez@gmail.com', 'Monotributista'),
  (20444444445, 'Ana Gómez', 'Calle Corrientes 789', 'anagomez@yahoo.com', 'Consumidor Final'),
  (20666666667, 'Luis García', 'Avenida Libertador 456', 'luisgarcia@gmail.com', 'Responsable Inscripto'),
  (20999999990, 'Laura Fernández', 'Calle San Martín 101', 'laurafernandez@gmail.com', 'Monotributista'),
  (21111111113, 'Carlos López', 'Calle Principal 987', 'carloslopez@yahoo.com', 'Consumidor Final'),
  (21333333335, 'Mariana Torres', 'Avenida Central 654', 'marianatorres@gmail.com', 'Responsable Inscripto'),
  (21444444446, 'Pedro Sánchez', 'Calle Mayor 321', 'pedrosanchez@yahoo.com', 'Monotributista'),
  (21666666668, 'Silvia Martínez', 'Avenida Norte 852', 'silviamartinez@gmail.com', 'Consumidor Final'),
  (21999999991, 'Gabriel Herrera', 'Calle Sur 753', 'gabrielherrera@yahoo.com', 'Responsable Inscripto'),



drop table fichastock
truncate table fichastock
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
select * from fichastock

SELECT id_producto,nombre,categoria, marca, precio, cantidad, porcentajeg FROM productos WHERE cantidad >= 1;

DELETE FROM productos
WHERE cantidad > 1;

