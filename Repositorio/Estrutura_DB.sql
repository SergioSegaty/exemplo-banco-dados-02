DROP TABLE filmes;
CREATE TABLE filmes (
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100) NOT NULL,
	avaliacao DECIMAL(3,1),
	duracao DATETIME2,
	curtiu BIT, -- TRUE 1 / FALSE 0
	categoria VARCHAR(100)NOT NULL,
	tem_sequencia BIT
);

INSERT INTO filmes (nome, avaliacao, duracao, curtiu, categoria, tem_sequencia)
VALUES
('Carros 3', 10.0, '2000-01-01 02:30:00', 1, 'Infantil', 1),
('Professor !(não) é bipolar', 5.3, '2003-01-03 01:45:00', 1, 'Ação', 0);

SELECT * FROM filmes;