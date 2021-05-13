CREATE TABLE [dbo].[DefaultCharacterStats] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [StatName] NVARCHAR (50) NOT NULL,
    [Value]    FLOAT (53)    NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

