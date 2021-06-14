CREATE TABLE [dbo].[StudentToSubject]
(
	[Id] INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
	[StudentId] int NOT NULL,
	[SubjectId] int NOT NULL
)
