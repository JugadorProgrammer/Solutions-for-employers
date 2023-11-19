USE [ForHHRU]

CREATE TABLE [dbo].[Product](
	[Id] int IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	Primary key(Id)
);

CREATE TABLE [dbo].[Category](
	[Id] int IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	Primary key(Id)
);

CREATE TABLE product_category (
    product_id INT,
    category_id INT,
    PRIMARY KEY (product_id, category_id),
    FOREIGN KEY (product_id) REFERENCES [Product](Id),
    FOREIGN KEY (category_id) REFERENCES [Category](Id)
);