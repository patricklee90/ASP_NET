USE teaching

SELECT * FROM stu1

SELECT * FROM course

SELECT * FROM score

SELECT * 
FROM score,stu1

-- 2. equivalent connection

SELECT *
FROM score, stu1
WHERE score.numb=stu1.numb

-- 3. multiple table value connection

SELECT *
FROM score,stu1,course
WHERE score.numb=stu1.numb
AND score.cnumb=course.cnumb
AND stu1.name='Wang Ning'
ORDER BY course.cname DESC, score.score

-- 4. use table nickname

SELECT *
FROM score as a,stu1 as b,course as c
WHERE a.numb=b.numb
AND a.cnumb=c.cnumb
AND b.name='Wang Ning'
ORDER BY c.cname DESC, a.score

-- 5. delete that row that repeat
-- only see numb, name, class, score

SELECT b.numb,b.name,c.cname,a.score
FROM score as a,stu1 as b,course as c
WHERE a.numb=b.numb
AND a.cnumb=c.cnumb
AND b.name='Wang Ning'
ORDER BY c.cname DESC, a.score

-- 6. not equivalent connection
SELECT numb,cnumb,score,grade
FROM score, grade
WHERE score.score between grade.gstart AND grade.gend

--7. use INNER JOIN
SELECT *
FROM score
INNER JOIN stu1 ON score.numb=stu1.numb

SELECT *
FROM score
INNER JOIN stu1 ON score.numb=stu1.numb
INNER JOIN course ON score.cnumb=course.cnumb
WHERE stu1.name='Wang Ning'
ORDER BY course.cname DESC, score.score

--8. OUTER JOIN

SELECT *
FROM stu1
INNER JOIN score ON stu1.numb=score.numb

SELECT *
FROM stu1
lEFT OUTER JOIN score ON stu1.numb=score.numb

--- try this
SELECT *
FROM score
RIGHT OUTER JOIN stu1 ON stu1.numb=score.numb