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




select * from productos
INSERT INTO productos (cuit_prov, nombre, categoria, marca)VALUES
(20111111112, 'Producto 1', 'Categoria 1', 'Marca 1'),
(20333333334, 'Producto 2', 'Categoria 2', 'Marca 2'),
(20333333334, 'Producto 3', 'Categoria 3', 'Marca 3'),
(20333333334, 'Producto 4', 'Categoria 4', 'Marca 4'),
(20666666667, 'Producto 5', 'Categoria 5', 'Marca 5'),
(20999999990, 'Producto 6', 'Categoria 6', 'Marca 6')


drop table productos

create table proveedor(
cuit_prov float primary key,
nombre_prov varchar (40),
domicilio_prov varchar (60),
mail_prov varchar (40),
condicion varchar(30)
)

INSERT INTO proveedor (cuit_prov, nombre_prov, domicilio_prov, mail_prov, condicion)
VALUES 

(20111111112, 'Proveedor A', 'Calle Falsa 123', 'proveedora@gmail.com', 'Responsable Inscripto'),
(20333333334, 'Proveedor B', 'Avenida Siempre Viva 742', 'proveedora2@hotmail.com', 'Monotributista'),
(20444444445, 'Proveedor C', 'Calle Corrientes 789', 'proveedorc@gmail.com', 'Consumidor Final'),
(20666666667, 'Proveedor D', 'Avenida Libertador 456', 'proveedord@gmail.com', 'Responsable Inscripto'),
(20999999990, 'Proveedor E', 'Calle San Martín 101', 'proveedore@hotmail.com', 'Monotributista');

select * from proveedor

drop table proveedor

create table clientes(
cuit_cliente float primary key,
cliente_nombre varchar (40),
direccion varchar (60),
mail_cliente varchar (40),
condicion_cliente varchar(30)
)

INSERT INTO clientes VALUES (30589473922, 'Juan Perez', 'Calle Falsa 123', 'jperez@mail.com', 'Regular');
INSERT INTO clientes VALUES (27684930586, 'Maria Rodriguez', 'Avenida Siempreviva 456', 'amartinez@gmail.com', 'VIP');
INSERT INTO clientes VALUES (30875200143, 'Pedro Sanchez', 'Calle Imaginaria 789', 'psanchez@mail.com', 'Regular');
INSERT INTO clientes VALUES (30194750869, 'Ana Martinez', 'Avenida Principal 789', 'amartinez@mail.com', 'VIP');



