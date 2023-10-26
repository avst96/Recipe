use HeartyHearthDB
go

create or alter proc dbo.RecipeSummaryGet(
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0

    select r.RecipeID, r.RecipeName, r.RecipeStatus, concat(u.FirstName, ' ', u.LastName) as Users , r.Calories, count(ri.IngredientID) as Num_Ingredients 
    from Recipe r 
    join Users u 
    on r.UsersID = u.UsersID
    left join RecipeIngredient ri 
    on r.RecipeID = ri.RecipeID
    group by r.RecipeID, r.RecipeName, r.RecipeStatus, u.FirstName, u.LastName, r.Calories 
    order by r.RecipeStatus desc


    return @return
end
go


exec RecipeSummaryGet