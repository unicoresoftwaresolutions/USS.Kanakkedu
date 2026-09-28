CREATE TABLE [dbo].[Fund]
(
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[IsActive] [bit] NOT NULL, 
    CONSTRAINT [PK_Fund] PRIMARY KEY ([Id]),
)
