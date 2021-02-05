CREATE PROCEDURE [dbo].[spUserLookup]
	@Id nvarchar(128)
AS
begin
	set nocount on;

	SELECT Id, DisplayName, EmailAddress, FirstName, LastName, CreatedDate
	from [dbo].[Users]
	where Id = @Id 

end

