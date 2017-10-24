DROP TABLE products;
DROP TABLE categories;

CREATE TABLE categories
(
	id		int				identity(1,1),
	name	varchar(100)	not null,

	constraint pk_categories primary key (id)
);

CREATE TABLE products
(
	id			int				identity(1,1),
	product		varchar(255)	not null,
	price		decimal			not null,
	description	varchar(max)	not null,
	category_id	int,
	image		varchar(255)	not null,

	constraint pk_products primary key (id),
	constraint fk_products_categories foreign key (category_id) references categories(id)
);

insert into categories (name) VALUES ('Dairy');
insert into categories (name) VALUES ('Fruit');
insert into categories (name) VALUES ('Vegetables');
insert into categories (name) VALUES ('Picnic Supplies');
insert into categories (name) VALUES ('Breads');


insert into products (product, price, description, category_id, image) values ('Radish', '1.42', 'A really tasty Radish - Pickled perfect for a picnic.', 3, 'Radish.jpg');
insert into products (product, price, description, category_id, image) values ('Broccoli', '0.26', 'A really tasty Flour - Buckwheat, Dark perfect for a picnic.', 3, 'Broccoli.jpg');
insert into products (product, price, description, category_id, image) values ('Lettuce', '3.40', 'A really tasty Sour Cream perfect for a picnic.', 3, 'Lettuce.jpg');
insert into products (product, price, description, category_id, image) values ('Green Beans', '3.68', 'A really tasty Rice Paper perfect for a picnic.', 3, 'GreenBeans.jpg');
insert into products (product, price, description, category_id, image) values ('Bread', '0.12', 'A really tasty Bread Base - Gold Formel perfect for a picnic.', 5, 'Bread.jpg');
insert into products (product, price, description, category_id, image) values ('Green Onion', '5.81', 'A really tasty Papadam perfect for a picnic.', 3, 'GreenOnion.jpg');
insert into products (product, price, description, category_id, image) values ('Dish Towel', '4.10', 'A really tasty Dish Towel perfect for a picnic.', 4, 'DishTowel.jpg');
insert into products (product, price, description, category_id, image) values ('Table Cloth', '0.30', 'A really tasty Lettuce - Escarole perfect for a picnic.', 4, 'TableCloth.jpg');
insert into products (product, price, description, category_id, image) values ('Apple', '0.51', 'A really tasty Mix - Cocktail Ice Cream perfect for a picnic.', 2, 'Apple.jpg');
insert into products (product, price, description, category_id, image) values ('Banana', '1.52', 'A really tasty Onions Granulated perfect for a picnic.', 2, 'Banana,jpg');
insert into products (product, price, description, category_id, image) values ('Orange', '0.07', 'A really tasty Transfer Sheets perfect for a picnic.', 2, 'Orange.jpg');
insert into products (product, price, description, category_id, image) values ('Whole Wheat Bread', '3.29', 'A really tasty Garlic - Elephant perfect for a picnic.', 5, 'WholeWheatBread.jpg');
insert into products (product, price, description, category_id, image) values ('Rye Bread', '5.41', 'A really tasty Lamb Rack Frenched Australian perfect for a picnic.', 5, 'RyeBread.jpg');
insert into products (product, price, description, category_id, image) values ('Milk - Skim', '1.28', 'A really tasty Quiche Assorted perfect for a picnic.', 1, 'SkimMilk.jpg');
insert into products (product, price, description, category_id, image) values ('Milk - 2%', '0.96', 'A really tasty Beer - Sleemans Honey Brown perfect for a picnic.', 1, '2% Milk.jpg');
insert into products (product, price, description, category_id, image) values ('Milk - Whole', '4.01', 'A really tasty Cocoa Powder - Dutched perfect for a picnic.', 1, 'WholeMilk.jpg');
insert into products (product, price, description, category_id, image) values ('Creamer, Coffee', '2.77', 'A really tasty Laundry - Bag Cloth perfect for a picnic.', 1, 'CoffeeCreamer.jpg');
insert into products (product, price, description, category_id, image) values ('Eggs - 1 dozen', '5.19', 'A really tasty Plasticknivesblack perfect for a picnic.', 1, 'Eggs1Dozen.jpg');
insert into products (product, price, description, category_id, image) values ('Eggs - half dozen', '3.29', 'A really tasty Pears - Fiorelle perfect for a picnic.', 1, 'EggsHalfDozen.jpg');
insert into products (product, price, description, category_id, image) values ('Milk - Chocolate', '1.85', 'A really tasty Garlic - Primerba, Paste perfect for a picnic.', 1, 'MilkChocolate.jpg');