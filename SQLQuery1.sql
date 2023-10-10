CREATE PROCEDURE add_performer
    @Id INT,
    @Name NVARCHAR(100)
AS
BEGIN
    INSERT INTO Performers (Id, Name)
    VALUES (@Id, @Name)
END
GO
EXEC add_performer