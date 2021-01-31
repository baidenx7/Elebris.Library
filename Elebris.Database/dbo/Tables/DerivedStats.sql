CREATE TABLE [dbo].[DerivedStatTable]
(
--Based on the value of the obtained parent, inject scaling for the target
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [ParentStatId] INT NOT NULL, 
    [TargetStatId] INT NOT NULL, 
    [BaseFromParent] FLOAT NOT NULL DEFAULT 0, 
    [ScaleFromParent] FLOAT NOT NULL DEFAULT 0
)
