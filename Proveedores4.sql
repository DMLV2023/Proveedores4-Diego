CREATE DATABASE Proveedores4;

USE Proveedores4;

CREATE TABLE Proveedores (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(255) NOT NULL,
    CUIT CHAR(11) NOT NULL UNIQUE, 
    Telefono VARCHAR(14) NOT NULL,
    Correo_Electronico VARCHAR(255) NOT NULL,
    Direccion_Calle VARCHAR(255) NOT NULL,
    Ciudad VARCHAR(100) NOT NULL,
    Pais VARCHAR(100) NOT NULL,
    Codigo_Postal VARCHAR(20) NOT NULL,
	Sitio_Web VARCHAR(255),
    Tipo_Productos_servicios TEXT,
    Fecha_Registro DATE,
	CHECK (CUIT NOT LIKE '%[^0-9]%' AND LEN(CUIT) = 11),  -- Verificar que CUIT tiene exactamente 11 dígitos numéricos
    CHECK (Telefono NOT LIKE '%[^0-9]%' AND LEN(Telefono) BETWEEN 8 AND 14)  -- Verificar que Teléfono tiene entre 8 y 14 dígitos numéricos
);
select*from Proveedores