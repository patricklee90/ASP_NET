-- Example: get age and accending 

SELECT sname,sage FROM Student
WHERE sclass='Aerial'
ORDER BY sage ASC --or the ASC is Default

-- Exp2: get student age from big to small
SELECt * FROM Student
WHERE sclass='Aerial'
ORDER BY sage DESC, snumb ASC


-- Exp3: get books before 2010, show 50% discount and follow sequence

SELECT bnumb,bname,author,press,pdate,price*0.5 AS discountprice
FROm book
WHERE pdate<'2010-1-1'>
ORDER BY discountprice DESC