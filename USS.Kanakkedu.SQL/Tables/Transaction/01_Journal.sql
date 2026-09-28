CREATE TABLE [dbo].[Journal]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [JournalTypeId] INT NULL, 
    [EntryNo] NVARCHAR(50) NULL, 
    [Date] DATE NOT NULL, 
    [Amount] MONEY NOT NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    [RefNo] NVARCHAR(50) NULL,
    Constraint [FK_Journal_JournalType] Foreign Key ([JournalTypeId]) References [JournalType]([Id])
)
