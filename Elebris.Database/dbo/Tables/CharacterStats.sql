CREATE TABLE [dbo].[CharacterStats]
(
--Create a stat which has a base value, and value per level
	[Id] INT NOT NULL PRIMARY KEY Identity, 
    [StatName] NVARCHAR(50) NOT NULL, 
    [BaseValue] FLOAT NOT NULL 
)
