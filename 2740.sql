/*
Problem: Liga
URI Online Judge | 2740
Solution developed by: Alberto Kato
*/

(SELECT 
    'Podium: ' || team AS name
FROM
    league
ORDER BY position
LIMIT 3) UNION ALL (SELECT 
    'Demoted: ' || team AS name
FROM
    league
WHERE
    position IN (SELECT 
            position
        FROM
            league
        ORDER BY position DESC
        LIMIT 2)
ORDER BY position)