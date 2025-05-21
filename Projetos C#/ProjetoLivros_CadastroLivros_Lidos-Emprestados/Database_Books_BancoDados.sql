------------------// LIVROS PESSOAIS \\------------------

--VERSÃO 1.0 APLICAÇÃO SQL SERVER--

CREATE DATABASE BookStation;
USE BookStation;

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

CREATE TABLE LeituraLivros (
    Id INT PRIMARY KEY IDENTITY,
    StatusLeitura VARCHAR(20) NOT NULL,
    DataInicioLeitura DATE NOT NULL,
    DataFimLeitura DATE,
	DataEstimativa DATE NOT NULL,
	ResumoLivro VARCHAR(200),
	Anotacao VARCHAR(200),
	Nota INT,
    UsuarioId INT NOT NULL,
    CadastroLivroId INT NOT NULL
);


CREATE TABLE EmprestimoLivro(
	Id INT PRIMARY KEY IDENTITY,
	PessoaEmprestimo VARCHAR(30) NOT NULL,
	ValorEmprestimo DECIMAL(6,2),
	DataEmprestimo DATE NOT NULL,
    DataDevolucao DATE NOT NULL,
	LeituraLivrosId INT NOT NULL
);

CREATE TABLE ArquivosPDF(
	Id INT PRIMARY KEY IDENTITY,
	NomeArquivo VARCHAR(100) NOT NULL,
	ConteudoPDF VARBINARY (MAX) NOT NULL,
	CadastroLivroId INT
);

ALTER TABLE LeituraLivros ADD CONSTRAINT FK_Usuario_LeituraLivros
FOREIGN KEY (UsuarioId) REFERENCES Usuario(Id)

ALTER TABLE LeituraLivros ADD CONSTRAINT FK_CadastroLivro_LeituraLivros
FOREIGN KEY (CadastroLivroId) REFERENCES CadastroLivro(Id)

ALTER TABLE EmprestimoLivro ADD CONSTRAINT FK_LeituraLivros_EmprestimoLivro
FOREIGN KEY (LeituraLivrosId) REFERENCES LeituraLivros(Id)

ALTER TABLE ArquivosPDF ADD CONSTRAINT FK_CadastroLivro_ArquivosPDF
FOREIGN KEY (CadastroLivroId) REFERENCES CadastroLivro(Id)

INSERT INTO Usuario (NomeLogin, NomeLogin, SenhaLogin, Bloqueado) VALUES ('Administrador', 'Admin', '$2a$11$O0OcK8c969MNdWWL5emeF.qr.tirMSUa/T.f1g08Kk21RRNx33Mha', 0)