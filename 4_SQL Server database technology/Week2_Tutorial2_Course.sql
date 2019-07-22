CREATE TABLE Course
(
cnumb varchar(10) PRIMARY KEY,
cname varchar(40) NOT NULL,
chours int CONSTRAINT conshour CHECK(chours>=0 and chours<=300),
credit decimal(5,2) CONSTRAINT conscredit CHECK(credit >=0 and credit < 20),
intro text
)

INSERT INTO Course
VALUES('ENP09001','Theory Kinetic',56,3,'study the principle of Physcis dynamic')

SELECT * FROM Course