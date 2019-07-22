-- put student class form "electric" to "electric61".

use teaching

SELECT * FROM Student

UPDATE Student
SET sclass='Electric61'
WHERE sclass ='Electric51'

-- change age 19,20 to add one more age

UPDATE Student
SET sage=sage+1
WHERE sage IN(18,20)

-- set Wang Tao birthday to 1994-04-8

UPDATE Student
SET sbirthday = '1995-4-8'
WHERE snumb='2016006001'

-- calculate the age for student who set NULL to his age

UPDATE Student
SET sage=DATEDIFF(year,sbirthday,GETDATE())
WHERE sage is NULL

-- set those between age 17-18 add one more age

UPDATE Student
SET sage=sage+1
WHERE sage BETWEEN 17 AND 18

--Modify multiple line

--modify 3rd student classes name as physics and chang li
UPDATE Student
SET sclass='physics',
sname='chang li'
WHERE snumb='2016006003'

SELECT * FROM Student


-- Delete physics class student info

DELETE FROM Student
WHERE sclass='physics'



