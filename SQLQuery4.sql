USE Supermarket; 
CREATE TABLE Providers
(
    Provider_Id INT IDENTITY(1,1) PRIMARY KEY,   -- Clave primaria autoincremental
    Document_Number NVARCHAR(50) NOT NULL,       -- Número de documento, obligatorio
    First_Name NVARCHAR(50) NOT NULL,            -- Primer nombre, obligatorio
    Last_Name NVARCHAR(50) NOT NULL,             -- Apellido, obligatorio
    Address NVARCHAR(255) NOT NULL,              -- Dirección, obligatorio
    Birthday DATE NOT NULL,                       -- Fecha de nacimiento, obligatorio
    Phone_Number NVARCHAR(15) NOT NULL,          -- Número de teléfono, obligatorio
    Email NVARCHAR(100) NOT NULL                  -- Correo electrónico, obligatorio
);
INSERT INTO Providers (Document_Number, First_Name, Last_Name, Address, Birthday, Phone_Number, Email)
VALUES 
('12345678', 'John', 'Doe', '123 Main St', '1990-01-01', '1234567890', 'john.doe@example.com'),
('87654321', 'Jane', 'Smith', '456 Side St', '1985-05-15', '0987654321', 'jane.smith@example.com');
