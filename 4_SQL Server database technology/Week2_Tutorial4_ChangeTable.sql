
-- Create a server table called people
CREATE TABLE people
(
name varchar(40),
gender varchar(10),
birthday varchar(10)
)

--2. Alter Table
ALTER TABLE TableName

-- (1) Add Field
ALTER TABLE TableName
ADD ColumnName Type [Description] -- [NULL | NOT NULL] [DEFAULT] [PRIMARY KEY] [CONSTRAIN]

-- Example1: add phone number in table people
ALTER TABLE people
ADD tel varchar(20)

-- Example2: add age in table people
ALTER TABLE people
ADD age int DEFAULT 18 CHECK(age>=0 and age<=150)

SELECT * FROM people

-- Example3: add id into people table
ALTER TABLE people
ADD id varchar(20) CONSTRAINT pkey PRIMARY KEY

-- (2) DELETE Field
ALTER TABLE TableName
DROP COLUMN FieldName

-- Example4: DELETE Phone Field
ALTER TABLE people
DROP COLUMN tel

SELECT * FROM people

-- (3) Change Field Type

ALTER TABLE TableName
ALTER COLUMN Field Name New Type

-- Example5: change birthday to date type

ALTER TABLE people
ALTER COLUMN birthday date

ALTER TABLE people
ALTER COLUMN age decimal(5,1)

-- (4) Add CONSTRAINT

ALTER TABLE TableName
ADD CONSTRAINT ConstraintType
CHECK (rules)

-- Example6: add constraint to gender

ALTER TABLE people
ADD CONSTRAINT pgender CHECK(gender='Male' or gender='Female')

-- (5) Delete CONSTRAINT

ALTER TABLE TableName
DROP CONSTRAINT constrainName

-- Example7: delete gender constraint

ALTER TABLE people
DROP CONSTRAINT pgender

-- Example8: delete id PRIMARY KEY
ALTER TABLE people
DROP CONSTRAINT pkey

-- (6) Add PRIMARY KEY Constraint

ALTER TABLE TableName
ADD CONSTRAINT ConstraintName
PRIMARY KEY (Field List)

-- Example9: set id and name as PRIMARY KEY (when currently no PRIMARY KEY, if so must delete it first)

ALTER TABLE people
ALTER COLUMN
name varchar(40) NOT NULL

ALTER TABLE people
ADD CONSTRAINT pkey
PRIMARY KEY(id,name)

-- (7) Add FOREIGN KEY CONSTRAINT

ALTER TABLE TableName
ADD CONSTRAINT constraintName FOREIGN KEY(Foreign key fieldname)
REFERENCES TableName2(refered name)

-- Example10: set id as FOREIGN KEY

ALTER TABLE people
ADD CONSTRAINT fkey FOREIGN KEY(id)
REFERENCES Student(snumb)

ALTER TABLE people
ALTER COLUMN id varchar(10) NOT NULL

ALTER TABLE people
DROP CONSTRAINT pkey

-- DELTE TABLE
DROP
DROP TABLE TableName

-- Example11: delete people Table
DROP TABLE people








