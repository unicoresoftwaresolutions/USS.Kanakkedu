CREATE TABLE [dbo].[LedgerBalance]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [LedgerId] INT NOT NULL, 
    [ACYearId] INT NOT NULL, 
    [DrAmt] MONEY NOT NULL, 
    [CrAmt] MONEY NOT NULL,
    CONSTRAINT [FK_LedgerBalance_ACYear] FOREIGN KEY ([ACYearId]) REFERENCES [ACYear]([Id]),
    CONSTRAINT [FK_LedgerBalance_Ledger] FOREIGN KEY ([LedgerId]) REFERENCES [Ledger]([Id])
)
