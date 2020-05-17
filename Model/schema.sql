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

delete from users;

INSERT INTO users (first_name, email,ecy_password,type_user,created_at) VALUES ('João', 'joao@gmail.com', '12345678','c',GETDATE());
select * from users;

CREATE TABLE products(
	id INT PRIMARY KEY identity NOT NULL,
	product_name VARCHAR(60) NOT NULL,
	price DECIMAL(7,2) NOT NULL,
	stock int NOT NULL,
	created_at DATE
)