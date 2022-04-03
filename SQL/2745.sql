/*
Problem: Taxas
URI Online Judge | 2745
Solution developed by: Alberto Kato
*/

SELECT
name,
to_char(ROUND((salary * 0.1),2),'FM999999999.00') AS tax
FROM people
WHERE salary > 3000
