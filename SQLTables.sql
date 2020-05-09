CREATE TABLE [dbo].[Categories] (
    [Id]   INT  NOT NULL,
    [Name] TEXT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Products] (
    [Id]   INT  NOT NULL,
    [Name] TEXT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[ProdCat] (
    [ProductsId]   INT NOT NULL,
    [CategoriesId] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([ProductsId] ASC, [CategoriesId] ASC),
    FOREIGN KEY ([ProductsId]) REFERENCES [dbo].[Products] ([Id]),
    FOREIGN KEY ([CategoriesId]) REFERENCES [dbo].[Categories] ([Id])
);

INSERT INTO Products
VALUES
(1, 'Horse'),
(2, 'Pig'),
(3, 'Snake'),
(4, 'Sun'),
(5, 'Flower'),
(6, 'Tree'),
(7, 'Man'),
(8, 'Woman'),
(9, 'Dog');

INSERT INTO Categories
VALUES
(1, 'Animal'),
(2, 'Toy'),
(3, 'Picture'),
(4, 'Sculpture');

INSERT INTO ProdCat
VALUES
(1, 1),
(1, 3),
(2, 4),
(8, 3),
(8, 4);





