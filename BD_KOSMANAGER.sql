-- Criando banco de dados
CREATE DATABASE BD_KOSMANAGER;

-- Colocando ele em uso
USE BD_KOSMANAGER;

-- Criando tabelas
CREATE TABLE TB_OPERADOR_PRINCIPAL (
TB_OPERADOR_PRINCIPAL_ID INTEGER primary key NOT NULL auto_increment,
TB_OPERADOR_PRINCIPAL_NOME varchar(120) NOT NULL,
TB_OPERADOR_PRINCIPAL_EMAIL varchar(256) NOT NULL,
TB_OPERADOR_PRINCIPAL_SENHA char(8) NOT NULL
);

CREATE TABLE TB_STATUS(
TB_STATUS_ID INTEGER primary key NOT NULL auto_increment,
TB_STATUS_NOME varchar(250) NOT NULL
);

CREATE TABLE TB_VENDA_STATUS(
TB_VENDA_STATUS_ID INTEGER primary key NOT NULL auto_increment,
TB_VENDA_STATUS_NOME varchar(250) NOT NULL
);

CREATE TABLE TB_SOLICITACAO_STATUS(
TB_SOLICITACAO_STATUS_ID INTEGER primary key NOT NULL auto_increment,
TB_SOLICITACAO_STATUS_NOME varchar(250) NOT NULL
);

CREATE TABLE TB_REQUISICAO_STATUS(
TB_REQUISICAO_STATUS_ID INTEGER primary key NOT NULL auto_increment,
TB_REQUISICAO_STATUS_NOME varchar(250) NOT NULL
);

CREATE TABLE TB_NIVEL_ACESSO(
TB_NIVEL_ACESSO_ID INTEGER primary key NOT NULL auto_increment,
TB_NIVEL_ACESSO_NOME varchar(120) NOT NULL
);

CREATE TABLE TB_FUNCIONARIO (
TB_FUNCIONARIO_ID INTEGER  primary key NOT NULL auto_increment,
TB_FUNCIONARIO_NOME VARCHAR(120)   NOT NULL ,
TB_FUNCIONARIO_EMAIL VARCHAR(256)   NOT NULL ,
TB_FUNCIONARIO_SENHA CHAR(8)   NOT NULL ,
TB_STATUS_ID INTEGER NOT NULL,
TB_NIVEL_ACESSO_ID INTEGER   NOT NULL 
);
  
  CREATE TABLE TB_FORNECEDOR (
  TB_FORNECEDOR_ID INTEGER primary key NOT NULL auto_increment,
  TB_FORNECEDOR_NOME varchar(120) not null ,
  TB_FORNECEDOR_PRODUTO varchar (120),
  TB_FORNECEDOR_CONTATO VARCHAR(120) NOT NULL,
  TB_FORNECEDOR_OUTRO_CONTATO varchar(120) NULL
  );
  
  CREATE TABLE TB_MATERIA_PRIMA (
  TB_MATERIA_PRIMA_ID integer primary key NOT NULL auto_increment,
  TB_MATERIA_PRIMA_NOMENCLATURA varchar(120),
  TB_MATERIA_PRIMA_LOTE INTEGER NOT NULL,
  TB_MATERIA_PRIMA_DT_VAL DATE NOT NULL,
  TB_MATERIA_PRIMA_QUANTIDADE integer NOT NULL,
  TB_FORNECEDOR_ID INTEGER NOT NULL
  );
  
  CREATE TABLE TB_PRODUTO_MANU(
  TB_PRODUTO_MANU_ID INTEGER NOT NULL primary key auto_increment,
  TB_PRODUTO_MANU_NOME varchar(120) NOT NULL,
  TB_PRODUTO_MANU_DT_FAB date NOT NULL,
  TB_PRODUTO_MANU_DT_VAL DATE NOT NULL,
  TB_PRODUTO_MANU_LOTE integer NOT NULL,
  TB_PRODUTO_MANU_QUANTIDADE integer NOT NULL
  );
  
CREATE TABLE TB_SOLICITACAO(
TB_SOLICITACAO_ID INTEGER NOT NULL primary key auto_increment,
TB_SOLICITACAO_QUANTIDADE integer NOT NULL,
TB_MATERIA_PRIMA_ID INTEGER   NOT NULL,
TB_SOLICITACAO_STATUS_ID INTEGER NOT NULL,
TB_FORNECEDOR_ID INTEGER NOT NULL,
TB_SOLICITACAO_MARCA varchar(280) NOT NULL
);

CREATE TABLE TB_REQUISICAO(
TB_REQUISICAO_ID INTEGER NOT NULL primary key auto_increment,
TB_REQUISICAO_QUANTIDADE integer NOT NULL,
TB_PRODUTO_MANU_ID INTEGER   NOT NULL,
TB_REQUISICAO_STATUS_ID INTEGER NOT NULL
);

CREATE TABLE TB_VENDA (
TB_VENDA_ID INTEGER NOT NULL primary key auto_increment,
TB_VENDA_QUANTIDADE INTEGER NOT NULL,
TB_VENDA_VALOR DOUBLE NOT NULL,
TB_PRODUTO_MANU_ID INTEGER NOT NULL,
TB_FUNCIONARIO_ID INTEGER NOT NULL,
TB_VENDA_STATUS_ID INTEGER NOT NULL
);

CREATE TABLE TB_CLIENTE (
TB_CLIENTE_ID INTEGER NOT NULL primary key auto_increment,
TB_CLIENTE_NOME VARCHAR(120) NOT NULL,
TB_CLIENTE_CONTATO VARCHAR(120) NOT NULL
);

CREATE TABLE TB_MARCA(
TB_MARCA_ID INTEGER NOT NULL primary key auto_increment,
TB_MARCA_NOME varchar(120)
);

-- Adicionando as chaves estrangeiras
alter table TB_FUNCIONARIO
add constraint pk_NIVEL_ACESSO_fk_FUNCIONARIO
foreign key (TB_NIVEL_ACESSO_ID)
references TB_NIVEL_ACESSO(TB_NIVEL_ACESSO_ID);

alter table TB_FUNCIONARIO
add constraint pk_STATUS_fk_FUNCIONARIO
foreign key (TB_STATUS_ID)
references TB_STATUS(TB_STATUS_ID);

alter table TB_MATERIA_PRIMA
add constraint pk_FORNECEDOR_fk_MATERIA_PRIMA
foreign key (TB_FORNECEDOR_ID)
references TB_FORNECEDOR(TB_FORNECEDOR_ID);

alter table TB_VENDA
add constraint pk_FUNCIONARIO_fk_VENDA
foreign key (TB_FUNCIONARIO_ID)
references TB_FUNCIONARIO(TB_FUNCIONARIO_ID);

alter table TB_VENDA
add constraint pk_PRODUTO_MANU_fk_VENDA
foreign key (TB_PRODUTO_MANU_ID)
references TB_PRODUTO_MANU(TB_PRODUTO_MANU_ID);

alter table TB_VENDA
add constraint pk_VENDA_STATUS_fk_VENDA
foreign key (TB_VENDA_STATUS_ID)
references TB_VENDA_STATUS(TB_VENDA_STATUS_ID);

alter table TB_REQUISICAO
add constraint pk_PRODUTO_MANU_fk_REQUISICAO
foreign key (TB_PRODUTO_MANU_ID)
references TB_PRODUTO_MANU(TB_PRODUTO_MANU_ID);

alter table TB_REQUISICAO
add constraint pk_REQUISICAO_STATUS_fk_REQUISICAO
foreign key (TB_REQUISICAO_STATUS_ID)
references TB_REQUISICAO_STATUS(TB_REQUISICAO_STATUS_ID);

alter table TB_SOLICITACAO
add constraint pk_MATERIA_PRIMA_fk_SOLICITACAO
foreign key (TB_MATERIA_PRIMA_ID)
references TB_MATERIA_PRIMA(TB_MATERIA_PRIMA_ID);

alter table TB_SOLICITACAO
add constraint pk_SOLICITACAO_STATUS_fk_SOLICITACAO
foreign key (TB_SOLICITACAO_STATUS_ID)
references TB_SOLICITACAO_STATUS(TB_SOLICITACAO_STATUS_ID);


insert into TB_STATUS values
(default, 'Em operação'),
(default, 'De atestado'),
(default, 'Fora de serviço');

insert into TB_VENDA_STATUS values
(default, 'Efetuada'),
(default, 'Pendente'),
(default, 'Cancelada');

insert into TB_REQUISICAO_STATUS values
(default, 'Efetuada'),
(default, 'Pendente'),
(default, 'Cancelada');

insert into TB_SOLICITACAO_STATUS values
(default, 'Efetuada'),
(default, 'Pendente'),
(default, 'Cancelada');

 SELECT
    s.tb_solicitacao_id AS Id,
    s.tb_solicitacao_quantidade as Quantidade,
    t.tb_solicitacao_status_nome as Status,
    m.TB_MATERIA_PRIMA_NOMENCLATURA AS Nome,
    mp.TB_MARCA_NOME AS Marca,
    f.tb_fornecedor_nome AS Fornecedor
FROM
    tb_solicitacao s
    INNER JOIN TB_MATERIA_PRIMA m ON m.TB_MATERIA_PRIMA_id = s.TB_MATERIA_PRIMA_id
    INNER JOIN tb_fornecedor f ON f.tb_fornecedor_id = s.tb_fornecedor_id    
    INNER JOIN tb_solicitacao_status t ON t.tb_solicitacao_status_id = s.tb_solicitacao_status_id
    INNER JOIN tb_marca mp ON mp.tb_marca_id = s.TB_MARCA_ID;
    
    
    SELECT
                         m.tb_materia_prima_id AS Id,
                         m.tb_materia_prima_nomenclatura AS Nomenclatura,
                         P.tb_marca AS Marca,
                         m.tb_materia_prima_lote AS Lote,
                         m.tb_materia_prima_dt_val AS Data_de_Validade,
                         m.tb_materia_prima_quantidade AS Quantidade,
                         f.tb_fornecedor_nome AS Fornecedor
                        FROM
                         tb_materia_prima m
                         INNER JOIN
                         tb_fornecedor f ON m.tb_fornecedor_id = f.tb_fornecedor_id
                          INNER JOIN
                         tb_marca p ON m.tb_marca_id = p.tb_marca_id
    
