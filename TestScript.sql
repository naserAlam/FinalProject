SELECT FinalProjectDb.dbo.Users.Id, FinalProjectDb.dbo.Users.Username, FinalProjectDb.dbo.Users.Password, FinalProjectDb.dbo.Users.FirstName, FinalProjectDb.dbo.Users.LastName, FinalProjectDb.dbo.Users.Email, FinalProjectDb.dbo.UserTypes.Name AS Role 
FROM FinalProjectDb.dbo.Users 
INNER JOIN FinalProjectDb.dbo.UserTypes ON FinalProjectDb.dbo.Users.UserTypeId = FinalProjectDb.dbo.UserTypes.Id

SELECT FinalProjectDb.dbo.Users.Id, FinalProjectDb.dbo.Users.Username, FinalProjectDb.dbo.Users.Password, FinalProjectDb.dbo.Users.FirstName, FinalProjectDb.dbo.Users.LastName, FinalProjectDb.dbo.Users.Email, FinalProjectDb.dbo.UserTypes.Name AS Role
FROM FinalProjectDb.dbo.Users
INNER JOIN FinalProjectDb.dbo.UserTypes ON FinalProjectDb.dbo.Users.UserTypeId = FinalProjectDb.dbo.UserTypes.Id
WHERE FinalProjectDb.dbo.Users.Username LIKE '%naser%' AND FinalProjectDb.dbo.UserTypes.Name LIKE 'admin';

SELECT FinalProjectDb.dbo.Products.Id, FinalProjectDb.dbo.Products.Name, Description, Price, Unit, FinalProjectDb.dbo.Categories.Name AS Category 
FROM FinalProjectDb.dbo.Products 
INNER JOIN FinalProjectDb.dbo.Categories ON FinalProjectDb.dbo.Products.CategoryId = FinalProjectDb.dbo.Categories.Id 
WHERE FinalProjectDb.dbo.Products.Name LIKE '%coca%' OR FinalProjectDb.dbo.Categories.Name LIKE '%snack%';

SELECT * FROM FinalProjectDb.dbo.Categories
WHERE FinalProjectDb.dbo.Categories.Name LIKE '%bev%';