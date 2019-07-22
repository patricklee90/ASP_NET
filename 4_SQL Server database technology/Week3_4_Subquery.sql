USE teaching

SELECT * FROM Student

SELECT * FROM score1

SELECT * FROM course

--1. use the in keyword

--Exp1: check the class that not enough 5 people and the student number, name and class
--Classes that not enough 5 people

SELECT sclass
FROM Student
GROUP BY sclass
HAVING COUNT(*)<10

--display student information from these classes.

SELECT snumb, sname, sclass
FROM Student
WHERE sclass IN (
SELECT sclass
FROM Student
GROUP BY sclass
HAVING COUNT(*)<10
)

--2. use Exits keyword

--exp2: if "physics" class have people mark higher than 90
-- then display all information like name,class, cnumber, mark

SELECT *
FROM Student
INNER JOIN score ON Student.snumb=score.numb
WHERE Student.sclass='Electric61' AND score.score >= 50

--if there is a result, then will display whole class details

SELECT sclass,snumb,sname,cnumb,score
FROM Student
INNER JOIN score ON Student.snumb=score.numb
WHERE Student.sclass='Electric61' AND
EXISTS(
SELECT *
FROM Student
INNER JOIN score ON Student.snumb=score.numb
WHERE Student.sclass='Electric61' AND score.score >= 50
)

--3.Compare calculation

--exp3: display the mark average of students
-- class,numb,name,cnumb,mark

SELECT AVG(score)
FROM score

-- AVERAGE score student info

SELECT a.sclass, a.snumb,a.sname,b.cnumb,b.score
FROM Student as a
INNER JOIN score as b ON a.snumb=b.numb
WHERE b.score> ANY(
SELECT AVG(score)
FROM score
) AND a.sclass='Electric61'

--4.subquery in FROM word

--exp4: enquiry student class number

-- First, check student where are they come from

SELECT distinct sclass
FROM Student


-- display the result as a form/ table

SELECT count(*) AS classes
FROM(
SELECT distinct sclass
FROM Student
)AS a

