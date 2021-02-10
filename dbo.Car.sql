CREATE TABLE [dbo].[Car]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [CarName] NVARCHAR(30) NULL, 
    [BrandId] INT NULL , 
    [ColorId] INT NULL, 
    [DailyPrice] DECIMAL NULL, 
    [ModelYear] INT NULL, 
    [Description] NVARCHAR(50) NULL
	FOREIGN KEY (BrandId) REFERENCES Color(ColorId),
    FOREIGN KEY (ColorId) REFERENCES Brand(BrandId)
)
