-- Table buyers
CREATE TABLE "buyers" (
  "id" INTEGER PRIMARY KEY AUTOINCREMENT,
  "first_name" VARCHAR(30) NOT NULL,
  "last_name" VARCHAR(40) NOT NULL,
  "address" VARCHAR(50) NOT NULL,
  "email" VARCHAR(90) NOT NULL,
  "cities_id" INTEGER,
  FOREIGN KEY ("cities_id") REFERENCES "cities" ("id") ON DELETE NO ACTION ON UPDATE NO ACTION
);

-- Table user_types
CREATE TABLE "user_types" (
  "id" INTEGER PRIMARY KEY AUTOINCREMENT,
  "name" VARCHAR(30) NOT NULL,
  "description" VARCHAR(150)
);

-- Table items
CREATE TABLE "items" (
  "id" INTEGER PRIMARY KEY AUTOINCREMENT,
  "name" VARCHAR(50) NOT NULL,
  "price" REAL NOT NULL,
  "stock" INTEGER NOT NULL,
  "description" VARCHAR(300),
  "images_id" INTEGER,
  FOREIGN KEY ("images_id") REFERENCES "images" ("id") ON DELETE NO ACTION ON UPDATE NO ACTION
);

-- Table categories
CREATE TABLE "categories" (
  "id" INTEGER PRIMARY KEY AUTOINCREMENT,
  "name" VARCHAR(50) NOT NULL
);

-- Table cities
CREATE TABLE "cities" (
  "id" INTEGER PRIMARY KEY AUTOINCREMENT,
  "name" VARCHAR(100) NOT NULL,
  "postal_number" INTEGER NOT NULL,
  "countries_id" INTEGER,
  FOREIGN KEY ("countries_id") REFERENCES "countries" ("id") ON DELETE NO ACTION ON UPDATE NO ACTION
);

-- Table countries
CREATE TABLE "countries" (
  "id" INTEGER PRIMARY KEY AUTOINCREMENT,
  "name" VARCHAR(100) NOT NULL,
  "country_code" VARCHAR(3) NOT NULL
);

-- Table subcategories
CREATE TABLE "subcategories" (
  "id" INTEGER PRIMARY KEY AUTOINCREMENT,
  "name" VARCHAR(50) NOT NULL,
  "categories_id" INTEGER,
  FOREIGN KEY ("categories_id") REFERENCES "categories" ("id") ON DELETE NO ACTION ON UPDATE NO ACTION
);

-- Table proforma_invoices
CREATE TABLE "proforma_invoices" (
  "id" INTEGER PRIMARY KEY AUTOINCREMENT,
  "companies_id" INTEGER,
  "buyers_id" INTEGER,
  "items_id" INTEGER,
  "purchase_time" TIMESTAMP NOT NULL,
  "expire_date" TIMESTAMP NOT NULL,
  "invoice_number" INTEGER NOT NULL,
  "payment_type" VARCHAR(20) NOT NULL,
  FOREIGN KEY ("buyers_id") REFERENCES "buyers" ("id") ON DELETE NO ACTION ON UPDATE NO ACTION,
  FOREIGN KEY ("items_id") REFERENCES "items" ("id") ON DELETE NO ACTION ON UPDATE NO ACTION,
  FOREIGN KEY ("companies_id") REFERENCES "companies" ("id") ON DELETE NO ACTION ON UPDATE NO ACTION
);

-- Table companies
CREATE TABLE "companies" (
  "id" INTEGER PRIMARY KEY AUTOINCREMENT,
  "name" VARCHAR(50) NOT NULL,
  "cities_id" INTEGER,
  FOREIGN KEY ("cities_id") REFERENCES "cities" ("id") ON DELETE NO ACTION ON UPDATE NO ACTION
);

-- Table images
CREATE TABLE "images" (
  "id" INTEGER PRIMARY KEY AUTOINCREMENT,
  "url" TEXT NOT NULL,
  "description" VARCHAR(100)
);
