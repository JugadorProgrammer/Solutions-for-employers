USE [ForHHRU]

SELECT P.[Name], C.[Name]
FROM Product P
LEFT JOIN product_category PC ON P.Id = PC.product_id
LEFT JOIN Category C ON C.Id = PC.category_id;