/*
Created: 1. 04. 2025
Modified: 1. 04. 2025
Model: PostgreSQL 10
Database: PostgreSQL 10
*/

-- Create tables section -------------------------------------------------

-- Table buyers

CREATE TABLE "buyers"
(
  "id" Serial NOT NULL,
  "first_name" Character varying(30) NOT NULL,
  "last_name" Character varying(40) NOT NULL,
  "address" Character varying(50) NOT NULL,
  "email" Character varying(90) NOT NULL,
  "cities_id" Integer
)
WITH (
  autovacuum_enabled=true)
;

CREATE INDEX "IX_Relationship2" ON "buyers" ("cities_id")
;

ALTER TABLE "buyers" ADD CONSTRAINT "PK_buyers" PRIMARY KEY ("id")
;

-- Table user_types

CREATE TABLE "user_types"
(
  "id" Serial NOT NULL,
  "name" Character varying(30) NOT NULL,
  "description" Character varying(150)
)
WITH (
  autovacuum_enabled=true)
;

ALTER TABLE "user_types" ADD CONSTRAINT "PK_user_types" PRIMARY KEY ("id")
;

-- Table items

CREATE TABLE "items"
(
  "id" Serial NOT NULL,
  "name" Character varying(50) NOT NULL,
  "price" Real NOT NULL,
  "stock" Integer NOT NULL,
  "description" Character varying(300),
  "images_id" Integer
)
WITH (
  autovacuum_enabled=true)
;

CREATE INDEX "IX_Relationship12" ON "items" ("images_id")
;

ALTER TABLE "items" ADD CONSTRAINT "PK_items" PRIMARY KEY ("id")
;

-- Table categories

CREATE TABLE "categories"
(
  "id" Serial NOT NULL,
  "name" Character varying(50) NOT NULL
)
WITH (
  autovacuum_enabled=true)
;

ALTER TABLE "categories" ADD CONSTRAINT "PK_categories" PRIMARY KEY ("id")
;

-- Table cities

CREATE TABLE "cities"
(
  "id" Serial NOT NULL,
  "name" Character(100) NOT NULL,
  "postal_number" Integer NOT NULL,
  "countries_id" Integer
)
WITH (
  autovacuum_enabled=true)
;

CREATE INDEX "IX_Relationship3" ON "cities" ("countries_id")
;

ALTER TABLE "cities" ADD CONSTRAINT "PK_cities" PRIMARY KEY ("id")
;

-- Table countries

CREATE TABLE "countries"
(
  "id" Serial NOT NULL,
  "name" Character varying(100) NOT NULL,
  "country_code" Character varying(3) NOT NULL
)
WITH (
  autovacuum_enabled=true)
;

ALTER TABLE "countries" ADD CONSTRAINT "PK_countries" PRIMARY KEY ("id")
;

-- Table subcategories

CREATE TABLE "subcategories"
(
  "id" Serial NOT NULL,
  "name" Character varying(50) NOT NULL,
  "categories_id" Integer
)
WITH (
  autovacuum_enabled=true)
;

CREATE INDEX "IX_Relationship4" ON "subcategories" ("categories_id")
;

ALTER TABLE "subcategories" ADD CONSTRAINT "PK_subcategories" PRIMARY KEY ("id")
;

-- Table proforma_invoices

CREATE TABLE "proforma_invoices"
(
  "id" Serial NOT NULL,
  "companies_id" Integer,
  "buyers_id" Integer,
  "items_id" Integer,
  "purchase_time" Timestamp NOT NULL,
  "expire_date" Timestamp NOT NULL,
  "invoice_number" Integer NOT NULL,
  "payment_type" Character varying(20) NOT NULL
)
WITH (
  autovacuum_enabled=true)
;

CREATE INDEX "IX_Relationship7" ON "proforma_invoices" ("buyers_id")
;

CREATE INDEX "IX_Relationship8" ON "proforma_invoices" ("items_id")
;

CREATE INDEX "IX_Relationship9" ON "proforma_invoices" ("companies_id")
;

ALTER TABLE "proforma_invoices" ADD CONSTRAINT "PK_proforma_invoices" PRIMARY KEY ("id")
;

-- Table companies

CREATE TABLE "companies"
(
  "id" Serial NOT NULL,
  "name" Character varying(50) NOT NULL,
  "cities_id" Integer
)
WITH (
  autovacuum_enabled=true)
;

CREATE INDEX "IX_Relationship10" ON "companies" ("cities_id")
;

ALTER TABLE "companies" ADD CONSTRAINT "PK_companies" PRIMARY KEY ("id")
;

-- Table images

CREATE TABLE "images"
(
  "id" Serial NOT NULL,
  "url" Text NOT NULL,
  "description" Character varying(100)
)
WITH (
  autovacuum_enabled=true)
;

ALTER TABLE "images" ADD CONSTRAINT "PK_images" PRIMARY KEY ("id")
;

-- Create foreign keys (relationships) section -------------------------------------------------

ALTER TABLE "buyers"
  ADD CONSTRAINT "Relationship2"
    FOREIGN KEY ("cities_id")
    REFERENCES "cities" ("id")
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
;

ALTER TABLE "cities"
  ADD CONSTRAINT "Relationship3"
    FOREIGN KEY ("countries_id")
    REFERENCES "countries" ("id")
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
;

ALTER TABLE "subcategories"
  ADD CONSTRAINT "Relationship4"
    FOREIGN KEY ("categories_id")
    REFERENCES "categories" ("id")
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
;

ALTER TABLE "proforma_invoices"
  ADD CONSTRAINT "Relationship7"
    FOREIGN KEY ("buyers_id")
    REFERENCES "buyers" ("id")
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
;

ALTER TABLE "proforma_invoices"
  ADD CONSTRAINT "Relationship8"
    FOREIGN KEY ("items_id")
    REFERENCES "items" ("id")
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
;

ALTER TABLE "proforma_invoices"
  ADD CONSTRAINT "Relationship9"
    FOREIGN KEY ("companies_id")
    REFERENCES "companies" ("id")
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
;

ALTER TABLE "companies"
  ADD CONSTRAINT "Relationship10"
    FOREIGN KEY ("cities_id")
    REFERENCES "cities" ("id")
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
;

ALTER TABLE "items"
  ADD CONSTRAINT "Relationship12"
    FOREIGN KEY ("images_id")
    REFERENCES "images" ("id")
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
;

