USE TestGFT
GO
CREATE PROCEDURE Sp_SaveTrade
	@Value decimal(18,2),
	@ClientSector int,
	@TradeCategory int
AS
BEGIN
	INSERT INTO [Trade] ([Value], [ID_ClientSector], [ID_TradeCategories]) VALUES (@Value, @ClientSector, @TradeCategory)
END
GO


USE TestGFT
GO
CREATE PROCEDURE Sp_SelectTrade
	@IdTrade int
AS
BEGIN
	SELECT * FROM Trade WHERE ID_Trade = @IdTrade
END
GO

EXEC Sp_SaveTrade @Value = 2000000 , @ClientSector = 2, @TradeCategory = 3
EXEC Sp_SaveTrade @Value = 400000, @ClientSector = 1, @TradeCategory = 1
EXEC Sp_SaveTrade @Value = 500000, @ClientSector = 1, @TradeCategory = 1
EXEC Sp_SaveTrade @Value = 3000000, @ClientSector = 1, @TradeCategory = 2

EXEC Sp_SelectTrade @IdTrade = 1
EXEC Sp_SelectTrade @IdTrade = 2
EXEC Sp_SelectTrade @IdTrade = 3
EXEC Sp_SelectTrade @IdTrade = 4
