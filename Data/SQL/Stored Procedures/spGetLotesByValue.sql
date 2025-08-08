CREATE OR ALTER PROCEDURE spGetLotesByValue
    @Value VARCHAR(50),
    @PageNumber INT,
    @PageSize INT
AS
BEGIN
    SELECT * FROM Lote
    WHERE LoteID LIKE '%' + @Value + '%'
        OR FincaID LIKE '%' + @Value + '%'
    ORDER BY LoteID
    OFFSET (@PageNumber - 1) * @PageSize ROWS
    FETCH NEXT @PageSize ROWS ONLY
END