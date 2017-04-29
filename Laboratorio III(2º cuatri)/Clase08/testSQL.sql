
--SELECCION
SELECT [CAMPO1, CAMPO2]
FROM [TABLA]


SELECT id AS 'El primer campo', descripcion, tipo AS TipoProducto
FROM MiTabla
WHERE id > 99 AND/*OR*/ tipo <> null
ORDER BY descripcion DESC



SELECT t1.id AS IdProveedor, descripcion AS Descrip, t2.descripcionTabla AS Pais
FROM 
MiTabla t1
INNER JOIN	OtraTabla AS t2
ON t1.tipo =




order by id DESC
 


WHERE tipo BETWEEN 5 AND 99

tipo > 5 AND tipo < 99

descripcion LIKE '% %'



--INSERTAR

INSERT INTO MiTabla
(descripcion)
VALUES('MAS INFO')

--MODIFICAR
UPDATE [TABLA]
SET CAMPO = VALOR


UPDATE MiTabla
SET tipo = 88, descripcion = 'otra descripcion'
WHERE id = 97

--ELIMINAR

DELETE [TABLA]
WHERE [CONDICION]

