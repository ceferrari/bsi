USE master

IF EXISTS(SELECT * FROM sys.databases WHERE Name = 'TrabalhoPO')
DROP DATABASE TrabalhoPO

CREATE DATABASE TrabalhoPO

USE TrabalhoPO

CREATE TABLE Usuarios (
	"Id" INT IDENTITY (1, 1) NOT NULL,
	"Nome" NVARCHAR (128) NOT NULL,
	"Email" NVARCHAR (128) NOT NULL,
	"Senha" NVARCHAR (64) NOT NULL,
	"ConfirmarSenha" NVARCHAR (64) NOT NULL,
	CONSTRAINT "PK_Usuarios" PRIMARY KEY ("Id")
);

INSERT INTO Usuarios 
(Nome, Email, Senha, ConfirmarSenha) 
VALUES 
('Carlos Eduardo Ferrari', 'carled@gmail.com', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92');

CREATE TABLE Categorias (
	"Id" INT IDENTITY (1, 1) NOT NULL,
	"Descricao" NVARCHAR (128) NOT NULL,
	"DataAlteracao" DATETIME NOT NULL,
	CONSTRAINT "PK_Categorias" PRIMARY KEY ("Id")
);

INSERT INTO Categorias
(Descricao, DataAlteracao)
VALUES 
('Alimentos',		GETDATE()),
('Bebidas',		GETDATE()),
('Brinquedos',		GETDATE()),
('Eletrodomésticos',	GETDATE()),
('Escritório',		GETDATE()),
('Informática',		GETDATE()),
('Móveis',		GETDATE()),
('Vestuário',		GETDATE())

CREATE TABLE Produtos (
	"Id" INT IDENTITY (1, 1) NOT NULL,
	"Descricao" NVARCHAR (128) NOT NULL,
	"Preco" DECIMAL (8, 2) NOT NULL,
	"EstoqueAtual" INT NOT NULL,
	"EstoqueMinimo" INT NOT NULL,
	"PrecisaReposicao" BIT NOT NULL,
	"DataAlteracao" DATETIME NOT NULL,
	"Categoria" INT NOT NULL,
	CONSTRAINT "PK_Produtos" PRIMARY KEY ("Id"),
	CONSTRAINT "FK_Produtos_Categorias" FOREIGN KEY ("Categoria") REFERENCES Categorias ("Id")
);

INSERT INTO Produtos 
(Descricao, Preco, EstoqueAtual, EstoqueMinimo, PrecisaReposicao, Categoria, DataAlteracao) 
VALUES 
('Caneta',		ROUND(RAND(CHECKSUM(NewId())) * (150-5),5) + 5, ABS(CHECKSUM(NewId())) % 2000, (ABS(CHECKSUM(NewId())) % 100 + 1) * 10, 0, 5, GETDATE()),
('Lápis',		ROUND(RAND(CHECKSUM(NewId())) * (150-5),5) + 5, ABS(CHECKSUM(NewId())) % 2000, (ABS(CHECKSUM(NewId())) % 100 + 1) * 10, 0, 5, GETDATE()),
('Camiseta Polo',	ROUND(RAND(CHECKSUM(NewId())) * (150-5),5) + 5, ABS(CHECKSUM(NewId())) % 2000, (ABS(CHECKSUM(NewId())) % 100 + 1) * 10, 0, 8, GETDATE()),
('Caderno',		ROUND(RAND(CHECKSUM(NewId())) * (150-5),5) + 5, ABS(CHECKSUM(NewId())) % 2000, (ABS(CHECKSUM(NewId())) % 100 + 1) * 10, 0, 5, GETDATE()),
('Bola',		ROUND(RAND(CHECKSUM(NewId())) * (150-5),5) + 5, ABS(CHECKSUM(NewId())) % 2000, (ABS(CHECKSUM(NewId())) % 100 + 1) * 10, 0, 3, GETDATE()),
('Ventilador',		ROUND(RAND(CHECKSUM(NewId())) * (150-5),5) + 5, ABS(CHECKSUM(NewId())) % 2000, (ABS(CHECKSUM(NewId())) % 100 + 1) * 10, 0, 4, GETDATE()),
('Camisa',		ROUND(RAND(CHECKSUM(NewId())) * (150-5),5) + 5, ABS(CHECKSUM(NewId())) % 2000, (ABS(CHECKSUM(NewId())) % 100 + 1) * 10, 0, 8, GETDATE()),
('Régua',		ROUND(RAND(CHECKSUM(NewId())) * (150-5),5) + 5, ABS(CHECKSUM(NewId())) % 2000, (ABS(CHECKSUM(NewId())) % 100 + 1) * 10, 0, 5, GETDATE()),
('Apontador',		ROUND(RAND(CHECKSUM(NewId())) * (150-5),5) + 5, ABS(CHECKSUM(NewId())) % 2000, (ABS(CHECKSUM(NewId())) % 100 + 1) * 10, 0, 5, GETDATE()),
('Calça Jeans',		ROUND(RAND(CHECKSUM(NewId())) * (150-5),5) + 5, ABS(CHECKSUM(NewId())) % 2000, (ABS(CHECKSUM(NewId())) % 100 + 1) * 10, 0, 8, GETDATE()),
('Teclado',		ROUND(RAND(CHECKSUM(NewId())) * (150-5),5) + 5, ABS(CHECKSUM(NewId())) % 2000, (ABS(CHECKSUM(NewId())) % 100 + 1) * 10, 0, 6, GETDATE()),
('Banana',		ROUND(RAND(CHECKSUM(NewId())) * (150-5),5) + 5, ABS(CHECKSUM(NewId())) % 2000, (ABS(CHECKSUM(NewId())) % 100 + 1) * 10, 0, 1, GETDATE()),
('Televisão',		ROUND(RAND(CHECKSUM(NewId())) * (150-5),5) + 5, ABS(CHECKSUM(NewId())) % 2000, (ABS(CHECKSUM(NewId())) % 100 + 1) * 10, 0, 4, GETDATE()),
('Bicicleta',		ROUND(RAND(CHECKSUM(NewId())) * (150-5),5) + 5, ABS(CHECKSUM(NewId())) % 2000, (ABS(CHECKSUM(NewId())) % 100 + 1) * 10, 0, 3, GETDATE()),
('Jaqueta de Couro',	ROUND(RAND(CHECKSUM(NewId())) * (150-5),5) + 5, ABS(CHECKSUM(NewId())) % 2000, (ABS(CHECKSUM(NewId())) % 100 + 1) * 10, 0, 8, GETDATE()),
('Geladeira',		ROUND(RAND(CHECKSUM(NewId())) * (150-5),5) + 5, ABS(CHECKSUM(NewId())) % 2000, (ABS(CHECKSUM(NewId())) % 100 + 1) * 10, 0, 4, GETDATE()),
('Vinho',		ROUND(RAND(CHECKSUM(NewId())) * (150-5),5) + 5, ABS(CHECKSUM(NewId())) % 2000, (ABS(CHECKSUM(NewId())) % 100 + 1) * 10, 0, 2, GETDATE()),
('Mouse',		ROUND(RAND(CHECKSUM(NewId())) * (150-5),5) + 5, ABS(CHECKSUM(NewId())) % 2000, (ABS(CHECKSUM(NewId())) % 100 + 1) * 10, 0, 6, GETDATE()),
('Fogão',		ROUND(RAND(CHECKSUM(NewId())) * (150-5),5) + 5, ABS(CHECKSUM(NewId())) % 2000, (ABS(CHECKSUM(NewId())) % 100 + 1) * 10, 0, 4, GETDATE()),
('Armário',		ROUND(RAND(CHECKSUM(NewId())) * (150-5),5) + 5, ABS(CHECKSUM(NewId())) % 2000, (ABS(CHECKSUM(NewId())) % 100 + 1) * 10, 0, 7, GETDATE()),
('Borracha',		ROUND(RAND(CHECKSUM(NewId())) * (150-5),5) + 5, ABS(CHECKSUM(NewId())) % 2000, (ABS(CHECKSUM(NewId())) % 100 + 1) * 10, 0, 5, GETDATE()),
('Carrinho',		ROUND(RAND(CHECKSUM(NewId())) * (150-5),5) + 5, ABS(CHECKSUM(NewId())) % 2000, (ABS(CHECKSUM(NewId())) % 100 + 1) * 10, 0, 3, GETDATE()),
('Grão de Bico',	ROUND(RAND(CHECKSUM(NewId())) * (150-5),5) + 5, ABS(CHECKSUM(NewId())) % 2000, (ABS(CHECKSUM(NewId())) % 100 + 1) * 10, 0, 1, GETDATE()),
('Compasso',		ROUND(RAND(CHECKSUM(NewId())) * (150-5),5) + 5, ABS(CHECKSUM(NewId())) % 2000, (ABS(CHECKSUM(NewId())) % 100 + 1) * 10, 0, 5, GETDATE()),
('Mesa',		ROUND(RAND(CHECKSUM(NewId())) * (150-5),5) + 5, ABS(CHECKSUM(NewId())) % 2000, (ABS(CHECKSUM(NewId())) % 100 + 1) * 10, 0, 7, GETDATE()),
('Tesoura',		ROUND(RAND(CHECKSUM(NewId())) * (150-5),5) + 5, ABS(CHECKSUM(NewId())) % 2000, (ABS(CHECKSUM(NewId())) % 100 + 1) * 10, 0, 5, GETDATE()),
('Vestido',		ROUND(RAND(CHECKSUM(NewId())) * (150-5),5) + 5, ABS(CHECKSUM(NewId())) % 2000, (ABS(CHECKSUM(NewId())) % 100 + 1) * 10, 0, 8, GETDATE()),
('Cadeira',		ROUND(RAND(CHECKSUM(NewId())) * (150-5),5) + 5, ABS(CHECKSUM(NewId())) % 2000, (ABS(CHECKSUM(NewId())) % 100 + 1) * 10, 0, 7, GETDATE()),
('Papel',		ROUND(RAND(CHECKSUM(NewId())) * (150-5),5) + 5, ABS(CHECKSUM(NewId())) % 2000, (ABS(CHECKSUM(NewId())) % 100 + 1) * 10, 0, 5, GETDATE()),
('Carteira',		ROUND(RAND(CHECKSUM(NewId())) * (150-5),5) + 5, ABS(CHECKSUM(NewId())) % 2000, (ABS(CHECKSUM(NewId())) % 100 + 1) * 10, 0, 7, GETDATE()),
('Fichário',		ROUND(RAND(CHECKSUM(NewId())) * (150-5),5) + 5, ABS(CHECKSUM(NewId())) % 2000, (ABS(CHECKSUM(NewId())) % 100 + 1) * 10, 0, 5, GETDATE()),
('Cerveja',		ROUND(RAND(CHECKSUM(NewId())) * (150-5),5) + 5, ABS(CHECKSUM(NewId())) % 2000, (ABS(CHECKSUM(NewId())) % 100 + 1) * 10, 0, 2, GETDATE()),
('Corda',		ROUND(RAND(CHECKSUM(NewId())) * (150-5),5) + 5, ABS(CHECKSUM(NewId())) % 2000, (ABS(CHECKSUM(NewId())) % 100 + 1) * 10, 0, 3, GETDATE()),
('Arroz',		ROUND(RAND(CHECKSUM(NewId())) * (150-5),5) + 5, ABS(CHECKSUM(NewId())) % 2000, (ABS(CHECKSUM(NewId())) % 100 + 1) * 10, 0, 1, GETDATE());

UPDATE Produtos SET PrecisaReposicao = 1 WHERE EstoqueAtual < EstoqueMinimo;