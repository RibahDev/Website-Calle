-- Criação do banco de dados
CREATE DATABASE Calledb;
USE Calledb;

-- Criação da tabela Categoria
CREATE TABLE Categoria (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL
);

-- Inserção de dados na tabela Categoria
INSERT INTO Categoria (nome) VALUES
('camisas'),
('regatas'),
('blusas'),
('moletons'),
('jaquetas'),
('croppeds'),
('calcas'),
('bermudas'),
('bones'),
('bags'),
('shapes');

-- Criação da tabela Product
CREATE TABLE Product (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    descricao VARCHAR(500),
    preco DECIMAL(10, 2),
    qtdEstoque INT,
    foto varchar(500),
    CategoriaId INT,
    FOREIGN KEY (CategoriaId) REFERENCES Categoria(id)
);

-- Criação da tabela User
CREATE TABLE AppUser (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nomeCompleto VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,
    CPF VARCHAR(14) NOT NULL UNIQUE
);


SELECT * FROM Product;

SELECT * FROM Categoria;

DELETE FROM Product WHERE id = 4;

INSERT INTO Product (nome, descricao, preco, qtdEstoque, foto, CategoriaId) VALUES ('BLUSA MOLETOM BORDÔ CALLE','Blusa Moletom com Capuz e bolso Canguru, cor bordô com logo da CALLE Branca, Tecido 100% Algodão',159.99,5, '1.jfif', 3);
INSERT INTO Product (nome, descricao, preco, qtdEstoque, foto, CategoriaId) VALUES ('BLUSA MOLETOM Erykah Badu VERMELHO CALLE','Blusa Moletom com Capuz e bolso Canguru, cor vermelha com imagem da Erykah Badu estampado, Tecido 100% Algodão',159.99,5, '2.jfif', 3);
INSERT INTO Product (nome, descricao, preco, qtdEstoque, foto, CategoriaId) VALUES ('BLUSA MOLETOM PRETA CALLE','Blusa Moletom com Capuz e bolso Canguru, cor preta com logo da CALLE estampado, Tecido 100% Algodão',159.99,5, '3.jfif', 3);
INSERT INTO Product (nome, descricao, preco, qtdEstoque, foto, CategoriaId) VALUES ('BLUSA MOLETOM PRETO Non Dvcor Dvco CALLE','Blusa Moletom com Capuz e bolso Canguru, cor preta com frase Non Dvcor Dvco CALLE estampado, Tecido 100% Algodão',159.99,5, '4.jfif', 3);
INSERT INTO Product (nome, descricao, preco, qtdEstoque, foto, CategoriaId) VALUES ('BLUSA MOLETOM ROXA CALLE','Blusa Moletom com Capuz e bolso Canguru, cor roxa com logo da CALLE estampado, Tecido 100% Algodão',159.99,5, '5.jfif', 3);
INSERT INTO Product (nome, descricao, preco, qtdEstoque, foto, CategoriaId) VALUES ('BLUSA MOLETOM VERMELHA CALLE','Blusa Moletom com Capuz e bolso Canguru, cor vermelha com logo da CALLE estampado, Tecido 100% Algodão',159.99,5, '6.jfif', 3);
INSERT INTO Product (nome, descricao, preco, qtdEstoque, foto, CategoriaId) VALUES ('BLUSA MOLETOM Erykah Badu PRETO CALLE','Blusa Moletom com Capuz e bolso Canguru, cor vermelha com imagem da Erykah Badu estampado, Tecido 100% Algodão',159.99,5, '7.jfif', 3);
INSERT INTO Product (nome, descricao, preco, qtdEstoque, foto, CategoriaId) VALUES ('BLUSA MOLETOM Martin Luther King BRANCO CALLE','Blusa Moletom com Capuz e bolso Canguru, cor branca com frase do marthin luther king estampado, Tecido 100% Algodão',159.99,5, '8.jfif', 3);
INSERT INTO Product (nome, descricao, preco, qtdEstoque, foto, CategoriaId) VALUES ('BLUSA MOLETON PRETA CALLE','Blusa Moletom com Capuz e bolso Canguru, cor preta com logo da CALLE estampado, Tecido 100% Algodão',159.99,5, '9.jfif', 3);
INSERT INTO Product (nome, descricao, preco, qtdEstoque, foto, CategoriaId) VALUES ('JAQUETA FLANELADA XADRES PRETA CALLE','Blusa Flanelada Xadres, cor preta e cinza com 2 bolsos de botoes',159.99,5, '10.jfif', 5);
INSERT INTO Product (nome, descricao, preco, qtdEstoque, foto, CategoriaId) VALUES ('JAQUETA FLANELADA XADRES VERMELHA CALLE','Blusa Flanelada Xadres, cor vermelha e preta com 2 bolsos de botoes',159.99,5, '11.jfif', 5);
INSERT INTO Product (nome, descricao, preco, qtdEstoque, foto, CategoriaId) VALUES ('CAMISETA It Could Be So Simple PRETA CALLE','Camiseta manga curta, cor preta, com a frase It Could Be So Simple. estampada',59.99,5, '12.jfif', 1);
INSERT INTO Product (nome, descricao, preco, qtdEstoque, foto, CategoriaId) VALUES ('CROPPED BORDÔ CALLE','Cropped manga curta, cor bordô, com a logo CALLE estampada',39.99,5, '13.jfif', 6);
INSERT INTO Product (nome, descricao, preco, qtdEstoque, foto, CategoriaId) VALUES ('CROPPED CINZA CALLE','Cropped manga curta, cor cinza, com a logo CALLE estampada',39.99,5, '14.jfif', 6);
INSERT INTO Product (nome, descricao, preco, qtdEstoque, foto, CategoriaId) VALUES ('CROPPED PRETO CALLE','Cropped manga curta, cor preta, com a logo CALLE estampada',39.99,5, '15.jfif', 6);
INSERT INTO Product (nome, descricao, preco, qtdEstoque, foto, CategoriaId) VALUES ('CALÇA CARGO BEGE CALLE','Calça Cargo, cor bege, tecido tactel, logo CALLE estampado na perna direita, ajuste na cintura por cordão',159.99,5, '16.jfif', 7);
INSERT INTO Product (nome, descricao, preco, qtdEstoque, foto, CategoriaId) VALUES ('CALÇA CARGO CHOCOLATE CALLE','Calça Cargo, cor chocolate, tecido leve e confortavel, logo CALLE estampado na perna, elastico na cintura',159.99,5, '17.jfif', 7);
INSERT INTO Product (nome, descricao, preco, qtdEstoque, foto, CategoriaId) VALUES ('CALÇA CARGO JEANS AZUL ESCURO CALLE','Calça Cargo, cor azul escuro, tecido jeans, logo CALLE estampado na perna, elastico na cintura',159.99,5, '18.jfif', 7);
INSERT INTO Product (nome, descricao, preco, qtdEstoque, foto, CategoriaId) VALUES ('CALÇA CARGO JEANS CLARA CALLE','Calça Cargo, cor azul claro, tecido jeans, logo CALLE estampado na perna, elastico na cintura',159.99,5, '19.jfif', 7);
INSERT INTO Product (nome, descricao, preco, qtdEstoque, foto, CategoriaId) VALUES ('CALÇA CARGO MARROM ESCURO CALLE','Calça Cargo, cor marrom escuro, tecido leve e confortavel, logo CALLE estampado na perna, elastico na cintura',159.99,5, '20.jfif', 7);
INSERT INTO Product (nome, descricao, preco, qtdEstoque, foto, CategoriaId) VALUES ('CALÇA CARGO PRETA CALLE','Calça Cargo, cor preta, tecido leve e confortavel, logo CALLE estampado na perna, elastico na cintura',159.99,5, '21.jfif', 7);
INSERT INTO Product (nome, descricao, preco, qtdEstoque, foto, CategoriaId) VALUES ('CALÇA CARGO Veludo Cotelê Off White CALLE','Calça Cargo, cor branca, tecido leve e confortavel, logo CALLE estampado na perna, elastico na cintura',159.99,5, '22.jfif', 7);
INSERT INTO Product (nome, descricao, preco, qtdEstoque, foto, CategoriaId) VALUES ('BONE 5 Five Panel AZUL E PRETO CALLE','Calça Cargo, cor azul e preto, logo CALLE estampado na frente',89.99,5, '23.jfif', 9);
INSERT INTO Product (nome, descricao, preco, qtdEstoque, foto, CategoriaId) VALUES ('BONE 5 Five Panel VERDE E PRETO CALLE','Calça Cargo, cor verde e preto, logo CALLE estampado na frente',89.99,5, '24.jfif', 9);
INSERT INTO Product (nome, descricao, preco, qtdEstoque, foto, CategoriaId) VALUES ('BONE ABA CURVA VERMELHO E AZUL MARINHO CALLE','Calça Cargo, cor vermelho e azul marinho, logo CALLE estampado na frente',89.99,5, '25.jfif', 9);











