﻿CREATE TABLE [dbo].Users
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[FirstName] NVARCHAR(50), 
	[LastName] NVARCHAR(50),
	[Email] NVARCHAR(50),
	[Password] NVARCHAR(50)
)
