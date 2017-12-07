CREATE TABLE [dbo].[People]
(
	[Person_Id] INT NOT NULL PRIMARY KEY, 
    [First_Name] VARCHAR(50) NOT NULL, 
    [Last_Name] NCHAR(50) NOT NULL, 
    [Email_Address] VARCHAR(50) NOT NULL, 
    [Phone_Number] INT NOT NULL, 
    [Numberof_Kids] INT NOT NULL DEFAULT 0, 
    [Create_Date] TIMESTAMP NOT NULL
)
