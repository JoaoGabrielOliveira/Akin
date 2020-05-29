CREATE DATABASE AKIN;

USE akin;

CREATE TABLE users(
	id INT PRIMARY KEY identity,
	first_name VARCHAR(60),
	email VARCHAR(255),
	ecy_password VARCHAR(32),
	type_user CHAR(1),
	created_at DATE
)

CREATE TABLE products(
	id INT PRIMARY KEY identity NOT NULL,
	product_name VARCHAR(60) NOT NULL,
	price DECIMAL(7,2) NOT NULL,
	stock int NOT NULL,
	suplier_id int NOT NULL,
	created_at DATE
)

CREATE TABLE purchases (
	id INT NOT NULL,
	total_price DECIMAL(7,2) NOT NULL,

	user_id INT NOT NULL,

	product_id INT,
	created_at DATE
)

INSERT INTO users (first_name, email,ecy_password,type_user,created_at) VALUES ('João', 'joao@gmail.com', '12345678','c',GETDATE());

INSERT INTO products (product_name, price,stock,suplier_id,created_at) VALUES ('Brinco', 10.00 , 10 , 2 ,GETDATE());
INSERT INTO products (product_name, price,stock,suplier_id,created_at) VALUES ('Bolsa', 15.99 , 15 , 2 ,GETDATE());
INSERT INTO products (product_name, price,stock,suplier_id,created_at) VALUES ('Turbante', 79.99 , 19 , 2 ,GETDATE());

INSERT INTO purchases (id, total_price,user_id,product_id,created_at) VALUES (3, 10.00 , 1 , 3 ,GETDATE());
INSERT INTO purchases (id, total_price,user_id,product_id,created_at) VALUES (3, 79.99 , 1 , 5 ,GETDATE());



SELECT Top(2) products.ID,products.product_name,products.price,products.stock,products.created_at FROM products
SELECT products.ID,products.product_name,products.price,products.stock,products.created_at FROM products

SELECT * FROM users;
SELECT * FROM products;

SELECT purchases.id, purchases.total_price,users.first_name,purchases.product_id,purchases.created_at FROM purchases, users WHERE users.id = product_id