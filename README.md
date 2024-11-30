Task 2

SELECT 
    Products.ProductName AS ProductName,
    Categories.CategoryName AS CategoryName
FROM 
    Products
LEFT JOIN 
    ProductCategories ON Products.ProductID = ProductCategories.ProductID
LEFT JOIN 
    Categories ON ProductCategories.CategoryID = Categories.CategoryID
ORDER BY 
    ProductName, CategoryName;
