CREATE PROCEDURE [dbo].[spStat_Update]
	@Id int ,
	@StatName nvarchar(128),
	@BaseValue float,
	@GenericScale float
AS
	begin
	set nocount on;
	update CharacterStats
	set StatName = @StatName, BaseValue = @BaseValue, GenericScale = @GenericScale
	where Id = @Id;

	end