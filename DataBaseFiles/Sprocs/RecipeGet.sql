use HeartyHearthDB
go

create or alter procedure dbo.RecipeGet 
as 
begin
select r.RecipeID, r.UsersID, r.CuisineID, r.RecipeName, r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.RecipePic
from Recipe r
end
go

exec RecipeGet