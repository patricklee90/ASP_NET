USE teaching

SELECT * FROM Student

SELECT sclass,snumb,sname FROM Student

SELECT sclass FROM Student

SELECT DISTINCT sclass FROM Student

SELECT bnumb,bname,author,press,pdate,price*0.9 AS discount
FROM book

SELECT bnumb AS Booknum,bname AS BookName,author,press,pdate,price*0.9 AS discount 
INTO discount
FROM book
