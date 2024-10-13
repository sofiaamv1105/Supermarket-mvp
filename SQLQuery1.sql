USE Supermarket;

-- Crear la tabla Category
CREATE TABLE Category
(
    Category_Id INT IDENTITY(1,1) PRIMARY KEY, -- Clave primaria autoincremental
    Category_Name NVARCHAR(100) NOT NULL,      -- Nombre de la categoría, no nulo
    Description CHAR(255)                      -- Descripción de la categoría, puede ser nula
);
-- Insertar algunos datos de ejemplo en la tabla Category
INSERT INTO Category (Category_Name, Description) VALUES ('Beverages', 'Drinks including water, soda, and juice');
INSERT INTO Category (Category_Name, Description) VALUES ('Dairy Products', 'Milk, cheese, and other dairy items');
INSERT INTO Category (Category_Name, Description) VALUES ('Meat', 'Fresh and frozen meats including beef and chicken');

