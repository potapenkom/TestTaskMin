SELECT Products.Name, Categories.Name from Products
LEFT JOIN CategoriesProducts
ON CategoriesProducts.productId = Products.id
LEFT JOIN Categories
ON CategoriesProducts.CategoryId = Categories.id