CREATE TABLE [dbo].[JournalDetail]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [JournalId] UNIQUEIDENTIFIER NOT NULL,
	[RefId] UNIQUEIDENTIFIER,
	[LedgerId] UNIQUEIDENTIFIER NOT NULL, 
    [DrAmt] MONEY NOT NULL, 
    [CrAmt] MONEY NOT NULL, 
    [Descrption] NVARCHAR(MAX) NULL, 
    Constraint [FK_JournalDetail_Journal] Foreign Key([JournalId]) References [Journal]([Id]),
    Constraint [FK_JournalDetail_Ledger] Foreign Key(LedgerId) References [Ledger]([Id])
)
