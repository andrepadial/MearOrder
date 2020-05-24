USE MealOrder
GO


IF OBJECT_ID('dbo.Pedido') IS NOT NULL
	DROP TABLE dbo.Pedido
GO

IF OBJECT_ID('dbo.Refeicao') IS NOT NULL
	DROP TABLE dbo.Refeicao
GO


IF OBJECT_ID('dbo.ItemRefeicao') IS NOT NULL
	DROP TABLE dbo.ItemRefeicao
GO


IF OBJECT_ID('dbo.TipoRefeicao') IS NOT NULL
	DROP TABLE dbo.TipoRefeicao
GO

IF OBJECT_ID('dbo.Estoque') IS NOT NULL
	DROP TABLE dbo.Estoque
GO

IF OBJECT_ID('dbo.Produto') IS NOT NULL
	DROP TABLE dbo.Produto
GO


CREATE TABLE dbo.Produto (
    Id BIGINT IDENTITY(1,1) PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Descricao VARCHAR(255) NOT NULL,
    DataInclusao DATETIME NOT NULL,
	DataAlteracao DATETIME NOT NULL,
	ValorCompra NUMERIC(19, 2)

);

GO


CREATE TABLE dbo.Estoque (
    Id BIGINT IDENTITY(1,1) PRIMARY KEY,
    IdProduto BIGINT,
	Quantidade INT,
	DataInclusao DATETIME,
	UsuarioInclusao VARCHAR(50),
	DataBaixa DATETIME,
	UsuarioBaixa VARCHAR(50)

);

ALTER TABLE dbo.Estoque
ADD CONSTRAINT FK_Estoque_Produto FOREIGN KEY (IdProduto) REFERENCES Produto(Id);

GO


CREATE TABLE dbo.TipoRefeicao (
    Id BIGINT IDENTITY(1,1) PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Descricao VARCHAR(255) NOT NULL  

);

GO


CREATE TABLE dbo.ItemRefeicao (
    Id BIGINT IDENTITY(1,1) PRIMARY KEY,
	IdTipoRefeicao BIGINT NOT NULL,
    IdProduto BIGINT NOT NULL,
	Valor NUMERIC(19,2)

);

ALTER TABLE dbo.ItemRefeicao
ADD CONSTRAINT FK_Tipo_Refeicao FOREIGN KEY (IdTipoRefeicao) REFERENCES TipoRefeicao(Id);

ALTER TABLE dbo.ItemRefeicao
ADD CONSTRAINT FK_Tipo_Refeicao_Produto FOREIGN KEY (IdProduto) REFERENCES Produto(Id);

GO


CREATE TABLE dbo.Refeicao (
    Id BIGINT NOT NULL,
	IdItemRefeicao BIGINT NOT NULL,
	Nome VARCHAR(50),
	Descricao VARCHAR(500)

);

ALTER TABLE dbo.Refeicao
ADD CONSTRAINT PK_Refeicao PRIMARY KEY (ID,IdItemRefeicao);

ALTER TABLE dbo.Refeicao
ADD CONSTRAINT FK_Refeicao_ItemRefeicao FOREIGN KEY (IdItemRefeicao) REFERENCES ItemRefeicao(Id);

GO


CREATE TABLE dbo.Pedido (
    Id BIGINT IDENTITY(1,1) PRIMARY KEY,
	IdRefeicao BIGINT NOT NULL,
	DataPedido DATETIME,
	Valor NUMERIC(19,2),
	ValorPago NUMERIC(19,2)

);


