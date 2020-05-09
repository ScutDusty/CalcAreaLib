SELECT 
	Products.Name,
	Categories.Name
FROM Products
	LEFT JOIN ProdCat ON Products.Id = ProdCat.ProductsId
	LEFT JOIN Categories ON ProdCat.CategoriesId=Categories.Id

/*
RESULT

1	Horse	Animal
2	Horse	Picture
3	Pig	Sculpture
4	Snake	NULL
5	Sun	NULL
6	Flower	NULL
7	Tree	NULL
8	Man	NULL
9	Woman	Picture
10	Woman	Sculpture
11	Dog	NULL
*/