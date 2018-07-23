/*
Problem: Senhas
URI Online Judge | 2744
Solution developed by: Alberto Kato
*/

SELECT
id,password, MD5(password) AS MD5
FROM account
