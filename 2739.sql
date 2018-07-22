/*
Problem: Dia de Pagamento
URI Online Judge | 2739
Solution developed by: Alberto Kato
*/

SELECT name, 
CAST(substring(CAST(payday AS varchar) from 9 for 2) AS integer) AS day 
FROM loan