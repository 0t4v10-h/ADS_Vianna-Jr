create database plataformaonline;

use plataformaonline;

CREATE TABLE Usuario (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    email VARCHAR(50) NOT NULL,
    login VARCHAR(20) NOT NULL,
    senha VARCHAR(10) NOT NULL
);

CREATE TABLE Aluno (
    id INT PRIMARY KEY,
    matricula VARCHAR(10) NOT NULL,
    FOREIGN KEY (id) REFERENCES Usuario(id)
);

CREATE TABLE Professor (
    id INT PRIMARY KEY,
    FOREIGN KEY (id) REFERENCES Usuario(id)
);

CREATE TABLE Administrador (
    id INT PRIMARY KEY,
    FOREIGN KEY (id) REFERENCES Usuario(id)
);

CREATE TABLE Curso (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    descricao TEXT NOT NULL,
    professor_id INT,
    FOREIGN KEY (professor_id) REFERENCES Professor(id)
);

CREATE TABLE Material (
    id INT PRIMARY KEY AUTO_INCREMENT,
    curso_id INT,
    titulo VARCHAR(50) NOT NULL,
    conteudo TEXT NOT NULL,
    FOREIGN KEY (curso_id) REFERENCES Curso(id)
);

CREATE TABLE Avaliacao (
    id INT PRIMARY KEY AUTO_INCREMENT,
    professor_id INT,
    aluno_id INT,
    nota INT NOT NULL,
    FOREIGN KEY (professor_id) REFERENCES Professor(id),
    FOREIGN KEY (aluno_id) REFERENCES Aluno(id)
);

CREATE TABLE Curso_Aluno (
    curso_id INT,
    aluno_id INT,
    PRIMARY KEY (curso_id, aluno_id),
    FOREIGN KEY (curso_id) REFERENCES Curso(id),
    FOREIGN KEY (aluno_id) REFERENCES Aluno(id)
);

ALTER TABLE plataformaonline.Usuario MODIFY senha VARCHAR(65);

ALTER TABLE plataformaonline.professor
ADD COLUMN curso_id INT,
ADD CONSTRAINT fk_professor_curso
FOREIGN KEY (curso_id) REFERENCES plataformaonline.curso(id);

ALTER TABLE plataformaonline.curso MODIFY professor_id INT NULL;

SET FOREIGN_KEY_CHECKS = 0;
TRUNCATE TABLE plataformaonline.professor;
TRUNCATE TABLE plataformaonline.usuario;
TRUNCATE TABLE plataformaonline.curso;
TRUNCATE TABLE plataformaonline.aluno;
TRUNCATE TABLE plataformaonline.administrador;
TRUNCATE TABLE plataformaonline.avaliacao;
TRUNCATE TABLE plataformaonline.material;
SET FOREIGN_KEY_CHECKS = 1;

ALTER TABLE plataformaonline.usuario MODIFY COLUMN login VARCHAR(50); 
