CREATE PROCEDURE [dbo].[spStat_GetById]
	@Id int
AS
 begin
	set nocount on;

	SELECT Id, StatName, BaseValue, GenericScale
	from [dbo].[CharacterStats]
	Where Id = @Id;

end

