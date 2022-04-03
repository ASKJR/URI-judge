/*
Problem: Concurso
URI Online Judge | 2738
Solution developed by: Alberto Kato
*/

SELECT
c.name,
to_char(float8 ((s.math*2)+(s.specific*3)+(s.project_plan*5))/10,'FM999999999.00') AS avg 
FROM score s
JOIN candidate c ON (c.id = s.candidate_id)
ORDER BY avg DESC