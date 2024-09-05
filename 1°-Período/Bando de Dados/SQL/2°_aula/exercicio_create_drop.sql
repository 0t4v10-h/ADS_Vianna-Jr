create database empresa;
use empresa;

CREATE TABLE empregado (
    codigo_empregado DECIMAL(6),
    noma VARCHAR(50), 
    codigo_cargo DECIMAL(5),
    endereco VARCHAR(50),
    bairro VARCHAR(20),
    cidade VARCHAR(20),
    codigo_chefe DECIMAL(6),
    UF CHAR(2),
    data_nasc DATE,
    sexo CHAR(1),
    filiacao VARCHAR(60),
    salario DECIMAL(10 , 2 )
);
desc empregado;

CREATE TABLE cargo (
    codigo_cargo DECIMAL(3),
    descricao_cargo VARCHAR(20),
    salario_min NUMERIC(7 , 2 ),
    salario_max NUMERIC(8 , 2 ),
    nivel_graduacao CHAR(1)
);
desc cargo;

CREATE TABLE dependente (
    codigo_empregado DECIMAL(6),
    nome_dependente VARCHAR(50),
    sexo CHAR(1),
    data_nasc DATE,
    parentesco VARCHAR(15)
);
desc dependente;

CREATE TABLE departamento (
    codigo_dep DECIMAL(3),
    nome_dep VARCHAR(30),
    codigo_gerente DECIMAL(6),
    data_inicio_gerente DATE,
    data_criacao DATE
);
desc departamento;


