CREATE TABLE Study
(
snumb varchar(10),
cnumb varchar(10),
score decimal(5,2),
PRIMARY KEY(snumb,cnumb),
FOREIGN KEY(snumb) REFERENCES Student(snumb),
FOREIGN KEY(cnumb) REFERENCES Course(cnumb)
)

INSERT INTO Study
VALUES('2016006001','ENP09001',90)

SELECT * FROM Student

SELECT * FROM Course

SELECT * FROM Study