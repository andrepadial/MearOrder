USE MealOrder
GO

IF OBJECT_ID('GetTipoRefeicoes') IS NOT NULL
	DROP PROCEDURE GetTipoRefeicoes
GO


CREATE PROCEDURE GetTipoRefeicoes AS 

BEGIN 

	SELECT		Id, Nome, Descricao
	FROM		TipoRefeicao

END;