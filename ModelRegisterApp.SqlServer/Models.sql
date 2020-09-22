CREATE TABLE [dbo].[Models]
(
	[ModelCode] INT NOT NULL PRIMARY KEY Identity(1, 1),
    [PartID] NVARCHAR(50) NOT NULL, 
    [ModelName] NVARCHAR(50) NOT NULL, 
)
