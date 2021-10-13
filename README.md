# kontrolni

## CREATE PROCEDURE
USE *Baza*  
GO  
CREATE PROCEDURE *Procedura*  
@*parametar1* *tip1*,  
@*parametar2* *tip2*  
AS  
SELECT *  
FROM *Tabela*  
WHERE *Kolona* = @*parametar1* AND *Kolona2* != @*parametar2*  

## UPDATE
UPDATE *Tabela*  
SET *kolona* = *vrednost*  
WHERE *uslov*  

## INSERT
INSERT INTO *Tabela*(*kolona1*, *kolona2*, *kolona3* ...)  
VALUES(*parametar1*, *parametar2*, *parametar3* ...)  

## DELETE
DELETE FROM *Tabela*  
WHERE *kolona* = *vrednost*  
