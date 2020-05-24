USE MealOrder
GO

IF OBJECT_ID('IncluirPedido') IS NOT NULL
	DROP PROCEDURE IncluirPedido
GO


CREATE PROCEDURE IncluirPedido (@IdRefeicao BIGINT, @DataPedido DATETIME, @Valor NUMERIC(19, 2), @ValorPago NUMERIC(19,2)) AS 

BEGIN 

	INSERT	INTO Pedido
	SELECT	@IdRefeicao, @DataPedido, @Valor, @ValorPago

END;