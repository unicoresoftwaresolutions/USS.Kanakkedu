CREATE TABLE [dbo].[Payment]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [JournalId] UNIQUEIDENTIFIER not null,
    [TransactionTypeId] UNIQUEIDENTIFIER,
    [TransactionDetailId] UNIQUEIDENTIFIER NULL, 
    Constraint [FK_Payment_JournalDetail] Foreign Key ([JournalId]) References [Journal]([Id]),
    Constraint [FK_Payment_TransactionType] Foreign Key ([TransactionTypeId]) References [TransactionType]([Id])
)
