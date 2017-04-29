--1)
/*SELECT * FROM Productos
ORDER BY Tamaño ASC */

--2)
/*SELECT * FROM Proveedores
WHERE Localidad = 'Capital'*/

--3)
/*SELECT * FROM Envios
WHERE Cantidad BETWEEN 200 AND 300*/

--4)
--SELECT SUM(Cantidad) AS 'Cantidad Total' FROM Envios

--5)
--SELECT AVG(Precio) AS Promedio	FROM Productos

--6)
/*SELECT (t1.Precio*t2.Cantidad) AS 'Precio Total'
FROM Productos AS t1
INNER JOIN Envios AS t2
ON t1.pNumero = t2.pNumero*/

--7)
/*SELECT Cantidad 
FROM Envios
WHERE pNumero = 1 AND Numero = 102*/

--8)
/*SELECT pNumero
FROM Envios AS E
INNER JOIN Proveedores AS P
ON P.Numero = E.Numero WHERE P.Localidad = 'Avellaneda'*/

--9)
/*SELECT Domicilio,Localidad
FROM Proveedores
WHERE Nombre LIKE '%i%'*/

--10)
/*INSERT INTO Productos(pNumero,pNombre,Precio,Tamaño)
VALUES(4,'Chocolate',0.35,'Chico')*/

--11)
/*INSERT INTO Proveedores(Numero,Nombre)
VALUES(103,'Joako')*/

--12)
/*INSERT INTO Proveedores(Numero,Nombre,Localidad)
VALUES(107,'Rosales','La Plata')*/

--13)
/*UPDATE Productos
SET Precio = 7.5
WHERE Tamaño = 'Grande'*/

--14)
UPDATE Productos
SET Productos.Tamaño = 'Mediano'
FROM Productos
INNER JOIN Envios
ON Productos.pNumero = Envios.pNumero
WHERE Envios.Cantidad >= 300 AND Productos.Tamaño = 'Chico'

--15)
DELETE Productos
WHERE Productos.pNumero = 1

--16)
DELETE Proveedores 
/*FROM Proveedores
INNER JOIN Envios
ON NOT Proveedores.Numero = Envios.Numero*/
WHERE NOT Proveedores.Numero = Envios.Numero

SELECT * FROM Proveedores
SELECT * FROM Envios
