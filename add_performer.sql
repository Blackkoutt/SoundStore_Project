CREATE PROCEDURE performer_add
    @Name NVARCHAR(100)
AS
BEGIN
    INSERT INTO Performers (Name)
    VALUES (@Name)
END