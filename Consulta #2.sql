SET time_zone = 'UTC';
INSERT INTO cargos(cargo) VALUES ('Director');
INSERT INTO cargos(cargo) VALUES ('Recepcionista');
INSERT INTO cargos(cargo) VALUES ('Ayudantes');
INSERT INTO cargos(cargo) VALUES ('Champunier');
INSERT INTO cargos(cargo) VALUES ('Peluqueros');
INSERT INTO cargos(cargo) VALUES ('Técnicos');
INSERT INTO cargos(cargo) VALUES ('Manicuras');
INSERT INTO cargos(cargo) VALUES ('Esteticistas');
SELECT *
FROM cargos;
INSERT Estadoscitas(nombre) VALUES ('Finalizada');
INSERT Estadoscitas(nombre) VALUES ('Pendiente');
INSERT Estadoscitas(nombre) VALUES ('Anulada');
INSERT INTO EstadosNomina(nombre) VALUES ('Activa');
INSERT INTO EstadosNomina(nombre) VALUES ('Inactiva');
SELECT *
FROM estadosnomina;
INSERT INTO empleados(cedula,nombre, telefono, celular, email, fecha_inicio, direccion,estado,cargo) VALUES ('032-0221324-4','Luis Gomez','8093238462','8093238462','LuisBarberShop@gmail.com','2022-09-03','Calle Doctor Virgilio Garcia Casi ESQ 16 de Agosto, Cabrera provincia Maria Trinidad Sanchez, RD',1,1);
SELECT *
FROM empleados;
INSERT INTO clientes(nombre,telefono,celular,email,direccion) VALUES ('Maximo Ulloa','809-323-3232','809-323-3232','prueba@gmail.com','Direccion de prueba');
SELECT *
FROM clientes;
INSERT INTO citas(cliente,empleado,fecha,estado) VALUES (1,1,'2022-08-10 08:30:00.123456',1);
INSERT INTO citas(cliente,empleado,fecha,estado) VALUES (1,1,'2022-08-10 08:30:00.123456',2);
SELECT *
FROM citas;
INSERT INTO servicios(servicio,precio,descripcion) VALUE ('Corte de pelo hombre', 200,'');
INSERT INTO servicios(servicio,precio,descripcion) VALUE ('Corte de pelo niño', 100,'');
INSERT INTO servicios(servicio,precio,descripcion) VALUE ('Corte de pelo niña', 100,'');
INSERT INTO servicios(servicio,precio,descripcion) VALUE ('Corte de pelo bebe', 100,'');
INSERT INTO servicios(servicio,precio,descripcion) VALUE ('Corte de barba hombre', 100,'');
INSERT INTO servicios(servicio,precio,descripcion) VALUE ('Peinado express', 50,'');
INSERT INTO servicios(servicio,precio,descripcion) VALUE ('Lavado + Secado', 100,'');
INSERT INTO servicios(servicio,precio,descripcion) VALUE ('Lavar + Peinar', 75,'');
INSERT INTO servicios(servicio,precio,descripcion) VALUE ('Lavar + Peinar + Cortar', 500,'');
SELECT * 
FROM servicios;
INSERT INTO EstadoFactura(nombre) VALUES ('Saldado');
INSERT INTO EstadoFactura(nombre) VALUES ('Pendiente');
INSERT INTO EstadoFactura(nombre) VALUES ('Anulada');
INSERT INTO credenciales(empleado,usuario,pasw) VALUES (1, 'admin','4FB5E50E2790532C25629D5FC211F853');