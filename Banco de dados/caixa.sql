-- --------------------------------------------------------
-- Servidor:                     C:\Users\natan.gacastro\bin\projeto-caixa\caixa.sqlite3
-- Versão do servidor:           3.39.4
-- OS do Servidor:               
-- HeidiSQL Versão:              12.3.0.6589
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES  */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Copiando estrutura do banco de dados para caixa
CREATE DATABASE IF NOT EXISTS "caixa";
;

-- Copiando estrutura para tabela caixa.categoria
CREATE TABLE IF NOT EXISTS categoria 
( 
 id INTEGER PRIMARY KEY AUTOINCREMENT,  
 nome TEXT(60) NOT NULL,
 ativo INTEGER NOT NULL DEFAULT 1,
 UNIQUE (nome)
);

-- Copiando dados para a tabela caixa.categoria: -1 rows
DELETE FROM "categoria";
/*!40000 ALTER TABLE "categoria" DISABLE KEYS */;
INSERT INTO "categoria" ("id", "nome", "ativo") VALUES
	(1, 'teste ativo', 1),
	(2, 'teste inativo', 0);
/*!40000 ALTER TABLE "categoria" ENABLE KEYS */;

-- Copiando estrutura para tabela caixa.cliente
CREATE TABLE IF NOT EXISTS cliente 
( 
 id INTEGER PRIMARY KEY AUTOINCREMENT,  
 nome TEXT NOT NULL,  
 cpf_cnpj VARCHAR(20) NOT NULL,  
 data_nascimento TEXT(10) NOT NULL,
 ativo INTEGER NOT NULL DEFAULT 1,
 id_endereco INTEGER NOT NULL,
 FOREIGN KEY(id_endereco) REFERENCES endereco (id) ON DELETE SET NULL
);

-- Copiando dados para a tabela caixa.cliente: -1 rows
DELETE FROM "cliente";
/*!40000 ALTER TABLE "cliente" DISABLE KEYS */;
INSERT INTO "cliente" ("id", "nome", "cpf_cnpj", "data_nascimento", "ativo", "id_endereco") VALUES
	(1, 'maria', '333.333.333-33', '2000-02-10', 1, 1),
	(2, 'joão', '22.222.222/2222-22', '1990-12-10', 1, 1);
/*!40000 ALTER TABLE "cliente" ENABLE KEYS */;

-- Copiando estrutura para tabela caixa.endereco
CREATE TABLE IF NOT EXISTS endereco 
( 
 id INTEGER PRIMARY KEY AUTOINCREMENT,
 rua TEXT(60) NOT NULL,
 numero TEXT(4) NOT NULL,
 bairro TEXT(60) NOT NULL,
 complemento TEXT(60),
 cidade TEXT(60) NOT NULL,
 uf VARCHAR(2) NOT NULL,
 cep VARCHAR(9) NOT NULL,
 pais TEXT
);

-- Copiando dados para a tabela caixa.endereco: -1 rows
DELETE FROM "endereco";
/*!40000 ALTER TABLE "endereco" DISABLE KEYS */;
INSERT INTO "endereco" ("id", "rua", "numero", "bairro", "complemento", "cidade", "uf", "cep", "pais") VALUES
	(1, 'Passo fundo', '3232', 'Santo antonio', 'casa', 'Rio de Janeiro', 'MG', '11111-111', 'Brasil');
/*!40000 ALTER TABLE "endereco" ENABLE KEYS */;

-- Copiando estrutura para tabela caixa.itens_venda
CREATE TABLE IF NOT EXISTS itens_venda
( 
 id_venda INTEGER NOT NULL,
 codigo_produto TEXT NOT NULL,
 quantidade INTEGER NOT NULL,
 valor_unit REAL NOT NULL,
 valor_total REAL NOT NULL,
 PRIMARY KEY (id_venda, codigo_produto),
 FOREIGN KEY (id_venda) REFERENCES venda (id)
 ON DELETE CASCADE ON UPDATE NO ACTION,
 FOREIGN KEY (codigo_produto) REFERENCES produto (codigo_barras)
 ON DELETE SET NULL ON UPDATE CASCADE 
);

-- Copiando dados para a tabela caixa.itens_venda: -1 rows
DELETE FROM "itens_venda";
/*!40000 ALTER TABLE "itens_venda" DISABLE KEYS */;
/*!40000 ALTER TABLE "itens_venda" ENABLE KEYS */;

-- Copiando estrutura para tabela caixa.metodo_pagamento
CREATE TABLE IF NOT EXISTS metodo_pagamento (
	"id" INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	"nome" TEXT NOT NULL
);

-- Copiando dados para a tabela caixa.metodo_pagamento: -1 rows
DELETE FROM "metodo_pagamento";
/*!40000 ALTER TABLE "metodo_pagamento" DISABLE KEYS */;
INSERT INTO "metodo_pagamento" ("id", "nome") VALUES
	(1, 'CREDITO'),
	(2, 'DEBITO'),
	(3, 'DINHEIRO'),
	(4, 'PIX');
/*!40000 ALTER TABLE "metodo_pagamento" ENABLE KEYS */;

-- Copiando estrutura para tabela caixa.produto
CREATE TABLE IF NOT EXISTS produto 
( 
 codigo_barras TEXT PRIMARY KEY NOT NULL,  
 nome TEXT NOT NULL,  
 valor_produto TEXT NOT NULL,  
 valor_venda TEXT NOT NULL,  
 margem_lucro TEXT NOT NULL,  
 quantidade INTEGER NOT NULL DEFAULT '0',
 ativo INTEGER NOT NULL DEFAULT 1,
 id_categoria INTEGER NOT NULL,
 FOREIGN KEY(id_categoria) REFERENCES categoria (id) ON DELETE SET NULL
);

-- Copiando dados para a tabela caixa.produto: -1 rows
DELETE FROM "produto";
/*!40000 ALTER TABLE "produto" DISABLE KEYS */;
INSERT INTO "produto" ("codigo_barras", "nome", "valor_produto", "valor_venda", "margem_lucro", "quantidade", "ativo", "id_categoria") VALUES
	('123', 'camisa', '10,00', '20,00', '50', 10, 1, 1),
	('456', 'blusa', '30,00', '60,00', '50', 10, 1, 1),
	('789', 'calça', '60,00', '120,00', '50', 10, 0, 1);
/*!40000 ALTER TABLE "produto" ENABLE KEYS */;

-- Copiando estrutura para tabela caixa.usuario
CREATE TABLE IF NOT EXISTS usuario 
( 
 id INTEGER PRIMARY KEY AUTOINCREMENT,  
 nome TEXT NOT NULL,  
 senha TEXT,
 ativo INTEGER NOT NULL DEFAULT 1
);

-- Copiando dados para a tabela caixa.usuario: -1 rows
DELETE FROM "usuario";
/*!40000 ALTER TABLE "usuario" DISABLE KEYS */;
INSERT INTO "usuario" ("id", "nome", "senha", "ativo") VALUES
	(1, 'adm', '123', 1);
/*!40000 ALTER TABLE "usuario" ENABLE KEYS */;

-- Copiando estrutura para tabela caixa.venda
CREATE TABLE IF NOT EXISTS venda (
	"id" INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	"id_cliente" INTEGER NOT NULL,
	"id_usuario" INTEGER NOT NULL,
	"id_metodo_pagamento" INTEGER NOT NULL,
	"valor_total" REAL NOT NULL,
	"desconto" REAL DEFAULT "0,00",
	"valor_final" REAL NOT NULL,
	"data_venda" TEXT(10) NOT NULL,
	FOREIGN KEY ("id_cliente") REFERENCES "cliente" ("id")
	ON DELETE SET NULL ON UPDATE CASCADE,
	FOREIGN KEY ("id_usuario") REFERENCES "usuario" ("id")
	ON DELETE SET NULL ON UPDATE CASCADE,
	FOREIGN KEY ("id_metodo_pagamento") REFERENCES "metodo_pagamento" ("id")
	ON DELETE NO ACTION ON UPDATE CASCADE
);

-- Copiando dados para a tabela caixa.venda: -1 rows
DELETE FROM "venda";
/*!40000 ALTER TABLE "venda" DISABLE KEYS */;
/*!40000 ALTER TABLE "venda" ENABLE KEYS */;

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
