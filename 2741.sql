/*
Problem: Notas dos Alunos
URI Online Judge | 2741
Solution developed by: Alberto Kato
*/

SELECT
'Approved: ' || name AS name,
grade
FROM students
WHERE grade >= 7
ORDER BY grade DESC