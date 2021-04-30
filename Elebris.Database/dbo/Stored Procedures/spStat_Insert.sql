CREATE PROCEDURE [dbo].[spStat_Insert]
	@Id int output,
	@StatName nvarchar(128),
	@BaseValue float,
	@GenericScale float
AS
	begin
	set nocount on;
	insert into dbo.CharacterStats(StatName, BaseValue)
	values(@StatName, @BaseValue, @GenericScale);

	select @Id = @@IDENTITY;
	end