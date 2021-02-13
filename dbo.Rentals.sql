CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [CarId] INT NULL, 
    [CustomerId] INT NULL,
	[RentDate] datetime,
	[ReturnDate] datetime,
	FOREIGN KEY (CarId) REFERENCES Car(Id),
	FOREIGN KEY (CustomerId) REFERENCES Customers(Id)
)
