CREATE TABLE [dbo].[ACYear]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Code] NVARCHAR(20) NOT NULL, 
    [StartDate] DATE NOT NULL, 
    [EndDate] DATE NOT NULL, 
    [YearEndClosed] BIT NOT NULL, 
    [FundId] INT NOT NULL, 
    CONSTRAINT [FK_ACYear_Fund] FOREIGN KEY ([FundId]) REFERENCES [Fund]([Id])
)
