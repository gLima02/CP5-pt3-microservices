Checkpoint 05 / parte 3 

Guilherme Lima Oliveira RM93401

- Comandos utilizados

DOCKER: docker run --name database-mysql -e MYSQL_ROOT_PASSWORD=123 -p 3306:3306 -d mysql 

REDIS : docker run --name redis -p 6379:6379 -d redis

- SCRIPT UTILIZADO: 

CREATE TABLE `sys`.`produtos` (\
  `id` INT NOT NULL AUTO_INCREMENT,\
  `nome` VARCHAR(45) NULL,\
  `preco` DOUBLE NULL,\
  `quantidade_estoque` INT NULL,\
  `data_criacao` VARCHAR(45) NULL,\
  PRIMARY KEY (`id`));


CREATE TABLE `sys`.`usuarios` (\
    `id` INT NOT NULL AUTO_INCREMENT,\
    `nome`  VARCHAR(45) NULL,\
    `email` VARCHAR(45) NULL\
    PRIMARY KEY (`id`));\