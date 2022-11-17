USE DesignPatterns;

CREATE TABLE Beer (BeerId INT PRIMARY KEY IDENTITY NOT NULL, NAME VARCHAR(20) NOT NULL, Style VARCHAR(20));

ALTER TABLE Beer ADD BranId UNIQUEIDENTIFIER CONSTRAINT fk_beer_brand FOREIGN KEY REFERENCES Brand(BrandId)


CREATE TABLE Brand (BrandId UNIQUEIDENTIFIER PRIMARY KEY, NAME VARCHAR(30));