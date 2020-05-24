USE MealOrder
GO

IF OBJECT_ID('GetItensRefeicao') IS NOT NULL
	DROP PROCEDURE GetItensRefeicao
GO


CREATE PROCEDURE GetItensRefeicao (@IdTipoRefeicao BIGINT) AS 

BEGIN 

	SELECT		Id, IdTipoRefeicao, IdProduto, Valor
	FROM		ItemRefeicao
	WHERE		IdTipoRefeicao = @IdTipoRefeicao

END;