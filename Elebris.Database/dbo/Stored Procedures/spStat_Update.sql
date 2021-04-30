CREATE PROCEDURE [dbo].[spStat_Update]
	@Id int ,
	@StatName nvarchar(128),
	@BaseValue float
AS
	begin
	set nocount on;
	update CharacterStats
	set StatName = @StatName, BaseValue = @BaseValue
	where Id = @Id;

	end