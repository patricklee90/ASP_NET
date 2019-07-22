Use teaching

-- Exp1: get all the student average age.

SELECT AVG(sage) AS Average FROM Student

-- Exp2: Get student biggest smalles and average age

SELECT MAX(sage) AS MAXIMUM, MIN(sage) AS MINIMUM,AVG(sage) AS AVERAGE, COUNT(*) AS PEOPLENUMBER
FROM Student
WHERE sclass='aero'

--exp3: Format Conversion Function

SELECT CONVERT(varchar, 120)

--exp5: change number to string

SELECt CONVERT(varchar, 120.12)

--exp6: string to int

SELECT CONVERT(int, '120')

--exp7: string to real number

SELECt CONVERT(decimal(7,5),'3.14159')

--exp8: date to string

SELECT CONVERT(char, GETDATE())

--exp9: date to yy,mm,dd type of string

SELECT CONVERT(char, GETDATE(), 102)

--exp10: date to yy/mm/dd type of string

SELECT CONVERT(char, GETDATE(),111)

--exp11: string to date

SELECT CONVERT(DATE, '20160510')
SELECT CONVERT(DATE, '2016/5/10')
SELECT CONVERT(DATE, '2016-5-10')
SELECT CONVERT(DATE, '5/10/2016')

--exp12: get current date

SELECT GETDATE()

--exp13: date in part add

SELECT DATEADD(year,0, '2010/5/10 10:10:10.100')

SELECT DATEADD(year,5, '2010/5/10 10:10:10.100')

SELECT DATEADD(month,5, '2010/5/10 10:10:10.100')

SELECT DATEADD(day,5, '2010/5/10 10:10:10.100')

SELECT DATEADD(hour,5, '2010/5/10 10:10:10.100')

SELECT DATEADD(minute,5, '2010/5/10 10:10:10.100')

SELECT DATEADD(second,5, '2010/5/10 10:10:10.100')

SELECT DATEADD(year,5,sbirthday) FROM Student

--exp14: minus in a part of date

SELECt DATEDIFF(year,'2010-1-1','2016-1-1')

SELECT DATEDIFF(year,sbirthday,GETDATE())
FROM Student

--exp15: get a part of the date

SELECT DATENAME(month,GETDATE())

SELECT DATENAME(hour,GETDATE())

SELECT sclass,snumb,sname, 
	DATENAME(year,sbirthday) AS birhtday
	FROM Student
	WHERE sclass='electric'

--exp16: get the student detail from physic class

SELECT*
FROM Student
WHERE sclass='Physics'

SELECT*
FROM Student
WHERE rtrim(ltrim(sclass))='Physics'
