USE master

IF EXISTS(SELECT * FROM sys.databases WHERE Name = 'TrabalhoEAD')
DROP DATABASE TrabalhoEAD

CREATE DATABASE TrabalhoEAD

USE TrabalhoEAD

CREATE TABLE Contatos (
	"Nome" NVARCHAR (128) NOT NULL,
	"Sobrenome" NVARCHAR (128) NOT NULL,
	"Email" NVARCHAR (128) NOT NULL,
	"Celular" NVARCHAR (64) NOT NULL
);

INSERT INTO Contatos 
(Nome, Sobrenome, Email, Celular) 
VALUES 
('Ferrari', 'Carlos', 'carled@gmail.com', '14998885566'),
('Silva', 'José', 'jose@silva.com', '12345678900'),
('Souza', 'João', 'joao@souza.com', '00987654321');