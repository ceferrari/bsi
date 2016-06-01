USE master

IF EXISTS(SELECT * FROM sys.databases WHERE Name = 'TrabalhoPO')
DROP DATABASE TrabalhoPO

CREATE DATABASE TrabalhoPO

USE TrabalhoPO

CREATE TABLE Usuarios (
	"UsuarioID" INT IDENTITY (1, 1) NOT NULL,
	"Nome" NVARCHAR (128) NOT NULL,
	"Email" NVARCHAR (128) NOT NULL,
	"Senha" NVARCHAR (64) NOT NULL,
	CONSTRAINT "PK_Usuarios" PRIMARY KEY ("UsuarioID")
);

INSERT INTO Usuarios 
(Nome, Email, Senha) 
VALUES 
('Carlos Eduardo Ferrari', 'carled@gmail.com', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92');

CREATE TABLE Categorias (
	"CategoriaID" INT IDENTITY (1, 1) NOT NULL,
	"Descricao" NVARCHAR (128) NOT NULL,
	CONSTRAINT "PK_Categorias" PRIMARY KEY ("CategoriaID")
);

INSERT INTO Categorias
(Descricao) 
VALUES 
('Alimentação'),
('Bebidas'),
('Brinquedos'),
('Eletrodomésticos'),
('Escritório'),
('Informática'),
('Móveis'),
('Vestuário')

CREATE TABLE Produtos (
	"ProdutoID" INT IDENTITY (1, 1) NOT NULL,
	"Descricao" NVARCHAR (128) NOT NULL,
	"Preco" DECIMAL (8, 2) NOT NULL,
	"EstoqueAtual" INT NOT NULL,
	"EstoqueMinimo" INT NOT NULL,
	"PrecisaReposicao" BIT NOT NULL,
	"DataAlteracao" DATETIME NOT NULL,
	"Categoria" INT NOT NULL,
	CONSTRAINT "PK_Produtos" PRIMARY KEY ("ProdutoID"),
	CONSTRAINT "FK_Produtos_Categorias" FOREIGN KEY ("Categoria") REFERENCES Categorias ("CategoriaID")
);

INSERT INTO Produtos 
(Descricao, Preco, EstoqueAtual, EstoqueMinimo, PrecisaReposicao, Categoria, DataAlteracao) 
VALUES 
('Caneta', 23.90, 56, 40, 0, 5, GETDATE()),
('Lápis', 12.56, 42, 50, 1, 5, GETDATE()),
('Caderno', 11.74, 62, 30, 0, 5, GETDATE()),
('Bola', 22.79, 34, 40, 1, 3, GETDATE()),
('Ventilador', 16.31, 27, 30, 1, 4, GETDATE()),
('Régua', 18.25, 48, 20, 0, 5, GETDATE()),
('Apontador', 24.02, 55, 40, 0, 5, GETDATE()),
('Borracha', 10.39, 21, 50, 1, 5, GETDATE()),
('Compasso', 23.72, 39, 40, 1, 5, GETDATE()),
('Tesoura', 14.18, 43, 30, 0, 5, GETDATE()),
('Cadeira', 8.46, 35, 20, 0, 7, GETDATE()),
('Mesa', 12.44, 17, 30, 1, 7, GETDATE()),
('Papel', 6.59, 22, 40, 1, 5, GETDATE()),
('Carteira', 13.08, 41, 50, 1, 7, GETDATE()),
('Fichário', 17.55, 53, 40, 0, 5, GETDATE()),
('Cerveja', 9.18, 12, 40, 1, 2, GETDATE()),
('Carrinho', 23.21, 49, 50, 1, 3, GETDATE()),
('Corda', 15.99, 33, 20, 0, 3, GETDATE()),
('Arroz', 6.87, 54, 20, 0, 1, GETDATE()),
('Teclado', 31.45, 18, 30, 1, 6, GETDATE()),
('Banana', 20.56, 35, 20, 0, 1, GETDATE()),
('Televisão', 19.00, 30, 40, 1, 4, GETDATE()),
('Bicicleta', 11.31, 27, 30, 1, 3, GETDATE()),
('Geladeira', 28.09, 44, 50, 1, 4, GETDATE()),
('Vinho', 7.63, 26, 40, 1, 2, GETDATE()),
('Mouse', 25.01, 22, 20, 0, 6, GETDATE()),
('Fogão', 34.46, 24, 50, 1, 4, GETDATE()),
('Armário', 43.20, 66, 50, 0, 7, GETDATE()),
('Camisa', 17.39, 51, 50, 0, 8, GETDATE()),
('Vestido', 13.88, 69, 40, 0, 8, GETDATE()),
('Calça', 26.71, 13, 30, 1, 8, GETDATE())