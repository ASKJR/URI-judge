/*
Problem: Quantidade de Caracteres
URI Online Judge | 2743
Solution developed by: Alberto Kato
*/

SELECT
name, char_length(name) AS length
FROM people
ORDER BY length DESC