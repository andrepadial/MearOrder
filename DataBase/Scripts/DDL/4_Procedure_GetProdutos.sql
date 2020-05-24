USE MealOrder
GO

IF OBJECT_ID('GetProdutos') IS NOT NULL
	DROP PROCEDURE GetProdutos
GO


CREATE PROCEDURE GetProdutos (@Id BIGINT) AS 

BEGIN 

	SELECT		Id, Nome, Descricao, DataInclusao, DataAlteracao, ValorCompra 
	FROM		Produto

END;