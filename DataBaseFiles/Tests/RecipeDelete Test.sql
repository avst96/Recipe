declare @recipeid int
select top 1 @recipeid = r.RecipeId
from Recipe r
--left
 join MealCourseRecipe mcr 
on r.RecipeID = mcr.RecipeID
--left
 join CookbookRecipe cr 
on r.RecipeID = cr.RecipeID
--where cr.CookbookRecipeID is null 
--and mcr.MealCourseRecipeID is null 



exec RecipeGet @recipeid = @recipeid 

exec RecipeDelete @recipeid = @recipeid

exec RecipeGet @recipeid = @recipeid 