CREATE TABLE [dbo].[JournalDetail]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [JournalId] INT NOT NULL,
	[RefId] int,
	[LedgerId] INT NOT NULL, 
    [DrAmt] MONEY NOT NULL, 
    [CrAmt] MONEY NOT NULL, 
    [Descrption] NVARCHAR(MAX) NULL, 
    Constraint [FK_JournalDetail_Journal] Foreign Key([JournalId]) References [Journal]([Id]),
    Constraint [FK_JournalDetail_Ledger] Foreign Key(LedgerId) References [Ledger]([Id])
)
