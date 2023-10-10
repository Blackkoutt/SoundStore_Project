CREATE PROCEDURE performer_delete
    @Id INT 
AS
BEGIN
    DELETE Performers WHERE Id = @Id
END