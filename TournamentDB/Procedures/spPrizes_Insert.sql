CREATE PROCEDURE [dbo].[spPrizes_Insert]
@Place_Number int,
@Place_Name nvarchar(50),
@Prize_Amount money,
@Prize_Percentage float,
@Prize_Id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;
	
	insert into dbo.Prizes (Place_Name, Prize_Amount, Prize_Percentage)
	values (@Place_Number, @Place_Name, @Prize_Amount, @Prize_Percentage);

	select @Prize_Id = SCOPE_IDENTITY();

END
GO
