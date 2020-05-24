USE MealOrder
GO

IF OBJECT_ID('GetEstoque') IS NOT NULL
	DROP PROCEDURE GetEstoque
GO


CREATE PROCEDURE GetEstoque (@IdProduto BIGINT) AS 

BEGIN 

	SELECT		Id, Quantidade, DataInclusao, UsuarioInclusao, DataBaixa, UsuarioBaixa
	FROM		dbo.Estoque
	WHERE		IdProduto = @IdProduto

END;