USE teaching 
CREATE TABLE stu
(
sclass varchar(20),
snumb varchar(10),
sname varchar(40)
)

INSERT INTO stu(sclass,snumb,sname)
VALUES ('mechanical','2016005001','zhang ming')

INSERT INTO stu(sclass,snumb)
VALUES ('mechanical','2016005002')

INSERT INTO stu(sname,snumb)
VALUES ('LILI','2016005003')

INSERT INTO stu
VALUES ('English','2016006001','wang wei')

SELECT * FROM stu

