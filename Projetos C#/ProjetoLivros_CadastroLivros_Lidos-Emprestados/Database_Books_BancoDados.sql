------------------// LIVROS PESSOAIS \\------------------

--VERSÃO 1.0 APLICAÇÃO SQL SERVER--

CREATE DATABASE BookStation;
GO

USE BookStation;
GO

CREATE TABLE CadastroLivro (
    Id INT PRIMARY KEY IDENTITY,
    NomeLivro VARCHAR(30) NOT NULL,
    GeneroLivro VARCHAR(30) NOT NULL,
    NPaginas INT NOT NULL,
	Formato CHAR(15) NOT NULL,
	NomeSequencia VARCHAR(30),
    NSequencia INT,		
	Autor VARCHAR(30),
	Valor DECIMAL(6,2)
);
GO

CREATE TABLE Usuario (
    Id INT PRIMARY KEY IDENTITY,
    NomeUsuario VARCHAR(30) NOT NULL,
    NomeLogin VARCHAR(15) NOT NULL UNIQUE,
    SenhaLogin VARCHAR(12) NOT NULL UNIQUE,
    Bloqueado BIT,
    PerguntaCidade VARCHAR(20),
    PerguntaObjeto VARCHAR(20),
    PerguntaCachorro VARCHAR(20)	
);
GO

CREATE TABLE LeituraLivros (
    Id INT PRIMARY KEY IDENTITY,
    StatusLeitura VARCHAR(20) NOT NULL,
    DataInicioLeitura DATETIME NOT NULL,
    DataFimLeitura DATETIME,
	DataEstimativa DATETIME NOT NULL,
	ResumoLivro VARCHAR(200),
	Anotacao VARCHAR(200),
	Nota INT,
    UsuarioId INT NOT NULL,
    CadastroLivroId INT NOT NULL
);
GO

CREATE TABLE EmprestimoLivro(
	Id INT PRIMARY KEY IDENTITY,
	PessoaEmprestimo VARCHAR(30) NOT NULL,
	ValorEmprestimo DECIMAL(6,2),
	DataEmprestimo DATETIME NOT NULL,
    DataDevolucao DATETIME NOT NULL,
	LeituraLivrosId INT NOT NULL
);
GO

ALTER TABLE LeituraLivros ADD CONSTRAINT FK_Usuario_LeituraLivros
FOREIGN KEY (UsuarioId) REFERENCES Usuario(Id)
GO

ALTER TABLE LeituraLivros ADD CONSTRAINT FK_CadastroLivro_LeituraLivros
FOREIGN KEY (CadastroLivroId) REFERENCES CadastroLivro(Id)
GO

ALTER TABLE EmprestimoLivro ADD CONSTRAINT FK_LeituraLivros_EmprestimoLivro
FOREIGN KEY (LeituraLivrosId) REFERENCES LeituraLivros(Id)
GO

INSERT INTO Usuario (NomeLogin, NomeLogin, SenhaLogin, Bloqueado) VALUES ('Administrador', 'Admin', 'admin@123', 0)
GO