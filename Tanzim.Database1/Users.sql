CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1),
	[email] varchar(50) NOT NULL UNIQUE,
	[name] varchar(50) NOT NULL,
	[Surname] varchar(50) NOT NULL,
	[Password] varchar(50) NOT NULL

) 
