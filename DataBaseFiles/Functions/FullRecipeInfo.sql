use HeartyHearthDB
go

create or alter function dbo.FullRecipeInfo (@RecipeId int)
returns varchar(150)

as begin
	declare @recipeinfo varchar(150)

	select @recipeinfo = concat(r.RecipeName, ' (', c.CuisineName, ') has ',count(distinct ri.RecipeIngredientID),' ingredients and ',count(distinct d.Steps),' steps.' )
	from Recipe r
	join Cuisine c 
	on r.CuisineID = c.CuisineID
	join RecipeIngredient ri
	on r.RecipeID = ri.RecipeID
	join Directions d 
	on r.RecipeID = d.RecipeID
	where r.RecipeID = @RecipeId
	group by r.RecipeName, c.CuisineName
	
	if @recipeinfo is null 
		begin 
			select @recipeinfo = 'Sorry there is no info recorded for this recipe (' + r.recipename +').'
			from Recipe r
			where r.RecipeID = @RecipeId
		end

	return @recipeinfo
end
go


/*
select dbo.FullRecipeInfo(r.RecipeID) as FullRecipeInfo, r.RecipeName, r.RecipeID
from Recipe r
*/