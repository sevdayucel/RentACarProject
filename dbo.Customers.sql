CREATE TABLE [dbo].Customers
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[UserId] INT,
	CompanyName nvarchar(50),
	FOREIGN KEY (UserId) REFERENCES Users(Id)
)
