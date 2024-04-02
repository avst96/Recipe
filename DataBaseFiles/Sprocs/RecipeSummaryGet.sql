use HeartyHearthDB
go

create or alter proc dbo.RecipeSummaryGet(
    @RecipeSummaryId int = 0,
    @All bit = 0,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0
    select @All = isnull(@All,0) , @RecipeSummaryId = isnull(@RecipeSummaryId,0)

    select r.RecipeID, r.RecipeName, r.RecipeStatus, concat(u.FirstName, ' ', u.LastName) as Users , r.Calories, count(ri.IngredientID) as Num_Ingredients, r.isVegan 
    from Recipe r 
    join Users u 
    on r.UsersID = u.UsersID
    left join RecipeIngredient ri 
    on r.RecipeID = ri.RecipeID
    where r.RecipeID = @RecipeSummaryId or @All = 1
    group by r.RecipeID, r.RecipeName, r.RecipeStatus, u.FirstName, u.LastName, r.Calories, r.isVegan 
    order by r.RecipeStatus desc


    return @return
end
go


exec RecipeSummaryGet @All=1