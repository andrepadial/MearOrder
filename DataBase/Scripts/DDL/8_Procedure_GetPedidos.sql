USE MealOrder
GO

IF OBJECT_ID('GetPedidos') IS NOT NULL
	DROP PROCEDURE GetPedidos
GO


CREATE PROCEDURE GetPedidos (@DataInicial DATETIME, @DataFinal DATETIME) AS 

BEGIN 

	SELECT		Id, IdRefeicao, DataPedido, Valor, ValorPago
	FROM		Pedido
	WHERE		DataPedido BETWEEN @DataInicial AND @DataFinal

END;