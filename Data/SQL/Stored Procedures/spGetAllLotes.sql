CREATE OR ALTER PROCEDURE spGetAllLotes
    @PageNumber INT,
    @PageSize INT
AS
    SELECT * FROM Lote
    ORDER BY LoteID
    OFFSET (@PageNumber - 1) * @PageSize ROWS
    FETCH NEXT @PageSize ROWS ONLY
GO
