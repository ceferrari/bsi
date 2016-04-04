USE master

IF EXISTS(SELECT * FROM sys.databases WHERE Name = 'ProjetoFinal')
DROP DATABASE ProjetoFinal

CREATE DATABASE ProjetoFinal

USE ProjetoFinal

CREATE TABLE Produtos (
	"Codigo" INT IDENTITY (1, 1) NOT NULL,
	"Descricao" NVARCHAR (128) NOT NULL,
	"Preco" DECIMAL (8, 2) NOT NULL,
	"EstoqueAtual" INT NOT NULL,
	"EstoqueMinimo" INT NOT NULL,
	"PrecisaReposicao" CHAR NOT NULL,
	"DataAlteracao" DATETIME NOT NULL,
	CONSTRAINT "PK_Produtos" PRIMARY KEY (
		"Codigo"
	)
);

INSERT INTO Produtos (Descricao, Preco, EstoqueAtual, EstoqueMinimo, PrecisaReposicao, DataAlteracao) VALUES 
('Caneta', 23.90, 56, 40, 'N', GETDATE()),
('Lápis', 12.56, 42, 50, 'S', GETDATE()),
('Caderno', 11.74, 62, 30, 'N', GETDATE()),
('Bola', 22.79, 34, 40, 'S', GETDATE()),
('Ventilador', 16.31, 27, 30, 'S', GETDATE()),
('Régua', 18.25, 48, 20, 'N', GETDATE()),
('Apontador', 24.02, 55, 40, 'N', GETDATE()),
('Borracha', 10.39, 21, 50, 'S', GETDATE()),
('Compasso', 23.72, 39, 40, 'S', GETDATE()),
('Tesoura', 14.18, 43, 30, 'N', GETDATE()),
('Cadeira', 8.46, 35, 20, 'N', GETDATE()),
('Mesa', 12.44, 17, 30, 'S', GETDATE()),
('Papel', 6.59, 22, 40, 'S', GETDATE()),
('Carteira', 13.08, 41, 50, 'S', GETDATE()),
('Corda', 20.64, 30, 20, 'N', GETDATE()),
('Fichário', 17.55, 53, 40, 'N', GETDATE());