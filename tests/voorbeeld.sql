create table "test" (
    "id" int primary key,
    "districts" char(256)
);

insert into "test" ("id", "districts") values
(1, 'Rotterdam'),
(2, 'Schiedam'),
(3, 'Delft'),
(4, 'Rotterdam'),
(5, 'Schiedam'),
(6, 'Schiedam');

-- Test nr 1:

SELECT DISTINCT "districts" FROM "test";

-- Test nr 2:

SELECT DISTINCT "districts" FROM "test" WHERE "districts" LIKE '%dam%'

-- of zonder DISTINCT

SELECT "districts" FROM "test" WHERE "districts" LIKE '%dam%'

-- of met meerdere velden zonder DISTINCT

SELECT * FROM "test" WHERE "districts" LIKE '%dam%'