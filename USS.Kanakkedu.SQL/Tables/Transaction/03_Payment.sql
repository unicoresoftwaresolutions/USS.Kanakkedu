CREATE TABLE [dbo].[Payment]
(
	[Id] INT NOT NULL PRIMARY KEY Identity, 
    [JournalId] int not null,
    [TransactionTypeId] int,
    [TransactionDetailId] INT NULL, 
    Constraint [FK_Payment_JournalDetail] Foreign Key ([JournalId]) References [Journal]([Id]),
    Constraint [FK_Payment_TransactionType] Foreign Key ([TransactionTypeId]) References [TransactionType]([Id])
)
