DROP DATABASE IF exists kiosk;
CREATE DATABASE kiosk;
USE kiosk;

-- Create a table and insert rows
DROP TABLE IF EXISTS dvd;
CREATE TABLE dvd (id serial PRIMARY KEY, title VARCHAR(50), director VARCHAR(50), price decimal(4,2), rating enum('G', 'PG', '12A', '15A', '16', '18') default 'PG' ,stockQuantity INTEGER default 2, timesRented INTEGER default 0, imageURL VARCHAR(30));
INSERT INTO dvd VALUES (0,'Zoolander', 'Ben Stiller', 10.00, '15A', 2, 0, 'zoolander.jpg');
INSERT INTO dvd VALUES (0,'Hot Fuzz', 'Edgar Wright', 10.00, '15A', 2, 0, 'darkknight.jpg');
INSERT INTO dvd VALUES (0,'Avatar', 'James Cameron', 10.00, '15A', 2, 0, 'avatar.jpg');
INSERT INTO dvd VALUES (0,'Titanic', 'James Cameron', 10.00, 'G', 2, 0, 'titanic.jpg');
INSERT INTO dvd VALUES (0,'The Avengers', 'Joss Whedon', 10.00, '16', 2, 0, 'theAvengers.jpg');
INSERT INTO dvd VALUES (0,'Black Panther', 'Ryan Coogler', 10.00, '15A', 2, 0,'blackPanther.jpg');
INSERT INTO dvd VALUES (0,'Iron Man 3', 'Shane Black', 10.00, '12A', 2, 0,'ironMan3.jpg');
INSERT INTO dvd VALUES (0,'Sky Fall', 'Sam Mendes', 10.00, '15A', 2, 0, 'skyfall.jpg');
INSERT INTO dvd VALUES (0,'Joker', 'Todd Philips', 10.00, '16', 2, 0, 'joker.jpg');
INSERT INTO dvd VALUES (0,'The Dark Knight', 'Chrisropher Nolan', 10.00, '16', 2, 0, 'darkknight.jpg');
INSERT INTO dvd VALUES (0,'Training Day', 'Antoine Fuqua', 10.00, '15A', 2, 0,'trainingday.jpg');
INSERT INTO dvd VALUES (0,'Usual Suspects', 'Bryan Singer', 10.00, '15A', 2, 0, 'usualSuspects.jpg');
INSERT INTO dvd VALUES (0,'The Prestige', 'Chrisropher Nolan', 10.00, '15A', 2, 0, 'thepresitege.jpg');
INSERT INTO dvd VALUES (0,'Inception', 'Christopher Nolan', 10.00, '12A', 2, 0, 'inception.jpg');
INSERT INTO dvd VALUES (0,'Shutter Island', 'Martin Scorsese', 10.00, '12A', 2, 0, 'shutterIsland.jpg');
INSERT INTO dvd VALUES (0,'Reservoir Dogs', 'Quentin Tarantino', 10.00, '16', 2, 0, 'reservoirDogs.jpg');
INSERT INTO dvd VALUES (0,'Toy Story', 'John Lasseter', 10.00, 'G', 2, 0, 'Toy_Story.jpg');
INSERT INTO dvd VALUES (0,'The Lion King', 'Roger Allers', 10.00, 'G', 2, 0, 'lionKing.jpg');
INSERT INTO dvd VALUES (0,'Grease', 'Randal Kleiser', 10.00, '12A', 2, 0, 'grease.jpg');
INSERT INTO dvd VALUES (0,'Top Gun', 'Tony Scott', 10.00, '12A', 2, 0, 'topGun.jpg');

Commit;

-- Read
SELECT * FROM dvd;