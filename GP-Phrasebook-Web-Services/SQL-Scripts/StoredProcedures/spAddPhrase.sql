CREATE PROCEDURE spAddPhrase @English VarChar(200), @German VarChar(200), @Note VarChar(200), @Category VarChar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO [dbo].[allphrases] (English, German, Note, Category)
	VALUES (@English, @German, @Note, @Category)
END