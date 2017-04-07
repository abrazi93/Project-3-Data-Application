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

SELECT DISTINCT "districts" FROM "test";