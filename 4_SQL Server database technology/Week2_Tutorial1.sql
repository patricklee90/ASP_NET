CREATE TABLE Student
(
sclass varchar(10) NOT NULL,
snumb varchar(10) PRIMARY KEY,
sname varchar(40) NOT NULL,
sgender varchar(4) DEFAULT 'Male' CONSTRAINT consgender CHECK(sgender IN('Male','Female')),
sbirthday date,
sage int CONSTRAINT consage CHECK(sage>=0 and sage<=150)
)

Electric51 2016006001 Wang Tao Male 1998-2-1 18

INSERT INTO Student
VALUES('Electric51','2016006002','Wang Tao','Male','1998-2-1',18)

SELECT * FROM Student

INSERT INTO Student (sclass,snumb,sname)
VALUES('Electric51','2016006003','Wang Tao')

INSERT INTO Student (sclass,snumb)
VALUES('Electric51','2016006004')

CONSTRAINT nameofconstrain CHECK(rules)