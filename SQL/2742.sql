/*
Problem: O Multiverso de Richard
URI Online Judge | 2742
Solution developed by: Alberto Kato
*/

SELECT 
lr.name,
ROUND((lr.omega * 1.618),3) AS "Fator N"
FROM life_registry lr
JOIN dimensions d on (d.id = lr.dimensions_id)
WHERE d.name IN ('C875','C774')
AND lr. name like '%Richard%'
