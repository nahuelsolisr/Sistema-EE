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
INSERT INTO productos (cuit_prov, nombre, categoria, marca) VALUES (20333333334, 'Televisor Samsung', 'Electrónica', 'Samsung');
INSERT INTO productos (cuit_prov, nombre, categoria, marca) VALUES (20444444445, 'Camiseta Nike', 'Ropa', 'Nike');
INSERT INTO productos (cuit_prov, nombre, categoria, marca) VALUES (20666666667, 'Zapatos Adidas', 'Calzado', 'Adidas');
INSERT INTO productos (cuit_prov, nombre, categoria, marca) VALUES (20999999990, 'Aceite de Oliva', 'Alimentos', 'Marca X');
INSERT INTO productos (cuit_prov, nombre, categoria, marca) VALUES (20111111112, 'Smartphone iPhone', 'Electrónica', 'Apple');
INSERT INTO productos (cuit_prov, nombre, categoria, marca) VALUES (20333333334, 'Pantalones Levi', 'Ropa', 'Levi');
INSERT INTO productos (cuit_prov, nombre, categoria, marca) VALUES (20444444445, 'Zapatillas New Balance', 'Calzado', 'New Balance');
INSERT INTO productos (cuit_prov, nombre, categoria, marca) VALUES (20666666667, 'Arroz Integral', 'Alimentos', 'Marca Y');
INSERT INTO productos (cuit_prov, nombre, categoria, marca) VALUES (20999999990, 'Smartwatch Samsung', 'Electrónica', 'Samsung');
INSERT INTO productos (cuit_prov, nombre, categoria, marca) VALUES (20111111112, 'Televisor LG', 'Electrónica', 'LG');
INSERT INTO productos (cuit_prov, nombre, categoria, marca) VALUES (20333333334, 'Chaqueta de Cuero', 'Ropa', 'Marca Z');
INSERT INTO productos (cuit_prov, nombre, categoria, marca) VALUES (20444444445, 'Sandalias Birkenstock', 'Calzado', 'Birkenstock');
INSERT INTO productos (cuit_prov, nombre, categoria, marca) VALUES (20666666667, 'Café en grano', 'Alimentos', 'Marca W');
INSERT INTO productos (cuit_prov, nombre, categoria, marca) VALUES (20999999990, 'Tablet Samsung', 'Electrónica', 'Samsung');
INSERT INTO productos (cuit_prov, nombre, categoria, marca) VALUES (20111111112, 'Jeans Wrangler', 'Ropa', 'Wrangler');
INSERT INTO productos (cuit_prov, nombre, categoria, marca) VALUES (20333333334, 'Botas Timberland', 'Calzado', 'Timberland');
INSERT INTO productos (cuit_prov, nombre, categoria, marca) VALUES (20444444445, 'Chocolate Milka', 'Alimentos', 'Milka');
INSERT INTO productos (cuit_prov, nombre, categoria, marca) VALUES (20666666667, 'Impresora HP', 'Electrónica', 'HP');
INSERT INTO productos (cuit_prov, nombre, categoria, marca) VALUES (20999999990, 'Chaleco de Lana', 'Ropa', 'Marca V');
INSERT INTO productos (cuit_prov, nombre, categoria, marca) VALUES (20111111112, 'Zapatos de Vestir', 'Calzado', 'Marca U');
INSERT INTO productos (cuit_prov, nombre, categoria, marca) VALUES (20333333334, 'Aceitunas rellenas', 'Alimentos', 'Marca T');
INSERT INTO productos (cuit_prov, nombre, categoria, marca) VALUES (20444444445, 'Monitor Dell', 'Electrónica', 'Dell');
INSERT INTO productos (cuit_prov, nombre, categoria, marca) VALUES (20666666667, 'Camisa Polo Ralph Lauren', 'Ropa', 'Ralph Lauren');
INSERT INTO productos (cuit_prov, nombre, categoria, marca) VALUES (20999999990, 'Zapatos Deportivos', 'Calzado', 'Marca S');


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
  (22111111114, 'Carolina Rodríguez', 'Avenida Este 159', 'carolinarodriguez@gmail.com', 'Monotributista'),
  (22333333336, 'Roberto González', 'Calle Oeste 357', 'robertogonzalez@yahoo.com', 'Consumidor Final'),
  (22444444447, 'Marcela Torres', 'Avenida Sur 753', 'marcelatorres@gmail.com', 'Responsable Inscripto'),
  (22666666669, 'Lucas Romero', 'Calle Norte 951', 'lucasromero@yahoo.com', 'Monotributista'),
  (22999999992, 'Florencia López', 'Avenida Oeste 357', 'florencialopez@gmail.com', 'Consumidor Final');

drop table fichastock

  CREATE TABLE fichastock(
    fecha datetime,
    IdProducto int primary key identity(1,1),
    Concepto varchar(10),
    UnidadesE int NULL,
    PrecioUE int NULL,
    TotalE int NULL,
    UnidadesS int NULL,
    PrecioUS int NULL,
    TotalS int NULL,
    UnidadesEx int,
    PrecioUEx int,
    TotalEx int,  
)

INSERT INTO fichastock (fecha,IdProducto, Concepto, UnidadesE, PrecioUE, TotalE, UnidadesEx, PrecioUEx, TotalEx) VALUES ('2023-05-25', 'COMPRA', '21', 10, 5600, 56000, 10, 5600, 56000)
INSERT INTO fichastock (fecha,IdProducto, Concepto, UnidadesE, PrecioUE, TotalE, UnidadesEx, PrecioUEx, TotalEx) VALUES ('2023-05-25', '2', 'COMPRA', 20, 100000, 2000000, 20, 100000, 2000000)
INSERT INTO fichastock (fecha,IdProducto, Concepto, UnidadesE, PrecioUE, TotalE, UnidadesEx, PrecioUEx, TotalEx) VALUES ('2023-05-25' , 2, 'COMPRA', 20, 100000, 2000000, 20, 100000, 2000000)