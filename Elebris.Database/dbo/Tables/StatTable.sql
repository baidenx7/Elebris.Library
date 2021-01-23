CREATE TABLE [dbo].[StatTable]
(
	[Id] INT NOT NULL PRIMARY KEY Identity, 
    [StatName] NVARCHAR(50) NOT NULL, 
    [GoverningAttributeId] INT NOT NULL, 
    [BaseValue] FLOAT NOT NULL, 
    [GenericScale] FLOAT NULL DEFAULT 0, 
    [BaseFromAttribute] FLOAT NULL DEFAULT 0, 
    [AttributeScale] FLOAT NULL DEFAULT 0
)
