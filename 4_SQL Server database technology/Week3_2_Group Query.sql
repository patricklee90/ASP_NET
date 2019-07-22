USE teaching

SELECT * FROM Student

INSERT INTO Student(sclass,snumb,sname,sgender,sbirthday,sage)
VALUES('Chemi54','2016006003','li cheng', 'Male', '1993-02-15',26)

INSERT INTO Student(sclass,snumb,sname,sgender,sbirthday,sage)
VALUES('Chemi54','2016006004','Brian', 'Male', '1994-12-05',25)

INSERT INTO Student(sclass,snumb,sname,sgender,sbirthday,sage)
VALUES('Chemi54','2016006005','Jing Guang', 'Male', '1994-12-12',25)

INSERT INTO Student(sclass,snumb,sname,sgender,sbirthday,sage)
VALUES('Electric61','2016006007','Yong Guan', 'Male', '1992-12-12',27)

INSERT INTO Student(sclass,snumb,sname,sgender,sbirthday,sage)
VALUES('Account33','2016006008','Allya', 'Female', '1992-05-16',27)

INSERT INTO Student(sclass,snumb,sname,sgender,sbirthday,sage)
VALUES('Account33','2016006009','Eleen', 'Female', '1996-07-03',23)

INSERT INTO Student(sclass,snumb,sname,sgender,sbirthday,sage)
VALUES('Account33','2016006010','jx', 'Male', '1992-02-23',27)

------
INSERT INTO Student(sclass,snumb,sname,sgender,sbirthday,sage)
VALUES('Chemi54','2016006011','Lee Yen', 'Female', '1992-01-15',27)

INSERT INTO Student(sclass,snumb,sname,sgender,sbirthday,sage)
VALUES('Chemi54','2016006012','Regina', 'Female', '1996-11-05',23)

INSERT INTO Student(sclass,snumb,sname,sgender,sbirthday,sage)
VALUES('Chemi54','2016006013','Xiu Ping', 'Female', '1995-12-12',24)

INSERT INTO Student(sclass,snumb,sname,sgender,sbirthday,sage)
VALUES('Electric61','2016006014','Shu Peng', 'Female', '1992-12-12',27)

INSERT INTO Student(sclass,snumb,sname,sgender,sbirthday,sage)
VALUES('Account33','2016006015','Evoon', 'Female', '1992-05-16',27)

INSERT INTO Student(sclass,snumb,sname,sgender,sbirthday,sage)
VALUES('Account33','2016006016','Xiu Ting', 'Female', '1998-05-03',21)

INSERT INTO Student(sclass,snumb,sname,sgender,sbirthday,sage)
VALUES('Account33','2016006017','Xia Li', 'Female', '1992-02-23',27)

-------
INSERT INTO Student(sclass,snumb,sname,sgender,sbirthday,sage)
VALUES('Chemi54','2016006018','Xiu Yook', 'Female', '1992-01-15',27)

INSERT INTO Student(sclass,snumb,sname,sgender,sbirthday,sage)
VALUES('Chemi54','2016006019','Xiu Feng', 'Female', '1996-11-05',23)

INSERT INTO Student(sclass,snumb,sname,sgender,sbirthday,sage)
VALUES('Chemi54','2016006020','Xiu Koon', 'Female', '1995-12-12',24)

INSERT INTO Student(sclass,snumb,sname,sgender,sbirthday,sage)
VALUES('Electric61','2016006021','Xiu Yoon', 'Female', '1992-12-12',27)

INSERT INTO Student(sclass,snumb,sname,sgender,sbirthday,sage)
VALUES('Account33','2016006022','Xiu Yen', 'Female', '1992-05-16',27)

INSERT INTO Student(sclass,snumb,sname,sgender,sbirthday,sage)
VALUES('Account33','2016006023','Xiu En', 'Female', '1998-05-03',21)

INSERT INTO Student(sclass,snumb,sname,sgender,sbirthday,sage)
VALUES('Account33','2016006024','Xia Kun', 'Female', '1992-02-23',27)


--Example 1 check student max age, min age, and average people number

SELECT sclass AS class, MAX(sage) as MAXIMUM, MIN(sage) as MINIMUM,
AVG(sage) as AVERAGE, COUNT(*) as NUMBER
FROM Student
GROUP BY sclass

--Example1.1 trim those that have empty space
SELECT ltrim(sclass) AS class, MAX(sage) as MAXIMUM, MIN(sage) as MINIMUM,
AVG(sage) as AVERAGE, COUNT(*) as NUMBER
FROM Student
GROUP BY ltrim(sclass)

UPDATE Student
SET sclass=ltrim(sclass)

SELECT * FROM Student

--Example2 check student max age, min age, and average people number
-- at the same time sequence base on average age.
SELECT sclass AS class, MAX(sage) as MAXIMUM, MIN(sage) as MINIMUM,
AVG(sage) as AVERAGE, COUNT(*) as NUMBER
FROM Student
GROUP BY sclass
ORDER BY AVERAGE DESC

--Example3 check the number of male and female
SELECT sclass, sgender, COUNT(*) as NUMBER
FROM Student
GROUP BY sclass,sgender
ORDER BY sclass

--Example4 check each class student have xiu
SELECT sclass,COUNT(*) AS XIU FROM Student
WHERE sname LIKE 'Xiu%'
GROUP BY sclass

--Example5 Check the number of Xiu bigger than 1 class and number of people
SELECT sclass,COUNT(*) AS XIU FROM Student
WHERE sname LIKE 'Xiu%'
GROUP BY sclass
HAVING COUNT(*)>1

ALTER TABLE Student
ADD Province varchar(255)

--Example6 check number of student who came from different province, follow by class sequence
SELECT sclass,Province, count(*) AS NUM
from Student
GROUP BY sclass,Province
ORDER BY sclass


