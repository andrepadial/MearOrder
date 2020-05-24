USE MealOrder
GO

DELETE FROM dbo.Refeicao;
DELETE FROM dbo.ItemRefeicao;
DELETE FROM dbo.TipoRefeicao;
DELETE FROM dbo.Estoque;
DELETE FROM dbo.Produto;


INSERT INTO dbo.Produto
SELECT 'Hamburguer', 'Hamburguer de carne', GETDATE(), GETDATE(), 5.00 UNION ALL
SELECT 'Alface', 'Alface', GETDATE(), GETDATE(), 1.00 UNION ALL
SELECT 'Bacon', 'Bacon', GETDATE(), GETDATE(), 1.00 UNION ALL
SELECT 'Ovo', 'Ovo', GETDATE(), GETDATE(), 1.00 UNION ALL
SELECT 'Queijo', 'Queijo', GETDATE(), GETDATE(), 2.00 


INSERT INTO dbo.Estoque
SELECT P.Id, 10, GETDATE(), USER_NAME(), NULL, NULL
FROM (SELECT Id FROM dbo.Produto WHERE Nome = 'Hamburguer') AS P UNION ALL

SELECT P.Id, 10, GETDATE(), USER_NAME(), NULL, NULL
FROM (SELECT Id FROM dbo.Produto WHERE Nome = 'Alface') AS P UNION ALL

SELECT P.Id, 10, GETDATE(), USER_NAME(), NULL, NULL
FROM (SELECT Id FROM dbo.Produto WHERE Nome = 'Bacon') AS P UNION ALL

SELECT P.Id, 10, GETDATE(), USER_NAME(), NULL, NULL
FROM (SELECT Id FROM dbo.Produto WHERE Nome = 'Queijo') AS P UNION ALL

SELECT P.Id, 10, GETDATE(), USER_NAME(), NULL, NULL
FROM (SELECT Id FROM dbo.Produto WHERE Nome = 'Ovo') AS P 



INSERT INTO dbo.TipoRefeicao
SELECT 'Hamburguer', 'Menu de Hamburgueres' UNION ALL
SELECT 'Pizza', 'Menu de Pizzas' UNION ALL
SELECT 'La Carte', 'Menu a la carte' UNION ALL
SELECT 'Self Service', 'Menu self service'


INSERT	INTO dbo.ItemRefeicao
SELECT	TIPO.Id, PRODUTO.Id, PRODUTO.ValorCompra * 1.8
FROM	(SELECT Id FROM dbo.TipoRefeicao WHERE Nome = 'Hamburguer') AS TIPO,
		(SELECT Id, ValorCompra FROM dbo.Produto) AS PRODUTO



INSERT	INTO dbo.Refeicao
SELECT	REF.Id, ITENS.IdItemRefeicao, 'X-Bacon', 'Hamburguer de carne + Queijo + Bacon'
FROM (	SELECT	I.Id AS IdItemRefeicao, P.Id, P.Nome, P.ValorCompra, I.Valor AS ValorVenda
		FROM	ItemRefeicao I INNER JOIN Produto P ON I.IdProduto = P.Id
		INNER JOIN dbo.TipoRefeicao TR ON I.IdTipoRefeicao = TR.Id
		WHERE	TR.Nome = 'Hamburguer'	
	 ) AS ITENS,
	 (SELECT (ISNULL(MAX(Id), 0) + 1) AS Id FROM dbo.Refeicao) AS REF
WHERE ITENS.Nome IN ('Hamburguer', 'Queijo', 'Bacon')


INSERT	INTO dbo.Refeicao
SELECT	REF.Id, ITENS.IdItemRefeicao, 'X-Burguer', 'Hamburguer de carne + Queijo'
FROM (	SELECT	I.Id AS IdItemRefeicao, P.Id, P.Nome, P.ValorCompra, I.Valor AS ValorVenda
		FROM	ItemRefeicao I INNER JOIN Produto P ON I.IdProduto = P.Id
		INNER JOIN dbo.TipoRefeicao TR ON I.IdTipoRefeicao = TR.Id
		WHERE	TR.Nome = 'Hamburguer'	
	 ) AS ITENS,
	 (SELECT (ISNULL(MAX(Id), 0) + 1) AS Id FROM dbo.Refeicao) AS REF
WHERE ITENS.Nome IN ('Hamburguer', 'Queijo')


INSERT	INTO dbo.Refeicao
SELECT	REF.Id, ITENS.IdItemRefeicao, 'X-Egg', 'Hamburguer de carne + Queijo + Ovo'
FROM (	SELECT	I.Id AS IdItemRefeicao, P.Id, P.Nome, P.ValorCompra, I.Valor AS ValorVenda
		FROM	ItemRefeicao I INNER JOIN Produto P ON I.IdProduto = P.Id
		INNER JOIN dbo.TipoRefeicao TR ON I.IdTipoRefeicao = TR.Id
		WHERE	TR.Nome = 'Hamburguer'	
	 ) AS ITENS,
	 (SELECT (ISNULL(MAX(Id), 0) + 1) AS Id FROM dbo.Refeicao) AS REF
WHERE ITENS.Nome IN ('Hamburguer', 'Queijo', 'Ovo')


INSERT	INTO dbo.Refeicao
SELECT	REF.Id, ITENS.IdItemRefeicao, 'X-Egg Bacon', 'Hamburguer de carne + Queijo + Ovo + Bacon'
FROM (	SELECT	I.Id AS IdItemRefeicao, P.Id, P.Nome, P.ValorCompra, I.Valor AS ValorVenda
		FROM	ItemRefeicao I INNER JOIN Produto P ON I.IdProduto = P.Id
		INNER JOIN dbo.TipoRefeicao TR ON I.IdTipoRefeicao = TR.Id
		WHERE	TR.Nome = 'Hamburguer'	
	 ) AS ITENS,
	 (SELECT (ISNULL(MAX(Id), 0) + 1) AS Id FROM dbo.Refeicao) AS REF
WHERE ITENS.Nome IN ('Hamburguer', 'Queijo', 'Ovo', 'Bacon')





