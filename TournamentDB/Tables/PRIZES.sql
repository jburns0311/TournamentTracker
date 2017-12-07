CREATE TABLE [dbo].[Prizes]
(
	[Prize_Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [Place_Number] INT NOT NULL, 
    [Place_Name] NVARCHAR(50) NOT NULL, 
    [Prize_Amount] INT NOT NULL, 
    [Prize_Percentage] FLOAT NOT NULL
);


