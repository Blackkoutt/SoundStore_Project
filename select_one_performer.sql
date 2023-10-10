CREATE PROCEDURE performer_select_one
	@Id INT
AS
BEGIN 
	SELECT Id, Name 
	FROM Performers
	WHERE Id = @Id
END