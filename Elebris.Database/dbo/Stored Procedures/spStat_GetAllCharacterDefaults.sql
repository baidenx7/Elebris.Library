CREATE PROCEDURE [dbo].[spStat_GetAllCharacterDefaults]
	
AS
 begin
	set nocount on;

	SELECT [StatName],[Value]
	from [dbo].[DefaultCharacterStats]
end
