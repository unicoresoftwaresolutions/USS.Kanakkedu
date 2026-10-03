CREATE TABLE [dbo].[Receipt]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	[JournalId] UNIQUEIDENTIFIER not null,
    [TransactionTypeId] UNIQUEIDENTIFIER,
    [TransactionDetailId] UNIQUEIDENTIFIER NULL, 
    Constraint [FK_Receipt_JournalDetail] Foreign Key ([JournalId]) References [Journal]([Id]),
    Constraint [FK_Receipt_TransactionType] Foreign Key ([TransactionTypeId]) References [TransactionType]([Id])
)
