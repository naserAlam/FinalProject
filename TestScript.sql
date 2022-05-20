SELECT FinalProjectDb.dbo.Users.Id, FinalProjectDb.dbo.Users.Username, FinalProjectDb.dbo.Users.Password, FinalProjectDb.dbo.Users.FirstName, FinalProjectDb.dbo.Users.LastName, FinalProjectDb.dbo.Users.Email, FinalProjectDb.dbo.UserTypes.Name AS Role 
FROM FinalProjectDb.dbo.Users 
INNER JOIN FinalProjectDb.dbo.UserTypes ON FinalProjectDb.dbo.Users.UserTypeId = FinalProjectDb.dbo.UserTypes.Id