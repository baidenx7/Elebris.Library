﻿CREATE TABLE [dbo].[ValueTypes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [DefaultValue] FLOAT NOT NULL 
)
