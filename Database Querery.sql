-- 1. Create Database
CREATE DATABASE LaundryDb;
GO

-- 2. Use the Database
USE LaundryDb;
GO

-- 3. Create Table
CREATE TABLE users (
    user_id INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,
    role VARCHAR(50) NOT NULL,
    first_name VARCHAR(100) NULL,
    middle_name VARCHAR(100) NULL,
    last_name VARCHAR(100) NULL,
    address VARCHAR(255) NULL,
    contact VARCHAR(50) NULL,
    created_at DATETIME DEFAULT GETDATE() NOT NULL
);
GO

-- 4. Insert Seed Data (hashed passwords already prepared)

-- Admin user admin123
INSERT INTO users (username, password, role, first_name, last_name, address, contact)
VALUES ('admin', 'JAvlGPq9JyTdtvBO6x2llnRI1+gxwIyPqCKAn3THIKk=', 'admin', 'Admin', 'User', 'HQ', '09123456789');

-- Laundry attendant123
INSERT INTO users (username, password, role, first_name, last_name, address, contact)
VALUES ('attendant', 'zm4XkvaxBirT8rU6zVmHowL8B7Sv8gNjtNS6/merSsc=', 'laundry_attendant', 'Attendant', 'User', 'Branch1', '09121212121');

-- Customer user123
INSERT INTO users (username, password, role, first_name, last_name, address, contact)
VALUES ('customer', 'sEHArrNbsPpKpmjKWpILWQGW/a+aAOuFLJt/TRI8xtY=', 'customer', 'Customer', 'User', 'City', '09998887777');
GO
