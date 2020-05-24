USE MealOrder
GO

IF OBJECT_ID('GetProduto') IS NOT NULL
	DROP PROCEDURE GetProduto
GO


CREATE PROCEDURE GetProduto (@Id BIGINT) AS 

BEGIN 

	SELECT		Id, Nome, Descricao, DataInclusao, DataAlteracao, ValorCompra 
	FROM		Produto
	WHERE		Id = @Id

END;