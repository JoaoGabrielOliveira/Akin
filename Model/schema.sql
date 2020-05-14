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

INSERT INTO users (first_name, email,ecy_password,type_user) VALUES ('João', 'joao@gmail.com', '12345678','c');