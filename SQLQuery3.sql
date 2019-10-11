CREATE TABLE [dbo].[Location]
([Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
[Store] nvarchar(MAX) NOT NULL,
[Address] nvarchar(MAX) NOT NULL, 
[Latitude] Numeric(10,8) NOT NULL,
[Longitude] Numeric(11,8) NOT NULL,
CONSTRAINT CK_Latitude CHECK (Latitude >=-90 AND Latitude <=90),
CONSTRAINT CK_Longitude CHECK (Longitude >=-190 AND Longitude <=180)
)
INSERT INTO [dbo].[Location] ([Store], [Address], [Latitude],
[Longitude]) VALUES (N'Hungry Souls', N'123 Hungry Street', CAST(-
37.87682300 AS Decimal(10, 8)), CAST(145.04583700 AS Decimal(11, 8)))