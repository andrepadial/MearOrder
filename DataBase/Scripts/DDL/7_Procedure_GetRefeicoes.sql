USE MealOrder
GO

IF OBJECT_ID('GetRefeicoes') IS NOT NULL
	DROP PROCEDURE GetRefeicoes
GO


CREATE PROCEDURE GetRefeicoes AS 

BEGIN 

	SELECT		Id, IdItemRefeicao, Nome, Descricao
	FROM		Refeicao

END;