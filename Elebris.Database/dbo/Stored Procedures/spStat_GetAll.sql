CREATE PROCEDURE [dbo].[spStat_GetAll]
	
AS
 begin
	set nocount on;

	SELECT Id, StatName, BaseValue, GenericScale
	from [dbo].[CharacterStats]
	order by Id;

end

