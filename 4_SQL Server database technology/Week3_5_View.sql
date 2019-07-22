USE teaching

SELECT * FROM Student

SELECT * FROM score

SELECT * FROM Course

-- 2. multiple form link

-- link student, score and course

SELECT a.sclass, a.snumb,a.sname,a.sgender,
c.cname,b.score,c.chours,c.credit
FROM Student as a
INNER JOIN score as b ON a.snumb=b.numb
INNER JOIN Course as c ON b.cnumb = c.cnumb

-- CREATE VIEW diagramname [(list)]
-- AS
-- Query

CREATE VIEW examinfo
AS
SELECT a.sclass, a.snumb,a.sname,a.sgender,
c.cname,b.score,c.chours,c.credit
FROM Student as a
INNER JOIN score as b ON a.snumb=b.numb
INNER JOIN Course as c ON b.cnumb = c.cnumb

-- Add on nickname
CREATE VIEW examinfo2 (class,id,naming,gender,course,score,hournumber,credit)
AS
SELECT a.sclass, a.snumb,a.sname,a.sgender,
c.cname,b.score,c.chours,c.credit
FROM Student as a
INNER JOIN score as b ON a.snumb=b.numb
INNER JOIN Course as c ON b.cnumb = c.cnumb

-- Use of View

-- query all student all class mark
-- display class, numb, name,gende, course, mark, hour and credit

SELECT * FROM examinfo2

-- query those who join "Database Technique" student information
-- id, name, gender, course, mark, hour, credit

SELECT * FROM examinfo
WHERE cname ='Database Technique'

SELECT snumb, sname, cname,score
FROM examinfo
WHERE sclass = 'Electric61'

-- get "electric61" and "database technique" student info
SELECT snumb, sname, score
FROM examinfo
WHERE sclass = 'Electric61' AND cname = 'Database Technique'

-- example2: check student who average age is 20

-- completely use subquery

SELECT *
FROM Student
WHERE sclass IN(
SELECT sclass as class FROM Student
GROUP BY sclass
HAVING AVG(sage) >=20
)

-- use view to get average

CREATE VIEW myclass
AS
SELECT sclass as average FROM Student
GROUP by sclass
HAVING AVG(sage)>=20

-- use view

SELECT * FROM Student
WHERE sclass in (
SELECT * FROM myclass
)

-- DELETE VIEW

DROP VIEW myclass

DROP VIEW examinfo2











