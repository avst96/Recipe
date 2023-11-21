use HeartyHearthDB
go

drop role if exists approle
go
create role approle
go

alter role approle add member appadmin_user
go


-- select concat('grant execute on ', r.ROUTINE_NAME, ' to approle')
-- from INFORMATION_SCHEMA.ROUTINES r 
-- where r.ROUTINE_NAME not like '%/_%' escape '/'

grant execute on RecipeIngredientGet to approle
grant execute on IngredientGet to approle
grant execute on UsersGet to approle
grant execute on UsersUpdate to approle
grant execute on CuisineUpdate to approle
grant execute on IngredientUpdate to approle
grant execute on DirectonsGet to approle
grant execute on MeasuringUnitUpdate to approle
grant execute on MeasuringUnitGet to approle
grant execute on CourseUpdate to approle
grant execute on DirectionsGet to approle
grant execute on CuisineGet to approle
grant execute on CookbookSummaryGet to approle
grant execute on RecipeUpdate to approle
grant execute on UsersDelete to approle
grant execute on CuisineDelete to approle
grant execute on IngredientDelete to approle
grant execute on RecipeIngredientDelete to approle
grant execute on MeasuringUnitDelete to approle
grant execute on CourseDelete to approle
grant execute on RecipeClone to approle
grant execute on RecipeDelete to approle
grant execute on CookbookGet to approle
grant execute on CaloriesPerMeal to approle
grant execute on CookbookAutoCreate to approle
grant execute on DirectionsDelete to approle
grant execute on CookbookRecipeGet to approle
grant execute on CookbookUpdate to approle
grant execute on CookbookDelete to approle
grant execute on FullRecipeInfo to approle
grant execute on RecipeIngredientUpdate to approle
grant execute on CookbookRecipeDelete to approle
grant execute on CookbookRecipeUpdate to approle
grant execute on DashboardGet to approle
grant execute on DirectionsUpdate to approle
grant execute on MealSummaryGet to approle
grant execute on RecipeSummaryGet to approle
grant execute on RecipeGet to approle
grant execute on CourseGet to approle