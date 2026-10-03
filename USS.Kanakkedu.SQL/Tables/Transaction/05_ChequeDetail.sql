CREATE TABLE [dbo].[ChequeDetail]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [No] VARCHAR(500) NULL, 
    [Date] DATE NULL, 
    [ClearedAt] DATE NULL
)
