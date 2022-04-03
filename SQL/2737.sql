/*
Problem: Advogados
URI Online Judge | 2737
Solution developed by: Alberto Kato
*/

SELECT name, customers_number FROM lawyers
WHERE customers_number = (SELECT MAX(customers_number) FROM lawyers)
UNION ALL
SELECT name, customers_number FROM lawyers
WHERE customers_number = (SELECT MIN(customers_number) FROM lawyers)
UNION ALL
SELECT 'Average', ROUND(AVG(customers_number),0)  AS customers_number FROM lawyers


