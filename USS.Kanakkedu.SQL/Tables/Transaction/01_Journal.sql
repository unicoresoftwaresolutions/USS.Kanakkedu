CREATE TABLE [dbo].[Journal]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [JournalTypeId] UNIQUEIDENTIFIER NULL, 
    [EntryNo] NVARCHAR(50) NULL, 
    [Date] DATE NOT NULL, 
    [Amount] MONEY NOT NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    [RefNo] NVARCHAR(50) NULL,
    Constraint [FK_Journal_JournalType] Foreign Key ([JournalTypeId]) References [JournalType]([Id])
)
