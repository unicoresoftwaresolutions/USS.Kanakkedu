CREATE TABLE [dbo].[Receipt]
(
	[Id] INT NOT NULL PRIMARY KEY Identity,
	[JournalId] int not null,
    [TransactionTypeId] int,
    [TransactionDetailId] INT NULL, 
    Constraint [FK_Receipt_JournalDetail] Foreign Key ([JournalId]) References [Journal]([Id]),
    Constraint [FK_Receipt_TransactionType] Foreign Key ([TransactionTypeId]) References [TransactionType]([Id])
)
