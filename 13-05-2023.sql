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

drop table usuarios

create table productos(
id_producto INT IDENTITY(1,1) PRIMARY KEY,
nombre varchar(20),
categoria varchar(20),
marca varchar(20),
cantidad int NULL,
precio float NULL,
porcentajeg float NULL
)




select * from productos
INSERT INTO productos (nombre, categoria, marca)
VALUES ('Leche', 'Lácteos', 'Alpura'),
('Pan', 'Panadería', 'Bimbo'),
('Jabón', 'Higiene personal', 'Zote'),
('Arroz', 'Alimentos básicos', 'Lala'),
('Refresco', 'Bebidas', 'Coca-Cola'),
('Crema', 'Lácteos', 'Nestlé'),
('Cereal', 'Desayunos', 'Kelloggs'),
('Pañales', 'Bebés', 'Huggies'),
('Galletas', 'Snacks', 'Gamesa'),
('Pasta dental', 'Higiene personal', 'Colgate'),
('Atún', 'Conservas', 'Dolphin'),
('Papel higiénico', 'Higiene personal', 'Suavel'),
('Sopa', 'Alimentos básicos', 'Maggi'),
('Shampoo', 'Higiene personal', 'Pantene'),
('Café', 'Bebidas', 'Nescafé');



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





